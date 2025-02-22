using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002E2 RID: 738
	public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible
	{
		// Token: 0x06001D03 RID: 7427 RVA: 0x0001922C File Offset: 0x0001742C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0001923C File Offset: 0x0001743C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JValue(object value, JTokenType type)
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00019244 File Offset: 0x00017444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(JValue other)
		{
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x0001924C File Offset: 0x0001744C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(long value)
		{
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00019254 File Offset: 0x00017454
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(decimal value)
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0001925C File Offset: 0x0001745C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(char value)
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00019264 File Offset: 0x00017464
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(ulong value)
		{
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x0001926C File Offset: 0x0001746C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(double value)
		{
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00019274 File Offset: 0x00017474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(float value)
		{
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x0001927C File Offset: 0x0001747C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(DateTime value)
		{
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00019284 File Offset: 0x00017484
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(DateTimeOffset value)
		{
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0001928C File Offset: 0x0001748C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(bool value)
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00019294 File Offset: 0x00017494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(string value)
		{
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0001929C File Offset: 0x0001749C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(Guid value)
		{
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000192A4 File Offset: 0x000174A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(Uri value)
		{
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x000192AC File Offset: 0x000174AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(TimeSpan value)
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x000192B4 File Offset: 0x000174B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JValue(object value)
		{
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x000192C4 File Offset: 0x000174C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool DeepEquals(JToken node)
		{
			return true;
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x000192D4 File Offset: 0x000174D4
		public override bool HasValues
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x000192DC File Offset: 0x000174DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int Xgo5GyTXBg(BigInteger \u0020, object \u0020)
		{
			return 0;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x000192EC File Offset: 0x000174EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			return 0;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000192FC File Offset: 0x000174FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int iFN5dPMt1e(object \u0020, object \u0020)
		{
			return 0;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0001930C File Offset: 0x0001750C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool iV05j5V8LE(ExpressionType \u0020, object \u0020, object \u0020, out object \u0020)
		{
			return true;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0001931C File Offset: 0x0001751C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00019324 File Offset: 0x00017524
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JValue CreateComment(string value)
		{
			return null;
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0001932C File Offset: 0x0001752C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JValue CreateString(string value)
		{
			return null;
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00019334 File Offset: 0x00017534
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JValue CreateNull()
		{
			return null;
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0001933C File Offset: 0x0001753C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JValue CreateUndefined()
		{
			return null;
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00019344 File Offset: 0x00017544
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static JTokenType Y0Y5ysxbfB(JTokenType? \u0020, object \u0020)
		{
			return (JTokenType)null;
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00019358 File Offset: 0x00017558
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static JTokenType qOR5fUl18M(JTokenType? \u0020)
		{
			return (JTokenType)null;
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0001936C File Offset: 0x0001756C
		public override JTokenType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (JTokenType)null;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00019378 File Offset: 0x00017578
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00019380 File Offset: 0x00017580
		public new object Value
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

		// Token: 0x06001D24 RID: 7460 RVA: 0x00019390 File Offset: 0x00017590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000193A0 File Offset: 0x000175A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000193B0 File Offset: 0x000175B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool BOL5am0uIf(JValue \u0020, JValue \u0020)
		{
			return true;
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x000193B8 File Offset: 0x000175B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JValue other)
		{
			return true;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x000193C0 File Offset: 0x000175C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			return true;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x000193C8 File Offset: 0x000175C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x000193D0 File Offset: 0x000175D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x000193D8 File Offset: 0x000175D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x000193E0 File Offset: 0x000175E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x000193E8 File Offset: 0x000175E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000193F8 File Offset: 0x000175F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00019400 File Offset: 0x00017600
		[MethodImpl(MethodImplOptions.NoInlining)]
		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00019410 File Offset: 0x00017610
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CompareTo(JValue obj)
		{
			return 0;
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00019418 File Offset: 0x00017618
		[MethodImpl(MethodImplOptions.NoInlining)]
		TypeCode IConvertible.GetTypeCode()
		{
			return (TypeCode)null;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0001942C File Offset: 0x0001762C
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return true;
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00019434 File Offset: 0x00017634
		[MethodImpl(MethodImplOptions.NoInlining)]
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0001943C File Offset: 0x0001763C
		[MethodImpl(MethodImplOptions.NoInlining)]
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00019444 File Offset: 0x00017644
		[MethodImpl(MethodImplOptions.NoInlining)]
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0001944C File Offset: 0x0001764C
		[MethodImpl(MethodImplOptions.NoInlining)]
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x00019454 File Offset: 0x00017654
		[MethodImpl(MethodImplOptions.NoInlining)]
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0001945C File Offset: 0x0001765C
		[MethodImpl(MethodImplOptions.NoInlining)]
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00019464 File Offset: 0x00017664
		[MethodImpl(MethodImplOptions.NoInlining)]
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0001946C File Offset: 0x0001766C
		[MethodImpl(MethodImplOptions.NoInlining)]
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00019474 File Offset: 0x00017674
		[MethodImpl(MethodImplOptions.NoInlining)]
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0001947C File Offset: 0x0001767C
		[MethodImpl(MethodImplOptions.NoInlining)]
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return (float)0;
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00019484 File Offset: 0x00017684
		[MethodImpl(MethodImplOptions.NoInlining)]
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return (double)0;
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0001948C File Offset: 0x0001768C
		[MethodImpl(MethodImplOptions.NoInlining)]
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return (decimal)null;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00019498 File Offset: 0x00017698
		[MethodImpl(MethodImplOptions.NoInlining)]
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return (DateTime)null;
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x000194A4 File Offset: 0x000176A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		object IConvertible.ToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x000194AC File Offset: 0x000176AC
		static JValue()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000D4F RID: 3407
		private JTokenType aDj5n5lJuF;

		// Token: 0x04000D50 RID: 3408
		private object e5S55UUmFm;

		// Token: 0x020002E3 RID: 739
		private class aNkM2SNw0Qgb3dwcZcj : DynamicProxy<JValue>
		{
			// Token: 0x06001D42 RID: 7490 RVA: 0x0001D05C File Offset: 0x0001B25C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool TryConvert(JValue instance, ConvertBinder binder, out object result)
			{
				return true;
			}

			// Token: 0x06001D43 RID: 7491 RVA: 0x0001D06C File Offset: 0x0001B26C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result)
			{
				return true;
			}

			// Token: 0x06001D44 RID: 7492 RVA: 0x0001D07C File Offset: 0x0001B27C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public aNkM2SNw0Qgb3dwcZcj()
			{
			}

			// Token: 0x06001D45 RID: 7493 RVA: 0x0001D084 File Offset: 0x0001B284
			static aNkM2SNw0Qgb3dwcZcj()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}
	}
}
