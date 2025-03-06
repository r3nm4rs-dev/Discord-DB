exports.get = (flags) => {
        const discord_worker = 1; const partner_server_owner = 2; const hypesquad_events = 4; const Bug_Hunter_Level_1 = 8; const House_Bravery = 64;const House_Brilliance = 128; const House_Balance = 256; const Early_Supporter = 512; const Bug_Hunter_Level_2 = 16384; const Early_Verified_Bot_Developer = 131072; const Active_Developer = 4194304;
        var badges = "";

        if ((flags & discord_worker) == discord_worker) { badges += "<:staff:874750808728666152> " }
        if ((flags & partner_server_owner) == partner_server_owner) { badges += "<:partner:874750808678354964> " }
        if ((flags & hypesquad_events) == hypesquad_events) { badges += "<:hypesquad_events:874750808594477056> " }
        if ((flags & Bug_Hunter_Level_1) == Bug_Hunter_Level_1) { badges += "<:bughunter_1:874750808426692658> " }
        if ((flags & House_Bravery) == House_Bravery) { badges += "<:bravery:874750808388952075> " }
        if ((flags & House_Brilliance) == House_Brilliance) { badges += "<:brilliance:874750808338608199> " }
        if ((flags & House_Balance) == House_Balance) { badges += "<:balance:874750808267292683> " }
        if ((flags & Early_Supporter) == Early_Supporter) { badges += "<:early_supporter:874750808414113823> " }
        if ((flags & Bug_Hunter_Level_2) == Bug_Hunter_Level_2) { badges += "<:bughunter_2:874750808430874664> " }
        if ((flags & Early_Verified_Bot_Developer) == Early_Verified_Bot_Developer) { badges += "<:developer:874750808472825986> " }
        if ((flags & Active_Developer) == Active_Developer) { badges += "<:activedev:1077552129335636069> " }
        if (badges == "") { badges = "\`No Badges\`" }
        
        return badges
}