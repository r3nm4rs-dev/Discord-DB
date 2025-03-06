const Discord = require("discord.js")

module.exports = {
    name: "ban",
    description: "Ban a user",
    options: [
        {
            name: "user",
            description: "The user you want to ban",
            type: "USER",
            required: true
        },
        {
            name: "reason",
            description: "The reason for the ban",
            type: "STRING",
            required: false
        }
    ],

    run: async (client, interaction) => {
        if(!interaction.member.permissions.has("BAN_MEMBERS")) {
            return interaction.reply({
                embeds: [new Discord.MessageEmbed().setTitle("You Don't Have Permission To Ban Users").setColor("#56089e")]
            }).then(msg => setTimeout(() => {
                interaction.deleteReply();
            }, client.config.message_remove_time*1000));
        }
            else if(!interaction.guild.me.permissions.has("BAN_MEMBERS")) {
                return interaction.reply({
                embeds: [new Discord.MessageEmbed().setTitle("I Don't Have Permission To Ban Users").setColor("#56089e")]
            }).then(msg => setTimeout(() => {
                interaction.deleteReply();
            }, client.config.message_remove_time*1000));
        }
        else {
            const user = interaction.guild.members.cache.get(interaction.options.getUser("user").id);
            if(!user) {
                return interaction.reply({
                    embeds: [new Discord.MessageEmbed().setTitle("User Not Found").setColor("#56089e")]
                }).then(msg => setTimeout(() => {
                    interaction.deleteReply();
                }, client.config.message_remove_time*1000));
            }
            else {
                if(user.id === interaction.user.id) {
                    return interaction.reply({
                        embeds: [new Discord.MessageEmbed().setTitle("You Can't Ban Yourself").setColor("#56089e")]
                    }).then(msg => setTimeout(() => {
                        interaction.deleteReply();
                    }, client.config.message_remove_time*1000));
                }
                else if(user.id === client.user.id) {
                    return interaction.reply({
                        embeds: [new Discord.MessageEmbed().setTitle("You Can't Ban Me").setColor("#56089e")]
                    }).then(msg => setTimeout(() => {
                        interaction.deleteReply();
                    }, client.config.message_remove_time*1000));
                }
                else if(user.id === interaction.guild.ownerId) {
                    return interaction.reply({
                        embeds: [new Discord.MessageEmbed().setTitle("You Can't Ban The Server Owner").setColor("#56089e")]
                    }).then(msg => setTimeout(() => {
                        interaction.deleteReply();
                    }, client.config.message_remove_time*1000));
                }
                else if(user.roles.highest.rawPosition >= interaction.member.roles.highest.rawPosition) {
                    return interaction.reply({
                        embeds: [new Discord.MessageEmbed().setTitle("You Can't Ban This User").setColor("#56089e")]
                    }).then(msg => setTimeout(() => {
                        interaction.deleteReply();
                    }, client.config.message_remove_time*1000));
                }

                const reason = interaction.options.getString("reason") || "No Reason Provided";
                user.ban({reason: reason}).then(() => {
                    interaction.reply({
                        embeds: [new Discord.MessageEmbed().setTitle("User Banned").setColor("#56089e")]
                    }).then(msg => setTimeout(() => {
                        interaction.deleteReply();
                    }, client.config.message_remove_time*1000));
                }
                ).catch(err => {
                    interaction.reply({
                        embeds: [new Discord.MessageEmbed().setTitle("Something Went Wrong").setColor("#56089e")]
                    }).then(msg => setTimeout(() => {
                        interaction.deleteReply();
                    }, client.config.message_remove_time*1000));
                }
                );
            }
        }
    }
}
