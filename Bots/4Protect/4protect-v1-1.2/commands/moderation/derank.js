const Discord = require("discord.js");
const db = require('quick.db');
const owner = new db.table("Owner");
const cl = new db.table("Color");
const modlog = new db.table("modlog")
const config = require("../config");
const footer = config.bot.footer;
 ;

module.exports = {
    name: 'derank',
    usage: 'derank <membre>',
    description: `Permet de derank un membre sur le serveur.`,
    async execute(client, message, args) {
    if (owner.get(`owners.${message.author.id}`) || config.bot.buyer.includes(message.author.id) || message.member.roles.cache.has(pgs.get(`permgs_${message.guild.id}`) )  === true) {
            let color = cl.fetch(`color_${message.guild.id}`);
            if (color == null) color = config.bot.couleur;
        
                let member = message.mentions.members.first() || message.guild.members.cache.get(args[0]);
                if (!member) return message.reply("Veuillez mentionner un membre valide ou fournir un ID valide.");

                let roles = member.roles.cache.filter(r => r.id !== message.guild.id).map(r => `<@&${r.id}>`).join(", ");
                try {
                    member.roles.set([]).then(() => {
                    }).catch(() => {
                    });
                } catch {
                }

                const embed = new Discord.MessageEmbed()
                    .setColor(color)
                    .setTitle("Derank d'un membre")
                    .setDescription(`<@${member.id}> a été derank et les rôles suivants ont été retirés : ${roles}`)
                    .setFooter({ text: `${footer}` });

                message.channel.send({ embeds: [embed] }).catch(() => false);

                const channellogs = modlog.get(`${message.guild.id}.modlog`);
                let roleping = db.get(`role_${message.guild.id}`);
                if (roleping === null) roleping = "@everyone";

                const modlog = new Discord.MessageEmbed()
                    .setColor(color)
                    .setTitle(`${message.author.tag} a effectué un derank`)
                    .setDescription(`⚠️ <@${member.id}> a été derank\nExécuteur : <@${message.author.id}>`)
                    .setTimestamp()
                    .setFooter({ text: `⚠️ ${footer}` });

                const logchannel = client.channels.cache.get(channellogs);
                if (logchannel) logchannel.send({ content: `${roleping}`, embeds: [alert] }).catch(() => false);
            }
    }
};
