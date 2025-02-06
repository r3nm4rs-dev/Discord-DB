module.exports = {
    name: "hug",
    description: "",
    run: async (client, message, args) => {
        let user = message.mentions.users.first()
        if(!user) {
            const noUser = client.db.lang === "fr" ? "***Veuillez mentionner un utilisateur ou fournir son identifiant**.*" : "***Please mention one user or provide their ID**.*"
            message.edit(noUser)
            return
        }
        const images = [
            "https://imgur.com/pa0R1t5",
            "https://imgur.com/a/pJV9R3h",
            "https://imgur.com/UKYDxVe",
            "https://imgur.com/BKOxZb7",
            "https://imgur.com/ZTjKona",
            "https://imgur.com/sZFpOxH",
            "https://imgur.com/eIEKQpx",
            "https://imgur.com/j3JsmPd",
            "https://imgur.com/DUsaZ4c",
            "https://imgur.com/fyymfiZ"
        ]
        const image = images[Math.floor(Math.random() * images.length)];
        message.edit(`🖐 ***<@${client.user.id}> hug ${user}***
`)
        message.channel.send(`${image}`)
    }
}