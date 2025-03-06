const fs = require('fs')

module.exports = {
  name: "punish",
  descriptionen: "Modifie la sanction lors d'un raid",
  descriptionfr: "Edit the punish for raids",
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "ban" && args[0] !== "kick" && args[0] !== "derank") return message.edit(client.trad("Missing parameters: `ban`, `kick` or `derank`", "Paramètre manquant: `ban`, `kick` ou `derank`"))
    if (args[0] === "derank"){
      client.db.sanction = "derank"
      client.save()
      message.edit(client.trad("The penalty will now be a **derank**" ,"La sanction sera maintenant un **derank**"))
    }
    else if (args[0] === "kick"){
      client.db.sanction = "kick"
      client.save()
      message.edit(client.trad("The penalty will now be a **kick**" ,"La sanction sera maintenant un **kick**"))
    }
    else if (args[0] === "ban"){
      client.db.sanction = "ban"
      client.save()
      message.edit(client.trad("The penalty will now be a **ban**" ,"La sanction sera maintenant un **ban**"))
    }
  }
}