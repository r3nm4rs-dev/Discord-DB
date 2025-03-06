using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using Leaf.xNet;

namespace NexusFN.Utilities;

internal class Translate
{
	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static string GrabCosmetics(string items, string itemType)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		int location = 0;
		List<string> list = new List<string>();
		string text = "";
		try
		{
			HttpRequest val = new HttpRequest();
			try
			{
				string[] separator = new string[1] { "," };
				string[] array = items.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				foreach (string text2 in array)
				{
					string text3 = ExtractNameFromResponse(((object)val.Get("https://fortnite-api.com/v2/cosmetics/br/" + text2, (RequestParams)null)).ToString());
					if (!string.IsNullOrEmpty(text3))
					{
						Interlocked.Increment(ref location);
						list.Add(text3);
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			foreach (string item in list)
			{
				text = ((!(text == "")) ? (text + ", " + item) : (text + item));
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
			File.AppendAllText("Trans error.txt", ex.Message);
		}
		return text;
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static string ExtractNameFromResponse(string response)
	{
		string pattern = "\"name\":\"(.*?)\"";
		Match match = Regex.Match(response, pattern);
		if (match.Success)
		{
			return match.Groups[1].Value.Replace("\\u0027", "'");
		}
		return null;
	}
}
