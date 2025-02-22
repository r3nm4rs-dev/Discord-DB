using System;
using System.Collections.Generic;
using System.Net;

namespace RestSharp
{
	// Token: 0x020003B0 RID: 944
	public interface IRestResponse
	{
		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002440 RID: 9280
		// (set) Token: 0x06002441 RID: 9281
		IRestRequest Request { get; set; }

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002442 RID: 9282
		// (set) Token: 0x06002443 RID: 9283
		string ContentType { get; set; }

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002444 RID: 9284
		// (set) Token: 0x06002445 RID: 9285
		long ContentLength { get; set; }

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002446 RID: 9286
		// (set) Token: 0x06002447 RID: 9287
		string ContentEncoding { get; set; }

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002448 RID: 9288
		// (set) Token: 0x06002449 RID: 9289
		string Content { get; set; }

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600244A RID: 9290
		// (set) Token: 0x0600244B RID: 9291
		HttpStatusCode StatusCode { get; set; }

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600244C RID: 9292
		bool IsSuccessful { get; }

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600244D RID: 9293
		// (set) Token: 0x0600244E RID: 9294
		string StatusDescription { get; set; }

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600244F RID: 9295
		// (set) Token: 0x06002450 RID: 9296
		byte[] RawBytes { get; set; }

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002451 RID: 9297
		// (set) Token: 0x06002452 RID: 9298
		Uri ResponseUri { get; set; }

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002453 RID: 9299
		// (set) Token: 0x06002454 RID: 9300
		string Server { get; set; }

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002455 RID: 9301
		IList<RestResponseCookie> Cookies { get; }

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002456 RID: 9302
		IList<Parameter> Headers { get; }

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002457 RID: 9303
		// (set) Token: 0x06002458 RID: 9304
		ResponseStatus ResponseStatus { get; set; }

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002459 RID: 9305
		// (set) Token: 0x0600245A RID: 9306
		string ErrorMessage { get; set; }

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600245B RID: 9307
		// (set) Token: 0x0600245C RID: 9308
		Exception ErrorException { get; set; }

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600245D RID: 9309
		// (set) Token: 0x0600245E RID: 9310
		Version ProtocolVersion { get; set; }
	}
}
