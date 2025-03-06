module.exports = {
  name: "button2-url",
  descriptionfr: "Modifie le lien du 2eme bouton",
  descriptionen: "Edit the text of the 2nd button",
  usage: "[url]",
  run: async (client, message, args) => {
    client.db.rpcbuttonlink2 = args[0] ? args.join(' ') : null
    if (args[0] && !args[0].startsWith("https://" || "http://")) return message.edit(client.trad("Give me a valid URL", "Donne moi un URL valide"))
    client.save()
    client.rpc()
    message.edit(client.trad(`The url of the 2nd button has been ${args[0] ? "edited" : "deleted"}`, `l'url du bouton 2 a été ${args[0] ? "modifié" : "supprimé"}`))
  }
}