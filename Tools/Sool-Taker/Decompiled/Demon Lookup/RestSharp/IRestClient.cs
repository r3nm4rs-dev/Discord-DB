using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RestSharp.Serialization;

namespace RestSharp
{
	// Token: 0x020003AE RID: 942
	public interface IRestClient
	{
		// Token: 0x060023AF RID: 9135
		IRestClient UseSerializer(IRestSerializer serializer);

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060023B0 RID: 9136
		// (set) Token: 0x060023B1 RID: 9137
		CookieContainer CookieContainer { get; set; }

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060023B2 RID: 9138
		// (set) Token: 0x060023B3 RID: 9139
		bool AutomaticDecompression { get; set; }

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060023B4 RID: 9140
		// (set) Token: 0x060023B5 RID: 9141
		int? MaxRedirects { get; set; }

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060023B6 RID: 9142
		// (set) Token: 0x060023B7 RID: 9143
		string UserAgent { get; set; }

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060023B8 RID: 9144
		// (set) Token: 0x060023B9 RID: 9145
		int Timeout { get; set; }

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060023BA RID: 9146
		// (set) Token: 0x060023BB RID: 9147
		int ReadWriteTimeout { get; set; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060023BC RID: 9148
		// (set) Token: 0x060023BD RID: 9149
		bool UseSynchronizationContext { get; set; }

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060023BE RID: 9150
		// (set) Token: 0x060023BF RID: 9151
		IAuthenticator Authenticator { get; set; }

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060023C0 RID: 9152
		// (set) Token: 0x060023C1 RID: 9153
		Uri BaseUrl { get; set; }

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060023C2 RID: 9154
		// (set) Token: 0x060023C3 RID: 9155
		Encoding Encoding { get; set; }

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060023C4 RID: 9156
		// (set) Token: 0x060023C5 RID: 9157
		string ConnectionGroupName { get; set; }

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060023C6 RID: 9158
		// (set) Token: 0x060023C7 RID: 9159
		bool PreAuthenticate { get; set; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060023C8 RID: 9160
		// (set) Token: 0x060023C9 RID: 9161
		bool UnsafeAuthenticatedConnectionSharing { get; set; }

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060023CA RID: 9162
		IList<Parameter> DefaultParameters { get; }

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060023CB RID: 9163
		// (set) Token: 0x060023CC RID: 9164
		string BaseHost { get; set; }

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060023CD RID: 9165
		// (set) Token: 0x060023CE RID: 9166
		bool AllowMultipleDefaultParametersWithSameName { get; set; }

		// Token: 0x060023CF RID: 9167
		RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback);

		// Token: 0x060023D0 RID: 9168
		RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback);

		// Token: 0x060023D1 RID: 9169
		RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, Method httpMethod);

		// Token: 0x060023D2 RID: 9170
		RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, Method httpMethod);

		// Token: 0x060023D3 RID: 9171
		IRestResponse<T> Deserialize<T>(IRestResponse response);

		// Token: 0x060023D4 RID: 9172
		IRestResponse Execute(IRestRequest request);

		// Token: 0x060023D5 RID: 9173
		IRestResponse Execute(IRestRequest request, Method httpMethod);

		// Token: 0x060023D6 RID: 9174
		IRestResponse<T> Execute<T>(IRestRequest request) where T : new();

		// Token: 0x060023D7 RID: 9175
		IRestResponse<T> Execute<T>(IRestRequest request, Method httpMethod) where T : new();

		// Token: 0x060023D8 RID: 9176
		byte[] DownloadData(IRestRequest request);

		// Token: 0x060023D9 RID: 9177
		byte[] DownloadData(IRestRequest request, bool throwOnError);

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060023DA RID: 9178
		// (set) Token: 0x060023DB RID: 9179
		X509CertificateCollection ClientCertificates { get; set; }

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060023DC RID: 9180
		// (set) Token: 0x060023DD RID: 9181
		IWebProxy Proxy { get; set; }

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060023DE RID: 9182
		// (set) Token: 0x060023DF RID: 9183
		RequestCachePolicy CachePolicy { get; set; }

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060023E0 RID: 9184
		// (set) Token: 0x060023E1 RID: 9185
		bool Pipelined { get; set; }

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060023E2 RID: 9186
		// (set) Token: 0x060023E3 RID: 9187
		bool FollowRedirects { get; set; }

		// Token: 0x060023E4 RID: 9188
		Uri BuildUri(IRestRequest request);

		// Token: 0x060023E5 RID: 9189
		string BuildUriWithoutQueryParameters(IRestRequest request);

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060023E6 RID: 9190
		// (set) Token: 0x060023E7 RID: 9191
		RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get; set; }

		// Token: 0x060023E8 RID: 9192
		RestRequestAsyncHandle ExecuteAsyncGet(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod);

		// Token: 0x060023E9 RID: 9193
		RestRequestAsyncHandle ExecuteAsyncPost(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod);

		// Token: 0x060023EA RID: 9194
		RestRequestAsyncHandle ExecuteAsyncGet<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod);

		// Token: 0x060023EB RID: 9195
		RestRequestAsyncHandle ExecuteAsyncPost<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod);

		// Token: 0x060023EC RID: 9196
		void ConfigureWebRequest(Action<HttpWebRequest> configurator);

		// Token: 0x060023ED RID: 9197
		void AddHandler(string contentType, IDeserializer deserializer);

		// Token: 0x060023EE RID: 9198
		void RemoveHandler(string contentType);

		// Token: 0x060023EF RID: 9199
		void ClearHandlers();

		// Token: 0x060023F0 RID: 9200
		IRestResponse ExecuteAsGet(IRestRequest request, string httpMethod);

		// Token: 0x060023F1 RID: 9201
		IRestResponse ExecuteAsPost(IRestRequest request, string httpMethod);

		// Token: 0x060023F2 RID: 9202
		IRestResponse<T> ExecuteAsGet<T>(IRestRequest request, string httpMethod) where T : new();

		// Token: 0x060023F3 RID: 9203
		IRestResponse<T> ExecuteAsPost<T>(IRestRequest request, string httpMethod) where T : new();

		// Token: 0x060023F4 RID: 9204
		Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request, CancellationToken token);

		// Token: 0x060023F5 RID: 9205
		Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request, Method httpMethod);

		// Token: 0x060023F6 RID: 9206
		Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request);

		// Token: 0x060023F7 RID: 9207
		Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request);

		// Token: 0x060023F8 RID: 9208
		Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request, CancellationToken token);

		// Token: 0x060023F9 RID: 9209
		Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request);

		// Token: 0x060023FA RID: 9210
		Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request, CancellationToken token);

		// Token: 0x060023FB RID: 9211
		Task<IRestResponse> ExecuteTaskAsync(IRestRequest request, CancellationToken token);

		// Token: 0x060023FC RID: 9212
		Task<IRestResponse> ExecuteTaskAsync(IRestRequest request, CancellationToken token, Method httpMethod);

		// Token: 0x060023FD RID: 9213
		Task<IRestResponse> ExecuteTaskAsync(IRestRequest request);

		// Token: 0x060023FE RID: 9214
		Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request);

		// Token: 0x060023FF RID: 9215
		Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request, CancellationToken token);

		// Token: 0x06002400 RID: 9216
		Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request);

		// Token: 0x06002401 RID: 9217
		Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request, CancellationToken token);
	}
}
