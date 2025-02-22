using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002BF RID: 703
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, IList, ICollection, INotifyCollectionChanged
	{
		// Token: 0x06001AAC RID: 6828 RVA: 0x00017C24 File Offset: 0x00015E24
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings options, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00017C34 File Offset: 0x00015E34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task g5rnGl1dRO(JsonReader \u0020, JsonLoadSettings \u0020, CancellationToken \u0020 = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06001AAE RID: 6830 RVA: 0x00017C44 File Offset: 0x00015E44
		// (remove) Token: 0x06001AAF RID: 6831 RVA: 0x00017C4C File Offset: 0x00015E4C
		public event ListChangedEventHandler ListChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06001AB0 RID: 6832 RVA: 0x00017C54 File Offset: 0x00015E54
		// (remove) Token: 0x06001AB1 RID: 6833 RVA: 0x00017C5C File Offset: 0x00015E5C
		public event AddingNewEventHandler AddingNew
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06001AB2 RID: 6834 RVA: 0x00017C64 File Offset: 0x00015E64
		// (remove) Token: 0x06001AB3 RID: 6835 RVA: 0x00017C6C File Offset: 0x00015E6C
		public event NotifyCollectionChangedEventHandler CollectionChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001AB4 RID: 6836
		protected abstract IList<JToken> ChildrenTokens { get; }

		// Token: 0x06001AB5 RID: 6837 RVA: 0x00017C74 File Offset: 0x00015E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JContainer()
		{
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00017C7C File Offset: 0x00015E7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JContainer(JContainer other)
		{
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x00017C9C File Offset: 0x00015E9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void CheckReentrancy()
		{
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00017CA4 File Offset: 0x00015EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual IList<JToken> CreateChildrenCollection()
		{
			return null;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00017CAC File Offset: 0x00015EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x00017CB4 File Offset: 0x00015EB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00017CD4 File Offset: 0x00015ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00017CF4 File Offset: 0x00015EF4
		public override bool HasValues
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00017CFC File Offset: 0x00015EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool ContentsEqual(JContainer container)
		{
			return true;
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00017D0C File Offset: 0x00015F0C
		public override JToken First
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00017D1C File Offset: 0x00015F1C
		public override JToken Last
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00017D2C File Offset: 0x00015F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override JEnumerable<JToken> Children()
		{
			return null;
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00017D34 File Offset: 0x00015F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerable<T> Values<T>()
		{
			return null;
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00017D3C File Offset: 0x00015F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JToken> Descendants()
		{
			return null;
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00017D44 File Offset: 0x00015F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JToken> DescendantsAndSelf()
		{
			return null;
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00017D4C File Offset: 0x00015F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			return null;
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00017D54 File Offset: 0x00015F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool IsMultiContent(object content)
		{
			return true;
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00017D5C File Offset: 0x00015F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			return null;
		}

		// Token: 0x06001AC7 RID: 6855
		internal abstract int IndexOfItem(JToken item);

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00017D6C File Offset: 0x00015F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00017D7C File Offset: 0x00015F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void RemoveItemAt(int index)
		{
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00017D8C File Offset: 0x00015F8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual bool RemoveItem(JToken item)
		{
			return true;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00017D9C File Offset: 0x00015F9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00017DA4 File Offset: 0x00015FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void SetItem(int index, JToken item)
		{
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00017DB4 File Offset: 0x00015FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void ClearItems()
		{
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00017DD4 File Offset: 0x00015FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00017DE4 File Offset: 0x00015FE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual bool ContainsItem(JToken item)
		{
			return true;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00017DEC File Offset: 0x00015FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00017E0C File Offset: 0x0001600C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return true;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00017E1C File Offset: 0x0001601C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00017E2C File Offset: 0x0001602C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Add(object content)
		{
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00017E34 File Offset: 0x00016034
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00017E3C File Offset: 0x0001603C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddFirst(object content)
		{
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00017E44 File Offset: 0x00016044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void AddInternal(int index, object content, bool skipParentCheck)
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00017E64 File Offset: 0x00016064
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JToken CreateFromContent(object content)
		{
			return null;
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00017E74 File Offset: 0x00016074
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonWriter CreateWriter()
		{
			return null;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00017E7C File Offset: 0x0001607C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReplaceAll(object content)
		{
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00017E84 File Offset: 0x00016084
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveAll()
		{
		}

		// Token: 0x06001ADB RID: 6875
		internal abstract void MergeItem(object content, JsonMergeSettings settings);

		// Token: 0x06001ADC RID: 6876 RVA: 0x00017E8C File Offset: 0x0001608C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Merge(object content)
		{
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00017E94 File Offset: 0x00016094
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Merge(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00017E9C File Offset: 0x0001609C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00017EAC File Offset: 0x000160AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00017EBC File Offset: 0x000160BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int ContentsHashCode()
		{
			return 0;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00017EDC File Offset: 0x000160DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00017EE4 File Offset: 0x000160E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00017EEC File Offset: 0x000160EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList<JToken>.IndexOf(JToken item)
		{
			return 0;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00017EF4 File Offset: 0x000160F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList<JToken>.Insert(int index, JToken item)
		{
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00017EFC File Offset: 0x000160FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList<JToken>.RemoveAt(int index)
		{
		}

		// Token: 0x1700057A RID: 1402
		JToken IList<JToken>.this[int index]
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

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00017F14 File Offset: 0x00016114
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<JToken>.Add(JToken item)
		{
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00017F1C File Offset: 0x0001611C
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<JToken>.Clear()
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00017F24 File Offset: 0x00016124
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ICollection<JToken>.Contains(JToken item)
		{
			return true;
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00017F2C File Offset: 0x0001612C
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<JToken>.CopyTo(JToken[] array, int arrayIndex)
		{
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00017F34 File Offset: 0x00016134
		bool ICollection<JToken>.IsReadOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00017F3C File Offset: 0x0001613C
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ICollection<JToken>.Remove(JToken item)
		{
			return true;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00017F44 File Offset: 0x00016144
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JToken flIndZ9mQW(object \u0020)
		{
			return null;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00017F54 File Offset: 0x00016154
		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.Add(object value)
		{
			return 0;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00017F5C File Offset: 0x0001615C
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Clear()
		{
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00017F64 File Offset: 0x00016164
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IList.Contains(object value)
		{
			return true;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00017F6C File Offset: 0x0001616C
		[MethodImpl(MethodImplOptions.NoInlining)]
		int IList.IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00017F74 File Offset: 0x00016174
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Insert(int index, object value)
		{
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00017F7C File Offset: 0x0001617C
		bool IList.IsFixedSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00017F84 File Offset: 0x00016184
		bool IList.IsReadOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00017F8C File Offset: 0x0001618C
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.Remove(object value)
		{
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00017F94 File Offset: 0x00016194
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IList.RemoveAt(int index)
		{
		}

		// Token: 0x1700057E RID: 1406
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

		// Token: 0x06001AFA RID: 6906 RVA: 0x00017FAC File Offset: 0x000161AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection.CopyTo(Array array, int index)
		{
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x00017FB4 File Offset: 0x000161B4
		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x00017FBC File Offset: 0x000161BC
		bool ICollection.IsSynchronized
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x00017FC4 File Offset: 0x000161C4
		object ICollection.SyncRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00017FCC File Offset: 0x000161CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00017FD4 File Offset: 0x000161D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		object IBindingList.AddNew()
		{
			return null;
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x00017FE4 File Offset: 0x000161E4
		bool IBindingList.AllowEdit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x00017FEC File Offset: 0x000161EC
		bool IBindingList.AllowNew
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x00017FF4 File Offset: 0x000161F4
		bool IBindingList.AllowRemove
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00017FFC File Offset: 0x000161FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00018004 File Offset: 0x00016204
		[MethodImpl(MethodImplOptions.NoInlining)]
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			return 0;
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0001800C File Offset: 0x0001620C
		bool IBindingList.IsSorted
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00018014 File Offset: 0x00016214
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0001801C File Offset: 0x0001621C
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBindingList.RemoveSort()
		{
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00018024 File Offset: 0x00016224
		ListSortDirection IBindingList.SortDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ListSortDirection)null;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00018030 File Offset: 0x00016230
		PropertyDescriptor IBindingList.SortProperty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00018038 File Offset: 0x00016238
		bool IBindingList.SupportsChangeNotification
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x00018040 File Offset: 0x00016240
		bool IBindingList.SupportsSearching
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00018048 File Offset: 0x00016248
		bool IBindingList.SupportsSorting
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00018050 File Offset: 0x00016250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings)
		{
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00018094 File Offset: 0x00016294
		static JContainer()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000C99 RID: 3225
		internal ListChangedEventHandler _listChanged;

		// Token: 0x04000C9A RID: 3226
		internal AddingNewEventHandler _addingNew;

		// Token: 0x04000C9B RID: 3227
		internal NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x04000C9C RID: 3228
		private object Ke4njGL5TL;

		// Token: 0x04000C9D RID: 3229
		private bool I8rnyqGJ2f;
	}
}
