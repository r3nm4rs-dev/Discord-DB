module.exports = {
  name: "partymin",
  descriptionfr: "Modifie le nombre d'utilisateur min.",
  descriptionen: "Edit the min users in the rpc",
  usage: "[number]",
  run: async (client, message, args) => {
    client.db.rpcpartymin = isNaN(args[0]) ? 0 : args[0]
    client.save()
    client.rpc()
    message.edit(client.trad(`The min players has been **edited**`, `Le nombre de joueur min. du rpc a été **modifié**`))    
  }
}