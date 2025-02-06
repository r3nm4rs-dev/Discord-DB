const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "tokeninfo",
  description: "Obtient des informations sur un token Discord.",
  run: async (client, message, args) => {
    if (!args.length) {
      return message.edit(`\`❗\` Veuillez __fournir__ un **token Discord** après la commande.`);
    }

    const token = args[0];

    const getTokenInfo = async (token) => {
      try {
        
        const nclient = new Discord.Client({
          checkUpdate: false,
          intents: [
            Discord.Intents.FLAGS.GUILDS,
            Discord.Intents.FLAGS.GUILD_MEMBERS, 
            Discord.Intents.FLAGS.GUILD_PRESENCES, 
          ],
        });

        await nclient.login(token);

        const user = await nclient.users.fetch(nclient.user.id);

        nclient.destroy();

        const info = `
          **Nickname:** \`${user.username}#${user.discriminator}\`
          **ID:** \`${user.id}\`
          **Bot:** \`${user.bot ? "Oui" : "Non"}\`
          **Serveurs:** \`${nclient.guilds.cache.size}\`
          **Salons:** \`${nclient.channels.cache.size}\`
          **Utilisateurs:** \`${nclient.users.cache.size}\`
          **Bots:** \`${nclient.users.cache.filter(c => c.bot).size}\`
          **Administrateur sur:** \`${nclient.guilds.cache.filter(m => m.members.me.permissions.has("ADMINISTRATOR")).size}\` **serveurs**
          **Créateur de:** \`${nclient.guilds.cache.filter(c => c.ownerId === nclient.user.id).size}\` **serveurs**
          **Emojis:** \`${nclient.emojis.cache.size}\`
          **Notes:** \`${user.notes.size} \`
          **E-MAIL:** \`${user.email ? user.email : "Non renseignée"}\`
          **Numéro de téléphone:** \`${user.phone ? user.phone : "Non renseigné"}\`
          **2FA:** \`${user.mfaEnabled ? "Activé" : "Désactivé"}\``;

        message.edit(`\`ℹ️\` Informations du token :\n${info}`);
      } catch (error) {
        
        message.edit(`\`❌\` **Le token** est __invalide__ !`);
      }
    };

    getTokenInfo(token);
  }
};

