const discord = require("discord.js");
const finitto = require("../../finitto");

module.exports = {
  name: "help",
  description: "Bot hakkında bilgi verir",
  default_permission: true,
  category: "whitelist",
  userPerms: [discord.PermissionFlagsBits.SendMessages],
  ownerOnly: false,

  run: async (client, interaction, args) => {
    await interaction.reply({
      embeds: [
        new discord.EmbedBuilder()
          .setDescription(`
👦 ▹ **/users** - Shows the number and locations of users

🔄 ▹ **/refresh** - Refreshes the users in the database, deletes the ones that are not working

🧹 ▹ **/clean** - It cleans the database completely, more effective than refresh

🚀 ▹ **/join** - Enters as many auths as you used in the command

🪂 ▹ **/pull** - It is the same as the join command. It allows you to send to servers with just id

📈 ▹ **/ping** - Shows the bot's ping information

🟢 ▹ **/wl add** - You will whitelist the person who can use the commands

🔴 ▹ **/wl remove** - You can remove someone who is already on the whitelist with this command

🟡 ▹ **/wl list** - List who is on your whitelist

⛔ ▹ **/stop** - It pauses the member submission of the server id you entered`)
          .setColor(discord.Colors.Blue)
		  .setFooter({
            text: "Aslan",
          }),
      ],
      ephemeral: false,
    });
  },
};
