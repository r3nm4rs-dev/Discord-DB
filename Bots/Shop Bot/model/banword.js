const mongoose = require('mongoose');

const BanWord = new mongoose.Schema({
    servername: String,
    words: {
      type: Array,
      default: ["Fuck"]
    },
    guildID: String
});

module.exports = mongoose.model('banwords', BanWord);