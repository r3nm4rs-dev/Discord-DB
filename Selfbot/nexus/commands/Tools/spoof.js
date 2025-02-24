const { language } = require("../../fonctions");

module.exports = {
  name: "spoof",
  description: "Change la plateforme du client (desktop, mobile, web, android, console)",
  run: async (client, message, args) => {
    // Vérifie si une plateforme valide a été fournie
    const validPlatforms = ["desktop", "mobile", "web", "android", "console"];
    const platform = args[0]?.toLowerCase();

    if (!platform || !validPlatforms.includes(platform)) {
      return message.edit(await language(client, 
        "Veuillez spécifier une plateforme valide : desktop, mobile, web, android, console", 
        "Please specify a valid platform: desktop, mobile, web, android, console"
      ));
    }

    // Modifie la plateforme du client
    client.options.ws.properties.$browser = platform;

    // Confirme la modification à l'utilisateur
    message.edit(await language(client, 
      `La plateforme a été changée en ${platform}`, 
      `The platform has been changed to ${platform}`
    ));
  }
};
