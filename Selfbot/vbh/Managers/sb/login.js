const Discord = require("discord.js");
const config = require("../../config.json");
const path = require('path');
const fs = require("fs");
const { Client, Collection } = require("discord.js-selfbot-v13");

module.exports = {
    name: "login",
    description: "Connecte toi",
    permissions: "Aucune",

    async run(bot, interaction) {
         const userId = interaction.user.id;
        
        if (acccess(bot, interaction, userId)) {
        const modal = new Discord.ModalBuilder()
        .setCustomId("modal")
        .setTitle("Connexion")
    
        const login = new Discord.TextInputBuilder()
                .setCustomId('token')
                .setLabel("token")
                .setStyle(Discord.TextInputStyle.Short);
    
        const roww = new Discord.ActionRowBuilder().addComponents(login);
    
        modal.addComponents(roww);
    
        await interaction.showModal(modal);
    }
   }
  }
      
      function acccess(bot, interaction, userId) {
        const dev = config.owner || [];
        const allowedRoles = config.role || [];
      
        const user = bot.users.cache.get(userId);
        const member = user ? interaction.guild.members.cache.get(userId) : null;
      
        return dev.includes(userId) || member?.roles.cache.some(role => allowedRoles.includes(role.id));
      }