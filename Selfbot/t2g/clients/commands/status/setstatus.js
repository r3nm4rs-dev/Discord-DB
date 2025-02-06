module.exports = {
    name: "setstatus",
    run: async(client, message, args) => {
        if(!args[0] && args[0] !== "online" && args[0] !== "dnd" && args[0] !== "idle" && args[0] !== "invisible") return message.edit(client.db.lang === 'fr' ? `***Vous devez choisir entre <online/dnd/idle/invisible>**.*` : ``)
            client.db.status = args[0]
            client.user.setStatus(args[0])
            client.save(client, client.db)
            message.delete()
    }
}