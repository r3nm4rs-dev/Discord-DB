using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002B8 RID: 696
	public interface IJEnumerable<out T> : IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x1700056C RID: 1388
		IJEnumerable<JToken> this[object key]
		{
			get;
		}
	}
}
