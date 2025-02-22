using System;
using System.Collections.Generic;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200031C RID: 796
	internal interface IXmlNode
	{
		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001ECC RID: 7884
		XmlNodeType NodeType { get; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001ECD RID: 7885
		string LocalName { get; }

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001ECE RID: 7886
		List<IXmlNode> ChildNodes { get; }

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001ECF RID: 7887
		List<IXmlNode> Attributes { get; }

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001ED0 RID: 7888
		IXmlNode ParentNode { get; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001ED1 RID: 7889
		// (set) Token: 0x06001ED2 RID: 7890
		string Value { get; set; }

		// Token: 0x06001ED3 RID: 7891
		IXmlNode AppendChild(IXmlNode newChild);

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001ED4 RID: 7892
		string NamespaceUri { get; }

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001ED5 RID: 7893
		object WrappedNode { get; }
	}
}
