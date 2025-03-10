const fs = require('fs');
const path = require('path');

module.exports = {
  name: "setmute",
  descriptionfr: "Active ou désactive le mute lors d'un joinvc",
  descriptionen: "Enable or disable the mute when joinvc",
  usage: "<on/off>",
  run: async (client, message, args) => {
    const userId = message.author.id; // Get the user ID from the message author
    const dbPath = path.join(__dirname, '../../container/db', `${userId}.json`); // Construct the path to the user's JSON file

    // Check if the user's DB file exists
    if (!fs.existsSync(dbPath)) {
      return message.edit("Aucune configuration trouvée pour cet utilisateur.");
    }

    // Load the user's DB file
    let userDb = require(dbPath); // Load the user's JSON data

    if (!args[0] || (args[0] !== "on" && args[0] !== "off")) {
      return message.edit("Paramètre manquant: `on` ou `off`");
    }

    if (args[0] === "on") {
      userDb.voicemute = true; // Set mute to true
      fs.writeFileSync(dbPath, JSON.stringify(userDb, null, 2)); // Save changes back to the file
      client.refreshVoice(); // Refresh voice settings
      message.edit(`Vous serez mute lors d'un joinvc`);
    } else {
      userDb.voicemute = false; // Set mute to false
      fs.writeFileSync(dbPath, JSON.stringify(userDb, null, 2)); // Save changes back to the file
      client.refreshVoice(); // Refresh voice settings
      message.edit(`Vous ne serez pas mute lors d'un joinvc`);
    }
  }
};
