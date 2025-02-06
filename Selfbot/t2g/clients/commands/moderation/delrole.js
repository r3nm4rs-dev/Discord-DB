const Discord = require("discord.js-selfbot-v13");

module.exports = {

  name: "delrole",

  description: "Supprime un rôle d'un utilisateur",

  run: async (client, message, args) => {

    if (!message.member.permissions.has("MANAGE_ROLES")) {

      if(client.db.lang === "fr") message.edit("***Vous n'avez pas la permission de gérer les rôles!***");

      if(client.db.lang === "en") message.edit("***You do not have permission to manage roles!***");

      return;

    }

    const user = message.mentions.members.first();

    const roleArg = args.slice(1).join(" ");

    let role;

    if (message.mentions.roles.first()) {

      role = message.mentions.roles.first();

    } else {

      role = message.guild.roles.cache.get(roleArg) || message.guild.roles.cache.find(r => r.name === roleArg);

    }

    if (!user) {

      if(client.db.lang === "fr") message.edit("***Veuillez mentionner un utilisateur valide**.*");

      if(client.db.lang === "en") message.edit("***Please mention a valid user**.*");

      return;

    }

    if (!role) {

      if(client.db.lang === "fr") message.edit("***Veuillez mentionner un rôle valide ou fournir un ID de rôle valide**.*");

      if(client.db.lang === "en") message.edit("***Please mention a valid role or provide a valid role ID**.*");

      return;

    }

    try {

      await user.roles.remove(role);

      if(client.db.lang === "fr") message.edit(`***Le rôle*** \`${role.name}\`*** a été retiré avec succès de ${user.user.tag}**.*`);

      if(client.db.lang === "en") message.edit(`***The role*** \`${role.name}\`*** has been successfully removed from ${user.user.tag}**.*`);

    } catch (err) {

      console.log(err);

    }

  },

};