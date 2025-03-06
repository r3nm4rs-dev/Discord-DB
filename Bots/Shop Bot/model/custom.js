const mongoose = require('mongoose');

const CustomSchema = new mongoose.Schema({
    servername: String,
    message: String,
    response: String,
    guildID: String
});

module.exports = mongoose.model('customs', CustomSchema);
