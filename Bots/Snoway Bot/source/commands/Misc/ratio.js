const Discord = require('discord.js')
const Pluzio = require('../../structures/client/index')
module.exports = {
    name: 'ratio',
    description: {
        fr: "Ratio un membre",
        en: "Single member ratio"
    },
    /**
     * 
     * @param {Pluzio} client 
     * @param {Discord.Message} message 
     * @param {string[]} args 
     */
    run: async (client, message, args) => {

       message.react('✅') 
       message.react('❌')
    }
}