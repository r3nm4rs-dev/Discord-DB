using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp.Authenticators.OAuth
{
	// Token: 0x0200041E RID: 1054
	[DataContract]
	internal static class OAuthTools
	{
		// Token: 0x060027C7 RID: 10183 RVA: 0x00021E00 File Offset: 0x00020000
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OAuthTools()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			if (nCP5vtxT3QjsSeuiK3.TU7gF13T1(4064))
			{
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				OAuthTools.YKEwX8USKB = new object();
				OAuthTools.oi9wGtALYZ = RandomNumberGenerator.Create();
				OAuthTools.e0KwdaVMZY = Encoding.UTF8;
				OAuthTools.AhDwj5LKh5 = new string[]
				{
					"!",
					"*",
					"'",
					"(",
					")"
				};
				OAuthTools.m6Vwy9yKl7 = new string[]
				{
					"%21",
					"%2A",
					"%27",
					"%28",
					"%29"
				};
				byte[] array = new byte[4];
				OAuthTools.oi9wGtALYZ.GetBytes(array);
				OAuthTools.l6Aw4R1b15 = new Random(BitConverter.ToInt32(array, 0));
			}
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00021ED4 File Offset: 0x000200D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetNonce()
		{
			return null;
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00021EF4 File Offset: 0x000200F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTimestamp()
		{
			return null;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00021F04 File Offset: 0x00020104
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetTimestamp(DateTime dateTime)
		{
			return null;
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00021F14 File Offset: 0x00020114
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlEncodeRelaxed(string value)
		{
			return null;
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00021F24 File Offset: 0x00020124
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string UrlEncodeStrict(string value)
		{
			return null;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00021F34 File Offset: 0x00020134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string NormalizeRequestParameters(WebParameterCollection parameters)
		{
			return null;
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00021F44 File Offset: 0x00020144
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static WebParameterCollection SortParametersExcludingSignature(WebParameterCollection parameters)
		{
			return null;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00021F54 File Offset: 0x00020154
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ConstructRequestUrl(Uri url)
		{
			return null;
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00021F64 File Offset: 0x00020164
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ConcatenateRequestElements(string method, string url, WebParameterCollection parameters)
		{
			return null;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00021F74 File Offset: 0x00020174
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSignature(OAuthSignatureMethod signatureMethod, string signatureBase, string consumerSecret)
		{
			return null;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00021F84 File Offset: 0x00020184
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSignature(OAuthSignatureMethod signatureMethod, OAuthSignatureTreatment signatureTreatment, string signatureBase, string consumerSecret)
		{
			return null;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x00021F94 File Offset: 0x00020194
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSignature(OAuthSignatureMethod signatureMethod, string signatureBase, string consumerSecret, string tokenSecret)
		{
			return null;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00021FA4 File Offset: 0x000201A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSignature(OAuthSignatureMethod signatureMethod, OAuthSignatureTreatment signatureTreatment, string signatureBase, string consumerSecret, string tokenSecret)
		{
			return null;
		}

		// Token: 0x0400111E RID: 4382
		private static readonly Random l6Aw4R1b15;

		// Token: 0x0400111F RID: 4383
		private static readonly object YKEwX8USKB;

		// Token: 0x04001120 RID: 4384
		private static readonly RandomNumberGenerator oi9wGtALYZ;

		// Token: 0x04001121 RID: 4385
		private static readonly Encoding e0KwdaVMZY;

		// Token: 0x04001122 RID: 4386
		private static readonly string[] AhDwj5LKh5;

		// Token: 0x04001123 RID: 4387
		private static readonly string[] m6Vwy9yKl7;

		// Token: 0x0200041F RID: 1055
		[CompilerGenerated]
		private sealed class kpjtgcrYNUvMwCGtqih
		{
			// Token: 0x060027D5 RID: 10197 RVA: 0x0002339C File Offset: 0x0002159C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public kpjtgcrYNUvMwCGtqih()
			{
			}

			// Token: 0x060027D6 RID: 10198 RVA: 0x000233A4 File Offset: 0x000215A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void TWKxxwHlc98(char c)
			{
			}

			// Token: 0x060027D7 RID: 10199 RVA: 0x000233B4 File Offset: 0x000215B4
			static kpjtgcrYNUvMwCGtqih()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04001124 RID: 4388
			public string ymaxxBJ4w6y;
		}

		// Token: 0x02000420 RID: 1056
		[CompilerGenerated]
		[Serializable]
		private sealed class PK47qJrNZsQ03qtOhhf
		{
			// Token: 0x060027D8 RID: 10200 RVA: 0x000233BC File Offset: 0x000215BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static PK47qJrNZsQ03qtOhhf()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				OAuthTools.PK47qJrNZsQ03qtOhhf.NNaxcxDGaYh = new OAuthTools.PK47qJrNZsQ03qtOhhf();
			}

			// Token: 0x060027D9 RID: 10201 RVA: 0x000233D8 File Offset: 0x000215D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public PK47qJrNZsQ03qtOhhf()
			{
			}

			// Token: 0x060027DA RID: 10202 RVA: 0x000233E0 File Offset: 0x000215E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool PGjxxJVAkVW(WebPair n)
			{
				return true;
			}

			// Token: 0x060027DB RID: 10203 RVA: 0x000233E8 File Offset: 0x000215E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void EiaxxzbJFnB(WebPair p)
			{
			}

			// Token: 0x060027DC RID: 10204 RVA: 0x000233F0 File Offset: 0x000215F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int eQ9xctH7M2c(WebPair x, WebPair y)
			{
				return 0;
			}

			// Token: 0x04001125 RID: 4389
			public static readonly OAuthTools.PK47qJrNZsQ03qtOhhf NNaxcxDGaYh;

			// Token: 0x04001126 RID: 4390
			public static Func<WebPair, bool> KY4xccDW1of;

			// Token: 0x04001127 RID: 4391
			public static Action<WebPair> H7uxcHHLcQk;

			// Token: 0x04001128 RID: 4392
			public static Comparison<WebPair> jgqxcYW7JJO;
		}
	}
}
