const Discord = require("discord.js-selfbot-v13");
const fs = require("fs");

module.exports = {
  name: "create",
  description: "Crée un emoji à partir d'une image.",
  run: async (client, message, args) => {
    // Vérifie si l'utilisateur a la permission de gérer les emojis
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_EMOJIS)) {
      return message.edit("Tu n'as pas la permission de créer des emojis !");
    }

    // Vérifie si l'image est fournie
    if (!args.length) {
      return message.edit("S'il te plaît, envoie l'image que tu veux utiliser comme emoji.");
    }

    // Récupère l'image
    const image = await message.attachments.first().fetch();

    // Vérifie le format de l'image
    if (!image.contentType.startsWith("image/")) {
      return message.edit("Le fichier fourni n'est pas une image.");
    }

    // Convertit l'image en buffer
    const imageBuffer = await image.buffer();

    // Définit le nom de l'emoji
    const emojiName = args.join("_").replace(/ /g, "_"); // Remplace les espaces par des underscores

    // Crée l'emoji
    message.guild.emojis.create(emojiName, imageBuffer)
    .then(emoji => {
      message.edit(`Emoji créé avec succès : ${emoji.name} (\`${emoji.id}\`)`);
    })
    .catch(error => {
      console.error(error);
      message.edit("Une erreur s'est produite lors de la création de l'emoji.");
    });
  },
};
