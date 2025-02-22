const Discord = require('discord.js')
const config = require('../config')
const db = require('quick.db')
const cl = new db.table("Color")

module.exports = {
    name: 'ready',
    once: true,

    async execute(client) {
        console.log(`NOM > ${client.user.username}`)
        console.log(`ID > ${client.user.id}\n`
            + `Invitation > https://discord.com/oauth2/authorize?client_id=${client.user.id}&scope=bot&permissions=8`)
        }
    }
