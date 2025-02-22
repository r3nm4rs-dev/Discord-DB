using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200020F RID: 527
	internal class NoThrowGetBinderMember : GetMemberBinder
	{
		// Token: 0x060014BC RID: 5308 RVA: 0x00013CDC File Offset: 0x00011EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NoThrowGetBinderMember(GetMemberBinder innerBinder)
		{
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00013CE4 File Offset: 0x00011EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			return null;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00013CF4 File Offset: 0x00011EF4
		static NoThrowGetBinderMember()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000A43 RID: 2627
		private readonly GetMemberBinder HRl4zfFCbl;
	}
}
