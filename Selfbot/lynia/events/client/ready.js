const Discord = require('discord.js-selfbot-v13');
const fs = require('fs');
const { CustomStatus, RichPresence, SpotifyRPC } = require('discord.js-selfbot-v13');
const chalk = require('chalk');

module.exports = {
  name: 'ready',
  once: true,
  run: async (client) => {
    try {
      console.log(chalk.green(`${client.user.tag} `) + chalk.blue('connected to selfbot ') + chalk.yellow('✔️'));

      // Ensure user data file exists
      while (!fs.existsSync(`./db/${client.user.id}.json`)) {
        fs.writeFileSync(`./db/${client.user.id}.json`, fs.readFileSync("./db/exemple.json"));
      }

      const db = require(`../../db/${client.user.id}.json`);

      // Spotify configuration
      if (db.spotifyonoff === true || db.spotifyonoff === 'on') {
        const r_ = new CustomStatus(client);
        if (db.rpcemoji) r_.setEmoji(db.rpcemoji);
        if (db.rpctextstatus) r_.setState(db.rpctextstatus);

        const r = new SpotifyRPC(client);
        if (db.spotifylargeimage) r.setAssetsLargeImage(db.spotifylargeimage);
        if (db.spotifysmallimage) r.setAssetsSmallImage(db.spotifysmallimage);
        if (db.spotifystates) r.setState(db.spotifystates);
        if (db.spotifydetails) r.setDetails(db.spotifydetails);
        r.setStartTimestamp(Date.now());
        r.setEndTimestamp(Date.now() + (db.spotifyendtimestamp || 1000 * (2 * 60 + 56)));

        client.user.setActivity(r, r_);
      }

      // Custom Status settings
      if (db.rpcemoji || db.rpctextstatus) {
        const r_ = new CustomStatus(client);
        if (db.rpcemoji) r_.setEmoji(db.rpcemoji);
        if (db.rpctextstatus) r_.setState(db.rpctextstatus);
        client.user.setActivity(r_);
      }

      // Rich Presence settings
      if (db.rpconoff === true || db.rpconoff === 'on') {
        const r_ = new CustomStatus(client);
        if (db.rpcemoji) r_.setEmoji(db.rpcemoji);
        if (db.rpctextstatus) r_.setState(db.rpctextstatus);

        const r = new RichPresence(client);
        if (db.rpctitle) r.setName(db.rpctitle);
        if (db.appid) r.setApplicationId(db.appid);
        if (db.rpcdetails) r.setDetails(db.rpcdetails);
        if (db.rpcstate) r.setState(db.rpcstate);
        if (db.rpctype) r.setType(db.rpctype);
        if (db.rpctype === 'STREAMING') r.setURL(db.twitch);
        if (db.rpcminparty !== 0 && db.rpcmaxparty !== 0) r.setParty({ max: db.rpcmaxparty, current: db.rpcminparty });
        if (db.rpctime) r.setStartTimestamp(db.rpctime);

        if (db.rpclargeimage) r.setAssetsLargeImage(db.rpclargeimage);
        if (db.rpclargeimagetext) r.setAssetsLargeText(db.rpclargeimagetext);
        if (db.rpcsmallimage) r.setAssetsSmallImage(db.rpcsmallimage);
        if (db.rpcsmallimagetext) r.setAssetsSmallText(db.rpcsmallimagetext);

        const userPlatform = db.rpcplatform || 'desktop';
        r.setPlatform(userPlatform);

        if (db.buttontext1 && db.buttonlink1) r.addButton(db.buttontext1, db.buttonlink1);
        if (db.buttontext2 && db.buttonlink2) r.addButton(db.buttontext2, db.buttonlink2);

        try {
          client.user.setActivity(r, r_);
        } catch (error) {
          console.error(chalk.red('Erreur lors de l\'application du RPC:'), error);
        }
      }

      // Voice connection logic using refreshVoice
      if (db.voiceconnect) {
        try {
          await client.refreshVoice(db.voiceconnect);
          
          // Mute the user if enabled
          if (db.voicemute) {
            await client.guilds.cache.get(db.guildId)?.members.me.edit({ mute: true });
            console.log(chalk.yellow('Utilisateur mis en mute lors de la connexion au salon vocal'));
          }
        } catch (error) {
          console.error(chalk.red('Erreur lors de la tentative de rejoindre le salon vocal:'), error);
        }
      }

      // Stream video if enabled
      if (db.voicestream) {
        const { DiscordStreamClient } = await import("discord-stream-client");
        const StreamClient = new DiscordStreamClient(client);

        try {
          let voiceConnection = await StreamClient.joinVoiceChannel(
            client.channels.cache.get(db.voiceconnect),
            {
              selfDeaf: db.voicedeaf,
              selfMute: db.voicemute,
              selfVideo: db.voicewebcam
            }
          );
        } catch (error) {
          console.error(chalk.red('Erreur lors de la tentative de streaming vidéo:'), error);
        }
      }

    } catch (e) {
      console.log(chalk.red(e));
    }
  },
};
