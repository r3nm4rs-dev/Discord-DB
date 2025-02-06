module.exports = {
    name: "slap",
    description: "",
    run: async (client, message, args, db, prefix, tag, help, utility, backup, moderation, voice, arrow, logs, settings, fun) => {
        let user = message.mentions.users.first()
        if(!user) {
            const noUser = db.language === "fr" ? "***Veuillez mentionner un utilisateur ou fournir son identifiant**.*" : "***Please mention one user or provide their ID**.*"
            message.edit(noUser)
            return
        }
        const images = [
            "https://imgur.com/a/FNPYFDj",
            "https://imgur.com/a/y35g2ZK",
            "https://imgur.com/a/CjGFXXy",
            "https://imgur.com/a/IGvBFfy",
            "https://imgur.com/a/uIJED3K",
            "https://imgur.com/a/3BW6Z9V",
            "https://imgur.com/a/YfejcaR",
            "https://imgur.com/a/XE40ZVO",
            "https://imgur.com/a/gch96Ri",
            "https://imgur.com/a/1fQjhzo",
            "https://imgur.com/a/7WW0vcE"
        ]
        const image = images[Math.floor(Math.random() * images.length)];
        message.edit(`🖐 ***<@${client.user.id}> slaps ${user}***`)
        message.channel.send(`${image}`)
    }
}