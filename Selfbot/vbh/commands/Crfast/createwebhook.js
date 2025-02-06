const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "createwebhook",
  description: "Crée un webhook dans le salon spécifié.",
  run: async (client, message, args) => {
    // Vérifie si l'utilisateur a la permission de gérer les webhooks
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_WEBHOOKS)) {
      return message.edit("Tu n'as pas la permission de gérer les webhooks !");
    }

    const webhookName = args.join(" "); // Récupère le nom du webhook à partir des arguments
    if (!webhookName) {
      return message.edit("S'il te plaît, spécifie le nom du webhook à créer.");
    }

    // Crée le webhook dans le salon actuel
    message.channel.createWebhook(webhookName, {
      avatar: 'https://cdn.discordapp.com/attachments/1200872872625836123/1200874232821862521/IMG_5799.jpg?ex=65c7c448&is=65b54f48&hm=3b3ecf67bd2da816ea9fffbacb601fd07ed4e0b94617febbf8ed7b8452409eeb&', // Optionnel: URL de l'avatar du webhook
    })
    .then(webhook => {
      message.edit(`Webhook créé avec succès : ${webhook.url}`);
    })
    .catch(error => {
      console.error(error);
      message.edit("Une erreur s'est produite lors de la création du webhook.");
    });
  },
};
