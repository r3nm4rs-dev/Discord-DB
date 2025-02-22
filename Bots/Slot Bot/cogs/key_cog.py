from discord_slash import cog_ext, SlashContext, SlashCommandOptionType
from discord.ext import commands, tasks
from discord import Embed
from pymongo import MongoClient
import secrets
from datetime import datetime, timedelta
import config
import discord

class KeyCog(commands.Cog):
    def __init__(self, bot):
        self.bot = bot
        self.client = MongoClient(config.mongo_connection_string)  # Connect to your MongoDB server
        self.db = self.client[config.database_name]  # Use your database
        self.collection = self.db['keys']  # Use your collection

    async def log_command_use(self, ctx):
        log_channel_id = config.log_channel_id  # Get the log channel ID from your config
        log_channel = self.bot.get_channel(log_channel_id)  # Get the log channel object

        embed = discord.Embed(title=f"{ctx.command} Used", description=f"User: {ctx.author}\nGuild: {ctx.guild.name} ({ctx.guild.id})", color=discord.Color.green())
        await log_channel.send(embed=embed)

    @cog_ext.cog_slash(name="key",
                 options=[
                     {
                         "name": "amount",
                         "description": "Number of keys to generate",
                         "type": SlashCommandOptionType.INTEGER,
                         "required": True
                     },
                     {
                         "name": "duration",
                         "description": "Duration of the keys",
                         "type": SlashCommandOptionType.STRING,
                         "required": True,
                         "choices": [
                             {
                                 "name": "Week",
                                 "value": "Week"
                             },
                             {
                                 "name": "Month",
                                 "value": "Month"
                             },
                             {
                                 "name": "Lifetime",
                                 "value": "Lifetime"
                             }
                         ]
                     }
                 ])
    async def _key(self, ctx: SlashContext, amount: int, duration: str):
        desired_user_id = 1114234591939661834  # Replace with your desired user ID
        await self.log_command_use(ctx)
        if ctx.author.id != desired_user_id:
            await ctx.send("You are not authorized to use this command.")
            return
        new_keys = []
        for _ in range(amount):
            key = secrets.token_hex(16)
            new_keys.append(key)
            self.collection.insert_one({"key": key, "duration": duration})

        existing_keys = [f"```{doc['key']}```" for doc in self.collection.find()]
        existing_durations = [f"```{doc['duration']}```" for doc in self.collection.find()]

        embed1 = Embed(title="Existing Keys")
        embed1.add_field(name="Key", value="\n".join(existing_keys), inline=True)
        embed1.add_field(name="Duration", value="\n".join(existing_durations), inline=True)

        new_durations = [duration] * amount
        embed2 = Embed(title="New Keys")
        embed2.add_field(name="Key", value="\n".join(new_keys), inline=True)
        embed2.add_field(name="Duration", value="\n".join(new_durations), inline=True)

        await ctx.send(embeds=[embed1, embed2])

    @cog_ext.cog_slash(name="redeem",
                 options=[
                     {
                         "name": "key",
                         "description": "Key to redeem",
                         "type": SlashCommandOptionType.STRING,
                         "required": True
                     }
                 ])
    async def _redeem(self, ctx: SlashContext, key: str):
        await self.log_command_use(ctx)
        key_doc = self.collection.find_one({"key": key})
        if key_doc is None:
            await ctx.send("Invalid key.")
            return

        user_collection = self.db['USERS']
        user_doc = user_collection.find_one({"USERID": ctx.author.id})
        if user_doc is not None:
            await ctx.send("You have already redeemed a key.")
            return

        redeem_time = datetime.now()
        duration = key_doc['duration']
        if duration == "Week":
            expire_time = redeem_time + timedelta(weeks=1)
        elif duration == "Month":
            expire_time = redeem_time + timedelta(weeks=4)
        else:  # Lifetime
            expire_time = None

        user_collection.insert_one({"USERID": ctx.author.id, "KEY": key, "DURATION": duration, "REDEEM TIME": redeem_time, "EXPIRE TIME": expire_time})
        self.collection.delete_one({"key": key})

        await ctx.send("Key redeemed successfully.")

    @tasks.loop(minutes=1)
    async def check_expired_keys(self):
        user_collection = self.db['USERS']
        expired_users = user_collection.find({"EXPIRE TIME": {"$lt": datetime.now()}})
        for user in expired_users:
            member = self.bot.get_user(user['USERID'])
            if member is not None:
                await member.send("Your subscription has expired. Please renew it.")
            user_collection.delete_one({"USERID": user['USERID']})

    @commands.Cog.listener()
    async def on_ready(self):
        self.check_expired_keys.start()


def setup(bot):
    bot.add_cog(KeyCog(bot))