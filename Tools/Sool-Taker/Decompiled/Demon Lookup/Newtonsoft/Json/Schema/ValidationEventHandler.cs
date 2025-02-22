using System;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020002AC RID: 684
	[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
	public sealed class ValidationEventHandler : MulticastDelegate
	{
		// Token: 0x06001A24 RID: 6692
		public extern ValidationEventHandler(object @object, IntPtr method);

		// Token: 0x06001A25 RID: 6693
		public extern void Invoke(object sender, ValidationEventArgs e);

		// Token: 0x06001A26 RID: 6694
		public extern IAsyncResult BeginInvoke(object sender, ValidationEventArgs e, AsyncCallback callback, object @object);

		// Token: 0x06001A27 RID: 6695
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x06001A28 RID: 6696 RVA: 0x000178BC File Offset: 0x00015ABC
		static ValidationEventHandler()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
