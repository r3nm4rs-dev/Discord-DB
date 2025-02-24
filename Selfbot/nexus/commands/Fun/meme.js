const fetch = require('node-fetch');

module.exports = {
    name: 'meme',
    description: 'Obtenez un meme aléatoire !',
    run: async (client, message, args) => {
        const res = await fetch('https://meme-api.herokuapp.com/gimme');
        const meme = await res.json();
        message.edit(meme.url);
    }
};
