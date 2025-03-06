const canvacord = require("canvacord");
const { MessageAttachment } = require("discord.js");

module.exports = {
    name: "level",
    description: "Shows your level",
    options: [
        {
            name: "user",
            description: "The user to show the level of.",
            type: "USER",
            required: false
        }
    ],

    run: async (client, interaction) => {
		let user = interaction.options.getUser("user") || interaction.user;

		let level = client.db.get(`level_${user.id}`) || 0;
		let exp = client.db.get(`xp_${user.id}`) || 0;
		let neededXP = Math.floor(Math.pow(level / 0.1, 2));

		let every = client.db.all().filter(i => i.ID.startsWith("xp_")).sort((a, b) => b.data - a.data);
		let rank = every.map(x => x.ID).indexOf(`xp_${user.id}`) + 1;

		// v4 rank card
		//   let img = await canvacord.rank({
		//     username: user.username,
		//     discrim: user.discriminator,
		//     currentXP: exp.toString(),
		//     neededXP: neededXP.toString(),
		//     rank: rank.toString(),
		//     level: level.toString(),
		//     avatarURL: user.displayAvatarURL({ format: "png" }),
		//     background: "https://images.unsplash.com/photo-1523821741446-edb2b68bb7a0?ixlib=rb-1.2.1&w=1000&q=80"
		//   });
		const card = new canvacord.Rank()
			.setUsername(user.username)
			.setDiscriminator(user.discriminator)
			.setRank(rank)
			.setLevel(level)
			.setCurrentXP(exp)
			.setRequiredXP(neededXP)
			.setBackground("IMAGE", "https://media.discordapp.net/attachments/1000006890790592592/1029390145230753812/20221011_191819.jpg?width=962&height=290")
			.setAvatar(user.displayAvatarURL({ format: "png", size: 1024 }));

		const img = await card.build();

		return interaction.reply({files: [new MessageAttachment(img, "rank.png")]});
	}
}