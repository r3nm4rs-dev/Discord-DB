using System;
using System.Collections.Generic;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000271 RID: 625
	public sealed class ExtensionDataGetter : MulticastDelegate
	{
		// Token: 0x0600171A RID: 5914
		public extern ExtensionDataGetter(object @object, IntPtr method);

		// Token: 0x0600171B RID: 5915
		public extern IEnumerable<KeyValuePair<object, object>> Invoke(object o);

		// Token: 0x0600171C RID: 5916
		public extern IAsyncResult BeginInvoke(object o, AsyncCallback callback, object @object);

		// Token: 0x0600171D RID: 5917
		public extern IEnumerable<KeyValuePair<object, object>> EndInvoke(IAsyncResult result);

		// Token: 0x0600171E RID: 5918 RVA: 0x00015560 File Offset: 0x00013760
		static ExtensionDataGetter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
