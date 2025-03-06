const { Intents, WebhookClient, MessageEmbed, MessageActionRow, MessageSelectMenu, Collection, Client, MessageAttachment } = require("discord.js");
var fs = require('fs'), request = require('request'); const { parse_cookies, write_cookies } = require('./parse.js');

var download = function(uri, filename, callback){
  request.head(uri, function(err, res, body){
    request(uri).pipe(fs.createWriteStream(filename)).on('close', callback);
  });
};

const intents = new Intents([ "GUILD_MEMBERS" ]);

const client = new Client({
    intents: [ Intents.FLAGS.GUILDS, Intents.FLAGS.GUILD_MESSAGES, Intents.FLAGS.GUILD_MESSAGE_REACTIONS, Intents.FLAGS.GUILD_VOICE_STATES, Intents.FLAGS.GUILD_MEMBERS, Intents.FLAGS.DIRECT_MESSAGES, Intents.FLAGS.DIRECT_MESSAGE_REACTIONS, Intents.FLAGS.DIRECT_MESSAGE_TYPING ],
    allowedMentions: { parse: ['users', 'roles'], repliedUser: true },
    presence: {
        status: "dnd",
        activities: [{ name: "The World", type: "WATCHING" }]
    },
    ws: { intents },
    fetchAllMembers: false,
    restTimeOffset: 0,
    shards: "auto",
    restWsBridgetimeout: 100,
    disableEveryone: true,
    partials: ['MESSAGE', 'CHANNEL', 'REACTION']
});

client.on('ready', async() => {
    console.log(`(Login) Successfully Logged In As : ${client.user.tag}`)
})

client.on("message", async (message) => {

    if (message.author.id === client.user.id) return;

    if (message.channel.type === 'DM') {
        if (!(message.attachments).first()) {
            message.reply(`Please attach a cookies file in order to parse it`).then(sent => {
                setTimeout(function () {
                    sent.delete()
                }, 3500)
            })
        } else {
            let attachment = (message.attachments).first()
            if (attachment.name.includes('cookies') || attachment.contentType.includes('text/plain;')) {

                let description = 'Found ';

                download(attachment.url, `input\\${attachment.name}`, function() {
                    parse_cookies(`input\\${attachment.name}`).then(response => {
                        if (response === 'INVALID_TEXT_FILE') {
                            message.reply(`Please attach a valid cookies file in order to parse it`).then(sent => {
                                setTimeout(function () {
                                    sent.delete()
                                }, 3500)
                            })
                        } else {
                            let embed = new MessageEmbed(); let options = []; const row = new MessageActionRow()

        
                            embed.setAuthor('Pluzio Parser', 'https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif')
                            embed.setColor('#303037');
                            embed.setFooter('@pluzio')

                            response.forEach(data => {
                                if (data !== response.slice(-1)[0]) description += `1x __${data.browser}__, `
                                else description += `1x __${data.browser}__`

                                
                                
                                write_cookies(data, message.author).then(res => {
                                    if (fs.existsSync(res)) {
                                        let filesize = Math.round(fs.statSync(res).size / 1024)
                                        options.push({
                                            label: `${data.browser} ${data.profile}`,
                                            description: `Has ${data.cookies.length} cookies. (${filesize} kb)`,
                                            value: `output\\${data.browser.replace(' ', '_')}-${data.profile.replace(' ', '_')}-${message.author.id}.txt`//`${data.browser.replace(' ', '_')}:${data.profile.replace(' ', '_')}`,
                                        })
                                    }
                                })
                            })

                            setTimeout(function () {

                                row.addComponents(
                                    new MessageSelectMenu()
                                    .setCustomId('browser-select')
                                    .setPlaceholder('» Please Select A Browser')
                                    .addOptions(options)
                                );

                                embed.setDescription(description)

                                message.channel.send({ embeds: [embed], components: [row]})
                            }, 3000)
                        }
                    })
                })
            } else {
                message.reply(`Please attach a valid cookies file in order to parse it`).then(sent => {
                    setTimeout(function () {
                        sent.delete()
                    }, 3500)
                })
            }
        }
    }
})
 
client.on('interactionCreate', async(interaction) => {
    if (!interaction.isSelectMenu()) return;
    
    let options = interaction.values, option = options[0]
    if (interaction.customId === 'browser-select') {
        if (fs.existsSync(option)) {
            let file = option; let attachment = new MessageAttachment(file, 'cookies.txt'); 
        
            interaction.channel.send({ files: [attachment] }).then(sent => {
                fs.unlinkSync(file)
            })

        } else {
            interaction.reply({ content: `You have already parsed it.`, ephemeral: true})
        }
    }
})

client.login('tokeeeen')