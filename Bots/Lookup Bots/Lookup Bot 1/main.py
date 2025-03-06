import discord
from discord.ext import commands
import aiohttp
import requests
import re
import typing
import instaloader
from requests.exceptions import HTTPError, SSLError, RequestException
from urllib3.exceptions import InsecureRequestWarning
import warnings

DISCORD_TOKEN = "Bot Token"

intents = discord.Intents.default()
intents.typing = False
intents.message_content = True
warnings.filterwarnings("ignore", category=InsecureRequestWarning)
requests.packages.urllib3.disable_warnings(InsecureRequestWarning)

bot_prefix = "!"
bot = commands.Bot(command_prefix=bot_prefix, intents=intents)
bot.remove_command('help')

command_list = [
    ("profil <identifiant>", "Affiche les informations Discord de l'utilisateur."),
    ("checku <username>", "Vérifie le nom d'utilisateur sur plusieurs sites."),
    ("igu <username>", "Donne les informations en détail d'un profil Instagram."),
    ("ip <ip>", "Donne les informations de l'adresse IP."),
    ("clear <nombre>/<all>", "Supprime un certain nombre de messages ou tout.")
]

@bot.event
async def on_ready():
    print(f"Connecté en tant que {bot.user.name}")

@bot.command(name='help')
async def list_commands(ctx):
    embed = discord.Embed(title="Liste des Commandes Disponibles", description="Voici toutes les commandes que vous pouvez utiliser avec ce bot.", color=discord.Color.blue())
    for command, description in command_list:
        embed.add_field(name=f"{bot_prefix}{command}", value=description, inline=False)
    embed.set_footer(text="Utilisez le préfixe '!' pour exécuter une commande.")
    await ctx.send(embed=embed)

@bot.command()
async def clear(ctx, amount: typing.Union[int, str] = 1):
    if isinstance(amount, str) and amount.lower() == "all":
        try:
            await ctx.channel.purge()
            await ctx.send("Tous les messages ont été supprimés.")
        except discord.Forbidden:
            await ctx.send("Je n'ai pas les permissions nécessaires pour supprimer des messages.")
        except Exception as e:
            await ctx.send(f"Une erreur est survenue : {e}")
    elif isinstance(amount, int) and amount > 0:
        try:
            await ctx.channel.purge(limit=amount + 1)
            await ctx.send(f"{amount} messages ont été supprimés.")
        except discord.Forbidden:
            await ctx.send("Je n'ai pas les permissions nécessaires pour supprimer des messages.")
        except Exception as e:
            await ctx.send(f"Une erreur est survenue : {e}")
    else:
        await ctx.send("Veuillez spécifier un nombre valide de messages à supprimer.")

@bot.command()
async def checku(ctx, username: str):
    sites = [
        f"https://github.com/{username}",
        f"https://www.facebook.com/{username}",
        f"https://www.linkedin.com/in/{username}",
        f"https://linktr.ee/{username}",
        f"https://www.snapchat.com/add/{username}",
        f"https://twitter.com/{username}",
        f"https://instagram.com/{username}",
        f"https://www.reddit.com/user/{username}",
        f"https://www.pinterest.com/{username}",
        f"https://www.twitch.tv/{username}",
        f"https://open.spotify.com/user/{username}",
        f"https://www.roblox.com/user.aspx?username={username}",
        f"https://t.me/{username}",
        f"https://xvideos.com/profiles/{username}",
        f"https://www.youtube.com/@{username}",
        f"https://api.mojang.com/users/profiles/minecraft/{username}",
        f"https://www.codewars.com/users/{username}",
        f"https://forum.hackthebox.eu/profile/{username}",
        f"https://replit.com/@{username}",
        f"https://www.chess.com/member/{username}",
        f"https://www.behance.net/{username}",
        f"https://www.soundcloud.com/{username}",
        f"https://www.dribbble.com/{username}",
        f"https://www.deviantart.com/{username}",
        f"https://www.producthunt.com/@{username}"
    ]

    valid_users = []
    headers = {'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36'}
    
    for url in sites:
        try:
            response = requests.get(url, headers=headers, timeout=10)
            response.raise_for_status()
            if re.search(username, response.text, re.IGNORECASE):
                valid_users.append(url)
        except HTTPError as e:
            if e.response.status_code in [404, 406]:
                continue
            else:
                print(f"HTTPError pour {url}: {e}")
        except SSLError as e:
            print(f"SSLError pour {url}: {e}")
        except RequestException as e:
            print(f"RequestException pour {url}: {e}")

    if valid_users:
        embed = discord.Embed(title="Résultats de la vérification", color=discord.Color.blue())
        for index, user_url in enumerate(valid_users, start=1):
            embed.add_field(name=f"Utilisateur {index}", value=user_url, inline=False)
        await ctx.send(embed=embed)
    else:
        await ctx.send("Aucun utilisateur valide trouvé.")

@bot.command()
async def profil(ctx, user_id: int):
    try:
        user = await bot.fetch_user(user_id)
        member = ctx.guild.get_member(user.id)
    except discord.NotFound:
        await ctx.send("Utilisateur introuvable.")
        return

    embed = discord.Embed(title="Profil Discord", color=discord.Color.blue())
    embed.add_field(name="Informations Utilisateur", value=f"**Nom :** `{user.name}`\n**ID :** `{user.id}`", inline=False)

    if user.avatar:
        embed.set_thumbnail(url=user.avatar.url)

    if user.banner:
        embed.set_image(url=user.banner.url)

    await ctx.send(embed=embed)

@bot.command()
async def igu(ctx, username):
    loader = instaloader.Instaloader()
    try:
        profile = instaloader.Profile.from_username(loader.context, username)
        embed = discord.Embed(title=f"Profil Instagram de {profile.username}", color=discord.Color.purple())
        embed.set_thumbnail(url=profile.profile_pic_url)

        embed.add_field(name="Nom Complet", value=profile.full_name, inline=False)
        embed.add_field(name="Nom d'utilisateur", value=profile.username, inline=True)
        embed.add_field(name="Biographie", value=profile.biography, inline=False)
        embed.add_field(name="Abonnés", value=profile.followers, inline=True)
        embed.add_field(name="Abonnements", value=profile.followees, inline=True)
        embed.add_field(name="Publications", value=profile.mediacount, inline=True)

        await ctx.send(embed=embed)
    except Exception as e:
        await ctx.send(f"Impossible de récupérer les informations Instagram : {e}")

def create_google_maps_link(city):
    return f"https://www.google.com/maps/place/{city.replace(' ', '+')}"

@bot.command()
async def ip(ctx, ip_address):
    try:
        response = requests.get(f"https://ipinfo.io/{ip_address}/json")
        data = response.json()

        ip = data.get('ip', 'N/A')
        hostname = data.get('hostname', 'N/A')
        city = data.get('city', 'N/A')
        region = data.get('region', 'N/A')
        country = data.get('country', 'N/A')
        postal = data.get('postal', 'N/A')
        loc = data.get('loc', 'N/A')
        org = data.get('org', 'N/A')
        timezone = data.get('timezone', 'N/A')

        google_maps_link = create_google_maps_link(city)

        embed = discord.Embed(title="Détails de l'Adresse IP", color=discord.Color.orange())
        embed.add_field(name="IP", value=ip, inline=False)
        embed.add_field(name="Nom d'Hôte", value=hostname, inline=False)
        embed.add_field(name="Ville", value=city, inline=False)
        embed.add_field(name="Région", value=region, inline=False)
        embed.add_field(name="Pays", value=country, inline=False)
        embed.add_field(name="Code Postal", value=postal, inline=False)
        embed.add_field(name="Coordonnées", value=loc, inline=False)
        embed.add_field(name="Organisation", value=org, inline=False)
        embed.add_field(name="Fuseau Horaire", value=timezone, inline=False)
        embed.add_field(name="Voir sur Google Maps", value=f"[Cliquez ici]({google_maps_link})", inline=False)

        await ctx.send(embed=embed)
    except Exception as e:
        await ctx.send(f"Impossible de récupérer les informations IP : {e}")

bot.run(DISCORD_TOKEN)