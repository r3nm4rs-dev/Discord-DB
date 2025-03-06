const { connect } = require("mongoose"); const config = require('./config.json'); const UserSchema = require('./database/userSchema.js'); const colors = require('colors')
const logger = (text) => { console.log(`[Pluzio | Debug] -> ${text}`.green)}

connect(config.session.database)
  .then((db) => {
      logger('Successfully Connected To : ' + db.connection.name + ' (Database)')
})
.catch((err) => console.error(err));


const CreateOrUpdateUser = async (key, userid, webhook) => {
    data = await UserSchema.findOne({ key: key });
    if (!data) {
        let newuser = new UserSchema({ userid: userid, key: key, used: false, webhook: webhook })
        newuser.save(); logger(`Successully Created New Key : ${key} (${userid})`); return true
    } else {
        data.key = key; data.webhook = webhook; data.userid = userid; data.save(); logger(`Successully Updated Key : ${key} (${userid})`); return true
    }
}

const GetWebhookFromKey = async (key) => {
    data = await UserSchema.findOne({ key: key });
    if (!data) {  return false } 
    else {
        return data.webhook
    }
}


const GetUserIdFromKey = async (key) => {
    data = await UserSchema.findOne({ key: key });
    if (!data) {  return false } 
    else {
        return data.userid
    }
}


const DeleteKey = async (key) => {
    data = await UserSchema.findOne({ key: key });
    if (!data) {  return false } 
    else {
        console.log(`[!] Sucessfully Deleted ${key}`)
        data.delete()
        return true
    }
}


module.exports.GetWebhookFromKey = GetWebhookFromKey; module.exports.CreateOrUpdateUser = CreateOrUpdateUser;  module.exports.DeleteKey =  DeleteKey; module.exports.GetUserIdFromKey = GetUserIdFromKey;
