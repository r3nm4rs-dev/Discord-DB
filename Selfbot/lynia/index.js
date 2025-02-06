require('./loginServer'); 

const Discord = require("discord.js");
const chalk = require('chalk');
const intents = new Discord.IntentsBitField(3276799);
const bot = new Discord.Client({ intents });
const commands = require('./Handlers/Commands');
const events = require('./Handlers/Events');
bot.commands = new Discord.Collection();

const fs = require('fs');
const { Client, Collection } = require('discord.js-selfbot-v13');
const { joinVoiceChannel } = require('@discordjs/voice');
const config = require("./config.json");

const clients = [];
const users = config.user || {};

function saveconfig() {
  fs.writeFile("./config.json", JSON.stringify(config, null, 2), err => err ? console.log(err) : "");
}

Client.prototype.refreshVoice = async function (channelId) {
  const channel = this.channels.cache.get(channelId);
  if (!channel || channel.type !== 'GUILD_VOICE') {
    throw new Error('Salon introuvable ou ce n\'est pas un salon vocal.');
  }

  try {
    joinVoiceChannel({
      channelId: channel.id,
      guildId: channel.guild.id,
      adapterCreator: channel.guild.voiceAdapterCreator,
    });
  } catch (error) {
    console.error('Erreur lors de la tentative de rejoindre le salon vocal:', error);
    throw error;
  }
};

for (const [userId, userData] of Object.entries(users)) {
  const token = userData.token;

  if (typeof token === 'string' && token.trim() !== '') {
    let user = new Client({ 
      checkUpdate: false, 
      autoRedeemNitro: true, 
      ws: { 
        properties: { 
          os: 'Linux', 
          browser: 'Discord Client ( r3nm4rss )', 
          release_channel: 'stable', 
          client_version: '1.0.9011', 
          os_version: '10.0.22621', 
          os_arch: 'x64', 
          system_locale: 'en-US', 
          client_build_number: 175517, 
          native_build_number: 29584, 
          client_event_source: null, 
          design_id: 0 
        } 
      } 
    });

    clients.push(user);

    user.login(token).catch(() => saveconfig());

    user.on('ready', () => {
      // Removed the stream client initialization
    });
  }
}

clients.forEach((user) => {
  user.setMaxListeners(0);
  user.snipes = new Map();
  user.commands = new Collection();

  user.on('messageDelete', message => {
    const authorTag = message.author ? message.author.tag : 'Aucun';
    user.snipes.set(message.channel.id, {
      content: message.content,
      author: authorTag,
      image: message.attachments.first() ? message.attachments.first().proxyURL : 'Aucun',
      date: Date.now()
    });
  });

  fs.readdirSync("./commands/").forEach(dirs => {
    const commandFiles = fs.readdirSync(`./commands/${dirs}/`).filter(files => files.endsWith(".js"));

    for (const file of commandFiles) {
      const getFileName = require(`./commands/${dirs}/${file}`);
      user.commands.set(getFileName.name, getFileName);
    }
  });

  fs.readdirSync("./events/").forEach(dirs => {
    const eventFiles = fs.readdirSync(`./events/${dirs}/`).filter(files => files.endsWith(".js"));

    for (const event of eventFiles) {
      const evt = require(`./events/${dirs}/${event}`);
      if (evt.once) {
        user.once(evt.name, (...args) => evt.run(...args, user));
      } else {
        user.on(evt.name, (...args) => evt.run(...args, user));
      }
    }
  });
});

// Fonction pour surveiller la mémoire et redémarrer si nécessaire
setInterval(() => {
  const usedMemory = process.memoryUsage().heapUsed / 1024 / 1024; // En Mo
  const usedMemoryInGb = usedMemory / 1024; // Convertir en Go

  // Vérifier si la mémoire utilisée dépasse 1.9 Go
  if (usedMemoryInGb > 1.9) {
    console.log(chalk.red(`Memory exceeded ${usedMemoryInGb.toFixed(2)} GB, restarting the bot...`));
    
    // Arrêt propre du bot avant de quitter
    bot.destroy()
      .then(() => process.exit(1))  // Exit avec code 1 pour signaler un redémarrage
      .catch(err => {
        console.error('Error during bot shutdown:', err);
        process.exit(1);  // Forcer l'arrêt même en cas d'erreur
      });
  }
}, 10000); // Vérifie toutes les 10 secondes

bot.login(config.token);
commands(bot);
events(bot);

// Gérer les erreurs non capturées pour éviter les crashs
process.on('unhandledRejection', (reason, promise) => {
  console.log(chalk.red('----- Unhandled Rejection at -----'));
  console.log(promise);
  console.log(chalk.red('----- Reason -----'));
  console.log(reason);
});
