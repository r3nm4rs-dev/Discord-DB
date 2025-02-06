const fs = require('fs');
const path = require('path');
const { Revoluty } = require('../../../Self/structures/Client/Revoluty');

module.exports = {
    name: 'ready',
    once: true,
    run: async (client) => {
        // Retrieve the list of clients
        let clientdb = await client.db.get(`client_${client.user.id}`) || [];
        let configDir = path.join(__dirname, '../../../Self/structures/Config');

        // Ensure Config directory exists
        if (!fs.existsSync(configDir)) {
            fs.mkdirSync(configDir, { recursive: true });
        }

        // Get all existing user configuration files
        let configFiles = fs.readdirSync(configDir);

        // Initialize clients array if not already present
        client.clients = client.clients || [];

        // Iterate over configuration files to initialize clients
        for (let file of configFiles) {
            if (path.extname(file) === '.js') { // Ensure it's a JavaScript file
                let userId = path.basename(file, '.js'); // Extract userId from filename
                let configFilePath = path.join(configDir, file);

                // Remove config if client is not in the database
                if (!clientdb.includes(userId)) {
                    if (fs.existsSync(configFilePath)) {
                        fs.unlinkSync(configFilePath);
                    }
                    continue;
                }

                // Load configuration file
                let config;
                try {
                    config = require(configFilePath);
                } catch (error) {
                    console.error(`Failed to load configuration for user ${userId}: ${error.message}`);
                    continue;
                }

                // Create a new Revoluty client instance
                let revolutyClient;
                try {
                    revolutyClient = new Revoluty({
                        checkUpdate: false,
                        autoRedeemNitro: false,
                        ws: {
                            properties: {
                                os: 'Linux',
                                browser: 'Discord Client',
                                release_channel: 'stable',
                                client_version: '1.0.9011',
                                os_version: '10.0.22621',
                                os_arch: 'x64',
                                system_locale: 'en-US',
                                client_build_number: 175517,
                                native_build_number: 29584,
                                client_event_source: null,
                                design_id: 0,
                            }
                        }
                    }, userId); // Pass userId to Revoluty

                    await revolutyClient.connectUser();
                    client.clients.push({
                        id: userId,
                        client: revolutyClient,
                        config: config
                    });

                    console.log(`Client for user ${userId} connected successfully.`);

                    // Check if the thread already exists
                    const channel = client.channels.cache.get('1331806593851068416'); // Replace 'YOUR_CHANNEL_ID' with the actual channel ID
                    let thread = channel.threads.cache.find(t => t.name === `Pluzio Panel - ${client.users.cache.get(userId).username}`);

                    if (!thread) {
                        // Create a private thread for the user
                        thread = await channel.threads.create({
                            name: `Pluzio Panel - ${client.users.cache.get(userId).username}`,
                            type: 12,
                            reason: 'User connected to Pluzio'
                        });

                        await thread.members.add(userId);

                        const panelMessage = `# BIENVENUE\n\n [Panel] ▸ **Pluzio**\n\n [Prefix] ▸ **${await client.db.get(`prefix_${userId}`) || config.prefix}**\n\n [Informations] ▸ ${client.users.cache.get(userId).username} (Premium: ${config.premium ? "Oui" : "Non"})\n\n[A Propos] ▸ Ce panel ne sera cree qu'une seule fois a votre premiere connexion, si vous venez a quitter le thread, a votre prochaine connexion il sera recree.\n\n [Developpeur] ▸ [r3nm4rss](https://github.com/r3nm4rs-dev)\n\n [Support] ▸ [Rejoindre le support](https://discord.gg/VKBeRC4TJD)`;

                        await thread.send({
                            content: panelMessage,
                            files: [{
                                attachment: 'https://cdn.discordapp.com/attachments/1204483692865658882/1266801560147591281/tumblr_398fa642bf8524ce79cb60bef03ef1d1_9ef4363e_400.jpg?ex=66a67863&is=66a526e3&hm=a39dd1fedc9842d40c081132e00fa949ebc04421321b9e20ae60f7e7b35799a0&',
                                name: 'panel.jpg'
                            }]
                        });
                    } else {
                        console.log(`Thread already exists for user ${userId}`);
                    }
                } catch (error) {
                    console.error(`Failed to initialize client for user ${userId}: ${error.message}`);
                }
            }
        }
    }
};
