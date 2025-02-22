using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002D6 RID: 726
	public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
	{
		// Token: 0x06001BF5 RID: 7157 RVA: 0x000187A4 File Offset: 0x000169A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000187AC File Offset: 0x000169AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task WriteToAsync(JsonWriter writer, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000187BC File Offset: 0x000169BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<JToken> ReadFromAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000187C4 File Offset: 0x000169C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<JToken> ReadFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x000187D4 File Offset: 0x000169D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<JToken> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x000187DC File Offset: 0x000169DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<JToken> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x000187E4 File Offset: 0x000169E4
		public static JTokenEqualityComparer EqualityComparer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x000187EC File Offset: 0x000169EC
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x000187F4 File Offset: 0x000169F4
		public JContainer Parent
		{
			[DebuggerStepThrough]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x000187FC File Offset: 0x000169FC
		public JToken Root
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BFF RID: 7167
		internal abstract JToken CloneToken();

		// Token: 0x06001C00 RID: 7168
		internal abstract bool DeepEquals(JToken node);

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001C01 RID: 7169
		public abstract JTokenType Type { get; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001C02 RID: 7170
		public abstract bool HasValues { get; }

		// Token: 0x06001C03 RID: 7171 RVA: 0x0001880C File Offset: 0x00016A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool DeepEquals(JToken t1, JToken t2)
		{
			return true;
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x00018814 File Offset: 0x00016A14
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0001881C File Offset: 0x00016A1C
		public JToken Next
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00018824 File Offset: 0x00016A24
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0001882C File Offset: 0x00016A2C
		public JToken Previous
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal set
			{
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00018834 File Offset: 0x00016A34
		public string Path
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00018844 File Offset: 0x00016A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JToken()
		{
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0001884C File Offset: 0x00016A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAfterSelf(object content)
		{
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0001885C File Offset: 0x00016A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddBeforeSelf(object content)
		{
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0001886C File Offset: 0x00016A6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JToken> Ancestors()
		{
			return null;
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00018874 File Offset: 0x00016A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JToken> AncestorsAndSelf()
		{
			return null;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0001887C File Offset: 0x00016A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<JToken> GetAncestors(bool self)
		{
			return null;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00018884 File Offset: 0x00016A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JToken> AfterSelf()
		{
			return null;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0001888C File Offset: 0x00016A8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JToken> BeforeSelf()
		{
			return null;
		}

		// Token: 0x170005B3 RID: 1459
		public virtual JToken this[object key]
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

		// Token: 0x06001C13 RID: 7187 RVA: 0x000188A4 File Offset: 0x00016AA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual T Value<T>(object key)
		{
			return null;
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000188B4 File Offset: 0x00016AB4
		public virtual JToken First
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x000188BC File Offset: 0x00016ABC
		public virtual JToken Last
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000188C4 File Offset: 0x00016AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual JEnumerable<JToken> Children()
		{
			return null;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000188CC File Offset: 0x00016ACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JEnumerable<T> Children<T>() where T : JToken
		{
			return null;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000188D4 File Offset: 0x00016AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IEnumerable<T> Values<T>()
		{
			return null;
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000188DC File Offset: 0x00016ADC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Remove()
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000188E4 File Offset: 0x00016AE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Replace(JToken value)
		{
		}

		// Token: 0x06001C1B RID: 7195
		public abstract void WriteTo(JsonWriter writer, params JsonConverter[] converters);

		// Token: 0x06001C1C RID: 7196 RVA: 0x000188EC File Offset: 0x00016AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000188F4 File Offset: 0x00016AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00018914 File Offset: 0x00016B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static JValue PoQnwSUCxq(JToken \u0020)
		{
			return null;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0001891C File Offset: 0x00016B1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string nDbnBfNUVq(JToken \u0020)
		{
			return null;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0001892C File Offset: 0x00016B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool EQGnJCOZZd(JToken \u0020, JTokenType[] \u0020, bool \u0020)
		{
			return true;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00018934 File Offset: 0x00016B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator bool(JToken value)
		{
			return true;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00018944 File Offset: 0x00016B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator DateTimeOffset(JToken value)
		{
			return (DateTimeOffset)null;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00018958 File Offset: 0x00016B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator bool?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00018968 File Offset: 0x00016B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator long(JToken value)
		{
			return 0L;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00018978 File Offset: 0x00016B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator DateTime?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00018988 File Offset: 0x00016B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator DateTimeOffset?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00018998 File Offset: 0x00016B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator decimal?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000189A8 File Offset: 0x00016BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator double?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000189B8 File Offset: 0x00016BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator char?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000189C8 File Offset: 0x00016BC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator int(JToken value)
		{
			return 0;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x000189D8 File Offset: 0x00016BD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator short(JToken value)
		{
			return 0;
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000189E8 File Offset: 0x00016BE8
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator ushort(JToken value)
		{
			return 0;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x000189F8 File Offset: 0x00016BF8
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator char(JToken value)
		{
			return '\0';
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00018A08 File Offset: 0x00016C08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator byte(JToken value)
		{
			return 0;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00018A18 File Offset: 0x00016C18
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator sbyte(JToken value)
		{
			return 0;
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00018A28 File Offset: 0x00016C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator int?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00018A38 File Offset: 0x00016C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator short?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00018A48 File Offset: 0x00016C48
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator ushort?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00018A58 File Offset: 0x00016C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator byte?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00018A68 File Offset: 0x00016C68
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator sbyte?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00018A78 File Offset: 0x00016C78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator DateTime(JToken value)
		{
			return (DateTime)null;
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00018A8C File Offset: 0x00016C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator long?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00018A9C File Offset: 0x00016C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator float?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00018AAC File Offset: 0x00016CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator decimal(JToken value)
		{
			return (decimal)null;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00018AC0 File Offset: 0x00016CC0
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator uint?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00018AD0 File Offset: 0x00016CD0
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator ulong?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00018AE0 File Offset: 0x00016CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator double(JToken value)
		{
			return (double)0;
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00018AF0 File Offset: 0x00016CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator float(JToken value)
		{
			return (float)0;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00018B00 File Offset: 0x00016D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator string(JToken value)
		{
			return null;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00018B10 File Offset: 0x00016D10
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator uint(JToken value)
		{
			return 0U;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00018B20 File Offset: 0x00016D20
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator ulong(JToken value)
		{
			return 0UL;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00018B30 File Offset: 0x00016D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator byte[](JToken value)
		{
			return null;
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00018B40 File Offset: 0x00016D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator Guid(JToken value)
		{
			return (Guid)null;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00018B54 File Offset: 0x00016D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator Guid?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00018B64 File Offset: 0x00016D64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator TimeSpan(JToken value)
		{
			return (TimeSpan)null;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00018B78 File Offset: 0x00016D78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator TimeSpan?(JToken value)
		{
			return null;
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00018B88 File Offset: 0x00016D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static explicit operator Uri(JToken value)
		{
			return null;
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00018B98 File Offset: 0x00016D98
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static BigInteger FVDnzPXVUt(JToken \u0020)
		{
			return (BigInteger)null;
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00018BAC File Offset: 0x00016DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static BigInteger? p645tlvDmY(JToken \u0020)
		{
			return null;
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00018BBC File Offset: 0x00016DBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(bool value)
		{
			return null;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00018BC4 File Offset: 0x00016DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(DateTimeOffset value)
		{
			return null;
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00018BCC File Offset: 0x00016DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(byte value)
		{
			return null;
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00018BD4 File Offset: 0x00016DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(byte? value)
		{
			return null;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00018BDC File Offset: 0x00016DDC
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(sbyte value)
		{
			return null;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00018BE4 File Offset: 0x00016DE4
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(sbyte? value)
		{
			return null;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00018BEC File Offset: 0x00016DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(bool? value)
		{
			return null;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00018BF4 File Offset: 0x00016DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(long value)
		{
			return null;
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00018BFC File Offset: 0x00016DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(DateTime? value)
		{
			return null;
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00018C04 File Offset: 0x00016E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(DateTimeOffset? value)
		{
			return null;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00018C0C File Offset: 0x00016E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(decimal? value)
		{
			return null;
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00018C14 File Offset: 0x00016E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(double? value)
		{
			return null;
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00018C1C File Offset: 0x00016E1C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(short value)
		{
			return null;
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00018C24 File Offset: 0x00016E24
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(ushort value)
		{
			return null;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00018C2C File Offset: 0x00016E2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(int value)
		{
			return null;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00018C34 File Offset: 0x00016E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(int? value)
		{
			return null;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00018C3C File Offset: 0x00016E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(DateTime value)
		{
			return null;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00018C44 File Offset: 0x00016E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(long? value)
		{
			return null;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00018C4C File Offset: 0x00016E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(float? value)
		{
			return null;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00018C54 File Offset: 0x00016E54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(decimal value)
		{
			return null;
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00018C5C File Offset: 0x00016E5C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(short? value)
		{
			return null;
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00018C64 File Offset: 0x00016E64
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(ushort? value)
		{
			return null;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00018C6C File Offset: 0x00016E6C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(uint? value)
		{
			return null;
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x00018C74 File Offset: 0x00016E74
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(ulong? value)
		{
			return null;
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00018C7C File Offset: 0x00016E7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(double value)
		{
			return null;
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00018C84 File Offset: 0x00016E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(float value)
		{
			return null;
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00018C8C File Offset: 0x00016E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(string value)
		{
			return null;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00018C94 File Offset: 0x00016E94
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(uint value)
		{
			return null;
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00018C9C File Offset: 0x00016E9C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(ulong value)
		{
			return null;
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00018CA4 File Offset: 0x00016EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(byte[] value)
		{
			return null;
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00018CAC File Offset: 0x00016EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(Uri value)
		{
			return null;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00018CB4 File Offset: 0x00016EB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(TimeSpan value)
		{
			return null;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00018CBC File Offset: 0x00016EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(TimeSpan? value)
		{
			return null;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00018CC4 File Offset: 0x00016EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(Guid value)
		{
			return null;
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00018CCC File Offset: 0x00016ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator JToken(Guid? value)
		{
			return null;
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00018CD4 File Offset: 0x00016ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00018CDC File Offset: 0x00016EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001C6D RID: 7277
		internal abstract int GetDeepHashCode();

		// Token: 0x170005B6 RID: 1462
		IJEnumerable<JToken> IJEnumerable<JToken>.this[object key]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00018CF4 File Offset: 0x00016EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonReader CreateReader()
		{
			return null;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00018CFC File Offset: 0x00016EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00018D1C File Offset: 0x00016F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JToken FromObject(object o)
		{
			return null;
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00018D24 File Offset: 0x00016F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JToken FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00018D2C File Offset: 0x00016F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T ToObject<T>()
		{
			return null;
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00018D34 File Offset: 0x00016F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object ToObject(Type objectType)
		{
			return null;
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00018D54 File Offset: 0x00016F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T ToObject<T>(JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00018D5C File Offset: 0x00016F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00018D7C File Offset: 0x00016F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JToken ReadFrom(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00018D84 File Offset: 0x00016F84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00018D94 File Offset: 0x00016F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JToken Parse(string json)
		{
			return null;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00018D9C File Offset: 0x00016F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JToken Parse(string json, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00018DBC File Offset: 0x00016FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JToken Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00018DC4 File Offset: 0x00016FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JToken Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00018DCC File Offset: 0x00016FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00018DD4 File Offset: 0x00016FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00018DDC File Offset: 0x00016FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IJsonLineInfo.HasLineInfo()
		{
			return true;
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00018DE4 File Offset: 0x00016FE4
		int IJsonLineInfo.LineNumber
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00018DF4 File Offset: 0x00016FF4
		int IJsonLineInfo.LinePosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00018E04 File Offset: 0x00017004
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JToken SelectToken(string path)
		{
			return null;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00018E0C File Offset: 0x0001700C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00018E2C File Offset: 0x0001702C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JToken> SelectTokens(string path)
		{
			return null;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00018E34 File Offset: 0x00017034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			return null;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00018E3C File Offset: 0x0001703C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00018E44 File Offset: 0x00017044
		[MethodImpl(MethodImplOptions.NoInlining)]
		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
		{
			return null;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00018E4C File Offset: 0x0001704C
		[MethodImpl(MethodImplOptions.NoInlining)]
		object ICloneable.Clone()
		{
			return null;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00018E54 File Offset: 0x00017054
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JToken DeepClone()
		{
			return null;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00018E5C File Offset: 0x0001705C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAnnotation(object annotation)
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00018E6C File Offset: 0x0001706C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Annotation<T>() where T : class
		{
			return null;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00018E7C File Offset: 0x0001707C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Annotation(Type type)
		{
			return null;
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00018E8C File Offset: 0x0001708C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<T> Annotations<T>() where T : class
		{
			return null;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00018E94 File Offset: 0x00017094
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<object> Annotations(Type type)
		{
			return null;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00018E9C File Offset: 0x0001709C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveAnnotations<T>() where T : class
		{
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00018EAC File Offset: 0x000170AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveAnnotations(Type type)
		{
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00018EBC File Offset: 0x000170BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JToken()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			if (nCP5vtxT3QjsSeuiK3.TU7gF13T1(3044))
			{
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				JToken.jvO5rdbWoc = new JTokenType[]
				{
					JTokenType.Integer,
					JTokenType.Float,
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw,
					JTokenType.Boolean
				};
				JToken.dkB5pa4rmA = new JTokenType[]
				{
					JTokenType.Integer,
					JTokenType.Float,
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw,
					JTokenType.Boolean
				};
				JToken.LV55MTcBse = new JTokenType[]
				{
					JTokenType.Integer,
					JTokenType.Float,
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw,
					JTokenType.Boolean,
					JTokenType.Bytes
				};
				JToken.FcH5O67AmP = new JTokenType[]
				{
					JTokenType.Date,
					JTokenType.Integer,
					JTokenType.Float,
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw,
					JTokenType.Boolean,
					JTokenType.Bytes,
					JTokenType.Guid,
					JTokenType.TimeSpan,
					JTokenType.Uri
				};
				JToken.lxi5vN6hNi = new JTokenType[]
				{
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw,
					JTokenType.Guid,
					JTokenType.Bytes
				};
				JToken.sAs5F3L98J = new JTokenType[]
				{
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw,
					JTokenType.TimeSpan
				};
				JToken.QT7507e3tN = new JTokenType[]
				{
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw,
					JTokenType.Uri
				};
				JToken.XsD5uu3Y06 = new JTokenType[]
				{
					JTokenType.Integer,
					JTokenType.Float,
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw
				};
				JToken.keT577d1dS = new JTokenType[]
				{
					JTokenType.Date,
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw
				};
				JToken.fMB515ZcXK = new JTokenType[]
				{
					JTokenType.Bytes,
					JTokenType.String,
					JTokenType.Comment,
					JTokenType.Raw,
					JTokenType.Integer
				};
			}
		}

		// Token: 0x04000CF9 RID: 3321
		private static JTokenEqualityComparer DGN5xYAwn6;

		// Token: 0x04000CFA RID: 3322
		private JContainer M6i5ckOjgm;

		// Token: 0x04000CFB RID: 3323
		private JToken wro5HmwAt3;

		// Token: 0x04000CFC RID: 3324
		private JToken mg75YhHmY3;

		// Token: 0x04000CFD RID: 3325
		private object sRl5PEMCtX;

		// Token: 0x04000CFE RID: 3326
		private static readonly JTokenType[] jvO5rdbWoc;

		// Token: 0x04000CFF RID: 3327
		private static readonly JTokenType[] dkB5pa4rmA;

		// Token: 0x04000D00 RID: 3328
		private static readonly JTokenType[] LV55MTcBse;

		// Token: 0x04000D01 RID: 3329
		private static readonly JTokenType[] FcH5O67AmP;

		// Token: 0x04000D02 RID: 3330
		private static readonly JTokenType[] lxi5vN6hNi;

		// Token: 0x04000D03 RID: 3331
		private static readonly JTokenType[] sAs5F3L98J;

		// Token: 0x04000D04 RID: 3332
		private static readonly JTokenType[] QT7507e3tN;

		// Token: 0x04000D05 RID: 3333
		private static readonly JTokenType[] XsD5uu3Y06;

		// Token: 0x04000D06 RID: 3334
		private static readonly JTokenType[] keT577d1dS;

		// Token: 0x04000D07 RID: 3335
		private static readonly JTokenType[] fMB515ZcXK;

		// Token: 0x020002D7 RID: 727
		private class m4lCNbNxjK6xWIUX9DZ
		{
			// Token: 0x06001C92 RID: 7314 RVA: 0x0001CE58 File Offset: 0x0001B058
			[MethodImpl(MethodImplOptions.NoInlining)]
			public m4lCNbNxjK6xWIUX9DZ(int \u0020, int \u0020)
			{
			}

			// Token: 0x06001C93 RID: 7315 RVA: 0x0001CE60 File Offset: 0x0001B060
			static m4lCNbNxjK6xWIUX9DZ()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000D08 RID: 3336
			internal readonly int YAMKybLhjl;

			// Token: 0x04000D09 RID: 3337
			internal readonly int cXmKfTgap0;
		}
	}
}
