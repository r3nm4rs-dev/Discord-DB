module.exports = {
    name: "help",
    run: async(client, message) => {
        let title = client.db.nitro === true ? '<:user:1275726935816929366>' : '✠'
        let arrow = client.db.nitro === true ? ' <:arrow:1274251907002667038> ' : '・'
        let msg = client.db.lang === 'fr' 
    ? `» __**T2G**__ ${title}\n\n` +
      `***Help utilitaire***${arrow}\`${client.db.prefix}utility\`\n` +
      `***Help fun***${arrow}\`${client.db.prefix}fun\`\n` +
      `***Help moderation***${arrow}\`${client.db.prefix}moderation\`\n` +
      `***Help backup***${arrow}\`${client.db.prefix}backup\`\n` +
      `***Help vanity***${arrow}\`${client.db.prefix}vanity\`\n` +
      `***Help vocal***${arrow}\`${client.db.prefix}voice\`\n\n` +
      `***Help status***${arrow}\`${client.db.prefix}status\`\n` +
      `***Help RPC***${arrow}\`${client.db.prefix}rpc\`\n` +
      `***Help Spotify***${arrow}\`${client.db.prefix}spotify\`\n\n` +
      `***Help logs***${arrow}\`${client.db.prefix}logs\`\n` +
      `***Help groupe***${arrow}\`${client.db.prefix}group\`\n` +
      `***Help paramètres***${arrow}\`${client.db.prefix}settings\``
    : `» __**T2G**__ ${title}\n\n` +
      `***Utility help***${arrow}\`${client.db.prefix}utility\`\n` +
      `***Fun help***${arrow}\`${client.db.prefix}fun\`\n` +
      `***Moderation help***${arrow}\`${client.db.prefix}moderation\`\n` +
      `***Backup help***${arrow}\`${client.db.prefix}backup\`\n` +
      `***Vanity help***${arrow}\`${client.db.prefix}vanity\`\n` +
      `***Voice help***${arrow}\`${client.db.prefix}voice\`\n\n` +
      `***Status help***${arrow}\`${client.db.prefix}status\`\n` +
      `***RPC help***${arrow}\`${client.db.prefix}rpc\`\n` +
      `***Spotify help***${arrow}\`${client.db.prefix}spotify\`\n\n` +
      `***Logs help***${arrow}\`${client.db.prefix}logs\`\n` +
      `***Group help***${arrow}\`${client.db.prefix}group\`\n` +
      `***Settings help***${arrow}\`${client.db.prefix}settings\``;

message.edit(msg)
    }
}