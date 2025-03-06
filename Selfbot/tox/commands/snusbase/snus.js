const axios = require('axios');
const fs = require('fs');
const path = require('path');

const snusbaseAuth = 'sb6sffauk36ll3n9ysf05f5vxwkcr9'; // Clé d'authentification de l'API Snusbase
const snusbaseApi = 'https://api.snusbase.com/data/search'; // URL de l'API Snusbase

module.exports = {
  name: 'snus',
  descriptionfr: 'Cherche un terme via l\'API Snusbase',
  descriptionen: 'Search for a term via the Snusbase API',
  usage: '[term]',
  async run(client, message, args) {
    const searchTerm = args.join(' ');
    if (!searchTerm) {
      return message.channel.send('Veuillez fournir un terme de recherche.');
    }

    message.channel.send('Recherche Snusbase en cours...');

    let searchType;
    if (/^[\w.-]+@[\w.-]+$/.test(searchTerm)) searchType = 'email';
    else if (/^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$/.test(searchTerm)) searchType = 'ip';
    else if (/^[\w.-]+$/.test(searchTerm)) searchType = 'username';
    else if (/^[\w@#$%^&+=]{6,}$/.test(searchTerm)) searchType = 'password';
    else if (/^[a-fA-F0-9]+$/.test(searchTerm)) searchType = 'hash';
    else return message.channel.send('Type de recherche invalide. Veuillez saisir une adresse e-mail, une adresse IP, un nom d\'utilisateur, un mot de passe ou un hash.');

    try {
      const response = await axios.post(snusbaseApi, {
        terms: [searchTerm],
        types: [searchType],
        wildcard: false
      }, {
        headers: {
          'Auth': snusbaseAuth,
          'Content-Type': 'application/json',
        }
      });

      // Préparation des résultats
      const searchDescription = `Searching for '${searchTerm}' (${searchType}) in Snusbase.`;
      const rawSearchResult = `\nResults for :\n${JSON.stringify(response.data, null, 4)}`;

      // Contenu du fichier aura.txt
      const formattedResults = `
Pluzio Snusbase
`;

      const completeResult = searchDescription + '\n\n' + formattedResults + rawSearchResult;

      // Créer le fichier aura.txt
      const filePath = path.join(__dirname, 'pluzio.txt');
      fs.writeFile(filePath, completeResult, (err) => {
        if (err) {
          console.error('Erreur lors de l\'écriture du fichier aura.txt:', err);
          return message.reply('Une erreur est survenue lors de la création du fichier.');
        }

        // Envoyer le fichier dans le même canal où la commande a été exécutée
        message.reply({
          content: 'Here the results of your research :',
          files: [filePath]
        })
        .then(() => {
          console.log('Le fichier tox.txt a été envoyé dans le canal.');
        })
        .catch(error => {
          console.error('Erreur lors de l\'envoi du fichier dans le canal:', error);
          message.reply('Une erreur est survenue lors de l\'envoi du fichier.');
        })
        .finally(() => {
          // Supprimer le fichier après l'envoi
          fs.unlinkSync(filePath);
        });
      });
    } catch (error) {
      console.error('Erreur lors de la recherche Snusbase:', error);
      message.channel.send('Une erreur est survenue lors de la recherche.');
    }
  }
};
