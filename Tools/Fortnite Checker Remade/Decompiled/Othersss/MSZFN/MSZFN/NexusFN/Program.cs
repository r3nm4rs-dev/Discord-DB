using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Colorful;
using NexusFN.Utilities;

namespace NexusFN;

internal class Program
{
	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	private const string currentVersion = "1.0.0";

	private static async Task Main(string[] args)
	{
		Console.Title = "MSZ - LOGIN";
		Console.Write(" \t\t\t\t   ███╗   ███╗███████╗███████╗    ███████╗███╗   ██╗ \r\n \t\t\t\t  ████╗ ████║██╔════╝╚══███╔╝    ██╔════╝████╗  ██║ \r\n \t\t\t\t  ██╔████╔██║███████╗  ███╔╝     █████╗  ██╔██╗ ██║ \r\n \t\t\t\t  ██║╚██╔╝██║╚════██║ ███╔╝      ██╔══╝  ██║╚██╗██║ \r\n \t\t\t\t   ██║ ╚═╝ ██║███████║███████╗    ██║     ██║ ╚████║ \r\n\n\n", Color.LightYellow);
		Console.Write("                            @e0s_ IF YOU HAVE PROBLEME DM ME TO FIXE THAT  \n\n ", Color.LightCoral);
		Start(args);
	}

	private static async Task<bool> CheckVersionAsync()
	{
		string text = "https://12009080-aa42-4843-96b5-ad23ec84f54d-00-3i1bgs81g0cbe.worf.replit.dev:8080/API/VERSION";
		try
		{
			HttpClient client = new HttpClient();
			try
			{
				HttpResponseMessage val = await client.GetAsync(text);
				if (val.IsSuccessStatusCode)
				{
					return "1.0.0".Equals((await val.Content.ReadAsStringAsync()).Trim(), StringComparison.OrdinalIgnoreCase);
				}
				return false;
			}
			finally
			{
				((IDisposable)client)?.Dispose();
			}
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static async Task<bool> CheckAPI()
	{
		string text = "https://12009080-aa42-4843-96b5-ad23ec84f54d-00-3i1bgs81g0cbe.worf.replit.dev:8080/API/VERSION";
		try
		{
			HttpClient client = new HttpClient();
			try
			{
				HttpResponseMessage val = await client.GetAsync(text);
				if (val.IsSuccessStatusCode)
				{
					return "1.0.0".Equals((await val.Content.ReadAsStringAsync()).Trim(), StringComparison.OrdinalIgnoreCase);
				}
				return false;
			}
			finally
			{
				((IDisposable)client)?.Dispose();
			}
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static async Task<bool> CheckLicenseKeyAsync(string key)
	{
		string text = "https://12009080-aa42-4843-96b5-ad23ec84f54d-00-3i1bgs81g0cbe.worf.replit.dev:8080/API/Check/" + key;
		try
		{
			HttpClient client = new HttpClient();
			try
			{
				HttpResponseMessage val = await client.GetAsync(text ?? "");
				if (val.IsSuccessStatusCode)
				{
					return (await val.Content.ReadAsStringAsync()).Equals("true", StringComparison.OrdinalIgnoreCase);
				}
				return false;
			}
			finally
			{
				((IDisposable)client)?.Dispose();
			}
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static void Start(string[] args)
	{
		Console.Title = "MSZ - CHECKER";
		Console.SetWindowSize(120, 40);
		Console.CursorVisible = false;
		Variables.useproxies = true;
		Variables.checkerruning = true;
		CreateFLD();
		Import.LoadShit();
		Variables.checkerruning = true;
		Variables.sw.Start();
		Thread thread = new Thread(UIManager.CUI);
		thread.IsBackground = false;
		thread.Start();
		Thread thread2 = new Thread(UIManager.SwitchModes);
		thread2.IsBackground = true;
		thread2.Start();
		try
		{
			Threading.StartChecking();
		}
		catch (Exception)
		{
		}
	}

	private static void test(string[] args)
	{
		Console.Title = "MSZ - CHECKING";
		Console.SetWindowSize(120, 40);
		Console.CursorVisible = false;
		Security.Startlogin();
	}

	private static void CreateFLD()
	{
		if (!Directory.Exists("Checked" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins"))
		{
			Directory.CreateDirectory("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins");
		}
		if (!Directory.Exists("Checked" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm")))
		{
			Directory.CreateDirectory("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm"));
		}
	}

	public static void AsResult(string fileName, string content)
	{
		string path = Path.Combine("Checked/" + Variables.module + "/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm"), fileName + ".txt");
		lock (Variables.exportlock)
		{
			File.AppendAllText(path, content + Environment.NewLine);
		}
	}
}
