const { MessageEmbed } = require('discord.js');
const db = require('quick.db');
const cl = new db.table("Color");
const config = require("../config");
const moment = require('moment');
const p1 = new db.table("Perm1");
const p2 = new db.table("Perm2");
const owner = new db.table("Owner");
const p3 = new db.table("Perm3");
require('moment/locale/fr');
moment.locale('fr');

module.exports = {
    name: 'serveur',
    usage: 'serveur',
    description: `Permet d'afficher des informations relatives au serveur`,
    async execute(client, message, args) {
        let color = cl.fetch(`color_${message.guild.id}`);
        if (color == null) color = config.bot.couleur;
         if (owner.get(`owners.${message.author.id}`) || message.member.roles.cache.has(perm1) || message.member.roles.cache.has(perm2) || message.member.roles.cache.has(perm3) || config.bot.buyer.includes(message.author.id)  ) {

        if (!args[0]) {
            return message.channel.send("Veuillez fournir un argument valide (pic, banner, info).");
        }

        if (args[0] === "pic") {
            let pic = message.guild.iconURL();
            if (pic) {
                const picembed = new MessageEmbed()
                    .setTitle(`${message.guild.name}`)
                    .setColor(color)
                    .setImage(message.guild.iconURL({ dynamic: true, size: 1024 }));
                message.channel.send({ embeds: [picembed] });
            } else {
                const nopic = new MessageEmbed()
                    .setTitle(`${message.guild.name}`)
                    .setColor(color)
                    .setDescription(`Ce serveur ne possède pas d'avatar`);
                message.channel.send({ embeds: [nopic] });
            }
        } else if (args[0] === "banner") {
            let banner = message.guild.bannerURL();
            if (banner) {
                const bannerembed = new MessageEmbed()
                    .setTitle(`${message.guild.name}`)
                    .setColor(color)
                    .setImage(message.guild.bannerURL({ dynamic: true, size: 512 }));
                message.channel.send({ embeds: [bannerembed] });
            } else {
                const nobanner = new MessageEmbed()
                    .setTitle(`${message.guild.name}`)
                    .setColor(color)
                    .setDescription('Ce serveur ne possède pas de bannière');
                message.channel.send({ embeds: [nobanner] });
            }
        } else if (args[0] === "info") {
            const premiumTier = {
                NONE: 0,
                TIER_1: 1,
                TIER_2: 2,
                TIER_3: 3,
            };

            const verifLevels = {
                NONE: "Aucune",
                LOW: "Faible",
                MEDIUM: "Moyen",
                HIGH: "Élevé",
                VERY_HIGH: "Maximum",
            };

            const rolesGuild = message.guild.roles.cache.sort((a, b) => b.position - a.position).map(role => role.toString());
            const membersGuild = message.guild.members.cache;
            const channelsGuild = message.guild.channels.cache;
            const emojisGuild = message.guild.emojis.cache;

            let desc = message.guild.description;
            if (desc == null) desc = "Le serveur ne possède pas de description !";

            const embed = new MessageEmbed()
                .setColor(color)
                .setThumbnail(message.guild.iconURL({ dynamic: true }))
                .setImage(message.guild.bannerURL({ dynamic: true, size: 512 }))
                .setTitle(`Informations sur \`${message.guild.name}\``)
                .setDescription(`**Description**\n ${desc}`)
                .addFields(
                    { name: `ℹ️ ID du serveur`, value: `${message.guild.id}`, inline: true },
                    { name: `👑 Propriétaire`, value: `<@${message.guild.ownerId}>`, inline: true },
                    { name: `ℹ️ ID Propriétaire`, value: `${message.guild.ownerId}`, inline: true },
                    { name: `👥 Nombre de Membres`, value: `${message.guild.memberCount || '0'}`, inline: true },
                    { name: "Nombre de Boosts", value: `${message.guild.premiumSubscriptionCount || '0'}`, inline: true },
                    { name: `🔮 Niveau de Boost`, value: `${premiumTier[message.guild.premiumTier]}`, inline: true },
                    { name: `🤖 Nombre de Bots`, value: `${membersGuild.filter(member => member.user.bot).size}`, inline: true },
                    { name: `👤 Nombre de Rôles`, value: `${rolesGuild.length}`, inline: true },
                    { name: `️⃣ Nombres de Salons`, value: `${channelsGuild.size}`, inline: true },
                    { name: `🎈 Nombre d'Emojis`, value: `${emojisGuild.size}`, inline: true },
                    { name: `❕ Date de création`, value: `${moment(message.guild.createdAt).format('LLLL')}`, inline: true },
                    { name: `🔗 URL Personnalisée`, value: message.guild.vanityURLCode ? `discord.gg/${message.guild.vanityURLCode}` : `Le serveur ne possède pas d'URL`, inline: true },
                    { name: `⚙️ Vérification du serveur`, value: `${verifLevels[message.guild.verificationLevel]}`, inline: true }
                )
                .setFooter({ text: `${config.bot.footer}` });
            message.channel.send({ embeds: [embed] });
        } else {
        }
    }
}
};
