const fs = require("fs");
const path = require("path");

module.exports = {
    name: "multirpc",
    async run(client, message, args) {
        const subCommand = args[0];
        const userId = client.user.id;
        const userDbPath = path.join(__dirname, `../../db/${userId}.json`);

        if (!fs.existsSync(userDbPath)) {
            const defaultStructure = {
                multi: {
                    rpcList: [],
                    rpcCount: 0
                }
            };
            fs.writeFileSync(userDbPath, JSON.stringify(defaultStructure, null, 2));
        }

        const db = JSON.parse(fs.readFileSync(userDbPath, "utf-8"));
        const rpcList = db.multi.rpcList || [];
        let rpcCount = db.multi.rpcCount || 0;

        switch (subCommand) {
            case "add":
                rpcCount += 1;
                const newRpc = {
                    id: rpcCount,
                    title: "",
                    details: "",
                    type: "",
                    rpcsmallimage: "",
                    rpclargeimage: "",
                };
                rpcList.push(newRpc);
                db.multi.rpcList = rpcList;
                db.multi.rpcCount = rpcCount;

                fs.writeFileSync(userDbPath, JSON.stringify(db, null, 2));
                message.edit(`RPC ajouté avec succès (Id: ${newRpc.id}).`);
                break;

            case "remove":
                const removeId = parseInt(args[1], 10);
                const rpcIndex = rpcList.findIndex(rpc => rpc.id === removeId);

                if (rpcIndex !== -1) {
                    const removedRpc = rpcList.splice(rpcIndex, 1)[0];
                    db.multi.rpcList = rpcList;

                    fs.writeFileSync(userDbPath, JSON.stringify(db, null, 2));
                    message.edit(`RPC ${removedRpc.title || "sans nom"} (Id: ${removedRpc.id}) supprimé avec succès.`);
                } else {
                    message.edit(`Aucun RPC trouvé avec l'id ${removeId}.`);
                }
                break;

            case "list":
                if (rpcList.length === 0) {
                    message.edit("Aucun RPC n'a été configuré.");
                } else {
                    const listMessage = rpcList
                        .map(rpc => {
                            const title = rpc.title || "none";
                            const type = rpc.type || "none";
                            const details = rpc.details || "none";
                            return `***Id:*** \`${rpc.id}\` - ***Type:*** \`${type}\` - ***Titre:*** \`${title}\` - ***Détails:*** \`${details}\``;
                        })
                        .join('\n');
                    message.edit(`***Liste des RPC:***\n${listMessage}`);
                }
                break;

            case "clear":
                db.multi.rpcList = [];
                db.multi.rpcCount = 0;

                fs.writeFileSync(userDbPath, JSON.stringify(db, null, 2));
                message.edit("Tous les RPC ont été supprimés avec succès.");
                break;

            case "edit":
                const editId = parseInt(args[1], 10);
                const editField = args[2];
                const editValue = args.slice(3).join(' ');

                const options = ["title", "details", "type", "rpcsmallimage", "rpclargeimage"];
                const rpcToEdit = rpcList.find(rpc => rpc.id === editId);

                if (!rpcToEdit) {
                    message.edit(`Aucun RPC trouvé avec l'Id ${editId}.`);
                    return;
                }

                if (!options.includes(editField)) {
                    message.edit("Champ d'édition invalide.");
                    return;
                }

                rpcToEdit[editField] = editValue;
                db.multi.rpcList = rpcList;

                fs.writeFileSync(userDbPath, JSON.stringify(db, null, 2));

                let editMsg;
                switch (editField) {
                    case "title":
                        editMsg = "Le titre a été modifié avec succès.";
                        break;
                    case "details":
                        editMsg = "Les détails ont été modifiés avec succès.";
                        break;
                    case "type":
                        editMsg = "Le type a été modifié avec succès.";
                        break;
                    case "rpcsmallimage":
                    case "rpclargeimage":
                        editMsg = "L'image a été modifiée avec succès.";
                        break;
                }

                message.edit(editMsg);
                break;

            default:
                message.edit("Commande invalide. Utilisez `add`, `remove`, `list`, `clear` ou `edit`.");
        }
    }
};
