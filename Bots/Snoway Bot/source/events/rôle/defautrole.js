const Discord = require("discord.js");
const Pluzio = require("../../structures/client/index");

module.exports = {
    name: "guildMemberAdd",
    /**
     *
     * @param {Pluzio} client
     * 
     */
    run: async (client, member) => {
        if(!member)return;
        const db = await client.db.get(`defautrole_${member.guild.id}`) || { roles: [] };
        for (const roleId of db.roles) {
            const role = member.guild.roles.cache.get(roleId);
            if (role) {
                member.roles.add(role).catch(e => { });
            }
        }
    }
}