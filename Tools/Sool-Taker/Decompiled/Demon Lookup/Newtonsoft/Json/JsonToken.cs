using System;

namespace Newtonsoft.Json
{
	// Token: 0x020001C9 RID: 457
	public enum JsonToken
	{
		// Token: 0x040008E9 RID: 2281
		None,
		// Token: 0x040008EA RID: 2282
		StartObject,
		// Token: 0x040008EB RID: 2283
		StartArray,
		// Token: 0x040008EC RID: 2284
		StartConstructor,
		// Token: 0x040008ED RID: 2285
		PropertyName,
		// Token: 0x040008EE RID: 2286
		Comment,
		// Token: 0x040008EF RID: 2287
		Raw,
		// Token: 0x040008F0 RID: 2288
		Integer,
		// Token: 0x040008F1 RID: 2289
		Float,
		// Token: 0x040008F2 RID: 2290
		String,
		// Token: 0x040008F3 RID: 2291
		Boolean,
		// Token: 0x040008F4 RID: 2292
		Null,
		// Token: 0x040008F5 RID: 2293
		Undefined,
		// Token: 0x040008F6 RID: 2294
		EndObject,
		// Token: 0x040008F7 RID: 2295
		EndArray,
		// Token: 0x040008F8 RID: 2296
		EndConstructor,
		// Token: 0x040008F9 RID: 2297
		Date,
		// Token: 0x040008FA RID: 2298
		Bytes
	}
}
