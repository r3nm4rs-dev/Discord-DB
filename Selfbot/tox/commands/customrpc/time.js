module.exports = {
  name: "time",
  descriptionfr: "Active ou désactive l'heure du RPC",
  descriptionen: "Enable or disable the time of the RPC",
  usage: "<on/off>",
  run: async (client, message, args) => {
    client.db.rpctimestamp = args[0] === "on" ? true : null
    client.save()
    client.rpc()
    message.edit(client.trad(`The time of the rpc has been **${args[0] === "on" ? "enabled" : "disabled"}**`, `Le temps du rpc a été **${args[0] === "on" ? "activé" : "désactivé"}**`))
  }
}