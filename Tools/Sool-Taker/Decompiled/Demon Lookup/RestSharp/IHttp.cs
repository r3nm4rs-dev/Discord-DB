using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RestSharp
{
	// Token: 0x020003AC RID: 940
	public interface IHttp
	{
		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002344 RID: 9028
		// (set) Token: 0x06002345 RID: 9029
		Action<Stream> ResponseWriter { get; set; }

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002346 RID: 9030
		// (set) Token: 0x06002347 RID: 9031
		Action<Stream, IHttpResponse> AdvancedResponseWriter { get; set; }

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002348 RID: 9032
		// (set) Token: 0x06002349 RID: 9033
		CookieContainer CookieContainer { get; set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600234A RID: 9034
		// (set) Token: 0x0600234B RID: 9035
		ICredentials Credentials { get; set; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600234C RID: 9036
		// (set) Token: 0x0600234D RID: 9037
		bool AutomaticDecompression { get; set; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600234E RID: 9038
		// (set) Token: 0x0600234F RID: 9039
		bool AlwaysMultipartFormData { get; set; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002350 RID: 9040
		// (set) Token: 0x06002351 RID: 9041
		string UserAgent { get; set; }

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002352 RID: 9042
		// (set) Token: 0x06002353 RID: 9043
		int Timeout { get; set; }

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002354 RID: 9044
		// (set) Token: 0x06002355 RID: 9045
		int ReadWriteTimeout { get; set; }

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002356 RID: 9046
		// (set) Token: 0x06002357 RID: 9047
		bool FollowRedirects { get; set; }

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002358 RID: 9048
		// (set) Token: 0x06002359 RID: 9049
		bool Pipelined { get; set; }

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600235A RID: 9050
		// (set) Token: 0x0600235B RID: 9051
		X509CertificateCollection ClientCertificates { get; set; }

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600235C RID: 9052
		// (set) Token: 0x0600235D RID: 9053
		int? MaxRedirects { get; set; }

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600235E RID: 9054
		// (set) Token: 0x0600235F RID: 9055
		bool UseDefaultCredentials { get; set; }

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002360 RID: 9056
		// (set) Token: 0x06002361 RID: 9057
		Encoding Encoding { get; set; }

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002362 RID: 9058
		IList<HttpHeader> Headers { get; }

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06002363 RID: 9059
		IList<HttpParameter> Parameters { get; }

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002364 RID: 9060
		IList<HttpFile> Files { get; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002365 RID: 9061
		IList<HttpCookie> Cookies { get; }

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002366 RID: 9062
		// (set) Token: 0x06002367 RID: 9063
		string RequestBody { get; set; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002368 RID: 9064
		// (set) Token: 0x06002369 RID: 9065
		string RequestContentType { get; set; }

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600236A RID: 9066
		// (set) Token: 0x0600236B RID: 9067
		bool PreAuthenticate { get; set; }

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600236C RID: 9068
		// (set) Token: 0x0600236D RID: 9069
		bool UnsafeAuthenticatedConnectionSharing { get; set; }

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x0600236E RID: 9070
		// (set) Token: 0x0600236F RID: 9071
		RequestCachePolicy CachePolicy { get; set; }

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002370 RID: 9072
		// (set) Token: 0x06002371 RID: 9073
		string ConnectionGroupName { get; set; }

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002372 RID: 9074
		// (set) Token: 0x06002373 RID: 9075
		byte[] RequestBodyBytes { get; set; }

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002374 RID: 9076
		// (set) Token: 0x06002375 RID: 9077
		Uri Url { get; set; }

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002376 RID: 9078
		// (set) Token: 0x06002377 RID: 9079
		string Host { get; set; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002378 RID: 9080
		// (set) Token: 0x06002379 RID: 9081
		IList<DecompressionMethods> AllowedDecompressionMethods { get; set; }

		// Token: 0x0600237A RID: 9082
		HttpWebRequest DeleteAsync(Action<HttpResponse> action);

		// Token: 0x0600237B RID: 9083
		HttpWebRequest GetAsync(Action<HttpResponse> action);

		// Token: 0x0600237C RID: 9084
		HttpWebRequest HeadAsync(Action<HttpResponse> action);

		// Token: 0x0600237D RID: 9085
		HttpWebRequest OptionsAsync(Action<HttpResponse> action);

		// Token: 0x0600237E RID: 9086
		HttpWebRequest PostAsync(Action<HttpResponse> action);

		// Token: 0x0600237F RID: 9087
		HttpWebRequest PutAsync(Action<HttpResponse> action);

		// Token: 0x06002380 RID: 9088
		HttpWebRequest PatchAsync(Action<HttpResponse> action);

		// Token: 0x06002381 RID: 9089
		HttpWebRequest MergeAsync(Action<HttpResponse> action);

		// Token: 0x06002382 RID: 9090
		HttpWebRequest AsPostAsync(Action<HttpResponse> action, string httpMethod);

		// Token: 0x06002383 RID: 9091
		HttpWebRequest AsGetAsync(Action<HttpResponse> action, string httpMethod);

		// Token: 0x06002384 RID: 9092
		HttpResponse Delete();

		// Token: 0x06002385 RID: 9093
		HttpResponse Get();

		// Token: 0x06002386 RID: 9094
		HttpResponse Head();

		// Token: 0x06002387 RID: 9095
		HttpResponse Options();

		// Token: 0x06002388 RID: 9096
		HttpResponse Post();

		// Token: 0x06002389 RID: 9097
		HttpResponse Put();

		// Token: 0x0600238A RID: 9098
		HttpResponse Patch();

		// Token: 0x0600238B RID: 9099
		HttpResponse Merge();

		// Token: 0x0600238C RID: 9100
		HttpResponse AsPost(string httpMethod);

		// Token: 0x0600238D RID: 9101
		HttpResponse AsGet(string httpMethod);

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600238E RID: 9102
		// (set) Token: 0x0600238F RID: 9103
		IWebProxy Proxy { get; set; }

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06002390 RID: 9104
		// (set) Token: 0x06002391 RID: 9105
		RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002392 RID: 9106
		// (set) Token: 0x06002393 RID: 9107
		Action<HttpWebRequest> WebRequestConfigurator { get; set; }
	}
}
