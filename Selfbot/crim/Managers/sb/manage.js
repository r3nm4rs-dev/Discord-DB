const Discord = require("discord.js-selfbot-v13");
const { language, savedb } = require("../../fonctions");

module.exports = {
    name: "manage",
    description: "Gérer la connexion au selfbot.",
    permissions: "Aucune",

    run: async (client, interaction, db) => {
        const userId = interaction.user.id;

        let embed = new Discord.MessageEmbed()
            .setTitle("Gérer ta connexion")
            .setDescription("Gestion de votre statut de connexion au selfbot. Utilisez les boutons ci-dessous pour démarrer ou arrêter le selfbot, ou pour réinitialiser votre configuration.")
            .setColor("2c2d31");

        const startButton = new Discord.MessageButton()
            .setCustomId('start')
            .setLabel('Start')
            .setStyle('SUCCESS');

        const stopButton = new Discord.MessageButton()
            .setCustomId('stop')
            .setLabel('Stop')
            .setStyle('DANGER');

        const resetButton = new Discord.MessageButton()
            .setCustomId('resetdb')
            .setLabel('ResetDB')
            .setStyle('SECONDARY');

        const row = new Discord.MessageActionRow()
            .addComponents(startButton, stopButton, resetButton);

        await interaction.reply({ embeds: [embed], components: [row], ephemeral: true });

        const filter = i => ['start', 'stop', 'resetdb'].includes(i.customId) && i.user.id === userId;
        const collector = interaction.channel.createMessageComponentCollector({ filter, time: 60000 });

        collector.on('collect', async i => {
            if (i.customId === 'start') {
                if (db.connecte) {
                    await i.reply({ content: "Tu es déjà connecté.", ephemeral: true });
                } else {
                    db.connecte = true;
                    await savedb(client, userId, db);
                    await i.reply({ content: "Vous êtes maintenant connecté.", ephemeral: true });
                }
            } else if (i.customId === 'stop') {
                if (!db.connecte) {
                    await i.reply({ content: "Tu n'es pas connecté.", ephemeral: true });
                } else {
                    db.connecte = false;
                    await savedb(client, userId, db);
                    await i.reply({ content: "Vous êtes maintenant déconnecté.", ephemeral: true });
                }
            } else if (i.customId === 'resetdb') {
                
                db = {
                
  "prefix": "&",
  "status": "online",
  "nitrosniper": false,
  "nitrourl": "",
  "langue": "fr",
  "time": 60000,
  "noaddgrp": false,
  "noaddgrptext": "",
  "voiceconnect": "1221886357736132608",
  "voicemute": false,
  "voicedeaf": true,
  "voicewebcam": false,
  "voicestream": false,
  "twitch": "https://twitch.tv/zen262",
  "rpconoff": true,
  "rpctitle": "Crim",
  "rpcdetails": "⛧",
  "rpcstate": "",
  "rpctype": "COMPETING",
  "rpclargeimage": "https://cdn.discordapp.com/icons/1219600628930842715/deefd30cbdd589f82740e985ef8b2ce1.png?size=1024",
  "rpclargeimagetext": "",
  "rpcsmallimage": "",
  "rpcsmallimagetext": "",
  "appid": "239069101794918410",
  "buttontext1": "Join now!",
  "buttonlink1": "https://discord.gg/kspG9dMkFV",
  "buttontext2": "",
  "buttonlink2": "",
  "spotifyonoff": "off",
  "spotifylargeimage": "",
  "spotifysmallimage": "",
  "spotifystates": "",
  "spotifyalbum": "",
  "spotifydetails": "",
  "spotifyendtimestamp": null,
  "rainbowrole": [],
  "rpctime": null,
  "rpcminparty": 0,
  "rpcmaxparty": 0,
  "webhooklogs": null,
  "aboutme": null,
  "hype": null,
  "rpctextstatus": null,
  "rpcemoji": null
  

                };
                await savedb(client, userId, db);
                await i.reply({ content: "Votre configuration a été réinitialisée.", ephemeral: true });
            }
        });
    }
};

