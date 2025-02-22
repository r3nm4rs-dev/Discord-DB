using System;
using RestSharp.Deserializers;

namespace RestSharp.Serialization.Xml
{
	// Token: 0x020003FB RID: 1019
	public interface IXmlDeserializer : IDeserializer
	{
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060026DC RID: 9948
		// (set) Token: 0x060026DD RID: 9949
		string RootElement { get; set; }

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060026DE RID: 9950
		// (set) Token: 0x060026DF RID: 9951
		string Namespace { get; set; }

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060026E0 RID: 9952
		// (set) Token: 0x060026E1 RID: 9953
		string DateFormat { get; set; }
	}
}
