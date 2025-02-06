const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const path = require('path');
const fs = require('fs');


module.exports = {
  name: "premium",
  description: "Menu premuim",
  run: async (client, message, args, db, prefix) => {
  const configPath = path.join(__dirname, '../../config.json');
    let config;

    try {
      
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Erreur lors de la lecture du fichier config.json", err);
      return message.edit("Erreur lors de la lecture de la configuration.");
    }

    const premiumUserCount = config.premiumUsers.length;

    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, `# Crim 

- __**Bienvenu(e) au personnes encore non éligible au**__ \`Premium\`
- *Pour avoir accès au __Premium__ voici la __seul chose__ que nous __demandons__*
 - **Prix du Premium :** \`5€/m\`

- __**Statistique du premium**__
 - **Utilisateur avec le premium :** \`${premiumUserCount}\`
 - **Commandes actif dans le premium :** \`2\`

 - *Si vous avez une question vous pouvez vous diriger vers le salon :* <#1219780666015613059>`, `# Crim

- __**Welcome to people not yet eligible for**__ \`Premium\`
- *To have access to __Premium__ here is the __only thing__ we __ask__*
 - **Premium price:** \`5€/m\`

- __**Premium statistics**__
 - **User with premium:** \`${premiumUserCount}\`
 - **Active orders in premium:** \`2\`

 - *If you have a question you can head to the lounge:* <#1219780666015613059>`));
    }
 message.edit(
      await language(
        client,
        `# Crim 

- **Prix Premuim :** \`5€/m\`
- **Premuim actif :** \`${premiumUserCount}\`

- \`${prefix}banall\`
 - **Bannir tout les utilisateur d'un serveur**
- \`${prefix}delc\`
 - **Supprimé tout les salons d'un serveur** 
- \`${prefix}lockurl\`
 - **Bloque toute les personnes qui tente de changer votre vanity**
- \`${prefix}startsnipe\`
 - **Snipe l'url / vanity demandée**`,
       
          `# Crim 

- Premium Price : \`5€/m\`
- Premium active : \`${premiumUserCount}\`

- \`${prefix}banall\`  
 - **Ban all users from a server**
- \`${prefix}delc\`
 - **Deleted all channels from a server**
- \`${prefix}lockurl\`
 - **Block all people who try to change your vanity**
- \`${prefix}startsnipe\`
 - **Snipe the requested url / vanity**`
      )
    )
  }
}