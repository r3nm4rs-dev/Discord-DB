using System;

namespace RestSharp.Deserializers
{
	// Token: 0x020003EE RID: 1006
	public interface IDeserializer
	{
		// Token: 0x0600269B RID: 9883
		T Deserialize<T>(IRestResponse response);
	}
}
