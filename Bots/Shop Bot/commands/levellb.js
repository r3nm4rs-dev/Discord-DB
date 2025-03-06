const { MessageEmbed } = require("discord.js");

module.exports.run = async (client, message, args) => {
  let data = client.db.all().filter(i => i.ID.startsWith("level_")).sort((a, b) => b.data - a.data);
  if (data.length < 1) return message.channel.send("No leaderboard");
  let myrank = data.map(m => m.ID).indexOf(`level_${message.author.id}`) + 1 || "N/A";
  data.length = 10;
  let lb = [];
  for (let i in data) {
    let id = data[i].ID.split("_")[1];
    let user = await client.users.fetch(id);
    user = user ? user.tag : "Unknown User#0000";
    let rank = data.indexOf(data[i]) + 1;
    let level = client.db.get(`level_${id}`);
    let xp = client.db.get(`xp_${id}`);
    let xpreq = Math.floor(Math.pow(level / 0.1, 2));
    lb.push({
      user: { id, tag: user },
      rank,
      level,
      xp,
      xpreq
    });
  };

  const embed = new MessageEmbed()
    .setTitle("Leaderboard")
    .setColor("#56089e")
  lb.forEach(d => {
    embed.addField(`${d.rank}. ${d.user.tag}`, `**Level** - ${d.level}\n**XP** - ${d.xp} / ${d.xpreq}`);
  });
  embed.setFooter(`Your Position: ${myrank}`);
  return message.channel.send({ embeds: [embed] }).then(msg => setTimeout(() => {
    msg.delete()
    message.delete()
  }, client.config.message_remove_time * 1000));
};