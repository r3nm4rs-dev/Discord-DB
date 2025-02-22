using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000272 RID: 626
	public abstract class JsonContract
	{
		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00015568 File Offset: 0x00013768
		public Type UnderlyingType
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x00015570 File Offset: 0x00013770
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x00015578 File Offset: 0x00013778
		public Type CreatedType
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x00015588 File Offset: 0x00013788
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x00015590 File Offset: 0x00013790
		public bool? IsReference
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00015598 File Offset: 0x00013798
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x000155A0 File Offset: 0x000137A0
		public JsonConverter Converter
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

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x000155A8 File Offset: 0x000137A8
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x000155B0 File Offset: 0x000137B0
		internal JsonConverter InternalConverter
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x000155B8 File Offset: 0x000137B8
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x000155C0 File Offset: 0x000137C0
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000155C8 File Offset: 0x000137C8
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x000155D0 File Offset: 0x000137D0
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x000155D8 File Offset: 0x000137D8
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x000155E0 File Offset: 0x000137E0
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x000155E8 File Offset: 0x000137E8
		public Func<object> DefaultCreator
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x000155F0 File Offset: 0x000137F0
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x000155F8 File Offset: 0x000137F8
		public bool DefaultCreatorNonPublic
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

		// Token: 0x06001731 RID: 5937 RVA: 0x00015600 File Offset: 0x00013800
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JsonContract(Type underlyingType)
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00015610 File Offset: 0x00013810
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00015630 File Offset: 0x00013830
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00015650 File Offset: 0x00013850
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00015670 File Offset: 0x00013870
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00015690 File Offset: 0x00013890
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000156B0 File Offset: 0x000138B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x000156B8 File Offset: 0x000138B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000156C0 File Offset: 0x000138C0
		static JsonContract()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000B2B RID: 2859
		internal bool IsNullable;

		// Token: 0x04000B2C RID: 2860
		internal bool IsConvertable;

		// Token: 0x04000B2D RID: 2861
		internal bool IsEnum;

		// Token: 0x04000B2E RID: 2862
		internal Type NonNullableUnderlyingType;

		// Token: 0x04000B2F RID: 2863
		internal ReadType InternalReadType;

		// Token: 0x04000B30 RID: 2864
		internal JsonContractType ContractType;

		// Token: 0x04000B31 RID: 2865
		internal bool IsReadOnlyOrFixedSize;

		// Token: 0x04000B32 RID: 2866
		internal bool IsSealed;

		// Token: 0x04000B33 RID: 2867
		internal bool IsInstantiable;

		// Token: 0x04000B34 RID: 2868
		private List<SerializationCallback> PWpdqkZqyn;

		// Token: 0x04000B35 RID: 2869
		private IList<SerializationCallback> afGdLj6FCI;

		// Token: 0x04000B36 RID: 2870
		private IList<SerializationCallback> a1bd8u7sE8;

		// Token: 0x04000B37 RID: 2871
		private IList<SerializationCallback> AGvdbppoE8;

		// Token: 0x04000B38 RID: 2872
		private IList<SerializationErrorCallback> Rv8d4md3XN;

		// Token: 0x04000B39 RID: 2873
		private Type XwRdXeUZq8;

		// Token: 0x04000B3A RID: 2874
		[CompilerGenerated]
		private readonly Type HwcdG0Fsro;

		// Token: 0x04000B3B RID: 2875
		[CompilerGenerated]
		private bool? akRddGmNah;

		// Token: 0x04000B3C RID: 2876
		[CompilerGenerated]
		private JsonConverter GWGdjjNryk;

		// Token: 0x04000B3D RID: 2877
		[CompilerGenerated]
		private JsonConverter X0Ndy29bpk;

		// Token: 0x04000B3E RID: 2878
		[CompilerGenerated]
		private Func<object> v2ndf9TDaJ;

		// Token: 0x04000B3F RID: 2879
		[CompilerGenerated]
		private bool u6HdaTbopQ;

		// Token: 0x02000273 RID: 627
		[CompilerGenerated]
		private sealed class IqAFohN1hSM3JGhjC1i
		{
			// Token: 0x0600173A RID: 5946 RVA: 0x0001C538 File Offset: 0x0001A738
			[MethodImpl(MethodImplOptions.NoInlining)]
			public IqAFohN1hSM3JGhjC1i()
			{
			}

			// Token: 0x0600173B RID: 5947 RVA: 0x0001C540 File Offset: 0x0001A740
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void YhRE40KchT(object o, StreamingContext context)
			{
			}

			// Token: 0x0600173C RID: 5948 RVA: 0x0001C548 File Offset: 0x0001A748
			static IqAFohN1hSM3JGhjC1i()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000B40 RID: 2880
			public MethodInfo H9xEXBDWiq;
		}

		// Token: 0x02000274 RID: 628
		[CompilerGenerated]
		private sealed class wXuuIyNYyUMlKWZjR9Q
		{
			// Token: 0x0600173D RID: 5949 RVA: 0x0001C550 File Offset: 0x0001A750
			[MethodImpl(MethodImplOptions.NoInlining)]
			public wXuuIyNYyUMlKWZjR9Q()
			{
			}

			// Token: 0x0600173E RID: 5950 RVA: 0x0001C558 File Offset: 0x0001A758
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void jXCEGOWCdm(object o, StreamingContext context, ErrorContext econtext)
			{
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x0001C560 File Offset: 0x0001A760
			static wXuuIyNYyUMlKWZjR9Q()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000B41 RID: 2881
			public MethodInfo h72Ed8fgke;
		}
	}
}
