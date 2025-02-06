module.exports = {
    name: "messageDelete",
    once: false,
  
    run: async (message, client) => {
        if (!message.author) return;

        const snipes = client.snipes.get(message.channel.id) || [];
        
        snipes.unshift({
            content: message.content ? message.content : "Aucun message",
            author: message.author,
            image: message.attachments.size > 0 ? message.attachments.first().url : "Aucune image",
            date: Date.now()
        });

        if (snipes.length > 5) snipes.pop();

        client.snipes.set(message.channel.id, snipes);
    }
}
