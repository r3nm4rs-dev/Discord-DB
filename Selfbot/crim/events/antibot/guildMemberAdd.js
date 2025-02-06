module.exports = {
    name: "guildMemberAdd.js",
    once: true,
    run: async (message, client) => {
 
  if (member.user.bot && db.antibots) {
    try {
 
      await member.ban({ reason: "Antibots activé - interdiction automatique des bots" });
      console.log(`Le bot ${member.user.tag} a été banni car l'antibots est activé.`);
    } catch (error) {
      console.error(`Erreur lors de la tentative de bannissement du bot ${member.user.tag}:`, error);
    }
  }
}}

