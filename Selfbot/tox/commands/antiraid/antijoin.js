const fs = require('fs')

module.exports = {
  name: "antijoin",
  descriptionfr: "Active ou désactive l'anti join",
  descriptionen: "Enable or disable the anti join",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad("Please use this command in a server", "Veuillez utiliser cette commande sur un serveur"))
    if (!message.guild.features.includes("COMMUNITY")) return message.edit(client.trad("You must have activated the community to use this command.", "Vous devez avoir activer la communauté pour utiliser cette commande"))
    if (!args[0] || args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("Missing parameter: `on` or `off`", "Paramètre manquant: `on` ou `off`"))

    function toggleFeature(feature, enable, reason) {
      this.features = message.guild.features
      const newFeatures = enable ?
        (this.features.includes(feature) ? this.features : [...this.features, feature]) :
        this.features.filter(name => name !== feature);
      return message.guild.edit({ features: newFeatures, reason });
    }
    
    if (args[0] === "on"){
      if (message.guild.features.includes("INVITES_DISABLED")) return message.edit(client.trad("Anti-raid is already active", "L'anti raid est déjà actif"))
      toggleFeature("INVITES_DISABLED", true)
      message.edit()
    }
    else{
      if (!message.guild.features.includes("INVITES_DISABLED")) return message.edit(client.trad("Anti-raid is not activated", "L'anti raid n'est pas activé"))
      toggleFeature("INVITES_DISABLED", false)
      message.edit(client.trad("Anti-raid has been disabled", "L'anti raid a été désactivé"))
    }
  }
}