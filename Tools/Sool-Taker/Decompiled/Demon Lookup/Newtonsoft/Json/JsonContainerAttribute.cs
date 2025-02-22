using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x02000173 RID: 371
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	public abstract class JsonContainerAttribute : Attribute
	{
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		public string Id
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

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x0000FBD8 File Offset: 0x0000DDD8
		public string Title
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0000FBE0 File Offset: 0x0000DDE0
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		public string Description
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

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0000FBF0 File Offset: 0x0000DDF0
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
		public Type ItemConverterType
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

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0000FC00 File Offset: 0x0000DE00
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public object[] ItemConverterParameters
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

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0000FC10 File Offset: 0x0000DE10
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x0000FC18 File Offset: 0x0000DE18
		public Type NamingStrategyType
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

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0000FC20 File Offset: 0x0000DE20
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x0000FC28 File Offset: 0x0000DE28
		public object[] NamingStrategyParameters
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

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0000FC30 File Offset: 0x0000DE30
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0000FC38 File Offset: 0x0000DE38
		internal NamingStrategy NamingStrategyInstance
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

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0000FC40 File Offset: 0x0000DE40
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x0000FC50 File Offset: 0x0000DE50
		public bool IsReference
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0000FC58 File Offset: 0x0000DE58
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x0000FC68 File Offset: 0x0000DE68
		public bool ItemIsReference
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0000FC70 File Offset: 0x0000DE70
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x0000FC84 File Offset: 0x0000DE84
		public ReferenceLoopHandling ItemReferenceLoopHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ReferenceLoopHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public TypeNameHandling ItemTypeNameHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TypeNameHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected JsonContainerAttribute()
		{
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected JsonContainerAttribute(string id)
		{
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		static JsonContainerAttribute()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000676 RID: 1654
		[CompilerGenerated]
		private string sbe6wVECB3;

		// Token: 0x04000677 RID: 1655
		[CompilerGenerated]
		private string G8W6BVinZp;

		// Token: 0x04000678 RID: 1656
		[CompilerGenerated]
		private string WyS6Jqn4bG;

		// Token: 0x04000679 RID: 1657
		[CompilerGenerated]
		private Type wOt6zbWFAi;

		// Token: 0x0400067A RID: 1658
		[CompilerGenerated]
		private object[] CbcltJ31Ky;

		// Token: 0x0400067B RID: 1659
		[CompilerGenerated]
		private NamingStrategy S7LlxcyMlp;

		// Token: 0x0400067C RID: 1660
		internal bool? _isReference;

		// Token: 0x0400067D RID: 1661
		internal bool? _itemIsReference;

		// Token: 0x0400067E RID: 1662
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		// Token: 0x0400067F RID: 1663
		internal TypeNameHandling? _itemTypeNameHandling;

		// Token: 0x04000680 RID: 1664
		private Type fMolccTKdS;

		// Token: 0x04000681 RID: 1665
		private object[] sVilHk1np2;
	}
}
