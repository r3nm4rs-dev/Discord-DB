const Discord = require("discord.js-selfbot-v13");

let vanityState = {
  isMonitoring: false,
  originalVanityURL: ""
};

async function getVanityMonitoringState() {
  return vanityState;
}

async function setVanityMonitoringState(isMonitoring, originalVanityURL) {
  vanityState.isMonitoring = isMonitoring;
  if (originalVanityURL) {
    vanityState.originalVanityURL = originalVanityURL;
  }
}

async function startMonitoringVanityURL(guild, originalVanityURL) {
  const interval = setInterval(async () => {
    const state = await getVanityMonitoringState();
    if (!state.isMonitoring) {
      clearInterval(interval);
      return;
    }

    const currentVanityURL = (await guild.fetchVanityData()).code;
    if (currentVanityURL !== originalVanityURL) {
      try {
        await guild.setVanityCode(originalVanityURL);
        console.log(`L'URL à été rétablie : ${originalVanityURL}`);
      } catch (error) {
        console.error("Erreur lors de la tentative de rétablissement de l'URL :", error);
      }
    }
  }, 1000); 
}

module.exports = {
  name: "lockurl",
  description: "Active ou désactive la surveillance de l'URL de vanité du serveur.",
  run: async (client, message, args, db, prefix) => {
    if (!args.length || (args[0] !== "on" && args[0] !== "off")) {
      return message.edit(`\`🔗\` Ajouter \`on\` ou \`off\``);
    }

    const action = args[0];
    const state = await getVanityMonitoringState();
    const vanityURL = state.originalVanityURL || (await message.guild.fetchVanityData()).code;

    if (action === "on") {
      if (!state.isMonitoring) {
        await setVanityMonitoringState(true, vanityURL);
        startMonitoringVanityURL(message.guild, vanityURL);
        message.edit(`\`🔒\` **Lock url activée avec succès !**`);
      } else {
        message.edit(`\`🚨\` **Lock url est déjà activéé**`);
      }
    } else {
      await setVanityMonitoringState(false, vanityURL);
      message.edit(`\`🔓\` **Lock url désactivée avec succès**`);
    }
  }
};

