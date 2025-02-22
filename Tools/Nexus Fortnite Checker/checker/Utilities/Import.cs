// Decompiled with JetBrains decompiler
// Type: NexusFN.Utilities.Import
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;

#nullable disable
namespace NexusFN.Utilities
{
  internal class Import
  {
    [STAThread]
    public static void LoadShit()
    {
label_1:
      Colorful.Console.Clear();
      UIManager.PrintLogo();
      Colorful.Console.WriteLine();
      Colorful.Console.WriteFormatted("[{0}] Select Proxy Type [{1}] - HTTP/S | [{2}] - Socks4 | [{3}] - Socks5 | ", (object) "?", (object) "1", (object) "2", (object) "3", Color.Crimson, Color.White);
      Colorful.Console.WriteFormatted("[{0}] - Proxyless\n", (object) "4", Color.Crimson, Color.White);
      Colorful.Console.WriteFormatted("[{0}] ", (object) ">", Color.Crimson, Color.White);
      switch ((int) Colorful.Console.ReadKey().KeyChar - 49)
      {
        case 0:
          Variables.proxtype = ProxyType.HTTP;
          break;
        case 1:
          Variables.proxtype = ProxyType.Socks4;
          break;
        case 2:
          Variables.proxtype = ProxyType.Socks5;
          break;
        case 3:
          Variables.useproxies = false;
          break;
        default:
          goto label_1;
      }
      Colorful.Console.Clear();
      UIManager.PrintLogo();
      Variables.ccombos = ((IEnumerable<string>) File.ReadAllLines("Combo.txt")).ToList<string>();
      foreach (string ccombo in Variables.ccombos)
      {
        if (ccombo.Contains(":") || ccombo.Contains(";") || ccombo.Contains("|"))
          Variables.combos.Enqueue(ccombo);
      }
      Colorful.Console.WriteLineFormatted("\n[{0}] Loaded [{1}] combos from Combo.txt!", (object) "!", (object) Variables.ccombos.Count, Color.Crimson, Color.White);
      Thread.Sleep(1000);
      if (Variables.useproxies)
      {
        Variables.proxies = ((IEnumerable<string>) File.ReadAllLines("Proxies.txt")).ToList<string>();
        Colorful.Console.WriteLineFormatted("[{0}] Loaded [{1}] proxies from Proxies.txt!\n", (object) "!", (object) Variables.proxies.Count, Color.Crimson, Color.White);
      }
      Colorful.Console.WriteLineFormatted("[{0}] Enter the thread amount", (object) "?", Color.Crimson, Color.White);
      Colorful.Console.WriteFormatted("[{0}] ", (object) ">", Color.Crimson, Color.White);
      Variables.threadcount = int.Parse(Colorful.Console.ReadLine());
      Colorful.Console.WriteLineFormatted("[{0}] Press [{1}] to start checking.", (object) ">", (object) "ENTER", Color.Crimson, Color.White);
    }
  }
}
