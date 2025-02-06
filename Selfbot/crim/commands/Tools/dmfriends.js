const { language } = require("../../fonctions");

module.exports = {
  name: "dmfriends",
  description: "Send a message to all your friends",
  run: async (client, message, args, db, prefix) => {
    if (!args[0])
      return message.edit(
        `Veuillez entrer un message à envoyer`,
        `Please enter a message to send at your friends`
      );
    message.edit("> **Crim**");
    message.delete().catch(() => false);
    try {
      client.relationships.friendCache.map((friend) =>
        friend ? friend.send(args.slice(0).join(" ")) : ""
      );
    } catch (e) {}
  },
};
