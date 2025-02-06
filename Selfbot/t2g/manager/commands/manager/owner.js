const Discord = require("discord.js");
const fs = require('fs');
const config = require('../../../config');

module.exports = {
    name: "owner",
    description: "Permet de gérer la liste des owners.",
    dev: true,
    options: [
        {
            name: "add",
            type: 1,
            description: "Ajouter quelqu'un à la liste des owners",
            options: [
                {
                    name: "user",
                    type: 6,
                    description: "La personne à ajouter à la liste",
                    required: true
                }
            ]
        },
        {
            name: "remove",
            type: 1,
            description: "Retirer quelqu'un de la liste des owners",
            options: [
                {
                    name: "user",
                    type: 6,
                    description: "La personne à retirer de la liste",
                    required: true
                },
            ]
        },
        {
            name: "list",
            type: 1,
            description: "Voir la liste des owners",
            options: []
        },
    ],
    run: async (client, interaction) => {
        try {
            const configPath = require.resolve('../../../config.json');
            const subcommand = interaction.options.getSubcommand();
            const user = interaction.options.getUser('user');
            
            if (!config.staffs) {
                config.staffs = [];
            }

            if (subcommand === "add") {
                if (!config.staffs.includes(user.id)) {
                    config.staffs.push(user.id);
                    fs.writeFileSync(configPath, JSON.stringify(config, null, 2));
                    await interaction.reply({content: `*${user.tag} a été ajouté à la liste des owners.*`, ephemeral: false});
                } else {
                    await interaction.reply({content: `*${user.tag} est déjà dans la liste des owners.*`, ephemeral: true});
                }
            } else if (subcommand === "remove") {
                if (config.staffs.includes(user.id)) {
                    config.staffs = config.staffs.filter(id => id !== user.id);
                    fs.writeFileSync(configPath, JSON.stringify(config, null, 2));
                    await interaction.reply({content: `*${user.tag} a été retiré de la liste des owners.*`, ephemeral: false});
                } else {
                    await interaction.reply({content: `*${user.tag} n'est pas dans la liste des owners.*`, ephemeral: true});
                }
            } else if (subcommand === "list") {
                const ownerTags = await Promise.all(config.staffs.map(async id => {
                    const owner = await client.users.fetch(id);
                    return `${owner.tag} : ${owner.id}`;
                }))
                const embed = new Discord.EmbedBuilder()
                .setTitle(`*Liste des owners:*`)
                .setDescription(`*${ownerTags.join('\n')}*`)
                await interaction.reply({embeds: [embed]});
            }
        } catch (e) {
            console.log(e)
        }
    }
}