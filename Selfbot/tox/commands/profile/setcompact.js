const fs = require('fs')

module.exports = {
  name: "setcompact",
  descriptionfr: "Active ou désactive le mode compact",
  descriptionen: "Activates or deactivates compact mode",
  premium: true,
  invisible: true,
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("Missing parameter: `on` or `off`", "Paramètre manquant: `on` ou `off`"))
    client.settings.setDisplayCompactMode(args[0] === "on" ? true : false)
    message.edit(client.trad(
      `The compact mode has been ${args[0] === "on" ? "enable" : "disable"}`,
      `Le mode compacte a été ${args[0] === "on" ? "activé" : "désactivé"}`,
    ))
  }
}