using System;
using System.Collections;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020001F6 RID: 502
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001419 RID: 5145
		object UnderlyingDictionary { get; }
	}
}
