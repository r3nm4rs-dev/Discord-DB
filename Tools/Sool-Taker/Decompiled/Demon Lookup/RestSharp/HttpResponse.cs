using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp
{
	// Token: 0x020003AB RID: 939
	public class HttpResponse : IHttpResponse
	{
		// Token: 0x06002325 RID: 8997 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HttpResponse()
		{
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x0001FFDC File Offset: 0x0001E1DC
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
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

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
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

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x00020004 File Offset: 0x0001E204
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

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x0002000C File Offset: 0x0001E20C
		public string Content
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x0002001C File Offset: 0x0001E21C
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x00020028 File Offset: 0x0001E228
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

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x00020030 File Offset: 0x0001E230
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x00020038 File Offset: 0x0001E238
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

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00020040 File Offset: 0x0001E240
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x00020048 File Offset: 0x0001E248
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

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00020050 File Offset: 0x0001E250
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x00020058 File Offset: 0x0001E258
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

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x00020060 File Offset: 0x0001E260
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00020068 File Offset: 0x0001E268
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

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x00020070 File Offset: 0x0001E270
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x00020078 File Offset: 0x0001E278
		public IList<HttpHeader> Headers
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x00020080 File Offset: 0x0001E280
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x00020088 File Offset: 0x0001E288
		public IList<HttpCookie> Cookies
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x00020090 File Offset: 0x0001E290
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x0002009C File Offset: 0x0001E29C
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

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x000200A4 File Offset: 0x0001E2A4
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x000200AC File Offset: 0x0001E2AC
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

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000200B4 File Offset: 0x0001E2B4
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x000200BC File Offset: 0x0001E2BC
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

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x000200C4 File Offset: 0x0001E2C4
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x000200CC File Offset: 0x0001E2CC
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

		// Token: 0x06002343 RID: 9027 RVA: 0x000200D4 File Offset: 0x0001E2D4
		static HttpResponse()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000F96 RID: 3990
		private string X6Q3yTZopI;

		// Token: 0x04000F97 RID: 3991
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string IBk3fKtnkk;

		// Token: 0x04000F98 RID: 3992
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private long B8C3adANUV;

		// Token: 0x04000F99 RID: 3993
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string NcO3nhevTY;

		// Token: 0x04000F9A RID: 3994
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private HttpStatusCode cLm353mXlm;

		// Token: 0x04000F9B RID: 3995
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string QRX3WCsod4;

		// Token: 0x04000F9C RID: 3996
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private byte[] ByB3srnhHs;

		// Token: 0x04000F9D RID: 3997
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Uri wRi3kWLHhD;

		// Token: 0x04000F9E RID: 3998
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string uaO3ekM39M;

		// Token: 0x04000F9F RID: 3999
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IList<HttpHeader> C0A3oyJ91q;

		// Token: 0x04000FA0 RID: 4000
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IList<HttpCookie> XFy3ATdfV3;

		// Token: 0x04000FA1 RID: 4001
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ResponseStatus yPC3EZiEqH;

		// Token: 0x04000FA2 RID: 4002
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string IZc3KqS3xo;

		// Token: 0x04000FA3 RID: 4003
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Exception GmA3DesnX6;

		// Token: 0x04000FA4 RID: 4004
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Version RIF3Z5kJsW;
	}
}
