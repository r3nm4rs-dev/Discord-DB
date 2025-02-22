const { EmbedBuilder, codeBlock } = require("@discordjs/builders");
const { Colors, PermissionFlagsBits,ApplicationCommandOptionType, } = require("discord.js");
const { userdb, stopList } = require("../..");

async function sleep(ms) {
  return new Promise((resolve) => setTimeout(resolve, ms));
}
module.exports = {
  name: "joinall",
  description: "Tüm kullanıcıları sunucuya girdirir.",
  options: [
    {
      name: "interval",
      type: ApplicationCommandOptionType.Integer,
      description:"5 üyede bir kac saniye dursun. (ms cinsinden)",
      required: true,
    },
  ],
  default_permission: true,
  category: "whitelist",
  userPerms: [PermissionFlagsBits.SendMessages],
  ownerOnly: true,

  run: async (client, interaction, args) => {
    // const row = new discord.MessageActionRow().addComponents(new discord.MessageButton().setLabel("Stop").setStyle("DANGER").setCustomId("stop"))
    const data = await userdb.find();
    const zamans = interaction.options.getInteger("interval");
    if(zamans > 15000) return;
if(zamans <2999) return;
const sleeps = milliseconds => {
  return new Promise(resolve => setTimeout(resolve, milliseconds));
}
    let error = 0;
    let success = 0;
    let already_joined = 0;
    let server_limit = 0;
    let canceled = false;
    interaction.reply({ content: "Process started." });
    let msg = await interaction.channel.send(
      `**Users...** \`0\`/\`${data.length}\``
    );
    const inter = setInterval(async () => {
      const embed = new EmbedBuilder()
        .setAuthor({name:"In Progress.."})
        .setColor(Colors.Yellow)
        .setFooter({
          text:"Aslan"
        })
        .addFields([
          {
            name: "`👨‍👨‍👦` Total Users",
            value: codeBlock(data.length.toString()),
            inline: true,
          },
          {
            name: "`🚀` Success",
            value: codeBlock(success.toString()),
            inline: true,
          },
          {
            name: "`🎭` Already on Server",
            value: codeBlock(already_joined.toString()),
            inline: true,
          },
          {
            name:"`🌕` Server Limit",
            value:codeBlock(server_limit.toString()),
            inline:true
          },
          {
            name: "`❌` Error",
            value: codeBlock(error.toString()),
            inline: true,
          },
        ]);
      msg.edit({ embeds: [embed],content:"" });
    }, 1000);

    for (const i of data) {
      const user = await client.users.fetch(i.userId).catch(() => {});
      if (stopList.has(interaction.guild.id)) {
        stopList.delete(interaction.guild.id)
        canceled = true
        break
      }
      if (interaction.guild.members.cache.get(i.userId)) {
        already_joined++;
        console.log(`✔️ ${i.username}`);
      } else {
        await interaction.guild.members
          .add(user, { accessToken: i.accessToken })
          .then(async()=> {
            
            success++;
            let modalma = success%5
           
				
            if(modalma === 0){
             await sleeps(zamans)
			    console.log(`${zamans} kadar bekliyom`)
            }
            console.log(`✔️ ${user.tag}`);
          })
          .catch((e) => {
            if (e.code ==30001) {
              server_limit++;
            }
            else {
            error++;
          }
            console.log(`❌ ${i.username}`,e);
          });
      }
    }
    await clearInterval(inter);
    const embed = new EmbedBuilder().setAuthor({name:canceled ? "Canceled" : "Done!"})
      .setColor(canceled ? Colors.Red :Colors.Green)
      .setFooter({
        text:"Aslan"
      })
      .addFields([
        {
          name: "`👨‍👨‍👦` Total Users",
          value: codeBlock(data.length.toString()),
          inline: true,
        },
        {
          name: "`🚀`Success",
          value: codeBlock(success.toString()),
          inline: true,
        },
        {
          name: "`🎭` Already on Server",
          value: codeBlock(already_joined.toString()),
          inline: true,
        },
        {
          name:"`🌕` Server Limit",
          value:codeBlock(server_limit.toString()),
          inline:true
        },
        {
          name: "`❌` Error",
          value: codeBlock(error.toString()),
          inline: true,
        },
      ]);
    await msg.edit({
      embeds: [embed],
    });
  },
}; //`**Member already on the server**: ${already_joined
//\n**Error**: ${error}
