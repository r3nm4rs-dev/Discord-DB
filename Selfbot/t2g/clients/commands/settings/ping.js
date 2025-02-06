module.exports = {
    name: "ping",
    description: "Test de latence",
    run: async (client, message, args, db, prefix, tag) => {
        try{
        const start = Date.now();
        message.edit('***Pinging...***');
        const end = Date.now()
        const rest = end - start; 
        await message.edit(`***REST***: \`${rest}ms\` ***WS***: \`${client.ws.ping}ms\``);
    }catch(e){console.log(e)}
    }
}  