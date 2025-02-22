using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002E1 RID: 737
	public class JTokenWriter : JsonWriter
	{
		// Token: 0x06001CD8 RID: 7384 RVA: 0x000190B4 File Offset: 0x000172B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x000190BC File Offset: 0x000172BC
		public JToken CurrentToken
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001CDA RID: 7386 RVA: 0x000190C4 File Offset: 0x000172C4
		public JToken Token
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x000190CC File Offset: 0x000172CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JTokenWriter(JContainer container)
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x000190D4 File Offset: 0x000172D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JTokenWriter()
		{
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x000190DC File Offset: 0x000172DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Flush()
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000190E4 File Offset: 0x000172E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x000190EC File Offset: 0x000172EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteStartObject()
		{
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x000190F4 File Offset: 0x000172F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void e2S5lwNd3a(JContainer \u0020)
		{
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000190FC File Offset: 0x000172FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void iJ15qM9dDs()
		{
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0001910C File Offset: 0x0001730C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteStartArray()
		{
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00019114 File Offset: 0x00017314
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0001911C File Offset: 0x0001731C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00019124 File Offset: 0x00017324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0001912C File Offset: 0x0001732C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void mv85LJHbEp(object \u0020, JsonToken \u0020)
		{
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00019134 File Offset: 0x00017334
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void AddValue(JValue value, JsonToken token)
		{
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00019144 File Offset: 0x00017344
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0001914C File Offset: 0x0001734C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteNull()
		{
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00019154 File Offset: 0x00017354
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteUndefined()
		{
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0001915C File Offset: 0x0001735C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00019164 File Offset: 0x00017364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x0001916C File Offset: 0x0001736C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00019174 File Offset: 0x00017374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0001917C File Offset: 0x0001737C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00019184 File Offset: 0x00017384
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x0001918C File Offset: 0x0001738C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00019194 File Offset: 0x00017394
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x0001919C File Offset: 0x0001739C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000191A4 File Offset: 0x000173A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000191AC File Offset: 0x000173AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000191B4 File Offset: 0x000173B4
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000191BC File Offset: 0x000173BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000191CC File Offset: 0x000173CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000191D4 File Offset: 0x000173D4
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000191DC File Offset: 0x000173DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000191E4 File Offset: 0x000173E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000191EC File Offset: 0x000173EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000191F4 File Offset: 0x000173F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000191FC File Offset: 0x000173FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00019204 File Offset: 0x00017404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x0001920C File Offset: 0x0001740C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00019214 File Offset: 0x00017414
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00019224 File Offset: 0x00017424
		static JTokenWriter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000D4B RID: 3403
		private JContainer F0o58dETOL;

		// Token: 0x04000D4C RID: 3404
		private JContainer X2b5bw9ow0;

		// Token: 0x04000D4D RID: 3405
		private JValue Nly54mbsc3;

		// Token: 0x04000D4E RID: 3406
		private JToken IRY5XNiMex;
	}
}
