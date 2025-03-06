const fs = require('fs');

const generated = new Set();  // Set pour gérer les utilisateurs déjà générés

module.exports = {
  name: 'gen',
  descriptionfr: 'Genère un compte si il y a du stock (NE PAS FAIRE EN PUBLIQUE)',
  descriptionen: 'Generate an account if got stock (DONT MAKE THIS IN PUBLIC)',
  run: async (client, message, args) => {
    const service = args[0];

    if (!service) {
      return message.channel.send("Erreur : vous devez spécifier un service.");
    }

    const filePath = `${__dirname}/../../stock/${service}.txt`;

    console.log(`Chemin du fichier : ${filePath}`);  // Log du chemin du fichier

    // Vérification si le fichier existe
    fs.access(filePath, fs.constants.F_OK, (err) => {
      if (err) {
        console.log(`Erreur : le fichier ${filePath} n'existe pas.`);  // Log si le fichier n'existe pas
        return message.channel.send(`Erreur : Le service \`${service}\` n'existe pas.`);
      }

      // Lire le fichier de stock
      fs.readFile(filePath, 'utf8', function (error, data) {
        if (error || !data) {
          console.log("Rupture");  // Log si erreur de lecture
          return message.channel.send(`Plop! Rupture de stock pour \`${service}\` Consulte le stock : &stock.`);
        }

        data = data.trim();
        const accounts = data.split('\n');

        // Vérifier si des comptes sont disponibles
        if (accounts.length === 0 || accounts[0] === '') {
          console.log(`Rupture de stock pour le service ${service}.`);  // Log en cas de rupture de stock
          return message.channel.send(`Rupture de stock : Aucun compte disponible pour \`${service}\` !`);
        }

        // Si l'utilisateur a déjà généré récemment, attendre
        if (generated.has(message.author.id)) {
          return message.channel.send("Veuillez patienter 10 minutes avant de regénerer");
        }

        // Récupérer le premier compte
        const firstAccount = accounts[0];

        // Supprimer le compte généré du fichier
        const updatedAccounts = accounts.slice(1).join('\n');
        fs.writeFile(filePath, updatedAccounts, (writeError) => {
          if (writeError) {
            console.log("Erreur lors de la mise à jour du stock.");  // Log si erreur d'écriture
            return message.channel.send("Erreur lors de la mise à jour du stock.");
          }

          // Envoyer le compte généré
          message.channel.send(`Compte généré pour le service \`${service}\` : ${firstAccount} <Conservez le compte, il n'y a aucun logs.>`);

          // Ajouter à l'ensemble 'generated' pour empêcher les générations rapides
          generated.add(message.author.id);

          // Attendre le cooldown avant de permettre une nouvelle génération
          setTimeout(() => {
            generated.delete(message.author.id);
          }, 600000);  // Attendre 1 minute avant de pouvoir regénérer
        });
      });
    });
  }
};
