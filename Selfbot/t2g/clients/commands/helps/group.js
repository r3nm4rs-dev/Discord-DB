module.exports = {
    name: "group",
    run: async(client, message, args) => {
        let title = client.db.nitro === true ? '<:emoji_5:1275207694919274507>' : '\`👨‍👨‍👧\`'
        let arrow = client.db.nitro === true ? ' <:arrow:1274251907002667038> ' : '・'
        message.edit(client.db.lang === 'fr' ? 
  `» __**T2G**__ ${title}\n\n***Active l'anti groupe***${arrow}\`${client.db.prefix}antigroup <on/off>\`\n***Ajoute quelqu'un a la wl***${arrow}\`${client.db.prefix}antigroup wl [user]\`\n***Enleve quelqu'un de la wl***${arrow}\`${client.db.prefix}antigroup unwl [user]\`\n\n***Enable silent leave***${arrow}\`${client.db.prefix}silentleave <on/off>\``
: 
  `» **__T2G__** ${title}\n\n***Enable antigroup***${arrow}\`${client.db.prefix}antigroup <on/off>\`\n***Add a user to the wl***${arrow}\`${client.db.prefix}antigroup wl [user]\`\n***Remove a user from the wl***${arrow}\`${client.db.prefix}antigroup unwl [user]\`\n\n***Enable silent leave***${arrow}\`${client.db.prefix}silentleave <on/off>\``)
    }
}