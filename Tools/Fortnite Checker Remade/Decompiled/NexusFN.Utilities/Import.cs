using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;

namespace NexusFN.Utilities;

internal class Import
{
	[STAThread]
	public static void LoadShit()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			Console.Clear();
			UIManager.PrintLogo();
			Console.WriteLine();
			Console.WriteLine("Proxy Mode : [1] Proxyless", Color.LightBlue);
			Console.WriteLine("Proxy Mode : [2] Soon", Color.LightBlue);
			Console.Write("\n ", Color.LightGoldenrodYellow, Color.White, Array.Empty<object>());
			switch (Console.ReadKey().KeyChar)
			{
			default:
				continue;
			case '1':
				Variables.useproxies = false;
				break;
			}
			break;
		}
		Console.Clear();
		UIManager.PrintLogo();
		Variables.ccombos = File.ReadAllLines("Input/Accounts.txt").ToList();
		foreach (string ccombo in Variables.ccombos)
		{
			if (ccombo.Contains(":") || ccombo.Contains(";") || ccombo.Contains("|"))
			{
				Variables.combos.Enqueue(ccombo);
			}
		}
		Thread.Sleep(1000);
		if (Variables.useproxies)
		{
			Variables.proxies = File.ReadAllLines("Input/Proxies.txt").ToList();
		}
		Console.Write("Thread Amount", (object)"", Color.LightCyan, Color.LightBlue);
		Variables.threadcount = int.Parse(Console.ReadLine());
		Console.Write("[{0}] Press [{1}] to start checking.", (object)">", (object)"ENTER", Color.LightGreen, Color.White);
		File.AppendAllText(Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/") + "Seller_Log.txt", "SELLER LOG BY @OMESFN\n\n");
	}
}
