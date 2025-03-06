const Discord = require("discord.js");

module.exports = {
    name: "kick",
    description: "Kicks a user from the server.",
    options: [
        {
            name: "user",
            description: "The user to kick.", 
            type: "USER",
            required: true
        },
        {
            name: "reason",
            description: "The reason for kicking the user.",
            type: "STRING",
            required: false
        }
    ],

    run: async (client, interaction) => {
		if(!interaction.member.permissions.has("KICK_MEMBERS")) return interaction.reply({ embeds: [new Discord.MessageEmbed()
			.setAuthor(`You dont have permission`, interaction.user.displayAvatarURL({dynamic:true})) 
			.setDescription(`You Want Administrator or Kick Members permissions to use this Command`)
			.setColor(`#56089e`)]}).then(msg => setTimeout(() => {
		  interaction.deleteReply()
		}, client.config.message_remove_time*1000))


		const member = interaction.guild.members.cache.get(interaction.options.getMember("user").id)

		if(member.id === interaction.member.id) return interaction.reply({ embeds: [new Discord.MessageEmbed()
			.setAuthor(`You cant kick yourself`, interaction.user.displayAvatarURL({dynamic:true}))
			.setDescription(`You cant kick yourself`)
			.setColor(`#56089e`)]}).then(msg => setTimeout(() => {
		  interaction.deleteReply()
		}, client.config.message_remove_time*1000))

		if(member.id === client.user.id) return interaction.reply({ embeds: [new Discord.MessageEmbed()
			.setAuthor(`You cant kick me`, interaction.user.displayAvatarURL({dynamic:true}))
			.setDescription(`You cant kick me`)
			.setColor(`#56089e`)]}).then(msg => setTimeout(() => {
		  interaction.deleteReply()
		}, client.config.message_remove_time*1000))



		member.kick(interaction.options.getString("reason"))
		const embed = new Discord.MessageEmbed()
			.setTitle("Successfully Kicked!")
			.setDescription(
				`${interaction.options.getMember("user")} Was Kicked`
			)
			.setColor("#56089e")
		return interaction.reply({ embeds: [embed]}).then(msg => setTimeout(() => {
			interaction.deleteReply()
		}, client.config.message_remove_time*1000));
	}
}
