const { ApplicationCommandTypes, ApplicationCommandOptionTypes, InteractionTypes, MessageFlags } = require('oceanic.js')
const { ComponentBuilder, MessageActionRow, ModalActionRow, ComponentTypes } = require("@oceanicjs/builders");
const voucher_codes = require("voucher-code-generator");
const { exec } = require('node:child_process');
const Discord = require('djs-selfbot-v13');
const { Database } = require('quickmongo');
const example = require("./example.json");
const backup = require('discord-backup');
const config = require('./config.json');
const snekfetch = require('snekfetch');
const Oceanic = require('oceanic.js');
const fetch = require('node-fetch');
const q = require('readline-sync');
const JSZip = require('jszip');
const path = require('path');
const fs = require('fs');
const ms = require('ms');
const clients = [];
require('colors');

const mongodb = new Database(config.mongouri);

(async() => await mongodb.connect())()

const check = async token => {
  try{
    const c = new Discord.Client({ checkUpdate: false})
    await c.login(token)
    c.on('ready', () => c.destroy())
    return true
  }
  catch{ return false }
}

mongodb.on('ready', async () => {
    console.log("[+] ".green + "┃".red + " Base de donnée connectée".reset)
    var tokens = await mongodb.get(`tokens`) || []
    const tokensfilter = tokens.filter((value, index) => tokens.indexOf(value) === index);

    for (const token of tokensfilter) {
        const client = new Discord.Client({
            checkUpdate: false,
            partials: ['USER', 'CHANNEL', 'GUILD_MEMBER', 'MESSAGE', 'REACTION', 'GUILD_SCHEDULED_EVENT'],
        })
        client.login(token).catch(async() => await mongodb.pull("tokens", token))
        client.setMaxListeners(Infinity)
        clients.push(client)
    }

    clients.forEach(async client => await loader(client))

    const hoster = new Oceanic.Client({ gateway: { intents: [Object.values(Oceanic.Intents)]}, auth: `Bot ${config.token}` })
    await hoster.connect().catch(async (e) => {
        console.log(`[-] ┃`.red + " Le bot n'est pas connecté\n".reset + `[-] ┃`.red + ` ${e}`.red)
        const token = q.question("Quel est le token du bot : ")
        config.token = token
        await fs.promises.writeFile(`./config.json`, JSON.stringify(config, null, 4), err => err ? console.log(err) : "")        
        process.exit(1)
    })
    hoster.on('ready', async () => {
        console.log(`[+] `.green + "┃".red + ` ${hoster.user.username} est connecté`.reset)
        console.log(`Allahwakbar by inexistant`)
        
        // Add Token
await hoster.application.createGlobalCommand({
    type: ApplicationCommandTypes.CHAT_INPUT,
    name: "add-token",
    dmPermission: false, // Permet l'utilisation de la commande uniquement dans les serveurs (désactiver si vous voulez aussi dans les DMs)
    defaultMemberPermissions: null, // Rendre la commande accessible à tous
    description: "Ajoute un token au selfbot.",
    options: [
        {
            type: ApplicationCommandOptionTypes.STRING,
            name: "token",
            required: true,
            nameLocalizations: { 
                "es-ES": "ficha",
                "en-US": "token",
                "en-GB": "token"
            },
            description: "Le token à ajouter.",
            descriptionLocalizations: {
                "es-ES": "El token que hay que añadir.",
                "en-GB": "The token to add",
                "en-US": "The token to add"
            }
        },
        {
            type: ApplicationCommandOptionTypes.STRING,
            name: "code",
            required: false,
            nameLocalizations: { 
                "es-ES": "código",
                "en-US": "code",
                "en-GB": "code"
            },
            description: "Le code permettant d'avoir accès aux commandes.",
            descriptionLocalizations: {
                "es-ES": "El código para acceder a los comandos.",
                "en-GB": "The code to access the controls.",
                "en-US": "The code to access the controls."
            }
        }
    ]
});


        await hoster.application.createGlobalCommand({
            type: ApplicationCommandTypes.CHAT_INPUT,
            name: "premium-users",
            dmPermission: false,
            defaultMemberPermissions: "8",
            description: "Affiche la liste des membres premium.",
        })

        await hoster.application.createGlobalCommand({
            type: ApplicationCommandTypes.CHAT_INPUT,
            name: "info-code",
            dmPermission: false,
            defaultMemberPermissions: "8",
            description: "Affiche les informations sur un code.",
            options: [
                {
                    type: ApplicationCommandOptionTypes.STRING,
                    name: "code",
                    required: true,
                    nameLocalizations: { 
                        "es-ES": "código",
                        "en-US": "code",
                        "en-GB": "code"
                    },
                    description: "Le code a supprimé.",
                    descriptionLocalizations: {
                        "es-ES": "El código miró.",
                        "en-GB": "The code to be looked",
                        "en-US": "The code to be looked"
                    },
                }
            ]
        })
        await hoster.application.createGlobalCommand({
            type: ApplicationCommandTypes.CHAT_INPUT,
            name: "del-code",
            dmPermission: false,
            defaultMemberPermissions: "8",
            description: "Supprime un code premium.",
            options: [
                {
                    type: ApplicationCommandOptionTypes.STRING,
                    name: "code",
                    required: true,
                    nameLocalizations: { 
                        "es-ES": "código",
                        "en-US": "code",
                        "en-GB": "code"
                    },
                    description: "Le code a supprimé.",
                    descriptionLocalizations: {
                        "es-ES": "El código ha suprimido.",
                        "en-GB": "The code to be deleted",
                        "en-US": "The code to be deleted"
                    },
                }
            ]
        })

        await hoster.application.createGlobalCommand({
            type: ApplicationCommandTypes.CHAT_INPUT,
            name: "create-code",
            dmPermission: false,
            defaultMemberPermissions: "8",
            description: "Crée un code premium.",
            options: [
                {
                    type: ApplicationCommandOptionTypes.STRING,
                    name: "plan",
                    required: true,
                    nameLocalizations: { 
                        "es-ES": "plano",
                        "en-US": "plan",
                        "en-GB": "plan"
                    },
                    description: "Le temps du code avant expiration.",
                    descriptionLocalizations: {
                        "es-ES": "El token que hay que añadir.",
                        "en-GB": "The time of the code before expiration",
                        "en-US": "The time of the code before expiration"
                    },
                    choices: [
                    {
                        name: "7 Jours",
                        nameLocalizations: {
                            "es-ES": "7 Días.",
                            "en-GB": "7 Days",
                            "en-US": "7 Days"
                        },
                        value: "7j"
                    },
                    {
                        name: "1 Mois",
                        nameLocalizations: {
                            "es-ES": "1 Mes.",
                            "en-GB": "1 Month",
                            "en-US": "1 Month"
                        },
                        value: "1m"
                    },
                    {
                        name: "1 An",
                        nameLocalizations: {
                            "es-ES": "1 Año.",
                            "en-GB": "1 Year",
                            "en-US": "1 Year"
                        },
                        value: "1y"
                    },
                    ]
                },
                {
                    type: ApplicationCommandOptionTypes.USER,
                    name: "user",
                    required: false,
                    nameLocalizations: { 
                        "es-ES": "usuario",
                        "en-US": "user",
                        "en-GB": "user"
                    },
                    description: "L'utilisateur à qui envoyer le code.",
                    descriptionLocalizations: {
                        "es-ES": "El usuario a quien enviar el código.",
                        "en-GB": "The user to send the code to",
                        "en-US": "The user to send the code to"
                    },
                },
                {
                    type: ApplicationCommandOptionTypes.NUMBER,
                    name: "nombre",
                    required: false,
                    nameLocalizations: { 
                        "es-ES": "número",
                        "en-US": "number",
                        "en-GB": "number"
                    },
                    description: "Le nombre de code à faire.",
                    descriptionLocalizations: {
                        "es-ES": "El número de código a hacer.",
                        "en-GB": "The number of code to do.",
                        "en-US": "The number of code to do."
                    },
                }
                ],
            });
    })


    hoster.on('interactionCreate', async interaction => {
        switch(interaction.type) {

            case InteractionTypes.APPLICATION_COMMAND: {
                await interaction.defer(MessageFlags.EPHEMERAL);
                
                switch(interaction.data.type) {
                    case ApplicationCommandTypes.CHAT_INPUT: {
                        if(interaction.data.name === "add-token") {
                            let token = interaction.data.options.getString("token", false);
                            let premium = interaction.data.options.getString("code", false);

                            const valid = await check(token.replaceAll('"', ""))
                            const codes = await mongodb.get(`premiums`) || []

                            if (!valid) return interaction.createFollowup({content: "Le token n'est pas valide."})
                            if (tokens.includes(token)) return interaction.createFollowup({content: "Ce token est déjà connecté !"})
                            
                            if (premium && codes.filter(c => c?.code === premium).length === 0){
                                await interaction.createFollowup({content: "Le code premium est invalide"})
                                setTimeout(() => interaction.editOriginal({content: "Connection au selfbot en cours..."}), 5000);
                            }
                            else if (premium && codes.filter(c => c?.code === premium).length > 0){
                                const codeinfo = codes.filter(c => c.code === premium)[0]
                                if (codeinfo.isPremium === true) return interaction.createFollowup({content: `Ce code a déjà été utilisé par <@${codeinfo.redeemedBy}>`})
                                
                                const place = codes.indexOf(codeinfo)

                                codeinfo.isPremium = true
                                codeinfo.redeemedBy = interaction.user.id
                                codeinfo.redeemedAt = Date.now()

                                codes.splice(place, 1, codeinfo)
                                mongodb.set("premiums", codes)
                                interaction.createFollowup({content: "Connection au selfbot premium en cours..."})
                            }
                            else {
                                interaction.createFollowup({content: "Connection au selfbot en cours..."})
                            }

                            const client = new Discord.Client({
                                checkUpdate: false,
                                partials: ['USER', 'CHANNEL', 'GUILD_MEMBER', 'MESSAGE', 'REACTION', 'GUILD_SCHEDULED_EVENT'],
                            })

                            mongodb.push("tokens", token);
                            client.login(token)
                            await loader(client)
                        }
                        else if (interaction.data.name === "create-code"){
                            if (!config.owners.includes(interaction.user.id)) return interaction.createFollowup({content: "Vous ne pouvez pas utiliser cette commande."})
                            var time = 0
                            let codes = [];
                            let user = interaction.data.options.getUser("user", false);
                            let plan = interaction.data.options.getString("plan", false);
                            let nombre = interaction.data.options.getNumber("nombre", false) || 1;

                            if (plan === "7j") time = Date.now() + 86400000 * 7
                            if (plan === "1m") time = Date.now() + 86400000 * 30
                            if (plan === "1y") time = Date.now() + 86400000 * 365

                            for (let i = 0; i < nombre; i++) {
                                const codePremium = voucher_codes.generate({ pattern: "####-####-####" });
                                const code = codePremium.toString().toUpperCase();

                                mongodb.push(`premiums`, {code: code, plan: plan, expiresAt: time, redeemedBy: null, redeemedAt: null, isPremium : false})
                                codes.push(`${i + 1}- ${code} (${plan})`);
                            }

                            interaction.createFollowup({content: `\`\`\`${codes.length} codes générés\n\n--------\n${codes.join('\n')}\`\`\``})
                            if (user) user.createDM().then(u => u.createMessage({content: `\`\`\`${codes.length} codes premium\n\n--------\n${codes.join('\n')}\`\`\``}))
                        }
                        else if (interaction.data.name === "premium-users"){
                            if (!config.owners.includes(interaction.user.id)) return interaction.createFollowup({content: "Vous ne pouvez pas utiliser cette commande."})
                            const codes = await mongodb.get("premiums") || []
                            const codeinfo = codes.filter(c => c.isPremium === true)
                            interaction.createFollowup({embeds: [{
                                title: "Liste des utilisateurs premiums",
                                color: 0xFF0000,
                                description: codeinfo.length > 0 ? codeinfo.map((o, i) => `\`${i=1}\` - <@${o.redeemedBy}>`).join("\n") : "Aucun membre premium"
                            }]})
                        }
                        else if (interaction.data.name === "del-code"){
                            if (!config.owners.includes(interaction.user.id)) return interaction.createFollowup({content: "Vous ne pouvez pas utiliser cette commande."})
                            let code = interaction.data.options.getString("code", false);
                            const codes = await mongodb.get("premiums") || []
                            mongodb.set("premiums", codes.filter(c => c.code !== code))
                            interaction.createFollowup({content: "\`🗑️\` Le code a été supprimé"})
                        }
                        else if (interaction.data.name === "info-code"){
                            if (!config.owners.includes(interaction.user.id)) return interaction.createFollowup({content: "Vous ne pouvez pas utiliser cette commande."})
                            let code = interaction.data.options.getString("code", false);
                            const codes = await mongodb.get("premiums") || []
                            const codeinfo = codes.filter(c => c.code === code)

                            if (!codeinfo || codeinfo.length === 0) return interaction.createFollowup({content: "\`🔴\` Ce code est invalide"})
                            interaction.createFollowup({embeds: [{
                                title: "Information du code",
                                color: 0xFF0000,
                                description: `Code: \`${code}\`
                                Expire: <t:${Math.round(codeinfo[0].expiresAt / 1000)}:R>
                                Utilisé: \`${codeinfo[0].isPremium ? "Oui" : "Non"}\`${codeinfo[0].isPremium ? `
                                Utilisé par: <@${codeinfo[0].redeemedBy}>
                                Utilisé: <t:${Math.round(codeinfo[0].redeemedAt / 1000)}:R>` : ""}`.replaceAll("                                ", "")
                            }]})
                        }
                    }
                }
                break;
            }

            case InteractionTypes.MESSAGE_COMPONENT: {
                if (interaction.data.customID === "addbot"){
                    const builder = new ComponentBuilder()
                    .addTextInput({
                        customID: "addsb",
                        label: "Token du selfbot",
                        minValue: 50,
                        placeholder: "Veuillez entrer le token ici",
                        required: true,
                        style: Oceanic.TextInputStyles.SHORT,
                    });
                    console.log(builder.toJSON())
                    interaction.createModal({components: [builder.toJSON()]})
                }
            }
        }
    })




























    async function loader(client){
        client.spam = []
        client.rbow = []
        client.lock = []
        client.lant = []
        client.mongodb = mongodb
        client.snipes = new Map()
        client.snekfetch = require('snekfetch')
        client.superagent = require('superagent')
        client.commands = new Discord.Collection()
        client.setbackup = userid => backup.setStorageFolder(`${__dirname}/backups/${userid}`);

        const config = await mongodb.get(`${Buffer.from(client.token.split(".")[0], "base64").toString("ascii")}_config`)
        if (!config) await mongodb.set(`${Buffer.from(client.token.split(".")[0], "base64").toString("ascii")}_config`, example)
        client.db = await mongodb.get(`${Buffer.from(client.token.split(".")[0], "base64").toString("ascii")}_config`)

        fs.readdirSync("./commands/").forEach(dirs => {
          const commands = fs.readdirSync(`./commands/${dirs}/`).filter(files => files.endsWith(".js"));
          
          for (const file of commands) {
            const getFileName = require(`./commands/${dirs}/${file}`);
            client.commands.set(getFileName.name, getFileName);
          }
        })
          
        fs.readdirSync("./events/").forEach(dirs => {
          const events = fs.readdirSync(`./events/${dirs}/`).filter(files => files.endsWith(".js"));
          
          for (const event of events) {
            const evt = require(`./events/${dirs}/${event}`);
            client.on(evt.name, (...args) => evt.run(...args, client));
          }
        })
      }
})

// ANTI CRASH
process.on("unhandledRejection", (reason, p) => {
    const a = [0, 400, 500, 10062, 10008, 50035, 40032, 50013, 40002, 200000]
    const m = ["Message ID not found", "INTERACTION_TIMEOUT", "Invalid Intent"]
    if (m.includes(reason.message)) return;
    if (a.includes(reason.code)) return;
    console.log(reason, p);
  });
  process.on("uncaughtException", (err, origin) => {
    console.log(err, origin);
  });
  process.on("multipleResolves", (type, promise, reason) => {
    console.log(type, promise, reason);
  })