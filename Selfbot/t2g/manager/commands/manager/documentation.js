const config = require('../../../config.json')
const Discord = require('discord.js')
const fs = require('node:fs')

module.exports = {
    name: "documentation",
    description: "Envoie la documentation",
    owner: true,
    options: [
        {
            name: "documentation",
            type: Discord.ApplicationCommandOptionType.String,
            description: "La documentation a envoyer",
            required: true
        }
    ],
    /**
    * @param {Discord.Client} client
    * @param {Discord.Interaction} interaction
    */
    run: async (client, interaction) => {
        try{
        const namee = interaction.options.getString('documentation');
        if(namee === 'images') {
            const embed = new Discord.EmbedBuilder()
            .setTitle('<:rpc:1275208317953638473> Comment mettre une image sur son RPC ?')
            .setDescription(`Pour ajouter une image à votre RPC/Spotify, il vous suffit de vous rendre sur [ce site](https://postimages.org), puis de cliquer sur __**Choisir des images**__. Une fois l’image téléchargée, descendez et copiez le lien dans la section __**Lien direct**__. Vous aurez ainsi le lien nécessaire pour configurer votre RPC/Spotify.`)
            .setColor('#ffffff')
            interaction.reply({embeds: [embed]})
        }
            if(namee === 'multistatus') {
            const embed = new Discord.EmbedBuilder()
            .setTitle('<:black_star:1276458935846703196> Comment configurer le multistatus ?')
            .setDescription(`Pour configurer le multistatus, il faudra exécuter la commande \`&multistatus add <emoji> <text>\` en choisissant un emoji et un texte. Pour voir ensuite ce que vous avez ajouté, faites \`&multistatus list\`. Si vous souhaitez supprimer un ou plusieurs éléments, utilisez \`&multistatus remove <number>\` avec le chiffre qui est écrit devant le statut dans la liste que vous voulez enlever. Ensuite, faites \`&multistatus start\` et votre multistatus sera activé.`)
            .setColor('#ffffff')
            interaction.reply({embeds: [embed]})
        }
         if(namee === 'rpc') {

            const embed = new Discord.EmbedBuilder()

            .setTitle('<:rpc:1275208317953638473> Comment configurer le RPC ?')

            .setDescription(`Pour configurer votre RPC, commencez par l'activer avec \`&rpc on\`. Ensuite, utilisez \`&rpc custom\` pour personnaliser. Pour désactiver, faites \`&rpc off\` et recommencez la configuration.

Voici les étapes de configuration :

1. **Type de RPC** : \`&configrpc type <streaming, watching, playing, competing, listening>\`

2. **Plateforme** : \`&configrpc platform <samsung, ps4, ps5, desktop>\`

3. **Nom** : \`&configrpc name\`

4. **Description** : \`&configrpc details\`

5. **Sous-description** : \`&configrpc state\`

6. **Image principale** : \`&configrpc largeimage\`

7. **Petite image** : \`&configrpc smallimage\`

8. **ID de l'application** : \`&configrpc appid\`

9. **Boutons** : \`&configrpc button 1/2 <lien> <texte>\`

Après chaque modification, actualisez avec \`&rpc custom\` pour voir les changements. Pour supprimer un élément, répétez la commande correspondante sans ajouter de texte (ex : \`&configrpc name\`).`)

            .setColor('#ffffff')

            interaction.reply({embeds: [embed]})

        }
        }catch(e){
            console.log(e)
        }
        }
    }