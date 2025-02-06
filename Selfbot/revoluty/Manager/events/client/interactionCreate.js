module.exports = {
    name: "interactionCreate",
    once: false,
    run: async(client, interaction) => {


        client.color = await client.db.get(`color_${interaction.guild.id}`) || client.config.color
        let lang = client.db.get(`lang_${interaction.guild.id}`) || client.db.get(`lang_${interaction.guild.id}`) || client.config.defaultLang;
        let langData = await client.lang.get(lang);
        let foot = client.db.get(`footer_${client.user.id}`) || {
            text: null,
            icon_url: null
        }


        if (!foot || !foot.text || !foot.icon_url) {
            client.footer = client.config.footer;
        } else {
            client.footer = foot;
        }

        let thumb = client.db.get(`thumbnail_${client.user.id}`) || {
            icon_url: null
        }

        if (!thumb || !thumb.icon_url) {
            client.thumbnail = client.user.displayAvatarURL({ dynamic: true });
        } else {
            client.thumbnail = thumb;
        }

        const command = client.slashCommands.get(interaction.commandName);
        if (!command) return;
        const msg_cmd = [
            `[SLASH] ${command.name}`,
            `Utilisé par ${interaction.user.tag} sur ${interaction.guild.name} (${interaction.guild.id})`,
        ];

        console.log(`${msg_cmd.join(" ")}`);

        try {
            command.run(client, interaction);
        } catch(e) {
            console.error(e);
            interaction.reply({
                content: `\`❌\` | Une erreur est survenue lors de l'exécution de cette commande.`,
                ephemeral: true,
            });
        }
    }
}