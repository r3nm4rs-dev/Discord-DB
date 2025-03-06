const { Intents, WebhookClient, MessageEmbed, MessageActionRow, MessageButton, Collection, Client, MessageSelectMenu} = require("discord.js");
const { Modal, TextInputComponent, SelectMenuComponent, showModal  } = require('discord-modals');


exports.run = async (client, message, args) => {

    const embed = new MessageEmbed()
    .setAuthor(`Pluzio Stealer - Ticket System`, ``)
    .setDescription(`Please Select Your Reason From The Menu Below.`)
    .setFooter(`@pluziostealer`)
    .setColor(0x303037)

    let button = new MessageActionRow()
    .addComponents(
        new MessageSelectMenu()
          .setCustomId('hype-tickets')
          .setPlaceholder('❯ Ticket Options')
          .addOptions([
            {
              label: 'Buy Licence',
              description: 'Click Me To Buy A Licence From Grabber',
              value: 'buy-grabber',
              emoji: `🛒`
            },
            {
                label: 'Replace Webhook',
                description: 'Click Me To Replace Webhook Of A Licence',
                value: 'replace-grabber',
                emoji: `📝`
            },
            {
                label: 'Support',
                description: 'Click Me To For Queries/Support.',
                value: 'support-grabber',
                emoji: `📪`
            }
        ])
    )

    await message.channel.send({ embeds: [embed], components: [button]})

}

exports.conf = { enabled: true, guildOnly: false, aliases: ["b","cg"], permLevel: 0 };

exports.help = { name: "tickets", description: "Ticket System For Stealer", usage: "tickets" };