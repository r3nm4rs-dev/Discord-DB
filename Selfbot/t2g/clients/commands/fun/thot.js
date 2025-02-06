module.exports = {
    name: "thot",
    description: "",

    run: async (client, message, args) => {
        try{
            let user = message.mentions.users.first() || client.users.cache.get(args[0]);
            if(!user) user = message.author
        const resultat = Math.round(Math.random() * 100)
        const reponse = client.db.lang === "fr" ? `***${user} est une salope à \`${resultat}%\` !***` : `***${user} is a \`${resultat}%\` slut !***`
        message.edit(reponse)
    }catch(e){
        const error = client.db.lang === "fr" ? `***${user} est une salope à \`0%\` !***` : `***${user} is a \`0%\` slut !***`
        message.edit(error)
        return
    }
    }
}