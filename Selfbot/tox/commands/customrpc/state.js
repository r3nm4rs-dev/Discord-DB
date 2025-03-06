module.exports = {
  name: "state",
  descriptionfr: "Modifie le nom du RPC",
  descriptionen: "Edit the name of the RPC",
  usage: "[text]",
  run: async (client, message, args) => {
    client.db.rpcstate = args[0] ? args.slice(1).join(' ') : null
    client.save()
    client.rpc()
    message.edit(client.trad(`The rpc state has been **${args[0] ? "edited" : "deleted"}**`, `Les states du rpc ont été **${args[0] ? "modifiés" : "supprimés"}**`))
  }
}