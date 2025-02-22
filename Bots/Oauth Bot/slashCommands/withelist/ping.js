const discord = require("discord.js");

module.exports = {
  name: "ping",
  description: "Ping",
  default_permission: true,
  category: "whitelist",
  userPerms: [discord.PermissionFlagsBits.SendMessages],
  ownerOnly: false,

  run: async (client, int, args) => {
    await int.reply({
      embeds: [
        new discord.EmbedBuilder()
          .setDescription(`**Pingim:** ${client.ws.ping}**ms**`)
          .setFooter({
            text: "Aslan",
          }),
      ],
      ephemeral: false,
    });
  },
};
