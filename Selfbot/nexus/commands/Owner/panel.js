const Discord = require("discord.js-selfbot-v13");
const fs = require("fs");
const path = require("path");

module.exports = {
    name: "panel",
    description: "command panel",

    async run(client, message, args) {
        const userId = message.author.id;
        const dbPath = path.join('/home/container/db/', `${userId}.json`);

        if (!fs.existsSync(dbPath)) {
            return message.edit("La base de données de l'utilisateur n'existe pas.");
        }

        const db = JSON.parse(fs.readFileSync(dbPath, 'utf8'));

        client.channels.createGroupDM([Discord.User]).then((grp) => {
            grp.setIcon("https://cdn.discordapp.com/icons/1265595157819166730/db104247fbe53e1e7207b78ab1ad88b9.webp")
            .then(() => grp.setName(`Panel - Pluzio`))
            .then((PartialGroupDMChannel) => {
                setTimeout(() => {
                    PartialGroupDMChannel.send(`Welcome to the panel 〃 **Pluzio** 
                    
▸  ***Prefix*** : \`&\`
          
▸ This panel is created when connecting to Pluzio so use commands here.
          
▸ I don't recommand to use commands in public, you can if you want.
          
If you got problems when using Pluzio, join the support here :
                                      
[**SUPPORT SERVER**](<https://discord.gg/pluzio>)
                                      
▸ Don't forget to write a review here <#1289885162766864499`).then((msg) => {
                        msg.react("⚡");
                        msg.pin();
                    });
                }, 500);
            });
            message.edit("✅ Panel créé avec succès");
        });
    }
}
