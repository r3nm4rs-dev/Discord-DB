module.exports = {
    name: 'rizz',
    description: 'Envoie un message séduisant avec une touche de riz.',
    run: async (client, message, args) => {
        const seductiveMessages = [
            
            "Tu es aussi doux que du riz cuit à la perfection.",
            "Si j'étais un grain de riz, je serais honoré d'être dans ton bol.",
            "Ton sourire est aussi éclatant que le soleil se reflétant sur un champ de riz.",
            "Tu es le riz à mon curry, l'ingrédient essentiel de ma vie.",
            "Comme du riz, tu remplis mon cœur de chaleur et de bonheur."

        ];

        const selectedMessage = seductiveMessages[Math.floor(Math.random() * seductiveMessages.length)];

        message.edit(selectedMessage);

    }

};