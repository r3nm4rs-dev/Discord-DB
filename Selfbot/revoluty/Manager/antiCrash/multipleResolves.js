module.exports = {
    name: "multipleResolves",
    once: false,
    run: async (client, reason, p) => {
        console.log(p, reason);

        return console.log(`[ERROR CATCH] \nReason : ${reason}`);
    }
}