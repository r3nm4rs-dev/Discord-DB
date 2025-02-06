module.exports = {
    name: "edit",
    description: "Édite un certain nombre de messages dans le canal avec un message spécifié.",
    run: async (client, message, args) => {
        const number = args[0] ? parseInt(args[0]) : 15
        const mss = args[1] ? args.slice(1).join(" ") : '.'

        message.delete()
        try {
            const fetchedMessages = await message.channel.messages.fetch({ limit: number })
            const messages = [...fetchedMessages.values()]

            const editMessagesWithDelay = async () => {
                for (let i = 0; i < messages.length; i++) {
                    const msg = messages[i]
                    try {
                        await msg.edit(mss)
                    } catch (error) {
                    }

                    await new Promise(resolve => setTimeout(resolve, 1500))
                }
            }

            await editMessagesWithDelay()
        }catch(e){
        }
    }
}