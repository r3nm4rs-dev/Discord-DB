const anticrashHandler = (bot) => {
  // Capture les exceptions non capturées
  process.on("uncaughtExceptionMonitor", (err, origin) => {
    console.error("uncaughtExceptionMonitor - Erreur capturée:", err);
    console.error("Origine:", origin);
  });

  process.on("uncaughtException", (error) => {
    console.error("uncaughtException - Une erreur non-capturée est survenue:", error);
  });

  // Capture les promesses rejetées non traitées
  process.on("unhandledRejection", (reason, promise) => {
    console.error("unhandledRejection - Une erreur asynchrone non-capturée est survenue:", reason);
    console.error("Promise:", promise);
    if (reason.code === 10062) return; // Exemple d'exception d'une erreur spécifique
  });

  process.on("rejectionHandled", (promise) => {
    console.error("rejectionHandled - Une promesse rejetée a été traitée:", promise);
  });

  // Capture les avertissements
  process.on("warning", (warning) => {
    console.warn("warning - Avertissement:", warning);
  });

  // Capture les erreurs spécifiques au bot
  bot.on("error", (error) => {
    console.error("bot.error - Une erreur du bot est survenue:", error);
  });

  // Ajout d'autres erreurs potentielles (fictives et expérimentales)
  process.on("SIGINT", () => {
    console.error("SIGINT - Signal d'interruption reçu.");
  });

  process.on("SIGTERM", () => {
    console.error("SIGTERM - Signal de terminaison reçu.");
  });

  process.on("multipleResolves", (type, promise, reason) => {
    console.error("multipleResolves - Résolution multiple détectée:", { type, promise, reason });
  });

  process.on("processTicksAndRejections", (request, reason) => {
    console.error("processTicksAndRejections - Erreur réseau ou autre non-capturée:", reason);
  });

  process.on("exit", (code) => {
    console.error(`exit - Processus terminé avec le code ${code}`);
  });

  // Simuler une erreur à l'intérieur du bot pour tester la robustesse
  bot.on("ready", () => {
    console.error("bot.ready - Simulation d'une erreur volontaire lors du démarrage.");
    throw new Error("Erreur simulée dans l'événement bot.ready");
  });
};

module.exports = anticrashHandler;
