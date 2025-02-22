using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using RestSharp.Serialization.Xml;
using RestSharp.Serializers;

namespace RestSharp
{
	// Token: 0x020003AF RID: 943
	public interface IRestRequest
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002402 RID: 9218
		// (set) Token: 0x06002403 RID: 9219
		bool AlwaysMultipartFormData { get; set; }

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002404 RID: 9220
		// (set) Token: 0x06002405 RID: 9221
		ISerializer JsonSerializer { get; set; }

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002406 RID: 9222
		// (set) Token: 0x06002407 RID: 9223
		IXmlSerializer XmlSerializer { get; set; }

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002408 RID: 9224
		// (set) Token: 0x06002409 RID: 9225
		Action<Stream, IHttpResponse> AdvancedResponseWriter { get; set; }

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600240A RID: 9226
		// (set) Token: 0x0600240B RID: 9227
		Action<Stream> ResponseWriter { get; set; }

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600240C RID: 9228
		List<Parameter> Parameters { get; }

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600240D RID: 9229
		List<FileParameter> Files { get; }

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600240E RID: 9230
		// (set) Token: 0x0600240F RID: 9231
		Method Method { get; set; }

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002410 RID: 9232
		// (set) Token: 0x06002411 RID: 9233
		string Resource { get; set; }

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002412 RID: 9234
		// (set) Token: 0x06002413 RID: 9235
		DataFormat RequestFormat { get; set; }

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002414 RID: 9236
		// (set) Token: 0x06002415 RID: 9237
		string RootElement { get; set; }

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002416 RID: 9238
		// (set) Token: 0x06002417 RID: 9239
		string DateFormat { get; set; }

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002418 RID: 9240
		// (set) Token: 0x06002419 RID: 9241
		string XmlNamespace { get; set; }

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600241A RID: 9242
		// (set) Token: 0x0600241B RID: 9243
		ICredentials Credentials { get; set; }

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600241C RID: 9244
		// (set) Token: 0x0600241D RID: 9245
		int Timeout { get; set; }

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600241E RID: 9246
		// (set) Token: 0x0600241F RID: 9247
		int ReadWriteTimeout { get; set; }

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002420 RID: 9248
		int Attempts { get; }

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002421 RID: 9249
		// (set) Token: 0x06002422 RID: 9250
		bool UseDefaultCredentials { get; set; }

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002423 RID: 9251
		IList<DecompressionMethods> AllowedDecompressionMethods { get; }

		// Token: 0x06002424 RID: 9252
		IRestRequest AddFile(string name, string path, string contentType = null);

		// Token: 0x06002425 RID: 9253
		IRestRequest AddFile(string name, byte[] bytes, string fileName, string contentType = null);

		// Token: 0x06002426 RID: 9254
		IRestRequest AddFile(string name, Action<Stream> writer, string fileName, long contentLength, string contentType = null);

		// Token: 0x06002427 RID: 9255
		IRestRequest AddFileBytes(string name, byte[] bytes, string filename, string contentType = "application/x-gzip");

		// Token: 0x06002428 RID: 9256
		IRestRequest AddBody(object obj, string xmlNamespace);

		// Token: 0x06002429 RID: 9257
		IRestRequest AddBody(object obj);

		// Token: 0x0600242A RID: 9258
		IRestRequest AddJsonBody(object obj);

		// Token: 0x0600242B RID: 9259
		IRestRequest AddXmlBody(object obj);

		// Token: 0x0600242C RID: 9260
		IRestRequest AddXmlBody(object obj, string xmlNamespace);

		// Token: 0x0600242D RID: 9261
		IRestRequest AddObject(object obj, params string[] includedProperties);

		// Token: 0x0600242E RID: 9262
		IRestRequest AddObject(object obj);

		// Token: 0x0600242F RID: 9263
		IRestRequest AddParameter(Parameter p);

		// Token: 0x06002430 RID: 9264
		IRestRequest AddParameter(string name, object value);

		// Token: 0x06002431 RID: 9265
		IRestRequest AddParameter(string name, object value, ParameterType type);

		// Token: 0x06002432 RID: 9266
		IRestRequest AddParameter(string name, object value, string contentType, ParameterType type);

		// Token: 0x06002433 RID: 9267
		IRestRequest AddOrUpdateParameter(Parameter p);

		// Token: 0x06002434 RID: 9268
		IRestRequest AddOrUpdateParameter(string name, object value);

		// Token: 0x06002435 RID: 9269
		IRestRequest AddOrUpdateParameter(string name, object value, ParameterType type);

		// Token: 0x06002436 RID: 9270
		IRestRequest AddOrUpdateParameter(string name, object value, string contentType, ParameterType type);

		// Token: 0x06002437 RID: 9271
		IRestRequest AddHeader(string name, string value);

		// Token: 0x06002438 RID: 9272
		IRestRequest AddCookie(string name, string value);

		// Token: 0x06002439 RID: 9273
		IRestRequest AddUrlSegment(string name, string value);

		// Token: 0x0600243A RID: 9274
		IRestRequest AddQueryParameter(string name, string value);

		// Token: 0x0600243B RID: 9275
		IRestRequest AddQueryParameter(string name, string value, bool encode);

		// Token: 0x0600243C RID: 9276
		IRestRequest AddDecompressionMethod(DecompressionMethods decompressionMethod);

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600243D RID: 9277
		// (set) Token: 0x0600243E RID: 9278
		Action<IRestResponse> OnBeforeDeserialization { get; set; }

		// Token: 0x0600243F RID: 9279
		void IncreaseNumAttempts();
	}
}
