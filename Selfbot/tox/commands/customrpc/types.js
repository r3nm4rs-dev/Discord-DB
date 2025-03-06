module.exports = {
  name: "type",
  descriptionfr: "Modifie le type du RPC",
  descriptionen: "Edit the type of the RPC",
  usage: "<type>",
  run: async (client, message, args) => {
    const types = ["playing", "listening", "streaming", "watching", "competing"]
    if (!types.includes(args[0])) return message.edit(client.trad(`Please give me one of them choice: ${types.map(t => `\`${t}\``).join(', ')}`, `Veuillez me donner l'un de ces choix: ${types.map(t => `\`${t}\``).join(', ')}`))
    client.db.rpctype = args[0].toLocaleUpperCase()
    client.save()
    client.rpc()
    message.edit(client.trad(`The rpc type has been **edited**`, `Le type du rpc a été **modifié**`))
  }
}