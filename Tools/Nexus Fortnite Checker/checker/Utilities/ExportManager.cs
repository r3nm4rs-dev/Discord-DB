// Decompiled with JetBrains decompiler
// Type: NexusFN.Utilities.ExportManager
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

#nullable disable
namespace NexusFN.Utilities
{
  internal class ExportManager
  {
    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void ExportSkins(
      string account,
      string username,
      int skincount,
      string skinslist,
      bool maybefa,
      string epicmail,
      bool stw)
    {
      string str1 = Translate.GrabCosmetics(skinslist, "Skins");
      string str2;
      if (maybefa)
      {
        str2 = "Yes";
        ++Variables.sfa;
      }
      else
        str2 = "No";
      string str3;
      if (stw)
      {
        str3 = "Yes";
        ++Variables.stw;
      }
      else
        str3 = "No";
      string path;
      if (skincount == 0)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/0 Skins.txt");
      else if (skincount > 0 && skincount < 10)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/1+ Skins.txt");
      else if (skincount >= 10 && skincount < 25)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/10+ Skins.txt");
      else if (skincount >= 25 && skincount < 50)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/25+ Skins.txt");
      else if (skincount >= 50 && skincount < 100)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/50+ Skins.txt");
      else if (skincount >= 100 && skincount < 150)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/100+ Skins.txt");
      else if (skincount >= 150 && skincount < 200)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/150+ Skins.txt");
      else if (skincount >= 200 && skincount < 250)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/200+ Skins.txt");
      else if (skincount > 250)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/250+ Skins.txt");
      else
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker/Unknown Skins.txt");
      lock (Variables.exportlock)
        File.AppendAllText(path, account + " | Username: " + username + " | Maybe FA: " + str2 + " | Epic Email: " + epicmail + " | STW: " + str3 + " | Skins [" + skincount.ToString() + "]: " + str1 + "\n");
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void ExportStats(
      string account,
      string username,
      int matchcount,
      bool maybefa,
      string epicmail,
      bool stw)
    {
      string str1;
      if (maybefa)
      {
        str1 = "Yes";
        ++Variables.sfa;
      }
      else
        str1 = "No";
      string str2 = !stw ? "No" : "Yes";
      string path = "";
      if (matchcount == 0)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats/0 Matches.txt");
      else if (matchcount > 0 && matchcount < 500)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats/1+ Matches.txt");
      else if (matchcount >= 500 && matchcount < 1000)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats/500+ Matches.txt");
      else if (matchcount >= 1000 && matchcount < 2500)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats/1000+ Matches.txt");
      else if (matchcount >= 2500 && matchcount < 5000)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats/2500+ Matches.txt");
      else if (matchcount >= 5000 && matchcount < 10000)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats/5000+ Matches.txt");
      else if (matchcount > 10000)
        path = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats/10000+ Matches.txt");
      lock (Variables.exportlock)
        File.AppendAllText(path, account + " | Username: " + username + " | Maybe FA: " + str1 + " | Epic Email: " + epicmail + " | STW: " + str2 + " | Matches Played: " + matchcount.ToString());
      ++Variables.check;
      ++Variables.hits;
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
      Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
      Interlocked.Increment(ref Variables.nonreg);
      Interlocked.Increment(ref Variables.check);
      Interlocked.Increment(ref Variables.cpm);
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void ExportFlagged(string combo)
    {
      string str = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
      Interlocked.Increment(ref Variables.twofa);
      Interlocked.Increment(ref Variables.check);
      Interlocked.Increment(ref Variables.cpm);
      lock (Variables.exportlock)
        File.AppendAllText(str + "2fa.txt", combo + "\n");
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void ExportBads(string combo)
    {
      Interlocked.Increment(ref Variables.bad);
      Interlocked.Increment(ref Variables.check);
      Interlocked.Increment(ref Variables.cpm);
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void ExportBanned(string combo)
    {
      Interlocked.Increment(ref Variables.banned);
      Interlocked.Increment(ref Variables.check);
      Interlocked.Increment(ref Variables.cpm);
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void Epic2Fa(string combo)
    {
      string str = Path.Combine("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/");
      Interlocked.Increment(ref Variables.epictwofa);
      Interlocked.Increment(ref Variables.check);
      Interlocked.Increment(ref Variables.cpm);
      lock (Variables.exportlock)
        File.AppendAllText(str + "Epic 2fa.txt", combo + "\n");
    }
  }
}
