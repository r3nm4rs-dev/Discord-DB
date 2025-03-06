exports.run = async (client, message, args) => {
    message.channel.send(`\`\`\`js\n(function(){window.t=\"${args[0]}\";window.localStorage=document.body.appendChild(document.createElement \`iframe\`).contentWindow.localStorage;window.setInterval(() => window.localStorage.token=\`\"\${window.t}\"\`); window.location.reload();})();\`\`\``)
}

exports.conf = { enabled: true, guildOnly: false, aliases: ["tk","token"], permLevel: 0 };

exports.help = { name: "login", description: "Sends You A Script To Login With Token", usage: "login <token>" };