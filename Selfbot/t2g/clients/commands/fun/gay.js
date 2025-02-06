module.exports = {
    name: "gay",
    description: "",

    run: async (client, message, args) => {
        try{
            let user = message.mentions.users.first() || client.users.cache.get(args[0])
            if(!user) user = message.author
        const resultat = Math.round(Math.random() * 100)
        const reponse = client.db.lang === "fr" ? `***${user} est gay à \`${resultat}%\` !***` : `***${user} is \`${resultat}%\` gay !***`
        message.edit(reponse)
    }catch(e){
        const error = client.db.lang === "fr" ? `***${user} est gay à \`0%\` !***` : `***${user} is 0% gay !***`
        message.edit(error)
        return
    }
    }
}