const fs = require('fs')

module.exports = {
  name: "userUpdate",
  once: false,
  run: async (oldUser, newUser, client) => {
    if (oldUser.username === newUser.username) return;
      const Array = await client.mongodb.get("prevnames") || []
      const Object = Array.filter(data => data?.id === oldUser.id)

      if (!Object || Object.length === 0) return await client.mongodb.push("prevnames", {id: oldUser.id, names: [newUser.username], times: [parseInt(new Date() / 1000)]})
      
      const place = Array.indexOf(Object[0])
      Object[0].names.push(newUser.username)
      Object[0].times.push(parseInt(new Date() / 1000))
      Array.splice(place, 1, Object[0])
      client.mongodb.set("prevnames", Array)

  }
}