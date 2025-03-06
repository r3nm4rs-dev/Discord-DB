const fs = require('fs')

module.exports = {
  name: "enablensfw",
  descriptionfr: "Aller dans des salons NSFW sans avoir l'âge requis",
  descriptionen: "Allows to go to NSFW channels without restrcited age",
  run: async (client, message, args) => {
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n\`\`\`js\nvar findModule=(item)=>window.webpackChunkdiscord_app.push([[Math.random()],{},(req)=>{for(const m of Object.keys(req.c).map((x)=>req.c[x].exports).filter((x)=>x)){if(m.default&&m.default[item]!==undefined)return m.default}}])\n    findModule('getCurrentUser').getCurrentUser().nsfwAllowed = true\`\`\``)
  }
}