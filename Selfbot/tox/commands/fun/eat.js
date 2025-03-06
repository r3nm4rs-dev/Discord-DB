const fs = require('fs')

module.exports = {
  name: "eat",
  descriptionfr: "Mange quelqu'un",
  descriptionen: "Eat someone",
  run: async (client, message, args) => {
    const eat = ["https://file1.topsante.com/var/topsante/storage/images/nutrition-et-recettes/equilibre-alimentaire/conseils-dietetiques/mon-ado-mange-n-importe-comment-que-faire/98388-2-fre-FR/Mon-ado-mange-n-importe-comment-que-faire.jpg", "https://www.canalvie.com/polopoly_fs/1.9240224.1558122803!/image/b%C3%A9b%C3%A9%20mange%20trop.jpg_gen/derivatives/cvlandscape_670_377/b%C3%A9b%C3%A9%20mange%20trop.jpg", "https://thumbs.gfycat.com/BeautifulGargantuanAustraliancurlew-size_restricted.gif", "https://media1.tenor.com/images/26a2a9c2d504544ecafa884d88079886/tenor.gif"]
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n${message.author.username} **${client.trad("eat", "Mange")}**\n\n${eat[Math.floor(Math.random() * eat.length)]}`)
  }
}