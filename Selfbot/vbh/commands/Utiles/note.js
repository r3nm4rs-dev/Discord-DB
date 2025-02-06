const Discord = require("discord.js-selfbot-v13");
const fs = require('fs');
const path = require('path');

// Chemin du fichier JSON pour stocker les notes
const notesFilePath = path.join(__dirname, 'notes.json');

// Charger les notes existantes ou créer un objet vide
let notes = {};
if (fs.existsSync(notesFilePath)) {
  notes = JSON.parse(fs.readFileSync(notesFilePath, 'utf8'));
}

module.exports = {
  name: "notes",
  description: "Gère vos notes personnelles",
  run: async (client, message, args, db, prefix) => {
    // Commande pour ajouter une note
    if (args[0] === "add") {
      const noteContent = args.slice(1).join(" ");
      if (!noteContent) {
        return message.edit("Veuillez fournir un contenu pour la note.");
      }

      const noteId = Date.now(); // Utilise le timestamp comme ID unique
      notes[noteId] = noteContent;

      // Enregistrer les notes
      fs.writeFileSync(notesFilePath, JSON.stringify(notes, null, 2));

      message.edit(`Note ajoutée avec succès. ID: \`${noteId}\``);
    }

    // Commande pour lister toutes les notes
    else if (args[0] === "list") {
      if (Object.keys(notes).length === 0) {
        return message.edit("Aucune note enregistrée.");
      }

      let noteList = "Liste de vos notes:\n";
      for (const [id, content] of Object.entries(notes)) {
        noteList += `\`ID: ${id}\` - **${content}**\n`;
      }

      message.edit(noteList);
    }

    // Commande pour supprimer une note
    else if (args[0] === "delete") {
      const noteId = args[1];
      if (!noteId || !notes[noteId]) {
        return message.edit("Veuillez fournir un ID de note valide à supprimer.");
      }

      delete notes[noteId];
      fs.writeFileSync(notesFilePath, JSON.stringify(notes, null, 2));
      message.edit(`Note avec ID ${noteId} supprimée.`);
    }

    // Ajoutez d'autres sous-commandes si nécessaire
  },
};

