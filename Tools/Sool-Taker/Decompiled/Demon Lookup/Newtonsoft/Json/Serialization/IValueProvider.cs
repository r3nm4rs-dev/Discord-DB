using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200026A RID: 618
	public interface IValueProvider
	{
		// Token: 0x060016EB RID: 5867
		void SetValue(object target, object value);

		// Token: 0x060016EC RID: 5868
		object GetValue(object target);
	}
}
