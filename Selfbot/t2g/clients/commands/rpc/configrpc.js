const Discord = require('discord.js-selfbot-v13');

module.exports = {
    name: "configrpc",
    run: async (c, m, a) => {
        const db = c.db;

        const saveDb = () => c.save(c, db);

        if(a[0] === "type") {
            if (!a[1] || !["playing", "watching", "listening", "competing", "streaming"].includes(a[1])) {
                return m.edit(db.lang === "fr" ? "***Vous devez choisir entre `competing`, `streaming`, `listening`, `playing` ou `watching`***" : "***Please choose a type between `competing`, `streaming`, `listening`, `playing` or `watching`***");
            }
            db.rpc.type = a[1].toUpperCase();
            saveDb();
            m.delete();
        }
        else if(a[0] === "name") {
            db.rpc.name = a.slice(1).join(' ');
            saveDb();
            m.delete();
        }
        else if(a[0] === "details") {
            db.rpc.details = a.slice(1).join(' ');
            saveDb();
            m.delete();
        }
        else if(a[0] === "state") {
            db.rpc.state = a.slice(1).join(' ');
            saveDb();
            m.delete();
        }
        else if (a[0] === "largeimage") {
            if (!a[1]) {
                db.rpc.largeimage = "";
                saveDb();
                return m.delete();
            }
            const getExtendURL = await Discord.RichPresence.getExternal(
                c,
                '1145327370472009869',
                a[1],
            );
            db.rpc.largeimage = getExtendURL[0].external_asset_path;
            if (a[2]) {
                db.rpc.largeimagetext = a.slice(2).join(' ');
            }
            saveDb();
            m.delete();
        } 
        else if (a[0] === "smallimage") {
            if (!a[1]) {
                db.rpc.smallimage = "";
                saveDb();
                return m.delete();
            }
            const getExtendURL = await Discord.RichPresence.getExternal(
                c,
                '1145327370472009869',
                a[1],
            );
            db.rpc.smallimage = getExtendURL[0].external_asset_path;
            if (a[2]) {
                db.rpc.smallimagetext = a.slice(2).join(' ');
            }
            saveDb();
            m.delete();
        } 
        else if (a[0] === "appid") {
            db.rpc.appid = a[1] || "";
            saveDb();
        }
        else if (a[0] === "button") {
            if (!["1", "2"].includes(a[1])) {
                return m.edit(db.lang === 'fr' ? `***Vous devez choisir entre \`1\` ou \`2\`**.*` : `***You must choose between \`1\` or \`2\`**.*`);
            }
            if (!a[2] || !a[2].startsWith('https://')) {
                return m.edit(db.lang === 'fr' ? `***Vous devez fournir un lien valide**.*` : `***You must provide a valid link**.*`);
            }
            db.rpc[`buttontext${a[1]}`] = a[3] || '';
            db.rpc[`buttonlink${a[1]}`] = a[2];
            saveDb();
            m.delete();
        }
        else if(a[0] === "platform") {
            if(!["ps5", "ps4", "samsung", "desktop"].includes(a[1])) {
                return m.edit(db.lang === 'fr' ? `***Vous devez choisir entre \`ps4\`, \`ps5\`, \`desktop\` ou \`samsung\`**.*` : `***You must choose between \`ps4\`, \`ps5\`, \`desktop\` or \`samsung\`**.*`);
            }
            db.rpc.platform = a[1];
            saveDb();
            m.delete();
        }
        else if (a[0] === "time") {

  
if(!a[1]) {
    c.db.rpc.time = null
    c.save(c, c.db)
    m.delete()
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
