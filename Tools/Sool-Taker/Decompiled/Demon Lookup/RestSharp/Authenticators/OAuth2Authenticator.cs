using System;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp.Authenticators
{
	// Token: 0x02000414 RID: 1044
	public abstract class OAuth2Authenticator : IAuthenticator
	{
		// Token: 0x060027A8 RID: 10152 RVA: 0x00021D0C File Offset: 0x0001FF0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected OAuth2Authenticator(string accessToken)
		{
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x00021D14 File Offset: 0x0001FF14
		public string AccessToken
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060027AA RID: 10154
		public abstract void Authenticate(IRestClient client, IRestRequest request);

		// Token: 0x060027AB RID: 10155 RVA: 0x00021D1C File Offset: 0x0001FF1C
		static OAuth2Authenticator()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04001103 RID: 4355
		private readonly string kSSwUNtRC8;
	}
}
