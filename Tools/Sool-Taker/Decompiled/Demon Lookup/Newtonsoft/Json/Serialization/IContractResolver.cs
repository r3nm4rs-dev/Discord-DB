using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000266 RID: 614
	public interface IContractResolver
	{
		// Token: 0x060016E2 RID: 5858
		JsonContract ResolveContract(Type type);
	}
}
