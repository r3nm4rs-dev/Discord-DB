module.exports = {
    name: "uncaughtExceptionMonitor",
    once: false,
    run: async (client, reason, p) => {
        console.log(p, reason);

        return console.log(`[ERROR CATCH] \nReason : ${reason}`);
    }
}