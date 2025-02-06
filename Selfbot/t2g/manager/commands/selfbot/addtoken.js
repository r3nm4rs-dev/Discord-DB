const config = require('../../../config.json')
const Discord = require('discord.js')
const fs = require('node:fs')

module.exports = {
    name: "addtoken",
    description: "Ajoute un token sur la machine",
    owner: true,
    options: [
        {
            name: "token",
            type: Discord.ApplicationCommandOptionType.String,
            description: "Le token a add",
            required: true
        }
    ],
    /**
    * @param {Discord.Client} client
    * @param {Discord.Interaction} interaction
    */
    run: async (client, interaction) => {
        try{
        const clients = client.clients
        const token = interaction.options.getString('token');
        if(config.tokens.includes(token)) return interaction.reply({content: `*<a:UC_Black_skull:1275722522444173343> The token you provided is already in use.*`, ephemeral: true})
            const Client = require('../../../clients/structure.js')
            const request = new Client()
            request.login(token).catch(() => interaction.reply({content: `*<a:UC_Black_skull:1275722522444173343> The token you provided is invalid.*`, ephemeral: true}))
            config.tokens.push(token)
            fs.writeFileSync('./config.json', JSON.stringify(config, null, 2))
            interaction.reply({content: `*<:user:1275726935816929366> The token has been added successfully.*`, ephemeral: true})
            clients.push(request)
        }catch(e){
            console.log(e)
        }
        }
    }