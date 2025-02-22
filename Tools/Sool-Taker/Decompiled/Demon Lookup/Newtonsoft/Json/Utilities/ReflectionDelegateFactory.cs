using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000238 RID: 568
	internal abstract class ReflectionDelegateFactory
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x000146B8 File Offset: 0x000128B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x000146C8 File Offset: 0x000128C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x06001592 RID: 5522
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		// Token: 0x06001593 RID: 5523
		public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

		// Token: 0x06001594 RID: 5524
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		// Token: 0x06001595 RID: 5525
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		// Token: 0x06001596 RID: 5526
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		// Token: 0x06001597 RID: 5527
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		// Token: 0x06001598 RID: 5528
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);

		// Token: 0x06001599 RID: 5529 RVA: 0x000146D8 File Offset: 0x000128D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ReflectionDelegateFactory()
		{
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x000146E0 File Offset: 0x000128E0
		static ReflectionDelegateFactory()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
