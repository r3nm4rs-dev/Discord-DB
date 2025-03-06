const fs = require('fs')

module.exports = {
  name: "morse",
  descriptionfr: "Transforme ton texte en morse",
  descriptionen: "Turn your text into morse code",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))

    let alpha = " ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!¡#$%⅋,)(*+\'-˙/:;<=>?@[/]^_`{|}~".split("");
    let morse = "/,.-,-...,-.-.,-..,.,..-.,--.,....,..,.---,-.-,.-..,--,-.,---,.--.,--.-,.-.,...,-,..-,...-,.--,-..-,-.--,--..,.----,..---,...--,....-,.....,-....,--...,---..,----.,-----,?,!,¡,#,$,%,⅋,,,),(,*,+,\,',-,˙,/,:,;,<,=,>,?,@,[,/,],^,_,`,{,|,},~".split(",");
    let text = args.join(" ").toUpperCase().replaceAll("Ä", "AE").replaceAll("Ç", "C").replaceAll("Ê", "E").replaceAll("Ù", "U").replaceAll("Ö", "OE").replaceAll("É", "E").replaceAll("Ü", "UE");

    if (text.startsWith(".") || text.startsWith("-")) {
      text = text.split(" ");
      for (i = 0; i < text.length; i++) {
          text[i] = alpha[morse.indexOf(text[i])];
      }
      text = text.join("");
    } else {
      text = text.split("");
      let length = text.length;
      for (i = 0; i < length; i++) {
          text[i] = morse[alpha.indexOf(text[i])];
      }
      text = text.join(" ");
    }
    message.edit(`\`\`\`${text}\`\`\``)
  }
}