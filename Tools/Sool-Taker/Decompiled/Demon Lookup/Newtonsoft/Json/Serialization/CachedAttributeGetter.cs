using System;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200024D RID: 589
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		// Token: 0x0600163D RID: 5693 RVA: 0x00014D1C File Offset: 0x00012F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetAttribute(object type)
		{
			return null;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00014D24 File Offset: 0x00012F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CachedAttributeGetter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			CachedAttributeGetter<T>.gZEGuFIA8m = new ThreadSafeStore<object, T>(new Func<object, T>(JsonTypeReflector.GetAttribute<T>));
		}

		// Token: 0x04000AD3 RID: 2771
		private static readonly ThreadSafeStore<object, T> gZEGuFIA8m;
	}
}
