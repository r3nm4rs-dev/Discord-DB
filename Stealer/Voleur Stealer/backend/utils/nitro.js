const axios = require('axios')


function GetMonthFromDate(startDate, endDate) {
    return (endDate.getMonth() - startDate.getMonth() + 12 * (endDate.getFullYear() - startDate.getFullYear()) );
}

exports.get = async (flags, token, userid) => {

    let nitro;
    if (flags == 0) { nitro =  "\`No Nitro\`" }
    if (flags == 1) { nitro = ":space_classic:" }
    if (flags == 2) { 
        const config = { method: "GET", url: "https://discord.com/api/v9/users/" + userid + "/profile?with_mutual_guilds=false", headers: { 'Authorization': token, 'Content-Type': 'application/x-www-form-urlencoded', 'Accept-Encoding': '*'  }}
        
        await axios.request(config).then(async function (data) {
            let boost_badge_age = GetMonthFromDate(new Date(data.data.premium_guild_since), new Date())
            console.log(boost_badge_age)
            
            let boost_badge;

            if (boost_badge_age.toString() === '1' || boost_badge_age.toString() == '0') { boost_badge =  '<:space_classic:996835068851011584> <:space_boost_1:996836062687141979>' }
            if (boost_badge_age.toString() === '2' ) { boost_badge =  '<:space_classic:996835068851011584> <:space_boost_2:996836157994324048>' }
            if (boost_badge_age.toString() === '3' || boost_badge_age.toString() == '4' || boost_badge_age.toString() == '5' ) { boost_badge =  '<:space_classic:996835068851011584> <:space_boost_3:996836215565328414>' }
            if (boost_badge_age.toString() === '6' || boost_badge_age.toString() == '7' || boost_badge_age.toString() == '8' ) { boost_badge = '<:space_classic:996835068851011584> <:space_boost_4:996836251900592169>' }
            if (boost_badge_age.toString() === '9' ||  boost_badge_age.toString() == '10' || boost_badge_age.toString() == '11' ) { boost_badge = '<:space_classic:996835068851011584> <:space_boost_5:996836337837682818>' }
            if (boost_badge_age.toString() === '12' || boost_badge_age.toString() == '13' || boost_badge_age.toString() == '14' ) { boost_badge = '<:space_classic:996835068851011584> <:space_boost_6:996836457694118089>' }
            if (boost_badge_age.toString() === '15' || boost_badge_age.toString() == '16' || boost_badge_age.toString() == '17') { boost_badge = '<:space_classic:996835068851011584> <:space_boost_7:996836512538837053>' }
            if (boost_badge_age.toString() === '18' || boost_badge_age.toString() == '19' || boost_badge_age.toString() == '20' || boost_badge_age.toString() == '21' || boost_badge_age.toString() == '22' || boost_badge_age.toString() == '23') { boost_badge = '<:space_classic:996835068851011584> <:space_boost_8:996836608907161670>' }
            if (boost_badge_age.toString() === '24' || boost_badge_age.toString() == '25') { boost_badge = '<:space_classic:996835068851011584> <:space_boost_9:996836680235495484>' }
            nitro = boost_badge
        }).catch();
    }
    else { nitro = "\`No Nitro\`" }
    return nitro
}