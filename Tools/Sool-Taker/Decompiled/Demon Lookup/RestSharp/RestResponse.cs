using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp
{
	// Token: 0x020003E1 RID: 993
	[DebuggerDisplay("{DebuggerDisplay()}")]
	public class RestResponse<T> : RestResponseBase, IRestResponse<T>, IRestResponse
	{
		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x00020F18 File Offset: 0x0001F118
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x00020F20 File Offset: 0x0001F120
		public T Data
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00020F28 File Offset: 0x0001F128
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator RestResponse<T>(RestResponse response)
		{
			return null;
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00020F38 File Offset: 0x0001F138
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestResponse()
		{
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00020F40 File Offset: 0x0001F140
		static RestResponse()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x0400106F RID: 4207
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private T Uf6TjCKTBI;
	}
}
