module.exports = {
  name: "smallimagetext",
  descriptionfr: "Modifie ou supprime le texte de la petite image",
  descriptionen: "Edit or delete the text of the the small image",
  usage: "[text]",
  run: async (client, message, args) => {
    client.db.rpcsmallimagetext = args[0] ? args.join(' ') : null
    client.save()
    client.rpc()
    message.edit(client.trad(`The text of the small image in the rpc has been **${args[0] ? "editeed" : "deleted"}**`, `Le texte de la petite image du rpc a été **${args[0] ? "modifié" : "supprimé"}**`))    
  }
}