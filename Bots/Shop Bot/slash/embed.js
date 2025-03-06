const Discord = require('discord.js');

module.exports = {
	name: 'embed',
	description: 'Create Embeds With Options!',
	options: [
		{
			name: 'channel',
			description: 'The Channel To Send The Embed In',
			type: 'CHANNEL',
			channel_types: ['0'],
			required: true
		},
		{
			name: 'title',
			description: 'The Title Of The Embed',
			type: 'STRING',
			required: true
		},
		{
			name: 'description',
			description: 'The Description Of The Embed',
			type: 'STRING',
			required: true
		},
		{
			name: 'color',
			description: 'The Color Of The Embed in Hex',
			type: 'STRING',
			required: true
		},
		{
			name: 'thumbnail',
			description: 'The Thumbnail Url Of The Embed',
			type: 'STRING',
			required: true
		},
		{
			name: 'image',
			description: 'The Image Url Of The Embed',
			type: 'STRING',
			required: true
		},
		{
			name: 'field1_name',
			description: 'The Field Name Of The Field 1',
			type: 'STRING',
			required: true
		},
		{
			name: 'field1_value',
			description: 'The Field Value Of The Field 1',
			type: 'STRING',
			required: true
		},
		{
			name: 'field2_name',
			description: 'The Field Name Of The Field 2',
			type: 'STRING',
			required: false
		},
		{
			name: 'field2_value',
			description: 'The Field Value Of The Field 2',
			type: 'STRING',
			required: false
		},
		{
			name: 'field3_name',
			description: 'The Field Name Of The Field 3',
			type: 'STRING',
			required: false
		},
		{
			name: 'field3_value',
			description: 'The Field Value Of The Field 3',
			type: 'STRING',
			required: false
		},
	],
	async run(client, interaction) {
		await interaction.deferReply({ ephemeral: true });
		const channel = interaction.options.getChannel('channel');
		const title = interaction.options.getString('title');
		const description = interaction.options.getString('description');
		const color = interaction.options.getString('color');
		const thumbnail = interaction.options.getString('thumbnail');
		const image = interaction.options.getString('image');
		const field1_name = interaction.options.getString('field1_name');
		const field1_value = interaction.options.getString('field1_value');
		const field2_name = interaction.options.getString('field2_name');
		const field2_value = interaction.options.getString('field2_value');
		const field3_name = interaction.options.getString('field3_name');
		const field3_value = interaction.options.getString('field3_value');

		const embed_role_id = client.db.get('embed_role');
		if (!embed_role_id) {
			return await interaction.editReply({
				content: 'There is no embed role set',
				ephemeral: true
			});
		}
		const embed_role = interaction.guild.roles.cache.get(embed_role_id);
		if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR') && !interaction.member.roles.cache.has(embed_role.id)) {
			return await interaction.editReply({
				content: 'You do not have permissions to use this command',
				ephemeral: true
			});
		}
		
		const embed = new Discord.MessageEmbed()
			.setTitle(title)
			.setDescription(description)
			.setColor(color)
			.setThumbnail(thumbnail)
			.setImage(image)
			.addField(field1_name, field1_value)

		if (field2_name && field2_value) {
			embed
				.addField(field2_name, field2_value)
		}
		if (field3_name && field3_value) {
			embed
				.addField(field3_name, field3_value)
		}

		try {
			await channel.send({ embeds: [embed] });
			await interaction.editReply({ content: 'Embed Sent!', ephemeral: true });
		}
		catch (error) {
			console.log(error);
			await interaction.editReply({ content: 'There Was An Error While Executing This Command!', ephemeral: true });
		}
	}
}