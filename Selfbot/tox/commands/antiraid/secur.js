const fs = require('fs')

module.exports = {
  name: "secur",
  descriptionfr: "Affiche la sécuritée du serveur",
  descriptionen: "Displays the server security",
  run: async (client, message, args) => {
    if (!args[0]) {
      const secur = `
\`antichannels\` ➜ **${client.db.antichannels === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiroles\` ➜ **${client.db.antiroles === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antibots\` ➜ **${client.db.antibots === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiwebhooks\` ➜ **${client.db.antiwebhooks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antipings\` ➜ **${client.db.antipings === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antikicks\` ➜ **${client.db.antikicks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antibans\` ➜ **${client.db.antibans === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiupdates\` ➜ **${client.db.antiupdates === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antilinks\` ➜ **${client.db.antilinks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiinvites\` ➜ **${client.db.antiinvites === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**`
      return message.edit(secur)
    }

    else if (args[0] === "on") {
      client.db.antichannels = true
      client.db.antiroles = true
      client.db.antibots = true
      client.db.antiwebhooks = true
      client.db.antipings = true
      client.db.antikicks = true
      client.db.antibans = true
      client.db.antiupdates = true
      client.db.antilinks = true
      client.db.antiinvites = true

      client.save()

      const secur = `
\`antichannels\` ➜ **${client.db.antichannels === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiroles\` ➜ **${client.db.antiroles === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antibots\` ➜ **${client.db.antibots === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiwebhooks\` ➜ **${client.db.antiwebhooks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antipings\` ➜ **${client.db.antipings === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antikicks\` ➜ **${client.db.antikicks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antibans\` ➜ **${client.db.antibans === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiupdates\` ➜ **${client.db.antiupdates === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antilinks\` ➜ **${client.db.antilinks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiinvites\` ➜ **${client.db.antiinvites === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**`
      return message.edit(secur)
    }

    if (args[0] === "off") {
      client.db.antichannels = false
      client.db.antiroles = false
      client.db.antibots = false
      client.db.antiwebhooks = false
      client.db.antipings = false
      client.db.antikicks = false
      client.db.antibans = false
      client.db.antiupdates = false
      client.db.antilinks = false
      client.db.antiinvites = false

      client.save()

      const secur = `
\`antichannels\` ➜ **${client.db.antichannels === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiroles\` ➜ **${client.db.antiroles === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antibots\` ➜ **${client.db.antibots === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiwebhooks\` ➜ **${client.db.antiwebhooks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antipings\` ➜ **${client.db.antipings === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antikicks\` ➜ **${client.db.antikicks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antibans\` ➜ **${client.db.antibans === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiupdates\` ➜ **${client.db.antiupdates === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antilinks\` ➜ **${client.db.antilinks === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**
\`antiinvites\` ➜ **${client.db.antiinvites === true ? client.trad("Enable", "Activé") : client.trad("Disable", "Désactivé")}**`
      return message.edit(secur)
    }
  }
}