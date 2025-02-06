module.exports = {
    name: "cointoss",
    description: "",
    run: async (client, message, args) => {
        if(client.db.lang === "fr") {
            const sides = ['pile', 'face'];
            const result = sides[Math.floor(Math.random() * sides.length)];
    
            message.edit(`***La pièce tombe sur __${result}__ !***`);
            return
        }
        if(client.db.lang === "en") {
            const sides = ['heads', 'tails'];
            const result = sides[Math.floor(Math.random() * sides.length)];
    
            message.edit(`***The coin lands on __${result}__ !***`);
            return
        }
    }
}