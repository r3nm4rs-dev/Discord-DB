const fs = require('fs')

module.exports = {
  name: "setbio",
  descriptionfr: "Modifie ta bio discord",
  descriptionen: "Edit your discord about me",
  run: async (client, message, args) => {
    client.user.setAboutMe(args.slice(0).join(' ') || null)
    .then(() => message.edit(client.trad(`Your aboutme has been ${args[0] ? "edited" : "deleted"}`, `Votre bio a été ${args[0] ? "modifiée" : "supprimée"}`)))
    .catch(() => message.edit(client.trad(`I can't ${args[0] ? "edit" : "delete"} your aboutme`, `Je ne peux pas ${args[0] ? "modifier" : "supprimer"} votre bio`)))
  }
}