using System;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020002AA RID: 682
	[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
	public enum UndefinedSchemaIdHandling
	{
		// Token: 0x04000C50 RID: 3152
		None,
		// Token: 0x04000C51 RID: 3153
		UseTypeName,
		// Token: 0x04000C52 RID: 3154
		UseAssemblyQualifiedName
	}
}
