const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "rolemenu",
  description: "Créé un rolemenu",
  usage: "<roleId> <messageId> <emote>",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json');
    let config;

    try {
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Error reading config.json", err);
      return message.edit(language(client, 
        "Erreur lors de la lecture de la configuration.", 
        "Error reading configuration."
      ));
    }

    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(language(client, 
        "*Vous n'êtes pas éligible au mode :* `premium`", 
        "*You are not eligible for the mode:* `premium`"
      ));
    }

    if (!message.guild) {
      return message.edit(language(client, 
        "Veuillez executer cette commande dans un serveur", 
        "Please run this command on a server"
      ));
    }

    if (!message.guild.members.me.permissions.has("MANAGE_GUILD")) {
      return message.edit(language(client, 
        "Vous n'avez pas les permissions nécessaires pour executer cette commande", 
        "You do not have the necessary permissions to run this command"
      ));
    }

    const role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0]);
    if (!role) {
      return message.edit(language(client, 
        `Aucun rôle de trouvé pour \`${args[0] || "rien"}\``, 
        `No role found for \`${args[0] || "nothing"}\``
      ));
    }
    if (!role.editable) {
      return message.edit(language(client, 
        "Vous ne pouvez pas donner ce rôle", 
        "You cannot give this role"
      ));
    }

    const messages = await message.channel.messages.fetch(args[1]).catch(() => null);
    if (!messages) {
      return message.edit(language(client, 
        `Aucun message de trouvé dans ce salon pour \`${args[1] || "rien"}\``, 
        `No message found in this channel for \`${args[1] || "nothing"}\``
      ));
    }

    messages.react(args[2])
      .then(() => {
        db.rolemenus.push({
          emotes: args[2],
          msgsid: messages.id,
          roleid: role.id
        });
        client.save();
        return message.edit(language(client, 
          "Le rolemenu a été créé", 
          "The rolemenu has been created"
        ));
      })
      .catch(() => {
        return message.edit(language(client, 
          `Aucune reaction de trouvée pour \`${args[2] || "rien"}\``, 
          `No reaction found for \`${args[2] || "nothing"}\``
        ));
      });
  }
};
