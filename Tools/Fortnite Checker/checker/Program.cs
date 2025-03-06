// Decompiled with JetBrains decompiler
// Type: NexusFN.Program
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using NexusFN.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

#nullable disable
namespace NexusFN
{
  internal class Program
  {
    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    private static void Main(string[] args)
    {
      Console.Title = "Pluto FN - Authentication";
      Console.SetWindowSize(120, 40);
      Console.CursorVisible = false;
      Variables.useproxies = true;
      Variables.checkerruning = true;
      Program.CreateFLD();
      Import.LoadShit();
      Variables.checkerruning = true;
      Variables.sw.Start();
      new Thread(new ThreadStart(UIManager.CUI))
      {
        IsBackground = false
      }.Start();
      new Thread(new ThreadStart(UIManager.SwitchModes))
      {
        IsBackground = true
      }.Start();
      try
      {
        NexusFN.Utilities.Threading.StartChecking();
      }
      catch (Exception ex)
      {
      }
    }

    private static void CreateFLD()
    {
      if (!Directory.Exists("Results" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats"))
        Directory.CreateDirectory("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Stats");
      if (!Directory.Exists("Results" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker"))
        Directory.CreateDirectory("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm") + "/Locker");
      if (Directory.Exists("Results" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm")))
        return;
      Directory.CreateDirectory("Results/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm"));
    }

    public static void AsResult(string fileName, string content)
    {
      string path = Path.Combine("Results/" + Variables.module + "/" + Process.GetCurrentProcess().StartTime.ToString("dd-MM-yyyy-hh-mm"), fileName + ".txt");
      lock (Variables.exportlock)
        File.AppendAllText(path, content + Environment.NewLine);
    }
  }
}
