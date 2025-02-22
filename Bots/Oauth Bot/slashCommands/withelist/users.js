const discord = require('discord.js')
const index = require('../..')
const { userdb } = require('../..')
module.exports = {
  name: "users",
  description: "total users",
  default_permission: true,
  category: "whitelist",
  userPerms: [discord.PermissionFlagsBits.SendMessages],
  ownerOnly: false,

  run: async (client, interaction, args) => {

    const data = await userdb.find()
    const datatr = await userdb.find({ country_code: "TR" })
	const dataca = await userdb.find({ country_code: "CA"})
	const datagb = await userdb.find({ country_code: "GB"})
	const datain = await userdb.find({ country_code: "IN"})
    const dataus = await userdb.find({ country_code: "US"})
	const datail = await userdb.find({ country_code: "IL"})
	const datapl = await userdb.find({ country_code: "PL"})
	const dataat = await userdb.find({ country_code: "AT"})
	const datama = await userdb.find({ country_code: "MA"})
    const datafr = await userdb.find({ country_code: "FR"})
	const datade = await userdb.find({ country_code: "DE"})
	const dataec = await userdb.find({ country_code: "EC"})
    const databr = await userdb.find({ country_code: "BR"})
	const datape = await userdb.find({ country_code: "PE"})
    const dataes = await userdb.find({ country_code: "ES"})
	const databg = await userdb.find({ country_code: "BG"})
    const databa = await userdb.find({ country_code: "BA"})
	const datamy = await userdb.find({ country_code: "MY"})
    const dataph = await userdb.find({ country_code: "PH"})
	const databe = await userdb.find({ country_code: "BE"})
    const datamx = await userdb.find({ country_code: "MX"})
	const datath = await userdb.find({ country_code: "TH"})
	const datasa = await userdb.find({ country_code: "SA"})
	const dataco = await userdb.find({ country_code: "CO"})
	const databd = await userdb.find({ country_code: "BD"})
	const dataar = await userdb.find({ country_code: "AR"})
	const datacl = await userdb.find({ country_code: "CL"})
	const dataid = await userdb.find({ country_code: "ID"})
	const datasv = await userdb.find({ country_code: "SV"})
	const datair = await userdb.find({ country_code: "IR"})
	const dataru = await userdb.find({ country_code: "RU"})
	const datagr = await userdb.find({ country_code: "GR"})
    const datait = await userdb.find({ country_code: "IT"})
	const datapt = await userdb.find({ country_code: "PT"})
	const datase = await userdb.find({ country_code: "SE"})
	const dataua = await userdb.find({ country_code: "UA"})
	
    interaction.reply({
      embeds: [new discord.EmbedBuilder()
	    .setColor(discord.Colors.Yellow)
        .setAuthor({
          name:"🌍 List of user locations"
        })
		.setDescription (`<a:toplamusers:1084186596137508967>  Total Users: ${data.length} \n\n :flag_us: : ${dataus.length} \n :flag_fr: : ${datafr.length} \n :flag_br: : ${databr.length} \n :flag_de: : ${datade.length} \n :flag_tr: : ${datatr.length} \n :flag_gb: : ${datagb.length} \n :flag_in: : ${datain.length} \n :flag_mx: : ${datamx.length} \n :flag_pl: : ${datapl.length} \n :flag_ca: : ${dataca.length} \n :flag_sa: : ${datasa.length} \n :flag_ar: : ${dataar.length} \n :flag_ph: : ${dataph.length} \n :flag_es: : ${dataes.length} \n :flag_id: : ${dataid.length} \n :flag_cl: : ${datacl.length} \n :flag_co: : ${dataco.length} \n :flag_ir: : ${datair.length} \n :flag_my: : ${datamy.length} \n :flag_bd: : ${databd.length} \n :flag_il: : ${datail.length} \n :flag_pe: : ${datape.length} \n :flag_be: : ${databe.length} \n :flag_se: : ${datase.length} \n :flag_gr: : ${datagr.length} \n :flag_ec: : ${dataec.length} \n :flag_at: : ${dataat.length} \n :flag_it: : ${datait.length} \n :flag_pt: : ${datapt.length} \n :flag_ma: : ${datama.length} \n :flag_bg: : ${databg.length} \n :flag_th: : ${datath.length} \n :flag_ua: : ${dataua.length} \n :flag_ba: : ${databa.length} \n :flag_ru: : ${dataru.length} \n :flag_sv: : ${datasv.length}`)
      
        .setFooter({
          text:"Aslan"
        })
      ]
    })
  
  }
}

