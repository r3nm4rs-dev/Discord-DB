const Discord = require("discord.js")
const db = require('quick.db')
const config = require("../config")
const owner = new db.table("Owner")
const cl = new db.table("Color")
const blv = new db.table("blvoc")
const pgs = new db.table("PermGs");
const footer = config.bot.footer


module.exports = {
    name: 'blv',
    usage: 'antivoc',
    description: `Permet de gérer la blacklist vocal`,
    async execute(client, message, args) {


  if (owner.get(`owners.${message.author.id}`) || config.bot.buyer.includes(message.author.id) || message.member.roles.cache.has(pgs.get(`permgs_${message.guild.id}`) )  === true) {

            let color = cl.fetch(`color_${message.guild.id}`)
            if (color == null) color = config.bot.couleur

            if (args[0]) {
                let member = client.users.cache.get(message.author.id);
                if (args[0]) {
                    member = client.users.cache.get(args[0]);
                } else {
                    return message.channel.send(`Aucun membre trouvé pour \`${args[0] || "rien"}\``)

                }
                if (message.mentions.members.first()) {
                    member = client.users.cache.get(message.mentions.members.first().id);
                }
                if (!member) return message.channel.send(`Aucun membre trouvé pour \`${args[0] || "rien"}\``)
                if (blv.get(`${message.guild.id}.${member.id}.blv`) === true) { return message.channel.send(`${member.username} est déjà dans la blacklist vocal.`) }
                blv.add(`${message.guild.id}.blvcount`, 1)
                blv.push(`${message.guild.id}.blv`, member.id)
                blv.set(`${message.guild.id}.${member.id}.blv`, member.id)

                message.channel.send(`${member.username} est maintenant dans la blacklist vocal.`)

            } else if (!args[0]) {


                let own = blv.get(`${message.guild.id}.blv`)
                let ownc = blv.get(`${message.guild.id}.blvcount`)
                if (ownc === null || "Nan") ownc = 1
                let p0 = 0;
                let p1 = 30;
                let page = 1;

                let embed = new Discord.MessageEmbed()
                embed.setTitle("Blacklist Vocal")
                    .setColor(color)
                    .setDescription(!own ? "Aucun" : own.map((user, i) => `<@${user}>`).slice(0, 30).join("\n")
                    )
                    .setFooter({ text: `${footer}` })
                    const logchannel = client.channels.cache.get(ml.get(`${message.guild.id}.modlog`))
                    if (logchannel) logchannel.send({ embeds: [embed] }).catch(() => false)
            }
        }
    }
}
