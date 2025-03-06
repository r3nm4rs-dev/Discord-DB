const { MessageEmbed, MessageActionRow, MessageButton } = require('discord.js');
const config = require("../config");
const db = require('quick.db');
const cl = new db.table("Color");
const p3 = new db.table("Perm3");
const owner = new db.table("Owner");

module.exports = {
    name: 'role',
    description: `Permet d'avoir des informations sur un rôle.`,
    async execute(client, message, args) {
        try {
            let color = cl.get(`color_${message.guild.id}`) || config.bot.couleur;

             if (owner.get(`owners.${message.author.id}`) || message.member.roles.cache.has(perm3) || config.bot.buyer.includes(message.author.id)  ) {

            let membersWithRole = role.members.map(member => member.user.tag).filter((value, index, self) => self.indexOf(value) === index);

            const perms = {
                KICK_MEMBERS: "Expulser des membres",
                BAN_MEMBERS: "Bannir des membres",
                MANAGE_WEBHOOKS: "Gérer les webhooks",
                VIEW_AUDIT_LOG: "Voir les logs du serveur",
                MANAGE_ROLES: "Gérer les rôles",
                MANAGE_CHANNELS: "Gérer les salons",
                MANAGE_GUILD: "Gérer le serveur"
            };

            const dangerousPerms = Object.keys(perms).filter(perm => role.permissions.has(perm));
            const allPermissions = dangerousPerms.length > 0 ? dangerousPerms.map(perm => perms[perm]).join(", ") : "Aucune";

            const roleEmbed = new MessageEmbed()
                .setColor(color)
                .addField("Nom du rôle", `<@&${role.id}>`)
                .addField("Couleur Hex", role.hexColor === "#000000" ? "Classique" : role.hexColor)
                .addField("ID du rôle", role.id)
                .addField("Est-il affiché séparément ?", role.hoist ? "Oui" : "Non")
                .addField("Est-il mentionnable ?", role.mentionable ? "Oui" : "Non")
                .addField("Est-il géré par une intégration", role.managed ? "Oui" : "Non")
                .addField("Permissions principales", allPermissions)
                .setFooter(config.bot.footer);

            const membersButton = new MessageButton()
                .setCustomId('members_button')
                .setLabel('Membres avec le rôle')
                .setStyle('PRIMARY');

            const removeRoleButton = new MessageButton()
                .setCustomId('remove_role_button')
                .setLabel('Supprimer le rôle à un membre')
                .setStyle('DANGER');

            const closeButton = new MessageButton()
                .setCustomId('close_button')
                .setLabel('Fermer')
                .setStyle('SECONDARY');

            const row = new MessageActionRow()
                .addComponents(membersButton, removeRoleButton, closeButton);

            const sentMessage = await message.channel.send({ embeds: [roleEmbed], components: [row] });

            const filter = i => ['members_button', 'remove_role_button', 'close_button'].includes(i.customId) && i.user.id === message.author.id;

            const collector = sentMessage.createMessageComponentCollector({ filter, time: 15000 });

            collector.on('collect', async i => {
                if (i.customId === 'members_button') {
                    if (membersWithRole.length > 0) {
                        const membersEmbed = new MessageEmbed()
                            .setColor(color)
                            .setTitle(`Membres ayant le rôle ${role.name}`)
                            .setDescription(membersWithRole.join('\n'));

                        await i.reply({ embeds: [membersEmbed], ephemeral: true });
                    } else {
                        await i.reply({ content: 'Aucun membre n\'a ce rôle.', ephemeral: true });
                    }
                } else if (i.customId === 'remove_role_button') {
                    const mention = await message.channel.send("Veuillez mentionner le membre auquel vous souhaitez supprimer le rôle.");

                    const filter = response => {
                        return message.author.id === response.author.id && response.mentions.members.first();
                    };

                    message.channel.awaitMessages({ filter, max: 1, time: 60000, errors: ['time'] })
                        .then(async collected => {
                            const member = collected.first().mentions.members.first();

                            if (!member) {
                                return message.channel.send("Membre introuvable.");
                            }

                            try {
                                await member.roles.remove(role);
                                await message.channel.send(`Le rôle ${role.name} a été supprimé avec succès à ${member.user.tag}.`);
                            } catch (error) {
                                console.error("Erreur lors de la suppression du rôle:", error);
                                await message.channel.send("Une erreur est survenue lors de la suppression du rôle.");
                            }
                        })
                        .catch(() => {
                            message.channel.send("Temps écoulé, aucune mention reçue.");
                        });

                    mention.delete();
                } else if (i.customId === 'close_button') {
                    await sentMessage.delete();
                }
            });

            collector.on('end', () => {
                row.components.forEach(component => component.setDisabled(true));
                sentMessage.edit({ components: [row] });
            });
        }
        } catch (error) {
            console.error("Une erreur est survenue lors de l'exécution de la commande 'role':", error);
            message.channel.send("Une erreur est survenue lors de l'exécution de la commande.");
        }
    }
};