using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002BC RID: 700
	public class JConstructor : JContainer
	{
		// Token: 0x06001A8F RID: 6799 RVA: 0x00017B20 File Offset: 0x00015D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00017B30 File Offset: 0x00015D30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static Task<JConstructor> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00017B38 File Offset: 0x00015D38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static Task<JConstructor> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00017B48 File Offset: 0x00015D48
		protected override IList<JToken> ChildrenTokens
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00017B50 File Offset: 0x00015D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00017B58 File Offset: 0x00015D58
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x00017B68 File Offset: 0x00015D68
		// (set) Token: 0x06001A96 RID: 6806 RVA: 0x00017B70 File Offset: 0x00015D70
		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x00017B78 File Offset: 0x00015D78
		public override JTokenType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (JTokenType)null;
			}
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00017B84 File Offset: 0x00015D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JConstructor()
		{
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x00017B8C File Offset: 0x00015D8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JConstructor(JConstructor other)
		{
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00017B94 File Offset: 0x00015D94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JConstructor(string name, params object[] content)
		{
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00017B9C File Offset: 0x00015D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JConstructor(string name, object content)
		{
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00017BA4 File Offset: 0x00015DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JConstructor(string name)
		{
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00017BB4 File Offset: 0x00015DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool DeepEquals(JToken node)
		{
			return true;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00017BC4 File Offset: 0x00015DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00017BCC File Offset: 0x00015DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x17000575 RID: 1397
		public override JToken this[object key]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00017BFC File Offset: 0x00015DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00017C04 File Offset: 0x00015E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JConstructor Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00017C0C File Offset: 0x00015E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00017C1C File Offset: 0x00015E1C
		static JConstructor()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000C87 RID: 3207
		private string M9sn4yyjgn;

		// Token: 0x04000C88 RID: 3208
		private readonly List<JToken> n3lnXasxw2;
	}
}
