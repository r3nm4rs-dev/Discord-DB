const { language } = require("../../fonctions");
const fs = require('fs');

module.exports = {
  name: "userinfo",
  description: "Display the info of a user",
  run: async (client, message, args) => {
    try {
      let user = message.mentions.users.first() || client.users.cache.get(args[0]);
      if (!user) {
        try {
          user = await client.users.fetch(args[0]);
        } catch (e) {
          user = message.author;
        }
      }

      const dbFilePath = `./db/${client.user.id}.json`;
      const db = JSON.parse(fs.readFileSync(dbFilePath));
      const botName = db.botname || "Pluzio V2";

      message.edit(await language(client, `♡**${botName} - Userinfo**♡
> Tag: ${user.username} 
> User ID: ${user.id} 
> Date de création: <t:${Math.round(user.createdTimestamp / 1000)}> <t:${Math.round(user.createdTimestamp / 1000)}:R> 
> Jours depuis la création: ${Math.floor((Date.now() - user.createdTimestamp) / (1000 * 60 * 60 * 24))}
> Photo de profil: ${user.avatar ? user.displayAvatarURL({ format: 'png', dynamic: true, size: 1024 }) : "Pas de photo de profil"}
> Bannière: ${user.banner ? user.bannerURL({ format: 'png', dynamic: true, size: 4096 }) : "Pas de bannière"}`,
        `♡**${botName} - Userinfo**♡
> Tag: ${user.username} 
> User ID: ${user.id} 
> Creation date: <t:${Math.round(user.createdTimestamp / 1000)}> <t:${Math.round(user.createdTimestamp / 1000)}:R>
> Days since the creation: ${Math.floor((Date.now() - user.createdTimestamp) / (1000 * 60 * 60 * 24))}
> Pfp: ${user.avatar ? user.displayAvatarURL({ format: 'png', dynamic: true, size: 1024 }) : "No pfp"}
> Banner: ${user.banner ? user.bannerURL({ format: 'png', dynamic: true, size: 4096 }) : "No banner"}`));
    } catch (e) {
      console.error(e);
    }
  }
};
