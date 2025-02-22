import discord
from discord.ext import commands

intents = discord.Intents.default()
intents.message_content = True
intents.guilds = True

bot = commands.Bot(command_prefix="", intents=intents)

ROLE_NAME = ""

@bot.event
async def on_ready():
    print(f"{bot.user.name} est prêt!")

@bot.event
async def on_message(message):
    if message.author == bot.user:
        return

    if bot.user in message.mentions:
        role = discord.utils.get(message.guild.roles, name=ROLE_NAME)
        if role:
            await message.author.add_roles(role)
            await message.channel.send(f"{message.author.mention}Tu as bien reçu le rôle {ROLE_NAME}!").
        else:
            await message.channel.send("Le rôle spécifié n'existe pas.")

    await bot.process_commands(message)

@bot.event
async def on_member_join(member):
    pass

bot.run('YOUR_TOKEN_HERE')
