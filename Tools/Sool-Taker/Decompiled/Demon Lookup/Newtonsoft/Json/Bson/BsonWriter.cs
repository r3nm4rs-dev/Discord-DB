using System;
using System.IO;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000339 RID: 825
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonWriter : JsonWriter
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0001AB04 File Offset: 0x00018D04
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0001AB10 File Offset: 0x00018D10
		public DateTimeKind DateTimeKindHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DateTimeKind)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0001AB18 File Offset: 0x00018D18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BsonWriter(Stream stream)
		{
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0001AB20 File Offset: 0x00018D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BsonWriter(BinaryWriter writer)
		{
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0001AB28 File Offset: 0x00018D28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Flush()
		{
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0001AB30 File Offset: 0x00018D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x0001AB38 File Offset: 0x00018D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x0001AB40 File Offset: 0x00018D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0001AB48 File Offset: 0x00018D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0001AB50 File Offset: 0x00018D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteRawValue(string json)
		{
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0001AB58 File Offset: 0x00018D58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteStartArray()
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0001AB60 File Offset: 0x00018D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteStartObject()
		{
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0001AB68 File Offset: 0x00018D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0001AB70 File Offset: 0x00018D70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x0001AB78 File Offset: 0x00018D78
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void f4Ik5cK5RQ(BsonToken \u0020)
		{
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x0001AB80 File Offset: 0x00018D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IDIkWGOG49()
		{
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x0001AB88 File Offset: 0x00018D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void A3nksAKN6Y(object \u0020, BsonType \u0020)
		{
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0001AB90 File Offset: 0x00018D90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void AddToken(BsonToken token)
		{
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x0001ABA0 File Offset: 0x00018DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteNull()
		{
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteUndefined()
		{
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x0001ABC0 File Offset: 0x00018DC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x0001ABD0 File Offset: 0x00018DD0
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0001ABD8 File Offset: 0x00018DD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x0001ABE8 File Offset: 0x00018DE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x0001ABF0 File Offset: 0x00018DF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0001AC00 File Offset: 0x00018E00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0001AC08 File Offset: 0x00018E08
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0001AC10 File Offset: 0x00018E10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0001AC20 File Offset: 0x00018E20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0001AC28 File Offset: 0x00018E28
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x0001AC30 File Offset: 0x00018E30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0001AC38 File Offset: 0x00018E38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0001AC40 File Offset: 0x00018E40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0001AC48 File Offset: 0x00018E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0001AC50 File Offset: 0x00018E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0001AC58 File Offset: 0x00018E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x0001AC60 File Offset: 0x00018E60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0001AC68 File Offset: 0x00018E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteObjectId(byte[] value)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0001AC70 File Offset: 0x00018E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteRegex(string pattern, string options)
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0001AC78 File Offset: 0x00018E78
		static BsonWriter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000E53 RID: 3667
		private readonly BsonBinaryWriter p32kkdisrT;

		// Token: 0x04000E54 RID: 3668
		private BsonToken eOJkehCC2P;

		// Token: 0x04000E55 RID: 3669
		private BsonToken yUNkoGhpAM;

		// Token: 0x04000E56 RID: 3670
		private string CY0kAOgSrf;
	}
}
