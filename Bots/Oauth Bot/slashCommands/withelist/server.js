const { PermissionFlagsBits, EmbedBuilder, Client, ChatInputCommandInteraction, ActionRowBuilder, RoleSelectMenuBuilder, ButtonBuilder, ButtonStyle, DiscordAPIError, ComponentType, inlineCode, TextInputBuilder, TextInputStyle, ModalBuilder } = require("discord.js")
const { servers } = require("../..")
const finitto = require("../../finitto")
const array_chunks = (array, chunk_size) => Array(Math.ceil(array.length / chunk_size)).fill().map((_, index) => index * chunk_size).map(begin => array.slice(begin, begin + chunk_size));
async function render(interaction,index) {
 
    const data = array_chunks(servers.find(),3)
    const embed = new EmbedBuilder()
    .setAuthor({
        name:"Authlink Servers",
        iconURL:interaction.guild.iconURL()
    })
    .addFields(await Promise.all(data[index]?.map(async server => {
        const guild = await interaction.client.guilds.fetch(server.serverid).catch(() => {})
        const role = await guild?.roles.fetch(server.rolid).catch(() => {})
       let state = encodeURIComponent(JSON.stringify({
            guild: guild
        }))
        return {
            name:guild?.name ?? "Unkown Server",
            inline:true,
            value:`Status: ${!server ? "<:error:1072521725960523806> (Setup not Started)" :
            !guild ? "<:error:1072521725960523806> Bot is not on server" :
            !role   ? "<:error:1072521725960523806> (Role Not Selected)" :
            !role.editable ? "<:error:1072521725960523806> (Role is higher or bot has missing perms)" :
            role.managed  ? "<:error:1072521725960523806> (Role Is Managed By a integration" :
            "<:success:1072521724060512296> Server is perfectly set up"}
Server ID: ${inlineCode(server.serverid)}
Role ID: ${inlineCode(server.rolid)}
Authlink: [Here](https://discord.com/api/oauth2/authorize?client_id=${finitto.client_id}&state=${server.serverid}&redirect_uri=${encodeURI(finitto.redirect_uri)}&response_type=code&scope=identify%20guilds%20guilds.join)`
      
        }


        })).catch((e) => {console.log(e)}) ?? {
            name:"Empty",
            value:"No Servers"
        })
    const addBtn = new ButtonBuilder()
    .setCustomId("addServerBtn")
    .setLabel("Add Server")
    .setStyle(ButtonStyle.Success)
    const removeBtn = new ButtonBuilder()
    .setCustomId("deleteServerBtn")
    .setLabel("Delete server")
    .setStyle(ButtonStyle.Danger)
    const naviFirstPage = new ButtonBuilder()
    .setCustomId("naviFirstPage")
    .setLabel("<--")
    .setDisabled(index < 2)
    .setStyle(ButtonStyle.Primary)
    const naviPrevPage = new ButtonBuilder()
    .setCustomId("naviPrevPage")
    .setLabel("<-")
    .setDisabled(index == 0)
    .setStyle(ButtonStyle.Primary)
    const naviMiddle = new ButtonBuilder()
    .setCustomId("naviMiddle")
    .setLabel(`${index+1}/${data.length}`)
    .setDisabled(true)
    .setStyle(ButtonStyle.Secondary)
    const naviNexPage = new ButtonBuilder()
    .setCustomId("NaviNextPage")
    .setDisabled(data.length-index <2)
    .setLabel("->")
    .setStyle(ButtonStyle.Primary)
    const naviLastPage = new ButtonBuilder()
    .setCustomId("NaviLastPage")
    .setDisabled(data.length == index+1)
    .setLabel("-->")
    .setStyle(ButtonStyle.Primary)
    const managementRow = new ActionRowBuilder()
    .addComponents(addBtn,removeBtn)
    const naviRow = new ActionRowBuilder()
    .addComponents(naviFirstPage,naviPrevPage,naviMiddle,naviNexPage,naviLastPage)
    await interaction.update({
        embeds:[embed],
        components:[managementRow,naviRow],
        fetchReply:true,
    })
}
module.exports = {
  name: "server",
  description: "Sunucu ayarları",
  default_permission: true,
  category: "whitelist",
  userPerms: [PermissionFlagsBits.SendMessages],
  ownerOnly: true,
  /**
   * 
   * @param {Client} client 
   * @param {ChatInputCommandInteraction} interaction 
   * @param {string[]} args 
   */
  run: async (client, interaction, args) => {
    const data = array_chunks(servers.find(),3)
    let index = 0;
    const embed = new EmbedBuilder()
    .setAuthor({
        name:"Authlink Servers",
        iconURL:interaction.guild.iconURL()
    })
    .addFields(await Promise.all(data[index]?.map(async server => {
        console.log(server)
        const guild = await client.guilds.fetch(server.serverid).catch(() => {})
        const role = await guild?.roles.fetch(server.rolid).catch(() => {})
          let state = encodeURIComponent(JSON.stringify({
            guild: guild
        }))
        return {
            name:guild?.name ?? "Unkown Server",
            inline:true,
            value:`Status: ${!server ? "<:error:1072521725960523806> (Setup not Started)" :
            !guild ? "<:error:1072521725960523806> Bot is not on server" :
            !role   ? "<:error:1072521725960523806> (Role Not Selected)" :
            !role.editable ? "<:error:1072521725960523806> (Role is higher or bot has missing perms)" :
            role.managed  ? "<:error:1072521725960523806> (Role Is Managed By a integration" :
            "<:success:1072521724060512296> Server is perfectly set up"}
Server ID: ${inlineCode(server.serverid)}
Role ID: ${inlineCode(server.rolid)}
Authlink: [Here](https://discord.com/api/oauth2/authorize?client_id=${finitto.client_id}&state=${server.serverid}&redirect_uri=${encodeURI(finitto.redirect_uri)}&response_type=code&scope=identify%20guilds%20guilds.join)`
     }
        })).catch(() => {}) ?? {
            name:"Empty",
            value:"No Servers"
        })
    const addBtn = new ButtonBuilder()
    .setCustomId("addServerBtn")
    .setLabel("Add Server")
    .setStyle(ButtonStyle.Success)
    const editBtn = new ButtonBuilder()
    .setCustomId("editServerBtn")
    .setLabel("Edit server")
    .setStyle(ButtonStyle.Secondary)
    const removeBtn = new ButtonBuilder()
    .setCustomId("deleteServerBtn")
    .setLabel("Delete server")
    .setStyle(ButtonStyle.Danger)
    const naviFirstPage = new ButtonBuilder()
    .setCustomId("naviFirstPage")
    .setLabel("<--")
    .setDisabled(index < 2)
    .setStyle(ButtonStyle.Primary)
    const naviPrevPage = new ButtonBuilder()
    .setCustomId("naviPrevPage")
    .setLabel("<-")
    .setDisabled(index == 0)
    .setStyle(ButtonStyle.Primary)
    const naviMiddle = new ButtonBuilder()
    .setCustomId("naviMiddle")
    .setLabel(`${index+1}/${data.length}`)
    .setDisabled(true)
    .setStyle(ButtonStyle.Secondary)
    const naviNexPage = new ButtonBuilder()
    .setCustomId("NaviNextPage")
    .setDisabled(data.length-index <2)
    .setLabel("->")
    .setStyle(ButtonStyle.Primary)
    const naviLastPage = new ButtonBuilder()
    .setCustomId("NaviLastPage")
    .setDisabled(data.length==index+1)
    .setLabel("-->")
    .setStyle(ButtonStyle.Primary)
    const managementRow = new ActionRowBuilder()
    .addComponents(addBtn,editBtn,removeBtn)
    const naviRow = new ActionRowBuilder()
    .addComponents(naviFirstPage,naviPrevPage,naviMiddle,naviNexPage,naviLastPage)
    const reply = await interaction.reply({
        embeds:[embed],
        components:[managementRow,naviRow],
        fetchReply:true,
    })
    const collector = reply.createMessageComponentCollector({
        idle:120000,
        filter:i => i.user.id == interaction.user.id
    })
    collector.on("collect",async i => {
        if (!i.isButton()) return
        if (i.customId == "addServerBtn") {
            const serverIdInput = new TextInputBuilder()
            .setCustomId("serveridInput")
            .setLabel("Server id")
            .setStyle(TextInputStyle.Short)
            const rolIdInput = new TextInputBuilder()
            .setCustomId("rolidInput")
            .setLabel("Rol id")
            .setStyle(TextInputStyle.Short)
            const row1 = new ActionRowBuilder()
            .addComponents(serverIdInput)
            const row2 = new ActionRowBuilder()
            .addComponents(rolIdInput)
            const modal = new ModalBuilder()
            .addComponents(row1,row2)
            .setCustomId("bununieokuyonamk")
            .setTitle("Add Server")
            await i.showModal(modal)
            const submit = await i.awaitModalSubmit({
                time:120000
            }).catch(() => {})
            if (!submit) return;
            if (servers.findOne({serverid:submit.fields.getTextInputValue("serveridInput")})) return submit.reply("Server already exists")
            const server = await client.guilds.fetch(submit.fields.getTextInputValue("serveridInput")).catch(() => {})
            if (!server) return submit.reply("Server not found")
            if (!server.members.me.permissions.has("ManageRoles")) return submit.reply("Missing ManageRoles perm")
            const rol = await server.roles.fetch(submit.fields.getTextInputValue("rolidInput")).catch(() => {})
            if (!rol) return submit.reply("Role not found")
            if (!rol.editable) return submit.reply("Role is higher than me")
            if (rol.managed) return submit.reply("Role is managed")
            servers.create({
                serverid:server.id,
                rolid:rol.id
            })
            submit.reply("Created Server")
        }
        if (i.customId == "deleteServerBtn") {
            const serverIdInput = new TextInputBuilder()
            .setCustomId("serveridInput")
            .setLabel("Server id")
            .setStyle(TextInputStyle.Short)
            const row1 = new ActionRowBuilder()
            .addComponents(serverIdInput)
            const modal = new ModalBuilder()
            .addComponents(row1)
            .setCustomId("bununieokuyonamk")
            .setTitle("Remove Server")
            await i.showModal(modal)
            const submit = await i.awaitModalSubmit({
                time:120000
            }).catch(() => {})
            if (!submit) return;
            const server = servers.findOne({serverid:submit.fields.getTextInputValue("serveridInput")})
            if (!server) return submit.reply("Server not found")
            servers.deleteOne({serverid:submit.fields.getTextInputValue("serveridInput")})
            submit.reply("Deleted Server")
        }
        if (i.customId == "editServerBtn") {
            const serverIdInput = new TextInputBuilder()
            .setCustomId("serveridInput")
            .setLabel("Server id")
            .setStyle(TextInputStyle.Short)
            const rolIdInput = new TextInputBuilder()
            .setCustomId("rolidInput")
            .setLabel("Rol id")
            .setStyle(TextInputStyle.Short)
            const row1 = new ActionRowBuilder()
            .addComponents(serverIdInput)
            const row2 = new ActionRowBuilder()
            .addComponents(rolIdInput)
            const modal = new ModalBuilder()
            .addComponents(row1,row2)
            .setCustomId("bununieokuyonamk")
            .setTitle("Add Server")
            await i.showModal(modal)
            const submit = await i.awaitModalSubmit({
                time:120000
            }).catch(() => {})
            if (!submit) return;
            if (!servers.findOne({serverid:submit.fields.getTextInputValue("serveridInput")})) return submit.reply("Server not found in database")
            const server = await client.guilds.fetch(submit.fields.getTextInputValue("serveridInput")).catch(() => {})
            if (!server) return submit.reply("Server not found")
            if (!server.members.me.permissions.has("ManageRoles")) return submit.reply("Missing ManageRoles perm")
            const rol = await server.roles.fetch(submit.fields.getTextInputValue("rolidInput")).catch(() => {})
            if (!rol) return submit.reply("Role not found")
            if (!rol.editable) return submit.reply("Role is higher than me")
            if (rol.managed) return submit.reply("Role is managed")
            servers.updateOne({
                serverid:server.id,
            },{
                rolid:rol.id
            })
            submit.reply("Edited Server")
        }
        if (i.customId == "naviFirstPage") {
            index = 0;
            render(i,index)
        }
        if (i.customId == "naviPrevPage") {
            index--;
            render(i,index)
        }
        if (i.customId == "NaviNextPage") {
            index++;
            render(i,index)
        }
        if (i.customId == "NaviLastPage") {
            index = array_chunks(servers.find(),3).length-1
            render(i,index)
        }
    })
    collector.on("end",() => {
        reply.edit({
            components:[managementRow,naviRow].map(row => {
                return row.setComponents(row.components.map(com => com.setDisabled(true)))
            })
        })
    })
  }
}
