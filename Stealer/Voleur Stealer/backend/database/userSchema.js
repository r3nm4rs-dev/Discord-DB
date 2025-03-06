const mongoose = require("mongoose");

const user = mongoose.Schema({
  userid: String, key: String, used: Boolean, webhook: String
});

module.exports = mongoose.model("PremiumSchee", user);