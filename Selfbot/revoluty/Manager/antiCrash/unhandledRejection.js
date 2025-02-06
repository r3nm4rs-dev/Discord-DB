module.exports = {
    name: "unhandledRejection",
    once: false,
    run: async (client, reason, p) => {
        console.log(p, reason);

        return console.log(`[ERROR CATCH] \nReason : ${reason}`);
    }
}