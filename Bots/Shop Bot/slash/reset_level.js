const Discord = require('discord.js');

module.exports  = {
    name: 'reset_level',
    description: 'Reset a user\'s level',
    options: [
        {
            name: 'user',
            description: 'User',
            type: 'USER',
            required: true
        }
    ],
    run: async (client, interaction) => {
        if (!interaction.member.permissions.has('ADMINISTRATOR')) return interaction.reply({ embeds: [new Discord.MessageEmbed()
            .setAuthor(`You dont have permission`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
                  interaction.deleteReply()
                }, client.config.message_remove_time*1000))
        if (client.db.get(`level_${interaction.options.get('user').user.id}`)) {
            let newLevel = client.db.set(`level_${interaction.options.get('user').user.id}`, 0);
            client.db.set(`xp_${interaction.options.get('user').user.id}`, 0)
            interaction.reply(`${interaction.options.get('user').user}, Level Was Reset!`).then(msg => setTimeout(() => {
                  interaction.deleteReply()
                }, client.config.message_remove_time*1000));
        }
        else {
            client.db.set(`level_${interaction.options.get('user').user.id}`, 0)
            client.db.set(`xp_${interaction.options.get('user').user.id}`, 0)
            let newLevel = client.db.get(`level_${interaction.options.get('user').user.id}`);
            interaction.reply(`${interaction.options.get('user').user}, Level Was Reset!`).then(msg => setTimeout(() => {
                  interaction.deleteReply()
                }, client.config.message_remove_time*1000));
        }
    }
}


