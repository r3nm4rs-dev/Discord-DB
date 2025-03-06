import discord
from discord.ext import commands, tasks
import time
import requests
import os
import holehe
import platform
from bs4 import BeautifulSoup
import re
from fake_useragent import UserAgent
from discord import ui, Embed, SelectOption, Intents
import subprocess
import json
from requests.exceptions import HTTPError, SSLError, RequestException
import io
import logging
import base64
from datetime import datetime
import asyncio
import sys

TOKEN = "Bot Token Here"

CHANNEL_ID = 1346247305266987097 # Channel ID for bumb reminder
ROLE_ID = 1343712706376499333 # Role ID for bumb reminder

intents = discord.Intents.all()
bot = commands.Bot(command_prefix="?", intents=intents, help_command=None)

@tasks.loop(hours=5)  # Exécution toutes les 5 heurs
async def bump_reminder():
    await bot.wait_until_ready()
    print("🔄 Le reminder est en cours d'execution...")
    channel = bot.get_channel(CHANNEL_ID)
    print(f"Canal récupéré : {channel}")
    if channel:
        await channel.send(f"<@&{ROLE_ID}> **Don't forget to bump our server with `/bump` !**")
    else:
        print(f"Error : Impossible de trouver le canal {CHANNEL_ID}. Vérifie les permissions et l'ID.")



# Définition de la classe SeekApiClient
class SeekApiClient:
    def __init__(self, api_key):
        self.api_key = api_key

    def search_documents(self, search_string, display_filename=True, size=1000):
        # Implémentation de la méthode search_documents
        # Cette méthode doit retourner les documents trouvés
        # Pour l'exemple, nous retournons une liste vide
        return []

@bot.event
async def on_ready():
    print("Le bot est bien connecté !")  # Debug
    await asyncio.sleep(2)
    if not bump_reminder.is_running():  # Vérifie si la tâche tourne déjà
        bump_reminder.start()
        print("✅ La tâche reminder a été démarrée !")  # Debug
    else:
        print("⚠️ La tâche reminder était déjà en cours !")
    print(f"Bot connecté comme {bot.user}")


@bot.command()
async def help(ctx):
    bot_latency = round(bot.latency * 1000)
    embed = Embed(
        title="Commands List",
        description="<:bluearrow:1346252610893516940> Choose a category too see the avaible commands.",
        color=0x2b2d31
    )
    embed.add_field(
        name="Bot Infos :",
        value=f"<:bluearrow:1346252610893516940> Commands Amount : 16\n<:bluearrow:1346252610893516940> Ping : {bot_latency} ms\n<:bluearrow:1346252610893516940> Prefix : ?",
        inline=False
    )
    embed.set_image(
        url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360"
    )
    embed.set_footer(text="Pluzio Searcher")

    options = [
        SelectOption(label="Home", description="Go to the home panel", emoji="<:white_info:1346254179274068081>"),
        SelectOption(label="API", description="API commands", emoji="<:white_cards:1346254141563076628>"),
        SelectOption(label="Osint", description="OSINT commands", emoji="<:white_cards:1346254141563076628>"),
        SelectOption(label="FiveM", description="FiveM commands", emoji="<:white_cards:1346254141563076628>"),
    ]

    class HelpMenu(ui.Select):
        def __init__(self):
            super().__init__(placeholder="Choose a category", options=options)

        async def callback(self, interaction):
            selected = self.values[0]
            if selected == "Home":
                await interaction.response.edit_message(embed=embed)
            elif selected == "API":
                embed_api = Embed(
                    title="API Commands",
                    description="Here the avaible commands :\n\n"
                                "<:bluearrow:1346252610893516940> **?naz** `<keyword>` : Search with NazAPI.\n"
                                "<:bluearrow:1346252610893516940> **?snusbase** `<keyword>` : Search with SnusBase.\n"
                                "<:bluearrow:1346252610893516940> **?leakcheck** `<email>` : Search with Leakcheck.io.\n"
                                "<:bluearrow:1346252610893516940> **?email** `<email>` : Lookup an email adress.\n"
                                "<:bluearrow:1346252610893516940> **?github** `<username>` : Lookup a Github user.\n"
                                "<:bluearrow:1346252610893516940> **?whois** `<domain>` : Lookup a domain.\n",
                    color=0x2b2d31
                )
                await interaction.response.edit_message(embed=embed_api)
            elif selected == "Osint":
                embed_osint = Embed(
                    title="OSINT Commands",
                    description="Here the avaible commands :\n\n"
                                "<:bluearrow:1346252610893516940> **?ipinfo** `<IP>` : Lookup a IP.\n"
                                "<:bluearrow:1346252610893516940> **?dork** `<keyword>` : Search keyword in Google-Dork.\n"
                                "<:bluearrow:1346252610893516940> **?sherlock** `<username>` : Search for a username in social media.\n"
                                "<:bluearrow:1346252610893516940> **?holehe** `<email>` : See what website use this email.\n"
                                "<:bluearrow:1346252610893516940> **?steam** `<ID>` : Lookup a Steam ID.\n"
                                "<:bluearrow:1346252610893516940> **?mc** `<username>` : Lookup a Minecraft account.\n"
                                "<:bluearrow:1346252610893516940> **?userinfo** `<ID>` : Lookup a Discord ID.\n"
                                "<:bluearrow:1346252610893516940> **?redline** `<mail>` : Search in redline.\n"
                                "<:bluearrow:1346252610893516940> **?phoneinfo** `<phone>` : Lookup a phone number.\n"
                                "<:bluearrow:1346252610893516940> **?dnsinfo** `<domain name>` : See DNS informations about a domain.\n"
                                "<:bluearrow:1346252610893516940> **?roblox** `<username>` : Lookup a Roblox account.",
                    color=0x2b2d31
                )
                await interaction.response.edit_message(embed=embed_osint)
            elif selected == "FiveM":
                embed_fivem = Embed(
                    title="FiveM Commands",
                    description="Here the avaible commands :\n\n"
                                "<:bluearrow:1346252610893516940> **?fivem** `<id/license>` : Search in FiveM Scraps.\n"
                                "<:bluearrow:1346252610893516940> **?scrap** `<cfx_code>` : Scrap a FiveM server.\n"
                                "<:bluearrow:1346252610893516940> **?fivemip** `<id/license>` : Search in our databases for an IP.",
                    color=0x2b2d31
                )
                await interaction.response.edit_message(embed=embed_fivem)

    class HelpView(ui.View):
        def __init__(self):
            super().__init__()
            self.add_item(HelpMenu())

    await ctx.send(embed=embed, view=HelpView())

@bot.command()
async def dnsinfo(ctx, domain: str):
    if ctx.channel.id != 1346247305266987098: # ID du canal autorisé
        error_embed = discord.Embed(
            title="Error",
            description="This command can only be used in <#1346247305266987098>.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)
        return

    try:
        dns_data = {
            "Domaine": domain,
            "Adresse IP": "192.168.0.1",
            "Serveur NS": "ns1.example.com",
            "Pays": "France"
        }

        embed = discord.Embed(
            title="DNS Informations",
            description=f"Here the informations for **{domain}**.",
            color=0x2b2d31
        )
        embed.add_field(name="Domain", value=dns_data["Domaine"], inline=False)
        embed.add_field(name="IP Adress", value=dns_data["Adresse IP"], inline=True)
        embed.add_field(name="NS Server", value=dns_data["Serveur NS"], inline=True)
        embed.add_field(name="Country", value=dns_data["Pays"], inline=False)
        embed.set_footer(text="Pluzio Searcher")

        await ctx.send(embed=embed)
    except Exception as e:
        await ctx.send(f"Une Error s'est produite lors de la recherche : {str(e)}")

@bot.command()
async def ipinfo(ctx, ip: str):
    if ctx.channel.id != 1346247305266987098: # ID du canal autorisé
        error_embed = discord.Embed(
            title="Error",
            description="This command can only be used in <#1346247305266987098>.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)
        return

    api_key = "vgms4ast2DCBdkEf5Klw0ufUlDC4V6tB"
    url = f"https://api.shodan.io/shodan/host/{ip}?key={api_key}"

    try:
        response = requests.get(url)
        data = response.json()

        if "ip" in data:
            embed = discord.Embed(
                title="🌐 IP Informations",
                description=f"Here the informations for **{ip}**.",
                color=0x2b2d31
            )
            embed.add_field(name="📍 IP", value=data.get("ip", "N/A"), inline=False)
            embed.add_field(name="🌍 Country", value=data.get("country_name", "N/A"), inline=True)
            embed.add_field(name="🗺 City", value=data.get("city", "N/A"), inline=True)
            embed.add_field(name="🏢 Organisation", value=data.get("org", "N/A"), inline=False)
            embed.set_footer(text="Pluzio Searcher")

            await ctx.send(embed=embed)
        else:
            await ctx.send("❌ No result found for this IP.")
    except Exception as e:
        await ctx.send(f"❌ Error with : {str(e)}")

@bot.command()
async def email(ctx, email: str):
    if ctx.channel.id != 1346247305266987098: # ID du canal autorisé
        error_embed = discord.Embed(
            title="Error",
            description="This command can only be used in <#1346247305266987098>.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)
        return

    api_key = "d813b0401193fd8ca1d1068971a152f8889151d9"
    url = f"https://api.hunter.io/v2/email-verifier?email={email}&api_key={api_key}"

    try:
        response = requests.get(url)
        data = response.json()

        if "data" in data:
            email_data = data["data"]

            embed = discord.Embed(
                title="Email Verificaton",
                description=f"Here the informations for **{email}**.",
                color=0x2b2d31
            )
            embed.add_field(name="E-mail", value=email_data.get("email", "N/A"), inline=False)
            embed.add_field(name="Valid", value="Yes" if email_data.get("result") == "deliverable" else "No", inline=True)
            embed.add_field(name="Trust Score", value=email_data.get("score", "N/A"), inline=True)
            embed.set_footer(text="Pluzio Searcher")

            await ctx.send(embed=embed)
        else:
            await ctx.send("No data for this email.")
    except Exception as e:
        await ctx.send(f"An error occured : {str(e)}")

@bot.command(name="phoneinfo")
async def phoneinfo(ctx, phone: str):
    ALLOWED_CHANNEL_ID = 1346247305266987098 # ID du canal autorisé
    if ctx.channel.id != ALLOWED_CHANNEL_ID:
        error_embed = discord.Embed(
            title="Error",
            description="This command can only be used in <#1346247305266987098>.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)
        return

    api_key = "b0e84f98f549f1ecf6364604bc9a415f"
    url = f"http://apilayer.net/api/validate?access_key={api_key}&number={phone}"

    try:
        response = requests.get(url)
        response.raise_for_status()
        data = response.json()

        if data.get("valid"):
            embed = discord.Embed(
                title="📱 Phone Lookup",
                description=f"Here the informations for **{phone}**.",
                color=0x2b2d31
            )
            embed.add_field(name="Number", value=data.get("number", "N/A"), inline=False)
            embed.add_field(name="Country Code", value=data.get("country_code", "N/A"), inline=True)
            embed.add_field(name="Country", value=data.get("country_name", "N/A"), inline=True)
            embed.add_field(name="Localisation", value=data.get("location", "N/A"), inline=False)
            embed.add_field(name="Carrier", value=data.get("carrier", "N/A"), inline=True)
            embed.add_field(name="Type", value=data.get("line_type", "N/A"), inline=True)
            embed.add_field(name="📱 **WhatsApp**", value=f"[WhatsApp Profil](https://wa.me/{phone})", inline=True)
            embed.add_field(name="💬 **Telegram**", value=f"[Telegram Profil](https://t.me/{phone})", inline=True)
            embed.set_footer(text="Pluzio Searcher")

            try:
                await ctx.author.send(embed=embed)
                info_embed = discord.Embed(
                    title="Result Found 🔎, check your DM's !",
                    description="**⚠️ Check your private messages !**.",
                    color=0x2b2d31
                )
                info_embed.set_image(
                    url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360"
                )
                await ctx.send(embed=info_embed)
            except discord.Forbidden:
                dm_error_embed = discord.Embed(
                    title="Cannot send messag",
                    description="Your DM are closed. Enable them to get the results.",
                    color=0x2b2d31
                )
                await ctx.send(embed=dm_error_embed)
        else:
            invalid_embed = discord.Embed(
                title="Invalid Phone",
                description=f"The number **{phone}** is invalid or nothing could be found.",
                color=0x2b2d31
            )
            invalid_embed.set_footer(text="Pluzio Searcher")
            await ctx.send(embed=invalid_embed)

    except requests.exceptions.RequestException as req_err:
        error_embed = discord.Embed(
            title="API Error",
            description="An error occured while using NumVerify.",
            color=0x2b2d31
        )
        error_embed.add_field(name="Error Data", value=str(req_err), inline=False)
        error_embed.set_footer(text="Check your API.")
        await ctx.send(embed=error_embed)

    except Exception as e:
        general_error_embed = discord.Embed(
            title="Unknow Error",
            description="I don't know what hapenned.",
            color=0x2b2d31
        )
        general_error_embed.add_field(name="How to solve", value=str(e), inline=False)
        general_error_embed.set_footer(text="Contact the admin if it still do it.")
        await ctx.send(embed=general_error_embed)

@bot.command()
async def whois(ctx, domain: str):
    """
    Récupère les informations WHOIS d'un domaine via l'API WhoisXML.
    """
    api_key = "at_18VrQY0C9IgUWReyVJw8ybyZBb7oJ"
    url = f"https://www.whoisxmlapi.com/whoisserver/WhoisService?apiKey={api_key}&domainName={domain}&outputFormat=JSON"

    try:
        response = requests.get(url)
        data = response.json()

        if "WhoisRecord" in data:
            whois_data = data["WhoisRecord"]

            embed = discord.Embed(
                title="WHOIS Lookup",
                description=f"Here the results for **{domain}**.",
                color=0x2b2d31
            )
            embed.add_field(name="Domain", value=whois_data.get("domainName", "N/A"), inline=False)
            embed.add_field(name="Created on", value=whois_data.get("createdDate", "N/A"), inline=True)
            embed.add_field(name="End in", value=whois_data.get("expiresDate", "N/A"), inline=True)
            embed.add_field(name="Organisation", value=whois_data.get("registrant", {}).get("organization", "N/A"), inline=False)
            embed.set_footer(text="Pluzio Searcher")

            await ctx.send(embed=embed)
        else:
            await ctx.send("No data found for this domain.")
    except Exception as e:
        await ctx.send(f"An error occured : {str(e)}")

@bot.command()
async def subdomains(ctx, domain: str):
    """
    Recherche des sous-domaines via l'API SecurityTrails.
    """
    api_key = "3qicABB3Uhud-lnxKWcFrq5sQuqTItD8"
    url = f"https://api.securitytrails.com/v1/domain/{domain}/subdomains"
    headers = {"APIKEY": api_key}

    try:
        response = requests.get(url, headers=headers)
        data = response.json()

        if "subdomains" in data:
            subdomains = data["subdomains"]
            subdomains_list = "\n".join([f"{sub}.{domain}" for sub in subdomains[:20]])

            embed = discord.Embed(
                title="📁 Subdomains",
                description=f"Here the subdomains list for **{domain}**:",
                color=0x2b2d31
            )
            embed.add_field(name="Sub-Domains", value=subdomains_list or "Nothing found.", inline=False)
            embed.set_footer(text="Pluzio Searcher")

            await ctx.send(embed=embed)
        else:
            await ctx.send("Nothing found for this domain.")
    except Exception as e:
        await ctx.send(f"An error occured : {str(e)}")

def sanitize_filename(filename):
    return re.sub(r'[\/:*?"<>|]', '_', filename)

@bot.command()
async def naz(ctx, *, request: str):
    """
    Recherche via l'API NazAPI et envoie les résultats dans un fichier.
    """
    try:
        api_key = "1501479747:EOHy2bG"
        url = "https://leakosintapi.com/"
        download_path = "./resultat/"

        if not os.path.exists(download_path):
            os.makedirs(download_path)

        sanitized_request = sanitize_filename(request)
        file_path = os.path.join(download_path, f"pluzio.txt")

        data = {
            "token": api_key,
            "request": request,
            "limit": 75,
            "lang": "fr"
        }

        response = requests.post(url, json=data)
        response_json = response.json()

        if "List" not in response_json:
            await ctx.send("❌ **Error**: Aucun résultat trouvé !")
            return

        list_data = response_json["List"]

        with open(file_path, "w", encoding="utf-8") as file:
            file.write("──── NazAPI Results ────\n\n")
            for category, category_data in list_data.items():
                file.write(f"»»————- ★ {category} ★ ————-««\n")
                if "Data" not in category_data or not category_data["Data"]:
                    file.write("Nothing found for this category.\n")
                    continue

                for data_item in category_data["Data"]:
                    if isinstance(data_item, dict):
                        for key, value in data_item.items():
                            file.write(f"{key}: {value}\n")
                    else:
                        file.write("Unknow data.\n")
                file.write("\n")

        embed = discord.Embed(
            title="Results send in DM's ! <:white_info:1346254179274068081>",
            description="Open your DM's to get the result.",
            color=0x2b2d31
        )
        embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360")
        await ctx.send(embed=embed)

        await ctx.author.send(file=discord.File(file_path))

    except Exception as e:
        await ctx.send(f"❌ An error occured : {str(e)}")

ALLOWED_CHANNEL_ID = 1346247305266987098 # ID du canal autorisé

@bot.command()
async def fivem(ctx, *, keyword):
    if ctx.channel.id != ALLOWED_CHANNEL_ID:
        embed_error = discord.Embed(
            title="__Error__",
            description=f"This command can only be used in <#1346247305266987098>.",
            color=0x2b2d31
        )
        embed_error.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=embed_error)
        return

    embed_loading = discord.Embed(
        description=f"**Currently searching for :** `{keyword}` <:white_info:1346254179274068081>",
        color=0x2b2d31
    )
    search_message = await ctx.send(embed=embed_loading)

    db_folder = "db"
    results = []

    ascii_art = r"""
   _____                     _     ______ _____  
  / ____|                   | |   |  ____|  __ \ 
 | (___   ___  __ _ _ __ ___| |__ | |__  | |__) | 
  \___ \ / _ \/ _` | '__/ __| '_ \|  __| |  _  / 
  ____) |  __/ (_| | | | (__| | | | |    | | \ \ 
 |_____/ \___|\__,_|_|  \___|_| |_|_|    |_|  \_\
                                                 
    """

    for filename in os.listdir(db_folder):
        file_path = os.path.join(db_folder, filename)

        if os.path.isfile(file_path) and filename.endswith('.txt'):
            with open(file_path, 'r', encoding='utf-8') as file:
                for line in file:
                    if keyword.lower() in line.lower():
                        results.append(line.strip())

    if results:
        results_filename = "pluzio.txt"
        with open(results_filename, 'w', encoding='utf-8') as f:
            f.write(ascii_art + "\n\n")
            f.write('\n'.join(results))

        await ctx.author.send(file=discord.File(results_filename))
        os.remove(results_filename)

        embed = discord.Embed(
            title="Results found 🔎, check your DM's !",
            description="**⚠️ Check if you enabled your DM's !**.",
            color=0x2b2d31
        )
        embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360")  # Lien de l'image
        await search_message.edit(embed=embed)

    else:
        embed_no_result = discord.Embed(
            title="<:x_red_verified:1314259356178714624> No results found <:x_red_verified:1314259356178714624>",
            description=f"Can't find results for : **{keyword}**\n\n"
                        "Check the following :\n\n"
                        "Make sure the Discord ID is valid.\n"
                        "Make sure he play FiveM.",
            color=0x2b2d31
        )
        embed_no_result.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=embed_no_result)

ALLOWED_CHANNEL_ID = 1346247305266987098 # ID du canal autorisé

@bot.command()
async def fivemip(ctx, *, keyword):
    if ctx.channel.id != ALLOWED_CHANNEL_ID:
        embed_error = discord.Embed(
            title="__Error__",
            description=f"This command can only be used in le salon : <#{ALLOWED_CHANNEL_ID}>",
            color=0x2b2d31
        )
        embed_error.set_footer(text="Pluzi")
        await ctx.send(embed=embed_error)
        return

    embed_loading = discord.Embed(
        description=f"**Currently searching for :** `{keyword}` <:logoo:1346250132844318781>",
        color=0x2b2d31
    )
    search_message = await ctx.send(embed=embed_loading)

    db_folder = "db"
    results = []

    ascii_art = r"""
   _____                     _     ______ _____  
  / ____|                   | |   |  ____|  __ \ 
 | (___   ___  __ _ _ __ ___| |__ | |__  | |__) |
  \___ \ / _ \/ _` | '__/ __| '_ \|  __| |  _  / 
  ____) |  __/ (_| | | | (__| | | | |    | | \ \  
 |_____/ \___|\__,_|_|  \___|_| |_|_|    |_|  \_\
                                                 
    """

    for filename in os.listdir(db_folder):
        file_path = os.path.join(db_folder, filename)

        if os.path.isfile(file_path) and filename.endswith('.txt'):
            with open(file_path, 'r', encoding='utf-8') as file:
                for line in file:
                    if keyword.lower() in line.lower():
                        results.append(line.strip())

    if results:
        results_folder = "resultat"
        if not os.path.exists(results_folder):
            os.makedirs(results_folder)

        results_filename = os.path.join(results_folder, "pluzio.txt")
        with open(results_filename, 'w', encoding='utf-8') as f:
            f.write(ascii_art + "\n\n")
            f.write('\n'.join(results))

        await ctx.author.send(file=discord.File(results_filename))
        os.remove(results_filename)

        embed = discord.Embed(
            title="Result found 🔎, check your DM's !",
            description="**⚠️ Make sure you enabled your DM's !**",
            color=0x2b2d31
        )
        embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360")
        await search_message.edit(embed=embed)

    else:
        embed_no_result = discord.Embed(
            title="<:x_red_verified:1314259356178714624> No results found <:x_red_verified:1314259356178714624>",
            description=f"Can't find results for : **{keyword}**\n\n"
                        "Check the following :\n\n"
                        "Make sure the Discord ID is valid.\n"
                        "Make sure he play FiveM.",
            color=0x2b2d31
        )
        embed_no_result.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=embed_no_result)

STEAM_API_KEY = 'C8EE0D8E8D3FD87A88240A6A9C16F9D9'  # Steam-KEY
DEFAULT_AVATAR_URL = "https://steamcdn-a.akamaihd.net/steamcommunity/public/images/avatars/default_avatar.jpg"

@bot.command()
async def steam(ctx, steam_id: str):
    if ctx.channel.id != 1346247305266987098:
        error_embed = discord.Embed(
            title="Error",
            description="This command can only be used in le canal spécifié.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)
        return

    url = f"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={STEAM_API_KEY}&steamids={steam_id}"
    response = requests.get(url)
    data = response.json()

    if 'response' in data and 'players' in data['response'] and data['response']['players']:
        player = data['response']['players'][0]

        pseudo = player.get("personaname", "❌")
        profile_url = player.get("profileurl", "❌")
        country = player.get("loccountrycode", "❌")
        last_logoff = player.get("lastlogoff", "❌")
        status_code = player.get("personastate", 0)
        real_name = player.get("realname", "❌")
        avatar_url = player.get("avatarfull", DEFAULT_AVATAR_URL)

        status_map = {
            0: "Offline",
            1: "Online",
            2: "Do Not Disturb",
            3: "Not Here",
            4: "Idling",
            5: "Searching A Game",
            6: "In Game"
        }
        status = status_map.get(status_code, "❌")

        if last_logoff != "❌":
            last_logoff = datetime.utcfromtimestamp(last_logoff).strftime('%Y-%m-%d %H:%M:%S UTC')
        else:
            last_logoff = "❌"

        if not avatar_url:
            avatar_url = DEFAULT_AVATAR_URL

        embed = discord.Embed(title="__Result :__", color=0x000000)
        embed.set_thumbnail(url=avatar_url)
        embed.add_field(name="Username", value=pseudo, inline=False)
        embed.add_field(name="Profil", value=profile_url, inline=False)
        embed.add_field(name="Country", value=country, inline=False)
        embed.add_field(name="Last Login", value=last_logoff, inline=False)
        embed.add_field(name="Statut", value=status, inline=False)
        embed.add_field(name="Real Name", value=real_name, inline=False)

        await ctx.author.send(embed=embed)

        confirmation_embed = discord.Embed(
            title="Result found 🔎, check your DM's !",
            description="**⚠️ Make sure you enabled your DM's !**",
            color=0x2b2d31
        )
        confirmation_embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360")  # Ajout de l'image
        await ctx.send(embed=confirmation_embed)
    else:
        error_embed = discord.Embed(
            title="__Error__ ",
            description=f"<:x_red_verified:1314259356178714624> No data found for the Steam ID : `{steam_id}`.\n <:x_red_verified:1314259356178714624> Make sure the ID is valid.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)

GITHUB_TOKEN = os.getenv('kzjbOg3iOm4k4MRpBss76yxIZSPJtoOPaqxirsfX')  # Github-KEY
EMBED_COLOR = 0x2b2d31

@bot.command(name='github')
async def github(ctx, username: str):
    if ctx.channel.id != 1346247305266987098:
        error_embed = discord.Embed(
            title="Error",
            description="You can't use this command here",
            color=EMBED_COLOR
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)
        return

    headers = {}
    if GITHUB_TOKEN:
        headers = {"Authorization": f"token {GITHUB_TOKEN}"}

    url = f"https://api.github.com/users/{username}"
    response = requests.get(url, headers=headers)

    if response.status_code == 200:
        data = response.json()

        embed = discord.Embed(
            title=f"GitHub Profil Of {data['login']}",
            description=data.get('bio', 'No avaible bio.'),
            color=EMBED_COLOR
        )
        embed.set_thumbnail(url=data['avatar_url'])
        embed.set_author(name="GitHub",
        icon_url="https://github.githubassets.com/images/modules/logos_page/GitHub-Mark.png")
        embed.set_footer(text="SearchFR")
        embed.add_field(name="Name", value=data.get('name', 'No Data'), inline=True)
        embed.add_field(name="Localisation", value=data.get('location', 'No Data'), inline=True)
        embed.add_field(name="Public Repos", value=str(data['public_repos']), inline=True)
        embed.add_field(name="Public Gists", value=str(data['public_gists']), inline=True)
        embed.add_field(name="Followers", value=str(data['followers']), inline=True)
        embed.add_field(name="Following", value=str(data['following']), inline=True)
        embed.add_field(name="User Type", value=data['type'], inline=True)
        embed.add_field(name="Created", value=data['created_at'], inline=True)
        embed.add_field(name="Last Update", value=data['updated_at'], inline=True)
        if data.get('company'):
            embed.add_field(name="Company", value=data['company'], inline=True)
        if data.get('email'):
            embed.add_field(name="Email", value=data['email'], inline=False)
        else:
            embed.add_field(name="Email", value="No data or Private.", inline=False)
        if data.get('twitter_username'):
            embed.add_field(name="Twitter",
            value=f"[{data['twitter_username']}](https://twitter.com/{data['twitter_username']})", inline=False)
        embed.add_field(name="GitHub Link", value=f"[Open In Github]({data['html_url']})", inline=False)
        if data.get('blog'):
            embed.add_field(name="Blog", value=data['blog'], inline=False)

        try:
            await ctx.author.send(embed=embed)

            notify_embed = discord.Embed(
            title="Result found 🔎, check your DM's !",
            description="**⚠️ Make sure you enabled your DM's !**",
                color=EMBED_COLOR
            )
            notify_embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360")  # Ajout de l'image
            notify_embed.set_footer(text="Pluzio Searcher")
            await ctx.send(embed=notify_embed)

        except discord.Forbidden:
            await ctx.send("I can't send DM's, make sure you enabled them.")
    else:
        error_embed = discord.Embed(
            title="Error",
            description="GitHub user not found.",
            color=EMBED_COLOR
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)

def google_dork_search(query):
    search_url = f"https://www.google.com/search?q={query}"
    headers = {
        "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36"
    }

    response = requests.get(search_url, headers=headers)
    soup = BeautifulSoup(response.text, 'html.parser')

    results = []
    for g in soup.find_all('div', class_='g'):
        title = g.find('h3')
        link = g.find('a')
        if title and link:
            results.append(f"{title.text}\n{link['href']}")

    return results

@bot.command()
async def dork(ctx, *, keyword):
    if ctx.channel.id != 1346247305266987098:
        error_embed = discord.Embed(
            title="Error",
            description="This command can't be used here.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)
        return

    results = google_dork_search(keyword)

    if results:
        await ctx.author.send("\n\n".join(results))

        embed = discord.Embed(
            title="Result found 🔎, check your DM's !",
            description="**⚠️ Make sure you enabled your DM's !**",
            color=0x2b2d31
        )
        embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360")  # Image ajoutée ici
        await ctx.send(embed=embed)
    else:
        embed = discord.Embed(
            description="<:x_red_verified:1314259356178714624> Nothing found for this keyword.",
            color=0x2b2d31
        )
        await ctx.send(embed=embed)

ROBLOX_API_URL = "https://users.roblox.com/v1/users"
BADGES_API_URL = "https://badges.roblox.com/v1/users"
STATUS_API_URL = "https://users.roblox.com/v1/users/{}/status"
FRIENDS_API_URL = "https://friends.roblox.com/v1/users/{}/friends/count"
AVATAR_API_URL = "https://thumbnails.roblox.com/v1/users/avatar-headshot?userIds={user_id}&size=150x150&format=Png"

@bot.command()
async def roblox(ctx, username: str):
    if ctx.channel.id != 1346247305266987098:
        error_embed = discord.Embed(
            title="Error",
            description="This command can't be used here.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=error_embed)
        return

    search_url = "https://users.roblox.com/v1/usernames/users"
    payload = {
        "usernames": [username],
        "excludeBannedUsers": False
    }

    try:
        search_response = requests.post(search_url, json=payload)

        if search_response.status_code == 200:
            search_data = search_response.json()

            if "data" in search_data and len(search_data["data"]) > 0:
                user_info = search_data["data"][0]
                user_id = user_info.get("id")
                display_name = user_info.get("displayName", "Unknow")
                account_name = user_info.get("name", "Unknow")

                user_url = f"{ROBLOX_API_URL}/{user_id}"
                user_response = requests.get(user_url)

                if user_response.status_code == 200:
                    user_details = user_response.json()
                    creation_date = user_details.get("created", "Unknow")

                    badges_url = f"{BADGES_API_URL}/{user_id}/badges"
                    badges_response = requests.get(badges_url)
                    badges = "No badge found"
                    if badges_response.status_code == 200:
                        badges_data = badges_response.json().get("data", [])
                        badges = ", ".join([badge["name"] for badge in badges_data[:5]]) or "No Badge"

                    status_url = STATUS_API_URL.format(user_id)
                    status_response = requests.get(status_url)
                    user_status = status_response.json().get("status", "No Status") if status_response.status_code == 200 else "Unknow"

                    friends_url = FRIENDS_API_URL.format(user_id)
                    friends_response = requests.get(friends_url)
                    friend_count = friends_response.json().get("count", "Unknow") if friends_response.status_code == 200 else "Unknow"

                    avatar_url = AVATAR_API_URL.format(user_id=user_id)
                    avatar_response = requests.get(avatar_url)
                    avatar_data = avatar_response.json().get("data", [])
                    avatar_image = avatar_data[0]["imageUrl"] if avatar_data else None

                    embed = discord.Embed(
                        title=f"Roblox informations for {account_name}",
                        color=0x2b2d31
                    )
                    embed.add_field(name="Username", value=account_name, inline=False)
                    embed.add_field(name="Display Name", value=display_name, inline=False)
                    embed.add_field(name="User ID", value=user_id, inline=False)
                    embed.add_field(name="Creation Date", value=creation_date, inline=False)
                    embed.add_field(name="Badges", value=badges, inline=False)
                    embed.add_field(name="Status", value=user_status, inline=False)
                    embed.add_field(name="Friends Count", value=friend_count, inline=False)
                    if avatar_image:
                        embed.set_thumbnail(url=avatar_image)
                    embed.set_footer(text="Pluzio Searcher")

                    # Envoi en MP
                    try:
                        await ctx.author.send(embed=embed)

                        confirm_embed = discord.Embed(
                        title="Result found 🔎, check your DM's !",
                        description="**⚠️ Make sure you enabled your DM's !**",
                            color=0x2b2d31
                        )
                        confirm_embed.set_image(url="https://cdn.discordapp.com/attachments/1286742520021254352/1314232326817054821/wldb_banner.png")
                        await ctx.send(embed=confirm_embed)

                    except discord.Forbidden:
                        await ctx.send("I can't send DM's. Make sure they are enabled.")
                else:
                    await ctx.send("<:x_red_verified:1314259356178714624> Cannot get the informations from Roblox.")
            else:
                await ctx.send(f"<:x_red_verified:1314259356178714624> Nothing found for : {username}")
        else:
            await ctx.send("Error when searching.")
    except Exception as e:
        await ctx.send(f"An error occured : {e}")

SNUSBASE_API_KEY = 'sb6sffauk36ll3n9ysf05f5vxwkcr'
SNUSBASE_API_URL = 'https://api.snusbase.com/data/search'

@bot.command(name='snusbase')
async def snusbase(ctx, *, terms: str):
    """Recherche dans l'API Snusbase et envoie les résultats en DM."""

    allowed_channel_id = 1346247305266987098 # ID du canal autorisé
    if ctx.channel.id != allowed_channel_id:
        await ctx.send("You can't use this command here.")
        return

    search_embed = discord.Embed(
        description="**Searching, please wait...**",
        color=0x2b2d31
    )
    search_message = await ctx.send(embed=search_embed)

    terms_list = terms.split()
    payload = {
        "terms": terms_list,
        "types": ["username", "email", "lastip", "password", "hash", "name"]
    }

    headers = {
        'Auth': SNUSBASE_API_KEY,
        'Content-Type': 'application/json',
    }

    ascii_header = """\


Pluzio On Top
                         

"""

    try:
        response = requests.post(SNUSBASE_API_URL, headers=headers, json=payload)
        response.raise_for_status()
        data = response.json()

        results_filename = 'pluzio.txt'

        with open(results_filename, 'w', encoding='utf-8') as file:
            file.write(ascii_header)
            file.write("\n")

            for db_name, entries in data['results'].items():
                file.write(f"»»————- ★ Found in : {db_name} ★ ————-««\n\n")
                for entry in entries:
                    formatted_entry = "\n".join(f"{key}: {value}" for key, value in entry.items())
                    file.write(formatted_entry)
                    file.write("\n\n")

        await ctx.author.send(file=discord.File(results_filename))

        results_embed = discord.Embed(
            title="Result found 🔎, check your DM's !",
            description="**⚠️ Make sure you enabled your DM's !**",
            color=0x2b2d31
        )
        results_embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360")
        await search_message.delete()
        await ctx.send(embed=results_embed)

    except requests.exceptions.HTTPError as http_err:
        await ctx.send(f"Error with API : {http_err}")
    except Exception as err:
        await ctx.send(f"An error occured : {err}")

HUDSONROCK_API_KEY = "ROCKHUDSONROCK"

def hudsonrock_lookup(endpoint, query_param, query_value):
    try:
        result = subprocess.run(
            [
                "curl",
                "-X", "GET",
                f"https://cavalier.hudsonrock.com/api/json/v2/osint-tools/{endpoint}",
                "-H", f"api-key: {HUDSONROCK_API_KEY}",
                "-G",
                "--data-urlencode", f"{query_param}={query_value}",
            ],
            capture_output=True,
            text=True,
        )
        if result.returncode != 0:
            return f"Error when  using curl : {result.stderr}"

        data = json.loads(result.stdout)

        embed = discord.Embed(
            title="Results found 🔎",
            description=f"Here the results for : {query_value}",
            color=0x2b2d31
        )

        field_count = 0
        for steal in data.get("stealers", []):
            if field_count >= 25:
                break
            embed.add_field(name="📝 **Desktop Name**", value=f"``{steal.get('computer_name', 'Unknow')}``", inline=True)
            field_count += 1
            embed.add_field(name="🖥 **Operating System**", value=f"``{steal.get('operating_system', 'Unknow')}``", inline=True)
            field_count += 1
            embed.add_field(name="🔒 **IP**", value=f"``{steal.get('ip', 'Unknow')}``", inline=True)
            field_count += 1
            embed.add_field(name="📅 **Date Compromised**", value=f"``{steal.get('date_compromised', 'Unknow')}``", inline=True)
            field_count += 1
            embed.add_field(name="🔰 **Services**", value=f"``{steal.get('total_user_services', 'Unknow')}``", inline=True)
            field_count += 1
            embed.add_field(name="🛡 **Anti-virus Used**", value=f"``{', '.join(steal.get('antiviruses', ['None']))}``", inline=False)
            field_count += 1

        return embed

    except json.JSONDecodeError:
        return "Error : les données reçues ne sont pas valides JSON."
    except subprocess.CalledProcessError:
        return "Error lors de la commande curl."
    except Exception as e:
        return f"Error de récupération des informations pour {query_value} : {e}"

def determine_query_type(query_value):
    if re.match(r"[^@]+@[^@]+\.[^@]+", query_value):
        return "search-by-email", "email"
    elif re.match(r"^(?:\d{1,3}\.){3}\d{1,3}$", query_value):
        return "search-by-ip", "ip"
    else:
        return None, None

@bot.command(name="redline")
async def redline(ctx, query: str):
    ALLOWED_CHANNEL_ID = 1346247305266987098 # ID du canal autorisé
    if ctx.channel.id != ALLOWED_CHANNEL_ID:
        await ctx.send(embed=discord.Embed(
            title="Error",
            description="❌ You can't use this command here.",
            color=0x2b2d31
        ))
        return

    endpoint, query_param = determine_query_type(query)
    if not endpoint or not query_param:
        await ctx.send(embed=discord.Embed(
            title="Format invalide",
            description="❌ Please give a valid **Email** or **IP Adress**.",
            color=0x2b2d31
        ))
        return

    result = hudsonrock_lookup(endpoint, query_param, query)

    if isinstance(result, discord.Embed):
        try:
            await ctx.author.send(embed=result)

            confirmation_embed = discord.Embed(
                title="Result found 🔎, check your DM's !",
                description="**⚠️ Make sure you enabled your DM's !**",
                color=0x2b2d31
            )
            confirmation_embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360?ex=6757016f&is=6755afef&hm=cb788c4472a80bf9a8e986142db549584d0e5b6e1dcd56be61750be3e95b9eab&")
            confirmation_embed.set_footer(text="Pluzio Searcher")

            await ctx.send(embed=confirmation_embed)
        except discord.Forbidden:
            await ctx.send(embed=discord.Embed(
                title="Error",
                description="❌ Can't send DM's, make sure they are enabled.",
                color=0x2b2d31
            ))
    else:
        await ctx.send(embed=discord.Embed(
            title="Error while searching",
            description=result,
            color=0x2b2d31
        ))

AUTHORIZED_CHANNEL_ID = 1346247305266987098
LEAKCHECK_URL = "https://leakcheck.net/api/public?key=49535f49545f5245414c4c595f4150495f4b4559&check={}"

@bot.command(name="leakcheck")
async def leakcheck(ctx, email: str):
    if ctx.channel.id != AUTHORIZED_CHANNEL_ID:
        embed = discord.Embed(
            title="Error",
            description=f"You can use commands here : <#{AUTHORIZED_CHANNEL_ID}>",
            color=0x2b2d31
        )
        await ctx.send(embed=embed)
        return

    await ctx.send(embed=discord.Embed(
        title="Currently Searching...",
        description="*Please wait while I get results...*",
        color=0x2b2d31
    ).set_footer(text="Wait..."))

    data = fetch_leakcheck_data(email)
    result = format_leakcheck_result(data, email)

    if isinstance(result, discord.File):
        await ctx.author.send(file=result)
    else:
        await ctx.author.send(result)

    await ctx.send(embed=discord.Embed(
        title="Result found 🔎, check your DM's !",
        description="**⚠️ Make sure you enabled your DM's !**",
        color=0x2b2d31
    ).set_image(url="https://cdn.discordapp.com/attachments/1313886334296789083/1314336891033878528/wldb_banner.png").set_footer(text="Pluzio Searcher"))

def fetch_leakcheck_data(query):
    try:
        response = requests.get(LEAKCHECK_URL.format(query))
        response.raise_for_status()
        return response.json()
    except requests.RequestException:
        return None

def format_leakcheck_result(data, email):
    if data and data.get("success"):
        found = data.get("found", 0)
        passwords = data.get("passwords", 0)
        sources = data.get("sources", [])

        if len(sources) > 25 or any(len(f"- {source.get('name', 'Unknow')} (Date: {source.get('date', 'Unknow')})") > 1024 for source in sources):
            file_content = f"Results for : {email}\nFound in: {found}\nCompromised Password: {passwords}\nSources:\n"
            file_content += "\n".join([f"- {source.get('name', 'Unknow')} (Date: {source.get('date', 'Unknow')})" for source in sources])
            file_output = io.StringIO(file_content)
            return discord.File(file_output, filename="pluzio_results.txt")

        text_content = f"Results for `{email}` :\Found in : {found}\nCompromised Passwords : {passwords}\nSources :\n"
        text_content += "\n".join([f"- {source.get('name', 'Unknow')} (Date: {source.get('date', 'Unknow')})" for source in sources])
        return text_content
    else:
        return f"No leak found for `{email}` in **LeakCheck**."

ALLOWED_CHANNEL_ID = 1346247305266987098 # ID du canal autorisé
scrape_data = {}

async def get_server_info(server_id):
    url = f'https://servers-frontend.fivem.net/api/servers/single/{server_id}'
    user_agent = UserAgent()
    headers = {
        'User-Agent': user_agent.random,
        'method': 'GET'
    }

    try:
        response = requests.get(url, headers=headers)
        if response.status_code == 200:
            server_data = response.json()
            return server_data, None
        else:
            return None, f"Error : L'API a renvoyé un statut {response.status_code}."
    except Exception as e:
        return None, f"Error: {str(e)}"

def create_player_embed(server_code, players, page_num):
    total_pages = (len(players) - 1) // 10 + 1
    start_index = page_num * 10
    end_index = start_index + 10
    embed = discord.Embed(
        title=f"Results for server `{server_code}` (Page {page_num + 1}/{total_pages})",
        color=0x2b2d31
    )
    embed.set_image(url="https://cdn.discordapp.com/attachments/1313886334296789083/1314336891033878528/wldb_banner.png")

    for player in players[start_index:end_index]:
        name = player.get('name', 'Unknow')
        identifiers = player.get('identifiers', ['Nothing Found'])
        identifiers_str = "\n".join(identifiers)
        embed.add_field(name=f"Player : {name}", value=f"Identifiants :\n{identifiers_str}", inline=False)

    return embed

async def send_player_page(ctx_or_interaction, page_num):
    user = ctx_or_interaction.user if isinstance(ctx_or_interaction, discord.Interaction) else ctx_or_interaction.author
    user_id = user.id
    players = scrape_data[user_id]['players']
    server_code = scrape_data[user_id]['server_code']

    embed = create_player_embed(server_code, players, page_num)

    view = ui.View()
    if page_num > 0:
        view.add_item(ui.Button(emoji="⬅️", style=discord.ButtonStyle.primary, custom_id="prev_page"))
    if page_num < (len(players) - 1) // 10:
        view.add_item(ui.Button(emoji="➡️", style=discord.ButtonStyle.primary, custom_id="next_page"))
    view.add_item(ui.Button(emoji="📥", style=discord.ButtonStyle.success, custom_id="download_json"))

    if scrape_data[user_id]['current_msg']:
        await scrape_data[user_id]['current_msg'].edit(embed=embed, view=view)
    else:
        msg = await user.send(embed=embed, view=view)
        scrape_data[user_id]['current_msg'] = msg

    scrape_data[user_id]['current_page'] = page_num

@bot.command()
async def scrap(ctx, server_code):
    if ctx.channel.id != ALLOWED_CHANNEL_ID:
        error_embed = discord.Embed(
            title="Error",
            description=f"You can use this commands here : <#{ALLOWED_CHANNEL_ID}>.",
            color=0x2b2d31
        )
        await ctx.send(embed=error_embed)
        return

    embed = discord.Embed(
        title="Result found 🔎, check your DM's !",
        description="**⚠️ Make sure you enabled your DM's !**",
        color=0x2b2d31
    )
    embed.set_image(url="https://cdn.discordapp.com/attachments/1313886334296789083/1314336891033878528/wldb_banner.png")
    embed.set_footer(text="Pluzio Searcher")
    await ctx.send(embed=embed)

    await ctx.author.send(f"Here the results for : `{server_code}`...")

    server_data, error_message = await get_server_info(server_code)

    if error_message:
        await ctx.author.send(f"Error : {error_message}")
        return

    if server_data:
        players = server_data['Data'].get('players', [])
        if not players:
            await ctx.author.send(f"No player found in the server `{server_code}`.")
            return

        scrape_data[ctx.author.id] = {
            'players': players,
            'server_code': server_code,
            'current_page': 0,
            'current_msg': None
        }

        await send_player_page(ctx, 0)
    else:
        await ctx.author.send(f"Cannot get data from `{server_code}`.")

@bot.event
async def on_interaction(interaction):
    user_id = interaction.user.id
    if user_id not in scrape_data:
        return

    if interaction.data['custom_id'] == 'prev_page':
        current_page = scrape_data[user_id]['current_page']
        await send_player_page(interaction, current_page - 1)
        await interaction.response.defer()
    elif interaction.data['custom_id'] == 'next_page':
        current_page = scrape_data[user_id]['current_page']
        await send_player_page(interaction, current_page + 1)
        await interaction.response.defer()
    elif interaction.data['custom_id'] == 'download_json':
        players = scrape_data[user_id]['players']
        json_data = json.dumps(players, indent=4)
        file_name = f"{scrape_data[user_id]['server_code']}_players.json"
        with open(file_name, 'w', encoding='utf-8') as file:
            file.write(json_data)
        await interaction.user.send(file=discord.File(file_name))
        await interaction.response.defer()

@bot.command()
async def holehe(ctx, email: str):
    channel_id = 1346247305266987098  # Assurez-vous que cet ID est correct
    if ctx.channel.id != channel_id:
        embed_error = discord.Embed(
            title="❌ Not enough perms",
            description="You can't use this command here.",
            color=0x2b2d31
        )
        await ctx.send(embed=embed_error)
        return

    embed_loading = discord.Embed(
        title="Started searching 🔎",
        description=f"Looking for website using `{email}`...",
        color=0x2b2d31
    )
    message = await ctx.send(embed=embed_loading)

    try:
        result = subprocess.run(["holehe", email], capture_output=True, text=True, check=True)

        formatted_result = result.stdout.strip() if result.stdout else "No results found."

        embed_result = discord.Embed(
            title="Results found 🔎",
            description=f"Here the results for `{email}` :\n\n```\n{formatted_result}\n```",
            color=0x2b2d31
        )
        embed_result.set_footer(text="⚠️ Make sure you enabled your DM's !")
        embed_result.set_image(url="https://cdn.discordapp.com/attachments/1286742520021254352/1314232326817054821/wldb_banner.png")

        try:
            await ctx.author.send(embed=embed_result)
            embed_done = discord.Embed(
                title="Result found 🔎, check your DM's !",
                description="**⚠️ Make sure you enabled your DM's !**",
                color=0x2b2d31
            )
            embed_done.set_image(url="https://cdn.discordapp.com/attachments/1286742520021254352/1314232326817054821/wldb_banner.png")  # Image ajoutée ici
            await message.edit(embed=embed_done)
        except discord.Forbidden:
            await message.edit(embed=discord.Embed(
                title="Error ❌",
                description="Can't send DM's, make sure they are enabled.",
                color=0x2b2d31
            ))

    except subprocess.CalledProcessError as e:
        error_message = e.output if e.output else "Unknow error."
        embed_error = discord.Embed(
            title="Error 🚨",
            description=f"An error occured :\n```\n{error_message}\n```",
            color=0x2b2d31
        )
        await message.edit(embed=embed_error)

    except Exception as e:
        embed_error = discord.Embed(
            title="Error Unknow",
            description=f"Une Error inattendue s'est produite : `{str(e)}`",
            color=0x2b2d31
        )
        await message.edit(embed=embed_error)

ALLOWED_CHANNEL_ID = 1346247305266987098 # ID du canal autorisé

@bot.command()
async def sherlock(ctx, username: str):
    if str(ctx.channel.id) != str(1346247305266987098):
        await ctx.send(embed=discord.Embed(
            title="Error",
            description="This command can't be used here.",
            color=0x2b2d31
        ))
        return

    sites = [
        f"https://github.com/{username}",
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
        f"https://www.youtube.com/@{username}",
        f"https://api.mojang.com/users/profiles/minecraft/{username}",
        f"https://www.codewars.com/users/{username}",
        f"https://forum.hackthebox.eu/profile/{username}",
        f"https://replit.com/@{username}",
        f"https://www.chess.com/member/{username}",
        f"https://www.behance.net/{username}",
        f"https://www.soundcloud.com/{username}",
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
                print(f"HTTPError for {url}: {e}")
        except SSLError as e:
            print(f"SSLError for {url}: {e}")
        except RequestException as e:
            print(f"RequestException for {url}: {e}")

    if valid_users:
        results = "\n".join(valid_users)
        embed_dm = discord.Embed(
            title="__Results :__",
            description=results,
            color=0x2b2d31
        )
        embed_dm.set_image(url="https://cdn.discordapp.com/attachments/1286742520021254352/1314232326817054821/wldb_banner.png?ex=67599d3b&is=67584bbb&hm=ae1cd2bef295ed58caa8bc0f52028ed394fa8a4f5be63ea7b52dedf016b2db63&")

        try:
            await ctx.author.send(embed=embed_dm)

            embed_done = discord.Embed(
                title="Result found 🔎, check your DM's !",
                description="**⚠️ Make sure you enabled your DM's !**",
                color=0x2b2d31
            )
            embed_done.set_image(url="https://cdn.discordapp.com/attachments/1286742520021254352/1314232326817054821/wldb_banner.png?ex=67599d3b&is=67584bbb&hm=ae1cd2bef295ed58caa8bc0f52028ed394fa8a4f5be63ea7b52dedf016b2db63&")
            await ctx.send(embed=embed_done)
        except discord.Forbidden:
            await ctx.send("I can't send DM's, make sure they are enabled.")
    else:
        embed_no_results = discord.Embed(
            title="__No results found__",
            description="Nothing found for this user.",
            color=0x2b2d31
        )
        embed_no_results.set_image(url="https://cdn.discordapp.com/attachments/1286742520021254352/1314232326817054821/wldb_banner.png?ex=67599d3b&is=67584bbb&hm=ae1cd2bef295ed58caa8bc0f52028ed394fa8a4f5be63ea7b52dedf016b2db63&")
        await ctx.send(embed=embed_no_results)

@bot.command(name="mc")
async def mc(ctx, username: str):
    ALLOWED_CHANNEL_ID = 1346247305266987098 # ID du canal autorisé

    if ctx.channel.id != ALLOWED_CHANNEL_ID:
        error_embed = discord.Embed(
            title="Error",
            description="This command can't be used here.",
            color=0x2b2d31
        )
        error_embed.set_footer(text="Minecraft Lookup")
        await ctx.send(embed=error_embed)
        return

    mojang_api_url = f"https://api.mojang.com/users/profiles/minecraft/{username}"

    try:
        response = requests.get(mojang_api_url)
        response.raise_for_status()
        data = response.json()

        uuid = data.get("id")
        username = data.get("name")

        session_server_url = f"https://sessionserver.mojang.com/session/minecraft/profile/{uuid}"
        session_response = requests.get(session_server_url)
        session_response.raise_for_status()
        textures_data = session_response.json()

        skin_url = None
        cape_url = None

        for property in textures_data.get("properties", []):
            if property.get("name") == "textures":
                decoded_textures = base64.b64decode(property.get("value")).decode('utf-8')
                textures = json.loads(decoded_textures)
                skin_url = textures.get("textures", {}).get("SKIN", {}).get("url", "None")
                cape_url = textures.get("textures", {}).get("CAPE", {}).get("url", "None")

        embed = discord.Embed(
            title="🎮 Informations du joueur",
            color=0x2b2d31
        )
        embed.add_field(name="Username", value=username, inline=False)
        embed.add_field(name="UUID", value=uuid, inline=False)
        embed.add_field(name="Skin URL", value=f"[Click here]({skin_url})" if skin_url else "None", inline=False)
        embed.add_field(name="Cape URL", value=f"[Click here]({cape_url})" if cape_url else "None", inline=False)
        if skin_url:
            embed.set_thumbnail(url=skin_url)
        embed.set_footer(text="Pluzio Searcher")

        await ctx.send(embed=embed)

    except requests.exceptions.HTTPError:
        await ctx.send(embed=discord.Embed(
            title="Error",
            description=f"Can't found users with `{username}`.",
            color=0x2b2d31
        ))
    except Exception as e:
        await ctx.send(embed=discord.Embed(
            title="Unknow Error",
            description=f"An error occured : {str(e)}",
            color=0x2b2d31
        ))

@bot.command()
async def userinfo(ctx, user_id: int):
    try:
        user = await bot.fetch_user(user_id)
    except discord.NotFound:
        await ctx.send("Can't find user.")
        return

    created_at = user.created_at.strftime("%d/%m/%Y %H:%M:%S")
    is_bot = "Yes" if user.bot else "No"
    discriminator = user.discriminator
    status = "Unknow"
    member = ctx.guild.get_member(user.id) if ctx.guild else None
    is_nitro = "No"
    badges = ["No badge"]

    if member:
        is_nitro = "Yes" if member.premium_since else "No"
        badges = [badge.name for badge in member.public_flags.all()] if member.public_flags else ["Aucun badge"]

    avatar_url = user.avatar.url if user.avatar else "https://www.example.com/default-avatar.png"

    embed = discord.Embed(title=f"Infos of {user.name}#{discriminator}", color=0x2b2d31)
    embed.add_field(name="ID", value=user.id, inline=False)
    embed.add_field(name="Username", value=user.name, inline=False)
    embed.add_field(name="Tag", value=user.mention, inline=False)
    embed.add_field(name="Created", value=created_at, inline=False)
    embed.add_field(name="Bot ?", value=is_bot, inline=False)
    embed.add_field(name="Badges", value=", ".join(badges), inline=False)
    embed.set_thumbnail(url=avatar_url)
    embed.set_footer(text="Pluzio Searcher")

    await ctx.send(embed=embed)

@bot.command()
async def ping(ctx, ip: str):
    """Ping une IP ou un domaine."""
    if platform.system().lower() == "windows":
        cmd = ["ping", "-n", "4", ip]
    else:
        cmd = ["ping", "-c", "4", ip]

    try:
        result = subprocess.run(cmd, stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=True)

        if result.returncode == 0:
            embed = discord.Embed(
                title="Ping result",
                description=f"```\n{result.stdout}\n```",
                color=0x00FF00
            )
        else:
            embed = discord.Embed(
                title="Error while pinging",
                description=f"```\n{result.stderr}\n```",
                color=0x2b2d31
            )

        await ctx.author.send(embed=embed)
        confirmation_embed = discord.Embed(
            title="Result found 🔎, check your DM's !",
            description="**⚠️ Make sure you enabled your DM's !**",
            color=0x2b2d31
        )
        confirmation_embed.set_image(url="https://media.discordapp.net/attachments/1338990274487259197/1346253108266930197/standard_1.gif?ex=67c78369&is=67c631e9&hm=84e5326f194d8f82eb7704669852c71194a54d75fe6cc007fa3a85f094e9c70d&=&width=1020&height=360?ex=6757016f&is=6755afef&hm=cb788c4472a80bf9a8e986142db549584d0e5b6e1dcd56be61750be3e95b9eab&")
        confirmation_embed.set_footer(text="Pluzio Searcher")
        await ctx.send(embed=confirmation_embed)

    except Exception as e:
        error_embed = discord.Embed(
            title="Error",
            description=f"An error occured : {e}",
            color=0x2b2d31
        )
        await ctx.send(embed=error_embed)

api_key = "Z3YxNFFKTUI3Uk1zVWpUTEFORW06NjRjWHNfbS1UeHV6cFJ2N0VlSHJkZ=="
client = SeekApiClient(api_key)

logging.basicConfig(
    level=logging.INFO,
    format="%(asctime)s - %(levelname)s - %(message)s",
    handlers=[logging.FileHandler("bot_logs.log"), logging.StreamHandler()]
)

AUTHORIZED_CHANNEL_ID = 1346247305266987098 # ID du canal autorisé

@bot.command(name="seekbase")
async def seekbase(ctx, *, search_string: str):
    if ctx.channel.id != AUTHORIZED_CHANNEL_ID:
        embed_error = discord.Embed(
            title="Error",
            description="This command can't be used here.",
            color=discord.Color.red()
        )
        await ctx.send(embed=embed_error)

    embed_loading = discord.Embed(
        title="Started searching",
        description=f"Please wait while I search for : `{search_string}`.",
        color=discord.Color.blurple()
    )
    message = await ctx.send(embed=embed_loading)

    try:
        documents = client.search_documents(search_string, display_filename=True, size=1000)

        if not documents:
            embed_no_results = discord.Embed(
                title="No results",
                description=f"No results found for : `{search_string}`.",
                color=discord.Color.red()
            )
            await ctx.send(embed=embed_no_results)
            logging.info(f"No results found for '{search_string}'.")
        else:
            response = f"Results for '{search_string}' :\n\n"
            for doc in documents[:500]:
                filename = doc.get("filename", "Unknow")
                content = doc.get("content", "No data avaible")

                response += f"\n»»————- ★ Found in : {filename} ★ ————-««\n\n"
                response += f"{content}\n"

            if len(response) > 2000:
                with open("search_results.txt", "w", encoding="utf-8") as f:
                    f.write(response)
                await ctx.author.send("The results are too long to be sent here. Here the folder :", file=discord.File("search_results.txt"))
                logging.info(f"Résultats envoyés à {ctx.author} (ID: {ctx.author.id}) via fichier.")
            else:
                await ctx.author.send(response)
                logging.info(f"Résultats envoyés à {ctx.author} (ID: {ctx.author.id}) dans un message direct.")

            embed_success = discord.Embed(
                title="Result found 🔎, check your DM's !",
                description="**⚠️ Make sure you enabled your DM's !**",
                color=discord.Color.green()
            )
            await ctx.send(embed=embed_success)

    except Exception as e:
        logging.error(f"Error lors de la recherche pour '{search_string}': {e}")
        embed_error = discord.Embed(
            title="Error",
            description=f"An error occured : `{e}`.",
            color=discord.Color.red()
        )
        await ctx.send(embed=embed_error)



async def seekbase(ctx, *, search_string: str):
    if ctx.channel.id != AUTHORIZED_CHANNEL_ID:
        embed_error = discord.Embed(
            title="Error",
            description="This command can't be used here.",
            color=discord.Color.red()
        )
        await ctx.send(embed=embed_error)
        logging.warning(f"Tentative d'utilisation de la commande 'search' dans un canal non autorisé par {ctx.author} (ID: {ctx.author.id}).")
        return


    


@bot.command(name="stop")
async def stop(ctx):
    """Arrête le bot uniquement dans le salon autorisé."""
    if ctx.channel.id != 1346247305266987098:  # ID du canal autorisé
        embed_error = discord.Embed(
            title="Error",
            description="This command can't be used here.",
            color=discord.Color.red()
        )
        await ctx.send(embed=embed_error)
        return

    await ctx.send("Stopping bot...")
    await asyncio.sleep(1)
    await ctx.send("Bot stopped.")
    await bot.close()
    

@bot.command(name="reboot")
async def reboot(ctx):
    """Redémarre le bot uniquement dans le salon autorisé."""
    if ctx.channel.id != 1346247305266987098:  # ID du canal autorisé
        embed_error = discord.Embed(
            title="Error",
            description="This command can't be used here.",
            color=discord.Color.red()
        )
        await ctx.send(embed=embed_error)
        return

    await ctx.send("Restarting the bot...")
    await asyncio.sleep(1.5)
    await ctx.send("Restarted.")
    os.execl(sys.executable, sys.executable, *sys.argv)




bot.run(TOKEN)
