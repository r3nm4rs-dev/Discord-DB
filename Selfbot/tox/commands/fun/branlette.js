const fs = require('fs')

module.exports = {
  name: "branlette",
  descriptionfr: "La meilleure commande",
  descriptionen: "The best command",
  run: async (client, message, args) => {
    const sltcv = [
      "8=:fist:==D",
      "8==:fist:=D",
      "8===:fist:D",
      "8==:fist:=D",
      "8=:fist:==D",
      "8:fist:===D",
      "8=:fist:==D",
      "8==:fist:=D",
      "8===:fist:D",
      "8==:fist:=D:sweat_drops:",
      "8===:fist:D:sweat_drops:"
      ]
      
    sltcv.forEach(c => message.edit(c).catch(() => false))
  }
}