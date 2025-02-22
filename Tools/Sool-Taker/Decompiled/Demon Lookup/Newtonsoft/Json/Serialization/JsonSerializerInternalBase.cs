using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200027E RID: 638
	internal abstract class JsonSerializerInternalBase
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x00015D60 File Offset: 0x00013F60
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00015D68 File Offset: 0x00013F68
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00015D70 File Offset: 0x00013F70
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ErrorContext IMsjEiNhAi(object \u0020, object \u0020, string \u0020, Exception \u0020)
		{
			return null;
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00015D80 File Offset: 0x00013F80
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ClearErrorContext()
		{
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00015D88 File Offset: 0x00013F88
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex)
		{
			return true;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00015D98 File Offset: 0x00013F98
		static JsonSerializerInternalBase()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000B88 RID: 2952
		private ErrorContext xrZjKM9Eah;

		// Token: 0x04000B89 RID: 2953
		private BidirectionalDictionary<string, object> fuyjDVcO1G;

		// Token: 0x04000B8A RID: 2954
		internal readonly JsonSerializer Serializer;

		// Token: 0x04000B8B RID: 2955
		internal readonly ITraceWriter TraceWriter;

		// Token: 0x04000B8C RID: 2956
		protected JsonSerializerProxy InternalSerializer;

		// Token: 0x0200027F RID: 639
		private class zmZsLINN09OAk27n30Z : IEqualityComparer<object>
		{
			// Token: 0x060017DC RID: 6108 RVA: 0x0001C568 File Offset: 0x0001A768
			[MethodImpl(MethodImplOptions.NoInlining)]
			bool IEqualityComparer<object>.Equals(object \u0020, object \u0020)
			{
				return true;
			}

			// Token: 0x060017DD RID: 6109 RVA: 0x0001C570 File Offset: 0x0001A770
			[MethodImpl(MethodImplOptions.NoInlining)]
			int IEqualityComparer<object>.GetHashCode(object \u0020)
			{
				return 0;
			}

			// Token: 0x060017DE RID: 6110 RVA: 0x0001C578 File Offset: 0x0001A778
			[MethodImpl(MethodImplOptions.NoInlining)]
			public zmZsLINN09OAk27n30Z()
			{
			}

			// Token: 0x060017DF RID: 6111 RVA: 0x0001C580 File Offset: 0x0001A780
			static zmZsLINN09OAk27n30Z()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}
	}
}
