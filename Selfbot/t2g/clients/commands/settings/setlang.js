module.exports = {
    name: "setlang",
    run: async(client, message, args) => {
        if(!args[0] && args[0] !== "fr" && args[0] !== "en") return message.edit(db.lang === "en" ? `***You must choose a language between*** \`fr/en\`.` : `***Tu dois choisir une langue entre*** \`fr/en\`.`)
        if(args[0] === "fr") {
            client.db.lang = args[0]
            client.save(client, client.db)
            message.edit(`***La langue de T2G a été changée en français**.*`)
        }
        if(args[0] === "en") {
            client.db.lang = args[0]
            client.save(client, client.db)
            message.edit(`***The language of T2G has been changed to English.***`)
        }
    }
}