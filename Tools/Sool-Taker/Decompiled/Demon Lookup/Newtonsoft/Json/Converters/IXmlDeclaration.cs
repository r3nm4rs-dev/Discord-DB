using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000319 RID: 793
	internal interface IXmlDeclaration : IXmlNode
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001EC0 RID: 7872
		string Version { get; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001EC1 RID: 7873
		// (set) Token: 0x06001EC2 RID: 7874
		string Encoding { get; set; }

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001EC3 RID: 7875
		// (set) Token: 0x06001EC4 RID: 7876
		string Standalone { get; set; }
	}
}
