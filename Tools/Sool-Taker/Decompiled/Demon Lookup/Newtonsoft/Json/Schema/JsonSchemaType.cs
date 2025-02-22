using System;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020002A7 RID: 679
	[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
	[Flags]
	public enum JsonSchemaType
	{
		// Token: 0x04000C42 RID: 3138
		None = 0,
		// Token: 0x04000C43 RID: 3139
		String = 1,
		// Token: 0x04000C44 RID: 3140
		Float = 2,
		// Token: 0x04000C45 RID: 3141
		Integer = 4,
		// Token: 0x04000C46 RID: 3142
		Boolean = 8,
		// Token: 0x04000C47 RID: 3143
		Object = 16,
		// Token: 0x04000C48 RID: 3144
		Array = 32,
		// Token: 0x04000C49 RID: 3145
		Null = 64,
		// Token: 0x04000C4A RID: 3146
		Any = 127
	}
}
