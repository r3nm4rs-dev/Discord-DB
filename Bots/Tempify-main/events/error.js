const { Events } = require('discord.js');

module.exports = {
    name: 'error',
    execute(error) {
        console.error('❌ Une erreur est survenue:', error);
    }
};