const fs = require('fs')

module.exports = {
    name: "premium",
    descriptionfr: "Vérifie si vous êtes premium ou active un code",
    descriptionen: "Check if you're premium or activate a code",
    usage: "[code]",
    run: async (client, message, args) => {
        if (!args[0] && client.premium){
            const codes = await client.mongodb.get("premiums") || []
            const codeinfo = codes.filter(c => c?.redeemedBy === client.user.id)[0]
            return message.edit(client.trad(
                `\`\`\`💲 YOU'RE A PREMIUM MEMBER 💲\`\`\`
                - **Code:** \`${codeinfo.code}\`
                - **Expire At:** <t:${Math.round(codeinfo.expiresAt / 1000)}:R>
                - **Used:** <t:${Math.round(codeinfo.redeemedAt / 1000)}:R>`.replaceAll("                ", ""), 
                `\`\`\`💲 VOUS ETES UN MEMBRE PREMIUM 💲\`\`\`
                - **Code:** \`${codeinfo.code}\`
                - **Expire:** <t:${Math.round(codeinfo.expiresAt / 1000)}:R>
                - **Utilisé:** <t:${Math.round(codeinfo.redeemedAt / 1000)}:R>`.replaceAll("                ", "")))
        }
        if (!args[0] && !client.premium) return message.edit(client.trad("`🔴` You're not a premium member `🔴`", "`🔴` Tu n'es pas un membre premium `🔴`"))
        else if (args[0]){
            const codes = await client.mongodb.get("premiums") || []
            const codeinfo = codes.filter(c => c.code === args[0])[0]
            if (codeinfo.isPremium === true) return message.edit(client.trad(`This code has already been used by <@${codeinfo.redeemedBy}>`, `Ce code a déjà été utilisé par <@${codeinfo.redeemedBy}>`))
            
            const place = codes.indexOf(codeinfo)

            codeinfo.isPremium = true
            codeinfo.redeemedBy = client.user.id
            codeinfo.redeemedAt = Date.now()
            client.premium = true

            codes.splice(place, 1, codeinfo)
            await client.mongodb.set("premiums", codes)
            message.edit(client.trad(`\`🟢\` Your code has beed activated now \`🟢\``, `\`🟢\` Votre code a été activé à l'instant \`🟢\``))
        }
    }
}