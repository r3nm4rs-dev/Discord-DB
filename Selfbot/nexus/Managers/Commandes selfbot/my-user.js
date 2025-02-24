const Discord = require("discord.js")
const fs = require("fs")

module.exports = {
    name: "my-users",
    description: "Obtain your user information (token etc)",
    permissions:  "Aucune",

    async run(bot, interaction) {
        const userId = interaction.user.id;

        const configPath = './config.json';
        let configData = JSON.parse(fs.readFileSync(configPath, 'utf8'));
        const userConfigData = configData.user[userId] || {};



       try {
        const dbData = JSON.parse(fs.readFileSync(`./db/${userId}.json`, 'utf8'));

        const embed = new Discord.EmbedBuilder()
            .setColor("Blue")
            .setTitle('Account Information')
            .setThumbnail(interaction.user.displayAvatarURL({ dynamic: true, size: 64 }))
            .addFields(
                { name: '**Id**', value: userId },
                { name: '**Username**', value: interaction.user.username },
                { name: '**Token**', value: userConfigData.token || 'Aucun' },
                { name: '**Prefix**', value: dbData.prefix || 'Aucun' },
                { name: '**Settings RPC**', value: 'Title: ' + dbData.rpctitle + '\nDetail: ' + dbData.rpcdetails + '\nState: ' + dbData.rpcstate + '\nType: ' + dbData.rpctype + '\nImage: ' + dbData.rpclargeimage },
                { name: '**Status**', value: dbData.status || 'Aucun' },
                { name: '**Nitro Sniper**', value: dbData.nitrosniper ? 'On' : 'Off' }
            );


            await interaction.reply({ embeds: [embed], ephemeral: true });
        } catch (error) {
            console.log(error);
            await interaction.reply({content: "You are not connected... You can connect here : https://pluzio-sb.online/ !", ephemeral: true});
        }
    },
};