const fs = require('fs');
const path = require('path');

module.exports = {
  name: 'recherche',
  descriptionfr: 'Obtenir des tools disponibles',
  descriptionen: 'Get tools from the storage',
  usage: '<film>',
  run: async (client, message, args) => {
    if (!args[0]) {
      return message.edit('Veuillez entrer un nom de tool après la commande.');
    }

    // Charger le fichier storage.json
    const storageFilePath = path.join(__dirname, '../../storage.json');

    fs.readFile(storageFilePath, 'utf8', (err, data) => {
      if (err) {
        console.error('Erreur de lecture du fichier storage.json:', err);
        return message.edit('Désolé, une erreur est survenue lors de la recherche du film.');
      }

      let films;
      try {
        films = JSON.parse(data); // Parser le fichier JSON
      } catch (parseError) {
        console.error('Erreur de parsing JSON:', parseError);
        return message.edit('Désolé, une erreur est survenue avec les données du film.');
      }

      // Trouver le film dans la liste
      const filmName = args.join(' ').toLowerCase(); // Assurer que la recherche est insensible à la casse
      const film = films.find(f => f.title.toLowerCase() === filmName);

      if (!film) {
        return message.edit(`Désolé, nous n'avons pas trouvé d'informations pour le tool **${args.join(' ')}**.`);
      }

      // Créer un message avec la description du film
      const filmDescription = `**${film.title}**\n\n${film.description}\n\nCatégorie: ${film.category}`;

      // Modifier le message avec la description du film
      message.edit(filmDescription);
    });
  },
};
