using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x02000180 RID: 384
	public abstract class JsonReader : IDisposable
	{
		// Token: 0x06000F4A RID: 3914 RVA: 0x0001037C File Offset: 0x0000E57C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<bool> ReadAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00010384 File Offset: 0x0000E584
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task SkipAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00010394 File Offset: 0x0000E594
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task ReaderReadAndAssertAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x000103A4 File Offset: 0x0000E5A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<bool?> ReadAsBooleanAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000103AC File Offset: 0x0000E5AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<byte[]> ReadAsBytesAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000103B4 File Offset: 0x0000E5B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<byte[]> ReadArrayIntoByteArrayAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000103C4 File Offset: 0x0000E5C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<DateTime?> ReadAsDateTimeAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000103CC File Offset: 0x0000E5CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<DateTimeOffset?> ReadAsDateTimeOffsetAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000103D4 File Offset: 0x0000E5D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<decimal?> ReadAsDecimalAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x000103DC File Offset: 0x0000E5DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<double?> ReadAsDoubleAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x000103E4 File Offset: 0x0000E5E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<int?> ReadAsInt32Async(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000103EC File Offset: 0x0000E5EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<string> ReadAsStringAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x000103F4 File Offset: 0x0000E5F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<bool> ReadAndMoveToContentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00010404 File Offset: 0x0000E604
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task<bool> MoveToContentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00010414 File Offset: 0x0000E614
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> nvflV2JDfp(CancellationToken \u0020)
		{
			return null;
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00010424 File Offset: 0x0000E624
		protected JsonReader.State CurrentState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (JsonReader.State)null;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00010430 File Offset: 0x0000E630
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00010438 File Offset: 0x0000E638
		public bool CloseInput
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

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00010440 File Offset: 0x0000E640
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00010448 File Offset: 0x0000E648
		public bool SupportMultipleContent
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

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00010450 File Offset: 0x0000E650
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00010458 File Offset: 0x0000E658
		public virtual char QuoteChar
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

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00010460 File Offset: 0x0000E660
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0001046C File Offset: 0x0000E66C
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

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00010474 File Offset: 0x0000E674
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x00010480 File Offset: 0x0000E680
		public DateParseHandling DateParseHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DateParseHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00010488 File Offset: 0x0000E688
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x00010494 File Offset: 0x0000E694
		public FloatParseHandling FloatParseHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FloatParseHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0001049C File Offset: 0x0000E69C
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x000104A4 File Offset: 0x0000E6A4
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x000104AC File Offset: 0x0000E6AC
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x000104B4 File Offset: 0x0000E6B4
		public int? MaxDepth
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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000104C4 File Offset: 0x0000E6C4
		public virtual JsonToken TokenType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (JsonToken)null;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x000104D0 File Offset: 0x0000E6D0
		public virtual object Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x000104D8 File Offset: 0x0000E6D8
		public virtual Type ValueType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x000104E0 File Offset: 0x0000E6E0
		public virtual int Depth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x000104F0 File Offset: 0x0000E6F0
		public virtual string Path
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00010500 File Offset: 0x0000E700
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00010508 File Offset: 0x0000E708
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

		// Token: 0x06000F71 RID: 3953 RVA: 0x00010510 File Offset: 0x0000E710
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JsonPosition GetPosition(int depth)
		{
			return (JsonPosition)null;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0001051C File Offset: 0x0000E71C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected JsonReader()
		{
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00010524 File Offset: 0x0000E724
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void xyUl9gaqv5(JsonContainerType \u0020)
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00010534 File Offset: 0x0000E734
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonContainerType nIul2EU4uR()
		{
			return (JsonContainerType)null;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00010548 File Offset: 0x0000E748
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonContainerType hxJlgIVWcb()
		{
			return (JsonContainerType)null;
		}

		// Token: 0x06000F76 RID: 3958
		public abstract bool Read();

		// Token: 0x06000F77 RID: 3959 RVA: 0x00010554 File Offset: 0x0000E754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00010564 File Offset: 0x0000E764
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int? ReadInt32String(string s)
		{
			return null;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00010574 File Offset: 0x0000E774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string ReadAsString()
		{
			return null;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00010584 File Offset: 0x0000E784
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00010594 File Offset: 0x0000E794
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] ReadArrayIntoByteArray()
		{
			return null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000105A4 File Offset: 0x0000E7A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool YyAlCg5aa7(List<byte> \u0020)
		{
			return true;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000105B4 File Offset: 0x0000E7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000105C4 File Offset: 0x0000E7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal double? ReadDoubleString(string s)
		{
			return null;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000105D4 File Offset: 0x0000E7D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x000105E4 File Offset: 0x0000E7E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool? ReadBooleanString(string s)
		{
			return null;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x000105F4 File Offset: 0x0000E7F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00010604 File Offset: 0x0000E804
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal decimal? ReadDecimalString(string s)
		{
			return null;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00010614 File Offset: 0x0000E814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00010624 File Offset: 0x0000E824
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DateTime? ReadDateTimeString(string s)
		{
			return null;
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00010634 File Offset: 0x0000E834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00010644 File Offset: 0x0000E844
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			return null;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00010654 File Offset: 0x0000E854
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ReaderReadAndAssert()
		{
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0001065C File Offset: 0x0000E85C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JsonReaderException CreateUnexpectedEndException()
		{
			return null;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00010664 File Offset: 0x0000E864
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ReadIntoWrappedTypeObject()
		{
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00010674 File Offset: 0x0000E874
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Skip()
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00010684 File Offset: 0x0000E884
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetToken(JsonToken newToken)
		{
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0001068C File Offset: 0x0000E88C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetToken(JsonToken newToken, object value)
		{
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00010694 File Offset: 0x0000E894
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000106A4 File Offset: 0x0000E8A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetPostValueState(bool updateIndex)
		{
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000106AC File Offset: 0x0000E8AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void eNIl6KL2on()
		{
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000106B4 File Offset: 0x0000E8B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QbOllNlTk7(JsonToken \u0020)
		{
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000106C4 File Offset: 0x0000E8C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetStateBasedOnCurrent()
		{
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000106D4 File Offset: 0x0000E8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void XqGlq9OVNn()
		{
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000106DC File Offset: 0x0000E8DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonContainerType OXnlLUmjrg(JsonToken \u0020)
		{
			return (JsonContainerType)null;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000106F0 File Offset: 0x0000E8F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00010700 File Offset: 0x0000E900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Close()
		{
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00010708 File Offset: 0x0000E908
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ReadAndAssert()
		{
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00010710 File Offset: 0x0000E910
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter)
		{
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00010718 File Offset: 0x0000E918
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool ReadForType(JsonContract contract, bool hasConverter)
		{
			return true;
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00010728 File Offset: 0x0000E928
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool ReadAndMoveToContent()
		{
			return true;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00010730 File Offset: 0x0000E930
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool MoveToContent()
		{
			return true;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00010740 File Offset: 0x0000E940
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonToken QCYl8xOOSk()
		{
			return (JsonToken)null;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00010754 File Offset: 0x0000E954
		static JsonReader()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040006AA RID: 1706
		private JsonToken bsLlbha6ZL;

		// Token: 0x040006AB RID: 1707
		private object WPFl4AqYLA;

		// Token: 0x040006AC RID: 1708
		internal char _quoteChar;

		// Token: 0x040006AD RID: 1709
		internal JsonReader.State _currentState;

		// Token: 0x040006AE RID: 1710
		private JsonPosition bCalXX0TAo;

		// Token: 0x040006AF RID: 1711
		private CultureInfo KpslGPisJg;

		// Token: 0x040006B0 RID: 1712
		private DateTimeZoneHandling riwldCw7Tr;

		// Token: 0x040006B1 RID: 1713
		private int? SPflj0jkhQ;

		// Token: 0x040006B2 RID: 1714
		private bool F9Bly9CNZw;

		// Token: 0x040006B3 RID: 1715
		internal DateParseHandling _dateParseHandling;

		// Token: 0x040006B4 RID: 1716
		internal FloatParseHandling _floatParseHandling;

		// Token: 0x040006B5 RID: 1717
		private string W4olf7vChq;

		// Token: 0x040006B6 RID: 1718
		private List<JsonPosition> EI7lacpPEb;

		// Token: 0x040006B7 RID: 1719
		[CompilerGenerated]
		private bool IRxln6xFA9;

		// Token: 0x040006B8 RID: 1720
		[CompilerGenerated]
		private bool yFLl5K0QJo;

		// Token: 0x02000181 RID: 385
		protected internal enum State
		{
			// Token: 0x040006BA RID: 1722
			Start,
			// Token: 0x040006BB RID: 1723
			Complete,
			// Token: 0x040006BC RID: 1724
			Property,
			// Token: 0x040006BD RID: 1725
			ObjectStart,
			// Token: 0x040006BE RID: 1726
			Object,
			// Token: 0x040006BF RID: 1727
			ArrayStart,
			// Token: 0x040006C0 RID: 1728
			Array,
			// Token: 0x040006C1 RID: 1729
			Closed,
			// Token: 0x040006C2 RID: 1730
			PostValue,
			// Token: 0x040006C3 RID: 1731
			ConstructorStart,
			// Token: 0x040006C4 RID: 1732
			Constructor,
			// Token: 0x040006C5 RID: 1733
			Error,
			// Token: 0x040006C6 RID: 1734
			Finished
		}
	}
}
