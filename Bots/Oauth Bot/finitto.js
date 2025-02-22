const { ActivityType, PresenceUpdateStatus } = require("discord.js");

module.exports = {
  client: "",// aşağıda ki ve yukarıda ki ikisi de aynı
  client_id: "", // client id du ",
  client_secret:"",
  redirect_uri: "", //domain url veya vds ip
  footer: "@printsmoney", //Değiştirme
  support: "", //koymasan da olur
  owners: ["", "",""], //örnek ["owner_1_id", "owner_2_id"])
  token:"",
  webhooks:{
    general:"",
    join:""
  },
  durum: "Full security",
  type:ActivityType.Watching,
  status:PresenceUpdateStatus.DoNotDisturb,
}