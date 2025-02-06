module.exports = {
    name: "status",
    run: async(client, message) => {
        let title = client.db.nitro === true ? '<:black_star:1276458935846703196>' : '\`⭐\`'
        let arrow = client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'
        message.edit(client.db.lang === 'fr' ? `» **__Help Status__** ${title}\n\n***Permet d'effacer son status***${arrow}\`${client.db.prefix}clearstatus\`\n\n***Mettre le customstatus***${arrow}\`${client.db.prefix}customstatus <emoji> <text>\`\n***Enleve le customstatus***${arrow}\`${client.db.prefix}customstatus clear\`\n\n***Help multistatus***${arrow}\`${client.db.prefix}multistatus\`\n***Mettre un activité***${arrow}\`${client.db.prefix}setactivity <type> <text>\`\n***Changer le status***${arrow}\`${client.db.prefix}setstatus <online/dnd/idle/invisible>\`` : `» **__Help Status__** ${title}\n\n***Allows you to clear your status***${arrow}\`${client.db.prefix}clearstatus\`\n\n***Set a custom status***${arrow}\`${client.db.prefix}customstatus <emoji> <text>\`\n***Remove the custom status***${arrow}\`${client.db.prefix}customstatus clear\`\n\n***Multistatus help***${arrow}\`${client.db.prefix}multistatus\`\n***Set an activity***${arrow}\`${client.db.prefix}setactivity <type> <text>\`\n***Change the status***${arrow}\`${client.db.prefix}setstatus <online/dnd/idle/invisible>\``)
    }
}