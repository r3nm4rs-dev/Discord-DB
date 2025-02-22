using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x020001CE RID: 462
	public abstract class JsonWriter : IDisposable
	{
		// Token: 0x0600129A RID: 4762 RVA: 0x000120AC File Offset: 0x000102AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x000120BC File Offset: 0x000102BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task PnsbtGV7Pt(CancellationToken \u0020)
		{
			return null;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000120CC File Offset: 0x000102CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task CloseAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000120D4 File Offset: 0x000102D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000120DC File Offset: 0x000102DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000120E4 File Offset: 0x000102E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task WriteIndentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000120EC File Offset: 0x000102EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000120F4 File Offset: 0x000102F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000120FC File Offset: 0x000102FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteRawAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00012104 File Offset: 0x00010304
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteEndAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0001210C File Offset: 0x0001030C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task WriteEndInternalAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0001211C File Offset: 0x0001031C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0001212C File Offset: 0x0001032C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteEndArrayAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00012134 File Offset: 0x00010334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteEndConstructorAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0001213C File Offset: 0x0001033C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteEndObjectAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00012144 File Offset: 0x00010344
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteNullAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0001214C File Offset: 0x0001034C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WritePropertyNameAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00012154 File Offset: 0x00010354
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0001215C File Offset: 0x0001035C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00012164 File Offset: 0x00010364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteStartArrayAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0001216C File Offset: 0x0001036C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0001217C File Offset: 0x0001037C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteCommentAsync(string text, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00012184 File Offset: 0x00010384
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task InternalWriteCommentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0001218C File Offset: 0x0001038C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteRawValueAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00012194 File Offset: 0x00010394
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteStartConstructorAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0001219C File Offset: 0x0001039C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteStartObjectAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000121A4 File Offset: 0x000103A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task WriteTokenAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000121AC File Offset: 0x000103AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task WriteTokenAsync(JsonReader reader, bool writeChildren, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000121B4 File Offset: 0x000103B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task WriteTokenAsync(JsonToken token, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000121BC File Offset: 0x000103BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task WriteTokenAsync(JsonToken token, object value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000121CC File Offset: 0x000103CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000121DC File Offset: 0x000103DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000121EC File Offset: 0x000103EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task e8obxk5FPy(JsonReader \u0020, CancellationToken \u0020)
		{
			return null;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000121FC File Offset: 0x000103FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(bool value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00012204 File Offset: 0x00010404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(bool? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0001220C File Offset: 0x0001040C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(byte value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00012214 File Offset: 0x00010414
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(byte? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0001221C File Offset: 0x0001041C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(byte[] value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00012224 File Offset: 0x00010424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(char value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0001222C File Offset: 0x0001042C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(char? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00012234 File Offset: 0x00010434
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(DateTime value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0001223C File Offset: 0x0001043C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(DateTime? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00012244 File Offset: 0x00010444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0001224C File Offset: 0x0001044C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(DateTimeOffset? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00012254 File Offset: 0x00010454
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(decimal value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0001225C File Offset: 0x0001045C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(decimal? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00012264 File Offset: 0x00010464
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(double value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0001226C File Offset: 0x0001046C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(double? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00012274 File Offset: 0x00010474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(float value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0001227C File Offset: 0x0001047C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(float? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00012284 File Offset: 0x00010484
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(Guid value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0001228C File Offset: 0x0001048C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(Guid? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00012294 File Offset: 0x00010494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(int value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0001229C File Offset: 0x0001049C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(int? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000122A4 File Offset: 0x000104A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(long value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x000122AC File Offset: 0x000104AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(long? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000122B4 File Offset: 0x000104B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(object value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000122BC File Offset: 0x000104BC
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(sbyte value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000122C4 File Offset: 0x000104C4
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(sbyte? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000122CC File Offset: 0x000104CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(short value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000122D4 File Offset: 0x000104D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(short? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x000122DC File Offset: 0x000104DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(string value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000122E4 File Offset: 0x000104E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(TimeSpan value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000122EC File Offset: 0x000104EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(TimeSpan? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000122F4 File Offset: 0x000104F4
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(uint value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000122FC File Offset: 0x000104FC
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(uint? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00012304 File Offset: 0x00010504
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(ulong value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0001230C File Offset: 0x0001050C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(ulong? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00012314 File Offset: 0x00010514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(Uri value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0001231C File Offset: 0x0001051C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(ushort value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00012324 File Offset: 0x00010524
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteValueAsync(ushort? value, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0001232C File Offset: 0x0001052C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteUndefinedAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00012334 File Offset: 0x00010534
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteWhitespaceAsync(string ws, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0001233C File Offset: 0x0001053C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00012344 File Offset: 0x00010544
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Task SetWriteStateAsync(JsonToken token, object value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00012354 File Offset: 0x00010554
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00012364 File Offset: 0x00010564
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JsonWriter.State[][] BuildStateArray()
		{
			return null;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00012384 File Offset: 0x00010584
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JsonWriter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			if (nCP5vtxT3QjsSeuiK3.TU7gF13T1(2432))
			{
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				JsonWriter.StateArrayTempate = new JsonWriter.State[][]
				{
					new JsonWriter.State[]
					{
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error
					},
					new JsonWriter.State[]
					{
						JsonWriter.State.ObjectStart,
						JsonWriter.State.ObjectStart,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.ObjectStart,
						JsonWriter.State.ObjectStart,
						JsonWriter.State.ObjectStart,
						JsonWriter.State.ObjectStart,
						JsonWriter.State.Error,
						JsonWriter.State.Error
					},
					new JsonWriter.State[]
					{
						JsonWriter.State.ArrayStart,
						JsonWriter.State.ArrayStart,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.ArrayStart,
						JsonWriter.State.ArrayStart,
						JsonWriter.State.ArrayStart,
						JsonWriter.State.ArrayStart,
						JsonWriter.State.Error,
						JsonWriter.State.Error
					},
					new JsonWriter.State[]
					{
						JsonWriter.State.ConstructorStart,
						JsonWriter.State.ConstructorStart,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.ConstructorStart,
						JsonWriter.State.ConstructorStart,
						JsonWriter.State.ConstructorStart,
						JsonWriter.State.ConstructorStart,
						JsonWriter.State.Error,
						JsonWriter.State.Error
					},
					new JsonWriter.State[]
					{
						JsonWriter.State.Property,
						JsonWriter.State.Error,
						JsonWriter.State.Property,
						JsonWriter.State.Property,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Error
					},
					new JsonWriter.State[]
					{
						JsonWriter.State.Start,
						JsonWriter.State.Property,
						JsonWriter.State.ObjectStart,
						JsonWriter.State.Object,
						JsonWriter.State.ArrayStart,
						JsonWriter.State.Array,
						JsonWriter.State.Constructor,
						JsonWriter.State.Constructor,
						JsonWriter.State.Error,
						JsonWriter.State.Error
					},
					new JsonWriter.State[]
					{
						JsonWriter.State.Start,
						JsonWriter.State.Property,
						JsonWriter.State.ObjectStart,
						JsonWriter.State.Object,
						JsonWriter.State.ArrayStart,
						JsonWriter.State.Array,
						JsonWriter.State.Constructor,
						JsonWriter.State.Constructor,
						JsonWriter.State.Error,
						JsonWriter.State.Error
					},
					new JsonWriter.State[]
					{
						JsonWriter.State.Start,
						JsonWriter.State.Object,
						JsonWriter.State.Error,
						JsonWriter.State.Error,
						JsonWriter.State.Array,
						JsonWriter.State.Array,
						JsonWriter.State.Constructor,
						JsonWriter.State.Constructor,
						JsonWriter.State.Error,
						JsonWriter.State.Error
					}
				};
				JsonWriter.Urrb18G6b3 = JsonWriter.BuildStateArray();
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0001246C File Offset: 0x0001066C
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00012474 File Offset: 0x00010674
		public bool CloseOutput
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x0001247C File Offset: 0x0001067C
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x00012484 File Offset: 0x00010684
		public bool AutoCompleteOnClose
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x0001248C File Offset: 0x0001068C
		protected internal int Top
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x0001249C File Offset: 0x0001069C
		public WriteState WriteState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (WriteState)null;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000124B0 File Offset: 0x000106B0
		internal string ContainerPath
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x000124C0 File Offset: 0x000106C0
		public string Path
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000124D0 File Offset: 0x000106D0
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x000124DC File Offset: 0x000106DC
		public Formatting Formatting
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Formatting)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000124E4 File Offset: 0x000106E4
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x000124F0 File Offset: 0x000106F0
		public DateFormatHandling DateFormatHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DateFormatHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x000124F8 File Offset: 0x000106F8
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x00012504 File Offset: 0x00010704
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DateTimeZoneHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0001250C File Offset: 0x0001070C
		// (set) Token: 0x060012F7 RID: 4855 RVA: 0x00012518 File Offset: 0x00010718
		public StringEscapeHandling StringEscapeHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (StringEscapeHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00012520 File Offset: 0x00010720
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00012528 File Offset: 0x00010728
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x00012534 File Offset: 0x00010734
		public FloatFormatHandling FloatFormatHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FloatFormatHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0001253C File Offset: 0x0001073C
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00012544 File Offset: 0x00010744
		public string DateFormatString
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

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x0001254C File Offset: 0x0001074C
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00012554 File Offset: 0x00010754
		public CultureInfo Culture
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

		// Token: 0x060012FF RID: 4863 RVA: 0x0001255C File Offset: 0x0001075C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected JsonWriter()
		{
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00012564 File Offset: 0x00010764
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void UpdateScopeWithFinishedValue()
		{
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0001256C File Offset: 0x0001076C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LWfbcWt2ZQ(JsonContainerType \u0020)
		{
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0001257C File Offset: 0x0001077C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonContainerType qiHbHj16in()
		{
			return (JsonContainerType)null;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00012590 File Offset: 0x00010790
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonContainerType GO2bYfCaDB()
		{
			return (JsonContainerType)null;
		}

		// Token: 0x06001304 RID: 4868
		public abstract void Flush();

		// Token: 0x06001305 RID: 4869 RVA: 0x0001259C File Offset: 0x0001079C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Close()
		{
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000125A4 File Offset: 0x000107A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteStartObject()
		{
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000125AC File Offset: 0x000107AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteEndObject()
		{
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000125B4 File Offset: 0x000107B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteStartArray()
		{
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x000125BC File Offset: 0x000107BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteEndArray()
		{
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000125C4 File Offset: 0x000107C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteStartConstructor(string name)
		{
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000125CC File Offset: 0x000107CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteEndConstructor()
		{
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000125D4 File Offset: 0x000107D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WritePropertyName(string name)
		{
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000125DC File Offset: 0x000107DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WritePropertyName(string name, bool escape)
		{
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000125E4 File Offset: 0x000107E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteEnd()
		{
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000125EC File Offset: 0x000107EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteToken(JsonReader reader)
		{
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000125F4 File Offset: 0x000107F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000125FC File Offset: 0x000107FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteToken(JsonToken token, object value)
		{
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0001260C File Offset: 0x0001080C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteToken(JsonToken token)
		{
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00012614 File Offset: 0x00010814
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00012624 File Offset: 0x00010824
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int pB9bP0gGjl(JsonReader \u0020)
		{
			return 0;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00012634 File Offset: 0x00010834
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int XW7brAnFd8(JsonReader \u0020)
		{
			return 0;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00012644 File Offset: 0x00010844
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void KKhbpclS0J(JsonReader \u0020)
		{
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00012654 File Offset: 0x00010854
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void cQBbMux0LT(JsonContainerType \u0020)
		{
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00012664 File Offset: 0x00010864
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FylbOWTn7p()
		{
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0001266C File Offset: 0x0001086C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonToken wNfbvWxaWp(JsonContainerType \u0020)
		{
			return (JsonToken)null;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00012680 File Offset: 0x00010880
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NdUbFnGijx(JsonContainerType \u0020)
		{
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00012690 File Offset: 0x00010890
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int FHvb0hUX8N(JsonContainerType \u0020)
		{
			return 0;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000126A0 File Offset: 0x000108A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void L53bup6ch1()
		{
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000126B0 File Offset: 0x000108B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x000126B8 File Offset: 0x000108B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void WriteIndent()
		{
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x000126C0 File Offset: 0x000108C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void WriteValueDelimiter()
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000126C8 File Offset: 0x000108C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void WriteIndentSpace()
		{
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000126D0 File Offset: 0x000108D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000126E0 File Offset: 0x000108E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteNull()
		{
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000126E8 File Offset: 0x000108E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteUndefined()
		{
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000126F0 File Offset: 0x000108F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteRaw(string json)
		{
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000126F8 File Offset: 0x000108F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteRawValue(string json)
		{
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00012700 File Offset: 0x00010900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(string value)
		{
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00012708 File Offset: 0x00010908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(int value)
		{
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00012710 File Offset: 0x00010910
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(uint value)
		{
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00012718 File Offset: 0x00010918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(long value)
		{
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00012720 File Offset: 0x00010920
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(ulong value)
		{
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00012728 File Offset: 0x00010928
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(float value)
		{
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00012730 File Offset: 0x00010930
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(double value)
		{
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00012738 File Offset: 0x00010938
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(bool value)
		{
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00012740 File Offset: 0x00010940
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(short value)
		{
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00012748 File Offset: 0x00010948
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(ushort value)
		{
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00012750 File Offset: 0x00010950
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(char value)
		{
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00012758 File Offset: 0x00010958
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(byte value)
		{
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00012760 File Offset: 0x00010960
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(sbyte value)
		{
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00012768 File Offset: 0x00010968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(decimal value)
		{
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00012770 File Offset: 0x00010970
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(DateTime value)
		{
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00012778 File Offset: 0x00010978
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00012780 File Offset: 0x00010980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(Guid value)
		{
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00012788 File Offset: 0x00010988
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00012790 File Offset: 0x00010990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(int? value)
		{
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00012798 File Offset: 0x00010998
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(uint? value)
		{
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000127A0 File Offset: 0x000109A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(long? value)
		{
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000127A8 File Offset: 0x000109A8
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(ulong? value)
		{
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000127B0 File Offset: 0x000109B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(float? value)
		{
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000127B8 File Offset: 0x000109B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(double? value)
		{
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000127C0 File Offset: 0x000109C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(bool? value)
		{
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000127C8 File Offset: 0x000109C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(short? value)
		{
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000127D0 File Offset: 0x000109D0
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(ushort? value)
		{
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000127D8 File Offset: 0x000109D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(char? value)
		{
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000127E0 File Offset: 0x000109E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(byte? value)
		{
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000127E8 File Offset: 0x000109E8
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(sbyte? value)
		{
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000127F0 File Offset: 0x000109F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(decimal? value)
		{
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000127F8 File Offset: 0x000109F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(DateTime? value)
		{
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00012800 File Offset: 0x00010A00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00012808 File Offset: 0x00010A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(Guid? value)
		{
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00012810 File Offset: 0x00010A10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(TimeSpan? value)
		{
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00012818 File Offset: 0x00010A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(byte[] value)
		{
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00012820 File Offset: 0x00010A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(Uri value)
		{
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00012828 File Offset: 0x00010A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteValue(object value)
		{
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00012830 File Offset: 0x00010A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteComment(string text)
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00012838 File Offset: 0x00010A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void WriteWhitespace(string ws)
		{
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00012840 File Offset: 0x00010A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDisposable.Dispose()
		{
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00012848 File Offset: 0x00010A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00012850 File Offset: 0x00010A50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00012860 File Offset: 0x00010A60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static JsonWriterException hf3b7I4u8S(JsonWriter \u0020, object \u0020)
		{
			return null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00012868 File Offset: 0x00010A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetWriteState(JsonToken token, object value)
		{
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00012878 File Offset: 0x00010A78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalWriteEnd(JsonContainerType container)
		{
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00012880 File Offset: 0x00010A80
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalWritePropertyName(string name)
		{
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00012888 File Offset: 0x00010A88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalWriteRaw()
		{
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00012890 File Offset: 0x00010A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00012898 File Offset: 0x00010A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalWriteValue(JsonToken token)
		{
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x000128A0 File Offset: 0x00010AA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalWriteWhitespace(string ws)
		{
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x000128A8 File Offset: 0x00010AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalWriteComment()
		{
		}

		// Token: 0x04000917 RID: 2327
		private static readonly JsonWriter.State[][] Urrb18G6b3;

		// Token: 0x04000918 RID: 2328
		internal static readonly JsonWriter.State[][] StateArrayTempate;

		// Token: 0x04000919 RID: 2329
		private List<JsonPosition> UWVbibfmxK;

		// Token: 0x0400091A RID: 2330
		private JsonPosition pSybUpADNc;

		// Token: 0x0400091B RID: 2331
		private JsonWriter.State Wj8bIxyWfe;

		// Token: 0x0400091C RID: 2332
		private Formatting rrFbNnancd;

		// Token: 0x0400091D RID: 2333
		[CompilerGenerated]
		private bool P9SbmHYeBP;

		// Token: 0x0400091E RID: 2334
		[CompilerGenerated]
		private bool ePabVt7Zgc;

		// Token: 0x0400091F RID: 2335
		private DateFormatHandling qiOb98fDq8;

		// Token: 0x04000920 RID: 2336
		private DateTimeZoneHandling ogQb2cQ692;

		// Token: 0x04000921 RID: 2337
		private StringEscapeHandling uupbgdWoH0;

		// Token: 0x04000922 RID: 2338
		private FloatFormatHandling ssIbCH5e4p;

		// Token: 0x04000923 RID: 2339
		private string aJGb6baiaT;

		// Token: 0x04000924 RID: 2340
		private CultureInfo Yo4blV2rjG;

		// Token: 0x020001CF RID: 463
		internal enum State
		{
			// Token: 0x04000926 RID: 2342
			Start,
			// Token: 0x04000927 RID: 2343
			Property,
			// Token: 0x04000928 RID: 2344
			ObjectStart,
			// Token: 0x04000929 RID: 2345
			Object,
			// Token: 0x0400092A RID: 2346
			ArrayStart,
			// Token: 0x0400092B RID: 2347
			Array,
			// Token: 0x0400092C RID: 2348
			ConstructorStart,
			// Token: 0x0400092D RID: 2349
			Constructor,
			// Token: 0x0400092E RID: 2350
			Closed,
			// Token: 0x0400092F RID: 2351
			Error
		}
	}
}
