import discord
from discord.ext import commands

intents = discord.Intents.default()
intents.message_content = True
intents.guilds = True

bot = commands.Bot(command_prefix="?", intents=intents)

ROLE_NAME = "" # Name of the role to give

@bot.event
async def on_ready():
    print(f"{bot.user.name} is online!")

@bot.event
async def on_message(message):
    if message.author == bot.user:
        return

    if bot.user in message.mentions:
        role = discord.utils.get(message.guild.roles, name=ROLE_NAME)
        if role:
            await message.author.add_roles(role)
            await message.channel.send(f"{message.author.mention} I gave you the role {ROLE_NAME}!")
        else:
            await message.channel.send("The given role don't exist.")

    await bot.process_commands(message)

@bot.event
async def on_member_join(member):
    pass

bot.run('YOUR_TOKEN_HERE')
