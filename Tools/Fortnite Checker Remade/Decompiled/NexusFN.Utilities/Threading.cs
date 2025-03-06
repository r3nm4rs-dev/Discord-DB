using System.Reflection;
using System.Threading;

namespace NexusFN.Utilities;

internal class Threading
{
	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void StartChecking()
	{
		for (int i = 0; i < Variables.threadcount; i++)
		{
			Thread thread = new Thread(CheckCombos);
			Variables.threads.Add(thread);
			thread.Start();
		}
		foreach (Thread thread2 in Variables.threads)
		{
			thread2.Start();
		}
		foreach (Thread thread3 in Variables.threads)
		{
			thread3.Join();
		}
	}

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void CheckCombos()
	{
		string result;
		while (Variables.combos.TryDequeue(out result))
		{
			API.Check(result);
		}
	}
}
