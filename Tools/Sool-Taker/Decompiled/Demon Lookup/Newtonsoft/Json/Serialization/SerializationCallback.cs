using System;
using System.Runtime.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200026E RID: 622
	public sealed class SerializationCallback : MulticastDelegate
	{
		// Token: 0x0600170B RID: 5899
		public extern SerializationCallback(object @object, IntPtr method);

		// Token: 0x0600170C RID: 5900
		public extern void Invoke(object o, StreamingContext context);

		// Token: 0x0600170D RID: 5901
		public extern IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object @object);

		// Token: 0x0600170E RID: 5902
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x0600170F RID: 5903 RVA: 0x00015548 File Offset: 0x00013748
		static SerializationCallback()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
