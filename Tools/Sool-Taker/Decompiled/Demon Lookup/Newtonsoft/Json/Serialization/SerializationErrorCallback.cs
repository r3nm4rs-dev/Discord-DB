using System;
using System.Runtime.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200026F RID: 623
	public sealed class SerializationErrorCallback : MulticastDelegate
	{
		// Token: 0x06001710 RID: 5904
		public extern SerializationErrorCallback(object @object, IntPtr method);

		// Token: 0x06001711 RID: 5905
		public extern void Invoke(object o, StreamingContext context, ErrorContext errorContext);

		// Token: 0x06001712 RID: 5906
		public extern IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object @object);

		// Token: 0x06001713 RID: 5907
		public extern void EndInvoke(IAsyncResult result);

		// Token: 0x06001714 RID: 5908 RVA: 0x00015550 File Offset: 0x00013750
		static SerializationErrorCallback()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
