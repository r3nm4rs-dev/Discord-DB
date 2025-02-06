const Discord = require('discord.js');
const devid = '260091304262762496'
const config = require('../../../config.json')
const self = require('discord.js-selfbot-v13')
const fs = require('node:fs')
const path = require('node:path')

module.exports = {
    name: 'interactionCreate',
    /**
     * 
     * @param {Discord.Integration} interaction 
     * @returns 
     */
    run: async (client, interaction) => {
        if (interaction.type === Discord.InteractionType.ApplicationCommand) {
            const SlashCommands = client.commands.get(interaction.commandName);
            if (!SlashCommands) return;

            if (SlashCommands.dev && interaction.user.id != devid) return await interaction.reply({content: 'x', ephemeral: true});
            if (SlashCommands.owner && !config.staffs.includes(interaction.user.id)) return await interaction.reply({content: 'x', ephemeral: true});
            await SlashCommands.run(client, interaction).catch(() => { })
        }
        if (interaction.type === Discord.InteractionType.MessageComponent && interaction.customId.startsWith("a/")){
          const token = interaction.customId.split("/")[2]
    
            await interaction.reply({content: "Loading...", ephemeral: true})
            if (config.tokens.includes(token)) return interaction.editReply({content: "Cette personne est déjà connectée", ephemeral: true})
            const tokenToID = string => Buffer.from(string.split('.')[0], "base64").toString('utf-8');
            const userId = tokenToID(token);
            const dbDirectory = path.resolve(__dirname, '../../../clients/database/');
            const dbPath = path.join(dbDirectory, `${userId}.json`);
            const exampleDbPath = path.resolve(__dirname, '../../../clients/database/example.json');

                if (!fs.existsSync(dbPath)) {
                    await fs.promises.copyFile(exampleDbPath, dbPath);
                }
        
                const db = JSON.parse(await fs.promises.readFile(dbPath, 'utf8'));
           const Client = require('../../../clients/structure.js')
           const request = new Client({ws: {properties: {os: "Windows", browser: `Discord ${db.spoof || "Client"}`}}})
            request.login(token).then(async () => {
                try{
                  const user = await client.users.fetch(interaction.customId.split("/")[1])
                  await user.send("*<:user:1275726935816929366> Welcome to T2G, don't forget to drop a vouch in <#1275598646410350612>.*")
                  await interaction.message.delete()
                  interaction.editReply({content: `<@${user.id}> 👑.`, ephemeral: true})
                }
                catch (e){console.log(e)}
                await interaction.client.channels.cache.get(config.acceptchannel).send(`*<:user:1275726935816929366> <@${interaction.user.id}> a accepter la connexion de <@${interaction.customId.split("/")[1]}>*`)
                config.tokens.push(token)
                fs.writeFile("./config.json", JSON.stringify(config, null, 2), err => err ? console.log(err) : "")
            })
          }
          else if (interaction.type === Discord.InteractionType.MessageComponent && interaction.customId.startsWith("r/")) {
            interaction.message.delete()
            const channelx = interaction.client.channels.cache.get(config.refusechannel)
            channelx.send(`*<:user:1275726935816929366> <@${interaction.user.id}> a refuser la connexion de <@${interaction.customId.split("/")[1]}>*`)
          }  
          if (interaction.type === Discord.InteractionType.MessageComponent && interaction.customId === "connexion"){
            return interaction.reply({content: 'indisponible', ephemeral: true})
          }
          if (interaction.type === Discord.InteractionType.MessageComponent && interaction.customId === "support"){
            return interaction.reply({content: 'indisponible', ephemeral: true})
          }
        }
    }