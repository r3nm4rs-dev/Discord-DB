const Discord = require('discord.js-selfbot-v13')

module.exports = {
    name: "configspotify",
    run: async(c, m, a) => {
        if(!c.db.spotify) c.db.spotify = {}
        if(a[0] === "details") {
            if(!a[1]) xx = ' '
            else xx = a.slice(1).join(' ')
            c.db.spotify.details = xx
            c.save(c, c.db);
            m.delete()
        }
        if(a[0] === "state") {
            if(!a[1]) xx = ' '
            else xx = a.slice(1).join(' ')
            c.db.spotify.state = xx
            c.save(c, c.db);
            m.delete()
        }
        if(a[0] === "album") {
            if(!a[1]) xx = ' '
            else xx = a.slice(1).join(' ')
            c.db.spotify.album = xx
            c.save(c, c.db);
            m.delete()
        }
        else if (a[0] === "timestamp") {
            if(!a[1]) xx = Date.now()
            else xx = a[1]
            c.db.spotify.timestamp = xx
            c.save(c, c.db);
            m.delete()
        }
        else if (a[0] === "largeimage"){
            if (!a[1]){
              c.db.spotify.largeimage = ""
              c.save(c, c.db)
              return m.delete()
            }
            a[1] = a[1]
             const getExtendURL = await Discord.RichPresence.getExternal(
              c,
              '1271941552897523743',
              a[1],
          )
            c.db.spotify.largeimage = getExtendURL[0].external_asset_path
            c.save(c, c.db)
            m.delete()
          }
          else if (a[0] === "smallimage"){
            if (!a[1]){
              c.db.spotify.smallimage = null
              c.save(c, c.db)
              return m.delete()
            }
            const getExtendURL = await Discord.RichPresence.getExternal(
              client,
              '1271941552897523743',
              a[1],
          )
            c.db.spotify.smallimage = getExtendURL[0].external_asset_path
            c.save(c, c.db)
            m.delete()
          }
          else if(a[0] === "platform") {
            if(!a[1] && a[1] !== 'ps5' && a[1] !== 'ps4' && a[1] !== 'samsung' && a[1] !== 'desktop') return m.edit(db.lang === 'fr' ? `***Vous devez choisir entre \`ps4\`, \`ps5\`, \`desktop\` ou \`samsung\`**.*` : `***You must choose between \`ps4\`, \`ps5\`, \`desktop\` or \`samsung\`**.*`)
            c.db.spotify.platform = a[1]
            c.save(c, c.db)
            m.delete()
            }
        else if (a[0] === "time") {

  
if(!a[1]) {
    c.db.rpc.time = null
    c.save(c, c.db)
    return
}
    if (isNaN(a[1]) || !["s", "m", "h", "d"].includes(a[2])) {

        return m.edit(db.lang === 'fr' ? 

            `***Vous devez fournir un nombre et une unité valide (\`s\`, \`m\`, \`h\`, \`d\`)**.*` :

            `***You must provide a valid number and unit (\`s\`, \`m\`, \`h\`, \`d\`)**.*`);

    }

    const number = parseInt(a[1], 10);

    const unit = a[2];

    let multiplier;

    switch (unit) {

        case 's': 

            multiplier = 1000;

            break;

        case 'm': 

            multiplier = 1000 * 60;

            break;

        case 'h': 

            multiplier = 1000 * 60 * 60;

            break;

        case 'd': 

            multiplier = 1000 * 60 * 60 * 24;

            break;

    }

    const timestamp = Date.now() + number * multiplier;

    db.rpc.time = timestamp;

    saveDb();

    m.delete();

}
    }
}