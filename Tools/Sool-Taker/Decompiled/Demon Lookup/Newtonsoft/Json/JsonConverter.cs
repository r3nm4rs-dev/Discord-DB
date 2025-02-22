using System;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x02000175 RID: 373
	public abstract class JsonConverter
	{
		// Token: 0x06000EF9 RID: 3833
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

		// Token: 0x06000EFA RID: 3834
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		// Token: 0x06000EFB RID: 3835
		public abstract bool CanConvert(Type objectType);

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00010034 File Offset: 0x0000E234
		public virtual bool CanRead
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0001003C File Offset: 0x0000E23C
		public virtual bool CanWrite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00010044 File Offset: 0x0000E244
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected JsonConverter()
		{
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0001004C File Offset: 0x0000E24C
		static JsonConverter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
