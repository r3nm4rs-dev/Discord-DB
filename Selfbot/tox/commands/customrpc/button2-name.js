module.exports = {
  name: "button2-name",
  descriptionfr: "Modifie le texte du 2eme bouton",
  descriptionen: "Edit the text of the 2nd button",
  usage: "[text]",
  run: async (client, message, args) => {
    client.db.rpcbuttontext2 = args[0] ? args.join(' ') : null
    client.save()
    client.rpc()
    message.edit(client.trad(`The text of the 2nd button has been ${args[0] ? "edited" : "deleted"}`, `Le texte du bouton 2 a été ${args[0] ? "modifié" : "supprimé"}`)) 
  }
}