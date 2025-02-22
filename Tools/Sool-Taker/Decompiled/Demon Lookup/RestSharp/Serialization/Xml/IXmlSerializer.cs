using System;
using RestSharp.Serializers;

namespace RestSharp.Serialization.Xml
{
	// Token: 0x020003FC RID: 1020
	public interface IXmlSerializer : ISerializer, IWithRootElement
	{
		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060026E2 RID: 9954
		// (set) Token: 0x060026E3 RID: 9955
		string Namespace { get; set; }

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060026E4 RID: 9956
		// (set) Token: 0x060026E5 RID: 9957
		string DateFormat { get; set; }
	}
}
