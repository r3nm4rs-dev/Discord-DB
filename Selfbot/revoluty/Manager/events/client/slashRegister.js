module.exports = {
    name: "ready",
    once: true,
    run: async (client) => {
        client.slashCommandHandler.registerCommands();
    }
}
