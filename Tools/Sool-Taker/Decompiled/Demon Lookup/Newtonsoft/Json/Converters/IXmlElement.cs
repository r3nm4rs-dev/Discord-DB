using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200031B RID: 795
	internal interface IXmlElement : IXmlNode
	{
		// Token: 0x06001EC9 RID: 7881
		void SetAttributeNode(IXmlNode attribute);

		// Token: 0x06001ECA RID: 7882
		string GetPrefixOfNamespace(string namespaceUri);

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001ECB RID: 7883
		bool IsEmpty { get; }
	}
}
