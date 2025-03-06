const Discord = require("discord.js");
const mongoose = require("mongoose");
const client = new Discord.Client({
	intents: [
		Discord.Intents.FLAGS.GUILDS,
		Discord.Intents.FLAGS.GUILD_MEMBERS,
		Discord.Intents.FLAGS.GUILD_BANS,
		Discord.Intents.FLAGS.GUILD_EMOJIS_AND_STICKERS,
		Discord.Intents.FLAGS.GUILD_INTEGRATIONS,
		Discord.Intents.FLAGS.GUILD_WEBHOOKS,
		Discord.Intents.FLAGS.GUILD_INVITES,
		Discord.Intents.FLAGS.GUILD_VOICE_STATES,
		Discord.Intents.FLAGS.GUILD_PRESENCES,
		Discord.Intents.FLAGS.GUILD_MESSAGES,
		Discord.Intents.FLAGS.GUILD_MESSAGE_REACTIONS,
		Discord.Intents.FLAGS.GUILD_MESSAGE_TYPING,
		Discord.Intents.FLAGS.DIRECT_MESSAGES,
		Discord.Intents.FLAGS.DIRECT_MESSAGE_REACTIONS,
		Discord.Intents.FLAGS.DIRECT_MESSAGE_TYPING
	]
});
const fs = require("fs");
const config = require("./config.json");
const guildsettings = require("./guildconfig.json");
client.config = config;
client.guildsettings = guildsettings;
const InviteModel = require("./model/invite")
client.db = require("quick.db");
const Schema = require("./model/sticky");
const fetchAll = require("discord-fetch-all")
let isRunning = false;

const InvitesTracker = require('@androz2091/discord-invites-tracker');
const tracker = InvitesTracker.init(client, {
	fetchGuilds: true,
	fetchVanity: true,
	fetchAuditLogs: true
});

client.afks = new Discord.Collection()
client.spams = new Discord.Collection()
client.cooldown = new Discord.Collection();

(async () => {
	await require("./utils/backup")(client);
})();

client.on("messageDelete", async message => {
	const AUTO_DELETE = await client.db.get(`autodelete`);
	if (AUTO_DELETE == null) return;
	if (message.channel.id !== AUTO_DELETE.channel) return;

	await client.db.set(`autodelete`, {
		channel: AUTO_DELETE.channel,
		duration: AUTO_DELETE.duration,
		lastDelete: AUTO_DELETE.lastDelete,
		amount: AUTO_DELETE.amount,
		currentAmount: (AUTO_DELETE.currentAmount - 1)
	});
})


client.on("messageDeleteBulk", async messages => {
	const AUTO_DELETE = await client.db.get(`autodelete`);
	if (AUTO_DELETE == null) return;
	if (messages.first().channel.id !== AUTO_DELETE.channel) return;
	await client.db.set(`autodelete`, {
		channel: AUTO_DELETE.channel,
		duration: AUTO_DELETE.duration,
		lastDelete: AUTO_DELETE.lastDelete,
		amount: AUTO_DELETE.amount,
		currentAmount: (AUTO_DELETE.currentAmount - (messages.size - 1))
	});
})

client.on("messageCreate", async message => {
	const AUTO_DELETE = client.db.get(`autodelete`);
	if (AUTO_DELETE == null) return;
	if (message.channel.id !== AUTO_DELETE.channel) return;
	const channel = client.channels.cache.get(AUTO_DELETE.channel);
	if (AUTO_DELETE.currentAmount >= AUTO_DELETE.amount) {
		if (!isRunning) {
			isRunning = true;
			const messages = await fetchAll.messages(channel, {
				reverseArray: true,
			});
			if ((messages.length - AUTO_DELETE.amount) > 5) {
				const bulk = messages.slice(0, 5);
				await channel.bulkDelete(bulk);
			}

			await client.db.set(`autodelete`, {
				channel: AUTO_DELETE.channel,
				duration: AUTO_DELETE.duration,
				lastDelete: Date.now(),
				amount: AUTO_DELETE.amount,
				currentAmount: AUTO_DELETE.currentAmount - 5
			});
			isRunning = false;
		}
	}
	await client.db.set(`autodelete`, {
		channel: AUTO_DELETE.channel,
		duration: AUTO_DELETE.duration,
		lastDelete: AUTO_DELETE.lastDelete,
		amount: AUTO_DELETE.amount,
		currentAmount: (AUTO_DELETE.currentAmount + 1)
	});
})

client.on("messageCreate", async message => {
	if (message.author.id === client.user.id) return;
	const emojis = client.db.get(`autoreaction_${message.channel.id}`);
	if (emojis) {
		const random = Math.floor(Math.random() * emojis.length);
		message.react(emojis[random]);
	}
	try {
		Schema.findOne(
			{ Guild: message.guild.id, Channel: message.channel.id },
			async (err, data) => {
				if (!data) return;

				const lastStickyMessage = await message.channel.messages
					.fetch(data.LastMessage)
					.catch(() => { });
				if (!lastStickyMessage) return;
				await lastStickyMessage.delete({ timeout: 1000 });
				const Embed = new Discord.MessageEmbed()
					.setColor("#56089e")
					.setDescription(data.Content)
				const newMessage = await client.channels.cache
					.get(data.Channel)
					.send({ embeds: [Embed] });

				data.LastMessage = newMessage.id;
				data.save();
			}
		);
	} catch { }
})

tracker.on('guildMemberAdd', async (member, type, invite) => {

	if (type === 'normal') {
		if ((new Date().getTime() - new Date(member.user.createdAt).getTime()) < 86400000) {
			let data = await InviteModel.findOne({
				guildID: member.guild.id,
				userID: invite.inviter.id
			});
			if (!data) {
				data = new InviteModel({
					servername: member.guild.name,
					userID: invite.inviter.id,
					joiner: [member.id],
					regular: 0,
					left: 0,
					fake: 1,
					guildID: member.guild.id
				})
				await data.save()
			} else {
				if (data.joiner.includes(member.id)) return
				data.joiner.push(member.id)
				data.fake += 1
				await data.save()
			}
		}
		else {
			let data = await InviteModel.findOne({
				guildID: member.guild.id,
				userID: invite.inviter.id
			});
			if (!data) {
				data = new InviteModel({
					servername: member.guild.name,
					userID: invite.inviter.id,
					joiner: [member.id],
					regular: 1,
					left: 0,
					fake: 0,
					guildID: member.guild.id
				})
				await data.save()
			} else {
				if (data.joiner.includes(member.id)) return
				data.joiner.push(member.id)
				data.regular += 1
				await data.save()
			}
		}
	}
});


/** REACT ROLE */
client.on('messageReactionAdd', async (reaction, user) => {
	if (user.id === client.user.id) return;
	if (!reaction.message.channel.type === "dm") return;
	const message = reaction.message;
	const member = message.guild.members.cache.get(user.id);
	const emoji = reaction.emoji.name;
	const emoji_id = reaction.emoji.id;

	const data = client.db.get(`react_role_${emoji_id}`);
	if (!data) return;

	if (data.message_id !== message.id) return;
	const role = data.role
	if (!role) return;

	const ROLE = message.guild.roles.cache.get(role);
	if (!ROLE) return;

	await member.roles.add([ROLE]);
});

client.on('messageReactionRemove', async (reaction, user) => {
	if (user.id === client.user.id) return;
	if (!reaction.message.channel.type === "dm") return;
	const message = reaction.message;
	const member = message.guild.members.cache.get(user.id);
	const emoji = reaction.emoji.name;
	const emoji_id = reaction.emoji.id;

	const data = client.db.get(`react_role_${emoji_id}`);
	if (!data) return;

	if (data.message_id !== message.id) return;
	const role = data.role
	if (!role) return;

	const ROLE = message.guild.roles.cache.get(role);
	if (!ROLE) return;

	await member.roles.remove([ROLE]);
});

/** VOUCH CODE */

client.on('messageCreate', async (message) => {
	if (message.author.bot) return;

	const CHANNEL = client.db.get('vouch_channel');
	if (!CHANNEL) return;
	if (message.channel.id !== CHANNEL) return;

	const ROLE_ID = client.db.get('vouch_role');
	if (!ROLE_ID) return;

	const ROLE = message.guild.roles.cache.get(ROLE_ID);
	if (!ROLE) return;

	await message.member.roles.add([ROLE]);

	const data = client.db.get('vouch_data');
	if (!data) {
		client.db.set('vouch_data', [message.author.id]);
	}
	else if (data.includes(message.author.id)) {
		return;
	}
	else {
		client.db.push('vouch_data', message.author.id);
	}
});

/** LOGS CODE */
client.on('guildMemberRemove', async (member) => {
	if (member.guild.fetchAuditLogs) {
		const audit = await member.guild.fetchAuditLogs({ type: 'MEMBER_KICK' });
		const entry = audit.entries.first();
		if (entry.target.id === member.id) {
			const excutioner = entry.executor;
			const data = client.db.get('kick_logs');
			if (!data) return;

			const channel = member.guild.channels.cache.get(data);
			if (!channel) return;

			const embed = new Discord.MessageEmbed()
				.setColor('RED')
				.setAuthor(member.user.tag, member.user.displayAvatarURL({ dynamic: true }))
				.setDescription(`**User:** ${member.user} (${member.user.id})\n**Action:** Kick\n**Excutioner:** ${excutioner} (${excutioner.id})`)
				.setTimestamp();

			channel.send({ embeds: [embed] });
		}
	}
})


client.on('guildBanAdd', async (user) => {
	const guild = user.guild;
	const audit = await guild.fetchAuditLogs({ type: 'MEMBER_BAN_ADD' });
	const entry = audit.entries.first();
	if (entry.target.id === user.user.id) {
		const excutioner = entry.executor;
		const data = client.db.get('ban_logs');
		if (!data) return;

		const channel = guild.channels.cache.get(data);
		if (!channel) return;

		const embed = new Discord.MessageEmbed()
			.setColor('RED')
			.setAuthor(user.user.tag, user.user.displayAvatarURL({ dynamic: true }))
			.setDescription(`**User:** ${user.user} (${user.user.id})\n**Action:** Ban\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
})

client.on('guildBanRemove', async (user) => {
	const guild = user.guild;
	const audit = await guild.fetchAuditLogs({ type: 'MEMBER_BAN_REMOVE' });
	const entry = audit.entries.first();
	if (entry.target.id === user.user.id) {
		const excutioner = entry.executor;
		const data = client.db.get('ban_logs');
		if (!data) return;

		const channel = guild.channels.cache.get(data);
		if (!channel) return;

		const embed = new Discord.MessageEmbed()
			.setColor('GREEN')
			.setAuthor(user.user.tag, user.user.displayAvatarURL({ dynamic: true }))
			.setDescription(`**User:** ${user.user} (${user.user.id})\n**Action:** Unban\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
})

client.on('messageDelete', async message => {
	if (message.author.bot) return;
	const data = client.db.get('message_logs');
	if (!data) return;

	const channel = message.guild.channels.cache.get(data);
	if (!channel) return;
	const guild = message.guild;
	const audit = await guild.fetchAuditLogs({ type: 'MESSAGE_DELETE' });
	const entry = audit.entries.first();
	if (entry.target.id === message.author.id) {
		const excutioner = entry.executor;
		const data = client.db.get('message_logs');
		if (!data) return;

		const channel = message.guild.channels.cache.get(data);
		if (!channel) return;

		const embed = new Discord.MessageEmbed()
			.setColor('RED')
			.setAuthor(message.author.tag, message.author.displayAvatarURL({ dynamic: true }))
			.setDescription(`**User:** ${message.author} (${message.author.id})\n**Channel:** ${message.channel}\n**Message:** ${message.content}\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
})

client.on('messageDeleteBulk', async messages => {
	const guild = messages.first().guild;
	const audit = await guild.fetchAuditLogs({ type: 'MESSAGE_BULK_DELETE' });
	const entry = audit.entries.first();
	if (entry.target.id === messages.first().channel.id) {
		const excutioner = entry.executor;
		const data = client.db.get('message_logs');
		if (!data) return;

		const channel = messages.first().guild.channels.cache.get(data);
		if (!channel) return;

		const allMessages = messages.map(m => m.content).join('\n');

		const embed = new Discord.MessageEmbed()
			.setColor('RED')
			.setAuthor(messages.first().author.tag, messages.first().author.displayAvatarURL({ dynamic: true }))
			.setDescription(`**User:** ${messages.first().author} (${messages.first().author.id})\n**Channel:** ${messages.first().channel}\n**Messages:** ${allMessages}\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
})

client.on('roleCreate', async role => {
	const data = client.db.get('server_logs');
	if (!data) return;

	const channel = role.guild.channels.cache.get(data);
	if (!channel) return;

	const guild = role.guild;
	const audit = await guild.fetchAuditLogs({ type: 'ROLE_CREATE' });
	const entry = audit.entries.first();
	if (entry.target.id === role.id) {
		const excutioner = entry.executor;
		const embed = new Discord.MessageEmbed()
			.setColor('GREEN')
			.setAuthor(role.name, role.guild.iconURL({ dynamic: true }))
			.setDescription(`**Role:** ${role.name} (${role.id})\n**Action:** Create\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
})

client.on('roleDelete', async role => {
	const data = client.db.get('server_logs');
	if (!data) return;

	const channel = role.guild.channels.cache.get(data);
	if (!channel) return;

	const guild = role.guild;
	const audit = await guild.fetchAuditLogs({ type: 'ROLE_DELETE' });
	const entry = audit.entries.first();
	if (entry.target.id === role.id) {
		const excutioner = entry.executor;
		const embed = new Discord.MessageEmbed()
			.setColor('RED')
			.setAuthor(role.name, role.guild.iconURL({ dynamic: true }))
			.setDescription(`**Role:** ${role.name} (${role.id})\n**Action:** Delete\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
})

client.on('roleUpdate', async (oldRole, newRole) => {
	const data = client.db.get('server_logs');
	if (!data) return;

	const channel = oldRole.guild.channels.cache.get(data);
	if (!channel) return;

	const guild = oldRole.guild;
	const audit = await guild.fetchAuditLogs({ type: 'ROLE_UPDATE' });
	const entry = audit.entries.first();
	if (entry.target.id === oldRole.id) {
		const excutioner = entry.executor;
		const oldRplePosition = (guild.roles.cache.size - oldRole.rawPosition) - 1;
		const newRolePosition = (guild.roles.cache.size - newRole.rawPosition) - 1;
		const embed = new Discord.MessageEmbed()
			.setColor('BLURPLE')
			.setAuthor(oldRole.name, oldRole.guild.iconURL({ dynamic: true }))
			.setDescription(`**Role:** ${oldRole.name} (${oldRole.id})\n**Action:** Update\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.addField('Old Role', `**Name:** ${oldRole.name}\n**Color:** ${oldRole.hexColor}\n**Mentionable:** ${oldRole.mentionable}\n**Position:** ${oldRplePosition}\n**Permissions:** ${oldRole.permissions.toArray().join(', ')}`)
			.addField('New Role', `**Name:** ${newRole.name}\n**Color:** ${newRole.hexColor}\n**Mentionable:** ${newRole.mentionable}\n**Position:** ${newRolePosition}\n**Permissions:** ${newRole.permissions.toArray().join(', ')}`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
})

client.on('channelCreate', async channel => {
	const data = client.db.get('server_logs');
	if (!data) return;

	const logChannel = channel.guild.channels.cache.get(data);
	if (!logChannel) return;

	const guild = channel.guild;
	const audit = await guild.fetchAuditLogs({ type: 'CHANNEL_CREATE' });
	const entry = audit.entries.first();
	if (entry.target.id === channel.id) {
		const excutioner = entry.executor;
		const embed = new Discord.MessageEmbed()
			.setColor('GREEN')
			.setAuthor(channel.name, channel.guild.iconURL({ dynamic: true }))
			.setDescription(`**Channel:** ${channel.name} (${channel.id})\n**Action:** Create\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.setTimestamp();

		logChannel.send({ embeds: [embed] });
	}
})

client.on('channelDelete', async channel => {
	const data = client.db.get('server_logs');
	if (!data) return;

	const logChannel = channel.guild.channels.cache.get(data);
	if (!logChannel) return;

	const guild = channel.guild;
	const audit = await guild.fetchAuditLogs({ type: 'CHANNEL_DELETE' });
	const entry = audit.entries.first();
	if (entry.target.id === channel.id) {
		const excutioner = entry.executor;
		const embed = new Discord.MessageEmbed()
			.setColor('RED')
			.setAuthor(channel.name, channel.guild.iconURL({ dynamic: true }))
			.setDescription(`**Channel:** ${channel.name} (${channel.id})\n**Action:** Delete\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.setTimestamp();

		logChannel.send({ embeds: [embed] });
	}
})

client.on('channelUpdate', async (oldChannel, newChannel) => {
	const data = client.db.get('server_logs');
	if (!data) return;

	const logChannel = oldChannel.guild.channels.cache.get(data);
	if (!logChannel) return;

	const guild = oldChannel.guild;
	const audit = await guild.fetchAuditLogs({ type: 'CHANNEL_UPDATE' });
	const entry = audit.entries.first();
	if (entry.target.id === oldChannel.id) {
		const excutioner = entry.executor;
		const category = oldChannel.parent ? oldChannel.parent : 'None';
		const embed = new Discord.MessageEmbed()
			.setColor('BLURPLE')
			.setAuthor(oldChannel.name, oldChannel.guild.iconURL({ dynamic: true }))
			.setDescription(`**Channel:** ${oldChannel.name} (${oldChannel.id})\n**Action:** Update\n**Excutioner:** ${excutioner} (${excutioner.id})`)
			.addField('Old Channel', `**Name:** ${oldChannel.name}\n**Type:** ${oldChannel.type}\n**NSFW:** ${oldChannel.nsfw}\n**Category:** ${category}\n**Topic:** ${oldChannel.topic}`)
			.addField('New Channel', `**Name:** ${newChannel.name}\n**Type:** ${newChannel.type}\n**NSFW:** ${newChannel.nsfw}\n**Category:** ${category}\n**Topic:** ${newChannel.topic}`)
			.setTimestamp();

		logChannel.send({ embeds: [embed] });
	}
})

client.on('messageUpdate', async (oldMessage, newMessage) => {
	if (oldMessage.author.bot) return;
	if (oldMessage.content === newMessage.content) return;
	const data = client.db.get('message_logs');
	if (!data) return;

	const channel = oldMessage.guild.channels.cache.get(data);
	if (!channel) return;

	const embed = new Discord.MessageEmbed()
		.setColor('BLURPLE')
		.setAuthor(oldMessage.author.tag, oldMessage.author.displayAvatarURL({ dynamic: true }))
		.setDescription(`**User:** ${oldMessage.author} (${oldMessage.author.id})\n**Channel:** ${oldMessage.channel}\n**Old Message:** ${oldMessage.content}\n**New Message:** ${newMessage.content}`)
		.setTimestamp();

	channel.send({ embeds: [embed] });
})

client.on('userUpdate', async (oldUser, newUser) => {
	if (oldUser.username === newUser.username) return;
	const data = client.db.get('member_logs');
	if (!data) return;

	const channel = client.channels.cache.get(data);
	if (!channel) return;

	const guild = client.guilds.cache.get(channel.guild.id);

	const MEMBER = await guild.members.fetch(oldUser.id);
	if (!MEMBER) return;

	const embed = new Discord.MessageEmbed()
		.setColor('BLURPLE')
		.setAuthor(oldUser.tag, oldUser.displayAvatarURL({ dynamic: true }))
		.setDescription(`**User:** ${oldUser} (${oldUser.id})\n**Old Username:** ${oldUser.username}\n**New Username:** ${newUser.username}`)
		.setTimestamp();

	channel.send({ embeds: [embed] });
})

client.on('userUpdate', async (oldUser, newUser) => {
	if (oldUser.discriminator === newUser.discriminator) return;
	const data = client.db.get('member_logs');
	if (!data) return;

	const channel = client.channels.cache.get(data);
	if (!channel) return;

	const guild = client.guilds.cache.get(channel.guild.id);

	const MEMBER = await guild.members.fetch(oldUser.id);
	if (!MEMBER) return;

	const embed = new Discord.MessageEmbed()
		.setColor('BLURPLE')
		.setAuthor(oldUser.tag, oldUser.displayAvatarURL({ dynamic: true }))
		.setDescription(`**User:** ${oldUser} (${oldUser.id})\n**Old Discriminator:** ${oldUser.discriminator}\n**New Discriminator:** ${newUser.discriminator}`)
		.setTimestamp();

	channel.send({ embeds: [embed] });
})

client.on('userUpdate', async (oldUser, newUser) => {
	if (oldUser.avatarURL() === newUser.avatarURL()) return;
	const data = client.db.get('member_logs');
	if (!data) return;

	const channel = client.channels.cache.get(data);
	if (!channel) return;

	const guild = client.guilds.cache.get(channel.guild.id);

	const MEMBER = await guild.members.fetch(oldUser.id);
	if (!MEMBER) return;

	const embed = new Discord.MessageEmbed()
		.setColor('BLURPLE')
		.setAuthor(oldUser.tag, newUser.displayAvatarURL({ dynamic: true }))
		.setThumbnail(oldUser.displayAvatarURL({ dynamic: true }))
		.setDescription(`**User:** ${oldUser} (${oldUser.id})\n**Old Avatar:** ${oldUser.displayAvatarURL({ dynamic: true, format: "png" })}\n**New Avatar:** ${newUser.displayAvatarURL({ dynamic: true, format: "png" })}`)
		.setTimestamp();

	channel.send({ embeds: [embed] });
})

client.on('guildMemberUpdate', async (oldMember, newMember) => {
	const data = client.db.get('member_logs');
	if (!data) return;

	const channel = oldMember.guild.channels.cache.get(data);
	if (!channel) return;
	if (oldMember.roles.cache.size < newMember.roles.cache.size) {
		const role = newMember.roles.cache.filter(r => !oldMember.roles.cache.has(r.id)).first();
		if (role.managed) return;
		const audit = await oldMember.guild.fetchAuditLogs({ type: 'MEMBER_ROLE_UPDATE' }).then(audit => audit.entries.first());
		const embed = new Discord.MessageEmbed()
			.setColor('GREEN')
			.setAuthor(newMember.user.tag, newMember.user.displayAvatarURL({ dynamic: true }))
			.setDescription(`**User:** ${newMember.user} (${newMember.user.id})\n**Action:** Role Added\n**Role:** ${role} (${role.id})\n**Moderator:** ${audit.executor} (${audit.executor.id})`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
	else if (oldMember.roles.cache.size > newMember.roles.cache.size) {
		const role = oldMember.roles.cache.filter(r => !newMember.roles.cache.has(r.id)).first();
		if (role.managed) return;
		const audit = await oldMember.guild.fetchAuditLogs({ type: 'MEMBER_ROLE_UPDATE' }).then(audit => audit.entries.first());
		const embed = new Discord.MessageEmbed()
			.setColor('RED')
			.setAuthor(newMember.user.tag, newMember.user.displayAvatarURL({ dynamic: true }))
			.setDescription(`**User:** ${newMember.user} (${newMember.user.id})\n**Action:** Role Removed\n**Role:** ${role} (${role.id})\n**Moderator:** ${audit.executor} (${audit.executor.id})`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
	else if (oldMember.nickname !== newMember.nickname) {
		const embed = new Discord.MessageEmbed()
			.setColor('BLURPLE')
			.setAuthor(newMember.user.tag, newMember.user.displayAvatarURL({ dynamic: true }))
			.setDescription(`**User:** ${newMember.user} (${newMember.user.id})\n**Action:** Nickname Change\n**Old Nickname:** ${oldMember.nickname}\n**New Nickname:** ${newMember.nickname}`)
			.setTimestamp();

		channel.send({ embeds: [embed] });
	}
})

tracker.on('guildMemberAdd', (member, type, invite) => {
	if (!client.guildsettings[member.guild.id]) return
	if (!client.guildsettings[member.guild.id].logs) return
	const welcomeChannel = member.guild.channels.cache.get(client.guildsettings[member.guild.id].logs.welcome_logs)

	if (type === 'normal') {
		welcomeChannel.send(`${client.guildsettings[member.guild.id].welcome_emoji ? client.guildsettings[member.guild.id].welcome_emoji :
			"✅"}Welcome ${member.displayName}!\n${client.guildsettings[member.guild.id].welcome_emoji ? client.guildsettings[member.guild.id].welcome_emoji :
				"✅"} You were invited by ${invite.inviter.username}!`);
	}

	else if (type === 'vanity') {
		welcomeChannel.send(`${client.guildsettings[member.guild.id].welcome_emoji ? client.guildsettings[member.guild.id].welcome_emoji :
			"✅"}Welcome ${member.displayName}!\n${client.guildsettings[member.guild.id].welcome_emoji ? client.guildsettings[member.guild.id].welcome_emoji :
				"✅"} You joined using a custom invite!`);
	}

	else if (type === 'permissions') {
		welcomeChannel.send(`${client.guildsettings[member.guild.id].welcome_emoji ? client.guildsettings[member.guild.id].welcome_emoji :
			"✅"}Welcome ${member.displayName}! \n${client.guildsettings[member.guild.id].welcome_emoji ? client.guildsettings[member.guild.id].welcome_emoji :
				"✅"} I can't figure out how you joined because I don't have the "Manage Server" permission!`);
	}

	else if (type === 'unknown') {
		welcomeChannel.send(`${client.guildsettings[member.guild.id].welcome_emoji ? client.guildsettings[member.guild.id].welcome_emoji :
			"✅"}Welcome ${member.displayName}! \n${client.guildsettings[member.guild.id].welcome_emoji ? client.guildsettings[member.guild.id].welcome_emoji :
				"✅"} I can't figure out how you joined the server...`);
	}

});


client.on("guildMemberRemove", async (member) => {
	let data = await InviteModel.find({
		guildID: member.guild.id
	});
	if (!data) return
	let joiners = []
	data.forEach(d => {
		d.joiner.forEach(j => {
			joiners.push(j)
		})
	})
	if (!joiners.includes(member.id)) return
	else {
		let inviter;
		data.forEach(d => {
			d.joiner.forEach(j => {
				if (j === member.id) {
					inviter = d.userID
				}
			})
		})
		data = await InviteModel.findOne({
			guildID: member.guild.id,
			userID: inviter
		});
		data.left += 1;
		data.joiner.pull(member.id)
		await data.save()
	}
})

// Initialise discord giveaways
const { GiveawaysManager } = require("discord-giveaways");
const { listenerCount } = require("process");
client.giveawaysManager = new GiveawaysManager(client, {
	storage: "./storage/giveaways.json",
	default: {
		botsCanWin: false,
		embedColor: "#2F3136",
		reaction: "🎉",
		lastChance: {
			enabled: true,
			content: `🛑 **Last chance to enter** 🛑`,
			threshold: 5000,
			embedColor: '#FF0000'
		}
	}
});

/* Load all events (discord based) */


fs.readdir("./events/discord", (_err, files) => {
	files.forEach(file => {
		if (!file.endsWith(".js")) return;
		const event = require(`./events/discord/${file}`);
		let eventName = file.split(".")[0];
		console.log(`[Event]   ✅  Loaded: ${eventName}`);
		client.on(eventName, event.bind(null, client));
		delete require.cache[require.resolve(`./events/discord/${file}`)];
	});
});

/* Load all events (giveaways based) */


fs.readdir("./events/giveaways", (_err, files) => {
	files.forEach((file) => {
		if (!file.endsWith(".js")) return;
		const event = require(`./events/giveaways/${file}`);
		let eventName = file.split(".")[0];
		console.log(`[Event]   🎉 Loaded: ${eventName}`);
		client.giveawaysManager.on(eventName, (...file) => event.execute(...file, client)), delete require.cache[require.resolve(`./events/giveaways/${file}`)];
	})
})

// Let commands be a new collection ( message commands )
client.commands = new Discord.Collection();
/* Load all commands */
fs.readdir("./commands/", (_err, files) => {
	files.forEach(file => {
		if (!file.endsWith(".js")) return;
		let props = require(`./commands/${file}`);
		let commandName = file.split(".")[0];
		client.commands.set(commandName, {
			name: commandName,
			...props
		});
		console.log(`[Command] ✅  Loaded: ${commandName}`);
	});
});

// let interactions be a new collection ( slash commands  )
client.interactions = new Discord.Collection();
// creating an empty array for registering slash commands
client.register_arr = []
/* Load all slash commands */
fs.readdir("./slash/", (_err, files) => {
	files.forEach(file => {
		if (!file.endsWith(".js")) return;
		let props = require(`./slash/${file}`);
		let commandName = file.split(".")[0];
		client.interactions.set(commandName, {
			name: commandName,
			...props
		});
		client.register_arr.push(props)
	});
});

client.on("guildMemberAdd", async member => {



	if (!client.guildsettings[member.guild.id]) return
	if (!client.guildsettings[member.guild.id].welcome) return
	const channel = client.guildsettings[member.guild.id].welcome.channelID
	const text = client.guildsettings[member.guild.id].welcome.message
	const img = client.guildsettings[member.guild.id].welcome.img_url
	const tnail = member.user.displayAvatarURL({ dynamic: true })


	if (channel === null) {
		return;
	}

	const mes = text.replace("{user}", member.user.username).replace("{server}", member.guild.name).replace("{tag}", member.user.tag).replace("{mention}", `<@${member.user.id}>`).replace("{rank}", member.guild.members.cache.size);

	const embed = new Discord.MessageEmbed()
		.setTitle(`Welcome to ${member.guild.name}`)
		.setDescription(`${mes}`)
		.setImage(img)
		.setThumbnail(tnail)
		.setColor("#56089e")



	client.channels.cache.get(channel).send({ content: `<@${member.id}>`, embeds: [embed] })
});

process.on("unhandledRejection", (reason, p) => {
	console.log(" [antiCrash] :: Unhandled Rejection/Catch");
	console.log(reason, p);
});
process.on("uncaughtException", (err, origin) => {
	console.log(" [antiCrash] :: Uncaught Exception/Catch");
	console.log(err, origin);
});
process.on("uncaughtExceptionMonitor", (err, origin) => {
	console.log(" [antiCrash] :: Uncaught Exception/Catch (MONITOR)");
	console.log(err, origin);
});
process.on("multipleResolves", (type, promise, reason) => {
	console.log(" [antiCrash] :: Multiple Resolves");
	console.log(type, promise, reason);
});

mongoose.connect(config.mongourl, {
	useNewUrlParser: true,
	useUnifiedTopology: true
})
	.then(console.log('Mongodb is Connected'))

// Login through the client
client.login(config.token);
