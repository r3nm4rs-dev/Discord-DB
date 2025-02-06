const { getVoiceConnection } = require('@discordjs/voice');

module.exports = {
  name: "stop",
  description: "Arrête la musique et quitte le salon vocal",
  run: async (client, message, args) => {
  
    const voiceConnection = getVoiceConnection(message.guild.id);
    
    if (!voiceConnection) {
      return message.edit(`\`❌\` Je ne suis actuellement dans aucun salon vocal.`);
    }
    
  
    voiceConnection.destroy();
    
    message.edit(`\`✅\` La musique a été arrêtée et j'ai quitté le salon vocal.`);
  },
};
