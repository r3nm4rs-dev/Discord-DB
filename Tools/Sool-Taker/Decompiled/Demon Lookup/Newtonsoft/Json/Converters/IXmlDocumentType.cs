using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200031A RID: 794
	internal interface IXmlDocumentType : IXmlNode
	{
		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001EC5 RID: 7877
		string Name { get; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001EC6 RID: 7878
		string System { get; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001EC7 RID: 7879
		string Public { get; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001EC8 RID: 7880
		string InternalSubset { get; }
	}
}
