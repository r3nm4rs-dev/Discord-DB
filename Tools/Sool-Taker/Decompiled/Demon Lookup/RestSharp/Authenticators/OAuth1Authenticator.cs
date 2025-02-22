using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using RestSharp.Authenticators.OAuth;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp.Authenticators
{
	// Token: 0x02000412 RID: 1042
	public class OAuth1Authenticator : IAuthenticator
	{
		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x00021B3C File Offset: 0x0001FD3C
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x00021B44 File Offset: 0x0001FD44
		public virtual string Realm
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

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x00021B4C File Offset: 0x0001FD4C
		// (set) Token: 0x06002772 RID: 10098 RVA: 0x00021B58 File Offset: 0x0001FD58
		public virtual OAuthParameterHandling ParameterHandling
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (OAuthParameterHandling)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x00021B60 File Offset: 0x0001FD60
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x00021B6C File Offset: 0x0001FD6C
		public virtual OAuthSignatureMethod SignatureMethod
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (OAuthSignatureMethod)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x00021B74 File Offset: 0x0001FD74
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x00021B80 File Offset: 0x0001FD80
		public virtual OAuthSignatureTreatment SignatureTreatment
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (OAuthSignatureTreatment)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x00021B88 File Offset: 0x0001FD88
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x00021B94 File Offset: 0x0001FD94
		internal virtual OAuthType Type
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (OAuthType)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x00021B9C File Offset: 0x0001FD9C
		// (set) Token: 0x0600277A RID: 10106 RVA: 0x00021BA4 File Offset: 0x0001FDA4
		internal virtual string ConsumerKey
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

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x00021BAC File Offset: 0x0001FDAC
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x00021BB4 File Offset: 0x0001FDB4
		internal virtual string ConsumerSecret
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

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x00021BBC File Offset: 0x0001FDBC
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x00021BC4 File Offset: 0x0001FDC4
		internal virtual string Token
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

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x00021BCC File Offset: 0x0001FDCC
		// (set) Token: 0x06002780 RID: 10112 RVA: 0x00021BD4 File Offset: 0x0001FDD4
		internal virtual string TokenSecret
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

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x00021BDC File Offset: 0x0001FDDC
		// (set) Token: 0x06002782 RID: 10114 RVA: 0x00021BE4 File Offset: 0x0001FDE4
		internal virtual string Verifier
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

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x00021BEC File Offset: 0x0001FDEC
		// (set) Token: 0x06002784 RID: 10116 RVA: 0x00021BF4 File Offset: 0x0001FDF4
		internal virtual string Version
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

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x00021BFC File Offset: 0x0001FDFC
		// (set) Token: 0x06002786 RID: 10118 RVA: 0x00021C04 File Offset: 0x0001FE04
		internal virtual string CallbackUrl
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

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x00021C0C File Offset: 0x0001FE0C
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x00021C14 File Offset: 0x0001FE14
		internal virtual string SessionHandle
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

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x00021C1C File Offset: 0x0001FE1C
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x00021C24 File Offset: 0x0001FE24
		internal virtual string ClientUsername
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x00021C2C File Offset: 0x0001FE2C
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x00021C34 File Offset: 0x0001FE34
		internal virtual string ClientPassword
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

		// Token: 0x0600278D RID: 10125 RVA: 0x00021C3C File Offset: 0x0001FE3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Authenticate(IRestClient client, IRestRequest request)
		{
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x00021C4C File Offset: 0x0001FE4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static OAuth1Authenticator ForRequestToken(string consumerKey, string consumerSecret, OAuthSignatureMethod signatureMethod = OAuthSignatureMethod.HmacSha1)
		{
			return null;
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x00021C5C File Offset: 0x0001FE5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static OAuth1Authenticator ForRequestToken(string consumerKey, string consumerSecret, string callbackUrl)
		{
			return null;
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00021C6C File Offset: 0x0001FE6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static OAuth1Authenticator ForAccessToken(string consumerKey, string consumerSecret, string token, string tokenSecret, OAuthSignatureMethod signatureMethod = OAuthSignatureMethod.HmacSha1)
		{
			return null;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00021C7C File Offset: 0x0001FE7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static OAuth1Authenticator ForAccessToken(string consumerKey, string consumerSecret, string token, string tokenSecret, string verifier)
		{
			return null;
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00021C8C File Offset: 0x0001FE8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static OAuth1Authenticator ForAccessTokenRefresh(string consumerKey, string consumerSecret, string token, string tokenSecret, string sessionHandle)
		{
			return null;
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00021C9C File Offset: 0x0001FE9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static OAuth1Authenticator ForAccessTokenRefresh(string consumerKey, string consumerSecret, string token, string tokenSecret, string verifier, string sessionHandle)
		{
			return null;
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00021CAC File Offset: 0x0001FEAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static OAuth1Authenticator ForClientAuthentication(string consumerKey, string consumerSecret, string username, string password, OAuthSignatureMethod signatureMethod = OAuthSignatureMethod.HmacSha1)
		{
			return null;
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x00021CBC File Offset: 0x0001FEBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static OAuth1Authenticator ForProtectedResource(string consumerKey, string consumerSecret, string accessToken, string accessTokenSecret, OAuthSignatureMethod signatureMethod = OAuthSignatureMethod.HmacSha1)
		{
			return null;
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00021CCC File Offset: 0x0001FECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QbKwtjBuNa(IRestClient \u0020, IRestRequest \u0020, OAuthWorkflow \u0020)
		{
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00021CDC File Offset: 0x0001FEDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string qIawxVthn6(WebPairCollection \u0020)
		{
			return null;
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x00021CFC File Offset: 0x0001FEFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OAuth1Authenticator()
		{
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00021D04 File Offset: 0x0001FF04
		static OAuth1Authenticator()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040010E7 RID: 4327
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string p6NwclLElN;

		// Token: 0x040010E8 RID: 4328
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private OAuthParameterHandling aeCwHKe6OV;

		// Token: 0x040010E9 RID: 4329
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private OAuthSignatureMethod aNbwYZZBl0;

		// Token: 0x040010EA RID: 4330
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private OAuthSignatureTreatment gVywPG4aWn;

		// Token: 0x040010EB RID: 4331
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private OAuthType tZdwrw16Cp;

		// Token: 0x040010EC RID: 4332
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string FVNwpnpObr;

		// Token: 0x040010ED RID: 4333
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string NYWwMoI7Tv;

		// Token: 0x040010EE RID: 4334
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string aWhwOCyv76;

		// Token: 0x040010EF RID: 4335
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string iwDwvxHDEj;

		// Token: 0x040010F0 RID: 4336
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string jeuwF3dL6K;

		// Token: 0x040010F1 RID: 4337
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string B1Iw0w6PG1;

		// Token: 0x040010F2 RID: 4338
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string UZewuf3qCn;

		// Token: 0x040010F3 RID: 4339
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string Yrdw7poLil;

		// Token: 0x040010F4 RID: 4340
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string i72w11tAn8;

		// Token: 0x040010F5 RID: 4341
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string FoGwitFZfc;

		// Token: 0x02000413 RID: 1043
		[CompilerGenerated]
		[Serializable]
		private sealed class SWXib2hzPPONXP9uh86
		{
			// Token: 0x0600279A RID: 10138 RVA: 0x000232DC File Offset: 0x000214DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static SWXib2hzPPONXP9uh86()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				OAuth1Authenticator.SWXib2hzPPONXP9uh86.i8gxxWBI0Mr = new OAuth1Authenticator.SWXib2hzPPONXP9uh86();
			}

			// Token: 0x0600279B RID: 10139 RVA: 0x000232F8 File Offset: 0x000214F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public SWXib2hzPPONXP9uh86()
			{
			}

			// Token: 0x0600279C RID: 10140 RVA: 0x00023300 File Offset: 0x00021500
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool LPLxx8ECW9J(Parameter p)
			{
				return true;
			}

			// Token: 0x0600279D RID: 10141 RVA: 0x00023308 File Offset: 0x00021508
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal WebPair EmWxxbHT5vl(Parameter p)
			{
				return null;
			}

			// Token: 0x0600279E RID: 10142 RVA: 0x00023310 File Offset: 0x00021510
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool HeUxx4vbChy(Parameter p)
			{
				return true;
			}

			// Token: 0x0600279F RID: 10143 RVA: 0x00023318 File Offset: 0x00021518
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal WebPair E7OxxXEmojK(Parameter p)
			{
				return null;
			}

			// Token: 0x060027A0 RID: 10144 RVA: 0x00023320 File Offset: 0x00021520
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool XiWxxG3R2fu(Parameter p)
			{
				return true;
			}

			// Token: 0x060027A1 RID: 10145 RVA: 0x00023328 File Offset: 0x00021528
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal WebPair iM1xxdm7aO0(Parameter p)
			{
				return null;
			}

			// Token: 0x060027A2 RID: 10146 RVA: 0x00023330 File Offset: 0x00021530
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool unsxxjy97yS(Parameter p)
			{
				return true;
			}

			// Token: 0x060027A3 RID: 10147 RVA: 0x00023338 File Offset: 0x00021538
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal WebPair P0UxxyBLLqT(Parameter p)
			{
				return null;
			}

			// Token: 0x060027A4 RID: 10148 RVA: 0x00023340 File Offset: 0x00021540
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool CjOxxfWsbki(WebPair p)
			{
				return true;
			}

			// Token: 0x060027A5 RID: 10149 RVA: 0x00023350 File Offset: 0x00021550
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Parameter NI1xxaFPmBb(WebPair p)
			{
				return null;
			}

			// Token: 0x060027A6 RID: 10150 RVA: 0x00023358 File Offset: 0x00021558
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int sCHxxnvHy1k(WebPair l, WebPair r)
			{
				return 0;
			}

			// Token: 0x060027A7 RID: 10151 RVA: 0x00023360 File Offset: 0x00021560
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool wwbxx5EyPt7(WebPair p)
			{
				return true;
			}

			// Token: 0x040010F6 RID: 4342
			public static readonly OAuth1Authenticator.SWXib2hzPPONXP9uh86 i8gxxWBI0Mr;

			// Token: 0x040010F7 RID: 4343
			public static Func<Parameter, bool> W2axxsR82QC;

			// Token: 0x040010F8 RID: 4344
			public static Func<Parameter, WebPair> ESjxxkfQsJK;

			// Token: 0x040010F9 RID: 4345
			public static Func<Parameter, bool> YdDxxewGDe4;

			// Token: 0x040010FA RID: 4346
			public static Func<Parameter, WebPair> H7rxxojk1a9;

			// Token: 0x040010FB RID: 4347
			public static Func<Parameter, bool> vuqxxAIhS7C;

			// Token: 0x040010FC RID: 4348
			public static Func<Parameter, WebPair> KiUxxENtNl8;

			// Token: 0x040010FD RID: 4349
			public static Func<Parameter, bool> RQixxK97MDc;

			// Token: 0x040010FE RID: 4350
			public static Func<Parameter, WebPair> cJ4xxDOyHg1;

			// Token: 0x040010FF RID: 4351
			public static Func<WebPair, bool> FeUxxZOtxgH;

			// Token: 0x04001100 RID: 4352
			public static Func<WebPair, Parameter> EPAxxhCH7AX;

			// Token: 0x04001101 RID: 4353
			public static Comparison<WebPair> HacxxQV0tpS;

			// Token: 0x04001102 RID: 4354
			public static Func<WebPair, bool> TGvxx3ELKur;
		}
	}
}
