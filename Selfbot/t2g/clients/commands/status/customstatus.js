const {CustomStatus} = require('discord.js-selfbot-v13')

module.exports = {
    name: "customstatus",
    description: "Clear the status",
    run: async (client, message, args) => {
        try{
            const db = client.db
            if(client.db.rpc) client.db.rpc = {}
            if(args[0] === "clear"){
                    db.rpc.customstatus = false;
                    client.save(client, client.db)
                    message.delete()
                    return
                }
                if(!args[0]) {
                    message.edit(`\`${prefix}customstatus [emoji] [text]\``)
                }
                if(!args[1]) {
                    message.edit(`\`${prefix}customstatus [emoji] [text]\``)
                }
                db.rpc.emoji = args[0]
                db.rpc.textstatus = args[1]
                const r = new CustomStatus(client)
                if (db.rpc.emoji) r.setEmoji(db.rpc.emoji)
                if (db.rpc.textstatus) r.setState(db.rpc.textstatus)
                client.user.setActivity(r)
                if(db.lang === "fr") message.edit(`***Le customStatus a été mis a jour avec succès**.*`)
                    if(db.lang === "en") message.edit(`***The customStatus has been successfully updated.***`)
}catch(e){
    console.log(e)
}
    }
}