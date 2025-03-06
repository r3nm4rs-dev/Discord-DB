using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using Colorful;

namespace NexusFN.Utilities;

internal class UIManager
{
	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void PrintLogo()
	{
		Console.Write(" \t\t\t\t   ███╗   ███╗███████╗███████╗    ███████╗███╗   ██╗ \r\n \t\t\t\t  ████╗ ████║██╔════╝╚══███╔╝    ██╔════╝████╗  ██║ \r\n \t\t\t\t  ██╔████╔██║███████╗  ███╔╝     █████╗  ██╔██╗ ██║ \r\n \t\t\t\t  ██║╚██╔╝██║╚════██║ ███╔╝      ██╔══╝  ██║╚██╗██║ \r\n \t\t\t\t   ██║ ╚═╝ ██║███████║███████╗    ██║     ██║ ╚████║ \r\n\n\n", Color.LightSkyBlue);
		Console.Write("                                               Welcome To Pluzio Checker. | Aka OmesFN\n", Color.LightBlue);
		Console.Write("\t\t   That a Beta if u are questions or error dm e0s_ on discord\n", Color.LightBlue);
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void PrintLogoN()
	{
		Console.Write(" \t\t\t\t   ███╗   ███╗███████╗███████╗    ███████╗███╗   ██╗ \r\n \t\t\t\t  ████╗ ████║██╔════╝╚══███╔╝    ██╔════╝████╗  ██║ \r\n \t\t\t\t  ██╔████╔██║███████╗  ███╔╝     █████╗  ██╔██╗ ██║ \r\n \t\t\t\t  ██║╚██╔╝██║╚════██║ ███╔╝      ██╔══╝  ██║╚██╗██║ \r\n \t\t\t\t   ██║ ╚═╝ ██║███████║███████╗    ██║     ██║ ╚████║ \r\n\n\n", Color.LightSkyBlue);
		Console.Write("                                               Welcome To Pluzio Checker. | Aka OmesFN\n\n", Color.LightBlue);
		Console.Write("\t\t\t\tThat a Beta if u are questions or error dm e0s_ on discord \n\n\n", Color.LightBlue);
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void SwitchModes()
	{
		while (true)
		{
			if (Console.ReadKey().Key == ConsoleKey.C)
			{
				if (Variables.mode == "1")
				{
					Variables.mode = "2";
				}
				else if (Variables.mode == "2")
				{
					Variables.mode = "1";
				}
			}
		}
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void CUI()
	{
		while (true)
		{
			if (Variables.ccombos.Count <= Variables.check)
			{
				Variables.checkerruning = false;
			}
			if (Variables.checkerruning)
			{
				if (Variables.mode == "1")
				{
					Console.Clear();
					PrintLogo();
					Console.WriteLine();
					Console.WriteLine($"                 [{Variables.check}/{Variables.ccombos.Count}] CHECKING", Color.LightBlue);
					Console.WriteLine("                         │                       ", Color.LightYellow);
					Console.WriteLine("                         │                        ", Color.LightYellow);
					Console.WriteLine("                         │                         ", Color.LightYellow);
					Console.WriteLine("              ┌──────────┤                          ", Color.LightYellow);
					Console.WriteLine($"              │          └──────────────────┬── [{Variables.twohundredfiftyplus}] 250-400 Skins", Color.LightYellow);
					Console.WriteLine($"              │                             ├── [{Variables.twohundredplus}] 200-250 Skins", Color.LightYellow);
					Console.WriteLine($"              └─[{Variables.okacc}] Hit                     ├── [{Variables.hundredplus}] 100-150 Skins", Color.LightYellow);
					Console.WriteLine($"                [NFA/FA] [{Variables.nfa}/{Variables.sfa}]              ├── [{Variables.fiftyplus}] 50-100 Skins", Color.LightYellow);
					Console.WriteLine($"                [{Variables.sfa}] Full Access             ├── [{Variables.twentyfiveplus}] 20-50 Skins", Color.LightYellow);
					Console.WriteLine($"                [{Variables.epictwofa}] Epic 2fa                ├── [{Variables.tenplus}] 10-20 Skins", Color.LightYellow);
					Console.WriteLine($"                [{Variables.twofa}] Xbox 2fa                ├── [{Variables.oneplus}] 1-10 Skins", Color.LightYellow);
					Console.WriteLine($"                                            ├── [{Variables.zeroskin}] 0 Skins", Color.LightYellow);
					Console.WriteLine();
					Console.WriteLine();
					Variables.cpm = 0;
					Thread.Sleep(1000);
				}
			}
			else if (Variables.mode == "1")
			{
				Console.Clear();
				PrintLogo();
				Console.WriteLine($"                 [{Variables.ccombos.Count}] Results", Color.LightBlue);
				Console.WriteLine("                         │                       ", Color.LightYellow);
				Console.WriteLine("                         │                        ", Color.LightYellow);
				Console.WriteLine("                         │                         ", Color.LightYellow);
				Console.WriteLine("              ┌──────────┤                          ", Color.LightYellow);
				Console.WriteLine($"              │          └──────────────────┬── [{Variables.twohundredfiftyplus}] 250-400 Skins", Color.LightYellow);
				Console.WriteLine($"              │                             ├── [{Variables.twohundredplus}] 200-250 Skins", Color.LightYellow);
				Console.WriteLine($"              └─[{Variables.okacc}] Hit                     ├── [{Variables.hundredplus}] 100-150 Skins", Color.LightYellow);
				Console.WriteLine($"                [{Variables.bad}] Bad                     ├── [{Variables.fiftyplus}] 50-100 Skins", Color.LightYellow);
				Console.WriteLine($"                [NFA/FA] [{Variables.nfa}/{Variables.sfa}]             ├── [{Variables.twentyfiveplus}] 20-50 Skins", Color.LightYellow);
				Console.WriteLine($"                [{Variables.epictwofa}] Epic 2fa                ├── [{Variables.tenplus}] 10-20 Skins", Color.LightYellow);
				Console.WriteLine($"                [{Variables.twofa}] Xbox 2fa                ├── [{Variables.oneplus}] 1-10 Skins", Color.LightYellow);
				Console.WriteLine($"                                            ├── [{Variables.zeroskin}] 0 Skins", Color.LightYellow);
				Console.WriteLine();
				Thread.Sleep(-1);
			}
			else if (Variables.mode == "2")
			{
				Console.Clear();
				PrintLogo();
				Console.WriteLineFormatted("\n\n           Finished Checking!", (object)"C", Color.LightBlue, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  Hits               [{0}]", (object)Variables.okacc, (object)">>", Color.LimeGreen, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  Xbox 2fa           [{0}]", (object)Variables.twofa, (object)">>", Color.Orange, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  EpicGames 2fa      [{0}]", (object)Variables.epictwofa, (object)">>", Color.DarkOrange, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  Full Access        [{0}]", (object)Variables.sfa, (object)">>", Color.MistyRose, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  Unlinked Epic      [{0}]", (object)Variables.banned, (object)">>", Color.Gray, Color.White);
				Console.WriteLine();
				Console.WriteLineFormatted("                                              [{1}]  10,000-20,000 Matches  [{0}]", (object)Variables.tenkmplus, (object)">>", Color.Crimson, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  5,000-10,000  Matches  [{0}]", (object)Variables.fivekmplus, (object)">>", Color.Crimson, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  2,500-5,000  Matches   [{0}]", (object)Variables.twoandhalfandmplus, (object)">>", Color.Crimson, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  1,000-2,500  Matches   [{0}]", (object)Variables.hundredplus, (object)">>", Color.Crimson, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  500-1000    Matches    [{0}]", (object)Variables.fivehundredmplus, (object)">>", Color.Crimson, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  1-500      Matches     [{0}]", (object)Variables.onemplus, (object)">>", Color.Crimson, Color.White);
				Console.WriteLine();
				Console.WriteLineFormatted("                                              [{1}]  NO SKINS         [{0}]", (object)Variables.zeroskin, (object)">>", Color.Gray, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  OG ACCOUNTS      [{0}]", (object)Variables.ogs, (object)">>", Color.MediumPurple, Color.White);
				Console.WriteLineFormatted("                                              [{1}]  SAVE THE WORLD   [{0}]", (object)Variables.stw, (object)">>", Color.SandyBrown, Color.White);
				Console.WriteLine();
				Console.WriteLineFormatted("                                              [{1}]  Checking  [{0}]", (object)(Variables.sw.Elapsed.Minutes + "m " + Variables.sw.Elapsed.Seconds + "s"), (object)">>", Color.WhiteSmoke, Color.White);
				Thread.Sleep(-1);
			}
		}
	}
}
