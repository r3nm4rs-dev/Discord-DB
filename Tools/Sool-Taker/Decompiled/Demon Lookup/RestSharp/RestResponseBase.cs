using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp
{
	// Token: 0x020003E0 RID: 992
	[DebuggerDisplay("{DebuggerDisplay()}")]
	public abstract class RestResponseBase
	{
		// Token: 0x0600260A RID: 9738 RVA: 0x00020DE0 File Offset: 0x0001EFE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected RestResponseBase()
		{
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00020DE8 File Offset: 0x0001EFE8
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x00020DF0 File Offset: 0x0001EFF0
		public IRestRequest Request
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

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x00020DF8 File Offset: 0x0001EFF8
		// (set) Token: 0x0600260E RID: 9742 RVA: 0x00020E00 File Offset: 0x0001F000
		public string ContentType
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

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x00020E08 File Offset: 0x0001F008
		// (set) Token: 0x06002610 RID: 9744 RVA: 0x00020E10 File Offset: 0x0001F010
		public long ContentLength
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x00020E18 File Offset: 0x0001F018
		// (set) Token: 0x06002612 RID: 9746 RVA: 0x00020E20 File Offset: 0x0001F020
		public string ContentEncoding
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

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x00020E28 File Offset: 0x0001F028
		// (set) Token: 0x06002614 RID: 9748 RVA: 0x00020E38 File Offset: 0x0001F038
		public string Content
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x00020E40 File Offset: 0x0001F040
		// (set) Token: 0x06002616 RID: 9750 RVA: 0x00020E4C File Offset: 0x0001F04C
		public HttpStatusCode StatusCode
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (HttpStatusCode)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x00020E54 File Offset: 0x0001F054
		public bool IsSuccessful
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x00020E5C File Offset: 0x0001F05C
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x00020E64 File Offset: 0x0001F064
		public string StatusDescription
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

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x00020E6C File Offset: 0x0001F06C
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x00020E74 File Offset: 0x0001F074
		public byte[] RawBytes
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

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x00020E7C File Offset: 0x0001F07C
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x00020E84 File Offset: 0x0001F084
		public Uri ResponseUri
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

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x00020E8C File Offset: 0x0001F08C
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x00020E94 File Offset: 0x0001F094
		public string Server
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

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x00020E9C File Offset: 0x0001F09C
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x00020EA4 File Offset: 0x0001F0A4
		public IList<RestResponseCookie> Cookies
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected internal set
			{
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x00020EAC File Offset: 0x0001F0AC
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x00020EB4 File Offset: 0x0001F0B4
		public IList<Parameter> Headers
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected internal set
			{
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x00020EBC File Offset: 0x0001F0BC
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		public ResponseStatus ResponseStatus
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ResponseStatus)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x00020ED0 File Offset: 0x0001F0D0
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x00020ED8 File Offset: 0x0001F0D8
		public string ErrorMessage
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

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x00020EE0 File Offset: 0x0001F0E0
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x00020EE8 File Offset: 0x0001F0E8
		public Exception ErrorException
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

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x00020EF0 File Offset: 0x0001F0F0
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		public Version ProtocolVersion
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

		// Token: 0x0600262C RID: 9772 RVA: 0x00020F00 File Offset: 0x0001F100
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected string DebuggerDisplay()
		{
			return null;
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00020F10 File Offset: 0x0001F110
		static RestResponseBase()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x0400105F RID: 4191
		private string cnmTmCSVrN;

		// Token: 0x04001060 RID: 4192
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IRestRequest wDCTVESEdo;

		// Token: 0x04001061 RID: 4193
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string k0dT9rxeUK;

		// Token: 0x04001062 RID: 4194
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long DFFT2g6LAQ;

		// Token: 0x04001063 RID: 4195
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string cK1TgjXlPu;

		// Token: 0x04001064 RID: 4196
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private HttpStatusCode QVLTC0SfY1;

		// Token: 0x04001065 RID: 4197
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string QjdT66Equv;

		// Token: 0x04001066 RID: 4198
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private byte[] UABTlaNudA;

		// Token: 0x04001067 RID: 4199
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Uri xXjTqIMq9d;

		// Token: 0x04001068 RID: 4200
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string b8OTL1yspF;

		// Token: 0x04001069 RID: 4201
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IList<RestResponseCookie> nKpT8IEdtp;

		// Token: 0x0400106A RID: 4202
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IList<Parameter> kiOTbuBnbF;

		// Token: 0x0400106B RID: 4203
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ResponseStatus T82T4o1IYI;

		// Token: 0x0400106C RID: 4204
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string ASYTXWRE16;

		// Token: 0x0400106D RID: 4205
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Exception LUFTGXuxgu;

		// Token: 0x0400106E RID: 4206
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Version SbtTd8naXj;
	}
}
