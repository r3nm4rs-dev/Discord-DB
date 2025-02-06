module.exports = {
    name: "number",
    description: "",

    run: async (client, message, args) => {
        try{
        const max = args[0] ? args[0] : 100
        const chatte2juive = Math.round(Math.random() * max)
        const reponse = client.db.lang === "fr" ? `***Nombre entre __0-${max}__*** : \`${chatte2juive}\`` : `***Number between __0-${max}__***: \`${chatte2juive}\``
        message.edit(reponse)
    }catch(e){
        const error = client.db.lang === "fr" ? `***Veuillez fournir un nombre valide !***` : `***Please provide a valid number !***`
        message.edit(error)
        return
    }
    }
}