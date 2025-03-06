module.exports = {
  name: "largeimage",
  descriptionfr: "Modifie ou désactive la grande image",
  descriptionen: "Edit or disable the large image",
  usage: "[url]",
  run: async (client, message, args) => {
    if (!args[0]){
      client.db.rpclargeimage = null
      client.save()
      client.rpc()
      return message.edit(client.trad(`The small image has been **${args[0] ? "edited" : "deleted"}**`, `La petite image du rpc a été **${args[0] ? "modifiée" : "supprimée"}**`))
    }
    if (!args[0].startsWith("https://")) return message.edit(client.trad("Give me the discord link of an image", "Veuillez donner le lien discord d'une image"))
    client.db.rpclargeimage = args[0] ? args[0] : null
    client.save()
    client.rpc()
    message.edit(client.trad(`The large image has been **${args[0] ? "edited" : "deleted"}**`, `La grande image du rpc a été **${args[0] ? "modifiée" : "supprimée"}**`))
  }
}