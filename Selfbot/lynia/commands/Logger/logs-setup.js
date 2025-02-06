const { Permissions } = require("discord.js-selfbot-v13");
const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "logs-setup",
  description: "Setup le panel de logs",
  usage: "[server ID]",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json');
    let config;

    try {
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Error reading config.json", err);
      return message.edit(await language(client, 
        "Erreur lors de la lecture de la configuration.", 
        "Error reading configuration."
      ));
    }

    // Vérification de l'éligibilité au mode premium
    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, 
        "*Vous n'êtes pas éligible au mode :* `premium`", 
        "*You are not eligible for the mode:* `premium`"
      ));
    }

    const userDbPath = path.join(__dirname, '../../db', `${message.author.id}.json`);
    let userDb;

    try {
      userDb = JSON.parse(fs.readFileSync(userDbPath, 'utf8'));
    } catch (err) {
      console.error("Error reading user database", err);
      return message.edit(await language(client, 
        "Erreur lors de la lecture de votre base de données.", 
        "Error reading your database."
      ));
    }

    const guild = client.guilds.cache.get(args[0]) || message.guild;
    if (!guild) {
      return message.edit(await language(client, 
        'Veuillez utiliser cette commande dans un serveur', 
        'Please use this command in guild'
      ));
    }

    if (!guild.members.me.permissions.has("MANAGE_CHANNELS") || !guild.members.me.permissions.has("MANAGE_WEBHOOKS")) {
      return message.edit(await language(client, 
        `Vous n'avez pas les permissions nécessaires pour executer cette commande`, 
        `You do not have the necessary permissions to run this command`
      ));
    }

    const cat = await guild.channels.create(userDb.name, {
      type: "GUILD_CATEGORY",
      position: 0,
      permissionOverwrites: [
        { id: message.author.id, allow: [Permissions.FLAGS.VIEW_CHANNEL] },
        { id: guild.id, deny: [Permissions.FLAGS.VIEW_CHANNEL] }
      ]
    });

    const channel = await guild.channels.create(userDb.name + " logger", {
      type: "GUILD_TEXT",
      permissionOverwrites: [
        { id: message.author.id, allow: [Permissions.FLAGS.VIEW_CHANNEL] },
        { id: guild.id, deny: [Permissions.FLAGS.VIEW_CHANNEL] }
      ]
    });

    channel.setParent(cat.id);

    const webhook = await channel.createWebhook(`${userDb.name} | LOGGER`, {
      avatar: "https://i.ibb.co/vY5fkvr/nexus.webp"
    });

    userDb.logger = webhook.url;
    userDb.ologger = true;
    await fs.promises.writeFile(userDbPath, JSON.stringify(userDb));

    message.edit(await language(client, 
      "Le setup a été fini", 
      "The setup has been finished"
    ));
  }
};
