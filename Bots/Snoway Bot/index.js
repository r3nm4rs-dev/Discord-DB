const Pluzio = require('./source/structures/client/index')
const client = new Pluzio() 
module.exports = client

process.on("uncaughtException", (e) => {
      if (e.code === 50013) return;
       if (e.code === 50001) return;
       if (e.code === 50035) return;
       if (e.code === 10062) return;
     
       console.log(e)
   })