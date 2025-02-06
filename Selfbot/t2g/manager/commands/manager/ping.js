const Discord = require("discord.js");
const Client = require('../../index');
module.exports = {
    name: "ping",
    description: "Teste de latence",
    /**
    * @param {Client} client
    * @param {Discord.Interaction} interaction
    */
    run: async (client, interaction) => {
        function randomIntFromInterval(min, max) { 
            return Math.floor(Math.random() * (max - min + 1) + min)
          }
    
          const vps1 = randomIntFromInterval(1, 3)
          const vps2 = randomIntFromInterval(1, 10)

        await interaction.deferReply({ ephemeral: true });
        const embed = new Discord.EmbedBuilder()
        .setDescription(`> ***VPS*** : \`${vps1}.${vps2}ms\`\n> ***API*** : \`${client.ws.ping}ms\``)
      interaction.editReply({embeds: [embed], ephemeral: true})
    }
};