const { language, savedb } = require("../../fonctions");
const fs = require('fs');

let autobumpInterval;

module.exports = {
    name: "bump",
    description: "Status of bump",
    run: async (client, message, args, db, prefix) => {
        if (!args[0] || (args[0] !== "on" && args[0] !== "off")) {
            return message.edit(await language(client, "Merci de fournir l'état souhaité de l'autobump (on/off).", "Please provide the desired state of autobump (on/off)."));
        }

        if (args[0] === "on") {
            const channelID = db.bumpchannel;
            if (!channelID) {
                return message.edit(await language(client, `Aucun salon défini (\`${prefix}setbump <salon>\`)`, `No channel defined (\`${prefix}setbump <channel>\`)`));
            }
            const channel = await client.channels.fetch(channelID);
            if (!channel) {
                return message.edit(await language(client, `Le salon défini avec l'ID "${channelID}" n'existe pas. Veuillez le vérifier et réessayer.`, `The channel defined with ID "${channelID}" does not exist. Please check it and try again.`));
            }
            if (db.autobump) {
                return message.edit(await language(client, "L'autobump est déjà activé.", "Autobump is already enabled."));
            }

            db.autobump = true;
            savedb(client, db);
            message.edit(await language(client, "L'autobump est maintenant activé dans le salon défini.", "Autobump is now enabled in the defined channel."));

            autobumpInterval = setInterval(() => {
                bump(channel);
            }, getRandomInterval());

            bump(channel);
        } else if (args[0] === "off") {
            const channelID = args[1];

            if (!channelID) {
                return message.edit(await language(client, `Merci de fournir l'ID du salon à utiliser pour désactiver l'autobump.`, `Please provide the channel ID to use for disabling autobump.`));
            }

            db.bumpchannel = channelID;
            savedb(client, db);

            message.edit(await language(client, `L'autobump est maintenant désactivé dans le salon défini sur ${channelID}.`, `Autobump is now disabled in the channel set to ${channelID}.`));

            clearInterval(autobumpInterval);
        }
    }
};