using System;
using System.Runtime.Serialization;

namespace RestSharp.Authenticators.OAuth
{
	// Token: 0x02000421 RID: 1057
	[DataContract]
	public enum OAuthType
	{
		// Token: 0x0400112A RID: 4394
		RequestToken,
		// Token: 0x0400112B RID: 4395
		AccessToken,
		// Token: 0x0400112C RID: 4396
		ProtectedResource,
		// Token: 0x0400112D RID: 4397
		ClientAuthentication
	}
}
