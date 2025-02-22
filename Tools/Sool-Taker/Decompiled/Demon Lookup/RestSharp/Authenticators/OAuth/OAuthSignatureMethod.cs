using System;
using System.Runtime.Serialization;

namespace RestSharp.Authenticators.OAuth
{
	// Token: 0x0200041C RID: 1052
	[DataContract]
	public enum OAuthSignatureMethod
	{
		// Token: 0x04001117 RID: 4375
		HmacSha1,
		// Token: 0x04001118 RID: 4376
		HmacSha256,
		// Token: 0x04001119 RID: 4377
		PlainText,
		// Token: 0x0400111A RID: 4378
		RsaSha1
	}
}
