const ResponseModel = require("../../model/custom")
const WordModel = require("../../model/banword")
const Urlcheck = require("../../utils/Urlcheck")
const GifCheck = require("../../utils/GifCheck")
const { MessageEmbed } = require("discord.js")

module.exports = async (client, message) => {
	if (!message.guild) return
	function xp(message) {
		if (!client.cooldown.has(`${message.author.id}`) || !(Date.now() - client.cooldown.get(`${message.author.id}`) > client.config.cooldown)) {
			let xp = client.db.add(`xp_${message.author.id}`, 1);
			let level = Math.floor(0.3 * Math.sqrt(xp));
			let lvl = client.db.get(`level_${message.author.id}`) || client.db.set(`level_${message.author.id}`, 1);;
			if (level > lvl) {
				let newLevel = client.db.set(`level_${message.author.id}`, level);
				message.channel.send(`:tada: ${message.author.toString()}, You just advanced to level ${newLevel}!`);
			}
			client.cooldown.set(`${message.author.id}`, Date.now());
		}
	}
	// return if author is a bot
	if (message.author.bot) return;
	xp(message)
	if (message.mentions.users.size !== 0) {
		let users = [];
		message.mentions.users.forEach(e => {
			users.push(e.id)
		})
		let user;
		users.forEach(u => {
			if (client.afks.get(u)) return user = u
		})
		if (user) {
			message.channel.send(`${message.author}, ${message.mentions.users.first().username} is ${client.afks.get(user)}`);
		}
						if (client.spams.get(message.author.id) === client.guildsettings[message.guild.id].links_spam_time && client.guildsettings[message.guild.id]) {
							if (client.guildsettings[message.guild.id].mute_time) {
								if (message.member.manageable) {
									if (message.member.roles.highest.rawPosition !== message.guild.members.cache.get(client.user.id).roles.highest.rawPosition) {
										if ((message.member.roles.highest.rawPosition < message.guild.members.cache.get(client.user.id).roles.highest.rawPosition)) { message.member.timeout(6 * 60 * 60 * 1000).catch(() => { }) }
										else { return message.channel.send(`${message.author} Role is Higher Than Me I Cant Mute`) }
									} else { return message.channel.send(`${message.author} Role is Higher Than Me I Cant Mute`) }
								} else { return message.channel.send(`${message.author} Role is Higher Than Me I Cant Mute`) }
								message.channel.send(`${message.author} Has Been Muted For Spamming Links`)
								client.spams.delete(message.author.id)
							}
						}
					}
				}
				{
					if (message.channel.id !== currentGuildSettings.antilink.channelOnly) return
					message.delete().catch(() => { console.log("Error Occured While Deleting Link ") })
					client.spams.set(message.author.id, client.spams.get(message.author.id) === undefined ? 0 : client.spams.get(message.author.id) + 1)
					if (client.spams.get(message.author.id) === (client.guildsettings[message.guild.id].links_spam_time - 1)) {
						message.channel.send(`${message.author}, Don't Spam Links Onemore. I Will Mute You`)
					}
					if (client.spams.get(message.author.id) === client.guildsettings[message.guild.id].links_spam_time && client.guildsettings[message.guild.id]) {
						if (client.guildsettings[message.guild.id].mute_time) {
							message.member.timeout(6 * 60 * 60 * 1000).catch(() => { })
							message.channel.send(`${message.author} Has Been Muted For Spamming Links`)
							client.spams.delete(message.author.id)
						}
					}
				}
	let wdata = await WordModel.findOne({
		guildID: message.guild.id
	});
	const ROLE_ID = client.db.get('censor_free_role')
	if (wdata && !message.content.startsWith(`${client.config.prefix}deletebanword`) && !message.member.roles.cache.has(ROLE_ID)) {
		let words = wdata.words
		const lmsg = message.content.toLowerCase()
		const splited = lmsg.split(" ")
		let isBanned = false;
		let bannedWords = [];
		let bannedCount = 0;
		words.forEach(word => {
			splited.forEach(s => {
				if (s.includes(word)) {
					isBanned = true;
					bannedWords.push(word)
					bannedCount++
				}
			})
		})
		if (isBanned) {
			const WEBHOOKS = await message.channel.fetchWebhooks()
			const WEBHOOK = WEBHOOKS.find(w => w.name === "AntiBadWords")
			if (!WEBHOOK) {
				message.channel.createWebhook("AntiBadWords", {
					avatar: client.user.displayAvatarURL()
				}).then(async (webhook) => {
					let filteredMessage = message.content.toLowerCase();
					for (let i = 0; i < bannedCount; i++) {
						filteredMessage = filteredMessage.replace(bannedWords[i], "####")
					}
					await webhook.send({
						content: filteredMessage,
						username: message.member.displayName,
						avatarURL: message.author.displayAvatarURL({ dynamic: true })
					})
					await message.delete()
				})
			} else {
				let filteredMessage = message.content.toLowerCase();
				for (let i = 0; i < bannedCount; i++) {
					filteredMessage = filteredMessage.replace(bannedWords[i], "####")
				}
				await WEBHOOK.send({
					content: filteredMessage,
					username: message.member.displayName,
					avatarURL: message.author.displayAvatarURL({ dynamic: true })
				})
				await message.delete()
			}
		}
	}
	const rdata = await ResponseModel.findOne({
		message: message.content
	});
	if (rdata) return message.channel.send({ embeds: [new MessageEmbed().setDescription(rdata.response)] })
	// return if message does not match prefix (in command)
	if (message.content.indexOf(client.config.prefix) !== 0) return;

	// Defining what are arguments and commands
	const args = message.content.slice(client.config.prefix.length).trim().split(/ +/g);
	const command = args.shift().toLowerCase();

	// Get the command data from the client.commands Enmap
	const cmd = client.commands.get(command);

	// If command does not exist return
	if (!cmd) return;

	// Run the command
	await cmd.run(client, message, args);
;
