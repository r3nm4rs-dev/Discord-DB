https://dsc.gg/4wip - Discord


Création d'un bot
```
･ Rendez-vous sur le site : https://discord.com/developers/applications
･ Cliquez sur "Nouvelle Application"
･ Dans l'onglet "Bot", cochez les 3 "Privileged Gateway Intents" (Presence, Server, Message Content).
･ Réinitialisez le token et garde le (ne le donne à personne).
Inviter le bot sur ton serveur
Allez dans l'onglet "Oauth2"
Dans "OAuth2 URL Generator", cochez "Bot" et "Administrator".
Copiez-collez l'URL générée dans un autre onglet.
```


Hébergement du bot sur Render | Gratuit (PC & Mobile)
```
Faites un fork du gitHub : https://github.com/4wip/naoki-modifier/fork
Allez dans le config.js et modifiez (appuie sur le petit crayon à droite)
buyer - changez par votre ID
couleur, footer, maxServer, préfixe - changez ce que vous voulez


Sur le site Render, créez un compte (c'est le bouton sign in) : https://render.com/
Créez un service web
Lien: le fork que tu vien de faire

Paramètres:

Région : Virginia
Runtime : Node
Commande de construction : npm i
Commande de démarrage : node index.js
Type d'instance : Gratuit

Variables d'environnement :
token : meeae898787 (Le token du bot)
NODE_VERSION : 16.20.0

Enfin, créez votre service web
Allez dans l'onglet "logs" sur Render pour voir l'indication : "nomdubot connecté". (Actualise la page pour voir les changements)


[Maintenir le bot en ligne 24/7]

Sur le site cron-job.org, créez un compte (bouton sign up)
Dans le tableau de bord (dashboard en anglais), allez dans l'onglet "Cronjobs" et créez un nouveau Cronjob:

Nom : Le nom que tu veux (Aucun impacte sur le bot)
URL : Utilisez l'URL de votre service web sur Render (voir l'image)
Calendrier d'exécution : Chaque minute

Créez le Cronjob
```

![image](https://github.com/4wip/Crowbot-Fix/assets/168364544/9c70adb6-34f7-44fe-97ad-78b46c2795bf)

## Crédit

La base de Betaaa modifiée par 4wip
