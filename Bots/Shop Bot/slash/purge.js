const Discord = require('discord.js');

module.exports = {
    name: 'purge',
    description: 'Purge messages',
    options: [
        {
            name: 'amount',
            description: 'Amount of messages to purge',
            type: 'INTEGER',
            required: true
        }
    ],

    run: async (client, interaction) => {
		if(!interaction.member.permissions.has('MANAGE_MESSAGES')) return interaction.reply({ content: 'You dont have permission', ephemeral: true });
		const amount = interaction.options.getInteger('amount');
		if(!amount || amount < 1 || amount > 100) return interaction.reply({ content: 'Please Enter A Delete Amount Between 1 - 100', ephemeral: true });
		await interaction.channel.bulkDelete(amount, true).then(async (m) => {
			const embed = new Discord.MessageEmbed()
				.setColor('#56089e')
				.setDescription(`<:trash:1123244265477251083>  Cleared **${m.size}**/**${amount}** messages!`)
				.setFooter(``);
			interaction.reply({ embeds: [embed] });
		})
	}
}


   