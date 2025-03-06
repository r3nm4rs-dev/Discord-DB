module.exports = {
  name: "name",
  descriptionfr: "Modifie le nom du RPC",
  descriptionen: "Edit the name of the RPC",
  usage: "<text>",
  run: async (client, message, args) => {
    
    client.db.rpcname = args[0] ? args.join(' ') : null
    client.save()
    client.rpc()
    message.edit(client.trad(`Your rpc name has been **${args[0] ? "edited" : "deleted"}**`, `Votre nom de rpc a été **${args[0] ? "modifié" : "supprimé"}**`))
 }
}