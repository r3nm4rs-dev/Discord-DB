
module.exports = {
    name: "ping",
    aliases: ["latency"],
    usage: '',
    description: "Gives you information on how fast the Bot can respond to you",
    category: "Info",
    run: async(client, message) => {
        try {
            await message.edit(`API : \`${client.ws.ping}\` ms`)
        }catch(e) {
            console.log(e)
        }
    }
  }
  