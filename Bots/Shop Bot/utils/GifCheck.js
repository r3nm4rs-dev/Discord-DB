const tenorregex = /https:\/\/tenor.com.?/g;
const tenorregex2 = /https:\/\/media.tenor.com.?/g;
const tenorregex3 = /https:\/\/c.tenor.com.?/g;
const discordcdnregex = /https:\/\/cdn.discordapp.com.?/g;
const dicordmediaregex = /https:\/\/media.discordapp.net.?/g
const spotifyregex = /https:\/\/www.spotify.com.?/g;
const dicordattachregex = /https:\/\/cdn.discordapp.com.?/g;
const openspotifyregex = /https:\/\/open.spotify.com.?/g;
const giphyregex = /https:\/\/media.giphy.com.?/g;

const GifCheck = (string) => {
    if (string.match(tenorregex)) { return false; }
    else if (string.match(tenorregex2)) { return false; }
    else if (string.match(tenorregex3)) { return false; }
    else if (string.match(discordcdnregex)) { return false; }
    else if (string.match(spotifyregex)) { return false; }
    else if (string.match(dicordmediaregex)) { return false; }
    else if (string.match(dicordattachregex)) { return false; }
    else if (string.match(openspotifyregex)) { return false; }
    else if (string.match(giphyregex)) { return false; }
    else { return true; }
}

module.exports = (string) => GifCheck(string)