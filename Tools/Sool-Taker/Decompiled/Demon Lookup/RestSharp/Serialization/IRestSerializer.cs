using System;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace RestSharp.Serialization
{
	// Token: 0x020003F8 RID: 1016
	public interface IRestSerializer : ISerializer, IDeserializer
	{
		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060026D5 RID: 9941
		string[] SupportedContentTypes { get; }

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060026D6 RID: 9942
		DataFormat DataFormat { get; }

		// Token: 0x060026D7 RID: 9943
		string Serialize(Parameter parameter);
	}
}
