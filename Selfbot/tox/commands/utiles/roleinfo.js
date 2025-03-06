const { Message } = require("djs-selfbot-v13");

const fs = require('fs')

module.exports = {
    name: "roleinfo",
    descriptionfr: "Affiche les informations d'un rôle",
    descriptionen: "Display the informations from a role",
    usage: "<role>",
    /**
     * @param {Message} message
    */
      run: async (client, message, args) => {
      let role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0]);
      if (!role) return message.edit(client.trad(
          `No role found for \`${args[0] || "nothing"}\``,
          `Aucun rôle de trouvé pour \`${args[0] || "rien"}\``
        ))
  
        message.edit(client.trad(
            `__**⛧ ${client.db.name} INFOS ⛧**__
            >>> **Name of the role:** ➜ \`${role.name}\`
            **ID** ➜ \`${role.id}\`
            **Color** ➜ \`${role.color}\`
            **Editable** ➜ \`${role.editable ? "Yes" : "No"}\`
            **Bot's role** ➜ \`${role.managed ? "Yes" : "No"}\`
            **Mentionnable** ➜ \`${role.mentionable ? "Yes" : "No"}\`
            **Members with this role** ➜ \`${role.members.size}\`
            **Created** ➜ <t:${Math.round(role.createdAt / 1000)}:R>
            **Icon** ➜ ${role.icon ? role.iconURL : "\`No\`"}`.replaceAll("            ", ""),
            `__**⛧ ${client.db.name} INFOS ⛧**__
            >>> **Nom du rôle:** ➜ \`${role.name}\`
            **ID** ➜ \`${role.id}\`
            **Couleur** ➜ \`${role.color}\`
            **Modifiable** ➜ \`${role.editable ? "Oui" : "Non"}\`
            **Rôle d'un Bot** ➜ \`${role.managed ? "Oui" : "Non"}\`
            **Mentionnable** ➜ \`${role.mentionable ? "Oui" : "Non"}\`
            **Membres ayant ce rôle** ➜ \`${role.members.size}\`
            **Créé** ➜ <t:${Math.round(role.createdAt / 1000)}:R>
            **Icone du rôle** ➜ ${role.icon ? role.iconURL : "\`Non\`"}`.replaceAll("            ", "")
        ))
    }
  }