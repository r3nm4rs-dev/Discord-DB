const fs = require('fs');
const { language } = require("../../fonctions");

module.exports = {
  name: "setdark",
  description: "Modifie le thème de ton client en mode sombre",
  run: async (client, message, args) => {
    client.settings.setTheme("dark");
    message.edit(await language(client, 
      "Votre thème a été modifié", 
      "Your theme has been modified"
    ));
  }
};
