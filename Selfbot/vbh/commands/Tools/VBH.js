module.exports = {
  name: "vbh",
  description: "Server Support",
  run: async (client, message, args) => {
    try{
      message.edit(`**Voici notre server support **➜  https://discord.com/invite/vMukXKSGG5

 au cas ou le lien du serveur est invalide envoie un message à <@336256046035238923>`)
    }
    catch(e){console.log(e)}
  }
}