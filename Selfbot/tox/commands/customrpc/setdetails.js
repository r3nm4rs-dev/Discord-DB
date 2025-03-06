module.exports = {
  name: "setdetails",
  descriptionfr: "Modifie les détails du RPC",
  descriptionen: "Edit the details of the RPC",
  usage: "[text]",
  run: async (client, message, args) => {
    client.db.rpcdetails = args[0] ? args.join(' ') : null
    client.save()
    client.rpc()
    message.edit(client.trad(`The rpc details has been **${args[0] ? "edited" : "deleted"}**`, `Vos details de rpc ont été **${args[0] ? "modifiés" : "supprimés"}**`))
  }
}