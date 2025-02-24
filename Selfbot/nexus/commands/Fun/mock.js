module.exports = {
    name: 'mock',
    description: 'Parodiez le texte que vous fournissez !',
    run: async (client, message, args) => {
        if (!args.length) {
            return message.reply('Veuillez fournir du texte à parodier !');
        }
        const text = args.join(' ');
        const mocked = text.split('').map((char, index) => 
            index % 2 ? char.toUpperCase() : char.toLowerCase()
        ).join('');
        message.edit(mocked);
    }
};
