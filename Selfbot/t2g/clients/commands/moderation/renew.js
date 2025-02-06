module.exports = {
    name: "renew",
    description: "Verrouiller un salon",
    run: async (client, message, args) => {
  if (!message.member.permissions.has("MANAGE_CHANNELS")) {
    if(client.db.lang === "fr") message.edit("***Vous n'avez pas la permission de gérer les salons!***");
    if(client.db.lang === "en") message.edit("***You do not have permission to manage channels!***");
    return
  }
  
        const channel = message.mentions.channels.first() || message.channel;
        await message.guild.channels.fetch()

        try {
            let ee = await channel.clone({
                name: channel.name,
                permissions: channel.permissionsOverwrites,
                type: channel.type,
                topic: channel.withTopic,
                nsfw: channel.nsfw,
                birate: channel.bitrate,
                userLimit: channel.userLimit,
                rateLimitPerUser: channel.rateLimitPerUser,
                permissions: channel.withPermissions,
                position: channel.rawPosition,
                reason:  `Salon recréé par ${message.author.tag} (${message.author.id})`
            })
            channel.delete().catch(async () => {
                ee.delete() && message.delete()
            })
    
      } catch (err) {
        console.log(err);
      }}}
  