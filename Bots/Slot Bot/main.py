import discord 
from config import Token
from discord import Activity, ActivityType, Status, Embed, PermissionOverwrite, Permissions
from discord.ext import commands, tasks
from discord_slash import SlashCommand, SlashContext
from discord_slash.utils.manage_commands import create_option, create_choice
from discord_slash.model import SlashMessage, SlashCommandPermissionType
from discord_slash.error import CheckFailure
from discord.errors import NotFound
import asyncio
from datetime import datetime, timedelta, timezone
from pytz import timezone
import pytz
import os
from termcolor import colored
from discord.ext import commands
import json
import time
import threading
from pymongo import MongoClient
import mysql.connector
import requests
import config

intents = discord.Intents(guilds=True)
client = commands.Bot(command_prefix='!', intents=intents)
slash = SlashCommand(client, sync_commands=True)
client.load_extension('cogs.key_cog')
client.load_extension('cogs.nuke_cog')
client.load_extension('cogs.backup')
client.load_extension('cogs.calculator_cog')
client.load_extension('cogs.buy_cog')

last_pings = {}
slots = {}

def reset_pings():
    stored_pings.clear()

# Create a datetime object
dt = datetime.now()

# Format the datetime as a MySQL-compatible string
dt_str = dt.strftime('%Y-%m-%d %H:%M:%S')

# Define the expiration date and time
expiration_date = dt.date()
expiration_time = dt.time()

# Define the MongoDB client
mongo_client = MongoClient(config.mongo_connection_string)
db = mongo_client[config.database_name]
pings_collection = db['pings']

@tasks.loop(hours=24)
async def reset_pings():
    try:
        # Delete all documents in the 'pings' collection
        result = pings_collection.delete_many({})
        print(f"Pings collection has been reset. Documents deleted: {result.deleted_count}")
    except Exception as e:
        print(f"An error occurred while resetting the pings collection: {e}")

@reset_pings.before_loop
async def before_reset_pings():
    await client.wait_until_ready()  # wait until the bot has connected to discord
    now = datetime.now(timezone('CET'))
    if now.hour < 0 or (now.hour == 0 and now.minute < 0):
        reset_time = now.replace(hour=0, minute=0, second=0, microsecond=0)
    else:
        reset_time = (now + timedelta(days=1)).replace(hour=0, minute=0, second=0, microsecond=0)
    seconds_until_reset = (reset_time - now).total_seconds()
    print(f"Seconds until reset: {seconds_until_reset}")
    await asyncio.sleep(seconds_until_reset)

reset_pings.start()  # start the task

# Connect to the MongoDB server
mongo_client = MongoClient(config.mongo_connection_string)

# Select the database
db = mongo_client["SlotBot"]

# Select the "slots" collection
slots = db["slots"]

@tasks.loop(seconds=20)
async def reset_ping_limits():
    try:
        # Get the current time in CET
        current_time = datetime.now(pytz.timezone('CET'))

        # Get the documents from the slots collection where end_time is not null
        rows = slots.find({"end_time": {"$ne": None}})

        # Loop through the rows and check if the end time is past the expiration time
        for row in rows:
            channel_id = row["1230262402692677724"]
            user_id = row["1114234591939661834"]
            end_time = datetime.strptime(row["end_time"], '%Y-%m-%d %H:%M:%S').astimezone(pytz.timezone('CET'))
            if end_time < current_time:
                # Send an embed message to the channel
                channel = client.get_channel(int(channel_id))
                if channel is not None:
                    print(f"Sending message to channel {channel_id}")
                    embed = discord.Embed(title="Subscription Ended", description=f"Your subscription has ended, <@{user_id}>.", color=discord.Color.red())
                    await channel.send(embed=embed)

                # Remove the write permission from the user
                user = await channel.guild.fetch_member(int(user_id))
                if user is not None:
                    overwrite = channel.overwrites_for(user)
                    overwrite.send_messages = False
                    await channel.set_permissions(user, overwrite=overwrite)

                # Delete the document from the collection
                slots.delete_one({"channel_id": channel_id, "user_id": user_id})
    except Exception as e:
        print(f"Error connecting to database: {e}")

reset_ping_limits.start()

current_activity = 0
embed_footer = {
    "text": "Pluzio Boost",
    "icon_url": ""
}
@tasks.loop(seconds=2)  # Run this task every 2 seconds
async def update_status():
    global current_activity

    mongo_client = MongoClient(config.mongo_connection_string)
    db = mongo_client[config.database_name]
    user_collection = db['slots']  # Use your collection

    guild_count = len(client.guilds)
    user_count = sum(guild.member_count for guild in client.guilds)
    
    # Query your slots database here and assign the result to `slots_count`
    slots_count = user_collection.count_documents({})  # Count all documents in the collection

    activities = [
        discord.Game(name=f'{guild_count} Servers'),
        discord.Game(name=f'{user_count} Users'),
        discord.Game(name=f'{slots_count} Slots'),
    ]

    await client.change_presence(activity=activities[current_activity], status=discord.Status.dnd)
    current_activity = (current_activity + 1) % len(activities)  # Move to the next activity

@client.event
async def on_ready():
    os.system('cls' if os.name == 'nt' else 'clear')  # Clear console

    ascii_art = """
      ____  _                 ____        _   
     / ___|| |__   ___  _ __ | __ )  ___ | |_ 
     \___ \| '_ \ / _ \| '_ \|  _ \ / _ \| __|
      ___) | | | | (_) | |_) | |_) | (_) | |_ 
     |____/|_| |_|\___/| .__/|____/ \___/ \__|
                       |_|                    
    """
    print(colored(ascii_art.center(os.get_terminal_size().columns), 'magenta'))  # Print ASCII art in purple and center it
    print(colored('By revilomm', 'yellow'))  # Print "By revilomm" in yellow

    update_status.start()  # Start the update_status task loop

@client.check
async def is_admin(ctx):
    return ctx.author.guild_permissions.administrator

stored_pings = {}
limits = {}
print(stored_pings)

class NotRegisteredError(commands.CommandError):
    pass

async def is_registered(ctx: SlashContext) -> bool:
    client = MongoClient(config.mongo_connection_string)  # Connect to your MongoDB server
    db = client[config.database_name]  # Use your database
    user_collection = db['USERS']  # Use your collection

    user_doc = user_collection.find_one({"USERID": ctx.author.id})
    if user_doc is None:
        raise NotRegisteredError('You are not registered to use this command')
    return True


@tasks.loop(seconds=60)  # Check every minute
async def check_slot_expirations():
    now = datetime.now(pytz.timezone('CET'))
    rows = slots.find()  # Get all documents from the slots collection
    for row in rows:  # Iterate over the documents
        user_id = row["_id"]
        end_time = datetime.strptime(row["end_time"], '%Y-%m-%d %H:%M:%S').astimezone(pytz.timezone('CET'))
        if now >= end_time:
            # Revoke access here
            slots.delete_one({"_id": user_id})  # Remove the document from the collection

# Start your background task here
check_slot_expirations.start()

# Define the expiration date and time
expiration_date = datetime.now().date()
expiration_time = datetime.now().time()

@slash.slash(name='slot', description='Create a slot channel with specified user access, duration, role, and category',
             options=[
                 create_option(
                     name='user',
                     description='The user to grant access',
                     option_type=6, # USER type
                     required=True
                 ),
                 create_option(
                     name='duration',
                     description='The duration of access (1 minute, 7 days, 30 days, or lifetime)',
                     option_type=3, # STRING type
                     required=True,
                     choices=[
                         create_choice(
                             name='1 minute',
                             value='1 minute'
                         ),
                         create_choice(
                             name='7 days',
                             value='7 days'
                         ),
                         create_choice(
                             name='30 days',
                             value='30 days'
                         ),
                         create_choice(
                             name='Lifetime',
                             value='lifetime'
                         )
                     ]
                 ),
                 create_option(
                     name='role',
                     description='The role to assign for access',
                     option_type=8, # ROLE type
                     required=True
                 ),
                 create_option(
                     name='category',
                     description='The category to create the channel in',
                     option_type=7, # CHANNEL type
                     required=True
                 ),
                 create_option(
                     name='verified',
                     description='Whether or not to require a verified role to access the channel',
                     option_type=5, # BOOLEAN type
                     required=True,
                     choices=[
                         create_choice(
                             name='Yes',
                             value='True'
                         ),
                         create_choice(
                             name='No',
                             value='False'
                         )
                     ]
                 ),
                 create_option(
                     name='channel_name',
                     description='The name of the channel to create (optional)',
                     option_type=3, # STRING type
                     required=False
                 )
             ])
@commands.check(is_admin)
@commands.check(is_registered)
async def slot(ctx: SlashContext, user: discord.Member, duration: str, role: discord.Role, category: discord.CategoryChannel, verified: bool = True, channel_name: str = None):
    try:
        await ctx.defer()
    except NotFound:
        pass
    guild = ctx.guild
    overwrites = {
        guild.default_role: discord.PermissionOverwrite(view_channel=False, send_messages=False),
        guild.me: discord.PermissionOverwrite(view_channel=True),
        user: discord.PermissionOverwrite(view_channel=True, send_messages=True)
    }
    if verified:
        verified_role = discord.utils.get(guild.roles, name='Verified')
        overwrites[verified_role] = discord.PermissionOverwrite(view_channel=True, send_messages=False)
    else:
        overwrites[guild.default_role] = discord.PermissionOverwrite(view_channel=True, send_messages=False)
    if channel_name is None:
        channel_name = f'{user.name}-slot'
    try:
        channel = await category.create_text_channel(channel_name, overwrites=overwrites, reason=f'Slot channel created ({duration})')
        await ctx.channel.send(f"Channel {channel.mention} was successfully created.")
    except Exception as e:
        await ctx.channel.send(f"An error occurred while creating the channel: {e}")
        return

    # Write user id and slot end time to database
    dt = datetime.now(pytz.timezone('CET'))
    end_time = dt + timedelta(seconds=get_duration_in_seconds(duration))

    # Write user id and slot end time to MongoDB
    end_time_str = end_time.strftime('%Y-%m-%d %H:%M:%S')
    slot = {"channel_id": str(channel.id), "user_id": str(user.id), "end_time": end_time_str}
    slots.insert_one(slot)

    if duration == 'lifetime':
        duration_str = 'Lifetime'
    else:
        duration_seconds = get_duration_in_seconds(duration)
        end_time = datetime.now(pytz.timezone('CET')) + timedelta(seconds=duration_seconds)
        duration_str = f'{duration} ({end_time.strftime("%Y-%m-%d %H:%M:%S")})'

    # Create the first embed
    embed1 = Embed(title="<a:yes:1187684309973352518>Slot Channel Created<a:yes:1187684309973352518>", description=f"Duration: {duration_str}", color=0x08F55B)
    embed1.add_field(name="User", value=user.mention)
    embed1.add_field(name="Channel", value=channel.mention)

    # Create the second embed
    embed2 = Embed(title="RULES", description="➥ 2 here ping per day.\n➥ No everyone Ping or role ping.\n➥ No Refund on private slot.\n➥ You can't sell your slot.\n➥ You can't share your slot.\n➥ Any Kind of promotion is not allowed.\n➥ Gambling/Money doubling not allowed.\n➥ If u have any report on scammeralert then i will hold ure slot", color=0xF50841)
    embed2.set_footer(**embed_footer)
    await channel.send(embed=embed1)
    await channel.send(embed=embed2)

    # Assign the specified role to the user
    try:
        if ctx.guild.me.top_role.position > role.position:
            await user.add_roles(role)
        else:
            await ctx.send("My highest role is lower than the role I'm trying to assign.")
    except Exception as e:
        try:
            await ctx.send(f"An error occurred while assigning the role: {e}")
        except NotFound:
            pass

def get_duration_in_seconds(duration: str) -> int:
    if duration == '1 minute':
        return 40
    elif duration == '7 days':
        return 7 * 24 * 60 * 60
    elif duration == '30 days':
        return 30 * 24 * 60 * 60
    else:
        return 0

################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################

@slash.slash(name='renew', description='Renew a slot channel with specified user access and duration',
             options=[
                 create_option(
                     name='user',
                     description='The user to renew access',
                     option_type=6,  # USER type
                     required=True
                 ),
                 create_option(
                     name='duration',
                     description='The duration of renewed access (1 minute, 7 days, 30 days, or lifetime)',
                     option_type=3,  # STRING type
                     required=True,
                     choices=[
                         create_choice(
                             name='1 minute',
                             value='1 minute'
                         ),
                         create_choice(
                             name='7 days',
                             value='7 days'
                         ),
                         create_choice(
                             name='30 days',
                             value='30 days'
                         ),
                         create_choice(
                             name='Lifetime',
                             value='lifetime'
                         )
                     ]
                 ),
                 create_option(
                     name='channel',
                     description='The channel to renew access',
                     option_type=7,  # CHANNEL type
                     required=True
                 )
             ])
async def renew(ctx: SlashContext, user: discord.Member, duration: str, channel: discord.TextChannel):
    await ctx.defer()

    if not is_admin(ctx) or not is_registered(ctx):
        return

    # Fetch the existing slot for the user from the database
    slot = slots.find_one({"user_id": str(user.id)})
    if slot is None:
        # If no slot found for the user, create a new one
        dt = datetime.now(pytz.timezone('CET'))
        end_time = dt + timedelta(seconds=get_duration_in_seconds(duration))
        end_time_str = end_time.strftime('%Y-%m-%d %H:%M:%S')
        slots.insert_one({"channel_id": str(channel.id), "user_id": str(user.id), "end_time": end_time_str})
        await ctx.send('New slot created for the user', hidden=True)
    else:
        # If a slot is found, renew it
        dt = datetime.now(pytz.timezone('CET'))
        end_time = dt + timedelta(seconds=get_duration_in_seconds(duration))
        end_time_str = end_time.strftime('%Y-%m-%d %H:%M:%S')
        slots.update_one({"user_id": str(user.id)}, {"$set": {"end_time": end_time_str}})

    # Create the embed message
    embed = Embed(title="<a:yes:1187684309973352518>Slot Channel Renewed<a:yes:1187684309973352518>", description=f"Duration: {duration}", color=0x08F55B)
    embed.add_field(name="User", value=user.mention)
    await ctx.send(embed=embed)

    # Schedule a task to revoke access when the slot expires
    if duration != 'lifetime':
        await asyncio.sleep(get_duration_in_seconds(duration))
        try:
            await channel.set_permissions(user, send_messages=False, reason='Slot channel access revoked')
        except Exception as e:
            await ctx.send(f"An error occurred while revoking access: {e}")
            return

################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################

@slash.slash(name='revoke', description='Revoke access to a slot channel and schedule its deletion',
             options=[
                 create_option(
                     name='channel',
                     description='The channel to revoke access to',
                     option_type=7, # CHANNEL type
                     required=True
                 )
             ])
@commands.check(is_admin)
async def revoke(ctx: SlashContext, channel: discord.TextChannel):
    try:
        await ctx.defer()
    except NotFound:
        pass

    # Fetch the user who has access to the channel
    overwrites = channel.overwrites
    user = None
    for target, permissions in overwrites.items():
        if isinstance(target, discord.Member) and permissions.view_channel:
            user = target
            break

    if user is None:
        await ctx.send('No user found with access to this channel')
        return

    # Remove the user's access to the channel
    await channel.set_permissions(user, view_channel=False, send_messages=False, reason='Access revoked')

    # Send an embed message to the channel
    embed = Embed(title="Channel Revoked", description="This channel has been revoked and will be deleted in 24 hours", color=0xF50841)
    await channel.send(embed=embed)

    # Schedule a task to delete the channel from the server and the database after 24 hours
    await asyncio.sleep(24 * 60 * 60)
    await channel.delete(reason='Channel access was revoked')
    slots.delete_one({"channel_id": str(channel.id)})

################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################

@slash.slash(name='remove', description='Delete a specified channel',
             options=[
                 create_option(
                     name='channel',
                     description='The channel to delete',
                     option_type=7, # CHANNEL type
                     required=True
                 )
             ])
@commands.check(is_admin)
@commands.check(is_registered)
async def remove(ctx: SlashContext, channel: discord.TextChannel):
    try:
        await channel.delete()
        embed = discord.Embed(title='<a:on:1187684363186483210>Channel Deleted<a:on:1187684363186483210>', description=f'The channel {channel.mention} has been deleted.', color=0xF50841)
        embed.set_footer(**embed_footer)
        await ctx.send(embed=embed)
    except Exception as e:
        await ctx.send(f"An error occurred while deleting the channel: {e}")

################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################

# Connect to your MongoDB database
mongo_client = MongoClient(config.mongo_connection_string)
db = mongo_client[config.database_name]
collection = db['limits']

# Load the limits from MongoDB on startup
limits = {}
for doc in collection.find():
    guild_id = doc['guild_id']
    limits[guild_id] = doc
    del limits[guild_id]['guild_id']  # Remove the guild_id from the limits dictionary

@slash.slash(name='limits', description='Set the maximum ping limits for each role',
             options=[
                 create_option(
                     name='lifetime_everyone_limit',
                     description='The maximum number of @everyone pings allowed for Lifetime role',
                     option_type=4,  # INTEGER type
                     required=True
                 ),
                 create_option(
                     name='lifetime_here_limit',
                     description='The maximum number of @here pings allowed for Lifetime role',
                     option_type=4,  # INTEGER type
                     required=True
                 ),
                 create_option(
                     name='month_everyone_limit',
                     description='The maximum number of @everyone pings allowed for Month role',
                     option_type=4,  # INTEGER type
                     required=True
                 ),
                 create_option(
                     name='month_here_limit',
                     description='The maximum number of @here pings allowed for Month role',
                     option_type=4,  # INTEGER type
                     required=True
                 ),
                 create_option(
                     name='week_everyone_limit',
                     description='The maximum number of @everyone pings allowed for Week role',
                     option_type=4,  # INTEGER type
                     required=True
                 ),
                 create_option(
                     name='week_here_limit',
                     description='The maximum number of @here pings allowed for Week role',
                     option_type=4,  # INTEGER type
                     required=True
                 )
             ])
@commands.has_permissions(administrator=True)
@commands.check(is_registered)
async def limits(ctx: SlashContext, lifetime_everyone_limit: int, lifetime_here_limit: int, month_everyone_limit: int, month_here_limit: int, week_everyone_limit: int, week_here_limit: int):
    ctx.send('Setting ping limits...')
    guild_id = ctx.guild.id
    limits = {
        'max_pings': {
            'Top Lifetime': {'@everyone': lifetime_everyone_limit, '@here': lifetime_here_limit},
            'Lifetime': {'@everyone': month_everyone_limit, '@here': month_here_limit},
            'Month/Week': {'@everyone': week_everyone_limit, '@here': week_here_limit}
        },
        'max_here_pings': {
            'Top Lifetime': lifetime_here_limit,
            'Lifetime': month_here_limit,
            'Month/Week': week_here_limit
        },
    }
    collection.update_one({'guild_id': guild_id}, {'$set': limits}, upsert=True)
    embed = discord.Embed(title='<a:yes:1187684309973352518>Ping Limits Set<a:yes:1187684309973352518>', description=f'Maximum ping limits have been set:\nLifetime: @everyone: {lifetime_everyone_limit}, @here: {lifetime_here_limit}\nMonth: @everyone: {month_everyone_limit}, @here: {month_here_limit}\nWeek: @everyone: {week_everyone_limit}, @here: {week_here_limit}', color=0x08F55B)
    embed.set_footer(**embed_footer)
    await ctx.send(embed=embed)
# Connect to your MongoDB database
mongo_client = MongoClient(config.mongo_connection_string)
db = mongo_client[config.database_name]
collection = db['limits']

# Initialize the limits dictionary at the top of the file
limits = {}

# Load the limits from MongoDB on startup
for doc in collection.find():
    guild_id = doc['guild_id']
    limits[guild_id] = doc
    del limits[guild_id]['guild_id']  # Remove the guild_id from the limits dictionary

# Load the limits from MongoDB on startup
for doc in collection.find():
    guild_id = doc['guild_id']
    limits[guild_id] = {
        'Lifetime': {'@everyone': doc.get('Lifetime', {}).get('@everyone', 0), '@here': doc.get('Lifetime', {}).get('@here', 0)},
        'Month': {'@everyone': doc.get('Month', {}).get('@everyone', 0), '@here': doc.get('Month', {}).get('@here', 0)},
        'Week': {'@everyone': doc.get('Week', {}).get('@everyone', 0), '@here': doc.get('Week', {}).get('@here', 0)},
    }

################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################

# Connect to your MongoDB database
mongo_client = MongoClient(config.mongo_connection_string)
db = mongo_client[config.database_name]
pings_collection = db['pings']
limits_collection = db['limits']  # Connect to the limits collection

@slash.slash(name='ping', description='Ping @here or @everyone', options=[
    create_option(
        name='ping_type',
        description='The type of ping to send',
        option_type=3,
        required=True,
        choices=[
            create_choice(name='@here', value='@here'),
            create_choice(name='@everyone', value='@everyone')
        ]
    )
])
async def ping(ctx: SlashContext, ping_type: str):
    await ctx.defer()
    guild_id = ctx.guild.id
    user_id = str(ctx.author.id)

    # Remove the '@' from the ping_type for database operations
    ping_type_without_at = ping_type.replace('@', '')

    # Use ping_type_without_at instead of ping_type when interacting with the database
    user_pings = pings_collection.find_one({'guild_id': guild_id, 'user_id': user_id})
    if user_pings is None:
        user_pings = {    ping_type_without_at: {'used_pings': 0}}
        pings_collection.insert_one({'guild_id': guild_id, 'user_id': user_id, 'pings': user_pings})

    # Fetch the limits for this guild from the limits collection
    guild_limits_doc = limits_collection.find_one({'guild_id': guild_id})
    if guild_limits_doc is None:
        await ctx.send("This guild does not have any ping limits set.")
        return

    # Get the user roles
    user_roles = [role.name for role in ctx.author.roles]

    # Initialize max_pings_allowed to None
    max_pings_allowed = None

    # Check each role in ['Lifetime', 'Month', 'Week']
    for role in ['Top Lifetime', 'Lifetime', 'Month/Week']:
        # If the role is in user_roles and in guild_limits_doc
        if role in user_roles and role in guild_limits_doc['max_pings']:
            # If ping_type is in guild_limits_doc['max_pings'][role]
            if ping_type in guild_limits_doc['max_pings'][role]:
                # Set max_pings_allowed to the value of guild_limits_doc['max_pings'][role][ping_type]
                max_pings_allowed = guild_limits_doc['max_pings'][role][ping_type]
                break

    # If max_pings_allowed is still None, send an error message
    if max_pings_allowed is None:
        embed = discord.Embed(title='<a:off:1187684352579076136>Ping Error<a:off:1187684352579076136>', description='You do not have permission to use this command', color=0xF50841)
        embed.set_footer(**embed_footer)
        await ctx.send(embed=embed)
        return

    # Fetch the document
    user_pings = pings_collection.find_one({'guild_id': guild_id, 'user_id': user_id})

    # If the document does not exist or does not have a 'pings' field, initialize it
    if user_pings is None or 'pings' not in user_pings:
        user_pings = {'pings': {ping_type_without_at: {'used_pings': 0}}}
        pings_collection.insert_one({'guild_id': guild_id, 'user_id': user_id, 'pings': user_pings['pings']})

    # Now you can safely access 'pings'
    used_pings = user_pings['pings'][ping_type_without_at]['used_pings'] if ping_type_without_at in user_pings['pings'] else 0


    # Check if the user has reached their limit
    if used_pings >= max_pings_allowed:
        # Send a message to the user and return
        embed = discord.Embed(title='<a:off:1187684352579076136>Ping Error<a:off:1187684352579076136>', description='You have reached your ping limit', color=0xF50841)
        embed.set_footer(**embed_footer)
        await ctx.send(embed=embed)
    else:    
    # If the user has not reached their limit, increment the used pings
        used_pings += 1

        # Update the 'used_pings' field in the 'user_pings' dictionary
        user_pings[ping_type_without_at] = {'used_pings': used_pings}

        # Increment the 'used_pings' field in the database
        pings_collection.update_one(
            {'guild_id': guild_id, 'user_id': user_id},
            {'$inc': {
                f'pings.{ping_type_without_at}.used_pings': 1
            }},
            upsert=True
        )
        
        # Send the ping message with the '@'
        await ctx.channel.send(ping_type)

        # Fetch the updated document
        user_pings = pings_collection.find_one({'guild_id': guild_id, 'user_id': user_id})

        # Calculate the remaining pings
        remaining_pings = max_pings_allowed - used_pings

        # Get the current number of used pings for this ping type
        used_pings = user_pings['pings'][ping_type_without_at]['used_pings']

        # Calculate the time until the next reset
        now = datetime.now(pytz.timezone('CET'))
        if now.hour < 0 or (now.hour == 0 and now.minute < 0):
            reset_time = now.replace(hour=0, minute=0, second=0, microsecond=0)
        else:
            reset_time = (now + timedelta(days=1)).replace(hour=0, minute=0, second=0, microsecond=0)
        time_until_reset = reset_time - now

        # Format the timedelta into a string
        hours, remainder = divmod(time_until_reset.seconds, 3600)
        minutes, _ = divmod(remainder, 60)
        time_until_reset_str = f'{hours}h {minutes}m'

        # Send a message to the user about their used pings
        embed = discord.Embed(title='<a:on:1167110696333476001>Ping Successful<a:on:1167110696333476001>', description=f'You have {used_pings}/{max_pings_allowed}{ping_type} pings┃**Use MM**', color=0xA608F5)
        embed.set_footer(text=f'YOUR TEXT ┃Time until reset: {time_until_reset_str}', icon_url='https://cdn.discordapp.com/attachments/1207680720311689226/1207693633176993802/Comp_9.gif?ex=65e09358&is=65ce1e58&hm=31520c9aea4a99f693e776d8d49e74518d76cc45393a07bdf334c7cd6c15d2c8&')
        await ctx.send(embed=embed)


################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################


@slash.slash(name='reset', description='Reset ping limits for a user',
             options=[
                 create_option(
                     name='ping_type',
                     description='The type of ping to reset',
                     option_type=3,
                     required=True,
                     choices=[
                         create_choice(name='here', value='here'),
                         create_choice(name='everyone', value='everyone')
                     ]
                 ),
                 create_option(
                     name='user',
                     description='The user to reset ping limits for',
                     option_type=6, # USER type
                     required=True
                 )
             ])
@commands.has_permissions(administrator=True)
@commands.check(is_registered)
async def reset(ctx: SlashContext, ping_type: str, user: discord.User):
    guild_id = ctx.guild.id
    user_id = str(user.id)
    if guild_id in stored_pings and user_id in stored_pings[guild_id]:
        # Reset the used pings in the stored_pings dictionary
        stored_pings[guild_id][user_id][ping_type]['used_pings'] = 0
    else:
        print(f'User {user_id} in guild {guild_id} not found in memory. Checking database...')

    # Reset the used pings in the database
    result = pings_collection.update_one(
        {'guild_id': guild_id, 'user_id': user_id},
        {'$set': {f'pings.{ping_type}.used_pings': 0}}
    )
    if result.modified_count > 0:
        print(f'Reset pings for user {user_id} in guild {guild_id} in database.')
        embed = discord.Embed(title='<a:on:1187684363186483210>Ping Limits Reset<a:on:1187684363186483210>', description=f'@{ping_type} ping limits have been reset for {user.mention}', color=0x00ff00)
        await ctx.send(embed=embed)
    else:
        print(f'User {user_id} in guild {guild_id} has not used any pings yet.')
        embed = discord.Embed(title='<a:off:1187684352579076136>Ping Limits Reset<a:off:1187684352579076136>', description=f'{user.mention} has not used any @{ping_type} pings yet', color=0x00ff00)
        await ctx.send(embed=embed)

################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################

@slash.slash(name='purge', description='Delete a specified number of messages from the current channel',
             options=[
                 create_option(
                     name='amount',
                     description='The number of messages to delete',
                     option_type=4, # INTEGER type
                     required=True
                 )
             ])
@commands.has_permissions(administrator=True)
async def purge(ctx: SlashContext, amount: int):
    channel = ctx.channel
    messages = await channel.history(limit=amount + 1).flatten()
    try:
        await channel.delete_messages(messages)
        await asyncio.sleep(3) # Wait for 3 seconds before sending the embed
        embed = discord.Embed(title='<a:alert:1167110542670962739>Purge<a:alert:1167110542670962739>', description=f'{amount} messages deleted by {ctx.author.mention}', color=0xF50841)
        await ctx.channel.send(embed=embed)
    except Exception as e:
        await ctx.send(f"An error occurred while purging messages: {e}")

async def reset_ping_limits():
    global last_pings
    while True:
        now = datetime.now()
        if now.hour == 0 and now.minute == 0:
            last_pings = {}
        await asyncio.sleep(60) # Check every minute

################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################

@slash.slash(name='getbal', description='Get the balance of a Litecoin address',
             options=[
                 create_option(
                     name='ltc_addy',
                     description='The Litecoin address to check',
                     option_type=3,  # STRING type
                     required=True
                 )
             ])
async def getbal(ctx: SlashContext, ltc_addy: str):
    # Fetch the balance in LTC
    response = requests.get(f'https://api.blockcypher.com/v1/ltc/main/addrs/{ltc_addy}/balance')
    response.raise_for_status()  # Raise an exception if the request failed
    balance_ltc = response.json()['balance'] / 1e8  # Convert from satoshis to LTC

    # Fetch the current LTC/EUR exchange rate
    response = requests.get('https://api.coingecko.com/api/v3/simple/price?ids=litecoin&vs_currencies=eur')
    response.raise_for_status()  # Raise an exception if the request failed
    rate_eur = response.json()['litecoin']['eur']

    # Convert the balance to EUR
    balance_eur = balance_ltc * rate_eur

    # Create an embed and send it
    embed = discord.Embed(title='Litecoin Balance', color=0x5E08F5)
    embed.add_field(name='<:stats:1167110536849264680>Address', value=ltc_addy, inline=False)
    embed.add_field(name='<:ltc:1167110574426050662>Balance (LTC)', value=str(balance_ltc), inline=True)
    embed.add_field(name='<a:pay:1167110578712629298>Balance (EUR)', value=f"{balance_eur:.2f}", inline=True)  # Format to 2 decimal places
    embed.set_footer(**embed_footer)
    await ctx.send(embed=embed)

################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################
################################################################################################################

@slash.slash(name='help', description='Provides help for commands')
async def help(ctx: SlashContext):
    embed1 = discord.Embed(title="Slot Commands", description="", color=0xA608F5)
    embed1.add_field(name="/slot", value="Creates a Slot for desired User, Time and asigns Role to the user", inline=False)
    embed1.add_field(name="/remove", value="Deletes a Slot Channel", inline=False)
    embed1.add_field(name="/ping", value="Pings @here or @everyone and counts pings for user", inline=False)
    embed1.add_field(name="/reset", value="Resets ping count for a user", inline=False)
    embed1.add_field(name="/limits", value="Sets ping limits for each role", inline=False)
    await ctx.channel.send(embed=embed1)

    embed2 = discord.Embed(title="Utility Commands", description="", color=0xA608F5)
    embed2.add_field(name="/getbal", value="Gets the balance of a Litecoin address", inline=False)
    embed2.add_field(name="/purge", value="Deletes a specified number of messages from the current channel", inline=False)
    embed2.add_field(name="/help", value="Provides help for commands", inline=False)
    embed2.add_field(name="/nuke", value="Nukes a desired channel", inline=False)
    await ctx.channel.send(embed=embed2)

    embed3 = discord.Embed(title="Key System", description="", color=0xA608F5)
    embed3.add_field(name="/key", value="Generates a Key.", inline=False)
    embed3.add_field(name="/redeem", value="Redeems a Key", inline=False)
    await ctx.channel.send(embed=embed3)


client.run(Token)