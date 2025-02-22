using System;

namespace Newtonsoft.Json
{
	// Token: 0x02000170 RID: 368
	public interface IJsonLineInfo
	{
		// Token: 0x06000E8D RID: 3725
		bool HasLineInfo();

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000E8E RID: 3726
		int LineNumber { get; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000E8F RID: 3727
		int LinePosition { get; }
	}
}
