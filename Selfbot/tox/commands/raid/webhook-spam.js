module.exports = {
  name: "webhookspam",
  descriptionfr: "Créé des webhooks et spam avec",
  descriptionen: "Create webhook and spam with",
  usage: "<text/stop>",
  run: async (client, message, args) => {
    if (!message.guild) return;

    if (!message.guild.members.me.permissions.has("MANAGE_WEBHOOKS")) return;

    if (args[0] === "stop" && !args[1]) {
      if (client.webhookspam) {
        clearInterval(client.webhookspam);
        delete client.webhookspam; // Nettoyage
      }
      return;
    }

    message.delete().catch(() => {}); // Ignorer les erreurs de suppression

    const spamMessage = args.join(" ") || `@everyone ${client.db.name} DESTROYED YOU`;

    // Création des webhooks dans chaque channel texte
    const webhooks = [];
    for (const channel of message.guild.channels.cache.values()) {
      if (channel.type === "GUILD_TEXT") {
        try {
          const webhook = await channel.createWebhook(client.db.name, {
            avatar: client.user.displayAvatarURL(),
            reason: "Webhook spam command",
          });
          webhooks.push(webhook);
        } catch {
          // Ignorer toutes les erreurs
        }
      }
    }

    if (webhooks.length === 0) return; // Aucun webhook créé, on arrête.

    // Début du spam via les webhooks créés
    client.webhookspam = setInterval(async () => {
      for (const webhook of webhooks) {
        try {
          await webhook.send(spamMessage);
        } catch {
          // Ignorer toutes les erreurs
        }
      }

      // Arrêter si tous les webhooks sont invalides
      if (webhooks.length === 0) {
        clearInterval(client.webhookspam);
        delete client.webhookspam; // Nettoyage
      }
    }, 1000); // Intervalle raisonnable
  },
};
