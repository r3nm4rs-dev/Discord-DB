const fs = require('fs');
const path = require('path');
const Discord = require("discord.js-selfbot-v13");

module.exports = {
    name: "panel",
    description: "Crée un panel pour l'utilisateur",

    async run(client, userId) {
        const dbPath = path.join('/home/container/db/', `${userId}.json`);

        if (!fs.existsSync(dbPath)) {
            console.error("La base de données de l'utilisateur n'existe pas.");
            return;
        }

        const db = JSON.parse(fs.readFileSync(dbPath, 'utf8'));

        try {
            const grp = await client.channels.createGroupDM([client.user]); // Utilisez client.user pour le créer avec le bot
            await grp.setIcon("https://media.discordapp.net/attachments/1253389938494542042/1253430802071556148/IMG_0293.jpg?ex=6675d3e6&is=66748266&hm=af556db03114a950ed5e6b12a616e27f9a98d36b3ee49c57055f5423d7c9a9e5&=&format=webp&width=559&height=559");
            await grp.setName(`Panel - Pluzio`);

            const msg = await grp.send(`Welcome to panel 〃 **Pluzio**
            
▸  ***Prefix*** : \`&\`
          
▸ This panel is created when connecting to Pluzio so use commands here.
          
▸ I don't recommand to use commands in public, you can if you want.
          
If you got problems when using Pluzio, join the support here :
                                      
[**SUPPORT SERVER**](<https://discord.gg/pluzio>)
                                      
▸ Don't forget to write a review here <#1289885162766864499>`);
            
            await msg.react("⚡");
            await msg.pin();

            console.log("✅ Panel créé avec succès pour l'utilisateur:", userId);
        } catch (error) {
            console.error("Erreur lors de la création du panel:", error);
        }
    }
};
