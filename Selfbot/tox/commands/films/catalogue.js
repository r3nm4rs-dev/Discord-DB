const fs = require('fs');
const path = require('path');

module.exports = {
  name: 'catalogue',
  descriptionfr: 'Envoie la liste des tools disponibles',
  descriptionen: 'Sends the list of available tools',
  usage: '',
  run: async (client, message, args) => {
    // Charger le fichier storage.json
    const storageFilePath = path.join(__dirname, '../../storage.json');

    fs.readFile(storageFilePath, 'utf8', (err, data) => {
      if (err) {
        console.error('Erreur de lecture du fichier storage.json:', err);
        return message.reply('Désolé, une erreur est survenue lors de la récupération du catalogue.');
      }

      let films;
      try {
        films = JSON.parse(data); // Parser le fichier JSON
      } catch (parseError) {
        console.error('Erreur de parsing JSON:', parseError);
        return message.reply('Désolé, une erreur est survenue avec les données du catalogue.');
      }

      // Créer une liste des titres de films
      const filmTitles = films.map(film => film.title).join('\n');

      // Créer un fichier .txt avec les titres
      const catalogueFilePath = path.join(__dirname, '../../tools.txt');

      fs.writeFile(catalogueFilePath, filmTitles, (writeErr) => {
        if (writeErr) {
          console.error('Erreur lors de l\'écriture du fichier tools.txt:', writeErr);
          return message.reply('Désolé, une erreur est survenue lors de la création du catalogue.');
        }

        // Envoyer le fichier dans le même canal où la commande a été exécutée
        message.reply({
          content: 'Voici la liste des tools disponibles :',
          files: [catalogueFilePath]
        })
        .then(() => {
          console.log('Le fichier tools.txt a été envoyé dans le canal.');
        })
        .catch(error => {
          console.error('Erreur lors de l\'envoi du fichier dans le canal:', error);
          message.reply('Désolé, une erreur est survenue lors de l\'envoi du catalogue.');
        });
      });
    });
  },
};
