// Decompiled with JetBrains decompiler
// Type: NexusFN.Utilities.UIManager
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using System;
using System.Drawing;
using System.Reflection;
using System.Threading;

#nullable disable
namespace NexusFN.Utilities
{
  internal class UIManager
  {
    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void PrintLogo()
    {
      Colorful.Console.Write(""""
          _____                    _____            _____                _____                   _______         
         /\    \                  /\    \          /\    \              /\    \                 /::\    \        
        /::\    \                /::\____\        /::\____\            /::\    \               /::::\    \       
       /::::\    \              /:::/    /       /:::/    /            \:::\    \             /::::::\    \      
      /::::::\    \            /:::/    /       /:::/    /              \:::\    \           /::::::::\    \     
     /:::/\:::\    \          /:::/    /       /:::/    /                \:::\    \         /:::/~~\:::\    \    
    /:::/__\:::\    \        /:::/    /       /:::/    /                  \:::\    \       /:::/    \:::\    \   
   /::::\   \:::\    \      /:::/    /       /:::/    /                   /::::\    \     /:::/    / \:::\    \  
  /::::::\   \:::\    \    /:::/    /       /:::/    /      _____        /::::::\    \   /:::/____/   \:::\____\ 
 /:::/\:::\   \:::\____\  /:::/    /       /:::/____/      /\    \      /:::/\:::\    \ |:::|    |     |:::|    |
/:::/  \:::\   \:::|    |/:::/____/       |:::|    /      /::\____\    /:::/  \:::\____\|:::|____|     |:::|    |
\::/    \:::\  /:::|____|\:::\    \       |:::|____\     /:::/    /   /:::/    \::/    / \:::\    \   /:::/    / 
 \/_____/\:::\/:::/    /  \:::\    \       \:::\    \   /:::/    /   /:::/    / \/____/   \:::\    \ /:::/    /  
          \::::::/    /    \:::\    \       \:::\    \ /:::/    /   /:::/    /             \:::\    /:::/    /   
           \::::/    /      \:::\    \       \:::\    /:::/    /   /:::/    /               \:::\__/:::/    /    
            \::/____/        \:::\    \       \:::\__/:::/    /    \::/    /                 \::::::::/    /     
             ~~               \:::\    \       \::::::::/    /      \/____/                   \::::::/    /      
                               \:::\    \       \::::::/    /                                  \::::/    /       
                                \:::\____\       \::::/    /                                    \::/____/        
                                 \::/    /        \::/____/                                      ~~              
                                  \/____/          ~~                                                            
                                                                                                                 
"""", Color.Crims                                         on);
      Colorful.Console.Write("                                                     Have a nice day " + Variables.username + "!\n", Color.White);
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void PrintLogoN()
    {
      Colorful.Console.Write(""
          _____                    _____            _____                _____                   _______         
         /\    \                  /\    \          /\    \              /\    \                 /::\    \        
        /::\    \                /::\____\        /::\____\            /::\    \               /::::\    \       
       /::::\    \              /:::/    /       /:::/    /            \:::\    \             /::::::\    \      
      /::::::\    \            /:::/    /       /:::/    /              \:::\    \           /::::::::\    \     
     /:::/\:::\    \          /:::/    /       /:::/    /                \:::\    \         /:::/~~\:::\    \    
    /:::/__\:::\    \        /:::/    /       /:::/    /                  \:::\    \       /:::/    \:::\    \   
   /::::\   \:::\    \      /:::/    /       /:::/    /                   /::::\    \     /:::/    / \:::\    \  
  /::::::\   \:::\    \    /:::/    /       /:::/    /      _____        /::::::\    \   /:::/____/   \:::\____\ 
 /:::/\:::\   \:::\____\  /:::/    /       /:::/____/      /\    \      /:::/\:::\    \ |:::|    |     |:::|    |
/:::/  \:::\   \:::|    |/:::/____/       |:::|    /      /::\____\    /:::/  \:::\____\|:::|____|     |:::|    |
\::/    \:::\  /:::|____|\:::\    \       |:::|____\     /:::/    /   /:::/    \::/    / \:::\    \   /:::/    / 
 \/_____/\:::\/:::/    /  \:::\    \       \:::\    \   /:::/    /   /:::/    / \/____/   \:::\    \ /:::/    /  
          \::::::/    /    \:::\    \       \:::\    \ /:::/    /   /:::/    /             \:::\    /:::/    /   
           \::::/    /      \:::\    \       \:::\    /:::/    /   /:::/    /               \:::\__/:::/    /    
            \::/____/        \:::\    \       \:::\__/:::/    /    \::/    /                 \::::::::/    /     
             ~~               \:::\    \       \::::::::/    /      \/____/                   \::::::/    /      
                               \:::\    \       \::::::/    /                                  \::::/    /       
                                \:::\____\       \::::/    /                                    \::/____/        
                                 \::/    /        \::/____/                                      ~~              
                                  \/____/          ~~                                                            
                                                                                                                 
"", Color.Crimson);
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void SwitchModes()
    {
      while (true)
      {
        if (Colorful.Console.ReadKey().Key == ConsoleKey.C)
        {
          switch (Variables.mode)
          {
            case "1":
              Variables.mode = "2";
              break;
            case "2":
              Variables.mode = "1";
              break;
          }
        }
      }
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void CUI()
    {
      while (true)
      {
        if (Variables.ccombos.Count <= Variables.check)
          Variables.checkerruning = false;
        TimeSpan elapsed;
        int num;
        if (Variables.checkerruning)
        {
          switch (Variables.mode)
          {
            case "1":
              Colorful.Console.Clear();
              UIManager.PrintLogo();
              Colorful.Console.WriteLineFormatted("\n\nPress [{0}] to cycle between Stats and Locker", (object) "C", Color.LightBlue, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Progress      [{0}/{2}]", (object) Variables.check, (object) ">>", (object) Variables.ccombos.Count, Color.Crimson, Color.White);
              Colorful.Console.WriteLine();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Hits          [{0}]", (object) Variables.hits, (object) ">>", Color.LimeGreen, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  2fa           [{0}]", (object) Variables.twofa, (object) ">>", Color.Orange, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Epic 2fa      [{0}]", (object) Variables.epictwofa, (object) ">>", Color.DarkOrange, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Maybe FA      [{0}]", (object) Variables.sfa, (object) ">>", Color.MistyRose, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Looted        [{0}]", (object) Variables.banned, (object) ">>", Color.Gray, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Fails         [{0}]", (object) Variables.bad, (object) ">>", Color.OrangeRed, Color.White);
              Colorful.Console.WriteLine();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  250+ Skins    [{0}]", (object) Variables.twohundredfiftyplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  200+ Skins    [{0}]", (object) Variables.twohundredplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  150+ Skins    [{0}]", (object) Variables.hundredfiftyplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  100+ Skins    [{0}]", (object) Variables.hundredplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  50+  Skins    [{0}]", (object) Variables.fiftyplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  25+  Skins    [{0}]", (object) Variables.twentyfiveplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  10+  Skins    [{0}]", (object) Variables.tenplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  1+   Skins    [{0}]", (object) Variables.oneplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  0    Skins    [{0}]", (object) Variables.zeroskin, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLine();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  STW           [{0}]", (object) Variables.stw, (object) ">>", Color.SandyBrown, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  OGS           [{0}]", (object) Variables.ogs, (object) ">>", Color.MediumPurple, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Rares         [{0}]", (object) Variables.rares, (object) ">>", Color.Cyan, Color.White);
              Colorful.Console.WriteLine();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Retries       [{0}]", (object) Variables.retries, (object) ">>", Color.LightYellow, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  CPM           [{0}]", (object) (Variables.cpm * 60), (object) ">>", Color.WhiteSmoke, Color.White);
              elapsed = Variables.sw.Elapsed;
              num = elapsed.Minutes;
              string str1 = num.ToString();
              elapsed = Variables.sw.Elapsed;
              num = elapsed.Seconds;
              string str2 = num.ToString();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Time elapsed  [{0}]", (object) (str1 + "m " + str2 + "s"), (object) ">>", Color.WhiteSmoke, Color.White);
              Variables.cpm = 0;
              Thread.Sleep(1000);
              break;
            case "2":
              Colorful.Console.Clear();
              UIManager.PrintLogo();
              Colorful.Console.WriteLineFormatted("\n\nPress [{0}] to cycle between Stats and Locker", (object) "C", Color.LightBlue, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Progress         [{0}/{2}]", (object) Variables.check, (object) ">>", (object) Variables.ccombos.Count, Color.Crimson, Color.White);
              Colorful.Console.WriteLine();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Hits             [{0}]", (object) Variables.hits, (object) ">>", Color.LimeGreen, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  2fa              [{0}]", (object) Variables.twofa, (object) ">>", Color.Orange, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Epic 2fa         [{0}]", (object) Variables.epictwofa, (object) ">>", Color.DarkOrange, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Maybe FA         [{0}]", (object) Variables.sfa, (object) ">>", Color.MistyRose, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Looted           [{0}]", (object) Variables.banned, (object) ">>", Color.Gray, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Fails            [{0}]", (object) Variables.bad, (object) ">>", Color.OrangeRed, Color.White);
              Colorful.Console.WriteLine();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  10,000+ Matches  [{0}]", (object) Variables.tenkmplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  5,000+  Matches  [{0}]", (object) Variables.fivekmplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  2,500+  Matches  [{0}]", (object) Variables.twoandhalfandmplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  1,000+  Matches  [{0}]", (object) Variables.hundredplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  500+    Matches  [{0}]", (object) Variables.fivehundredmplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  1+      Matches  [{0}]", (object) Variables.onemplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLine();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Defaults         [{0}]", (object) Variables.zeroskin, (object) ">>", Color.Gray, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  OGS              [{0}]", (object) Variables.ogs, (object) ">>", Color.MediumPurple, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  STW              [{0}]", (object) Variables.stw, (object) ">>", Color.SandyBrown, Color.White);
              Colorful.Console.WriteLine();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Retries          [{0}]", (object) Variables.retries, (object) ">>", Color.LightYellow, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  CPM              [{0}]", (object) (Variables.cpm * 60), (object) ">>", Color.WhiteSmoke, Color.White);
              elapsed = Variables.sw.Elapsed;
              num = elapsed.Minutes;
              string str3 = num.ToString();
              elapsed = Variables.sw.Elapsed;
              num = elapsed.Seconds;
              string str4 = num.ToString();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Time elapsed     [{0}]", (object) (str3 + "m " + str4 + "s"), (object) ">>", Color.WhiteSmoke, Color.White);
              Variables.cpm = 0;
              Thread.Sleep(1000);
              break;
          }
        }
        else
        {
          switch (Variables.mode)
          {
            case "1":
              Colorful.Console.Clear();
              UIManager.PrintLogo();
              Colorful.Console.WriteLineFormatted("\n\nDone checking", (object) "C", Color.LightBlue, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Hits          [{0}]", (object) Variables.hits, (object) ">>", Color.LimeGreen, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  2fa           [{0}]", (object) Variables.twofa, (object) ">>", Color.Orange, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Epic 2fa      [{0}]", (object) Variables.epictwofa, (object) ">>", Color.DarkOrange, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Maybe FA      [{0}]", (object) Variables.sfa, (object) ">>", Color.MistyRose, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Looted        [{0}]", (object) Variables.banned, (object) ">>", Color.Gray, Color.White);
              Colorful.Console.WriteLineFormatted("\n                                              [{1}]  250+ Skins    [{0}]", (object) Variables.twohundredfiftyplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  200+ Skins    [{0}]", (object) Variables.twohundredplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  150+ Skins    [{0}]", (object) Variables.hundredfiftyplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  100+ Skins    [{0}]", (object) Variables.hundredplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  50+  Skins    [{0}]", (object) Variables.fiftyplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  25+  Skins    [{0}]", (object) Variables.twentyfiveplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  10+  Skins    [{0}]", (object) Variables.tenplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  1+   Skins    [{0}]", (object) Variables.oneplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("\n                                              [{1}]  Defaults      [{0}]", (object) Variables.zeroskin, (object) ">>", Color.Gray, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  OGS           [{0}]", (object) Variables.ogs, (object) ">>", Color.MediumPurple, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  STW           [{0}]", (object) Variables.stw, (object) ">>", Color.SandyBrown, Color.White);
              elapsed = Variables.sw.Elapsed;
              num = elapsed.Minutes;
              string str5 = num.ToString();
              elapsed = Variables.sw.Elapsed;
              num = elapsed.Seconds;
              string str6 = num.ToString();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Time elapsed  [{0}]", (object) (str5 + "m " + str6 + "s"), (object) ">>", Color.WhiteSmoke, Color.White);
              Thread.Sleep(-1);
              break;
            case "2":
              Colorful.Console.Clear();
              UIManager.PrintLogo();
              Colorful.Console.WriteLineFormatted("\n\nDone checking", Color.LightBlue, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Hits          [{0}]", (object) Variables.hits, (object) ">>", Color.LimeGreen, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  2fa           [{0}]", (object) Variables.twofa, (object) ">>", Color.Orange, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Epic 2fa      [{0}]", (object) Variables.epictwofa, (object) ">>", Color.DarkOrange, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Maybe FA      [{0}]", (object) Variables.sfa, (object) ">>", Color.MistyRose, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Looted        [{0}]", (object) Variables.banned, (object) ">>", Color.Gray, Color.White);
              Colorful.Console.WriteLineFormatted("\n                                              [{1}]  10,000+ Matches  [{0}]", (object) Variables.tenkmplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  5,000+  Matches  [{0}]", (object) Variables.fivekmplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  2,500+  Matches  [{0}]", (object) Variables.twoandhalfandmplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  1,000+  Matches  [{0}]", (object) Variables.hundredplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  500+    Matches  [{0}]", (object) Variables.fivehundredmplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  1+      Matches  [{0}]", (object) Variables.onemplus, (object) ">>", Color.Crimson, Color.White);
              Colorful.Console.WriteLineFormatted("\n                                              [{1}]  Defaults         [{0}]", (object) Variables.zeroskin, (object) ">>", Color.Gray, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  OGS              [{0}]", (object) Variables.ogs, (object) ">>", Color.MediumPurple, Color.White);
              Colorful.Console.WriteLineFormatted("                                              [{1}]  STW              [{0}]", (object) Variables.stw, (object) ">>", Color.SandyBrown, Color.White);
              elapsed = Variables.sw.Elapsed;
              num = elapsed.Minutes;
              string str7 = num.ToString();
              elapsed = Variables.sw.Elapsed;
              num = elapsed.Seconds;
              string str8 = num.ToString();
              Colorful.Console.WriteLineFormatted("                                              [{1}]  Time elapsed     [{0}]", (object) (str7 + "m " + str8 + "s"), (object) ">>", Color.WhiteSmoke, Color.White);
              Thread.Sleep(-1);
              break;
          }
        }
      }
    }
  }
}
