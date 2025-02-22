using System;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000318 RID: 792
	internal interface IXmlDocument : IXmlNode
	{
		// Token: 0x06001EB3 RID: 7859
		IXmlNode CreateComment(string text);

		// Token: 0x06001EB4 RID: 7860
		IXmlNode CreateTextNode(string text);

		// Token: 0x06001EB5 RID: 7861
		IXmlNode CreateCDataSection(string data);

		// Token: 0x06001EB6 RID: 7862
		IXmlNode CreateWhitespace(string text);

		// Token: 0x06001EB7 RID: 7863
		IXmlNode CreateSignificantWhitespace(string text);

		// Token: 0x06001EB8 RID: 7864
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		// Token: 0x06001EB9 RID: 7865
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

		// Token: 0x06001EBA RID: 7866
		IXmlNode CreateProcessingInstruction(string target, string data);

		// Token: 0x06001EBB RID: 7867
		IXmlElement CreateElement(string elementName);

		// Token: 0x06001EBC RID: 7868
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		// Token: 0x06001EBD RID: 7869
		IXmlNode CreateAttribute(string name, string value);

		// Token: 0x06001EBE RID: 7870
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001EBF RID: 7871
		IXmlElement DocumentElement { get; }
	}
}
