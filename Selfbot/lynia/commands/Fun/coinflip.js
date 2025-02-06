const Discord = require("discord.js-selfbot-v13");

module.exports = {
    name: "coinflip",
    description: "Lance une pièce pour jouer à pile ou face",
    run: async (client, message, args) => {
        
        if (!args.length || (args[0].toLowerCase() !== 'pile' && args[0].toLowerCase() !== 'face')) {
            return message.edit(`Veuillez choisir entre \`pile\` ou \`face\`.`);
        }

        const userChoice = args[0].toLowerCase();
        const choices = ['pile', 'face'];
        const botChoice = choices[Math.floor(Math.random() * choices.length)]; 

        const resultMessage = userChoice === botChoice ? 'Vous avez gagné !' : 'Vous avez perdu !';
        
        
        message.edit(`🪙 Vous avez choisi \`${userChoice}\`. Le résultat est **${botChoice}**. ${resultMessage}`);
    },
};
