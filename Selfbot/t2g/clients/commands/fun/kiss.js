module.exports = {
    name: "kiss",
    description: "",
    run: async (client, message, args) => {
        let user = message.mentions.users.first()
        if(!user) {
            const noUser = client.db.lang === "fr" ? "***Veuillez mentionner un utilisateur ou fournir son identifiant**.*" : "***Please mention one user or provide their ID**.*"
            message.edit(noUser)
            return
        }
        const images = [
            "https://imgur.com/a/fHvIoIo",
            "https://imgur.com/a/pJV9R3h",
            "https://imgur.com/a/CjGFXXy",
            "https://imgur.com/a/VHG51VR",
            "https://imgur.com/a/Umq60SM",
            "https://imgur.com/22SacNE",
            "https://imgur.com/Me1o6YB",
            "https://imgur.com/oXRW1XU",
            "https://imgur.com/OMqAU5h",
            "https://imgur.com/1sq3s21"
        ]
        const image = images[Math.floor(Math.random() * images.length)];
        message.edit(`🖐 ***<@${client.user.id}> kisses ${user}***`)
        message.channel.send(`${image}`)
    }
}