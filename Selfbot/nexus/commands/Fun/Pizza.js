module.exports = {

    name: 'pizza',

    description: 'Sélectionne aléatoirement une part de pizza avec différentes garnitures.',

    run: async (client, message, args) => {

        const toppings = ['fromage', 'pepperoni', 'champignons', 'poivrons', 'ananas', 'bacon', 'olives', 'oignons', 'saucisse'];

        const selectedTopping = toppings[Math.floor(Math.random() * toppings.length)];

        message.edit(`🍕 Miam ! Votre part de pizza aléatoire est garnie de ${selectedTopping}. Bon appétit !`);

    }

};