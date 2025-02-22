import os
import discord 
from discord_slash import cog_ext, SlashContext
from discord.ext import commands, tasks
from pymongo import MongoClient
from discord_slash.utils.manage_commands import create_option, SlashCommandOptionType
import time
from discord import Colour, PermissionOverwrite, Embed
from bson.binary import Binary
import pickle
from discord_slash.error import CheckFailure
import asyncio
import ast
import requests
import config
from datetime import datetime, timedelta

async def is_admin(ctx):
    return ctx.author.guild_permissions.administrator

class NotRegisteredError(commands.CommandError):
    pass

async def is_registered(ctx: SlashContext) -> bool:
    client = MongoClient(config.mongo_connection_string)  # Connect to your MongoDB server
    db = client[config.database_name]  # Use your database
    user_collection = db['USERS']  # Use your collection

    user_doc = user_collection.find_one({"USERID": ctx.author.id})
    if user_doc is None:
        raise NotRegisteredError("You are not registered to use this command")
    return True

def serialize_overwrites(overwrites):
    serialized = {}
    for target, overwrite in overwrites.items():
        permissions = {}
        allow, deny = overwrite.pair()
        for name, value in allow:
            if value:  # if permission is allowed
                permissions[name] = 'Allow'
        for name, value in deny:
            if value:  # if permission is denied
                permissions[name] = 'Deny'
        serialized[target.name] = {'role': isinstance(target, discord.Role), 'permissions': permissions}
    return serialized

def deserialize_overwrites(bot, guild, serialized):
    overwrites = {}
    for target_name, data in serialized.items():
        target = discord.utils.get(guild.members, name=target_name) if not data['role'] else discord.utils.get(guild.roles, name=target_name)
        if target is not None:
            allow = discord.Permissions()
            deny = discord.Permissions()
            for name, value in data['permissions'].items():
                if value == 'Allow':
                    setattr(allow, name, True)
                    setattr(deny, name, False)
                elif value == 'Deny':
                    setattr(allow, name, False)
                    setattr(deny, name, True)
            overwrites[target] = discord.PermissionOverwrite.from_pair(allow, deny)
    return overwrites


class BackupCog(commands.Cog):
    def __init__(self, bot):
        self.bot = bot
        self.client = MongoClient(config.mongo_connection_string)
        self.db = self.client[config.database_name]
        self.collection = self.db['backups']
        self.autosave_collection = self.db['autosaves']

    async def log_command_use(self, ctx):
        log_channel_id = config.log_channel_id  # Get the log channel ID from your config
        log_channel = self.bot.get_channel(log_channel_id)  # Get the log channel object

        embed = discord.Embed(title=f"{ctx.command} Used", description=f"User: {ctx.author}\nGuild: {ctx.guild.name} ({ctx.guild.id})", color=discord.Color.green())
        await log_channel.send(embed=embed)

    @cog_ext.cog_slash(name="backup", description='It will save all roles, categories, channels, messages on your server.', options=[
        create_option(
            name="name",
            description="Name of the backup",
            option_type=SlashCommandOptionType.STRING,
            required=True
        )
    ])
    async def _backup(self, ctx: SlashContext, name: str):
        await self.log_command_use(ctx)
        async def _backup(self, ctx: SlashContext, name: str):
            if not await is_admin(ctx) or not await is_registered(ctx):
                return
        # Send an initial response
        await ctx.send(content="Creating backup...", hidden=True)
        guild = self.bot.get_guild(ctx.guild_id)  # Define guild
        data = {'name': name, 'channels': [], 'roles': [], 'categories': [], 'emojis': []}

        # For roles
        for role in sorted(guild.roles, key=lambda role: role.position):
            role_data = {
                'name': role.name,
                'color': role.color.value,
                'permissions': role.permissions.value,  # Save permissions
                'mentionable': role.mentionable,  # Save if the role is mentionable
                'hoist': role.hoist,  # Save if the role is displayed separately
                'position': role.position  # Save the position of the role
            }
            data['roles'].append(role_data)

        # For categories
        for category in sorted(guild.categories, key=lambda category: category.position):
            category_data = {
                'name': category.name,
                'permissions': serialize_overwrites(category.overwrites),  # Save permissions
                'position': category.position  # Save the position of the category
            }
            data['categories'].append(category_data)

        # For channels
        for channel in sorted(guild.channels, key=lambda channel: channel.position):
            if isinstance(channel, discord.TextChannel):
                messages = []
                async for msg in channel.history(limit=100):
                    message_data = {
                        'content': msg.content,
                        'author': msg.author.name,
                        'avatar_url': str(msg.author.avatar_url),
                        'embeds': [embed.to_dict() for embed in msg.embeds],  # Save embeds
                        'attachments': [attachment.url for attachment in msg.attachments],  # Save attachments
                        'bot': msg.author.bot  # Save if the message was sent by a bot
                    }
                    messages.append(message_data)
                channel_data = {
                    'name': channel.name,
                    'category_name': channel.category.name if channel.category else None,
                    'messages': messages,
                    'type': str(channel.type),
                    'category': channel.category.name if channel.category else None,
                    'permissions': serialize_overwrites(channel.overwrites),  # Save permissions
                    'position': channel.position  # Save the position of the channel
                }
                data['channels'].append(channel_data)
        
        # For emojis
        for emoji in guild.emojis:
            emoji_data = {
                'name': emoji.name,
                'image': str(emoji.url),
                'roles': [role.name for role in emoji.roles]  # Save roles that can use this emoji
            }
            data['emojis'].append(emoji_data)

        # Update the database
        result = self.collection.update_one({'name': name}, {'$set': data}, upsert=True)
        await ctx.send(content="Backup saved successfully.", hidden=True)

    @cog_ext.cog_slash(name="loadbackup", description='It will load all roles, categoryes, channels, messages from backup you saved before.', options=[
     create_option(
          name="name",
          description="Name of the backup to load",
           option_type=SlashCommandOptionType.STRING,
          required=True
      )
    ])
    async def _loadbackup(self, ctx: SlashContext, name: str):
        await self.log_command_use(ctx)
        await ctx.defer(hidden=True)
        if not await is_admin(ctx) or not await is_registered(ctx):
            return
        start_time = time.time()
        data = self.collection.find_one({'name': name})
        if data is None:
            await ctx.send(content='No backup found with this name.', hidden=True)
            return
        guild = self.bot.get_guild(ctx.guild_id)

        # Create roles
        for role_data in reversed(sorted(data['roles'], key=lambda role_data: role_data['position'])):
            if not discord.utils.get(guild.roles, name=role_data['name']):
                await guild.create_role(name=role_data['name'], color=Colour(role_data['color']), permissions=discord.Permissions(role_data['permissions']), mentionable=role_data['mentionable'], hoist=role_data['hoist'])

        # Create categories
        category_objects = {}  # Define the category_objects dictionary
        for category_data in sorted(data['categories'], key=lambda category_data: category_data['position']):
            if not discord.utils.get(guild.categories, name=category_data['name']):
                overwrites = deserialize_overwrites(self.bot, guild, category_data['permissions'])
                category = await guild.create_category_channel(category_data['name'], overwrites=overwrites)
                await category.edit(position=category_data['position'])
                category_objects[category_data['name']] = category  # Add the created category to the dictionary

        # Create channels
        channel_objects = {} 
        for channel_data in sorted(data['channels'], key=lambda channel_data: channel_data['position']):
            if not discord.utils.get(guild.channels, name=channel_data['name']):
                overwrites = deserialize_overwrites(self.bot, guild, channel_data['permissions'])
                category = category_objects.get(channel_data['category_name'])
                channel = await guild.create_text_channel(channel_data['name'], category=category, overwrites=overwrites)
                await channel.edit(position=channel_data['position'])
                channel_objects[channel_data['name']] = channel  # Add the created channel to the dictionary

        # Send messages to channels
        for channel_data in data['channels']:
            channel = channel_objects.get(channel_data['name'])
            if channel:
                webhook = await channel.create_webhook(name='Backup')
                for msg in channel_data['messages']:
                    if msg['content'] or msg['embeds'] or msg['attachments']:
                        # Create embeds
                        embeds = [discord.Embed.from_dict(embed_dict) for embed_dict in msg['embeds']]
                        # Create content
                        content = msg['content']
                        if msg['bot']:
                            content = f"[Bot] {msg['author']}: {msg['content']}"
                        for attachment_url in msg['attachments']:
                            content += f"\n{attachment_url}"
                        await webhook.send(content=content, username=msg['author'], avatar_url=msg['avatar_url'], embeds=embeds)
                        await asyncio.sleep(2)  # Add a delay of 2 seconds between each message

        # Create emojis
        for emoji_data in data['emojis']:
            if not discord.utils.get(guild.emojis, name=emoji_data['name']):
                response = requests.get(emoji_data['image'])
                emoji = await guild.create_custom_emoji(name=emoji_data['name'], image=response.content, roles=emoji_data['roles'])

        end_time = time.time()
        message = f"Backup loaded successfully in {end_time - start_time:.2f} seconds."
        await ctx.send(content=message)

    @cog_ext.cog_slash(name="autobackup", description='It will automatically backup your server in desired time frame.', options=[
        create_option(
            name="hours",
            description="Timeframe for autosave in hours",
            option_type=SlashCommandOptionType.INTEGER,
            required=True
        ),
        create_option(
            name="name",
            description="Name of the backup",
            option_type=SlashCommandOptionType.STRING,
            required=True
        )
    ])
    async def _autosave(self, ctx: SlashContext, hours: int, name: str):
        await self.log_command_use(ctx)
        if not await is_admin(ctx) or not await is_registered(ctx):
            return
        # Store the autosave settings in the database
        context_data = {'user_id': ctx.author.id, 'guild_id': ctx.guild_id}
        self.autosave_collection.update_one({'guild_id': ctx.guild_id}, {'$set': {'hours': hours, 'name': name, 'context': context_data}}, upsert=True)
        self.backup.start(ctx, hours, name)

    @tasks.loop(minutes=1)  # check every minute
    async def check_autosave(self):
        now = datetime.now()
        for autosave in self.autosave_collection.find():
            last_backup_time = autosave.get('last_backup_time')
            if last_backup_time is None or now - last_backup_time > timedelta(hours=autosave['hours']):
                guild = self.bot.get_guild(autosave['guild_id'])
                if guild and guild.system_channel and guild.system_channel.last_message:
                    ctx = await self.bot.get_context(guild.system_channel.last_message)
                    await self._backup(ctx, autosave['name'])
                    self.autosave_collection.update_one({'guild_id': autosave['guild_id']}, {'$set': {'last_backup_time': now}})

    @commands.Cog.listener()
    async def on_ready(self):
        self.check_autosave.start()

def setup(bot):
    bot.add_cog(BackupCog(bot))