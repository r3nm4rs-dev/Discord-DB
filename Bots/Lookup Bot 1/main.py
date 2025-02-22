import discord
from discord.ext import commands
import os
import asyncio
from concurrent.futures import ThreadPoolExecutor
import aiofiles

# Créer une instance du bot avec intents complets
bot = commands.Bot(command_prefix="+", intents=discord.Intents.all())

# Dossier où sont stockées les licences FiveM
DUMP_FOLDER = 'dump'

# Liste des encodages à essayer pour lire les fichiers
ENCODINGS = ['utf-8', 'latin-1', 'cp1252']

# Limite le nombre de tâches concurrentes
MAX_CONCURRENT_TASKS = 20

# Taille maximale des blocs à lire (en octets)
BLOCK_SIZE = 1024 * 1024  # 1 Mo

# Temps limite pour traiter un fichier (en secondes)
FILE_PROCESSING_TIMEOUT = 5

# Exécuteur pour les opérations de lecture de fichiers
executor = ThreadPoolExecutor(max_workers=MAX_CONCURRENT_TASKS)

# Fonction asynchrone pour lire un fichier par blocs
async def read_file_in_chunks(file_path, license, found_event):
    for encoding in ENCODINGS:
        try:
            async with aiofiles.open(file_path, mode='r', encoding=encoding, errors='ignore') as f:
                while True:
                    content = await f.read(BLOCK_SIZE)
                    if not content:
                        break
                    if license in content:
                        return content
        except Exception as e:
            print(f"Erreur avec l'encodage {encoding} pour le fichier {file_path}: {e}")
    return None

# Fonction pour traiter un fichier (lecture et extraction des données)
async def process_file(file_path, license, results, found_event):
    if found_event.is_set():
        return

    try:
        content = await asyncio.wait_for(read_file_in_chunks(file_path, license, found_event), timeout=FILE_PROCESSING_TIMEOUT)
        if content:
            associated_info = next((line.strip() for line in content.split('\n') if license in line), None)
            if associated_info:
                results.append(associated_info)
                found_event.set()
    except asyncio.TimeoutError:
        print(f"Le traitement du fichier {file_path} a dépassé le temps limite.")
    except Exception as e:
        print(f"Erreur lors du traitement du fichier {file_path}: {e}")

# Définir la commande +vip via le système de commandes de préfixe
@bot.command(name="vip", help="Rechercher des informations pour une licence FiveM")
async def vip(ctx, *, license: str):
    embed = discord.Embed(title="VIP Recherche", description="Recherche en cours...", color=0x00ff00)
    await ctx.send(embed=embed)

    found_event = asyncio.Event()
    results = []

    semaphore = asyncio.Semaphore(MAX_CONCURRENT_TASKS)

    async def sem_task(file_path):
        async with semaphore:
            await process_file(file_path, license, results, found_event)

    files_to_process = [os.path.join(root, file)
                        for root, _, files in os.walk(DUMP_FOLDER)
                        for file in files if file.endswith(('.txt', '.sql'))]

    tasks = [sem_task(file_path) for file_path in files_to_process]
    await asyncio.gather(*tasks, return_exceptions=True)

    if results:
        results_message = results[0]
        embed = discord.Embed(
            title="Résultat de la Recherche",
            description=results_message,
            color=0xffff00
        )
        try:
            await ctx.author.send(embed=embed)
            await ctx.send("Les résultats ont été envoyés en message privé.")
        except discord.Forbidden:
            await ctx.send("Je ne peux pas vous envoyer de message privé. Veuillez vérifier vos paramètres de confidentialité.")
        except discord.HTTPException as e:
            print(f"Erreur lors de l'envoi du message: {e}")
            await ctx.send("Erreur lors de l'envoi du message privé. Veuillez réessayer plus tard.")
    else:
        embed = discord.Embed(
            title="Aucune Information Trouvée",
            description="Aucune information trouvée pour cette licence.",
            color=0xffff00
        )
        await ctx.send(embed=embed)

# Événement pour indiquer que le bot est prêt
@bot.event
async def on_ready():
    print(f"{bot.user} est connecté et prêt à l'emploi.")

# Démarrer le bot avec le token
bot.run('')
