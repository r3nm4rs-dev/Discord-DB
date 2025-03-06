// Decompiled with JetBrains decompiler
// Type: NexusFN.Utilities.Variables
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using Leaf.xNet;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

#nullable disable
namespace NexusFN.Utilities
{
  internal static class Variables
  {
    public static Stopwatch sw = new Stopwatch();
    public static bool checkerruning = false;
    public static int twofa = 0;
    public static int hits = 0;
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
    public static int sfa;
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
      int num1 = 0;
      int startIndex = 0;
      int num2;
      while ((num2 = text.IndexOf(subString, startIndex)) != -1)
      {
        startIndex = num2 + subString.Length;
        ++num1;
      }
      return num1;
    }

    public static string Parse(string source, string left, string right)
    {
      return source.Split(new string[1]{ left }, StringSplitOptions.None)[1].Split(new string[1]
      {
        right
      }, StringSplitOptions.None)[0];
    }

    private static void parseJSON(string A, string B, List<KeyValuePair<string, string>> jsonlist)
    {
      jsonlist.Add(new KeyValuePair<string, string>(A, B));
      if (B.StartsWith("["))
      {
        JArray jarray;
        try
        {
          jarray = JArray.Parse(B);
        }
        catch
        {
          return;
        }
        foreach (object child in jarray.Children())
          Variables.parseJSON("", child.ToString(), jsonlist);
      }
      if (!B.Contains("{"))
        return;
      JObject jobject;
      try
      {
        jobject = JObject.Parse(B);
      }
      catch
      {
        return;
      }
      foreach (KeyValuePair<string, JToken> keyValuePair in jobject)
        Variables.parseJSON(keyValuePair.Key, keyValuePair.Value.ToString(), jsonlist);
    }

    public static IEnumerable<string> JSON(
      string input,
      string field,
      bool recursive = false,
      bool useJToken = false)
    {
      List<string> source = new List<string>();
      if (useJToken)
      {
        if (recursive)
        {
          if (input.Trim().StartsWith("["))
          {
            using (IEnumerator<JToken> enumerator = JArray.Parse(input).SelectTokens(field, false).GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                JToken current = enumerator.Current;
                source.Add(current.ToString());
              }
              return (IEnumerable<string>) source;
            }
          }
          else
          {
            using (IEnumerator<JToken> enumerator = JObject.Parse(input).SelectTokens(field, false).GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                JToken current = enumerator.Current;
                source.Add(current.ToString());
              }
              return (IEnumerable<string>) source;
            }
          }
        }
        else if (input.Trim().StartsWith("["))
        {
          JArray jarray = JArray.Parse(input);
          source.Add(jarray.SelectToken(field, false).ToString());
        }
        else
        {
          JObject jobject = JObject.Parse(input);
          source.Add(jobject.SelectToken(field, false).ToString());
        }
      }
      else
      {
        List<KeyValuePair<string, string>> jsonlist = new List<KeyValuePair<string, string>>();
        Variables.parseJSON("", input, jsonlist);
        foreach (KeyValuePair<string, string> keyValuePair in jsonlist)
        {
          if (keyValuePair.Key == field)
            source.Add(keyValuePair.Value);
        }
        if (!recursive && source.Count > 1)
          source = new List<string>()
          {
            source.First<string>()
          };
      }
      return (IEnumerable<string>) source;
    }

    public static IEnumerable<string> LR(
      string input,
      string left,
      string right,
      bool recursive = false,
      bool useRegex = false)
    {
      if (left == string.Empty && right == string.Empty)
        return (IEnumerable<string>) new string[1]{ input };
      if (left != string.Empty && !input.Contains(left) || right != string.Empty && !input.Contains(right))
        return (IEnumerable<string>) new string[0];
      string input1 = input;
      List<string> stringList = new List<string>();
      if (recursive)
      {
        if (useRegex)
        {
          try
          {
            string pattern = Variables.BuildLRPattern(left, right);
            foreach (Match match in Regex.Matches(input1, pattern))
              stringList.Add(match.Value);
            return (IEnumerable<string>) stringList;
          }
          catch
          {
            return (IEnumerable<string>) stringList;
          }
        }
        else
        {
          try
          {
            string str1;
            string str2;
            for (; left == string.Empty || input1.Contains(left) && (right == string.Empty || input1.Contains(right)); input1 = str1.Substring(str2.Length + right.Length))
            {
              int startIndex = left == string.Empty ? 0 : input1.IndexOf(left) + left.Length;
              str1 = input1.Substring(startIndex);
              int length = right == string.Empty ? str1.Length - 1 : str1.IndexOf(right);
              str2 = str1.Substring(0, length);
              stringList.Add(str2);
            }
            return (IEnumerable<string>) stringList;
          }
          catch
          {
            return (IEnumerable<string>) stringList;
          }
        }
      }
      else
      {
        if (useRegex)
        {
          string pattern = Variables.BuildLRPattern(left, right);
          MatchCollection matchCollection = Regex.Matches(input1, pattern);
          if (matchCollection.Count > 0)
            stringList.Add(matchCollection[0].Value);
        }
        else
        {
          try
          {
            int startIndex = left == string.Empty ? 0 : input1.IndexOf(left) + left.Length;
            string str = input1.Substring(startIndex);
            int length = right == string.Empty ? str.Length : str.IndexOf(right);
            stringList.Add(str.Substring(0, length));
          }
          catch
          {
          }
        }
        return (IEnumerable<string>) stringList;
      }
    }

    private static string BuildLRPattern(string ls, string rs)
    {
      return "(?<=" + (string.IsNullOrEmpty(ls) ? "^" : Regex.Escape(ls)) + ").+?(?=" + (string.IsNullOrEmpty(rs) ? "$" : Regex.Escape(rs)) + ")";
    }
  }
}
