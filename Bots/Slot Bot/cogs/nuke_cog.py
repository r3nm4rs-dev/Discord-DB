import discord
from discord.ext import commands
from discord_slash import cog_ext, SlashContext
from discord_slash.utils.manage_commands import create_option, create_choice
from discord import Embed

class NukeCog(commands.Cog):
    def __init__(self, bot):
        self.bot = bot

    @cog_ext.cog_slash(name='nuke', description='Remove and recreate a channel')
    @commands.has_permissions(administrator=True)
    async def nuke(self, ctx: SlashContext):
        channel = ctx.channel
        category = channel.category
        position = channel.position
        overwrites = channel.overwrites
        topic = channel.topic
        await channel.delete()

        new_channel = await category.create_text_channel(name=channel.name, position=position, overwrites=overwrites, topic=topic)
        embed = Embed(title='Channel Nuked', description=f'This channel was nuked by {ctx.author.mention}', color=0xff0000)
        await new_channel.send(embed=embed)
    
def setup(bot):
    bot.add_cog(NukeCog(bot))