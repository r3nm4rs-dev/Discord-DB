const fs = require('fs')

module.exports = {
  name: "deletewebhook",
  descriptionfr: "Supprime un webhook",
  descriptionen: "Delete a webhook",
  usage: '<webhook url>',
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a valid webhook url", "Envoyez un URL de webhook valide"))
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n\`\`\`js\nlet webhookURL = "${args[0]}";\n\n    await fetch(webhookURL, {\n      "method": "DELETE",\n    });\`\`\``)
  }
}