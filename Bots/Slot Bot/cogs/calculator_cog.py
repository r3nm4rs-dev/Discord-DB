from discord.ext import commands
from discord import NotFound, Embed
from discord_slash import cog_ext, SlashContext
from discord_slash.utils.manage_commands import create_option, create_choice

class CalculatorCog(commands.Cog):
    def __init__(self, bot):
        self.bot = bot

    @cog_ext.cog_slash(name='calculator', description='Perform a basic arithmetic operation',
                 options=[
                     create_option(
                         name='number1',
                         description='The first number',
                         option_type=10, # FLOAT type
                         required=True
                     ),
                     create_option(
                         name='operator',
                         description='The arithmetic operator',
                         option_type=3, # STRING type
                         required=True,
                         choices=[
                             create_choice(
                                 name='+ ┃ Add',
                                 value='+'
                             ),
                             create_choice(
                                 name='- ┃ Subtract',
                                 value='-'
                             ),
                             create_choice(
                                 name='* ┃ Multiply',
                                 value='*'
                             ),
                             create_choice(
                                 name='/ ┃ Divide',
                                 value='/'
                             )
                         ]
                     ),
                     create_option(
                         name='number2',
                         description='The second number',
                         option_type=10, # FLOAT type
                         required=True
                     )
                 ])
    async def calculator(self, ctx: SlashContext, number1: float, operator: str, number2: float):
        try:
            await ctx.defer()
        except NotFound:
            pass

        number1 = round(number1, 2)
        number2 = round(number2, 2)

        if operator == '+':
            result = number1 + number2
        elif operator == '-':
            result = number1 - number2
        elif operator == '*':
            result = number1 * number2
        elif operator == '/':
            if number2 == 0:
                await ctx.send('Error: Division by zero is not allowed')
                return
            result = number1 / number2

        result = round(result, 2)
        embed =Embed(title="Calculator", description=f"> `{number1} {operator} {number2}` = **`{result}`**", color=0xA608F5)
        embed.set_footer(text="YOUR TEXT", icon_url="YOUR URL")
        await ctx.send(embed=embed)

def setup(bot):
    bot.add_cog(CalculatorCog(bot))