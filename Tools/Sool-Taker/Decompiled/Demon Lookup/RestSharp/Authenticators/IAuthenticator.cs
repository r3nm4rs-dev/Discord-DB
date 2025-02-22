using System;

namespace RestSharp.Authenticators
{
	// Token: 0x0200040E RID: 1038
	public interface IAuthenticator
	{
		// Token: 0x06002763 RID: 10083
		void Authenticate(IRestClient client, IRestRequest request);
	}
}
