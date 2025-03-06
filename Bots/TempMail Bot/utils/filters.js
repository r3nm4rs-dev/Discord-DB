class Filters {
    constructor() {
        this.spamKeywords = [
            'viagra', 'cialis', 'casino',
            'lottery', 'winner', 'prize',
            'bitcoin', 'crypto', 'investment'
        ];

        this.phishingPatterns = [
            /verify.+account/i,
            /password.+expired/i,
            /security.+alert/i,
            /unusual.+activity/i
        ];

        this.urlPatterns = [
            /http[s]?:\/\/(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\\(\\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+/g
        ];
    }

    analyzeEmail(email) {
        const analysis = {
            score: 0,
            threats: [],
            isSafe: true
        };

        const spamScore = this.checkSpam(email.text || '');
        if (spamScore > 0) {
            analysis.score += spamScore;
            analysis.threats.push({
                type: 'spam',
                score: spamScore,
                severity: spamScore > 0.5 ? 'high' : 'medium'
            });
        }

        const phishingScore = this.checkPhishing(email.text || '');
        if (phishingScore > 0) {
            analysis.score += phishingScore;
            analysis.threats.push({
                type: 'phishing',
                score: phishingScore,
                severity: phishingScore > 0.5 ? 'high' : 'medium'
            });
        }

        const urlAnalysis = this.analyzeUrls(email.text || '');
        if (urlAnalysis.score > 0) {
            analysis.score += urlAnalysis.score;
            analysis.threats.push({
                type: 'suspicious_urls',
                count: urlAnalysis.count,
                severity: urlAnalysis.score > 0.5 ? 'high' : 'medium'
            });
        }

        analysis.isSafe = analysis.score < 0.7;
        analysis.recommendation = this.getRecommendation(analysis.score);

        return analysis;
    }

    checkSpam(content) {
        let score = 0;
        const contentLower = content.toLowerCase();

        for (const keyword of this.spamKeywords) {
            if (contentLower.includes(keyword)) {
                score += 0.2;
            }
        }

        return Math.min(score, 1);
    }

    checkPhishing(content) {
        let score = 0;

        for (const pattern of this.phishingPatterns) {
            if (pattern.test(content)) {
                score += 0.3;
            }
        }

        return Math.min(score, 1);
    }

    analyzeUrls(content) {
        let urls = [];
        for (const pattern of this.urlPatterns) {
            const matches = content.match(pattern);
            if (matches) {
                urls = urls.concat(matches);
            }
        }

        return {
            count: urls.length,
            score: Math.min(urls.length * 0.2, 1)
        };
    }

    getRecommendation(score) {
        if (score >= 0.7) {
            return '🚨 Cet email présente un risque élevé. Ne cliquez sur aucun lien et ne répondez pas.';
        } else if (score >= 0.4) {
            return '⚠️ Cet email contient des éléments suspects. Soyez prudent.';
        } else {
            return '✅ Cet email semble sûr, mais restez vigilant.';
        }
    }
}

module.exports = new Filters();