const fs = require('fs')

module.exports = {
  name: "patate",
  descriptionfr: "PATATE DANS TA MERE",
  descriptionen: "PATATE IN YOUR MOM",
  run: async (client, message, args) => {
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n**${client.trad("Potato in your mother PAAHHH", "Patate dans ta mère PAAHHH")}**\n\nhttps://cdn.discordapp.com/attachments/603949531700396032/603956469083144212/gdeadcamdr.gif`)
  }
}