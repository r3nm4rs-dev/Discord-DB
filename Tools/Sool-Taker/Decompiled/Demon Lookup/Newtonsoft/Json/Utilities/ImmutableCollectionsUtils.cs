using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200021F RID: 543
	internal static class ImmutableCollectionsUtils
	{
		// Token: 0x06001519 RID: 5401 RVA: 0x00014094 File Offset: 0x00012294
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator)
		{
			return true;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000140A4 File Offset: 0x000122A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator)
		{
			return true;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000140B4 File Offset: 0x000122B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ImmutableCollectionsUtils()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			if (!nCP5vtxT3QjsSeuiK3.TU7gF13T1(2612))
			{
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				ImmutableCollectionsUtils.EDWXy2oVj0 = new List<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>
				{
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.IImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList`1", "System.Collections.Immutable.ImmutableList"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.IImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue`1", "System.Collections.Immutable.ImmutableQueue"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.IImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack`1", "System.Collections.Immutable.ImmutableStack"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.IImmutableSet`1", "System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet`1", "System.Collections.Immutable.ImmutableSortedSet"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet`1", "System.Collections.Immutable.ImmutableHashSet"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray`1", "System.Collections.Immutable.ImmutableArray")
				};
				ImmutableCollectionsUtils.jndXfg1sXC = new List<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>
				{
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.IImmutableDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary`2", "System.Collections.Immutable.ImmutableSortedDictionary"),
					new ImmutableCollectionsUtils.ImmutableCollectionTypeInfo("System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary`2", "System.Collections.Immutable.ImmutableDictionary")
				};
			}
		}

		// Token: 0x04000A6A RID: 2666
		private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> EDWXy2oVj0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> jndXfg1sXC;

		// Token: 0x02000220 RID: 544
		internal class ImmutableCollectionTypeInfo
		{
			// Token: 0x0600151C RID: 5404 RVA: 0x0001C0A8 File Offset: 0x0001A2A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName)
			{
			}

			// Token: 0x17000479 RID: 1145
			// (get) Token: 0x0600151D RID: 5405 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
			// (set) Token: 0x0600151E RID: 5406 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
			public string ContractTypeName
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

			// Token: 0x1700047A RID: 1146
			// (get) Token: 0x0600151F RID: 5407 RVA: 0x0001C0C0 File Offset: 0x0001A2C0
			// (set) Token: 0x06001520 RID: 5408 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
			public string CreatedTypeName
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

			// Token: 0x1700047B RID: 1147
			// (get) Token: 0x06001521 RID: 5409 RVA: 0x0001C0D0 File Offset: 0x0001A2D0
			// (set) Token: 0x06001522 RID: 5410 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
			public string BuilderTypeName
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

			// Token: 0x06001523 RID: 5411 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
			static ImmutableCollectionTypeInfo()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000A6C RID: 2668
			[CompilerGenerated]
			private string OPRoBIrE4N;

			// Token: 0x04000A6D RID: 2669
			[CompilerGenerated]
			private string IKToJou6Hv;

			// Token: 0x04000A6E RID: 2670
			[CompilerGenerated]
			private string cxiozVspta;
		}

		// Token: 0x02000221 RID: 545
		[CompilerGenerated]
		private sealed class hnwBWBYvKiWVCpkTZB7
		{
			// Token: 0x06001524 RID: 5412 RVA: 0x0001C0E8 File Offset: 0x0001A2E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public hnwBWBYvKiWVCpkTZB7()
			{
			}

			// Token: 0x06001525 RID: 5413 RVA: 0x0001C0F0 File Offset: 0x0001A2F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool I6yAtiw2Aw(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d)
			{
				return true;
			}

			// Token: 0x06001526 RID: 5414 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
			static hnwBWBYvKiWVCpkTZB7()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000A6F RID: 2671
			public string TGqAxUpCYh;
		}

		// Token: 0x02000222 RID: 546
		[CompilerGenerated]
		[Serializable]
		private sealed class wqfJaRY9T3rE6KnRC4T
		{
			// Token: 0x06001527 RID: 5415 RVA: 0x0001C100 File Offset: 0x0001A300
			[MethodImpl(MethodImplOptions.NoInlining)]
			static wqfJaRY9T3rE6KnRC4T()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				ImmutableCollectionsUtils.wqfJaRY9T3rE6KnRC4T.k4LAYBvhpl = new ImmutableCollectionsUtils.wqfJaRY9T3rE6KnRC4T();
			}

			// Token: 0x06001528 RID: 5416 RVA: 0x0001C11C File Offset: 0x0001A31C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public wqfJaRY9T3rE6KnRC4T()
			{
			}

			// Token: 0x06001529 RID: 5417 RVA: 0x0001C124 File Offset: 0x0001A324
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool XWVAcGy9Kq(MethodInfo m)
			{
				return true;
			}

			// Token: 0x0600152A RID: 5418 RVA: 0x0001C12C File Offset: 0x0001A32C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool XYWAHcGjpG(MethodInfo m)
			{
				return true;
			}

			// Token: 0x04000A70 RID: 2672
			public static readonly ImmutableCollectionsUtils.wqfJaRY9T3rE6KnRC4T k4LAYBvhpl;

			// Token: 0x04000A71 RID: 2673
			public static Func<MethodInfo, bool> ttAAPQ2Ufu;

			// Token: 0x04000A72 RID: 2674
			public static Func<MethodInfo, bool> dXnArc117V;
		}

		// Token: 0x02000223 RID: 547
		[CompilerGenerated]
		private sealed class nj88UUYa3DMrNrSP4Cl
		{
			// Token: 0x0600152B RID: 5419 RVA: 0x0001C13C File Offset: 0x0001A33C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public nj88UUYa3DMrNrSP4Cl()
			{
			}

			// Token: 0x0600152C RID: 5420 RVA: 0x0001C144 File Offset: 0x0001A344
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool hkKApGOijV(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d)
			{
				return true;
			}

			// Token: 0x0600152D RID: 5421 RVA: 0x0001C14C File Offset: 0x0001A34C
			static nj88UUYa3DMrNrSP4Cl()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000A73 RID: 2675
			public string aYYAMgist2;
		}
	}
}
