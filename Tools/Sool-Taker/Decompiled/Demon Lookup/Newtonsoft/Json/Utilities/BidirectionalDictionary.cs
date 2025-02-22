using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020001E8 RID: 488
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		// Token: 0x06001393 RID: 5011 RVA: 0x00012A04 File Offset: 0x00010C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidirectionalDictionary()
		{
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00012A0C File Offset: 0x00010C0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
		{
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00012A14 File Offset: 0x00010C14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00012A1C File Offset: 0x00010C1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(TFirst first, TSecond second)
		{
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00012A2C File Offset: 0x00010C2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			return true;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00012A34 File Offset: 0x00010C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			return true;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00012A3C File Offset: 0x00010C3C
		static BidirectionalDictionary()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040009A9 RID: 2473
		private readonly IDictionary<TFirst, TSecond> arfbf9IYhe;

		// Token: 0x040009AA RID: 2474
		private readonly IDictionary<TSecond, TFirst> eWYbaoXa3N;

		// Token: 0x040009AB RID: 2475
		private readonly string id5bnnBKfg;

		// Token: 0x040009AC RID: 2476
		private readonly string TQqb5oVUjp;
	}
}
