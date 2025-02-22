using System;
using System.IO;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000293 RID: 659
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x060018CF RID: 6351 RVA: 0x00016AF0 File Offset: 0x00014CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TraceJsonReader(JsonReader innerReader)
		{
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00016B00 File Offset: 0x00014D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetDeserializedJsonMessage()
		{
			return null;
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00016B08 File Offset: 0x00014D08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Read()
		{
			return true;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00016B10 File Offset: 0x00014D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00016B18 File Offset: 0x00014D18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ReadAsString()
		{
			return null;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00016B20 File Offset: 0x00014D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00016B28 File Offset: 0x00014D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00016B30 File Offset: 0x00014D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00016B38 File Offset: 0x00014D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00016B40 File Offset: 0x00014D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00016B48 File Offset: 0x00014D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x00016B50 File Offset: 0x00014D50
		public override int Depth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060018DB RID: 6363 RVA: 0x00016B58 File Offset: 0x00014D58
		public override string Path
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x00016B60 File Offset: 0x00014D60
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x00016B68 File Offset: 0x00014D68
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

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00016B70 File Offset: 0x00014D70
		public override JsonToken TokenType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (JsonToken)null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x00016B7C File Offset: 0x00014D7C
		public override object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00016B84 File Offset: 0x00014D84
		public override Type ValueType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00016B8C File Offset: 0x00014D8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00016B94 File Offset: 0x00014D94
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IJsonLineInfo.HasLineInfo()
		{
			return true;
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00016BA4 File Offset: 0x00014DA4
		int IJsonLineInfo.LineNumber
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00016BB4 File Offset: 0x00014DB4
		int IJsonLineInfo.LinePosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00016BC4 File Offset: 0x00014DC4
		static TraceJsonReader()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000BBC RID: 3004
		private readonly JsonReader qSDflY04kt;

		// Token: 0x04000BBD RID: 3005
		private readonly JsonTextWriter dkXfqhfrVa;

		// Token: 0x04000BBE RID: 3006
		private readonly StringWriter wPUfLcUGao;
	}
}
