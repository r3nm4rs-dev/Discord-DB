const fs = require('fs')

module.exports = {
  name: "experiments",
  descriptionfr: "Activer les experiences discord",
  descriptionen: "Activate the discord experiences",
  run: async (client, message, args) => {
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n\`\`\`js\nlet wpRequire;\n    window.webpackChunkdiscord_app.push([[ Math.random() ], {}, (req) => { wpRequire = req; }]);\n    mod = Object.values(wpRequire.c).find(x => typeof x?.exports?.Z?.isDeveloper !== "undefined");\n    usermod = Object.values(wpRequire.c).find(x => x?.exports?.default?.getUsers)\n    nodes = Object.values(mod.exports.Z._dispatcher._actionHandlers._dependencyGraph.nodes)\n    try {\n        nodes.find(x => x.name == "ExperimentStore").actionHandler["OVERLAY_INITIALIZE"]({user: {flags: 1}})\n    } catch (e) {}\n    oldGetUser = usermod.exports.default.__proto__.getCurrentUser;\n    usermod.exports.default.__proto__.getCurrentUser = () => ({isStaff: () => true})\n    nodes.find(x => x.name == "DeveloperExperimentStore").actionHandler["CONNECTION_OPEN"]()\n    usermod.exports.default.__proto__.getCurrentUser = oldGetUser\`\`\``)
  }
}