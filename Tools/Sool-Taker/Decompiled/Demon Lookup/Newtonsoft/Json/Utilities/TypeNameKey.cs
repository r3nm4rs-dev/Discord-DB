using System;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000243 RID: 579
	internal struct TypeNameKey : IEquatable<TypeNameKey>
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x00014A30 File Offset: 0x00012C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeNameKey(string assemblyName, string typeName)
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00014A38 File Offset: 0x00012C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00014A40 File Offset: 0x00012C40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			return true;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00014A48 File Offset: 0x00012C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TypeNameKey other)
		{
			return true;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00014A50 File Offset: 0x00012C50
		static TypeNameKey()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000ABD RID: 2749
		internal readonly string AssemblyName;

		// Token: 0x04000ABE RID: 2750
		internal readonly string TypeName;
	}
}
