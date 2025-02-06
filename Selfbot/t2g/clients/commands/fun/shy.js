module.exports = {
    name: "shy",
    description: "Send a love message",
    run: async (client, message, args, db) => {
      try{
          message.edit(":point_right:   :point_left:")
          await new Promise(resolve => setTimeout(resolve, 1500));   
          message.edit(":point_right:   :point_left:")
          await new Promise(resolve => setTimeout(resolve, 1500));   
          message.edit(":point_right:   :point_left:")
          await new Promise(resolve => setTimeout(resolve, 1500));   
          message.edit(":point_right:  :point_left:")
          await new Promise(resolve => setTimeout(resolve, 1500));   
          message.edit(`:point_right: :point_left:`)
          await new Promise(resolve => setTimeout(resolve, 1500));
          message.edit(`:point_right::point_left:`)
          }
          catch{}
      }
  }