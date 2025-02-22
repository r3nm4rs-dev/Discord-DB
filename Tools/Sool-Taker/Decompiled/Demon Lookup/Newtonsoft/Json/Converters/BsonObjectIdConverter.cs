using System;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000301 RID: 769
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectIdConverter : JsonConverter
	{
		// Token: 0x06001E16 RID: 7702 RVA: 0x00019960 File Offset: 0x00017B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00019970 File Offset: 0x00017B70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00019980 File Offset: 0x00017B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanConvert(Type objectType)
		{
			return true;
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00019988 File Offset: 0x00017B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BsonObjectIdConverter()
		{
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00019990 File Offset: 0x00017B90
		static BsonObjectIdConverter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
