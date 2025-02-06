const fs = require('fs');
const path = './urls.json';

// Fonction pour charger les URLs depuis le fichier JSON
function loadUrls() {
  if (fs.existsSync(path)) {
    const data = fs.readFileSync(path, 'utf-8');
    const json = JSON.parse(data);
    return {
      lockedUrls: new Set(json.lockedUrls),
      snipeUrls: new Set(json.snipeUrls)
    };
  }
  return {
    lockedUrls: new Set(),
    snipeUrls: new Set()
  };
}

// Fonction pour sauvegarder les URLs dans le fichier JSON
function saveUrls(lockedUrls, snipeUrls) {
  const data = {
    lockedUrls: Array.from(lockedUrls),
    snipeUrls: Array.from(snipeUrls)
  };
  fs.writeFileSync(path, JSON.stringify(data, null, 2), 'utf-8');
}

// Charger les URLs au démarrage du bot
const { lockedUrls, snipeUrls } = loadUrls();

// Exporter les sets et les fonctions
module.exports = {
  lockedUrls,
  snipeUrls,
  saveUrls
};
