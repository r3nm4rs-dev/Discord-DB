const { MessageEmbed } = require("discord.js");
const config = require("../config.json");

module.exports = {
    name: "afk",
    description: "Set your afk status",
    options: [
        {
            name: "reason",
            description: "The reason for your afk status",
            type: "STRING",
            required: false
        }
	],

	run: async (client, interaction) => {
		if(client.afks.get(interaction.user.id)) {
			if(interaction.member.manageable) {
				if(interaction.member.roles.highest.rawPosition !== interaction.guild.members.cache.get(client.user.id).roles.highest.rawPosition) {
					if(interaction.member.roles.highest.rawPosition < interaction.guild.members.cache.get(client.user.id).roles.highest.rawPosition) {
						interaction.member.setNickname((interaction.member.displayName).replace("[AFK]", ""));
					}
				}
			}
			client.afks.delete(interaction.user.id);
			return interaction.reply({
				embeds: [new MessageEmbed().setTitle("Your Afk Was Removed").setColor("#56089e").setDescription("Users Pings You Will Not be Notified")]
			}).then(msg => setTimeout(() => {
				interaction.deleteReply();
			}, client.config.message_remove_time*1000));
		}
		else if(interaction.member.displayName.includes("[AFK]")) {
			function escapeRegex(string) {
				return string.replace(/[-\/\\^$*+?.()|[\]{}]/g, '\\$&');
			}
			function replaceAll(str) {
				return str.replace(new RegExp(escapeRegex("[AFK]"), 'g'), "");
			}
			interaction.member.setNickname(replaceAll(interaction.member.displayName));
			return interaction.reply({
				embeds: [new MessageEmbed().setTitle("Your Afk Was Removed").setColor("#56089e").setDescription("Users Pings You Will Not be Notified")]
			}).then(msg => setTimeout(() => {
				interaction.deleteReply();
			}, client.config.message_remove_time*1000));
		}
		else {
			if(interaction.member.manageable) {
				if(interaction.member.roles.highest.rawPosition !== interaction.guild.members.cache.get(client.user.id).roles.highest.rawPosition) {
					if(interaction.member.roles.highest.rawPosition < interaction.guild.members.cache.get(client.user.id).roles.highest.rawPosition) {
						interaction.member.setNickname(`[AFK] ${interaction.member.displayName}`);
					}
				}
			}
			client.afks.set(interaction.user.id, interaction.options.getString("reason") || "No Reason");
			return interaction.reply({
				embeds: [new MessageEmbed().setTitle("You Are Now Afk").setColor("#56089e").setDescription(`Reason: ${interaction.options.getString("reason") || "No Reason"}`)]
			}).then(msg => setTimeout(() => {
				interaction.deleteReply();
			}, client.config.message_remove_time*1000));
		}

	}
}
