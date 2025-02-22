using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp
{
	// Token: 0x020003C5 RID: 965
	public static class RestClientExtensions
	{
		// Token: 0x0600252C RID: 9516 RVA: 0x00020800 File Offset: 0x0001EA00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle ExecuteAsync(this IRestClient client, IRestRequest request, Action<IRestResponse> callback)
		{
			return null;
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x00020810 File Offset: 0x0001EA10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle ExecuteAsync<T>(this IRestClient client, IRestRequest request, Action<IRestResponse<T>> callback) where T : new()
		{
			return null;
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00020820 File Offset: 0x0001EA20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle GetAsync<T>(this IRestClient client, IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback) where T : new()
		{
			return null;
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00020828 File Offset: 0x0001EA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle PostAsync<T>(this IRestClient client, IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback) where T : new()
		{
			return null;
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00020830 File Offset: 0x0001EA30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle PutAsync<T>(this IRestClient client, IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback) where T : new()
		{
			return null;
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00020838 File Offset: 0x0001EA38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle HeadAsync<T>(this IRestClient client, IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback) where T : new()
		{
			return null;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00020840 File Offset: 0x0001EA40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle OptionsAsync<T>(this IRestClient client, IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback) where T : new()
		{
			return null;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00020848 File Offset: 0x0001EA48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle PatchAsync<T>(this IRestClient client, IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback) where T : new()
		{
			return null;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00020850 File Offset: 0x0001EA50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle DeleteAsync<T>(this IRestClient client, IRestRequest request, Action<IRestResponse<T>, RestRequestAsyncHandle> callback) where T : new()
		{
			return null;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00020858 File Offset: 0x0001EA58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle GetAsync(this IRestClient client, IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00020860 File Offset: 0x0001EA60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle PostAsync(this IRestClient client, IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00020868 File Offset: 0x0001EA68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle PutAsync(this IRestClient client, IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00020870 File Offset: 0x0001EA70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle HeadAsync(this IRestClient client, IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00020878 File Offset: 0x0001EA78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle OptionsAsync(this IRestClient client, IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00020880 File Offset: 0x0001EA80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle PatchAsync(this IRestClient client, IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00020888 File Offset: 0x0001EA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestRequestAsyncHandle DeleteAsync(this IRestClient client, IRestRequest request, Action<IRestResponse, RestRequestAsyncHandle> callback)
		{
			return null;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00020890 File Offset: 0x0001EA90
		[MethodImpl(MethodImplOptions.NoInlining)]
		[return: Dynamic(new bool[]
		{
			false,
			true
		})]
		public static RestResponse<dynamic> ExecuteDynamic(this IRestClient client, IRestRequest request)
		{
			return null;
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000208A0 File Offset: 0x0001EAA0
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> GetAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000208B0 File Offset: 0x0001EAB0
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> PostAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000208C0 File Offset: 0x0001EAC0
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> PutAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000208D0 File Offset: 0x0001EAD0
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> HeadAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000208E0 File Offset: 0x0001EAE0
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> OptionsAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000208F0 File Offset: 0x0001EAF0
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> PatchAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00020900 File Offset: 0x0001EB00
		[DebuggerStepThrough]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> DeleteAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00020910 File Offset: 0x0001EB10
		[Obsolete("Use GetAsync")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> GetTaskAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00020918 File Offset: 0x0001EB18
		[Obsolete("Use PostAsync")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> PostTaskAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00020920 File Offset: 0x0001EB20
		[Obsolete("Use PutAsync")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> PutTaskAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00020928 File Offset: 0x0001EB28
		[Obsolete("Use HeadAsync")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> HeadTaskAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00020930 File Offset: 0x0001EB30
		[Obsolete("Use OptionsAsync")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> OptionsTaskAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00020938 File Offset: 0x0001EB38
		[Obsolete("Use PatchAsync")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> PatchTaskAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00020940 File Offset: 0x0001EB40
		[Obsolete("Use DeleteAsync")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<T> DeleteTaskAsync<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00020948 File Offset: 0x0001EB48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse<T> Get<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00020950 File Offset: 0x0001EB50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse<T> Post<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00020958 File Offset: 0x0001EB58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse<T> Put<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00020960 File Offset: 0x0001EB60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse<T> Head<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00020968 File Offset: 0x0001EB68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse<T> Options<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00020970 File Offset: 0x0001EB70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse<T> Patch<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00020978 File Offset: 0x0001EB78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse<T> Delete<T>(this IRestClient client, IRestRequest request) where T : new()
		{
			return null;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00020980 File Offset: 0x0001EB80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse Get(this IRestClient client, IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00020988 File Offset: 0x0001EB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse Post(this IRestClient client, IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00020990 File Offset: 0x0001EB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse Put(this IRestClient client, IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00020998 File Offset: 0x0001EB98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse Head(this IRestClient client, IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000209A0 File Offset: 0x0001EBA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse Options(this IRestClient client, IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000209A8 File Offset: 0x0001EBA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse Patch(this IRestClient client, IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000209B0 File Offset: 0x0001EBB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestResponse Delete(this IRestClient client, IRestRequest request)
		{
			return null;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000209B8 File Offset: 0x0001EBB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestClient AddDefaultParameter(this IRestClient restClient, Parameter p)
		{
			return null;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000209C8 File Offset: 0x0001EBC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestClient RemoveDefaultParameter(this IRestClient restClient, string name)
		{
			return null;
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000209D8 File Offset: 0x0001EBD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestClient AddDefaultParameter(this IRestClient restClient, string name, object value)
		{
			return null;
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000209E0 File Offset: 0x0001EBE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestClient AddDefaultParameter(this IRestClient restClient, string name, object value, ParameterType type)
		{
			return null;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000209E8 File Offset: 0x0001EBE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestClient AddDefaultHeader(this IRestClient restClient, string name, string value)
		{
			return null;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000209F0 File Offset: 0x0001EBF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestClient AddDefaultUrlSegment(this IRestClient restClient, string name, string value)
		{
			return null;
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000209F8 File Offset: 0x0001EBF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IRestClient AddDefaultQueryParameter(this IRestClient restClient, string name, string value)
		{
			return null;
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00020A00 File Offset: 0x0001EC00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void DtySRxUBHn(IRestResponse \u0020)
		{
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00020A10 File Offset: 0x0001EC10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestClient UseJson(this RestClient client)
		{
			return null;
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00020A20 File Offset: 0x0001EC20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RestClient UseXml(this RestClient client)
		{
			return null;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00020A30 File Offset: 0x0001EC30
		static RestClientExtensions()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x020003C6 RID: 966
		[CompilerGenerated]
		private sealed class B64NlZhmCUxwbN0dHHv
		{
			// Token: 0x06002564 RID: 9572 RVA: 0x00022C7C File Offset: 0x00020E7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public B64NlZhmCUxwbN0dHHv()
			{
			}

			// Token: 0x06002565 RID: 9573 RVA: 0x00022C84 File Offset: 0x00020E84
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void b2gzQnqCgO(IRestResponse response, RestRequestAsyncHandle handle)
			{
			}

			// Token: 0x06002566 RID: 9574 RVA: 0x00022C8C File Offset: 0x00020E8C
			static B64NlZhmCUxwbN0dHHv()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FFB RID: 4091
			public Action<IRestResponse> ljQz3hTGSS;
		}

		// Token: 0x020003C7 RID: 967
		[CompilerGenerated]
		private sealed class pE3FGFhk2DZvPEOHDE9<sG3KYdhvMXcREFsfAK1> where sG3KYdhvMXcREFsfAK1 : new()
		{
			// Token: 0x06002567 RID: 9575 RVA: 0x00022C94 File Offset: 0x00020E94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public pE3FGFhk2DZvPEOHDE9()
			{
			}

			// Token: 0x06002568 RID: 9576 RVA: 0x00022C9C File Offset: 0x00020E9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void kUezSZGaPt(IRestResponse<sG3KYdhvMXcREFsfAK1> response, RestRequestAsyncHandle asyncHandle)
			{
			}

			// Token: 0x06002569 RID: 9577 RVA: 0x00022CA4 File Offset: 0x00020EA4
			static pE3FGFhk2DZvPEOHDE9()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000FFC RID: 4092
			public Action<IRestResponse<sG3KYdhvMXcREFsfAK1>> vD3zTv3brY;
		}

		// Token: 0x020003CF RID: 975
		[CompilerGenerated]
		[Serializable]
		private sealed class XH2bsdh9HO8Vi15EmhW<SouaglhaF2wRqMZ2sYu> where SouaglhaF2wRqMZ2sYu : new()
		{
			// Token: 0x06002586 RID: 9606 RVA: 0x00022E34 File Offset: 0x00021034
			[MethodImpl(MethodImplOptions.NoInlining)]
			static XH2bsdh9HO8Vi15EmhW()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestClientExtensions.XH2bsdh9HO8Vi15EmhW<SouaglhaF2wRqMZ2sYu>.FjjzwhOQty = new RestClientExtensions.XH2bsdh9HO8Vi15EmhW<SouaglhaF2wRqMZ2sYu>();
			}

			// Token: 0x06002587 RID: 9607 RVA: 0x00022E50 File Offset: 0x00021050
			[MethodImpl(MethodImplOptions.NoInlining)]
			public XH2bsdh9HO8Vi15EmhW()
			{
			}

			// Token: 0x06002588 RID: 9608 RVA: 0x00022E58 File Offset: 0x00021058
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal SouaglhaF2wRqMZ2sYu TU1zRElKHp(Task<IRestResponse<SouaglhaF2wRqMZ2sYu>> x)
			{
				return null;
			}

			// Token: 0x0400102E RID: 4142
			public static readonly RestClientExtensions.XH2bsdh9HO8Vi15EmhW<SouaglhaF2wRqMZ2sYu> FjjzwhOQty;

			// Token: 0x0400102F RID: 4143
			public static Func<Task<IRestResponse<SouaglhaF2wRqMZ2sYu>>, SouaglhaF2wRqMZ2sYu> K5gzBsvUjG;
		}

		// Token: 0x020003D0 RID: 976
		[CompilerGenerated]
		[Serializable]
		private sealed class uyoprThx9VrjUZYPbhj<gvfNhThw9p0VR4enOu8> where gvfNhThw9p0VR4enOu8 : new()
		{
			// Token: 0x06002589 RID: 9609 RVA: 0x00022E60 File Offset: 0x00021060
			[MethodImpl(MethodImplOptions.NoInlining)]
			static uyoprThx9VrjUZYPbhj()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestClientExtensions.uyoprThx9VrjUZYPbhj<gvfNhThw9p0VR4enOu8>.gmwzzRjQdY = new RestClientExtensions.uyoprThx9VrjUZYPbhj<gvfNhThw9p0VR4enOu8>();
			}

			// Token: 0x0600258A RID: 9610 RVA: 0x00022E7C File Offset: 0x0002107C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public uyoprThx9VrjUZYPbhj()
			{
			}

			// Token: 0x0600258B RID: 9611 RVA: 0x00022E84 File Offset: 0x00021084
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal gvfNhThw9p0VR4enOu8 kOYzJSLUaE(Task<IRestResponse<gvfNhThw9p0VR4enOu8>> x)
			{
				return null;
			}

			// Token: 0x04001030 RID: 4144
			public static readonly RestClientExtensions.uyoprThx9VrjUZYPbhj<gvfNhThw9p0VR4enOu8> gmwzzRjQdY;

			// Token: 0x04001031 RID: 4145
			public static Func<Task<IRestResponse<gvfNhThw9p0VR4enOu8>>, gvfNhThw9p0VR4enOu8> MPtxttqYgCQ;
		}

		// Token: 0x020003D1 RID: 977
		[CompilerGenerated]
		[Serializable]
		private sealed class Jwab3sh60bvpZ9nvM3w<JfMHNqhUCGZRNjutxfW> where JfMHNqhUCGZRNjutxfW : new()
		{
			// Token: 0x0600258C RID: 9612 RVA: 0x00022E8C File Offset: 0x0002108C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Jwab3sh60bvpZ9nvM3w()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestClientExtensions.Jwab3sh60bvpZ9nvM3w<JfMHNqhUCGZRNjutxfW>.ft1xtcPZGWu = new RestClientExtensions.Jwab3sh60bvpZ9nvM3w<JfMHNqhUCGZRNjutxfW>();
			}

			// Token: 0x0600258D RID: 9613 RVA: 0x00022EA8 File Offset: 0x000210A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Jwab3sh60bvpZ9nvM3w()
			{
			}

			// Token: 0x0600258E RID: 9614 RVA: 0x00022EB0 File Offset: 0x000210B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal JfMHNqhUCGZRNjutxfW Tb3xtxsYTLG(Task<IRestResponse<JfMHNqhUCGZRNjutxfW>> x)
			{
				return null;
			}

			// Token: 0x04001032 RID: 4146
			public static readonly RestClientExtensions.Jwab3sh60bvpZ9nvM3w<JfMHNqhUCGZRNjutxfW> ft1xtcPZGWu;

			// Token: 0x04001033 RID: 4147
			public static Func<Task<IRestResponse<JfMHNqhUCGZRNjutxfW>>, JfMHNqhUCGZRNjutxfW> jvAxtHFkTUe;
		}

		// Token: 0x020003D2 RID: 978
		[CompilerGenerated]
		[Serializable]
		private sealed class IVjWUxhWPnFjI0SQr73<NmNM7EhE8PDxBaswEBq> where NmNM7EhE8PDxBaswEBq : new()
		{
			// Token: 0x0600258F RID: 9615 RVA: 0x00022EB8 File Offset: 0x000210B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			static IVjWUxhWPnFjI0SQr73()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestClientExtensions.IVjWUxhWPnFjI0SQr73<NmNM7EhE8PDxBaswEBq>.WA4xtPKdlhh = new RestClientExtensions.IVjWUxhWPnFjI0SQr73<NmNM7EhE8PDxBaswEBq>();
			}

			// Token: 0x06002590 RID: 9616 RVA: 0x00022ED4 File Offset: 0x000210D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public IVjWUxhWPnFjI0SQr73()
			{
			}

			// Token: 0x06002591 RID: 9617 RVA: 0x00022EDC File Offset: 0x000210DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal NmNM7EhE8PDxBaswEBq aaGxtYw6kqx(Task<IRestResponse<NmNM7EhE8PDxBaswEBq>> x)
			{
				return null;
			}

			// Token: 0x04001034 RID: 4148
			public static readonly RestClientExtensions.IVjWUxhWPnFjI0SQr73<NmNM7EhE8PDxBaswEBq> WA4xtPKdlhh;

			// Token: 0x04001035 RID: 4149
			public static Func<Task<IRestResponse<NmNM7EhE8PDxBaswEBq>>, NmNM7EhE8PDxBaswEBq> Fakxtrnsyhm;
		}

		// Token: 0x020003D3 RID: 979
		[CompilerGenerated]
		[Serializable]
		private sealed class xiCgbYhfnI3SYgsbYG1<TTpKeOh7f9MKYHM6Iqx> where TTpKeOh7f9MKYHM6Iqx : new()
		{
			// Token: 0x06002592 RID: 9618 RVA: 0x00022EE4 File Offset: 0x000210E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static xiCgbYhfnI3SYgsbYG1()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestClientExtensions.xiCgbYhfnI3SYgsbYG1<TTpKeOh7f9MKYHM6Iqx>.Eg6xtMUOWbi = new RestClientExtensions.xiCgbYhfnI3SYgsbYG1<TTpKeOh7f9MKYHM6Iqx>();
			}

			// Token: 0x06002593 RID: 9619 RVA: 0x00022F00 File Offset: 0x00021100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public xiCgbYhfnI3SYgsbYG1()
			{
			}

			// Token: 0x06002594 RID: 9620 RVA: 0x00022F08 File Offset: 0x00021108
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TTpKeOh7f9MKYHM6Iqx RwsxtpkKM48(Task<IRestResponse<TTpKeOh7f9MKYHM6Iqx>> x)
			{
				return null;
			}

			// Token: 0x04001036 RID: 4150
			public static readonly RestClientExtensions.xiCgbYhfnI3SYgsbYG1<TTpKeOh7f9MKYHM6Iqx> Eg6xtMUOWbi;

			// Token: 0x04001037 RID: 4151
			public static Func<Task<IRestResponse<TTpKeOh7f9MKYHM6Iqx>>, TTpKeOh7f9MKYHM6Iqx> rydxtOZfpA7;
		}

		// Token: 0x020003D4 RID: 980
		[CompilerGenerated]
		[Serializable]
		private sealed class GMapddhJbdpp7JbrLIi<FAFNwUhTtxGHMAy9sHf> where FAFNwUhTtxGHMAy9sHf : new()
		{
			// Token: 0x06002595 RID: 9621 RVA: 0x00022F10 File Offset: 0x00021110
			[MethodImpl(MethodImplOptions.NoInlining)]
			static GMapddhJbdpp7JbrLIi()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestClientExtensions.GMapddhJbdpp7JbrLIi<FAFNwUhTtxGHMAy9sHf>.CE7xtFxm9cM = new RestClientExtensions.GMapddhJbdpp7JbrLIi<FAFNwUhTtxGHMAy9sHf>();
			}

			// Token: 0x06002596 RID: 9622 RVA: 0x00022F2C File Offset: 0x0002112C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public GMapddhJbdpp7JbrLIi()
			{
			}

			// Token: 0x06002597 RID: 9623 RVA: 0x00022F34 File Offset: 0x00021134
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal FAFNwUhTtxGHMAy9sHf J9vxtvEqbit(Task<IRestResponse<FAFNwUhTtxGHMAy9sHf>> x)
			{
				return null;
			}

			// Token: 0x04001038 RID: 4152
			public static readonly RestClientExtensions.GMapddhJbdpp7JbrLIi<FAFNwUhTtxGHMAy9sHf> CE7xtFxm9cM;

			// Token: 0x04001039 RID: 4153
			public static Func<Task<IRestResponse<FAFNwUhTtxGHMAy9sHf>>, FAFNwUhTtxGHMAy9sHf> Wogxt098pUS;
		}

		// Token: 0x020003D5 RID: 981
		[CompilerGenerated]
		[Serializable]
		private sealed class W3Ttr6hDMbt2Cm6GQWT<GVDG2HhqCVwpR3bLx1u> where GVDG2HhqCVwpR3bLx1u : new()
		{
			// Token: 0x06002598 RID: 9624 RVA: 0x00022F3C File Offset: 0x0002113C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static W3Ttr6hDMbt2Cm6GQWT()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestClientExtensions.W3Ttr6hDMbt2Cm6GQWT<GVDG2HhqCVwpR3bLx1u>.Y5ixt7ZEN8c = new RestClientExtensions.W3Ttr6hDMbt2Cm6GQWT<GVDG2HhqCVwpR3bLx1u>();
			}

			// Token: 0x06002599 RID: 9625 RVA: 0x00022F58 File Offset: 0x00021158
			[MethodImpl(MethodImplOptions.NoInlining)]
			public W3Ttr6hDMbt2Cm6GQWT()
			{
			}

			// Token: 0x0600259A RID: 9626 RVA: 0x00022F60 File Offset: 0x00021160
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GVDG2HhqCVwpR3bLx1u l7fxtu3rmVv(Task<IRestResponse<GVDG2HhqCVwpR3bLx1u>> x)
			{
				return null;
			}

			// Token: 0x0400103A RID: 4154
			public static readonly RestClientExtensions.W3Ttr6hDMbt2Cm6GQWT<GVDG2HhqCVwpR3bLx1u> Y5ixt7ZEN8c;

			// Token: 0x0400103B RID: 4155
			public static Func<Task<IRestResponse<GVDG2HhqCVwpR3bLx1u>>, GVDG2HhqCVwpR3bLx1u> Q9Pxt1PaM2a;
		}

		// Token: 0x020003D6 RID: 982
		[CompilerGenerated]
		private sealed class gDrBI7hpjSZgal42v1o
		{
			// Token: 0x0600259B RID: 9627 RVA: 0x00022F68 File Offset: 0x00021168
			[MethodImpl(MethodImplOptions.NoInlining)]
			public gDrBI7hpjSZgal42v1o()
			{
			}

			// Token: 0x0600259C RID: 9628 RVA: 0x00022F70 File Offset: 0x00021170
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool tEQxtidcUHM(Parameter p)
			{
				return true;
			}

			// Token: 0x0600259D RID: 9629 RVA: 0x00022F78 File Offset: 0x00021178
			static gDrBI7hpjSZgal42v1o()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x0400103C RID: 4156
			public string nkoxtUObNs8;
		}
	}
}
