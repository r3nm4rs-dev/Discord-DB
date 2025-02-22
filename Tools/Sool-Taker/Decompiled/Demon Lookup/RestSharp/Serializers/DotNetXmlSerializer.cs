using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using RestSharp.Serialization;
using RestSharp.Serialization.Xml;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp.Serializers
{
	// Token: 0x020003E9 RID: 1001
	public class DotNetXmlSerializer : IXmlSerializer, ISerializer, IWithRootElement
	{
		// Token: 0x0600266C RID: 9836 RVA: 0x00021124 File Offset: 0x0001F324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DotNetXmlSerializer()
		{
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0002112C File Offset: 0x0001F32C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DotNetXmlSerializer(string @namespace)
		{
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x00021134 File Offset: 0x0001F334
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x0002113C File Offset: 0x0001F33C
		public Encoding Encoding
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

		// Token: 0x06002670 RID: 9840 RVA: 0x00021144 File Offset: 0x0001F344
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Serialize(object obj)
		{
			return null;
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06002671 RID: 9841 RVA: 0x00021154 File Offset: 0x0001F354
		// (set) Token: 0x06002672 RID: 9842 RVA: 0x0002115C File Offset: 0x0001F35C
		public string RootElement
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

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x00021164 File Offset: 0x0001F364
		// (set) Token: 0x06002674 RID: 9844 RVA: 0x0002116C File Offset: 0x0001F36C
		public string Namespace
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

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x00021174 File Offset: 0x0001F374
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x0002117C File Offset: 0x0001F37C
		public string DateFormat
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

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x00021184 File Offset: 0x0001F384
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x0002118C File Offset: 0x0001F38C
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

		// Token: 0x06002679 RID: 9849 RVA: 0x00021194 File Offset: 0x0001F394
		static DotNetXmlSerializer()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04001089 RID: 4233
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Encoding Q6TTRTbpP5;

		// Token: 0x0400108A RID: 4234
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string B1kTwTVOZh;

		// Token: 0x0400108B RID: 4235
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string WDPTBI471G;

		// Token: 0x0400108C RID: 4236
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string NwnTJhYyt3;

		// Token: 0x0400108D RID: 4237
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string PyhTzHUQtG;

		// Token: 0x020003EA RID: 1002
		private class R2PL1ChdgGuCpa9rxlY : StringWriter
		{
			// Token: 0x0600267A RID: 9850 RVA: 0x00023090 File Offset: 0x00021290
			[MethodImpl(MethodImplOptions.NoInlining)]
			public R2PL1ChdgGuCpa9rxlY(Encoding \u0020)
			{
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x0600267B RID: 9851 RVA: 0x00023098 File Offset: 0x00021298
			public override Encoding Encoding
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
			}

			// Token: 0x0600267C RID: 9852 RVA: 0x000230A0 File Offset: 0x000212A0
			static R2PL1ChdgGuCpa9rxlY()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x0400108E RID: 4238
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private readonly Encoding kDHxtaOIG7H;
		}
	}
}
