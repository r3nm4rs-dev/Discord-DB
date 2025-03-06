using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace NexusFN.Utilities;

internal class ExportManager
{
	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void ExportSkins(string account, string username, int skincount, string skinslist, bool maybefa, string epicmail, bool stw, string lastlogin)
	{
		string text = Translate.GrabCosmetics(skinslist, "Skins");
		string text2;
		if (stw)
		{
			text2 = "True";
			Variables.stw++;
		}
		else
		{
			text2 = "False";
		}
		string text3;
		if (maybefa)
		{
			Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
			text3 = "True";
			Variables.sfa++;
			File.AppendAllText(Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Full Access.txt"), string.Concat(new string[2]
			{
				account + " | Epic Username: " + username + " | Full Access: " + text3 + " | Last Login " + lastlogin + " | Epic2fa : False | Epic Email: " + epicmail + " | Save The World: " + text2 + " | Skins [" + skincount + "]  " + text,
				"\n"
			}));
		}
		else
		{
			text3 = "False";
			Variables.nfa++;
		}
		string path = ((skincount == 0) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/0.txt") : ((skincount > 0 && skincount < 10) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/1-10.txt") : ((skincount >= 10 && skincount < 25) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/10-20.txt") : ((skincount >= 25 && skincount < 50) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/20-50.txt") : ((skincount >= 50 && skincount < 100) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/50-100.txt") : ((skincount >= 100 && skincount < 150) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/100-150.txt") : ((skincount >= 150 && skincount < 200) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/150-200.txt") : ((skincount >= 200 && skincount < 250) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/200-250.txt") : ((skincount <= 250) ? Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/Unknown Skins.txt") : Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Skins/250-500.txt"))))))))));
		lock (Variables.exportlock)
		{
			File.AppendAllText(path, string.Concat(new string[2]
			{
				account + " | Epic Username: " + username + " | Full Access: " + text3 + " | Last Login: " + lastlogin + " | Epic2fa: False | Epic Email: " + epicmail + " | Save The World: " + text2 + " | Skins [" + skincount + "]  " + text,
				"\n"
			}));
			File.AppendAllText(Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/") + "Final.txt", $"{account} | Epic Username: {username} | Epic Email : {epicmail} | Last Login: {lastlogin} | Epic2fa : False | Full Access : {maybefa} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]    " + "\n");
		}
		Variables.check++;
		Variables.okacc++;
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void ExportStats(string account, string username, int matchcount, bool maybefa, string epicmail, bool stw)
	{
		string text;
		if (maybefa)
		{
			text = "True";
			Variables.sfa++;
		}
		else
		{
			Variables.nfa++;
			text = "False";
		}
		string text2 = ((!stw) ? "False" : "True");
		string path = "";
		if (matchcount == 0)
		{
			path = Path.Combine();
		}
		else if (matchcount > 0 && matchcount < 500)
		{
			path = Path.Combine();
		}
		else if (matchcount >= 500 && matchcount < 1000)
		{
			path = Path.Combine();
		}
		else if (matchcount >= 1000 && matchcount < 2500)
		{
			path = Path.Combine();
		}
		else if (matchcount >= 2500 && matchcount < 5000)
		{
			path = Path.Combine();
		}
		else if (matchcount >= 5000 && matchcount < 10000)
		{
			path = Path.Combine();
		}
		else if (matchcount > 10000)
		{
			path = Path.Combine();
		}
		lock (Variables.exportlock)
		{
			File.AppendAllText(path, account + " | Epic Username: " + username + " | Full Access: " + text + " | Epic Email: " + epicmail + " | Save Thw World: " + text2 + " | Total Matches Played: " + matchcount);
		}
		Variables.check++;
		Variables.okacc++;
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void Retries(string combo)
	{
		Interlocked.Increment(ref Variables.retries);
		Variables.combos.Enqueue(combo);
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void ExportNonReg(string combo)
	{
		Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void ExportFlagged(string combo)
	{
		Interlocked.Increment(ref Variables.twofa);
		Interlocked.Increment(ref Variables.check);
		Interlocked.Increment(ref Variables.cpm);
		_ = Variables.exportlock;
		File.AppendAllText(Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/") + "Xbox2fa.txt", combo + "\n");
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void ExportBads(string combo)
	{
		Interlocked.Increment(ref Variables.bad);
		Interlocked.Increment(ref Variables.check);
		Interlocked.Increment(ref Variables.cpm);
		Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void ExportBanned(string combo)
	{
		string text = Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
		Interlocked.Increment(ref Variables.banned);
		Interlocked.Increment(ref Variables.check);
		Interlocked.Increment(ref Variables.cpm);
		lock (Variables.exportlock)
		{
			File.AppendAllText(text + "Unlinked.txt", combo + "\n");
		}
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void Epic2Fa(string account, string username, int skincount, string skinslist, bool maybefa, string epicmail, string stw, string lastlogin)
	{
		string text = Translate.GrabCosmetics(skinslist, "Skins");
		string text2 = Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
		string text3 = Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
		if (maybefa)
		{
			string text4 = "True";
			Variables.sfa++;
			File.AppendAllText(text2 + "Full Access.txt", $"{account} | Epic Username: {username} | Epic Email : {epicmail} | Last Login: {lastlogin} | Epic2fa : True | Full Access : {text4} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]    " + "\n");
			File.AppendAllText(text2 + "Final.txt", $"{account} | Epic Username: {username} | Epic Email : {epicmail} | Last Login: {lastlogin} | Epic2fa : True | Full Access : {text4} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]    " + "\n");
		}
		else
		{
			Variables.nfa++;
			string text4 = "False";
			File.AppendAllText(text2 + "Final.txt", $"{account} | Epic Username: {username} | Epic Email : {epicmail} | Last Login: {lastlogin} | Epic2fa : True | Full Access : {text4} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]    " + "\n");
		}
		Interlocked.Increment(ref Variables.epictwofa);
		Interlocked.Increment(ref Variables.check);
		Interlocked.Increment(ref Variables.cpm);
		lock (Variables.exportlock)
		{
			File.AppendAllText(text2 + "Epic Games 2fa.txt", $"{account} | Epic Username: {username} | Epic Email : {epicmail} | Last Login: {lastlogin} | Epic2fa : True | Full Access : {maybefa} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]    " + "\n");
			File.AppendAllText(text2 + "Final.txt", $"{account} | Epic Username: {username} | Epic Email : {epicmail} | Last Login: {lastlogin} | Epic2fa : True | Full Access : {maybefa} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]    " + "\n");
			File.AppendAllText(text3 + "Seller_Log.txt", $"Epic2fa : True | Full Access : {maybefa} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]    " + "\n");
		}
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void SellerLog(int skincount, string skinslist, bool maybefa, bool stw)
	{
		string text = Translate.GrabCosmetics(skinslist, "Skins");
		string text2 = Path.Combine("Checked/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
		if (maybefa)
		{
			File.AppendAllText(text2 + "Seller_Log.txt", $"Epic2fa : False | Full Access : {maybefa} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]  " + "\n");
		}
		Interlocked.Increment(ref Variables.epictwofa);
		Interlocked.Increment(ref Variables.check);
		Interlocked.Increment(ref Variables.cpm);
		lock (Variables.exportlock)
		{
			File.AppendAllText(text2 + "Seller_Log.txt", $"Epic2fa : False | Full Access : {maybefa} | STW : {stw} | Skin Count : {skincount} | Skins : [{text}]    " + "\n");
		}
	}
}
