const fs = require('fs');

module.exports = {
  name: 'pstock',  // Nom de la commande
  descriptionfr: 'Affiche le stock premium disponible',
  descriptionen: 'Display the stock',
  premium: true,

  /**
   * Exécution de la commande
   * @param {Message} message Le message envoyé par l'utilisateur
   */
  run: async (client, message, args) => {
    try {
      // Récupérer le stock
      const stock = await obtenirStock();

      // Message à envoyer avec les informations sur le stock
      let stockMessage = `Voici le stock disponible :\n`;

      // Boucle pour lire tous les fichiers dans le dossier stock
      for (const service of stock) {
        const filePath = `${__dirname}/../../pstock/${service}`;  // Chemin vers le fichier dans le dossier "stock"

        // Lire le contenu du fichier
        const fileContent = fs.readFileSync(filePath, 'utf-8');
        const lines = fileContent.split(/\r?\n/);  // Diviser le contenu en lignes

        // Vérifier si le stock est vide
        if (lines.length === 0 || (lines.length === 1 && lines[0] === '')) {
          stockMessage += `${service.replace('.txt', '')}: Aucun stock\n`;
        } else {
          stockMessage += `${service.replace('.txt', '')}: ${lines.length} comptes disponibles\n`;
        }
      }

      // Envoyer le message dans le canal (sans embed)
      message.channel.send(stockMessage);

    } catch (error) {
      console.error('Erreur lors de l\'exécution de la commande :', error);
      message.channel.send("Une erreur est survenue lors de l'affichage du stock.");
    }
  }
};

/**
 * Fonction qui récupère les fichiers de stock dans le répertoire "stock/"
 * @returns {Promise<Array>} Liste des fichiers de stock
 */
async function obtenirStock() {
  return new Promise((résoudre, rejeter) => {
    // Lire les fichiers dans le dossier stock à la racine
    fs.readdir(`${__dirname}/../../pstock/`, (err, fichiers) => {
      if (err) {
        console.error('Impossible de scanner le répertoire :', err);
        return rejeter(err);
      }

      // Filtrer les fichiers ayant l'extension ".txt"
      const stock = fichiers.filter(fichier => fichier.endsWith('.txt'));
      résoudre(stock);
    });
  });
}
