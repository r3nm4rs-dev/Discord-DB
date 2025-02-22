using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002C4 RID: 708
	public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, INotifyPropertyChanged, ICustomTypeDescriptor, INotifyPropertyChanging
	{
		// Token: 0x06001B28 RID: 6952 RVA: 0x000180F4 File Offset: 0x000162F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x00018104 File Offset: 0x00016304
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0001810C File Offset: 0x0001630C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0001811C File Offset: 0x0001631C
		protected override IList<JToken> ChildrenTokens
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06001B2C RID: 6956 RVA: 0x00018124 File Offset: 0x00016324
		// (remove) Token: 0x06001B2D RID: 6957 RVA: 0x00018134 File Offset: 0x00016334
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06001B2E RID: 6958 RVA: 0x00018144 File Offset: 0x00016344
		// (remove) Token: 0x06001B2F RID: 6959 RVA: 0x00018154 File Offset: 0x00016354
		public event PropertyChangingEventHandler PropertyChanging
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00018164 File Offset: 0x00016364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JObject()
		{
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0001816C File Offset: 0x0001636C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JObject(JObject other)
		{
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00018174 File Offset: 0x00016374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JObject(params object[] content)
		{
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0001817C File Offset: 0x0001637C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JObject(object content)
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00018184 File Offset: 0x00016384
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override bool DeepEquals(JToken node)
		{
			return true;
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00018194 File Offset: 0x00016394
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0001819C File Offset: 0x0001639C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000181A4 File Offset: 0x000163A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void ValidateToken(JToken o, JToken existing)
		{
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000181B4 File Offset: 0x000163B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void MergeItem(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000181D4 File Offset: 0x000163D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalPropertyChanged(JProperty childProperty)
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000181E4 File Offset: 0x000163E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalPropertyChanging(JProperty childProperty)
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000181EC File Offset: 0x000163EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override JToken CloneToken()
		{
			return null;
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x000181F4 File Offset: 0x000163F4
		public override JTokenType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (JTokenType)null;
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00018200 File Offset: 0x00016400
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<JProperty> Properties()
		{
			return null;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00018208 File Offset: 0x00016408
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JProperty Property(string name)
		{
			return null;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00018218 File Offset: 0x00016418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JEnumerable<JToken> PropertyValues()
		{
			return null;
		}

		// Token: 0x17000590 RID: 1424
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

		// Token: 0x17000591 RID: 1425
		public JToken this[string propertyName]
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

		// Token: 0x06001B44 RID: 6980 RVA: 0x00018258 File Offset: 0x00016458
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JObject Load(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00018260 File Offset: 0x00016460
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JObject Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00018270 File Offset: 0x00016470
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JObject Parse(string json)
		{
			return null;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00018278 File Offset: 0x00016478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JObject Parse(string json, JsonLoadSettings settings)
		{
			return null;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00018298 File Offset: 0x00016498
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JObject FromObject(object o)
		{
			return null;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x000182A0 File Offset: 0x000164A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public new static JObject FromObject(object o, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000182B0 File Offset: 0x000164B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x000182C0 File Offset: 0x000164C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JToken GetValue(string propertyName)
		{
			return null;
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000182C8 File Offset: 0x000164C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JToken GetValue(string propertyName, StringComparison comparison)
		{
			return null;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x000182E8 File Offset: 0x000164E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue(string propertyName, StringComparison comparison, out JToken value)
		{
			return true;
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x000182F0 File Offset: 0x000164F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(string propertyName, JToken value)
		{
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x000182F8 File Offset: 0x000164F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IDictionary<string, JToken>.ContainsKey(string key)
		{
			return true;
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00018300 File Offset: 0x00016500
		ICollection<string> IDictionary<string, JToken>.Keys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00018308 File Offset: 0x00016508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Remove(string propertyName)
		{
			return true;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00018318 File Offset: 0x00016518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetValue(string propertyName, out JToken value)
		{
			return true;
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00018328 File Offset: 0x00016528
		ICollection<JToken> IDictionary<string, JToken>.Values
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00018330 File Offset: 0x00016530
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<KeyValuePair<string, JToken>>.Add(KeyValuePair<string, JToken> item)
		{
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00018338 File Offset: 0x00016538
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<KeyValuePair<string, JToken>>.Clear()
		{
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00018340 File Offset: 0x00016540
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ICollection<KeyValuePair<string, JToken>>.Contains(KeyValuePair<string, JToken> item)
		{
			return true;
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00018350 File Offset: 0x00016550
		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICollection<KeyValuePair<string, JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex)
		{
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x00018370 File Offset: 0x00016570
		bool ICollection<KeyValuePair<string, JToken>>.IsReadOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00018378 File Offset: 0x00016578
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool ICollection<KeyValuePair<string, JToken>>.Remove(KeyValuePair<string, JToken> item)
		{
			return true;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x00018380 File Offset: 0x00016580
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override int GetDeepHashCode()
		{
			return 0;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00018388 File Offset: 0x00016588
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00018390 File Offset: 0x00016590
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00018398 File Offset: 0x00016598
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnPropertyChanging(string propertyName)
		{
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x000183A0 File Offset: 0x000165A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return null;
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x000183A8 File Offset: 0x000165A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x000183C8 File Offset: 0x000165C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return null;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x000183D0 File Offset: 0x000165D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000183D8 File Offset: 0x000165D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000183E0 File Offset: 0x000165E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000183E8 File Offset: 0x000165E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000183F0 File Offset: 0x000165F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x000183F8 File Offset: 0x000165F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00018400 File Offset: 0x00016600
		[MethodImpl(MethodImplOptions.NoInlining)]
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return null;
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00018408 File Offset: 0x00016608
		[MethodImpl(MethodImplOptions.NoInlining)]
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return null;
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00018410 File Offset: 0x00016610
		[MethodImpl(MethodImplOptions.NoInlining)]
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00018418 File Offset: 0x00016618
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return null;
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00018420 File Offset: 0x00016620
		static JObject()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000CBB RID: 3259
		private readonly JPropertyKeyedCollection a9hnacffAv;

		// Token: 0x04000CBC RID: 3260
		[CompilerGenerated]
		private PropertyChangedEventHandler SEdnniXwNc;

		// Token: 0x04000CBD RID: 3261
		[CompilerGenerated]
		private PropertyChangingEventHandler uvxn58B61D;

		// Token: 0x020002C5 RID: 709
		private class x0GJwpNvUPn7H6G4Lad : DynamicProxy<JObject>
		{
			// Token: 0x06001B6C RID: 7020 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool TryGetMember(JObject instance, GetMemberBinder binder, out object result)
			{
				return true;
			}

			// Token: 0x06001B6D RID: 7021 RVA: 0x0001CBB8 File Offset: 0x0001ADB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value)
			{
				return true;
			}

			// Token: 0x06001B6E RID: 7022 RVA: 0x0001CBC8 File Offset: 0x0001ADC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override IEnumerable<string> GetDynamicMemberNames(JObject \u0020)
			{
				return null;
			}

			// Token: 0x06001B6F RID: 7023 RVA: 0x0001CBD0 File Offset: 0x0001ADD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public x0GJwpNvUPn7H6G4Lad()
			{
			}

			// Token: 0x06001B70 RID: 7024 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
			static x0GJwpNvUPn7H6G4Lad()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x020002C6 RID: 710
			[CompilerGenerated]
			[Serializable]
			private sealed class eeWgsuNJyEmqS5xGFOQ
			{
				// Token: 0x06001B71 RID: 7025 RVA: 0x0001D798 File Offset: 0x0001B998
				[MethodImpl(MethodImplOptions.NoInlining)]
				static eeWgsuNJyEmqS5xGFOQ()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
					nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
					WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
					JObject.x0GJwpNvUPn7H6G4Lad.eeWgsuNJyEmqS5xGFOQ.ewGDx0iLBT = new JObject.x0GJwpNvUPn7H6G4Lad.eeWgsuNJyEmqS5xGFOQ();
				}

				// Token: 0x06001B72 RID: 7026 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
				[MethodImpl(MethodImplOptions.NoInlining)]
				public eeWgsuNJyEmqS5xGFOQ()
				{
				}

				// Token: 0x06001B73 RID: 7027 RVA: 0x0001D7BC File Offset: 0x0001B9BC
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string mKZDteDjfs(JProperty p)
				{
					return null;
				}

				// Token: 0x04000CBE RID: 3262
				public static readonly JObject.x0GJwpNvUPn7H6G4Lad.eeWgsuNJyEmqS5xGFOQ ewGDx0iLBT;

				// Token: 0x04000CBF RID: 3263
				public static Func<JProperty, string> mTTDcnyF9r;
			}
		}

		// Token: 0x020002C9 RID: 713
		[CompilerGenerated]
		[Serializable]
		private sealed class QbEAgqN9qDLM2p9DY4Z
		{
			// Token: 0x06001B7A RID: 7034 RVA: 0x0001CC58 File Offset: 0x0001AE58
			[MethodImpl(MethodImplOptions.NoInlining)]
			static QbEAgqN9qDLM2p9DY4Z()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				JObject.QbEAgqN9qDLM2p9DY4Z.L5MKG2yOVG = new JObject.QbEAgqN9qDLM2p9DY4Z();
			}

			// Token: 0x06001B7B RID: 7035 RVA: 0x0001CC74 File Offset: 0x0001AE74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public QbEAgqN9qDLM2p9DY4Z()
			{
			}

			// Token: 0x06001B7C RID: 7036 RVA: 0x0001CC7C File Offset: 0x0001AE7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal JToken VbXKXrtuXb(JProperty p)
			{
				return null;
			}

			// Token: 0x04000CD0 RID: 3280
			public static readonly JObject.QbEAgqN9qDLM2p9DY4Z L5MKG2yOVG;

			// Token: 0x04000CD1 RID: 3281
			public static Func<JProperty, JToken> fW6KdQZK1y;
		}
	}
}
