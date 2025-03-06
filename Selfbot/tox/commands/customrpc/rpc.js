module.exports = {
  name: "rpc",
  descriptionfr: "Active ou désactive ton RPC",
  descriptionen: "Enable or disable the RPC",
  usage: "<on/off>",
  run: async (client, message, args) => {
    client.db.rpc = args[0] === "on" ? true : false
    client.save()
    client.rpc()
    message.edit(client.trad(`Your rpc has been **${args[0] === "on" ? "enabled" : "disabled"}**`, `Votre rpc a été **${args[0] === "on" ? "activé" : "désactivé"}**`))
  }
}