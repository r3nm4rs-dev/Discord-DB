using System;

namespace RestSharp
{
	// Token: 0x02000398 RID: 920
	public enum ParameterType
	{
		// Token: 0x04000F20 RID: 3872
		Cookie,
		// Token: 0x04000F21 RID: 3873
		GetOrPost,
		// Token: 0x04000F22 RID: 3874
		UrlSegment,
		// Token: 0x04000F23 RID: 3875
		HttpHeader,
		// Token: 0x04000F24 RID: 3876
		RequestBody,
		// Token: 0x04000F25 RID: 3877
		QueryString,
		// Token: 0x04000F26 RID: 3878
		QueryStringWithoutEncode
	}
}
