module.exports = {
    name: "vanity",
    run: async(client, message) => {
    let title = client.db.nitro === true ? '<:sniper:1276098668164026471>' : '\`🎯\`'
    let arrow = client.db.nitro === true ? ' <:arrow:1274251907002667038> ' : '・'
    message.edit(client.db.lang === 'fr' ? `» **__Help Vanity__** ${title}` : `» **__Vanity Help__** ${title}`)       
    }
}