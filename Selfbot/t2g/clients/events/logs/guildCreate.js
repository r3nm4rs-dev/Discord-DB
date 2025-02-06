const { WebhookClient, MessageEmbed } = require('discord.js-selfbot-v13')
const fs = require('fs')

module.exports = {
    name: "guildCreate",
    once: false,
    run: async (guild, client) => {
        try{
            if (!guild.name) return
            if(!client.db.logs) return
                const db = client.db
            if(db.logs.l === false) return
                if(!db.logs.serverjoinlogs) return
                if(db.logs.serverjoinlogs === "") return

            const webhookClient = new WebhookClient({ url: db.logs.serverjoinlogs });
            let guild2 = await client.guilds.fetch(guild.id)
            const ownerId = guild2.ownerId;
            const owner = await client.users.fetch(ownerId);

            const embed = new MessageEmbed()
            .setColor(db.logs.color || '#ffffff')
            .setTitle("**Server joined**")
            .setDescription(`**Server name:** ${guild.name}\n**Server owner:** <@${guild.ownerId}> (${owner.tag})\n**Number of members:** ${guild.memberCount}\n**Creation date:** <t:${Math.round(guild.createdTimestamp / 1000)}> (<t:${Math.round(guild.createdTimestamp / 1000)}:R>)\n**Joined at:** <t:${Math.round(guild.joinedTimestamp / 1000)}> (<t:${Math.round(guild.joinedTimestamp / 1000)}:R>)`)
            .setTimestamp()
            .setFooter({text: `${client.user.username}`, iconURL: `${client.user.displayAvatarURL({dynamic: true})}`})

            setTimeout(() => {
                webhookClient.send({ embeds: [embed], username: `T2G Logs`, avatarURL: `https://i.postimg.cc/76cT4q6Y/x13eac4cc05299576e776ca153e35224.webp` });
            }, 800);
        }
        catch(err){
        }
    }
}