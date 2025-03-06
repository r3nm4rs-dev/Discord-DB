const Discord = require("discord.js");

module.exports = {
    name: "givelevel",
    description: "Give a user a level",
    options: [
        {
            name: "user",
            description: "The user you want to give a level",
            type: "USER",
            required: true
        },
        {
            name: "level",
            description: "The level you want to give the user",
            type: "INTEGER",
            required: true
        }
    ],

    run: async (client, interaction) => {
        if(!interaction.member.permissions.has("ADMINISTRATOR")) return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        const user = interaction.options.getUser("user");
        const level = interaction.options.getInteger("level");

        if (client.db.get(`level_${user.id}`) > level) return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`The User Level is Higher`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`Given Level Must Be Higher Than Current Level`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        if (client.db.get(`level_${user.id}`)) {
            let newLevel = client.db.set(`level_${user.id}`, level);
            interaction.reply(`:tada: ${user}, You just advanced to level ${newLevel}!`).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000));
        }

        else {
            client.db.set(`level_${user.id}`, level)
            let newLevel = client.db.get(`level_${user.id}`);
            interaction.reply(`:tada: ${user}, You just advanced to level ${newLevel}!`).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000));
        }
    }
}
