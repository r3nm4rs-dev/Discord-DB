const config = require('./config.json');

const Manager = require("./manager/index.js")
const manager = new Manager()
manager.connect(config.managertoken)

const tokenToID = string => {return Buffer.from(string.split('.')[0], "base64").toString('utf-8')}
const clients = [];
for (const token of config.tokens) {
    //const db = require(`./clients/database/${tokenToID(token)}.json`)
    const Client = require('./clients/structure.js')
    const example = new Client({ws: {properties: {os: "Windows", browser: `Discord Client`}}})
    example.connect(token);
    clients.push(example);
}

manager.setClients(clients)

process.on("unhandledRejection", (reason, p) => {
  if (reason.code === 0) return;
  if (reason.code === 400) return; 
  if (reason.code == 10062) return; 
  if (reason.code == 10008) return; 
  if (reason.code === 50035) return; 
  if (reason.code === 40032) return;  
  if (reason.code ==  50013) return;
  if (reason.message.includes("GUILD_VOICE")) return;
    if (reason.message.includes("CAPTCHA_SOLVER_NOT_IMPLEMENTED")) return;
  if (reason.message.includes("Temp env not set")) return; 
  if (reason.message.includes('no such file or director')) return;
  if (reason.message.includes("getaddrinfo ENOTFOUND null")) return;
    console.log(reason, p);
});
process.on("uncaughtException", (err) => {
    console.log(`[ERROR]: ${err}`)
})