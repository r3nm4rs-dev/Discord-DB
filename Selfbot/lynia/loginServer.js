const express = require('express');
const fs = require('fs');
const path = require('path');
const Discord = require('discord.js-selfbot-v13');
const readyEvent = require('./events/client/ready');
const app = express();
const PORT = 27200;

let config = require('./config.json');

app.use(express.static('public'));
app.use(express.json());

const isValidUserId = (userId) => {
    return /^[0-9]{17,19}$/.test(userId);
};

const isValidTokenFormat = (token) => {
    return /^[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+\.[A-Za-z0-9-_]+$/.test(token);
};

app.post('/login', (req, res) => {
    const { userId, token } = req.body;

    if (!userId || !token) {
        return res.status(400).json({ message: 'You ID or Token are NEEDED.' });
    }

    if (!isValidUserId(userId)) {
        return res.status(400).json({ message: "Invalid User ID. Numbers 17-19 are accepted." });
    }

    if (!isValidTokenFormat(token)) {
        return res.status(400).json({ message: "Invalid token format." });
    }

    const client = new Discord.Client({
        checkUpdate: false
    });

    client.login(token)
        .then(() => {
            console.log(`Token valide pour l'utilisateur ${userId}`);

            if (!config.user) {
                config.user = {};
            }

            config.user[userId] = { id: userId, token };

            fs.writeFile(path.join(__dirname, 'config.json'), JSON.stringify(config, null, 2), (err) => {
                if (err) {
                    console.error('Erreur de sauvegarde:', err);
                    return res.status(500).json({ message: 'Erreur serveur. Impossible de sauvegarder.' });
                }

                client.once('ready', () => {
                    console.log(`Client prêt pour l'utilisateur ${userId}`);
                    readyEvent.run(client);
                });

                res.json({ message: 'Succesfully Connected!' });
                process.exit(1);
            });
        })
        .catch((err) => {
            console.error('Erreur lors de la connexion au client Discord:', err);
            res.status(500).json({ message: 'Token invalide, vérifier votre token.' });
        });
});

app.listen(PORT, () => {
    console.log(`Connexion activé : Bonne Connexion!`);
});
