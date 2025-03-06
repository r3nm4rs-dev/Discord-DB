module.exports = {
  name: "button1-name",
  descriptionfr: "Modifie le texte du 1er bouton",
  descriptionen: "Edit the text of the 1st button",
  usage: "[text]",
  run: async (client, message, args) => {
    client.db.rpcbuttontext = args[0] ? args.join(' ') : null
    client.save()
    client.rpc()
    message.edit(client.trad(`The text of the 1st button has been ${args[0] ? "edited" : "deleted"}`, `Le texte du bouton 1 a été ${args[0] ? "modifié" : "supprimé"}`)) 
  }
}