const { PermissionFlagsBits, EmbedBuilder, Client, ChatInputCommandInteraction, ActionRowBuilder, RoleSelectMenuBuilder, ButtonBuilder, ButtonStyle, DiscordAPIError, ComponentType, inlineCode, TextInputBuilder, TextInputStyle, ModalBuilder } = require("discord.js");

const discord = require("discord.js");
const IDLE_TIMEOUT = 30; // in seconds
const MAX_PER_PAGE = 10; // max number of embed fields per page

/**
 * @type {import("@structures/Command")}
 */

module.exports = {
  name: "leave",
  description: "Bot hakkında bilgi verir",
  default_permission: true,
  category: "whitelist",
  userPerms: [discord.PermissionFlagsBits.SendMessages],
  ownerOnly: true,

  run: async (client, interaction, args) => {
    const { channel, member } = interaction;

    const matched = [];
    const match = args.join(" ") || null;
    if (match) {
      // match by id
      if (client.guilds.cache.has(match)) {
        matched.push(client.guilds.cache.get(match));
      }

      // match by name
      client.guilds.cache
        .filter((g) => g.name.toLowerCase().includes(match.toLowerCase()))
        .forEach((g) => matched.push(g));
    }

    const servers = match ? matched : Array.from(client.guilds.cache.values());
    const total = servers.length;
    const maxPerPage = MAX_PER_PAGE;
    const totalPages = Math.ceil(total / maxPerPage);

    if (totalPages === 0) return ;
    let currentPage = 1;

    // Buttons Row
    let components = [];
    components.push(
      new ButtonBuilder().setCustomId("prevBtn").setEmoji("⬅️").setStyle(ButtonStyle.Secondary).setDisabled(true),
   
      new ButtonBuilder()
        .setCustomId("nxtBtn")
        .setEmoji("➡️")
        .setStyle(ButtonStyle.Secondary)
        .setDisabled(totalPages === 1),
        new ButtonBuilder().setCustomId("leave").setStyle(discord.ButtonStyle.Danger).setEmoji("❌")
    );
    let buttonsRow = new ActionRowBuilder().addComponents(components);

    // Embed Builder
    const buildEmbed = () => {
      const start = (currentPage - 1) * maxPerPage;
      const end = start + maxPerPage < total ? start + maxPerPage : total;

      const embed = new EmbedBuilder()
        .setColor("#E70000")
        .setAuthor({ name: "List of servers" })
        .setFooter({ text: `${match ? "Matched" : "Total"} Servers: ${total} • Page ${currentPage} of ${totalPages}` });

      const fields = [];
      for (let i = start; i < end; i++) {
        const server = servers[i];
        fields.push({
          name: server.name,
          value: `\`${server.id}\`\n Server Member : **${server.members.cache.size}**`,
         
          inline: false,
        });
      }
      embed.addFields(fields);

      let components = [];
      components.push(
        ButtonBuilder.from(buttonsRow.components[0]).setDisabled(currentPage === 1),
        ButtonBuilder.from(buttonsRow.components[1]).setDisabled(currentPage === totalPages),
        ButtonBuilder.from(buttonsRow.components[2])
      );
      buttonsRow = new ActionRowBuilder().addComponents(components);
      return embed;
    };

    // Send Message
    const embed = buildEmbed();
    const sentMsg = await interaction.reply({ embeds: [embed], components: [buttonsRow] , ephemeral: true});

    // Listeners
    const collector = channel.createMessageComponentCollector({
      filter: i => i?.isButton(),
      idle: IDLE_TIMEOUT * 1000,
      dispose: true,
      componentType: ComponentType.Button,
    });

    collector.on("collect", async (response) => {
     
      
      switch (response.customId) {

        case "leave": 
   
        const serverIdInput = new TextInputBuilder()
        .setCustomId("serveridInput")
        .setLabel("Server id")
        .setStyle(TextInputStyle.Short)
        const row1 = new ActionRowBuilder()
        .addComponents(serverIdInput)
       
        const modal = new ModalBuilder()
        .addComponents(row1)
        .setCustomId("bununieokuyonamk")
        .setTitle("Leave Server")
        await response.showModal(modal)
        const submit = await response.awaitModalSubmit({
            time:120000
        }).catch(() => {})
        if (!submit) return;
        const server = await client.guilds.fetch(submit.fields.getTextInputValue("serveridInput")).catch(() => {})
        if (!server) return submit.reply("Server not found")
       client.guilds.cache.get(submit.fields.getTextInputValue("serveridInput")).leave()
        submit.reply(`Leaved Server ${client.guilds.cache.get(submit.fields.getTextInputValue("serveridInput")).name} (\`${submit.fields.getTextInputValue("serveridInput")}\`)`)
      
      break;
        case "prevBtn":
          if (currentPage > 1) {
            currentPage--;
            const embed = buildEmbed();
            await sentMsg.edit({ embeds: [embed], components: [buttonsRow] });
          }
          break;
         
        case "nxtBtn":
          if (currentPage < totalPages) {
            currentPage++;
            const embed = buildEmbed();
            await sentMsg.edit({ embeds: [embed], components: [buttonsRow] });
          }
          break;
         

        }

      collector.on("end", async () => {
        await sentMsg.edit({ components: [] });
      });
    });
  },
};