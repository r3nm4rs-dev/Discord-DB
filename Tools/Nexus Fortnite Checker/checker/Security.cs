// Decompiled with JetBrains decompiler
// Type: NexusFN.Security
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using KeyAuth;
using NexusFN.Utilities;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

#nullable disable
namespace NexusFN
{
  internal class Security
  {
    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static api KeyAuthApp = new api("Renaud.dev.mail's Application", "c7TJJ6a6Sq", "5b32b6d2c4aa1cbfe892e87d70897462c06745084ea090d5b26c86bd4dd43e88", "1.0");

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void Startlogin()
    {
      Security.KeyAuthApp.init();
      if (!File.Exists("Login.txt"))
        File.Create("Login.txt");
      string source;
      while (true)
      {
        try
        {
          source = File.ReadAllText("Login.txt");
          break;
        }
        catch
        {
          Thread.Sleep(500);
        }
      }
      Thread.Sleep(1000);
      if (!(source == ""))
      {
        Variables.username = Variables.Parse(source, "user=", "&");
        Variables.password = Variables.Parse(source, "password=", "");
        goto label_8;
      }
label_7:
      Console.Clear();
      UIManager.PrintLogoN();
      Console.Write("Enter your username: ");
      Variables.username = Console.ReadLine();
      Console.Write("Enter your password: ");
      Variables.password = Console.ReadLine();
label_8:
      Security.KeyAuthApp.login(Variables.username, Variables.password);
      if (Security.KeyAuthApp.response.success)
      {
        File.WriteAllText("Login.txt", "user=" + Variables.username + "&password=" + Variables.password);
      }
      else
      {
        Console.WriteLine(Security.KeyAuthApp.response.message);
        Thread.Sleep(2500);
        goto label_7;
      }
    }
  }
}
