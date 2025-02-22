using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using deslvHZHZ9Tbq0f7fZ;
using HsZcU78F13T1yLWI1V;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RestSharp.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp
{
	// Token: 0x020003B6 RID: 950
	public class RestClient : IRestClient
	{
		// Token: 0x0600247A RID: 9338 RVA: 0x000201C4 File Offset: 0x0001E3C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, Method httpMethod)
		{
			return null;
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x000201D4 File Offset: 0x0001E3D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual RestRequestAsyncHandle ExecuteAsync(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000201DC File Offset: 0x0001E3DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual RestRequestAsyncHandle ExecuteAsyncGet(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod)
		{
			return null;
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x000201E4 File Offset: 0x0001E3E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual RestRequestAsyncHandle ExecuteAsyncPost(IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback, string httpMethod)
		{
			return null;
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000201F4 File Offset: 0x0001E3F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, Method httpMethod)
		{
			return null;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00020204 File Offset: 0x0001E404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual RestRequestAsyncHandle ExecuteAsync<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00020214 File Offset: 0x0001E414
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual RestRequestAsyncHandle ExecuteAsyncGet<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod)
		{
			return null;
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00020224 File Offset: 0x0001E424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual RestRequestAsyncHandle ExecuteAsyncPost<T>(IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback, string httpMethod)
		{
			return null;
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00020234 File Offset: 0x0001E434
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0002023C File Offset: 0x0001E43C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse<T>> ExecuteGetTaskAsync<T>(IRestRequest request, CancellationToken token)
		{
			return null;
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x00020244 File Offset: 0x0001E444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0002024C File Offset: 0x0001E44C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse<T>> ExecutePostTaskAsync<T>(IRestRequest request, CancellationToken token)
		{
			return null;
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00020254 File Offset: 0x0001E454
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request, Method httpMethod)
		{
			return null;
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0002025C File Offset: 0x0001E45C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00020264 File Offset: 0x0001E464
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request, CancellationToken token, Method httpMethod)
		{
			return null;
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00020274 File Offset: 0x0001E474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse<T>> ExecuteTaskAsync<T>(IRestRequest request, CancellationToken token)
		{
			return null;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x00020294 File Offset: 0x0001E494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse> ExecuteTaskAsync(IRestRequest request)
		{
			return null;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0002029C File Offset: 0x0001E49C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request)
		{
			return null;
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x000202A4 File Offset: 0x0001E4A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse> ExecuteGetTaskAsync(IRestRequest request, CancellationToken token)
		{
			return null;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000202AC File Offset: 0x0001E4AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request)
		{
			return null;
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000202B4 File Offset: 0x0001E4B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse> ExecutePostTaskAsync(IRestRequest request, CancellationToken token)
		{
			return null;
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x000202BC File Offset: 0x0001E4BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse> ExecuteTaskAsync(IRestRequest request, CancellationToken token, Method httpMethod)
		{
			return null;
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x000202CC File Offset: 0x0001E4CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task<IRestResponse> ExecuteTaskAsync(IRestRequest request, CancellationToken token)
		{
			return null;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x000202EC File Offset: 0x0001E4EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private RestRequestAsyncHandle YuR3JeHX4G(IRestRequest \u0020, Action<IRestResponse, RestRequestAsyncHandle> \u0020, string \u0020, Func<IHttp, Action<HttpResponse>, string, HttpWebRequest> \u0020)
		{
			return null;
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000202FC File Offset: 0x0001E4FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static HttpWebRequest zcQ3zs3ODv(IHttp \u0020, Action<HttpResponse> \u0020, string \u0020)
		{
			return null;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00020304 File Offset: 0x0001E504
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static HttpWebRequest wjXSt0wZFt(IHttp \u0020, Action<HttpResponse> \u0020, string \u0020)
		{
			return null;
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0002030C File Offset: 0x0001E50C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void NLFSx3cX5g(IRestRequest \u0020, HttpResponse \u0020, RestRequestAsyncHandle \u0020, Action<IRestResponse, RestRequestAsyncHandle> \u0020)
		{
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0002031C File Offset: 0x0001E51C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MQwSc9gpHw<jJ6AtaNVKw02DcYrbVA>(IRestRequest \u0020, Action<IRestResponse<jJ6AtaNVKw02DcYrbVA>, RestRequestAsyncHandle> \u0020, IRestResponse \u0020, RestRequestAsyncHandle \u0020)
		{
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0002033C File Offset: 0x0001E53C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestClient()
		{
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x0002034C File Offset: 0x0001E54C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestClient(Uri baseUrl)
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00020354 File Offset: 0x0001E554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestClient(string baseUrl)
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00020364 File Offset: 0x0001E564
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestClient UseSerializer(IRestSerializer serializer)
		{
			return null;
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00020374 File Offset: 0x0001E574
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IDictionary<string, IDeserializer> Y6OSmuNvp6()
		{
			return null;
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0002037C File Offset: 0x0001E57C
		internal IDictionary<DataFormat, IRestSerializer> Serializers
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00020384 File Offset: 0x0001E584
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IList<string> E3WS9xUm1L()
		{
			return null;
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0002038C File Offset: 0x0001E58C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Action<HttpWebRequest> AWISgdBqWb()
		{
			return null;
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00020394 File Offset: 0x0001E594
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WvfSCm6ZhT(Action<HttpWebRequest> value)
		{
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x0002039C File Offset: 0x0001E59C
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x000203A4 File Offset: 0x0001E5A4
		public bool AutomaticDecompression
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000203AC File Offset: 0x0001E5AC
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x000203B4 File Offset: 0x0001E5B4
		public int? MaxRedirects
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000203BC File Offset: 0x0001E5BC
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x000203C4 File Offset: 0x0001E5C4
		public X509CertificateCollection ClientCertificates
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000203CC File Offset: 0x0001E5CC
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x000203D4 File Offset: 0x0001E5D4
		public IWebProxy Proxy
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x000203DC File Offset: 0x0001E5DC
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x000203E4 File Offset: 0x0001E5E4
		public RequestCachePolicy CachePolicy
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x000203EC File Offset: 0x0001E5EC
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x000203F4 File Offset: 0x0001E5F4
		public bool Pipelined
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x000203FC File Offset: 0x0001E5FC
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x00020404 File Offset: 0x0001E604
		public bool FollowRedirects
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x0002040C File Offset: 0x0001E60C
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x00020414 File Offset: 0x0001E614
		public CookieContainer CookieContainer
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x0002041C File Offset: 0x0001E61C
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x00020424 File Offset: 0x0001E624
		public string UserAgent
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x0002042C File Offset: 0x0001E62C
		// (set) Token: 0x060024B2 RID: 9394 RVA: 0x00020434 File Offset: 0x0001E634
		public int Timeout
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x0002043C File Offset: 0x0001E63C
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x00020444 File Offset: 0x0001E644
		public int ReadWriteTimeout
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x0002044C File Offset: 0x0001E64C
		// (set) Token: 0x060024B6 RID: 9398 RVA: 0x00020454 File Offset: 0x0001E654
		public bool UseSynchronizationContext
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x0002045C File Offset: 0x0001E65C
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x00020464 File Offset: 0x0001E664
		public IAuthenticator Authenticator
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x0002046C File Offset: 0x0001E66C
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x00020474 File Offset: 0x0001E674
		public virtual Uri BaseUrl
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x0002047C File Offset: 0x0001E67C
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x00020484 File Offset: 0x0001E684
		public Encoding Encoding
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x0002048C File Offset: 0x0001E68C
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x00020494 File Offset: 0x0001E694
		public bool PreAuthenticate
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x0002049C File Offset: 0x0001E69C
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x000204A4 File Offset: 0x0001E6A4
		public bool UnsafeAuthenticatedConnectionSharing
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000204AC File Offset: 0x0001E6AC
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x000204B4 File Offset: 0x0001E6B4
		public string ConnectionGroupName
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000204BC File Offset: 0x0001E6BC
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x000204C4 File Offset: 0x0001E6C4
		public RemoteCertificateValidationCallback RemoteCertificateValidationCallback
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060024C5 RID: 9413 RVA: 0x000204CC File Offset: 0x0001E6CC
		public IList<Parameter> DefaultParameters
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000204D4 File Offset: 0x0001E6D4
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x000204DC File Offset: 0x0001E6DC
		public string BaseHost
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000204E4 File Offset: 0x0001E6E4
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x000204EC File Offset: 0x0001E6EC
		public bool AllowMultipleDefaultParametersWithSameName
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x000204F4 File Offset: 0x0001E6F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddHandler(string contentType, IDeserializer deserializer)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00020504 File Offset: 0x0001E704
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddHandler(IDeserializer deserializer, params string[] contentTypes)
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00020514 File Offset: 0x0001E714
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveHandler(string contentType)
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0002051C File Offset: 0x0001E71C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearHandlers()
		{
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x00020524 File Offset: 0x0001E724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestResponse<T> Deserialize<T>(IRestResponse response)
		{
			return null;
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0002052C File Offset: 0x0001E72C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConfigureWebRequest(Action<HttpWebRequest> configurator)
		{
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00020534 File Offset: 0x0001E734
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Uri BuildUri(IRestRequest request)
		{
			return null;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00020544 File Offset: 0x0001E744
		[MethodImpl(MethodImplOptions.NoInlining)]
		string IRestClient.BuildUriWithoutQueryParameters(IRestRequest request)
		{
			return null;
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00020554 File Offset: 0x0001E754
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QrOSHv9SES(IRestRequest \u0020)
		{
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00020564 File Offset: 0x0001E764
		[MethodImpl(MethodImplOptions.NoInlining)]
		private RestClient.XVx0r9hScAZ3GgUSln6 PeASY5qvk5(IRestRequest \u0020)
		{
			return null;
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00020584 File Offset: 0x0001E784
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string EWaSP16byt(Uri \u0020, string \u0020)
		{
			return null;
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00020594 File Offset: 0x0001E794
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string vCRSrjdyhR(string \u0020, IRestRequest \u0020)
		{
			return null;
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000205A4 File Offset: 0x0001E7A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<Parameter> j4uSpiMHUD(IRestRequest \u0020)
		{
			return null;
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000205B4 File Offset: 0x0001E7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IEnumerable<Parameter> xgySMlnJHH(IRestRequest \u0020)
		{
			return null;
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000205C4 File Offset: 0x0001E7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IDeserializer FTXSOUYHOt(string \u0020)
		{
			return null;
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000205D4 File Offset: 0x0001E7D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void iQcSvyUfyA(RestClient \u0020, IRestRequest \u0020)
		{
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000205DC File Offset: 0x0001E7DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string OOaSFM5rUh(IEnumerable<Parameter> \u0020, Encoding \u0020)
		{
			return null;
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000205EC File Offset: 0x0001E7EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string jRQS06pTAI(Parameter \u0020, Encoding \u0020)
		{
			return null;
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000205FC File Offset: 0x0001E7FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IHttp ConfigureHttp(IRestRequest request)
		{
			return null;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x0002064C File Offset: 0x0001E84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void KRqSujuh0S(IEnumerable<Parameter> \u0020, IHttp \u0020)
		{
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x0002066C File Offset: 0x0001E86C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static RestResponse vO8S7FHhN5(IRestRequest \u0020, HttpResponse \u0020)
		{
			return null;
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00020698 File Offset: 0x0001E898
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IRestResponse<BMMGEXNIscLlP6RFEyv> FyvS11djXS<BMMGEXNIscLlP6RFEyv>(IRestRequest \u0020, IRestResponse \u0020)
		{
			return null;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000206B8 File Offset: 0x0001E8B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool vnZSi1AghH(string \u0020)
		{
			return true;
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000206C8 File Offset: 0x0001E8C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] DownloadData(IRestRequest request)
		{
			return null;
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000206D0 File Offset: 0x0001E8D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] DownloadData(IRestRequest request, bool throwOnError)
		{
			return null;
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000206E0 File Offset: 0x0001E8E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IRestResponse Execute(IRestRequest request, Method httpMethod)
		{
			return null;
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x000206F0 File Offset: 0x0001E8F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IRestResponse Execute(IRestRequest request)
		{
			return null;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00020700 File Offset: 0x0001E900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestResponse ExecuteAsGet(IRestRequest request, string httpMethod)
		{
			return null;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00020710 File Offset: 0x0001E910
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestResponse ExecuteAsPost(IRestRequest request, string httpMethod)
		{
			return null;
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00020720 File Offset: 0x0001E920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IRestResponse<T> Execute<T>(IRestRequest request, Method httpMethod) where T : new()
		{
			return null;
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00020730 File Offset: 0x0001E930
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IRestResponse<T> Execute<T>(IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00020738 File Offset: 0x0001E938
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestResponse<T> ExecuteAsGet<T>(IRestRequest request, string httpMethod) where T : new()
		{
			return null;
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00020740 File Offset: 0x0001E940
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestResponse<T> ExecuteAsPost<T>(IRestRequest request, string httpMethod) where T : new()
		{
			return null;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00020748 File Offset: 0x0001E948
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IRestResponse yXSSUTgtQT(IRestRequest \u0020, string \u0020, Func<IHttp, string, HttpResponse> \u0020)
		{
			return null;
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00020768 File Offset: 0x0001E968
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static HttpResponse v2JSIEMDqg(IHttp \u0020, string \u0020)
		{
			return null;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00020778 File Offset: 0x0001E978
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static HttpResponse Wk1SNv5Uxn(IHttp \u0020, string \u0020)
		{
			return null;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00020788 File Offset: 0x0001E988
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RestClient()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			RestClient.wLYSluPTIX = new AssemblyName(Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(33555382)).Assembly.FullName).Version;
			RestClient.VmgSqNwBiM = new Regex("\\+\\w+$");
			RestClient.d71SLWW0nj = new Regex("^\\*\\+\\w+$");
			RestClient.NybST2xVWk = new ParameterType[]
			{
				ParameterType.QueryString,
				ParameterType.GetOrPost
			};
		}

		// Token: 0x04000FAE RID: 4014
		private static readonly Version wLYSluPTIX;

		// Token: 0x04000FAF RID: 4015
		private static readonly Regex VmgSqNwBiM;

		// Token: 0x04000FB0 RID: 4016
		private static readonly Regex d71SLWW0nj;

		// Token: 0x04000FB1 RID: 4017
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly IDictionary<string, IDeserializer> quDS8pmUOG;

		// Token: 0x04000FB2 RID: 4018
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly IDictionary<DataFormat, IRestSerializer> hWiSbuSrd4;

		// Token: 0x04000FB3 RID: 4019
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IList<string> SKIS49pLq6;

		// Token: 0x04000FB4 RID: 4020
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<HttpWebRequest> SRiSXIS7kL;

		// Token: 0x04000FB5 RID: 4021
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool mCKSG8vxfA;

		// Token: 0x04000FB6 RID: 4022
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int? IbISdwt2FU;

		// Token: 0x04000FB7 RID: 4023
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private X509CertificateCollection yCFSjTgmga;

		// Token: 0x04000FB8 RID: 4024
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IWebProxy UFvSyah4RH;

		// Token: 0x04000FB9 RID: 4025
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RequestCachePolicy rxySf0wvQL;

		// Token: 0x04000FBA RID: 4026
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool m9wSaVqUDn;

		// Token: 0x04000FBB RID: 4027
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool ifOSnj6vcR;

		// Token: 0x04000FBC RID: 4028
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CookieContainer DZIS5Pg6e2;

		// Token: 0x04000FBD RID: 4029
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string eFDSWJxxf7;

		// Token: 0x04000FBE RID: 4030
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int DliSseHFtS;

		// Token: 0x04000FBF RID: 4031
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int Y1xSkurECW;

		// Token: 0x04000FC0 RID: 4032
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool UPeSevjXtb;

		// Token: 0x04000FC1 RID: 4033
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private IAuthenticator xO2SoP6M9H;

		// Token: 0x04000FC2 RID: 4034
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Uri sNvSAKnfi5;

		// Token: 0x04000FC3 RID: 4035
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Encoding J5SSEsoLOC;

		// Token: 0x04000FC4 RID: 4036
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool VPCSKdM7G9;

		// Token: 0x04000FC5 RID: 4037
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool JIJSDIBPRx;

		// Token: 0x04000FC6 RID: 4038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string UgRSZF0Kxv;

		// Token: 0x04000FC7 RID: 4039
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private RemoteCertificateValidationCallback VdaSheq5kB;

		// Token: 0x04000FC8 RID: 4040
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly IList<Parameter> T1aSQAvvlN;

		// Token: 0x04000FC9 RID: 4041
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string j9cS3H5hp4;

		// Token: 0x04000FCA RID: 4042
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool MG7SSTgQsD;

		// Token: 0x04000FCB RID: 4043
		private static readonly ParameterType[] NybST2xVWk;

		// Token: 0x020003B7 RID: 951
		private class XVx0r9hScAZ3GgUSln6
		{
			// Token: 0x060024EF RID: 9455 RVA: 0x00022A68 File Offset: 0x00020C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public XVx0r9hScAZ3GgUSln6(Uri \u0020, string \u0020)
			{
			}

			// Token: 0x060024F0 RID: 9456 RVA: 0x00022A70 File Offset: 0x00020C70
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Uri PrFJX4gYTD()
			{
				return null;
			}

			// Token: 0x060024F1 RID: 9457 RVA: 0x00022A78 File Offset: 0x00020C78
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public string EaQJdRljAO()
			{
				return null;
			}

			// Token: 0x060024F2 RID: 9458 RVA: 0x00022A80 File Offset: 0x00020C80
			static XVx0r9hScAZ3GgUSln6()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FCC RID: 4044
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private readonly Uri JbtJyIt0Uk;

			// Token: 0x04000FCD RID: 4045
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly string x1kJfhmNVe;
		}

		// Token: 0x020003B8 RID: 952
		[CompilerGenerated]
		private sealed class nME2ssh0hNrYNm780nB<i6T8a6hRmkWZuaq9cwf>
		{
			// Token: 0x060024F3 RID: 9459 RVA: 0x00022A88 File Offset: 0x00020C88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public nME2ssh0hNrYNm780nB()
			{
			}

			// Token: 0x060024F4 RID: 9460 RVA: 0x00022A90 File Offset: 0x00020C90
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void D8TJaR0yZ6(IRestResponse response, RestRequestAsyncHandle asyncHandle)
			{
			}

			// Token: 0x060024F5 RID: 9461 RVA: 0x00022A98 File Offset: 0x00020C98
			static nME2ssh0hNrYNm780nB()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FCE RID: 4046
			public RestClient Y3pJn4yhM6;

			// Token: 0x04000FCF RID: 4047
			public IRestRequest gHvJ5DR1vc;

			// Token: 0x04000FD0 RID: 4048
			public Action<IRestResponse<i6T8a6hRmkWZuaq9cwf>, RestRequestAsyncHandle> qvLJW0ecEK;
		}

		// Token: 0x020003B9 RID: 953
		[CompilerGenerated]
		private sealed class WScTMchyRtMTs0qfTlB<LU0obMhO1X6Wy2AQegH>
		{
			// Token: 0x060024F6 RID: 9462 RVA: 0x00022AA0 File Offset: 0x00020CA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public WScTMchyRtMTs0qfTlB()
			{
			}

			// Token: 0x060024F7 RID: 9463 RVA: 0x00022AA8 File Offset: 0x00020CA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void fnYJs53MlL(IRestResponse response, RestRequestAsyncHandle asyncHandle)
			{
			}

			// Token: 0x060024F8 RID: 9464 RVA: 0x00022AB0 File Offset: 0x00020CB0
			static WScTMchyRtMTs0qfTlB()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FD1 RID: 4049
			public RestClient rfIJkb3pPh;

			// Token: 0x04000FD2 RID: 4050
			public IRestRequest QKhJeUMn4w;

			// Token: 0x04000FD3 RID: 4051
			public Action<IRestResponse<LU0obMhO1X6Wy2AQegH>, RestRequestAsyncHandle> qwSJosldvJ;
		}

		// Token: 0x020003BA RID: 954
		[CompilerGenerated]
		private sealed class ilf8Hph86M4vo2iKukU<VAmKjDhAa8Xe3qNuH5m>
		{
			// Token: 0x060024F9 RID: 9465 RVA: 0x00022AB8 File Offset: 0x00020CB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ilf8Hph86M4vo2iKukU()
			{
			}

			// Token: 0x060024FA RID: 9466 RVA: 0x00022AC0 File Offset: 0x00020CC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void uqlJAOtCh0(IRestResponse response, RestRequestAsyncHandle asyncHandle)
			{
			}

			// Token: 0x060024FB RID: 9467 RVA: 0x00022AC8 File Offset: 0x00020CC8
			static ilf8Hph86M4vo2iKukU()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FD4 RID: 4052
			public RestClient kGkJEJnST7;

			// Token: 0x04000FD5 RID: 4053
			public IRestRequest AjSJKVWwli;

			// Token: 0x04000FD6 RID: 4054
			public Action<IRestResponse<VAmKjDhAa8Xe3qNuH5m>, RestRequestAsyncHandle> JKcJDK7LCX;
		}

		// Token: 0x020003BB RID: 955
		[CompilerGenerated]
		private sealed class HKX1OUhu4Sq4Ic9NrcQ<MNgO7Ahtcivk6hrHMhn>
		{
			// Token: 0x060024FC RID: 9468 RVA: 0x00022AD0 File Offset: 0x00020CD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public HKX1OUhu4Sq4Ic9NrcQ()
			{
			}

			// Token: 0x060024FD RID: 9469 RVA: 0x00022AD8 File Offset: 0x00020CD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void BIJJZdqAlK(IRestResponse<MNgO7Ahtcivk6hrHMhn> response, RestRequestAsyncHandle _)
			{
			}

			// Token: 0x060024FE RID: 9470 RVA: 0x00022AE8 File Offset: 0x00020CE8
			static HKX1OUhu4Sq4Ic9NrcQ()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FD7 RID: 4055
			public CancellationToken J6XJhC4XF9;

			// Token: 0x04000FD8 RID: 4056
			public TaskCompletionSource<IRestResponse<MNgO7Ahtcivk6hrHMhn>> DyCJQ5ehts;
		}

		// Token: 0x020003BC RID: 956
		[CompilerGenerated]
		private sealed class KjgRehhLpfOtw2WK45U<jGmtOlhnIr7VSfkmY1G>
		{
			// Token: 0x060024FF RID: 9471 RVA: 0x00022AF0 File Offset: 0x00020CF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public KjgRehhLpfOtw2WK45U()
			{
			}

			// Token: 0x06002500 RID: 9472 RVA: 0x00022AF8 File Offset: 0x00020CF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void r6TJ3cR5la()
			{
			}

			// Token: 0x06002501 RID: 9473 RVA: 0x00022B00 File Offset: 0x00020D00
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void sYgJSEdC7k(Task<IRestResponse<jGmtOlhnIr7VSfkmY1G>> t)
			{
			}

			// Token: 0x06002502 RID: 9474 RVA: 0x00022B08 File Offset: 0x00020D08
			static KjgRehhLpfOtw2WK45U()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FD9 RID: 4057
			public RestRequestAsyncHandle ulWJThMavo;

			// Token: 0x04000FDA RID: 4058
			public CancellationTokenRegistration BqZJRCZgrZ;

			// Token: 0x04000FDB RID: 4059
			public RestClient.HKX1OUhu4Sq4Ic9NrcQ<jGmtOlhnIr7VSfkmY1G> A94Jwpmw42;
		}

		// Token: 0x020003BD RID: 957
		[CompilerGenerated]
		private sealed class PbRsjZhKDI2XcC54uHl
		{
			// Token: 0x06002503 RID: 9475 RVA: 0x00022B10 File Offset: 0x00020D10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public PbRsjZhKDI2XcC54uHl()
			{
			}

			// Token: 0x06002504 RID: 9476 RVA: 0x00022B18 File Offset: 0x00020D18
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void rh6JBncKVS(IRestResponse response, RestRequestAsyncHandle _)
			{
			}

			// Token: 0x06002505 RID: 9477 RVA: 0x00022B28 File Offset: 0x00020D28
			static PbRsjZhKDI2XcC54uHl()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FDC RID: 4060
			public CancellationToken tljJJpRRaB;

			// Token: 0x04000FDD RID: 4061
			public TaskCompletionSource<IRestResponse> IjXJzARbSb;
		}

		// Token: 0x020003BE RID: 958
		[CompilerGenerated]
		private sealed class RPoOAEhekqJnvXJUWDo
		{
			// Token: 0x06002506 RID: 9478 RVA: 0x00022B30 File Offset: 0x00020D30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public RPoOAEhekqJnvXJUWDo()
			{
			}

			// Token: 0x06002507 RID: 9479 RVA: 0x00022B38 File Offset: 0x00020D38
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void oDtzt6SHUM()
			{
			}

			// Token: 0x06002508 RID: 9480 RVA: 0x00022B40 File Offset: 0x00020D40
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void JnMzxhjUdL(Task<IRestResponse> t)
			{
			}

			// Token: 0x06002509 RID: 9481 RVA: 0x00022B48 File Offset: 0x00020D48
			static RPoOAEhekqJnvXJUWDo()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FDE RID: 4062
			public RestRequestAsyncHandle ExZzceCAWd;

			// Token: 0x04000FDF RID: 4063
			public CancellationTokenRegistration goCzH9GItA;

			// Token: 0x04000FE0 RID: 4064
			public RestClient.PbRsjZhKDI2XcC54uHl GUUzYE4Y8L;
		}

		// Token: 0x020003BF RID: 959
		[CompilerGenerated]
		private sealed class LsCJyWh5QH6eKqbgPdY
		{
			// Token: 0x0600250A RID: 9482 RVA: 0x00022B50 File Offset: 0x00020D50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public LsCJyWh5QH6eKqbgPdY()
			{
			}

			// Token: 0x0600250B RID: 9483 RVA: 0x00022B58 File Offset: 0x00020D58
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void a6hzPnxTtK(HttpResponse r)
			{
			}

			// Token: 0x0600250C RID: 9484 RVA: 0x00022B60 File Offset: 0x00020D60
			static LsCJyWh5QH6eKqbgPdY()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FE1 RID: 4065
			public IRestRequest LutzrMLblP;

			// Token: 0x04000FE2 RID: 4066
			public RestRequestAsyncHandle lT3zpI5RXq;

			// Token: 0x04000FE3 RID: 4067
			public Action<IRestResponse, RestRequestAsyncHandle> DsJzM9UeG6;
		}

		// Token: 0x020003C0 RID: 960
		[CompilerGenerated]
		private sealed class KuHc91hsCGTEHijWGGj
		{
			// Token: 0x0600250D RID: 9485 RVA: 0x00022B68 File Offset: 0x00020D68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public KuHc91hsCGTEHijWGGj()
			{
			}

			// Token: 0x0600250E RID: 9486 RVA: 0x00022B70 File Offset: 0x00020D70
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void tbszO0F8od(HttpResponse resp)
			{
			}

			// Token: 0x0600250F RID: 9487 RVA: 0x00022B80 File Offset: 0x00020D80
			static KuHc91hsCGTEHijWGGj()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FE4 RID: 4068
			public SynchronizationContext zqizv5FS16;

			// Token: 0x04000FE5 RID: 4069
			public Action<HttpResponse> hKhzFTNR91;
		}

		// Token: 0x020003C1 RID: 961
		[CompilerGenerated]
		private sealed class Av1O5YhcuY1OR9YP0do
		{
			// Token: 0x06002510 RID: 9488 RVA: 0x00022B88 File Offset: 0x00020D88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Av1O5YhcuY1OR9YP0do()
			{
			}

			// Token: 0x06002511 RID: 9489 RVA: 0x00022B90 File Offset: 0x00020D90
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void DrTz08j19P(object s)
			{
			}

			// Token: 0x06002512 RID: 9490 RVA: 0x00022B98 File Offset: 0x00020D98
			static Av1O5YhcuY1OR9YP0do()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FE6 RID: 4070
			public HttpResponse FTtzu4nfAY;

			// Token: 0x04000FE7 RID: 4071
			public RestClient.KuHc91hsCGTEHijWGGj dQPz760YoO;
		}

		// Token: 0x020003C2 RID: 962
		[CompilerGenerated]
		[Serializable]
		private sealed class U87KuxhBFyiO3wy29hD
		{
			// Token: 0x06002513 RID: 9491 RVA: 0x00022BA0 File Offset: 0x00020DA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static U87KuxhBFyiO3wy29hD()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestClient.U87KuxhBFyiO3wy29hD.Oh5zbR6EqD = new RestClient.U87KuxhBFyiO3wy29hD();
			}

			// Token: 0x06002514 RID: 9492 RVA: 0x00022BBC File Offset: 0x00020DBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public U87KuxhBFyiO3wy29hD()
			{
			}

			// Token: 0x06002515 RID: 9493 RVA: 0x00022BC4 File Offset: 0x00020DC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool WA5z1kOwm7(Parameter p)
			{
				return true;
			}

			// Token: 0x06002516 RID: 9494 RVA: 0x00022BCC File Offset: 0x00020DCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string hsuzidcpfT(Parameter p)
			{
				return null;
			}

			// Token: 0x06002517 RID: 9495 RVA: 0x00022BD4 File Offset: 0x00020DD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string awjzUso2wR(string name)
			{
				return null;
			}

			// Token: 0x06002518 RID: 9496 RVA: 0x00022BDC File Offset: 0x00020DDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool em1zI650e7(Parameter p)
			{
				return true;
			}

			// Token: 0x06002519 RID: 9497 RVA: 0x00022BE4 File Offset: 0x00020DE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool r65zNjXOkH(Parameter p)
			{
				return true;
			}

			// Token: 0x0600251A RID: 9498 RVA: 0x00022BEC File Offset: 0x00020DEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool bGyzmTSVaf(Parameter p)
			{
				return true;
			}

			// Token: 0x0600251B RID: 9499 RVA: 0x00022BF4 File Offset: 0x00020DF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool cbQzVA3iWQ(Parameter p)
			{
				return true;
			}

			// Token: 0x0600251C RID: 9500 RVA: 0x00022BFC File Offset: 0x00020DFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool uwKz9G38aX(Parameter p)
			{
				return true;
			}

			// Token: 0x0600251D RID: 9501 RVA: 0x00022C04 File Offset: 0x00020E04
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool T62z2gWKGa(Parameter p)
			{
				return true;
			}

			// Token: 0x0600251E RID: 9502 RVA: 0x00022C0C File Offset: 0x00020E0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool LCbzgrlxZt(Parameter p)
			{
				return true;
			}

			// Token: 0x0600251F RID: 9503 RVA: 0x00022C14 File Offset: 0x00020E14
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool JuWzCA1kX1(Parameter p)
			{
				return true;
			}

			// Token: 0x06002520 RID: 9504 RVA: 0x00022C1C File Offset: 0x00020E1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal HttpHeader GZXz6NS2JE(Parameter p)
			{
				return null;
			}

			// Token: 0x06002521 RID: 9505 RVA: 0x00022C24 File Offset: 0x00020E24
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool i8hzlGx4gf(Parameter p)
			{
				return true;
			}

			// Token: 0x06002522 RID: 9506 RVA: 0x00022C2C File Offset: 0x00020E2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal HttpCookie NiOzqeOwcu(Parameter p)
			{
				return null;
			}

			// Token: 0x06002523 RID: 9507 RVA: 0x00022C34 File Offset: 0x00020E34
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool yKHzLYv6yn(Parameter p)
			{
				return true;
			}

			// Token: 0x06002524 RID: 9508 RVA: 0x00022C3C File Offset: 0x00020E3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal HttpParameter vydz8LXukv(Parameter p)
			{
				return null;
			}

			// Token: 0x04000FE8 RID: 4072
			public static readonly RestClient.U87KuxhBFyiO3wy29hD Oh5zbR6EqD;

			// Token: 0x04000FE9 RID: 4073
			public static Func<Parameter, bool> kSaz4ekeWv;

			// Token: 0x04000FEA RID: 4074
			public static Func<Parameter, string> uDSzXomMA9;

			// Token: 0x04000FEB RID: 4075
			public static Func<string, string> dqpzGgAfIb;

			// Token: 0x04000FEC RID: 4076
			public static Func<Parameter, bool> qgszdfQ1kI;

			// Token: 0x04000FED RID: 4077
			public static Func<Parameter, bool> GFxzjvOx9s;

			// Token: 0x04000FEE RID: 4078
			public static Func<Parameter, bool> x4mzyAjfBL;

			// Token: 0x04000FEF RID: 4079
			public static Func<Parameter, bool> smBzfI1yQk;

			// Token: 0x04000FF0 RID: 4080
			public static Func<Parameter, bool> fLOzaiswDh;

			// Token: 0x04000FF1 RID: 4081
			public static Func<Parameter, bool> DlmzniywKF;

			// Token: 0x04000FF2 RID: 4082
			public static Func<Parameter, bool> mJAz5Nf0F3;

			// Token: 0x04000FF3 RID: 4083
			public static Func<Parameter, bool> j0FzWvDYZE;

			// Token: 0x04000FF4 RID: 4084
			public static Func<Parameter, HttpHeader> Jsazsoa6sU;

			// Token: 0x04000FF5 RID: 4085
			public static Func<Parameter, bool> Yq0zkBCp4G;

			// Token: 0x04000FF6 RID: 4086
			public static Func<Parameter, HttpCookie> QNQzeF5CNT;

			// Token: 0x04000FF7 RID: 4087
			public static Func<Parameter, bool> jBSzo6niTo;

			// Token: 0x04000FF8 RID: 4088
			public static Func<Parameter, HttpParameter> eKxzANvwNB;
		}

		// Token: 0x020003C3 RID: 963
		[CompilerGenerated]
		private sealed class KO2uREhQ3r9SgaoBbVZ
		{
			// Token: 0x06002525 RID: 9509 RVA: 0x00022C44 File Offset: 0x00020E44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public KO2uREhQ3r9SgaoBbVZ()
			{
			}

			// Token: 0x06002526 RID: 9510 RVA: 0x00022C4C File Offset: 0x00020E4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string GFxzEfDunP(Parameter parameter)
			{
				return null;
			}

			// Token: 0x06002527 RID: 9511 RVA: 0x00022C54 File Offset: 0x00020E54
			static KO2uREhQ3r9SgaoBbVZ()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FF9 RID: 4089
			public Encoding lnAzKoxfhj;
		}

		// Token: 0x020003C4 RID: 964
		[CompilerGenerated]
		private sealed class V7ZePPhFjfrhjWeaWvj
		{
			// Token: 0x06002528 RID: 9512 RVA: 0x00022C5C File Offset: 0x00020E5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public V7ZePPhFjfrhjWeaWvj()
			{
			}

			// Token: 0x06002529 RID: 9513 RVA: 0x00022C64 File Offset: 0x00020E64
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool evlzDj3vF4(Parameter p)
			{
				return true;
			}

			// Token: 0x0600252A RID: 9514 RVA: 0x00022C6C File Offset: 0x00020E6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool ndCzZbEHwE(ParameterType pt)
			{
				return true;
			}

			// Token: 0x0600252B RID: 9515 RVA: 0x00022C74 File Offset: 0x00020E74
			static V7ZePPhFjfrhjWeaWvj()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FFA RID: 4090
			public Parameter GqHzhUhwGg;
		}
	}
}
