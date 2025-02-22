using System;

namespace RestSharp.Serializers
{
	// Token: 0x020003E6 RID: 998
	public interface ISerializer
	{
		// Token: 0x0600265A RID: 9818
		string Serialize(object obj);

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600265B RID: 9819
		// (set) Token: 0x0600265C RID: 9820
		string ContentType { get; set; }
	}
}
