module.exports = {
    name: "fun",
    run: async(client, message, args) => {
        let title = client.db.nitro === true ? '<:manette:1275512898206302271>' : '\`🎰\`'
        let arrow = client.db.nitro === true ? ' <:arrow:1274251907002667038> ' : '・'
        message.edit(client.db.lang === 'fr'
            ? `» **__Help Fun__** ${title}\n\n` +
              `***Jouer à pile ou face***${arrow}\`${client.db.prefix}cointoss\`\n` +
              `***Envoyer un faux Nitro***${arrow}\`${client.db.prefix}nitro\`\n` +
              `***Première partie du token***${arrow}\`${client.db.prefix}token [user]\`\n\n` +
              `***Pourcentage de gay***${arrow}\`${client.db.prefix}gay [user]\`\n` +
              `***Pourcentage d'amour***${arrow}\`${client.db.prefix}love [user]\`\n` +
              `***Pourcentage de saloperie***${arrow}\`${client.db.prefix}thot [user]\`\n` +
              `***Nombre au hasard***${arrow}\`${client.db.prefix}number [max]\`\n\n` +
              `***Animation cœur***${arrow}\`${client.db.prefix}hearth\`\n` +
              `***Animation kawaii***${arrow}\`${client.db.prefix}shy\`\n` +
              `***Animation branlette***${arrow}\`${client.db.prefix}jerkoff\`\n\n` +
              `***Faire un câlin à quelqu'un***${arrow}\`${client.db.prefix}hug [user]\`\n` +
              `***Faire un bisou à quelqu'un***${arrow}\`${client.db.prefix}kiss [user]\`\n` +
              `***Gifler quelqu'un***${arrow}\`${client.db.prefix}slap [user]\``
            : `» **__Help Fun__** ${title}\n\n` +
              `***Play Heads or Tails***${arrow}\`${client.db.prefix}cointoss\`\n` +
              `***Send a fake Nitro***${arrow}\`${client.db.prefix}nitro\`\n` +
              `***First part of the token***${arrow}\`${client.db.prefix}token [user]\`\n\n` +
              `***Percentage of gay***${arrow}\`${client.db.prefix}gay [user]\`\n` +
              `***Percentage of love***${arrow}\`${client.db.prefix}love [user]\`\n` +
              `***Percentage of naughtiness***${arrow}\`${client.db.prefix}thot [user]\`\n` +
              `***Random number***${arrow}\`${client.db.prefix}number [max]\`\n\n` +
              `***Heart animation***${arrow}\`${client.db.prefix}hearth\`\n` +
              `***Kawaii animation***${arrow}\`${client.db.prefix}shy\`\n` +
              `***Jerk-off animation***${arrow}\`${client.db.prefix}jerkoff\`\n\n` +
              `***Give a hug to someone***${arrow}\`${client.db.prefix}hug [user]\`\n` +
              `***Give a kiss to someone***${arrow}\`${client.db.prefix}kiss [user]\`\n` +
              `***Slap someone***${arrow}\`${client.db.prefix}slap [user]\``);
        
    }
}