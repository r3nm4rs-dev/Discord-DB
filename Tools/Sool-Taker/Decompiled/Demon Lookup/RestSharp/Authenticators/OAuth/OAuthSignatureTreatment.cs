using System;
using System.Runtime.Serialization;

namespace RestSharp.Authenticators.OAuth
{
	// Token: 0x0200041D RID: 1053
	[DataContract]
	public enum OAuthSignatureTreatment
	{
		// Token: 0x0400111C RID: 4380
		Escaped,
		// Token: 0x0400111D RID: 4381
		Unescaped
	}
}
