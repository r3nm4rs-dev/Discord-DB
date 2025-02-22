using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200026B RID: 619
	public class JsonArrayContract : JsonContainerContract
	{
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00015428 File Offset: 0x00013628
		public Type CollectionItemType
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00015430 File Offset: 0x00013630
		public bool IsMultidimensionalArray
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00015438 File Offset: 0x00013638
		internal bool IsArray
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00015440 File Offset: 0x00013640
		internal bool ShouldCreateWrapper
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x00015448 File Offset: 0x00013648
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x00015450 File Offset: 0x00013650
		internal bool CanDeserialize
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x00015458 File Offset: 0x00013658
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00015460 File Offset: 0x00013660
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x00015468 File Offset: 0x00013668
		public ObjectConstructor<object> OverrideCreator
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

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00015470 File Offset: 0x00013670
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x00015478 File Offset: 0x00013678
		public bool HasParameterizedCreator
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

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x00015480 File Offset: 0x00013680
		internal bool HasParameterizedCreatorInternal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00015488 File Offset: 0x00013688
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonArrayContract(Type underlyingType)
		{
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00015498 File Offset: 0x00013698
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000154A8 File Offset: 0x000136A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IList CreateTemporaryCollection()
		{
			return null;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x000154B8 File Offset: 0x000136B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void wI1dppHV8F(Type \u0020)
		{
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x000154C8 File Offset: 0x000136C8
		static JsonArrayContract()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000B0E RID: 2830
		[CompilerGenerated]
		private readonly Type iDDdO5I7Zu;

		// Token: 0x04000B0F RID: 2831
		[CompilerGenerated]
		private readonly bool GRNdvif8FX;

		// Token: 0x04000B10 RID: 2832
		private readonly Type BVedFrlWAm;

		// Token: 0x04000B11 RID: 2833
		private Type wKAd05bon2;

		// Token: 0x04000B12 RID: 2834
		private ObjectConstructor<object> gfLdupak3I;

		// Token: 0x04000B13 RID: 2835
		private Func<object> hiLd7qbcpq;

		// Token: 0x04000B14 RID: 2836
		[CompilerGenerated]
		private readonly bool S8Id13eN74;

		// Token: 0x04000B15 RID: 2837
		[CompilerGenerated]
		private readonly bool ztjdivWRPP;

		// Token: 0x04000B16 RID: 2838
		[CompilerGenerated]
		private bool hmZdU1g7hO;

		// Token: 0x04000B17 RID: 2839
		private readonly ConstructorInfo THDdIefCFE;

		// Token: 0x04000B18 RID: 2840
		private ObjectConstructor<object> V31dNXiKDL;

		// Token: 0x04000B19 RID: 2841
		private ObjectConstructor<object> FyVdmJKnKj;

		// Token: 0x04000B1A RID: 2842
		[CompilerGenerated]
		private bool B9KdVBXmiv;
	}
}
