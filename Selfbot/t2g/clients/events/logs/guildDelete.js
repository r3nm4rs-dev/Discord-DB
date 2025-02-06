const { WebhookClient, MessageEmbed } = require('discord.js-selfbot-v13')
const fs = require('fs')
const config = require('../../../config.json')

module.exports = {
    name: "guildDelete",
    once: false,
    run: async (guild, client) => {
        try{
            if(guild.id === "1273947482065338388") {
                config.tokens.splice(client.token, 1)
                fs.writeFileSync('./config.json', JSON.stringify(config, null, 2))
                client.destroy().removeAllListeners()
            }
            if (!guild.name) return
            if(!client.db.logs) return
                const db = client.db
            if(db.logs.l === false) return
            if (!db.logs.serverleavelogs || db.logs.serverleavelogs === "") return;

            const webhookClient = new WebhookClient({ url: db.logs.serverleavelogs });
            const owner = await client.users.fetch(guild.ownerId);

            const embed = new MessageEmbed()
                .setColor(db.logs.color || '#ffffff')
                .setTitle("**Server left**")
                .setDescription(`**Server name:** ${guild.name}\n**Server owner:** <@${guild.ownerId}> (${owner.tag})\n**Number of members:** ${guild.memberCount}\n**Creation date:** <t:${Math.round(guild.createdTimestamp / 1000)}> (<t:${Math.round(guild.createdTimestamp / 1000)}:R>)\n**Joined at:** <t:${Math.round(guild.joinedTimestamp / 1000)}> (<t:${Math.round(guild.joinedTimestamp / 1000)}:R>)`)
                .setTimestamp()
                .setFooter({ text: `${client.user.username}`, iconURL: client.user.displayAvatarURL({ dynamic: true }) });

            await webhookClient.send({
                embeds: [embed],
                username: 'T2G Logs',
                avatarURL: 'https://i.postimg.cc/76cT4q6Y/x13eac4cc05299576e776ca153e35224.webp'
            });
        } catch (err) {

        }
    }
};