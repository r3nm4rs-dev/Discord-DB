using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000268 RID: 616
	public interface ISerializationBinder
	{
		// Token: 0x060016E7 RID: 5863
		Type BindToType(string assemblyName, string typeName);

		// Token: 0x060016E8 RID: 5864
		void BindToName(Type serializedType, out string assemblyName, out string typeName);
	}
}
