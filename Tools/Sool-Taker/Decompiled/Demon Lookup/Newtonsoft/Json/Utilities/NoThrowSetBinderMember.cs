using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000210 RID: 528
	internal class NoThrowSetBinderMember : SetMemberBinder
	{
		// Token: 0x060014BF RID: 5311 RVA: 0x00013CFC File Offset: 0x00011EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NoThrowSetBinderMember(SetMemberBinder innerBinder)
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00013D04 File Offset: 0x00011F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
		{
			return null;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00013D14 File Offset: 0x00011F14
		static NoThrowSetBinderMember()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000A44 RID: 2628
		private readonly SetMemberBinder XjTXtVoys7;
	}
}
