from discord.ext import commands
from discord_slash import cog_ext, SlashContext
from discord_slash.utils.manage_commands import create_option
from discord_slash.model import ButtonStyle
from discord import Embed

class BuyCommandCog(commands.Cog):
    def __init__(self, bot):
        self.bot = bot

    @cog_ext.cog_slash(name='buy', description='Send a promotion embed with a button to buy the bot')
    async def buy(self, ctx: SlashContext):
        embed = Embed(title="<:shop:1187822586135068722>Shop Bot<:betabadge:1187684372934053909>", description="**`Everything you need for you Discord Store`**", color=0xA608F5)
        embed.add_field(name="**<:shop:1187822586135068722>Slot Moderation┃(Paid)**", value="**/slot** - Creates a slot channel with specified user access, duration, role, and category \n **/renew** - Renews a slot channel with specified user and duration \n **/revoke** - Revoke access to a slot channel and schedule its deletion \n **/limits** - Set the maximum ping limits for each role \n **/ping** - Pings @here or @everyone and writes it down in database so no one can exceed the limit \n **/reset** - Resets ping limits for desired user.", inline=True)
        embed.add_field(name="**<:modernmodmail:1187699416438677596>Backup System┃(Paid)**", value="**/backup** - Creates a backup of the server (Saves: Messages, Channels, Categorys, Roles, Emojis, Permissions) \n **/loadbackup** - Loads a backup of the server \n **/autobackup** - Automatically backups the server in desired timeframe", inline=True)
        embed.add_field(name="**<:modernstaff:1187699405848068106>Utility┃(Free)**", value="**/restock** - Sends a restock command \n **/remove** - Deletes a desired channel \n **/purge** - Deletes a desired ammount of messages \n **/nuke** - Deletes and recreate a channel with same name and permissions \n **/getbal** - Gets a balance of a LTC adress \n **/calculator** - A basic calculator that can Devide, Multiply, Add, Subtract \n **/help** - Provides help for commands", inline=True)
        embed.add_field(name="**<a:pay:1187684323588063262>Pricing**", value="> 1€ Week \n> 3€ Month \n> 6€ Lifetime \n> 12€ Rebrand ", inline=True)
        embed.add_field(name="**<:modernserverguide:1187699395597193267>Reseller Plan Bundles**", value="**`5€ Week`**\n (Comes with: 2x Week Key 2x Month key 1x Lifetime key)\n**`10€ Month`**\n (Comes with: 3x Week Key 3x Month key 4x Lifetime key)\n**`15€ Lifetime`**\n(Comes with: 3x Week Key 5x Month key 6x Lifetime key) ", inline=True)
        embed.add_field(name="**<:modernrules:1187699399632113694>Reseller Plan Prices**", value="> 0.5€ Week \n> 1.5€ Month \n> 3€ Lifetime \n> 8€ Rebrand \n **Rules:** \n To buy this you need to buy Reseller Bundle at first.\n You cant sell cheaper than me.", inline=True)
        embed.set_footer(text=".gg/pluzio ┃ Made by r3nm4rss", icon_url="https://cdn.discordapp.com/attachments/1187683452603093002/1187761268975747152/Logo.gif?ex=65980fe2&is=65859ae2&hm=925938dc49562f6bde33330f610a1a3a1711dd3bbac88c5f981520287bac866f&")
        await ctx.send(
            embed=embed,
            components=[
                {
                    "type": 1,
                    "components": [
                        {
                            "type": 2,
                            "label": "Buy Now",
                            "style": ButtonStyle.URL,
                            "url": "https://zeroservices.sellpass.io/products/Shop-Bot"
                        },
                        {
                            "type": 2,
                            "label": "Invite Bot",
                            "style": ButtonStyle.URL,
                            "url": "https://discord.com/api/oauth2/authorize?client_id=1166235689990504468&permissions=8&scope=bot%20applications.commands"  # Replace with your bot's invite URL
                        }
                    ]
                }
            ]
        )

def setup(bot):
    bot.add_cog(BuyCommandCog(bot))