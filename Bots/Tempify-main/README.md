<div align="center">

![Version](https://img.shields.io/badge/version-1.0.0-blue.svg?cacheSeconds=2592000)
![Node](https://img.shields.io/badge/node-%3E%3D16.9.0-green.svg)
[![Discord.js](https://img.shields.io/badge/discord.js-v14-blue.svg)](https://discord.js.org)

</div>

Un bot Discord moderne et professionnel permettant la création et la gestion d'emails temporaires directement depuis votre serveur Discord. Idéal pour protéger la vie privée de vos membres tout en offrant une solution simple et efficace pour les inscriptions temporaires. Fonctionne avec l'api de tempmail.lol

## ✨ Fonctionnalités

- 📬 **Création d'emails temporaires**
  - Génération instantanée d'adresses email temporaires
  - Limite configurable d'emails par utilisateur
  - Interface intuitive via boutons Discord

- ⚡ **Notifications en temps réel**
  - Réception instantanée des emails

- 🔒 **Sécurité et Confidentialité**
  - Système de rôles intégré
  - Suppression automatique des emails
  - Protection contre le spam & phishing
  - Canaux privés par utilisateur

- 🎮 **Interface utilisateur moderne**
  - Boutons interactifs
  - Embeds personnalisés
  - Copie rapide des adresses email
  - Interface intuitive et réactive

## 📋 Prérequis

- Node.js 16.9.0 ou supérieur
- Un bot Discord avec les intents suivantes activées :
  - GUILDS
  - GUILD_MESSAGES
  - MESSAGE_CONTENT

## 🚀 Installation

1. **Cloner le repository**
   ```bash
   git clone https://github.com/0xDroska/tempify.git
   cd tempify
   ```

2. **Installer les dépendances**
   ```bash
   npm install
   ```

3. **Configurer les variables d'environnement**
   - Remplir les variables requises :
   ```env
   DISCORD_TOKEN=votre token discord
   CLIENT_ID=votre client id
   CATEGORY_ID=votre category id
   TEMPMAIL_API_KEY=votre tempmail.lol api key
   MAX_EMAILS=3
   ```

4. **Déployer les commandes slash**
   ```bash
   npm run deploy
   ```

5. **Démarrer le bot**
   ```bash
   npm start
   ```

## 💻 Commandes

| Commande | Description | Permission |
|----------|-------------|------------|
| `/panel` | Ouvre le panneau de gestion des emails | Administrateur
| `/config maxemails` | Configure le nombre max d'emails par utilisateur | Administrateur
| `/config role` | Configure le rôle automatique | Administrateur

## ⚙️ Configuration

### Configuration du rôle automatique

1. Utilisez la commande `/config role` 
2. Sélectionnez le rôle à attribuer
3. Un message embed avec un bouton sera créé
4. Les utilisateurs pourront cliquer sur le bouton pour obtenir le role et avoir accès au channel dédier (configurer avec le rôle) pour génerer des emails

### Limitation des emails

- Utilisez `/config maxemails` pour définir la limite
- La valeur doit être entre 1 et 5
- La modification est immédiate pour tous les utilisateurs

## 🤝 Support

Pour obtenir de l'aide ou signaler un bug :
- MP sur discord -> .droska.

---
Créé avec ❤️ par [0xDroska]
