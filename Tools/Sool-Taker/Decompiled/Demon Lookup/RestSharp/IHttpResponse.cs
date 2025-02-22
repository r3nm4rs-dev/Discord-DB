using System;
using System.Collections.Generic;
using System.Net;

namespace RestSharp
{
	// Token: 0x020003AD RID: 941
	public interface IHttpResponse
	{
		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002394 RID: 9108
		// (set) Token: 0x06002395 RID: 9109
		string ContentType { get; set; }

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002396 RID: 9110
		// (set) Token: 0x06002397 RID: 9111
		long ContentLength { get; set; }

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002398 RID: 9112
		// (set) Token: 0x06002399 RID: 9113
		string ContentEncoding { get; set; }

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600239A RID: 9114
		string Content { get; }

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600239B RID: 9115
		// (set) Token: 0x0600239C RID: 9116
		HttpStatusCode StatusCode { get; set; }

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x0600239D RID: 9117
		// (set) Token: 0x0600239E RID: 9118
		string StatusDescription { get; set; }

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600239F RID: 9119
		// (set) Token: 0x060023A0 RID: 9120
		byte[] RawBytes { get; set; }

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060023A1 RID: 9121
		// (set) Token: 0x060023A2 RID: 9122
		Uri ResponseUri { get; set; }

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060023A3 RID: 9123
		// (set) Token: 0x060023A4 RID: 9124
		string Server { get; set; }

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060023A5 RID: 9125
		IList<HttpHeader> Headers { get; }

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060023A6 RID: 9126
		IList<HttpCookie> Cookies { get; }

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060023A7 RID: 9127
		// (set) Token: 0x060023A8 RID: 9128
		ResponseStatus ResponseStatus { get; set; }

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060023A9 RID: 9129
		// (set) Token: 0x060023AA RID: 9130
		string ErrorMessage { get; set; }

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060023AB RID: 9131
		// (set) Token: 0x060023AC RID: 9132
		Exception ErrorException { get; set; }

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060023AD RID: 9133
		// (set) Token: 0x060023AE RID: 9134
		Version ProtocolVersion { get; set; }
	}
}
