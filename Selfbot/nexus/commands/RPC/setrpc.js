const fs = require('fs');
const path = require('path');
const { RichPresence } = require('discord.js-selfbot-v13');

const config = require('/home/container/config.json');

module.exports = {
  name: "setrpc",
  description: "Gère les paramètres du RPC",
  usage: "<commande> <valeur>",
  run: async (client, message, args) => {
    const userId = message.author.id;
    const dbPath = path.join('/home/container/db/', `${userId}.json`);

    if (!fs.existsSync(dbPath)) {
      return message.edit("La base de données de l'utilisateur n'existe pas.");
    }

    const db = JSON.parse(fs.readFileSync(dbPath, 'utf8'));
    const command = args[0];

    switch (command) {
      case "vsc":
        db.rpctitle = "Visual Studio Code";
        db.rpcdetails = "Editing index.js";
        db.rpcstate = "Workspace: .gg/pluzio";
        db.rpctype = "PLAYING";
        db.rpclargeimage = "https://cdn.discordapp.com/app-assets/383226320970055681/808841241142755358.png?size=160";  // Nom de l'image large
        db.rpclargeimagetext = "Editing a JAVASCRIPT file";
        db.rpcsmallimage = "https://cdn.discordapp.com/app-assets/383226320970055681/565945770067623946.png?size=160";  // Nom de l'image petite à configurer
        db.rpcsmallimagetext = "Visual Studio Code";
		db.rpctime = Date.now(); 
        break;

      case "valorant":
        db.rpctitle = "VALORANT";
        db.rpcdetails = "";
        db.rpcstate = "";
        db.rpctype = "PLAYING";
        db.rpclargeimage = ""; 
        db.rpclargeimagetext = "";
        db.rpcsmallimage = "https://cdn.discordapp.com/icons/679875946597056683/ef0122687f7a29f264564c52adc273e0.webp";
        db.rpcsmallimagetext = "";
		db.rpctime = Date.now(); 
        break;

      case "roblox":
        db.rpctitle = "Roblox";
        db.rpcdetails = "";
        db.rpcstate = "";
        db.rpctype = "PLAYING";
        db.rpclargeimage = ""; 
        db.rpclargeimagetext = "";
        db.rpcsmallimage = "https://cdn.discordapp.com/app-icons/363445589247131668/f2b60e350a2097289b3b0b877495e55f.webp?size=240&keep_aspect_ratio=false"; 	             db.rpcsmallimagetext = "";
		db.rpctime = Date.now(); 
        break;

      case "fortnite":
        db.rpctitle = "Fortnite";
        db.rpcdetails = "Battle Royale - In Lobby";
        db.rpcstate = "";
        db.rpctype = "PLAYING";
        db.rpclargeimage = "https://cdn.discordapp.com/app-assets/432980957394370572/1169923443119116288.png?size=160"; 
        db.rpclargeimagetext = "";
        db.rpcsmallimage = "https://cdn.discordapp.com/app-assets/432980957394370572/443231156620754945.png?size=160"; 	             
        db.rpcsmallimagetext = "Level 322";
		db.rpctime = Date.now(); 
        break;

      case "cod":
        db.rpctitle = "Call of Duty®: MWIII";
        db.rpcdetails = "Waiting for mission";
        db.rpcstate = "";
        db.rpctype = "PLAYING";
        db.rpclargeimage = "https://media.discordapp.net/app-assets/1149118246826561609/1149445585217265714.png?size=160"; 
        db.rpclargeimagetext = "";
        db.rpcsmallimage = "https://media.discordapp.net/app-assets/1149118246826561609/1179160097352593500.png?size=160"; 	             
        db.rpcsmallimagetext = "Niveau du Passe de combat 72";
		db.rpctime = Date.now(); 
        break;

      case "fivem":
        db.rpctitle = "FiveM";
        db.rpcdetails = "Dans le menus";
        db.rpcstate = "";
        db.rpctype = "PLAYING";
        db.rpclargeimage = "https://cdn.discordapp.com/app-assets/382624125287399424/848636446137909298.png?size=160"; 
        db.rpclargeimagetext = "";
        db.rpcsmallimage = ""; 	             
        db.rpcsmallimagetext = "";
		db.rpctime = Date.now(); 
        break;

      case "minecraft":
        db.rpctitle = "Minecraft";
        db.rpcdetails = "";
        db.rpcstate = "";
        db.rpctype = "PLAYING";
        db.rpclargeimage = ""; 
        db.rpclargeimagetext = "";
        db.rpcsmallimage = "https://cdn.discordapp.com/app-icons/356875570916753438/166fbad351ecdd02d11a3b464748f66b.webp?size=240&keep_aspect_ratio=false";
        db.rpcsmallimagetext = "Minecraft";
		db.rpctime = Date.now(); 
        break;

      case "platform":
        if (!config.premiumUsers.includes(userId)) {
          return message.edit("Vous devez être un utilisateur premium pour définir une plateforme.");
        }

        const platforms = ["ps4", "ps5", "xbox", "desktop"];
        if (!args[1] || !platforms.includes(args[1].toLowerCase())) {
          return message.edit(`Plateforme invalide. Options valides : ${platforms.join(', ')}`);
        }
        db.rpcplatform = args[1].toLowerCase();
        break;

      case "bouton1":
        db.buttontext1 = args.slice(1).join(' ') || null;
        break;

      case "bouton1link":
        db.buttonlink1 = args.slice(1).join(' ') || null; 
        break;

      case "bouton2":
        db.buttontext2 = args.slice(1).join(' ') || null;
        break;

      case "bouton2link":
        db.buttonlink2 = args.slice(1).join(' ') || null; 
        break;

      case "smallimage":
  		const smallImageUrl = args[1];
  		if (!smallImageUrl || !/^https?:\/\/.*\.(jpg|jpeg|png|gif)$/i.test(smallImageUrl)) {
    		return message.edit("URL de l'image invalide.");
  }
  		db.rpcsmallimage = smallImageUrl;
  		break;

	  case "largeimage":
  		const largeImageUrl = args[1];
  		if (!largeImageUrl || !/^https?:\/\/.*\.(jpg|jpeg|png|gif)$/i.test(largeImageUrl)) {
    		return message.edit("URL de l'image invalide.");
  }
  		db.rpclargeimage = largeImageUrl;
  		break;

      case "details":
        db.rpcdetails = args.slice(1).join(' ') || null;
        break;

      case "state":
        db.rpcstate = args.slice(1).join(' ') || null;
        break;

      case "type":
        const validTypes = ["STREAMING", "PLAYING", "COMPETING", "WATCHING", "LISTENING"];
        if (!args[1]) {
          db.rpctype = null;
        } else if (!validTypes.includes(args[1].toUpperCase())) {
          return message.edit("Type invalide. Options valides : " + validTypes.join(', '));
        } else {
          db.rpctype = args[1].toUpperCase();
        }
        break;

      case "title":
        db.rpctitle = args.slice(1).join(' ') || null;
        break;

      case "smallimagetexte":
        db.rpcsmallimagetext = args.slice(1).join(' ') || null;
        break;

      case "largeimagetexte":
        db.rpclargeimagetext = args.slice(1).join(' ') || null;
        break;

      case "timerpc":
        if (args[1]) {
          const timeString = args[1].toLowerCase();
          const timeMatch = timeString.match(/^(\d+)([smhdjw])$/);
          if (timeMatch) {
            const value = parseInt(timeMatch[1]);
            const unit = timeMatch[2];

            let milliseconds;
            switch (unit) {
              case 's': milliseconds = value * 1000; break;
              case 'm': milliseconds = value * 60 * 1000; break;
              case 'h': milliseconds = value * 60 * 60 * 1000; break;
              case 'd': milliseconds = value * 24 * 60 * 60 * 1000; break;
              case 'w': milliseconds = value * 7 * 24 * 60 * 60 * 1000; break;
              case 'j': milliseconds = value * 30 * 24 * 60 * 60 * 1000; break;
            }
            db.rpctime = Date.now() - milliseconds;
          } else {
            return message.edit("Format de temps invalide. Utilisez un format comme '1d' pour 1 jour.");
          }
        } else {
          db.rpctime = Date.now();
        }
        break;

      default:
        return message.edit("Commande invalide. Vérifiez votre syntaxe.");
    }

    fs.writeFileSync(dbPath, JSON.stringify(db, null, 2));
    updateRPC(client, db);
    message.edit(`Paramètre ${command} mis à jour avec succès.`);
  }
};

const updateRPC = (client, db) => {
  const r = new RichPresence(client);

  if (db.rpctitle) r.setName(db.rpctitle);
  if (db.rpcdetails) r.setDetails(db.rpcdetails);
  if (db.rpcstate) r.setState(db.rpcstate);
  if (db.rpctype) r.setType(db.rpctype);
  if (db.rpctime) r.setStartTimestamp(db.rpctime);

  if (db.rpcsmallimage) r.setAssetsSmallImage(db.rpcsmallimage);
  if (db.rpcsmallimagetext) r.setAssetsSmallText(db.rpcsmallimagetext);
  
  if (db.rpclargeimage) r.setAssetsLargeImage(db.rpclargeimage);
  if (db.rpclargeimagetext) r.setAssetsLargeText(db.rpclargeimagetext);

  if (db.rpcplatform) r.setPlatform(db.rpcplatform);

  if (db.buttontext1 && db.buttonlink1) r.addButton(db.buttontext1, db.buttonlink1);
  if (db.buttontext2 && db.buttonlink2) r.addButton(db.buttontext2, db.buttonlink2);

  client.user.setActivity(r);
};