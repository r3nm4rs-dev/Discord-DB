using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using deslvHZHZ9Tbq0f7fZ;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200027B RID: 635
	public class JsonPrimitiveContract : JsonContract
	{
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0001597C File Offset: 0x00013B7C
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x00015988 File Offset: 0x00013B88
		internal PrimitiveTypeCode TypeCode
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PrimitiveTypeCode)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00015990 File Offset: 0x00013B90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonPrimitiveContract(Type underlyingType)
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000159A0 File Offset: 0x00013BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JsonPrimitiveContract()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			if (!nCP5vtxT3QjsSeuiK3.TU7gF13T1(2772))
			{
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				Dictionary<Type, ReadType> dictionary = new Dictionary<Type, ReadType>();
				Type typeFromHandle = typeof(byte[]);
				dictionary[typeFromHandle] = ReadType.ReadAsBytes;
				Type typeFromHandle2 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777324));
				dictionary[typeFromHandle2] = ReadType.ReadAsInt32;
				Type typeFromHandle3 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777540));
				dictionary[typeFromHandle3] = ReadType.ReadAsInt32;
				Type typeFromHandle4 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777219));
				dictionary[typeFromHandle4] = ReadType.ReadAsInt32;
				Type typeFromHandle5 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777545));
				dictionary[typeFromHandle5] = ReadType.ReadAsDecimal;
				Type typeFromHandle6 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777220));
				dictionary[typeFromHandle6] = ReadType.ReadAsBoolean;
				Type typeFromHandle7 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777225));
				dictionary[typeFromHandle7] = ReadType.ReadAsString;
				Type typeFromHandle8 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777536));
				dictionary[typeFromHandle8] = ReadType.ReadAsDateTime;
				Type typeFromHandle9 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777538));
				dictionary[typeFromHandle9] = ReadType.ReadAsDateTimeOffset;
				Type typeFromHandle10 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777313));
				dictionary[typeFromHandle10] = ReadType.ReadAsDouble;
				Type typeFromHandle11 = Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777366));
				dictionary[typeFromHandle11] = ReadType.ReadAsDouble;
				JsonPrimitiveContract.LRTj7TcYO1 = dictionary;
			}
		}

		// Token: 0x04000B63 RID: 2915
		[CompilerGenerated]
		private PrimitiveTypeCode gr6juHVprX;

		// Token: 0x04000B64 RID: 2916
		private static readonly Dictionary<Type, ReadType> LRTj7TcYO1;
	}
}
