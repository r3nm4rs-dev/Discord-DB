const Discord = require("discord.js");
const SlashCommands = require("../Handlers/slashCommands");
const config = require("../config");
const { ActivityType } = require("discord.js");

module.exports = async bot => {
    await SlashCommands(bot);

    // Fonction pour obtenir le nombre de tokens depuis la config
    function getNumberOfTokens() {
        return Object.values(config.user).length;
    }

    function generateRandomStatus() {
        const numTokens = getNumberOfTokens();
        const statuses = [`Manager〃Pluzio`, `〃${numTokens} Users`];
        const randomIndex = Math.floor(Math.random() * statuses.length);
        return statuses[randomIndex];
    }

    console.log(`${bot.user.tag} is connected to Discord !`);
    console.log(`> [INVITE]: https://discord.com/api/oauth2/authorize?client_id=${bot.user.id}&permissions=8&scope=bot%20applications.commands`);
    bot.user.setStatus('online');

    // Mettre à jour l'activité à chaque intervalle
    setInterval(() => {
        bot.user.setActivity(generateRandomStatus(), {
            type: ActivityType.Streaming,
            url: "https://twitch.tv/r3nm4rss",
        });
    }, 20000);
};
