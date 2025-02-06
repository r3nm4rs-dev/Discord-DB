const Discord = require('discord.js-selfbot-v13');

const chalk = require('chalk');

module.exports = {

  name: 'creategroup',

  description: 'Créer un groupe DM avec l’utilisateur et le renommer Pluzio automatiquement',

  run: async (client, message) => {

    try {

      // L'utilisateur qui lance la commande

      const userId = message.author.id;

      // Créer un groupe DM avec l'utilisateur lui-même

      const groupDM = await client.channels.createDMGroup([userId]);

      

      // Si le groupe DM est créé avec succès, on le renomme

      await groupDM.edit({

        name: 'Pluzio' // Nouveau nom du groupe

      });

      // Envoyer un message de confirmation dans le groupe

      await groupDM.send(`

        **Welcome to Pluzio panel** 🌟

        

        **Prefix :** &

        ➤ This panel is created when connecting to the selfbot Pluzio.

        ➤ Do not use commands in public, other users can report you.

        ➤ If you got problems, contact us with help commands.

        Pls leave a review. 😄

      `);

      console.log(chalk.green(`Groupe DM créé et renommé en Nexus pour l'utilisateur ${userId}.`));

    } catch (error) {

      console.error(chalk.red('Erreur lors de la création et du renommage du groupe DM :'), error);

      message.reply('Une erreur est survenue lors de la création et du renommage du groupe.');

    }

  },

};