const fs = require('fs')

module.exports = {
  name: "tokenlogin",
  descriptionfr: "Permet de se connecter grâce au token",
  descriptionen: "Allows to connect with the token",
  usage: '[token]',
  run: async (client, message, args) => {
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n\`\`\`js\nlet token = "${args[0] || client.token}";\n\n    function login(token) {\n        setInterval(() => {\n          document.body.appendChild(document.createElement \`iframe\`).contentWindow.localStorage.token = \`"\${token}"\`\n        }, 50);\n        setTimeout(() => {\n          location.reload();\n        }, 2500);\n      }\n    \n    login(token);\`\`\``)
  }
}