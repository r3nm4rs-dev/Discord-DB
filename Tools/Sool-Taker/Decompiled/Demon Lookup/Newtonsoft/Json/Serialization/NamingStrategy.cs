using System;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200028C RID: 652
	public abstract class NamingStrategy
	{
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x000169C8 File Offset: 0x00014BC8
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x000169D0 File Offset: 0x00014BD0
		public bool ProcessDictionaryKeys
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x000169D8 File Offset: 0x00014BD8
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x000169E0 File Offset: 0x00014BE0
		public bool ProcessExtensionDataNames
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x000169E8 File Offset: 0x00014BE8
		// (set) Token: 0x060018B0 RID: 6320 RVA: 0x000169F0 File Offset: 0x00014BF0
		public bool OverrideSpecifiedNames
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

		// Token: 0x060018B1 RID: 6321 RVA: 0x000169F8 File Offset: 0x00014BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string GetPropertyName(string name, bool hasSpecifiedName)
		{
			return null;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00016A00 File Offset: 0x00014C00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string GetExtensionDataName(string name)
		{
			return null;
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00016A08 File Offset: 0x00014C08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string GetDictionaryKey(string key)
		{
			return null;
		}

		// Token: 0x060018B4 RID: 6324
		protected abstract string ResolvePropertyName(string name);

		// Token: 0x060018B5 RID: 6325 RVA: 0x00016A10 File Offset: 0x00014C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected NamingStrategy()
		{
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00016A18 File Offset: 0x00014C18
		static NamingStrategy()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000BB6 RID: 2998
		[CompilerGenerated]
		private bool qHSf9Rq6FG;

		// Token: 0x04000BB7 RID: 2999
		[CompilerGenerated]
		private bool GxQf2llZ2W;

		// Token: 0x04000BB8 RID: 3000
		[CompilerGenerated]
		private bool B5WfgOildu;
	}
}
