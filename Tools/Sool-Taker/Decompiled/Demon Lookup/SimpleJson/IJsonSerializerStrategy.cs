using System;
using System.CodeDom.Compiler;

namespace SimpleJson
{
	// Token: 0x02000384 RID: 900
	[GeneratedCode("simple-json", "1.0.0")]
	public interface IJsonSerializerStrategy
	{
		// Token: 0x060021BA RID: 8634
		bool TrySerializeNonPrimitiveObject(object input, out object output);

		// Token: 0x060021BB RID: 8635
		object DeserializeObject(object value, Type type);
	}
}
