using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020002F2 RID: 754
	internal abstract class PathFilter
	{
		// Token: 0x06001DB3 RID: 7603
		public abstract IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, bool errorWhenNoMatch);

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000196E8 File Offset: 0x000178E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static JToken GetTokenIndex(JToken t, bool errorWhenNoMatch, int index)
		{
			return null;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x000196F8 File Offset: 0x000178F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static JToken GetNextScanValue(JToken originalParent, JToken container, JToken value)
		{
			return null;
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00019708 File Offset: 0x00017908
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PathFilter()
		{
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00019710 File Offset: 0x00017910
		static PathFilter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
