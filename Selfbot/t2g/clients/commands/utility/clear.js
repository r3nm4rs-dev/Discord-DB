module.exports = {
    name: "clear",
    description: "Clear a channel",
    dev: true,
    run: async (client, message, args) => {
      try{
        const chn = await client.channels.fetch(args[0]).catch(() => false)
        if(chn) {
            await message.delete().catch(() => false);

            const nombre = 9999999;
            let i = 0;

            const totalMessages = await chn.messages.fetch({ limit: nombre > 100 ? 100 : nombre });

            for (const singleMessage of totalMessages.values()) {
                if (singleMessage.author.id === client.user.id) {
                    await new Promise(resolve => setTimeout(resolve, 700));

                    await singleMessage.delete().catch(err => { });
                    i++;
                }
            }

            let remainingMessages = nombre - 100;
            while (remainingMessages > 0) {
                const additionalMessages = await chn.messages.fetch({ limit: remainingMessages > 100 ? 100 : remainingMessages, before: totalMessages.lastKey() });
                
                for (const singleMessage of additionalMessages.values()) {
                    if (singleMessage.author.id === client.user.id) {
                        await new Promise(resolve => setTimeout(resolve, 700));

                        await singleMessage.delete().catch(err => { });
                        i++;
                    }
                }

                remainingMessages -= 100;
            }
        }
        else {
            await message.delete().catch(() => false);

            const nombre = parseInt(args[0]) || 9999999;
            let i = 0;

            const totalMessages = await message.channel.messages.fetch({ limit: nombre > 100 ? 100 : nombre });

            for (const singleMessage of totalMessages.values()) {
                if (singleMessage.author.id === client.user.id) {
                    await new Promise(resolve => setTimeout(resolve, 200));

                    await singleMessage.delete().catch(err => { });
                    i++;
                }
            }

            let remainingMessages = nombre - 100;
            while (remainingMessages > 0) {
                const additionalMessages = await message.channel.messages.fetch({ limit: remainingMessages > 100 ? 100 : remainingMessages, before: totalMessages.lastKey() });
                
                for (const singleMessage of additionalMessages.values()) {
                    if (singleMessage.author.id === client.user.id) {
                        await new Promise(resolve => setTimeout(resolve, 200));

                        await singleMessage.delete().catch(err => { });
                        i++;
                    }
                }

                remainingMessages -= 100;
            }
        }
      }catch(e) {
        console.log(e)
      }
    },
  };