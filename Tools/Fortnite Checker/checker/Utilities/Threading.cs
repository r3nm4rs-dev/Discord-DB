// Decompiled with JetBrains decompiler
// Type: NexusFN.Utilities.Threading
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using System.Reflection;
using System.Threading;

#nullable disable
namespace NexusFN.Utilities
{
  internal class Threading
  {
    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void StartChecking()
    {
      for (int index = 0; index < Variables.threadcount; ++index)
      {
        Thread thread = new Thread(new ThreadStart(NexusFN.Utilities.Threading.CheckCombos));
        Variables.threads.Add(thread);
        thread.Start();
      }
      foreach (Thread thread in Variables.threads)
        thread.Start();
      foreach (Thread thread in Variables.threads)
        thread.Join();
    }

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void CheckCombos()
    {
      string result;
      while (Variables.combos.TryDequeue(out result))
        API.Check(result);
    }
  }
}
