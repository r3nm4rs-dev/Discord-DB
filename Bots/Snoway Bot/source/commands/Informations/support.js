const { EmbedBuilder } = require('discord.js')
const Pluzio = require('../../structures/client/index')

module.exports = {
    name: "support",
    aliases: ["Pluzio"],
    description: {
        fr: "Invite sur le support du bot !",
        en: "Invite to the bot support!"
    },
    /**
     * 
     * @param {Pluzio} client 
     * @param {Pluzio} message 
     * @param {Pluzio} args 
     * @returns 
     */
    run: async (client, message, args) => {

        await message.channel.send({
            embeds: [new EmbedBuilder().setColor(client.color).setDescription(`[Clique ici pour rejoindre le support Pluzio Bots](${client.support})`)]
        })
    }
}