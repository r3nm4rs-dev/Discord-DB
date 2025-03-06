const linkReg = /https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)/;
const discordReg = /(https?:\/\/)?(www\.)?(discord\.(gg|io|me|li)|discordapp\.com\/invite)\/.+[a-z]/g;


const Urlcheck = (string) => {
    if (string.match(linkReg)) return true;
    else if (string.match(discordReg)) return true;
    else return false;
}

module.exports = (string) => Urlcheck(string)