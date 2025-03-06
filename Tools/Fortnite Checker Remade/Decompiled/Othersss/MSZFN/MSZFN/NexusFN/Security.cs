using System;
using System.IO;
using System.Reflection;
using System.Threading;
using KeyAuth;
using NexusFN.Utilities;

namespace NexusFN;

internal class Security
{
	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static api KeyAuthApp = new api("MSZ", "IYTm5vm9O6", "d8070f0140469cb048b7c79feb29cf700718fbed46c2d52a58be26d95087b19b", "1.0");

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void Startlogin()
	{
		KeyAuthApp.init();
		if (!File.Exists("Login.txt"))
		{
			File.Create("Login.txt");
		}
		string text;
		while (true)
		{
			try
			{
				text = File.ReadAllText("Login.txt");
			}
			catch
			{
				Thread.Sleep(500);
				continue;
			}
			break;
		}
		Thread.Sleep(1000);
		if (text == "")
		{
			goto IL_0085;
		}
		Variables.username = Variables.Parse(text, "user=", "&");
		Variables.password = Variables.Parse(text, "password=", "");
		goto IL_00b7;
		IL_0085:
		Console.Clear();
		UIManager.PrintLogoN();
		Console.Write("Enter your username: ");
		Variables.username = Console.ReadLine();
		Console.Write("Enter your password: ");
		Variables.password = Console.ReadLine();
		goto IL_00b7;
		IL_00b7:
		KeyAuthApp.login(Variables.username, Variables.password);
		if (KeyAuthApp.response.success)
		{
			File.WriteAllText("Login.txt", "user=" + Variables.username + "&password=" + Variables.password);
			return;
		}
		Console.WriteLine(KeyAuthApp.response.message);
		Thread.Sleep(2500);
		goto IL_0085;
	}
}
