const { ActionRowBuilder, ModalBuilder, TextInputBuilder, TextInputStyle } = require("pwss");
const fs = require("fs");
const path = require("path");
const { Revoluty } = require("../../../Self/structures/Client/Revoluty");

module.exports = {
    name: 'interactionCreate',
    once: false,
    run: async (client, interaction) => {
        if (!interaction.isButton() && !interaction.isModalSubmit()) return;

        // Handle button interaction
        if (interaction.customId.startsWith("connect_button")) {
            const modal = new ModalBuilder()
                .setCustomId('connect_modal')
                .setTitle('Connect to Pluzio');

            const firstActionRow = new ActionRowBuilder()
                .addComponents(
                    new TextInputBuilder()
                        .setCustomId('prefix')
                        .setLabel('Prefix for your config')
                        .setStyle(TextInputStyle.Short)
                        .setRequired(false)
                );

            const secondActionRow = new ActionRowBuilder()
                .addComponents(
                    new TextInputBuilder()
                        .setCustomId('token')
                        .setLabel('Your Account token')
                        .setStyle(TextInputStyle.Short)
                        .setRequired(true)
                );

            const premiumRow = new ActionRowBuilder()
                .addComponents(
                    new TextInputBuilder()
                        .setCustomId('premium_token')
                        .setLabel('Your Premium license')
                        .setStyle(TextInputStyle.Short)
                        .setRequired(false)
                );

            modal.addComponents(firstActionRow, secondActionRow, premiumRow);

            await interaction.showModal(modal);
        }

        // Handle modal submit interaction
        if (interaction.customId === "connect_modal") {
            await interaction.deferUpdate();

            const prefix = interaction.fields.getTextInputValue('prefix') || '!';
            const token = interaction.fields.getTextInputValue('token');
            const premium_token = interaction.fields.getTextInputValue('premium_token');

            // Validate token presence
            if (!token) {
                await interaction.editReply({ content: 'Token is required!', ephemeral: true });
                return;
            }

            // Initialize client configuration
            let clientConf = {
                token: token,
                prefix: prefix,
                premium: false
            };

            // Check and handle premium token
            let premiumList = await client.db.get('revoluty_premium') || [];

            if (premium_token) {
                const premiumTokenData = premiumList.find(x => x.code === premium_token);

                if (premiumTokenData) {
                    if (premiumTokenData.claimedBy) {
                        await interaction.editReply({ content: 'This premium code has already been claimed.', ephemeral: true });
                        return;
                    } else {
                        premiumTokenData.claimedBy = interaction.user.id;
                        await client.db.set('revoluty_premium', premiumList);
                        clientConf.premium = true;
                        await interaction.editReply({ content: 'Premium code successfully claimed!', ephemeral: true });
                    }
                } else {
                    await interaction.editReply({ content: 'Invalid premium code.', ephemeral: true });
                    return;
                }
            }

            await client.db.set(`config_${interaction.user.id}`, clientConf);

            let clientData = await client.db.get(`client_${client.user.id}`) || [];
            if (!clientData.includes(interaction.user.id)) {
                clientData.push(interaction.user.id);
                await client.db.set(`client_${client.user.id}`, clientData);
            }

            // Create and write configuration file
            let userConfigDir = path.join(__dirname, "../../../Self/structures/Config");
            let configFilePath = path.join(userConfigDir, `${interaction.user.id}.js`);

            if (!fs.existsSync(userConfigDir)) {
                fs.mkdirSync(userConfigDir, { recursive: true });
            }

            let configContent = `
module.exports = {
    token: "${token}",
    prefix: "${prefix}",
    premium: ${clientConf.premium}
};`;

            fs.writeFileSync(configFilePath, configContent.trim(), 'utf8');

            await interaction.editReply({ content: `Config saved${clientConf.premium ? ' with premium config!' : ' with free config!'}`, ephemeral: true });

            // Initialize and connect new client
            try {
                const newClient = new Revoluty({
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
                }, interaction.user.id); // Pass the user ID here

                await newClient.connectUser();
            } catch (error) {
                console.error(`Failed to connect Pluzio client for user ${interaction.user.id}: ${error.message}`);
                await interaction.editReply({ content: 'Failed to connect Pluzio client. Please try again later.', ephemeral: true });
            }
        }
    }
};
