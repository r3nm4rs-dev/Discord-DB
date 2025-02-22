class Cooldown {
    constructor() {
        this.cooldowns = new Map();
    }

    /**
     * Vérifie si un utilisateur est en cooldown
     * @param {string} userId - ID de l'utilisateur
     * @param {string} command - Nom de la commande
     * @param {number} duration - Durée du cooldown en millisecondes
     * @returns {boolean} - true si l'utilisateur est en cooldown
     */
    isOnCooldown(userId, command, duration) {
        const key = `${userId}-${command}`;
        const lastUsage = this.cooldowns.get(key);

        if (!lastUsage) return false;

        const now = Date.now();
        const timePassed = now - lastUsage;

        return timePassed < duration;
    }

    /**
     * Obtient le temps restant du cooldown
     * @param {string} userId - ID de l'utilisateur
     * @param {string} command - Nom de la commande
     * @param {number} duration - Durée du cooldown en millisecondes
     * @returns {number} - Temps restant en secondes
     */
    getRemainingTime(userId, command, duration) {
        const key = `${userId}-${command}`;
        const lastUsage = this.cooldowns.get(key);

        if (!lastUsage) return 0;

        const now = Date.now();
        const timePassed = now - lastUsage;
        const remaining = duration - timePassed;

        return Math.ceil(remaining / 1000);
    }

    /**
     * Démarre le cooldown pour un utilisateur
     * @param {string} userId - ID de l'utilisateur
     * @param {string} command - Nom de la commande
     */
    startCooldown(userId, command) {
        const key = `${userId}-${command}`;
        this.cooldowns.set(key, Date.now());
    }

    /**
     * Réinitialise le cooldown pour un utilisateur
     * @param {string} userId - ID de l'utilisateur
     * @param {string} command - Nom de la commande
     */
    resetCooldown(userId, command) {
        const key = `${userId}-${command}`;
        this.cooldowns.delete(key);
    }
}

module.exports = new Cooldown();