using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000265 RID: 613
	public interface IAttributeProvider
	{
		// Token: 0x060016E0 RID: 5856
		IList<Attribute> GetAttributes(bool inherit);

		// Token: 0x060016E1 RID: 5857
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
