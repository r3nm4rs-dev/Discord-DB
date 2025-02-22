using System;
using System.Collections;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020001EA RID: 490
	internal interface IWrappedCollection : IList, ICollection, IEnumerable
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060013AC RID: 5036
		object UnderlyingCollection { get; }
	}
}
