using System;
using System.Runtime.Serialization;

namespace RestSharp.Authenticators.OAuth
{
	// Token: 0x0200041B RID: 1051
	[DataContract]
	public enum OAuthParameterHandling
	{
		// Token: 0x04001114 RID: 4372
		HttpAuthorizationHeader,
		// Token: 0x04001115 RID: 4373
		UrlOrPostParameters
	}
}
