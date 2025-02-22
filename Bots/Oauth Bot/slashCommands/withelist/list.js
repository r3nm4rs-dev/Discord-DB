const Discord = require("discord.js");
const finitto = require("../../finitto");
const { userdb, stopList } = require("../..");
module.exports = {
  name: "list",
  description: "Bot hakkında bilgi verir",
  default_permission: true,
  category: "whitelist",
  ownerOnly: false,

  run: async (client, message, args) => {
    const users = await userdb.find()
    if(!users) return message.reply({ embeds: [new Discord.EmbedBuilder().setColor('Red').setTitle(`Users List`).setDescription(`Üye Yok`)] })

    const texto = users.map((value, index) => `\`\` ${index+1} \`\` - ${value.username} | ${value.userId} | ${value.country} \n`)
    paginacion(client, message, texto, `Users List`)
}
}

async function paginacion(client, message, texto, titulo = "Page", elementos_por_pagina = 10) {

var embeds = [];
var dividido = elementos_por_pagina;
for(let i = 0; i < texto.length; i+= dividido) {
  let desc = texto.slice(i, elementos_por_pagina);
  elementos_por_pagina+= dividido;
  //creamos un embed por cada pagina de los datos divididos
  let embed = new Discord.EmbedBuilder()
  .setTitle(titulo.toString())
  .setDescription(desc.join(" "))
  .setColor('Grey')
  embeds.push(embed)
}

let paginaActual = 0;
//Si la cantidad de embeds es solo 1, envíamos el mensaje tal cual sin botones
if (embeds.length === 1) return message.reply({ embeds: [embeds[0]] }).catch(() => { });
//Si el numero de embeds es mayor 1, hacemos el resto || definimos los botones.
let boton_atras = new Discord.ButtonBuilder().setStyle(Discord.ButtonStyle.Success).setCustomId('Atrás').setEmoji('929001012176507040').setLabel('Previous')
let boton_inicio = new Discord.ButtonBuilder().setStyle(Discord.ButtonStyle.Danger).setCustomId('Inicio').setEmoji('🏠').setLabel('home')
let boton_avanzar = new Discord.ButtonBuilder().setStyle(Discord.ButtonStyle.Success).setCustomId('Avanzar').setEmoji('929001012461707335').setLabel('Next')
//Enviamos el mensaje embed con los botones
let embedpaginas = await message.channel.send({
  embeds: [embeds[0].setFooter({ text: `Page ${paginaActual + 1} / ${embeds.length}` })],
  components: [new Discord.ActionRowBuilder().addComponents([boton_atras, boton_inicio, boton_avanzar])]
});
//Creamos un collector y filtramos que la persona que haga click al botón, sea la misma que ha puesto el comando, y que el autor del mensaje de las páginas, sea el cliente
const collector =  embedpaginas.createMessageComponentCollector({ filter: i => i?.isButton(), time: 50000 });


collector.on("collect", async b => {
  //Si el usuario que hace clic a el botón no es el mismo que ha escrito el comando, le respondemos que solo la persona que ha escrito >>queue puede cambiar de páginas

  switch (b?.customId) {
      case "Atrás": {
          //Resetemamos el tiempo del collector
          collector.resetTimer();
          //Si la pagina a retroceder no es igual a la primera pagina entonces retrocedemos
          if (paginaActual !== 0) {
              //Resetemamos el valor de pagina actual -1
              paginaActual -= 1
              //Editamos el embeds
              await embedpaginas.edit({ embeds: [embeds[paginaActual].setFooter({ text: `Page ${paginaActual + 1} / ${embeds.length}` })], components: [embedpaginas.components[0]] }).catch(() => { });
              await b?.deferUpdate();
          } else {
              //Reseteamos al cantidad de embeds - 1
              paginaActual = embeds.length - 1
              //Editamos el embeds
              await embedpaginas.edit({ embeds: [embeds[paginaActual].setFooter({ text: `Page ${paginaActual + 1} / ${embeds.length}` })], components: [embedpaginas.components[0]] }).catch(() => { });
              await b?.deferUpdate();
          }
      }
          break;

      case "Inicio": {
          //Resetemamos el tiempo del collector
          collector.resetTimer();
          //Si la pagina a retroceder no es igual a la primera pagina entonces retrocedemos
          paginaActual = 0;
          await embedpaginas.edit({ embeds: [embeds[paginaActual].setFooter({ text: `Page ${paginaActual + 1} / ${embeds.length}` })], components: [embedpaginas.components[0]] }).catch(() => { });
          await b?.deferUpdate();
      }
          break;

      case "Avanzar": {
          //Resetemamos el tiempo del collector
          collector.resetTimer();
          //Si la pagina a avanzar no es la ultima, entonces avanzamos una página
          if (paginaActual < embeds.length - 1) {
              //Aumentamos el valor de pagina actual +1
              paginaActual++
              //Editamos el embeds
              await embedpaginas.edit({ embeds: [embeds[paginaActual].setFooter({ text: `Page ${paginaActual + 1} / ${embeds.length}` })], components: [embedpaginas.components[0]] }).catch(() => { });
              await b?.deferUpdate();
              //En caso de que sea la ultima, volvemos a la primera
          } else {
              //Reseteamos al cantidad de embeds - 1
              paginaActual = 0
              //Editamos el embeds
              await embedpaginas.edit({ embeds: [embeds[paginaActual].setFooter({ text: `Page ${paginaActual + 1} / ${embeds.length}` })], components: [embedpaginas.components[0]] }).catch(() => { });
              await b?.deferUpdate();
          }
      }
          break;

      default:
          break;
  }
});
collector.on("end", () => {
  //desactivamos los botones y editamos el mensaje
  embedpaginas.components[0].components.map(boton => boton.disabled = true)
  embedpaginas.edit({ content: `Zaman aşımı!`, embeds: [embeds[paginaActual].setFooter({ text: `Page ${paginaActual + 1} / ${embeds.length}` })], components: [embedpaginas.components[0]] }).catch(() => { });
});

}
