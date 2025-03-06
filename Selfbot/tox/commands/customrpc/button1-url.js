module.exports = {
  name: "button1-url",
  descriptionfr: "Modifie le lien du 1er bouton",
  descriptionen: "Edit the text of the 1st button",
  usage: "[url]",
  run: async (client, message, args) => {
    client.db.rpcbuttonlink = args[0] ? args.join(' ') : null
    if (args[0] && !args[0].startsWith("https://" || "http://")) return message.edit(client.trad("Give me a valid URL", "Donne moi un URL valide"))
    client.save()
    client.rpc()
    message.edit(client.trad(`The url of the button 1 has been ${args[0] ? "edited" : "deleted"}`, `l'url du bouton 1 a été ${args[0] ? "modifié" : "supprimé"}`))
  }
}