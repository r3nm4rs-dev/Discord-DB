using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Leaf.xNet;
using Newtonsoft.Json.Linq;

namespace NexusFN.Utilities;

internal static class Variables
{
	public static Stopwatch sw = new Stopwatch();

	public static bool checkerruning = false;

	public static int twofa = 0;

	public static int okacc = 0;

	public static int bad = 0;

	public static int check = 0;

	public static int frees = 0;

	public static int flagged = 0;

	public static int tocheck = 0;

	public static int threadcount = 0;

	public static int retries = 0;

	public static int perrors = 0;

	public static string username;

	public static string proxytype;

	public static int custom = 0;

	public static int cpm = 0;

	public static ConcurrentQueue<string> combos = new ConcurrentQueue<string>();

	public static List<string> proxies = new List<string>();

	public static List<string> ccombos = new List<string>();

	public static bool useproxies = true;

	public static string module;

	public static List<Func<string, bool>> Methods = new List<Func<string, bool>>();

	public static List<Thread> threads = new List<Thread>();

	public static string inboxword = "";

	public static bool isinbox = false;

	public static readonly object exportlock = new object();

	public static string path;

	public static int nonreg;

	public static string cookiess;

	public static int epictwofa;

	public static int looted;

	public static int fullaccess;

	public static int notfullaccess;

	public static int sfa;

	public static int nfa;

	public static string password;

	public static ProxyType proxtype;

	public static int rares;

	public static int weird;

	public static int bans;

	public static int stw;

	public static int zeroskin;

	public static int oneplus;

	public static int tenplus;

	public static int twentyfiveplus;

	public static int fiftyplus;

	public static int hundredplus;

	public static int hundredfiftyplus;

	public static int twohundredplus;

	public static int twohundredfiftyplus;

	public static int BlackK;

	public static int SparkleS;

	public static int BlueS;

	public static int TheR;

	public static int Galaxy;

	public static int Ikonik;

	public static int Glow;

	public static int RoyaleB;

	public static int PsychoB;

	public static int TravisS;

	public static int Trailblazer;

	public static int AssaultT;

	public static int Wonder;

	public static int Wildcat;

	public static int OGSkull;

	public static int OGGhoul;

	public static int RenegadeR;

	public static int ogs;

	public static int banned;

	public static int zeromatches;

	public static int onemplus;

	public static int fivehundredmplus;

	public static int onekmplus;

	public static int twoandhalfandmplus;

	public static int fivekmplus;

	public static int tenkmplus;

	public static int privatestats;

	public static string mode = "1";

	public static int CountOccurrences(string text, string subString)
	{
		int num = 0;
		int startIndex = 0;
		while ((startIndex = text.IndexOf(subString, startIndex)) != -1)
		{
			startIndex += subString.Length;
			num++;
		}
		return num;
	}

	public static string Parse(string source, string left, string right)
	{
		return source.Split(new string[1] { left }, StringSplitOptions.None)[1].Split(new string[1] { right }, StringSplitOptions.None)[0];
	}

	private static void parseJSON(string A, string B, List<KeyValuePair<string, string>> jsonlist)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		jsonlist.Add(new KeyValuePair<string, string>(A, B));
		if (B.StartsWith("["))
		{
			JArray val = null;
			try
			{
				val = JArray.Parse(B);
			}
			catch
			{
				return;
			}
			foreach (JToken item in ((JToken)val).Children())
			{
				parseJSON("", ((object)item).ToString(), jsonlist);
			}
		}
		if (!B.Contains("{"))
		{
			return;
		}
		JObject val2 = null;
		try
		{
			val2 = JObject.Parse(B);
		}
		catch
		{
			return;
		}
		foreach (KeyValuePair<string, JToken> item2 in val2)
		{
			parseJSON(item2.Key, ((object)item2.Value).ToString(), jsonlist);
		}
	}

	public static IEnumerable<string> JSON(string input, string field, bool recursive = false, bool useJToken = false)
	{
		List<string> list = new List<string>();
		if (useJToken)
		{
			if (recursive)
			{
				if (input.Trim().StartsWith("["))
				{
					foreach (JToken item in ((JToken)JArray.Parse(input)).SelectTokens(field, false))
					{
						list.Add(((object)item).ToString());
					}
					return list;
				}
				{
					foreach (JToken item2 in ((JToken)JObject.Parse(input)).SelectTokens(field, false))
					{
						list.Add(((object)item2).ToString());
					}
					return list;
				}
			}
			if (input.Trim().StartsWith("["))
			{
				JArray val = JArray.Parse(input);
				list.Add(((object)((JToken)val).SelectToken(field, false)).ToString());
			}
			else
			{
				JObject val2 = JObject.Parse(input);
				list.Add(((object)((JToken)val2).SelectToken(field, false)).ToString());
			}
		}
		else
		{
			List<KeyValuePair<string, string>> list2 = new List<KeyValuePair<string, string>>();
			parseJSON("", input, list2);
			foreach (KeyValuePair<string, string> item3 in list2)
			{
				if (item3.Key == field)
				{
					list.Add(item3.Value);
				}
			}
			if (!recursive && list.Count > 1)
			{
				list = new List<string> { list.First() };
			}
		}
		return list;
	}

	public static IEnumerable<string> LR(string input, string left, string right, bool recursive = false, bool useRegex = false)
	{
		if (left == string.Empty && right == string.Empty)
		{
			return new string[1] { input };
		}
		if ((left != string.Empty && !input.Contains(left)) || (right != string.Empty && !input.Contains(right)))
		{
			return new string[0];
		}
		string text = input;
		List<string> list = new List<string>();
		if (recursive)
		{
			if (useRegex)
			{
				try
				{
					string pattern = BuildLRPattern(left, right);
					foreach (Match item in Regex.Matches(text, pattern))
					{
						list.Add(item.Value);
					}
					return list;
				}
				catch
				{
					return list;
				}
			}
			try
			{
				while (left == string.Empty || (text.Contains(left) && (right == string.Empty || text.Contains(right))))
				{
					int startIndex = ((!(left == string.Empty)) ? (text.IndexOf(left) + left.Length) : 0);
					text = text.Substring(startIndex);
					string text2 = text[..((right == string.Empty) ? (text.Length - 1) : text.IndexOf(right))];
					list.Add(text2);
					text = text.Substring(text2.Length + right.Length);
				}
				return list;
			}
			catch
			{
				return list;
			}
		}
		if (useRegex)
		{
			string pattern2 = BuildLRPattern(left, right);
			MatchCollection matchCollection = Regex.Matches(text, pattern2);
			if (matchCollection.Count > 0)
			{
				list.Add(matchCollection[0].Value);
			}
		}
		else
		{
			try
			{
				int startIndex2 = ((!(left == string.Empty)) ? (text.IndexOf(left) + left.Length) : 0);
				text = text.Substring(startIndex2);
				list.Add(text[..((right == string.Empty) ? text.Length : text.IndexOf(right))]);
			}
			catch
			{
			}
		}
		return list;
	}

	private static string BuildLRPattern(string ls, string rs)
	{
		string text = (string.IsNullOrEmpty(ls) ? "^" : Regex.Escape(ls));
		string text2 = (string.IsNullOrEmpty(rs) ? "$" : Regex.Escape(rs));
		return "(?<=" + text + ").+?(?=" + text2 + ")";
	}
}
