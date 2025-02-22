using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020001F7 RID: 503
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection
	{
		// Token: 0x0600141A RID: 5146 RVA: 0x00013818 File Offset: 0x00011A18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DictionaryWrapper(IDictionary dictionary)
		{
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00013820 File Offset: 0x00011A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00013828 File Offset: 0x00011A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DictionaryWrapper(IReadOnlyDictionary<TKey, TValue> dictionary)
		{
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00013830 File Offset: 0x00011A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00013840 File Offset: 0x00011A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ContainsKey(TKey key)
		{
			return true;
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x00013850 File Offset: 0x00011A50
		public ICollection<TKey> Keys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00013860 File Offset: 0x00011A60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Remove(TKey key)
		{
			return true;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00013870 File Offset: 0x00011A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return true;
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00013880 File Offset: 0x00011A80
		public ICollection<TValue> Values
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045D RID: 1117
		public TValue this[TKey key]
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

		// Token: 0x06001425 RID: 5157 RVA: 0x000138B0 File Offset: 0x00011AB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x000138C0 File Offset: 0x00011AC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000138C8 File Offset: 0x00011AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return true;
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000138D8 File Offset: 0x00011AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x000138F8 File Offset: 0x00011AF8
		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00013908 File Offset: 0x00011B08
		public bool IsReadOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00013910 File Offset: 0x00011B10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return true;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00013920 File Offset: 0x00011B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00013930 File Offset: 0x00011B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00013938 File Offset: 0x00011B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDictionary.Add(object key, object value)
		{
		}

		// Token: 0x17000460 RID: 1120
		object IDictionary.this[object key]
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

		// Token: 0x06001431 RID: 5169 RVA: 0x00013968 File Offset: 0x00011B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00013978 File Offset: 0x00011B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IDictionary.Contains(object key)
		{
			return true;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00013988 File Offset: 0x00011B88
		bool IDictionary.IsFixedSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00013990 File Offset: 0x00011B90
		ICollection IDictionary.Keys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x000139A0 File Offset: 0x00011BA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Remove(object key)
		{
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x000139B0 File Offset: 0x00011BB0
		ICollection IDictionary.Values
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000139C0 File Offset: 0x00011BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection.CopyTo(Array array, int index)
		{
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x000139D0 File Offset: 0x00011BD0
		bool ICollection.IsSynchronized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x000139D8 File Offset: 0x00011BD8
		object ICollection.SyncRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000139E0 File Offset: 0x00011BE0
		public object UnderlyingDictionary
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000139E8 File Offset: 0x00011BE8
		static DictionaryWrapper()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000A10 RID: 2576
		private readonly IDictionary Ujp4fWwVZv;

		// Token: 0x04000A11 RID: 2577
		private readonly IDictionary<TKey, TValue> yww4apRAlP;

		// Token: 0x04000A12 RID: 2578
		private readonly IReadOnlyDictionary<TKey, TValue> jFM4nY3hKu;

		// Token: 0x04000A13 RID: 2579
		private object iPs45tgq2m;

		// Token: 0x020001F8 RID: 504
		private struct zRqE45fTeUudPNGtsq<zOmp6jTSEb9BCB9qby, j1NZ31D8AGJOfn63is> : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x0600143C RID: 5180 RVA: 0x0001BD58 File Offset: 0x00019F58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public zRqE45fTeUudPNGtsq(IEnumerator<KeyValuePair<zOmp6jTSEb9BCB9qby, j1NZ31D8AGJOfn63is>> \u0020)
			{
			}

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x0600143D RID: 5181 RVA: 0x0001BD60 File Offset: 0x00019F60
			public DictionaryEntry Entry
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return (DictionaryEntry)null;
				}
			}

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x0600143E RID: 5182 RVA: 0x0001BD6C File Offset: 0x00019F6C
			public object Key
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
			}

			// Token: 0x17000469 RID: 1129
			// (get) Token: 0x0600143F RID: 5183 RVA: 0x0001BD7C File Offset: 0x00019F7C
			public object Value
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
			}

			// Token: 0x1700046A RID: 1130
			// (get) Token: 0x06001440 RID: 5184 RVA: 0x0001BD8C File Offset: 0x00019F8C
			public object Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
			}

			// Token: 0x06001441 RID: 5185 RVA: 0x0001BD9C File Offset: 0x00019F9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool MoveNext()
			{
				return true;
			}

			// Token: 0x06001442 RID: 5186 RVA: 0x0001BDA4 File Offset: 0x00019FA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
			{
			}

			// Token: 0x06001443 RID: 5187 RVA: 0x0001BDAC File Offset: 0x00019FAC
			static zRqE45fTeUudPNGtsq()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000A14 RID: 2580
			private readonly IEnumerator<KeyValuePair<zOmp6jTSEb9BCB9qby, j1NZ31D8AGJOfn63is>> pM2efKDWMs;
		}

		// Token: 0x020001F9 RID: 505
		[CompilerGenerated]
		[Serializable]
		private sealed class MpjM7NqjBjr3gLkoG7
		{
			// Token: 0x06001444 RID: 5188 RVA: 0x0001BDB4 File Offset: 0x00019FB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			static MpjM7NqjBjr3gLkoG7()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				DictionaryWrapper<lxST1BpBYAPacJeB2f, OJHnA7CI7osStgptYR>.MpjM7NqjBjr3gLkoG7.bpIeno1cGw = new DictionaryWrapper<lxST1BpBYAPacJeB2f, OJHnA7CI7osStgptYR>.MpjM7NqjBjr3gLkoG7();
			}

			// Token: 0x06001445 RID: 5189 RVA: 0x0001BDD0 File Offset: 0x00019FD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public MpjM7NqjBjr3gLkoG7()
			{
			}

			// Token: 0x06001446 RID: 5190 RVA: 0x0001BDD8 File Offset: 0x00019FD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal KeyValuePair<lxST1BpBYAPacJeB2f, OJHnA7CI7osStgptYR> JHBeaJqcIH(DictionaryEntry de)
			{
				return null;
			}

			// Token: 0x04000A15 RID: 2581
			public static readonly DictionaryWrapper<lxST1BpBYAPacJeB2f, OJHnA7CI7osStgptYR>.MpjM7NqjBjr3gLkoG7 bpIeno1cGw;

			// Token: 0x04000A16 RID: 2582
			public static Func<DictionaryEntry, KeyValuePair<lxST1BpBYAPacJeB2f, OJHnA7CI7osStgptYR>> sGue5V3Phn;
		}
	}
}
