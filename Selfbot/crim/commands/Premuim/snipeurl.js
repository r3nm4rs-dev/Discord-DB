const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "startsnipe",
  description: "Tente de définir une URL de vanité pour le serveur à intervalles réguliers jusqu'à réussite.",
  run: async (client, message, args, db, prefix) => {
   
    if (!args.length) {
      return message.edit(`\`⛔\` *Erreur de syntaxe.*
**Utilisez :** ${prefix}snipeurl <URL>`);
    }

    const vanityURL = args[0];

   
    if (!message.guild) {
      return message.edit("\`❌\` **Erreur :** Cette commande doit etre effectuer sur un serveur");
    }

   
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.ADMINISTRATOR)) {
      return message.channel.send(`\`🔑\` **Erreur :** Permission(s) manquante`);
    }

    
    message.channel.send(`\`📌\` **Je commence à snipe l'URL :** \`${vanityURL}\``);
    
    const retryInterval = 1000; // 10 secondes
    let attempts = 0; // Compteur de tentatives

    const trySetVanityCode = () => {
      attempts++; 
      message.guild.setVanityCode(vanityURL)
        .then(res => {
          
          message.channel.send(`\`👑\` **Succès :** Votre Vanity à été snipe !
**Voici votre nouvelle URL :** \`${vanityURL}\``);
          clearInterval(retryIntervalId);
        })
        .catch(error => {
          
          if (error.message.includes('50035')) {
            message.channel.send("`🔮` **Erreur :** Boost(s) manquant");
            clearInterval(retryIntervalId);
          }
          console.error(`Tentative ${attempts} : `, error);
        });
    };

    trySetVanityCode(); 
    const retryIntervalId = setInterval(trySetVanityCode, retryInterval); 
  }
};

