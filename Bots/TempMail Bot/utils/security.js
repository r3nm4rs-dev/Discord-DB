const fs = require('fs').promises;
const path = require('path');

class Security {
    constructor() {
        this.blockedDomains = new Set();
        this.loadBlockedDomains();
    }

    async loadBlockedDomains() {
        try {
            const domainsPath = path.join(__dirname, '..', 'data', 'phishing-domains.txt');
            const content = await fs.readFile(domainsPath, 'utf8');
            const domains = content.split('\n')
                .map(line => line.trim())
                .filter(line => line && !line.startsWith('#'));
            
            this.blockedDomains = new Set(domains);
            console.log(`✅ Domaines bloqués chargés: ${this.blockedDomains.size} domaines`);
        } catch (error) {
            console.error('❌ Erreur lors du chargement des domaines bloqués:', error);
            this.blockedDomains = new Set();
        }
    }

    checkDomain(domain) {
        if (!domain) return false;
        
        const normalizedDomain = domain.toLowerCase().trim();
        if (this.blockedDomains.has(normalizedDomain)) {
            console.warn(`⚠️ Email bloqué de domaine suspect: ${domain}`);
            return false;
        }
        return true;
    }

    validateEmail(email) {
        if (!email || !email.from) {
            return { isSafe: false, reason: 'Email invalide' };
        }

        const domain = email.from.split('@')[1];
        const domainCheck = this.checkDomain(domain);

        return {
            isSafe: domainCheck,
            reason: domainCheck ? 'Email sûr' : 'Domaine bloqué',
            domain: domain
        };
    }

    async reloadBlockedDomains() {
        await this.loadBlockedDomains();
        return this.blockedDomains.size;
    }
}

module.exports = new Security();