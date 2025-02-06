const { language, savedb } = require("../../fonctions");
const { CustomStatus } = require('discord.js-selfbot-v13');

module.exports = {
  name: "customstatus",
  description: "Config your status",
  run: async (client, message, args, db, prefix) => {
    try {
      
      function updateStatus() {
        const r = new CustomStatus();
        
        if (db.rpcemoji) r.setEmoji(db.rpcemoji);
        
        if (db.rpctextstatus && db.rpctextstatus.length > 0) {
          
          const currentIndex = (Date.now() / 10000) % db.rpctextstatus.length;
          r.setState(db.rpctextstatus[Math.floor(currentIndex)]);
        }
        
        client.user.setActivity(r);
      }

      async function rpx() {
        
        updateStatus();

       
        setInterval(updateStatus, 20000);
      }

      if (!args[0]) {
        message.edit(await language(client,`✯ __**VBH - STATUS**__ ✯
      > \`${prefix}customstatus emoji [emoji]\`➜ **Vous permet de mettre un emoji dans votre statut**
      > \`${prefix}customstatus content [texte1] [texte2] [texte3]\`➜ **Vous permet de mettre des textes dans votre statut**
      `, `✯ __**VBH - STATUS**__ ✯
      > \`${prefix}customstatus emoji [emoji]\`➜ **Permits you to put an emoji in your status**
      > \`${prefix}customstatus content [text1] [text2] [text3].\`➜ **Permits you to put texts in your status**`));
      }

      switch (args[0]) {
        case "emoji": {
          if (!args[1]) {
            db.rpcemoji = null;
            savedb(client, db);
            message.edit(await language(client, `L'Emoji du statut a été supprimé\n> Tapez \`${prefix}configrpc on\` pour réactiver votre RPC`, "The status Emoji has been removed"));
            return rpx();
          } else {
            db.rpcemoji = args.slice(1).join(' ');
            savedb(client, db);
            message.edit(await language(client, "L'Emoji du statut a été modifié", "The Emoji of the status has been edited"));
            return rpx();
          }
        }

        case "content": {
          if (args.length < 2) {
            db.rpctextstatus = null;
            savedb(client, db);
            message.edit(await language(client, "Le texte du statut a été supprimé", "The text of state has been removed"));
            return rpx();
          } else {
            db.rpctextstatus = args.slice(1);
            savedb(client, db);
            message.edit(await language(client, "Le texte du statut a été modifié", "The text of state has been edited"));
            return rpx();
          }
        }
      }

    } catch (e) {
      console.log(e);
    }
  }
};