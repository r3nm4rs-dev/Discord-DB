// Decompiled with JetBrains decompiler
// Type: NexusFN.Utilities.Translate
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;

#nullable disable
namespace NexusFN.Utilities
{
  internal class Translate
  {
    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static string GrabCosmetics(string items, string itemType)
    {
      int location = 0;
      List<string> stringList = new List<string>();
      string str1 = "";
      try
      {
        using (HttpRequest httpRequest = new HttpRequest())
        {
          string[] separator = new string[1]{ "," };
          foreach (string str2 in items.Split(separator, StringSplitOptions.RemoveEmptyEntries))
          {
            string nameFromResponse = Translate.ExtractNameFromResponse(httpRequest.Get("https://fortnite-api.com/v2/cosmetics/br/" + str2).ToString());
            if (!string.IsNullOrEmpty(nameFromResponse))
            {
              Interlocked.Increment(ref location);
              stringList.Add(nameFromResponse);
            }
          }
        }
        foreach (string str3 in stringList)
          str1 = !(str1 == "") ? str1 + ", " + str3 : str1 + str3;
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error: " + ex.Message);
        File.AppendAllText("Trans error.txt", ex.Message);
      }
      return str1;
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static string ExtractNameFromResponse(string response)
    {
      string pattern = "\"name\":\"(.*?)\"";
      Match match = Regex.Match(response, pattern);
      return match.Success ? match.Groups[1].Value.Replace("\\u0027", "'") : (string) null;
    }
  }
}
