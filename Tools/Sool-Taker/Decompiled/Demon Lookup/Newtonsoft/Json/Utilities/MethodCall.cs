using System;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000233 RID: 563
	internal sealed class MethodCall<T, TResult> : MulticastDelegate
	{
		// Token: 0x06001574 RID: 5492
		public extern MethodCall(object @object, IntPtr method);

		// Token: 0x06001575 RID: 5493
		public extern TResult Invoke(T target, params object[] args);

		// Token: 0x06001576 RID: 5494
		public extern IAsyncResult BeginInvoke(T target, object[] args, AsyncCallback callback, object @object);

		// Token: 0x06001577 RID: 5495
		public extern TResult EndInvoke(IAsyncResult result);

		// Token: 0x06001578 RID: 5496 RVA: 0x000145BC File Offset: 0x000127BC
		static MethodCall()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
