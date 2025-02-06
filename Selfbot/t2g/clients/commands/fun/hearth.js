module.exports = {
    name: "hearth",
    description: "Send a love message",
    run: async (client, message, args) => {
      try{
          message.edit("🖤❤️🖤")
          await new Promise(resolve => setTimeout(resolve, 1500))
          message.edit("❤️🖤❤️")
          await new Promise(resolve => setTimeout(resolve, 1500))
          message.edit("🖤❤️🖤")
          await new Promise(resolve => setTimeout(resolve, 1500))
          message.edit("❤️🖤❤️")
          await new Promise(resolve => setTimeout(resolve, 1500))
          message.edit("🖤❤️🖤")
          await new Promise(resolve => setTimeout(resolve, 1500))
          message.edit(`❤️🖤❤️`)
          }
          catch{}
      }
  }