const mongoose = require('mongoose');

const InviteSchema = new mongoose.Schema({
    servername: String,
    userID: String,
    joiner: {
      type: Array,
      default: []
    },
    regular: Number,
    left: Number,
    fake: Number,
    guildID: String
});

module.exports = mongoose.model('invites', InviteSchema);
