
module.exports = {
    matchCode,
    nitrocode,
}

/**
 * Vérifie le lien d'un nitro
 * @param {string} [text] Le texte à vérifier
 * @param {string} [code] Le code à envoyer
 * @example matchCode(message.content, (code) => {})
 */

function matchCode(text, callback){
    let codes = text.match(/https:\/\/discord\.gift\/[abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789]+/)
    if(codes){
        callback(codes[0])
        return matchCode(text.slice(codes.index+codes[0].length), callback)
    }else{
        callback(null)
    }
  }


/**
 * @param {string} [length] Le nombre de caractères du code nitro
 * @param {string} [letter] Les lettres à prendre (0, A et a)
 * @example nitrocode(16, 0aA)
 */


function nitrocode(length, letter) {

    var multiplier = '';
    if (letter.indexOf('0') > -1) multiplier += '0123456789';
    if (letter.indexOf('A') > -1) multiplier += 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
    if (letter.indexOf('a') > -1) multiplier += 'abcdefghijklmnopqrstuvwxyz';
    var results = '';


    for (var i = length; i > 0; --i) {
        results += multiplier[Math.floor(Math.random() * multiplier.length)];

    }

    return results;

}