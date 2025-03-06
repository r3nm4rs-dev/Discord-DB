const fs = require('fs')

module.exports = {
  name: "search",
  descriptionfr: "Recherche une commande",
  descriptionen: "Search a command",
  usage: "<command>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please enter a command name/letters", "Veuillez entrez un nom/des lettres de commandes"))
    const commands = []
    for (const commande of client.commands.filter(c => c.name.includes(args.join(' '))).map(c => c)){
      client.db.theme === "mill" ? commands.push(`\`${client.db.prefix}${commande.name}\`\n**┖ Description :** \`${client.trad(commande.descriptionen || "No Description.", commande.descriptionfr || "Aucune Description.")}\`\n**┖ Usage :**\`${commande.usage ? `${commande.name} ${commande.usage}` : client.trad("No Usage.", "Aucun Utilisation.")}\``) :
      client.db.theme === "k3s" ? commands.push(`\`${client.db.prefix}${commande.name}\`\n▸ ***${client.trad(commande.descriptionen || "No Description", commande.descriptionfr || "Aucune Description")}**.*`) :
      client.db.theme === "speed" ? commands.push(`\`${client.db.prefix}${commande.name}\` ➜ **${client.trad(commande.descriptionen || "No Description.", commande.descriptionfr || "Aucune Description.")}**`) :
      client.db.theme === "nighty" ? commands.push(`[ ${client.db.prefix}${commande.name} ${commande.usage || " "}] ${!client.trad(commande.descriptionen, commande.descriptionfr) ? client.trad('No description.', 'Aucune description.') : client.trad(commande.descriptionen, commande.descriptionfr)}`) : 
      client.db.theme === "ryz" ? commands.push(`- **${client.db.prefix}${commande.name}** ${!client.trad(commande.descriptionen, commande.descriptionfr) ? client.trad('No description.', 'Aucune description.') : client.trad(commande.descriptionen, commande.descriptionfr)}`) : 
      client.db.theme === "ethone" ? commands.push(`${client.db.prefix}${commande.name} » ${!client.trad(commande.descriptionen, commande.descriptionfr) ? client.trad('No description.', 'Aucune description.') : client.trad(commande.descriptionen, commande.descriptionfr)}`) :
      commands.push(`\`${client.db.prefix}${commande.name}\` ➜ **${client.trad(commande.descriptionen || "No Description.", commande.descriptionfr || "Aucune Description.")}**`)
    }
    message.edit(`${commands.length > 0 ? commands.map(c => c).join("\n") : client.trad("No command found", "Aucune commande de trouvée")}`)
  }
}