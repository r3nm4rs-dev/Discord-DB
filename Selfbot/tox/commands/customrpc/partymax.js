module.exports = {
  name: "partymax",
  descriptionfr: "Modifie le nombre d'utilisateur max.",
  descriptionen: "Edit the max users in the rpc",
  usage: "[number]",
  run: async (client, message, args) => {
    client.db.rpcpartymax = isNaN(args[0]) ? 0 : args[0]
    client.save()
    client.rpc()
    message.edit(client.trad(`The ma players has been **modifié**`, `Le nombre de joueur max. du rpc a été **modifié**`))
  }
}