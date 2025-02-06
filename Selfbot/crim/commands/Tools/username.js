const Discord = require("discord.js-selfbot-v13");
const axios = require('axios');

module.exports = {
    name: "username",
    description: "Search for a username across multiple platforms",
    async run(client, message, args) {
        if (!args[0]) {
            return message.edit("Veuillez fournir un nom d'utilisateur pour rechercher.");
        }

        const username = args[0];
        const platforms = {
            "Chess": `https://www.chess.com/member/${username}`,
            "Github": `https://github.com/${username}`,
            "Youtube": `https://www.youtube.com/@${username}`,
            "Xbox": `https://xboxgamertag.com/search/${username}`,
            "Spotify": `https://open.spotify.com/user/${username}`,
            "Guns.lol": `https://guns.lol/${username}`,
            "Roblox": `https://www.roblox.com/user.aspx?username=${username}`,
            "Replit": `https://replit.com/@${username}`,
            "Snapchat": `https://www.snapchat.com/add/${username}`,
            "Twitter": `https://twitter.com/${username}`,
        };

        let resultsMessage = "# Crim\n";

     
        Object.keys(platforms).forEach(platform => {
            resultsMessage += `> \`${platform}\` ▸ \`🔎\`\n`;
        });

       
        let messageToUpdate = await message.edit(resultsMessage);

        for (const [platform, url] of Object.entries(platforms)) {
            let platformStatus = `> \`${platform}\` ▸ `; 

            try {
                if (platform === "Discord") { 
                    platformStatus += `\`🟢\`\n`;
                } else {
                    await axios.get(url);
                   
                    platformStatus += `[\`🟢\`](${url})\n`; 
                }
            } catch (error) {
               
                platformStatus += `\`🔴\`\n`;
            }

           
            resultsMessage = resultsMessage.replace(`> \`${platform}\` ▸ \`🔎\`\n`, platformStatus);
            await messageToUpdate.edit(resultsMessage);
        }
    }
};

