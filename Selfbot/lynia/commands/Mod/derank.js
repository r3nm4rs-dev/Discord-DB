const Discord = require('discord.js-selfbot-v13');

module.exports = {
    name: "derank",
    description: "Enlève tous les rôles d'un utilisateur mentionné.",
    run: async (client, message, args) => {
       
        if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_ROLES)) {
            return message.edit(`\`❌\` Vous n'avez pas la permission administrateur.`);
        }

        
        if (message.mentions.members.size === 0) {
            return message.edit("Veuillez mentionner l'utilisateur.");
        }

        const member = message.mentions.members.first();

        try {
            
            member.roles.cache.forEach(role => {
                
                if (role.id !== message.guild.id) {
                    member.roles.remove(role).catch(console.error);
                }
            });

            message.edit(`\`✅\` Tous les rôles ont été enlevés de \`${member.user.tag}.\``);
        } catch (error) {
            console.error(error);
            message.edit(`\`❌\` Error Syntaxe`);
        }
    }
};
