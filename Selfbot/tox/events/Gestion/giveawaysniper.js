const fs = require('fs')

module.exports = {
  name: "messageCreate",
  run: async (message, client) => {
    if (client.db.giveawaysniper !== true) return;
    if(message.embeds.length > 0 && message.embeds[0].title && message.embeds[0].title.toLowerCase().includes("giveaway") || message.embeds.length > 0 && message.embeds[0].fields && message.embeds[0].fields.length > 0 && message.embeds[0].fields[0].name.toLowerCase().includes("giveaway")) {
     if (message.components.length > 0) try { message.clickButton() } catch { }
    } else if(message.components.length > 0 && message.components[0].components.filter(c => c.type === "BUTTON").length > 0 && message.components[0].components.find((x) => x.emoji?.name == "🎉")) {
      message.components[0].components.filter(c => c.type === "BUTTON").map(button => {
        if (button) message.clickButton(button)
      })
    }
  }
}