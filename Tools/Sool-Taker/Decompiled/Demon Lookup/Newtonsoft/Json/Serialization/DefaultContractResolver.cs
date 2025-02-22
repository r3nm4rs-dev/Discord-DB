using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000251 RID: 593
	public class DefaultContractResolver : IContractResolver
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x00014DF4 File Offset: 0x00012FF4
		internal static IContractResolver Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00014DFC File Offset: 0x00012FFC
		public bool DynamicCodeGeneration
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00014E04 File Offset: 0x00013004
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x00014E10 File Offset: 0x00013010
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (BindingFlags)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x00014E18 File Offset: 0x00013018
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x00014E20 File Offset: 0x00013020
		public bool SerializeCompilerGeneratedMembers
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

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x00014E28 File Offset: 0x00013028
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x00014E30 File Offset: 0x00013030
		public bool IgnoreSerializableInterface
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

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x00014E38 File Offset: 0x00013038
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x00014E40 File Offset: 0x00013040
		public bool IgnoreSerializableAttribute
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

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x00014E48 File Offset: 0x00013048
		// (set) Token: 0x06001658 RID: 5720 RVA: 0x00014E50 File Offset: 0x00013050
		public NamingStrategy NamingStrategy
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

		// Token: 0x06001659 RID: 5721 RVA: 0x00014E58 File Offset: 0x00013058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DefaultContractResolver()
		{
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00014E60 File Offset: 0x00013060
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00014E80 File Offset: 0x00013080
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00014EAC File Offset: 0x000130AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return true;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00014EBC File Offset: 0x000130BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00014ECC File Offset: 0x000130CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private MemberInfo m6sGNEXUW9(Type \u0020)
		{
			return null;
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00014EDC File Offset: 0x000130DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void DlgGmyCACq(JsonObjectContract \u0020, MemberInfo \u0020)
		{
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00014EEC File Offset: 0x000130EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ConstructorInfo KIiGVPbaPA(Type \u0020)
		{
			return null;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00014EFC File Offset: 0x000130FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ConstructorInfo vkZG9ls0Gj(Type \u0020, JsonPropertyCollection \u0020)
		{
			return null;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00014F0C File Offset: 0x0001310C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ConstructorInfo HOiG2CwTBq(Type \u0020)
		{
			return null;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00014F1C File Offset: 0x0001311C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00014F2C File Offset: 0x0001312C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private JsonProperty TdvGg1TM1N(JsonPropertyCollection \u0020, string \u0020, Type \u0020)
		{
			return null;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00014F3C File Offset: 0x0001313C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00014F4C File Offset: 0x0001314C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00014F54 File Offset: 0x00013154
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Func<object> Rh1GC5yT6Q(Type \u0020)
		{
			return null;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00014F5C File Offset: 0x0001315C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void wcmG6mV6jQ(JsonContract \u0020)
		{
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00014F6C File Offset: 0x0001316C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void NxEGlRDiYC(JsonContract \u0020, Type \u0020)
		{
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00014F7C File Offset: 0x0001317C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AICGqk9s6J(Type \u0020, out List<SerializationCallback> \u0020, out List<SerializationCallback> \u0020, out List<SerializationCallback> \u0020, out List<SerializationCallback> \u0020, out List<SerializationErrorCallback> \u0020)
		{
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00014FA8 File Offset: 0x000131A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool xcEGL13JoE(Type \u0020)
		{
			return true;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00014FB8 File Offset: 0x000131B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool iVoG8sco9x(Type \u0020)
		{
			return true;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00014FC8 File Offset: 0x000131C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool RPHGb8LKOw(Type \u0020)
		{
			return true;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00014FD8 File Offset: 0x000131D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<Type> NZaG4w8Uwe(Type \u0020)
		{
			return null;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00014FE8 File Offset: 0x000131E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00014FF8 File Offset: 0x000131F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00015008 File Offset: 0x00013208
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00015018 File Offset: 0x00013218
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00015028 File Offset: 0x00013228
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00015038 File Offset: 0x00013238
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00015048 File Offset: 0x00013248
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00015058 File Offset: 0x00013258
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00015068 File Offset: 0x00013268
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsJsonPrimitiveType(Type t)
		{
			return true;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00015078 File Offset: 0x00013278
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsIConvertible(Type t)
		{
			return true;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00015088 File Offset: 0x00013288
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool CanConvertToString(Type type)
		{
			return true;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00015098 File Offset: 0x00013298
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool hwcGXxNeln(MethodInfo \u0020, ParameterInfo[] \u0020, Type \u0020, MethodInfo \u0020, ref Type \u0020)
		{
			return true;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x000150A8 File Offset: 0x000132A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000150B8 File Offset: 0x000132B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000150E4 File Offset: 0x000132E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual PropertyNameTable GetNameTable()
		{
			return null;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000150EC File Offset: 0x000132EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x000150FC File Offset: 0x000132FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0001510C File Offset: 0x0001330C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Dc7GGWbuXP(JsonProperty \u0020, object \u0020, string \u0020, Type \u0020, MemberSerialization \u0020, out bool \u0020)
		{
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0001511C File Offset: 0x0001331C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Predicate<object> aOmGdVM3bU(MemberInfo \u0020)
		{
			return null;
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0001512C File Offset: 0x0001332C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void g5YGjJLs1W(JsonProperty \u0020, MemberInfo \u0020, bool \u0020)
		{
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0001513C File Offset: 0x0001333C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00015144 File Offset: 0x00013344
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string ResolveExtensionDataName(string extensionDataName)
		{
			return null;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0001514C File Offset: 0x0001334C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			return null;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00015154 File Offset: 0x00013354
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetResolvedPropertyName(string propertyName)
		{
			return null;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x0001515C File Offset: 0x0001335C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DefaultContractResolver()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			DefaultContractResolver.yMYGymNkiG = new DefaultContractResolver();
			DefaultContractResolver.mUZGft1Fu1 = new JsonConverter[]
			{
				new EntityKeyMemberConverter(),
				new ExpandoObjectConverter(),
				new XmlNodeConverter(),
				new BinaryConverter(),
				new DataSetConverter(),
				new DataTableConverter(),
				new DiscriminatedUnionConverter(),
				new KeyValuePairConverter(),
				new BsonObjectIdConverter(),
				new RegexConverter()
			};
		}

		// Token: 0x04000AD9 RID: 2777
		private static readonly IContractResolver yMYGymNkiG;

		// Token: 0x04000ADA RID: 2778
		private static readonly JsonConverter[] mUZGft1Fu1;

		// Token: 0x04000ADB RID: 2779
		private readonly object t4wGafBIR9;

		// Token: 0x04000ADC RID: 2780
		private readonly PropertyNameTable lP5GnqBaeu;

		// Token: 0x04000ADD RID: 2781
		private Dictionary<Type, JsonContract> gl7G5mSPsK;

		// Token: 0x04000ADE RID: 2782
		[CompilerGenerated]
		private BindingFlags PpYGWmiyt6;

		// Token: 0x04000ADF RID: 2783
		[CompilerGenerated]
		private bool aVZGsFs8kc;

		// Token: 0x04000AE0 RID: 2784
		[CompilerGenerated]
		private bool iAdGku8PVX;

		// Token: 0x04000AE1 RID: 2785
		[CompilerGenerated]
		private bool o5BGeiGvR5;

		// Token: 0x04000AE2 RID: 2786
		[CompilerGenerated]
		private NamingStrategy M5uGoXa67a;

		// Token: 0x02000252 RID: 594
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			// Token: 0x06001688 RID: 5768 RVA: 0x0001C3EC File Offset: 0x0001A5EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public EnumerableDictionaryWrapper(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			// Token: 0x06001689 RID: 5769 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600168A RID: 5770 RVA: 0x0001C3FC File Offset: 0x0001A5FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600168B RID: 5771 RVA: 0x0001C404 File Offset: 0x0001A604
			static EnumerableDictionaryWrapper()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AE3 RID: 2787
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> ePaAJUWlKR;
		}

		// Token: 0x02000254 RID: 596
		[CompilerGenerated]
		[Serializable]
		private sealed class dCnXyPYjJ1UeWuELIEY
		{
			// Token: 0x06001694 RID: 5780 RVA: 0x0001C40C File Offset: 0x0001A60C
			[MethodImpl(MethodImplOptions.NoInlining)]
			static dCnXyPYjJ1UeWuELIEY()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				DefaultContractResolver.dCnXyPYjJ1UeWuELIEY.H9iEPapCKS = new DefaultContractResolver.dCnXyPYjJ1UeWuELIEY();
			}

			// Token: 0x06001695 RID: 5781 RVA: 0x0001C428 File Offset: 0x0001A628
			[MethodImpl(MethodImplOptions.NoInlining)]
			public dCnXyPYjJ1UeWuELIEY()
			{
			}

			// Token: 0x06001696 RID: 5782 RVA: 0x0001C430 File Offset: 0x0001A630
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool CO6Az7KoKg(MemberInfo m)
			{
				return true;
			}

			// Token: 0x06001697 RID: 5783 RVA: 0x0001C438 File Offset: 0x0001A638
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool Hg5EtCLy2y(MemberInfo m)
			{
				return true;
			}

			// Token: 0x06001698 RID: 5784 RVA: 0x0001C440 File Offset: 0x0001A640
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<MemberInfo> syRExrqZXI(Type baseType)
			{
				return null;
			}

			// Token: 0x06001699 RID: 5785 RVA: 0x0001C448 File Offset: 0x0001A648
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool pZAEc1A4eo(MemberInfo m)
			{
				return true;
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x0001C458 File Offset: 0x0001A658
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool m0wEHPSMZT(ConstructorInfo c)
			{
				return true;
			}

			// Token: 0x0600169B RID: 5787 RVA: 0x0001C460 File Offset: 0x0001A660
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int PJTEYx0G9j(JsonProperty p)
			{
				return 0;
			}

			// Token: 0x04000AE8 RID: 2792
			public static readonly DefaultContractResolver.dCnXyPYjJ1UeWuELIEY H9iEPapCKS;

			// Token: 0x04000AE9 RID: 2793
			public static Func<MemberInfo, bool> qHUErqHmyP;

			// Token: 0x04000AEA RID: 2794
			public static Func<MemberInfo, bool> KitEp7mMJZ;

			// Token: 0x04000AEB RID: 2795
			public static Func<Type, IEnumerable<MemberInfo>> fRTEMW2wCn;

			// Token: 0x04000AEC RID: 2796
			public static Func<MemberInfo, bool> VPWEOOnNys;

			// Token: 0x04000AED RID: 2797
			public static Func<ConstructorInfo, bool> aMTEvJOqw3;

			// Token: 0x04000AEE RID: 2798
			public static Func<JsonProperty, int> AJSEFikmkv;
		}

		// Token: 0x02000255 RID: 597
		[CompilerGenerated]
		private sealed class n9bwT3YZoTr4OCkatyW
		{
			// Token: 0x0600169C RID: 5788 RVA: 0x0001C470 File Offset: 0x0001A670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public n9bwT3YZoTr4OCkatyW()
			{
			}

			// Token: 0x0600169D RID: 5789 RVA: 0x0001C478 File Offset: 0x0001A678
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string p7LE0ZWGI1(string s)
			{
				return null;
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x0001C480 File Offset: 0x0001A680
			static n9bwT3YZoTr4OCkatyW()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AEF RID: 2799
			public NamingStrategy r7DEu6lK1E;
		}

		// Token: 0x02000256 RID: 598
		[CompilerGenerated]
		private sealed class rAQeN2Y4RkqfieutiHn
		{
			// Token: 0x0600169F RID: 5791 RVA: 0x0001C488 File Offset: 0x0001A688
			[MethodImpl(MethodImplOptions.NoInlining)]
			public rAQeN2Y4RkqfieutiHn()
			{
			}

			// Token: 0x060016A0 RID: 5792 RVA: 0x0001C490 File Offset: 0x0001A690
			static rAQeN2Y4RkqfieutiHn()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AF0 RID: 2800
			public Func<object, object> oGuE7NqTKg;

			// Token: 0x04000AF1 RID: 2801
			public MemberInfo S99E1aZeb5;
		}

		// Token: 0x02000257 RID: 599
		[CompilerGenerated]
		private sealed class MLJwyeYbdZnp5tUcs2p
		{
			// Token: 0x060016A1 RID: 5793 RVA: 0x0001C498 File Offset: 0x0001A698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public MLJwyeYbdZnp5tUcs2p()
			{
			}

			// Token: 0x060016A2 RID: 5794 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void xoHEif3Cdv(object o, string key, object value)
			{
			}

			// Token: 0x060016A3 RID: 5795 RVA: 0x0001C4B0 File Offset: 0x0001A6B0
			static MLJwyeYbdZnp5tUcs2p()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AF2 RID: 2802
			public Action<object, object> RXTEUfc1sx;

			// Token: 0x04000AF3 RID: 2803
			public Func<object> PZtEI7Wqvd;

			// Token: 0x04000AF4 RID: 2804
			public MethodCall<object, object> IArENlLayB;

			// Token: 0x04000AF5 RID: 2805
			public DefaultContractResolver.rAQeN2Y4RkqfieutiHn j2aEmtkfG9;
		}

		// Token: 0x02000258 RID: 600
		[CompilerGenerated]
		private sealed class b2sxdQY32CICuubJf7x
		{
			// Token: 0x060016A4 RID: 5796 RVA: 0x0001C4B8 File Offset: 0x0001A6B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public b2sxdQY32CICuubJf7x()
			{
			}

			// Token: 0x060016A5 RID: 5797 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<KeyValuePair<object, object>> zHnEVC6qjJ(object o)
			{
				return null;
			}

			// Token: 0x060016A6 RID: 5798 RVA: 0x0001C4D0 File Offset: 0x0001A6D0
			static b2sxdQY32CICuubJf7x()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AF6 RID: 2806
			public ObjectConstructor<object> L5hE9bEItc;

			// Token: 0x04000AF7 RID: 2807
			public DefaultContractResolver.rAQeN2Y4RkqfieutiHn TwTE2UwhbK;
		}

		// Token: 0x02000259 RID: 601
		[CompilerGenerated]
		private sealed class K0ZSxbYgUbdY21mQhRV
		{
			// Token: 0x060016A7 RID: 5799 RVA: 0x0001C4D8 File Offset: 0x0001A6D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public K0ZSxbYgUbdY21mQhRV()
			{
			}

			// Token: 0x060016A8 RID: 5800 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string djWEgR704c(string s)
			{
				return null;
			}

			// Token: 0x060016A9 RID: 5801 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
			static K0ZSxbYgUbdY21mQhRV()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AF8 RID: 2808
			public NamingStrategy T97ECkSR95;
		}

		// Token: 0x0200025A RID: 602
		[CompilerGenerated]
		private sealed class gIewsOYGssIARRcX0FR
		{
			// Token: 0x060016AA RID: 5802 RVA: 0x0001C4F0 File Offset: 0x0001A6F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public gIewsOYGssIARRcX0FR()
			{
			}

			// Token: 0x060016AB RID: 5803 RVA: 0x0001C4F8 File Offset: 0x0001A6F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string FV0E6NALUK(string s)
			{
				return null;
			}

			// Token: 0x060016AC RID: 5804 RVA: 0x0001C500 File Offset: 0x0001A700
			static gIewsOYGssIARRcX0FR()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AF9 RID: 2809
			public NamingStrategy lZ7El0YbEm;
		}

		// Token: 0x0200025B RID: 603
		[CompilerGenerated]
		private sealed class N7OClyYHKPe6P7HsVoR
		{
			// Token: 0x060016AD RID: 5805 RVA: 0x0001C508 File Offset: 0x0001A708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public N7OClyYHKPe6P7HsVoR()
			{
			}

			// Token: 0x060016AE RID: 5806 RVA: 0x0001C510 File Offset: 0x0001A710
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool MwuEqvH8dl(object o)
			{
				return true;
			}

			// Token: 0x060016AF RID: 5807 RVA: 0x0001C518 File Offset: 0x0001A718
			static N7OClyYHKPe6P7HsVoR()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AFA RID: 2810
			public MethodCall<object, object> w9HELsKZM6;
		}

		// Token: 0x0200025C RID: 604
		[CompilerGenerated]
		private sealed class YIambEYz9mDFbMuhqYK
		{
			// Token: 0x060016B0 RID: 5808 RVA: 0x0001C520 File Offset: 0x0001A720
			[MethodImpl(MethodImplOptions.NoInlining)]
			public YIambEYz9mDFbMuhqYK()
			{
			}

			// Token: 0x060016B1 RID: 5809 RVA: 0x0001C528 File Offset: 0x0001A728
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool ev5E8G8SVu(object o)
			{
				return true;
			}

			// Token: 0x060016B2 RID: 5810 RVA: 0x0001C530 File Offset: 0x0001A730
			static YIambEYz9mDFbMuhqYK()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000AFB RID: 2811
			public Func<object, object> fHcEbIZEE2;
		}
	}
}
