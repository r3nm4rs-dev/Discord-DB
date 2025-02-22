using System;

namespace RestSharp
{
	// Token: 0x020003B1 RID: 945
	public interface IRestResponse<T> : IRestResponse
	{
		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600245F RID: 9311
		// (set) Token: 0x06002460 RID: 9312
		T Data { get; set; }
	}
}
