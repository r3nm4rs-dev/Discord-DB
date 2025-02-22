using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002B9 RID: 697
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		// Token: 0x06001A65 RID: 6757 RVA: 0x00017994 File Offset: 0x00015B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x000179A4 File Offset: 0x00015BA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static Task<JArray> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x000179AC File Offset: 0x00015BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static Task<JArray> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x000179BC File Offset: 0x00015BBC
		protected override IList<JToken> ChildrenTokens
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x000179C4 File Offset: 0x00015BC4
		public override JTokenType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (JTokenType)null;
			}
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x000179D0 File Offset: 0x00015BD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JArray()
		{
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x000179D8 File Offset: 0x00015BD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JArray(JArray other)
		{
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x000179E0 File Offset: 0x00015BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JArray(params object[] content)
		{
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x000179E8 File Offset: 0x00015BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JArray(object content)
		{
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000179F0 File Offset: 0x00015BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool DeepEquals(JToken node)
		{
			return true;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00017A00 File Offset: 0x00015C00
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00017A08 File Offset: 0x00015C08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JArray Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00017A10 File Offset: 0x00015C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00017A20 File Offset: 0x00015C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JArray Parse(string json)
		{
			return null;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00017A28 File Offset: 0x00015C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JArray Parse(string json, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x00017A48 File Offset: 0x00015C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JArray FromObject(object o)
		{
			return null;
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x00017A50 File Offset: 0x00015C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JArray FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x00017A60 File Offset: 0x00015C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x1700056F RID: 1391
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

		// Token: 0x17000570 RID: 1392
		public JToken this[int index]
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

		// Token: 0x06001A7B RID: 6779 RVA: 0x00017AA0 File Offset: 0x00015CA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00017AA8 File Offset: 0x00015CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00017AB8 File Offset: 0x00015CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int IndexOf(JToken item)
		{
			return 0;
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x00017AC0 File Offset: 0x00015CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Insert(int index, JToken item)
		{
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x00017AC8 File Offset: 0x00015CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00017AD0 File Offset: 0x00015CD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00017AE0 File Offset: 0x00015CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(JToken item)
		{
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00017AE8 File Offset: 0x00015CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00017AF0 File Offset: 0x00015CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(JToken item)
		{
			return true;
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00017AF8 File Offset: 0x00015CF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00017B00 File Offset: 0x00015D00
		public bool IsReadOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00017B08 File Offset: 0x00015D08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Remove(JToken item)
		{
			return true;
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00017B10 File Offset: 0x00015D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00017B18 File Offset: 0x00015D18
		static JArray()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000C76 RID: 3190
		private readonly List<JToken> v0BnbM7pTr;
	}
}
