using System;
using System.Diagnostics;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000269 RID: 617
	public interface ITraceWriter
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060016E9 RID: 5865
		TraceLevel LevelFilter { get; }

		// Token: 0x060016EA RID: 5866
		void Trace(TraceLevel level, string message, Exception ex);
	}
}
