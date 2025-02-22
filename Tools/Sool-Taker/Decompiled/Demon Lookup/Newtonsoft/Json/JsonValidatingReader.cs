using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x020001CA RID: 458
	[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonValidatingReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06001249 RID: 4681 RVA: 0x00011D5C File Offset: 0x0000FF5C
		// (remove) Token: 0x0600124A RID: 4682 RVA: 0x00011D6C File Offset: 0x0000FF6C
		public event ValidationEventHandler ValidationEventHandler
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00011D7C File Offset: 0x0000FF7C
		public override object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00011D84 File Offset: 0x0000FF84
		public override int Depth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00011D8C File Offset: 0x0000FF8C
		public override string Path
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00011D94 File Offset: 0x0000FF94
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x00011D9C File Offset: 0x0000FF9C
		public override char QuoteChar
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return '\0';
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected internal set
			{
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		public override JsonToken TokenType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (JsonToken)null;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		public override Type ValueType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00011DB8 File Offset: 0x0000FFB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void pIm8qoChVV(JsonValidatingReader.xJDms0xkPmeahoDD7Z \u0020)
		{
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonValidatingReader.xJDms0xkPmeahoDD7Z dqg8LQEwQx()
		{
			return null;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00011DC8 File Offset: 0x0000FFC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IList<JsonSchemaModel> SCK8ZDgKYC()
		{
			return null;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00011DD0 File Offset: 0x0000FFD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IList<JsonSchemaModel> FZ58QIoVqr()
		{
			return null;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00011E08 File Offset: 0x00010008
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void vdp88DYIvn(string \u0020, JsonSchemaModel \u0020)
		{
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00011E18 File Offset: 0x00010018
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void mGE8bYYq6K(JsonSchemaException \u0020)
		{
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00011E28 File Offset: 0x00010028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonValidatingReader(JsonReader reader)
		{
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00011E30 File Offset: 0x00010030
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x00011E38 File Offset: 0x00010038
		public JsonSchema Schema
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

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00011E40 File Offset: 0x00010040
		public JsonReader Reader
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00011E48 File Offset: 0x00010048
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00011E50 File Offset: 0x00010050
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RD784L3F2b(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00011E60 File Offset: 0x00010060
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonSchemaType? WbX8XlF5lC()
		{
			return null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00011E70 File Offset: 0x00010070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00011E78 File Offset: 0x00010078
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00011E80 File Offset: 0x00010080
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00011E88 File Offset: 0x00010088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00011E90 File Offset: 0x00010090
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00011E98 File Offset: 0x00010098
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ReadAsString()
		{
			return null;
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00011EA0 File Offset: 0x000100A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00011EA8 File Offset: 0x000100A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00011EB0 File Offset: 0x000100B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Read()
		{
			return true;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00011EB8 File Offset: 0x000100B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void eo18GT0TVA()
		{
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00011F2C File Offset: 0x0001012C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void zcY8dTTq4M(IList<JsonSchemaModel> \u0020)
		{
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00011F70 File Offset: 0x00010170
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EhR8jIIRx0(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00011F80 File Offset: 0x00010180
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GNt8yvKCl5(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00011F90 File Offset: 0x00010190
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void olf8fnHPNZ(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00011F98 File Offset: 0x00010198
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void lsU8asRnhT(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00011FA0 File Offset: 0x000101A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IJN8nKcdHh(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00011FC0 File Offset: 0x000101C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Xth85OeSAD(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00011FD0 File Offset: 0x000101D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void iWD8WvMMGC()
		{
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00011FF0 File Offset: 0x000101F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FfB8sBoQPG(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00012000 File Offset: 0x00010200
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static double aSv8k9LjHu(double \u0020, double \u0020)
		{
			return (double)0;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00012008 File Offset: 0x00010208
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool HKD8eJkTrQ(double \u0020)
		{
			return true;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00012010 File Offset: 0x00010210
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void qnA8o1cqxD(JsonSchemaModel \u0020)
		{
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00012020 File Offset: 0x00010220
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool HCk8AZoHxL(JsonSchemaModel \u0020, string \u0020)
		{
			return true;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00012040 File Offset: 0x00010240
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool GUp8ES46xG(JsonSchemaModel \u0020)
		{
			return true;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00012048 File Offset: 0x00010248
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool zU68Kgs0iL(JsonSchemaModel \u0020)
		{
			return true;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00012050 File Offset: 0x00010250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool BeE8D0M24Y(JsonSchemaModel \u0020, JsonSchemaType \u0020)
		{
			return true;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00012060 File Offset: 0x00010260
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IJsonLineInfo.HasLineInfo()
		{
			return true;
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00012070 File Offset: 0x00010270
		int IJsonLineInfo.LineNumber
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00012080 File Offset: 0x00010280
		int IJsonLineInfo.LinePosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00012090 File Offset: 0x00010290
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JsonValidatingReader()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			JsonValidatingReader.jZG8zZfgnM = new List<JsonSchemaModel>();
		}

		// Token: 0x040008FB RID: 2299
		private readonly JsonReader qyA8SV9Aj4;

		// Token: 0x040008FC RID: 2300
		private readonly Stack<JsonValidatingReader.xJDms0xkPmeahoDD7Z> vtq8T3jAGt;

		// Token: 0x040008FD RID: 2301
		private JsonSchema oTk8RT3MN5;

		// Token: 0x040008FE RID: 2302
		private JsonSchemaModel qPx8w9CcyH;

		// Token: 0x040008FF RID: 2303
		private JsonValidatingReader.xJDms0xkPmeahoDD7Z fJS8BL71j0;

		// Token: 0x04000900 RID: 2304
		[CompilerGenerated]
		private ValidationEventHandler Kf48Jdpie0;

		// Token: 0x04000901 RID: 2305
		private static readonly IList<JsonSchemaModel> jZG8zZfgnM;

		// Token: 0x020001CB RID: 459
		private class xJDms0xkPmeahoDD7Z
		{
			// Token: 0x0600127D RID: 4733 RVA: 0x0001BA44 File Offset: 0x00019C44
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public string ynBkZsLJ4G()
			{
				return null;
			}

			// Token: 0x0600127E RID: 4734 RVA: 0x0001BA4C File Offset: 0x00019C4C
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void KvYkhZTKeG(string \u0020)
			{
			}

			// Token: 0x0600127F RID: 4735 RVA: 0x0001BA54 File Offset: 0x00019C54
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int qkek3sBS2b()
			{
				return 0;
			}

			// Token: 0x06001280 RID: 4736 RVA: 0x0001BA5C File Offset: 0x00019C5C
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void NDtkSEHOYm(int \u0020)
			{
			}

			// Token: 0x06001281 RID: 4737 RVA: 0x0001BA64 File Offset: 0x00019C64
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool CMXkR7Bdpq()
			{
				return true;
			}

			// Token: 0x06001282 RID: 4738 RVA: 0x0001BA6C File Offset: 0x00019C6C
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public IList<JToken> hLykB1dCNj()
			{
				return null;
			}

			// Token: 0x06001283 RID: 4739 RVA: 0x0001BA74 File Offset: 0x00019C74
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public JTokenWriter oflkzTwXoP()
			{
				return null;
			}

			// Token: 0x06001284 RID: 4740 RVA: 0x0001BA7C File Offset: 0x00019C7C
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void edIetwED2F(JTokenWriter \u0020)
			{
			}

			// Token: 0x06001285 RID: 4741 RVA: 0x0001BA84 File Offset: 0x00019C84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public IList<JsonSchemaModel> W7pecOrglv()
			{
				return null;
			}

			// Token: 0x06001286 RID: 4742 RVA: 0x0001BA8C File Offset: 0x00019C8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Dictionary<string, bool> nR0eYPfgNo()
			{
				return null;
			}

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x06001287 RID: 4743 RVA: 0x0001BA94 File Offset: 0x00019C94
			public JTokenType TokenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return (JTokenType)null;
				}
			}

			// Token: 0x06001288 RID: 4744 RVA: 0x0001BAA0 File Offset: 0x00019CA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public xJDms0xkPmeahoDD7Z(JTokenType \u0020, IList<JsonSchemaModel> \u0020)
			{
			}

			// Token: 0x06001289 RID: 4745 RVA: 0x0001BAB0 File Offset: 0x00019CB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			private IEnumerable<string> QybkDwxhYs(JsonSchemaModel \u0020)
			{
				return null;
			}

			// Token: 0x0600128A RID: 4746 RVA: 0x0001BAC0 File Offset: 0x00019CC0
			static xJDms0xkPmeahoDD7Z()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000902 RID: 2306
			private readonly JTokenType H2SepHCYeO;

			// Token: 0x04000903 RID: 2307
			private readonly IList<JsonSchemaModel> mckeMIa9tR;

			// Token: 0x04000904 RID: 2308
			private readonly Dictionary<string, bool> mmieO1XEWV;

			// Token: 0x04000905 RID: 2309
			[CompilerGenerated]
			private string Ya8evsSV9C;

			// Token: 0x04000906 RID: 2310
			[CompilerGenerated]
			private int vRCeFH0x8U;

			// Token: 0x04000907 RID: 2311
			[CompilerGenerated]
			private readonly bool Bbye0OaPO5;

			// Token: 0x04000908 RID: 2312
			[CompilerGenerated]
			private readonly IList<JToken> kiZeu8G7tP;

			// Token: 0x04000909 RID: 2313
			[CompilerGenerated]
			private JTokenWriter ooLe71yFgR;

			// Token: 0x020001CC RID: 460
			[CompilerGenerated]
			[Serializable]
			private sealed class uJTJfhN7mwfcYJRgffC
			{
				// Token: 0x0600128B RID: 4747 RVA: 0x0001D6DC File Offset: 0x0001B8DC
				[MethodImpl(MethodImplOptions.NoInlining)]
				static uJTJfhN7mwfcYJRgffC()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
					nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
					WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
					JsonValidatingReader.xJDms0xkPmeahoDD7Z.uJTJfhN7mwfcYJRgffC.KROKT00flf = new JsonValidatingReader.xJDms0xkPmeahoDD7Z.uJTJfhN7mwfcYJRgffC();
				}

				// Token: 0x0600128C RID: 4748 RVA: 0x0001D6F8 File Offset: 0x0001B8F8
				[MethodImpl(MethodImplOptions.NoInlining)]
				public uJTJfhN7mwfcYJRgffC()
				{
				}

				// Token: 0x0600128D RID: 4749 RVA: 0x0001D700 File Offset: 0x0001B900
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string RRJKZmRIen(string p)
				{
					return null;
				}

				// Token: 0x0600128E RID: 4750 RVA: 0x0001D708 File Offset: 0x0001B908
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool XrpKhtFVUr(string p)
				{
					return true;
				}

				// Token: 0x0600128F RID: 4751 RVA: 0x0001D710 File Offset: 0x0001B910
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool gpPKQUUhls(JsonSchemaModel s)
				{
					return true;
				}

				// Token: 0x06001290 RID: 4752 RVA: 0x0001D718 File Offset: 0x0001B918
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool n4ZK3kihot(KeyValuePair<string, JsonSchemaModel> p)
				{
					return true;
				}

				// Token: 0x06001291 RID: 4753 RVA: 0x0001D720 File Offset: 0x0001B920
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string PfdKSbUhBA(KeyValuePair<string, JsonSchemaModel> p)
				{
					return null;
				}

				// Token: 0x0400090A RID: 2314
				public static readonly JsonValidatingReader.xJDms0xkPmeahoDD7Z.uJTJfhN7mwfcYJRgffC KROKT00flf;

				// Token: 0x0400090B RID: 2315
				public static Func<string, string> vSNKRNx1v0;

				// Token: 0x0400090C RID: 2316
				public static Func<string, bool> sgFKwW4AFX;

				// Token: 0x0400090D RID: 2317
				public static Func<JsonSchemaModel, bool> EXmKBZHxPQ;

				// Token: 0x0400090E RID: 2318
				public static Func<KeyValuePair<string, JsonSchemaModel>, bool> m61KJiyv8m;

				// Token: 0x0400090F RID: 2319
				public static Func<KeyValuePair<string, JsonSchemaModel>, string> vtjKzy6gCy;
			}
		}

		// Token: 0x020001CD RID: 461
		[CompilerGenerated]
		[Serializable]
		private sealed class eLOFA9whmbobsqVKH5
		{
			// Token: 0x06001292 RID: 4754 RVA: 0x0001BAC8 File Offset: 0x00019CC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static eLOFA9whmbobsqVKH5()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				JsonValidatingReader.eLOFA9whmbobsqVKH5.ALGeVJTxKS = new JsonValidatingReader.eLOFA9whmbobsqVKH5();
			}

			// Token: 0x06001293 RID: 4755 RVA: 0x0001BAE4 File Offset: 0x00019CE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public eLOFA9whmbobsqVKH5()
			{
			}

			// Token: 0x06001294 RID: 4756 RVA: 0x0001BAEC File Offset: 0x00019CEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool IwGe1Twnff(JsonSchemaModel s)
			{
				return true;
			}

			// Token: 0x06001295 RID: 4757 RVA: 0x0001BAF4 File Offset: 0x00019CF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool OFAeivISGL(JsonSchemaModel s)
			{
				return true;
			}

			// Token: 0x06001296 RID: 4758 RVA: 0x0001BAFC File Offset: 0x00019CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool ybPeUgGrSJ(JsonSchemaModel s)
			{
				return true;
			}

			// Token: 0x06001297 RID: 4759 RVA: 0x0001BB04 File Offset: 0x00019D04
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool uROeIh5GSV(bool v)
			{
				return true;
			}

			// Token: 0x06001298 RID: 4760 RVA: 0x0001BB0C File Offset: 0x00019D0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool NpreNOCpWG(KeyValuePair<string, bool> kv)
			{
				return true;
			}

			// Token: 0x06001299 RID: 4761 RVA: 0x0001BB14 File Offset: 0x00019D14
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string UNGemf4gjV(KeyValuePair<string, bool> kv)
			{
				return null;
			}

			// Token: 0x04000910 RID: 2320
			public static readonly JsonValidatingReader.eLOFA9whmbobsqVKH5 ALGeVJTxKS;

			// Token: 0x04000911 RID: 2321
			public static Func<JsonSchemaModel, bool> vL3e93wbVt;

			// Token: 0x04000912 RID: 2322
			public static Func<JsonSchemaModel, bool> t1ge2J7Mwc;

			// Token: 0x04000913 RID: 2323
			public static Func<JsonSchemaModel, bool> OaVegKGI8K;

			// Token: 0x04000914 RID: 2324
			public static Func<bool, bool> GyUeCDBNE6;

			// Token: 0x04000915 RID: 2325
			public static Func<KeyValuePair<string, bool>, bool> mxme6D4VZL;

			// Token: 0x04000916 RID: 2326
			public static Func<KeyValuePair<string, bool>, string> EBHel8erf7;
		}
	}
}
