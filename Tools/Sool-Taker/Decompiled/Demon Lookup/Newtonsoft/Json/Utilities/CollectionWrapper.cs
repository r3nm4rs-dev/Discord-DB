using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020001EB RID: 491
	internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection
	{
		// Token: 0x060013AD RID: 5037 RVA: 0x00012B84 File Offset: 0x00010D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CollectionWrapper(IList list)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00012B94 File Offset: 0x00010D94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CollectionWrapper(ICollection<T> list)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00012B9C File Offset: 0x00010D9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Add(T item)
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00012BA4 File Offset: 0x00010DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Clear()
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00012BAC File Offset: 0x00010DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Contains(T item)
		{
			return true;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00012BB4 File Offset: 0x00010DB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x00012BBC File Offset: 0x00010DBC
		public virtual int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00012BC4 File Offset: 0x00010DC4
		public virtual bool IsReadOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00012BCC File Offset: 0x00010DCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Remove(T item)
		{
			return true;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00012BDC File Offset: 0x00010DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00012BEC File Offset: 0x00010DEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00012BFC File Offset: 0x00010DFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.Add(object value)
		{
			return 0;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00012C04 File Offset: 0x00010E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IList.Contains(object value)
		{
			return true;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00012C0C File Offset: 0x00010E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00012C1C File Offset: 0x00010E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.RemoveAt(int index)
		{
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00012C24 File Offset: 0x00010E24
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Insert(int index, object value)
		{
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00012C2C File Offset: 0x00010E2C
		bool IList.IsFixedSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00012C34 File Offset: 0x00010E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Remove(object value)
		{
		}

		// Token: 0x17000452 RID: 1106
		object IList.this[int index]
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

		// Token: 0x060013C1 RID: 5057 RVA: 0x00012C4C File Offset: 0x00010E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection.CopyTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00012C54 File Offset: 0x00010E54
		bool ICollection.IsSynchronized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00012C5C File Offset: 0x00010E5C
		object ICollection.SyncRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00012C64 File Offset: 0x00010E64
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void aUgbe70sc2(object \u0020)
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00012C6C File Offset: 0x00010E6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool p23bonvQdB(object \u0020)
		{
			return true;
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00012C7C File Offset: 0x00010E7C
		public object UnderlyingCollection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00012C84 File Offset: 0x00010E84
		static CollectionWrapper()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040009AD RID: 2477
		private readonly IList hfxbAMhgfk;

		// Token: 0x040009AE RID: 2478
		private readonly ICollection<T> nBxbErPbbI;

		// Token: 0x040009AF RID: 2479
		private object YOmbKkauVJ;
	}
}
