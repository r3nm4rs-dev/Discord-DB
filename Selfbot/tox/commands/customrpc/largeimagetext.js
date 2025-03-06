module.exports = {
  name: "largeimagetext",
  descriptionfr: "Modifie ou supprime le texte de la grande image",
  descriptionen: "Edit or delete the text of the the large image",
  usage: "[text]",
  run: async (client, message, args) => {
    client.db.rpclargeimagetext = args[0] ? args.slice(1).join(' ') : null
    client.save()
    client.rpc()
    message.edit(client.trad(`The text of the large image in the rpc has been **${args[0] ? "editeed" : "deleted"}**`, `Le texte de la grande image du rpc a été **${args[0] ? "modifié" : "supprimé"}**`))    
  }
}