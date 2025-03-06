const Discord = require('discord.js');

module.exports = {
    name: 'reset_all_level',
    description: 'Reset all level',
    options: [
        {
            name: 'confirm',
            description: 'Confirm to reset all level',
            type: 'BOOLEAN',
            required: true
        }
    ],

    run: async (client, interaction) => {
		if (!interaction.member.permissions.has('ADMINISTRATOR')) return interaction.reply({ content: 'You dont have permission', ephemeral: true });
		let ldata = client.db.all().filter(i => i.ID.startsWith("level_")).sort((a, b) => b.data - a.data);
		let xdata = client.db.all().filter(i => i.ID.startsWith("xp_")).sort((a, b) => b.data - a.data);
		for (let i of ldata) {
			client.db.set(i.ID, 0)
		}
		for (let j of xdata) {
			client.db.set(j.ID, 0)
		}
		return interaction.reply({ content: 'Everyones, Levels Were Reset!', ephemeral: true });
	}
}

