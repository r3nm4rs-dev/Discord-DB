const { ActivityType, PresenceUpdateStatus } = require("discord.js");

module.exports = {
  client: "", // I think it the oauth url
  client_id: "", // bot id,
  client_secret:"", // bot secret from oauth page
  redirect_uri: "", // domain of vps without http ( example : 23.446.34:4402)
  footer: "@pluzio", // footer for all embeds
  support: "", // support server url
  owners: ["", "",""], // id of the owners
  token:"", // bot token
  webhooks:{
    general:"", // webhook for general logs
    join:"" // webhook for new users
  },
  durum: "Full security", // bot activity
  type:ActivityType.Watching,
  status:PresenceUpdateStatus.DoNotDisturb,
}