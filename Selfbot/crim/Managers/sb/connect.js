const Discord = require("discord.js");
const path = require('path');

const fs = require("fs")
const { Client, Collection } = require("discord.js-selfbot-v13");

module.exports = {
    name: "connect",
    description: "pour se connecter.",
    permissions: "Aucune",

    async run(bot, interaction) {
        let embed = new Discord.EmbedBuilder()
            .setDescription(`👋 Bienvenu(e) sur le Panel de Connexion !

Le panel est à votre __disposition__ si vous **souhaitez** être **connecté(e)** à la bêta de **Crim**.

> ❓**Un Bug ?** Envoyez un **MP** à <@219096963902210048> avec le **bug** en __question__. **Nous** allons __essayer__ de **corriger** le **problème** le plus **rapidement** __possible__.


> ⚠️ **Note :** La __version__ **BÊTA** est **uniquement** __disponible__ pour __vérifier__ s'il y a des **bugs** dans les **commandes** de __base__, afin d'__éviter__ d'__éventuelles__ **erreurs** et d'**offrir** la **meilleur** __experience__ possible. **Aucune** commande "__wow__" n'est **actuellement** __disponible__. Aussi l'**esthétique** du **sb** n'est pas **définitive** ; elle a été __réalisée__ **uniquement** pour la **BÊTA**.`)
            .setColor("2c2d31");

        
        const connectButton = new Discord.ButtonBuilder()
            .setCustomId('login')
            .setEmoji('💎') 
            .setStyle(Discord.ButtonStyle.Secondary); 

        
        const row = new Discord.ActionRowBuilder()
            .addComponents(connectButton);

        
        await interaction.channel.send({
            embeds: [embed],
            components: [row]
        });
    }
};
