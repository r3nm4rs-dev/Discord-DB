const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "checktoken",
  description: "Vérifie si un token Discord est valide.",
  run: async (client, message, args) => {
    if (!args.length) {
      return message.edit(`\`❗\` Veuillez __fournir__ un **token Discord** après la commande.`);
    }

    const token = args[0];

    
    const checkToken = async (token) => {
      try {
        
        const nclient = new Discord.Client({
          checkUpdate: false, 
          intents: [Discord.Intents.FLAGS.GUILDS], 
        });

        
        await nclient.login(token);

       
        nclient.on("ready", () => {
        
          nclient.destroy();

         
          message.edit(`\`✅\` **Le token** est __valide__ est **__potentiellement utilisable__ !**`);
        });
      } catch (error) {
        
        message.edit(`\`❌\` **Le token** est __invalide__ !`);
      }
    };

    
    checkToken(token);
  }
};
