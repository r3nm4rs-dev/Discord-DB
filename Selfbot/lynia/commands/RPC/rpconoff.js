const fs = require('fs');
const path = require('path');
const { RichPresence } = require('discord.js-selfbot-v13');

module.exports = {
  name: "rpc",
  descriptionfr: "Active ou désactive la présence RPC",
  descriptionen: "Enables or disables RPC presence",
  run: async (client, message, args) => {
    try {
      const userId = message.author.id;
      const filePath = path.join('/home/container/db', `${userId}.json`);

      let userDB;
      try {
        const data = fs.readFileSync(filePath, 'utf8');
        userDB = JSON.parse(data);
      } catch (err) {
        console.error('Erreur lors de la lecture du fichier JSON:', err);
        return await message.edit('Impossible de lire les données utilisateur.');
      }

      if (!args[0]) {
        return await message.edit('Veuillez spécifier "on" ou "off".');
      }

      if (args[0].toLowerCase() === "on") {
        userDB.rpconoff = true; // Active la présence RPC

        // Mise à jour du RPC
        updateRPC(client, userDB);

        await message.edit("La présence RPC est maintenant **activée**.");
      } else if (args[0].toLowerCase() === "off") {
        userDB.rpconoff = false; // Désactive la présence RPC
        client.user.setActivity(""); // Supprime l'activité
        await message.edit("Le RPC est maintenant **désactivé**.");
      } else {
        return await message.edit('Argument invalide. Veuillez spécifier "on" ou "off".');
      }

      // Écriture des nouvelles données dans le fichier JSON
      try {
        fs.writeFileSync(filePath, JSON.stringify(userDB, null, 2), 'utf8');
      } catch (err) {
        console.error('Erreur lors de l\'écriture du fichier JSON:', err);
        return await message.edit('Impossible de mettre à jour les données utilisateur.');
      }

    } catch (error) {
      console.error('Erreur lors de l\'exécution de la commande rpc:', error);
      await message.edit('Une erreur est survenue lors de la configuration de la présence RPC.');
    }
  }
};

const updateRPC = (client, db) => {
  if (!db.rpconoff) return;

  const r = new RichPresence(client);

  if (db.rpctitle) r.setName(db.rpctitle);
  if (db.rpcdetails) r.setDetails(db.rpcdetails);
  if (db.rpcstate) r.setState(db.rpcstate);
  if (db.rpctype) r.setType(db.rpctype);
  if (db.rpctime) r.setStartTimestamp(db.rpctime);

  if (db.rpcsmallimage) r.setAssetsSmallImage(db.rpcsmallimage);
  if (db.rpcsmallimagetext) r.setAssetsSmallText(db.rpcsmallimagetext);
  if (db.rpclargeimage) r.setAssetsLargeImage(db.rpclargeimage);
  if (db.rpclargeimagetext) r.setAssetsLargeText(db.rpclargeimagetext);

  if (db.rpcplatform) r.setPlatform(db.rpcplatform);

  // Ajout des boutons ici
  if (db.buttontext1 && db.buttonlink1) r.addButton(db.buttontext1, db.buttonlink1);
  if (db.buttontext2 && db.buttonlink2) r.addButton(db.buttontext2, db.buttonlink2);

  client.user.setActivity(r);
};
