const { WebhookClient, MessageEmbed } = require('discord.js-selfbot-v13')

module.exports = {
    name: "messageCreate",
    once: false,
    run: async (message, client) => {
        try{
            if(!client.db.logs) return
            if(client.db.logs.l === false) return
            if(client.db.logs.customLogs === "") return
            if(!client.db.logs.customword) return

            const pipi = client.db.logs.customword.find(word => message.content.includes(word));
            if (!pipi) return;

            const webhookClient = new WebhookClient({ url: client.db.logs.customLogs });

            const embed = new MessageEmbed()
            .setColor(client.db.logs.color || '#ffffff')
            .setTitle(`**Custom Logs** : \`${pipi}\``)
            .setDescription(`**Author:** \`${message.author.tag}\`\n**Location:** <#${message.channel.id}>\n**Content:**\n${message.content}`)
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