using System;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000302 RID: 770
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		// Token: 0x06001E1B RID: 7707 RVA: 0x00019998 File Offset: 0x00017B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000199A0 File Offset: 0x00017BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06001E1D RID: 7709
		public abstract T Create(Type objectType);

		// Token: 0x06001E1E RID: 7710 RVA: 0x000199B0 File Offset: 0x00017BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanConvert(Type objectType)
		{
			return true;
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000199B8 File Offset: 0x00017BB8
		public override bool CanWrite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x000199C0 File Offset: 0x00017BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected CustomCreationConverter()
		{
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000199C8 File Offset: 0x00017BC8
		static CustomCreationConverter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
