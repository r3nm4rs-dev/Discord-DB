const fs = require('fs');
const { language } = require("../../fonctions");

module.exports = {
  name: "setlight",
  description: "Modifie le thème de ton client en mode éclairé",
  run: async (client, message, args) => {
    client.settings.setTheme("light");
    message.edit(await language(client, 
      "Votre thème a été modifié", 
      "Your theme has been modified"
    ));
  }
};
