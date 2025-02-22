using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using deslvHZHZ9Tbq0f7fZ;
using HsZcU78F13T1yLWI1V;
using SimpleJson.Reflection;
using UY3BiEArlp6B4GPt9k;

namespace SimpleJson
{
	// Token: 0x02000385 RID: 901
	[GeneratedCode("simple-json", "1.0.0")]
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PocoJsonSerializerStrategy()
		{
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0001F2B4 File Offset: 0x0001D4B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
		{
			return null;
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
		{
			return null;
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0001F2D4 File Offset: 0x0001D4D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			return null;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0001F300 File Offset: 0x0001D500
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			return null;
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0001F32C File Offset: 0x0001D52C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
		{
			return true;
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0001F33C File Offset: 0x0001D53C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual object DeserializeObject(object value, Type type)
		{
			return null;
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0001F380 File Offset: 0x0001D580
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual object SerializeEnum(Enum p)
		{
			return null;
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0001F390 File Offset: 0x0001D590
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool TrySerializeKnownTypes(object input, out object output)
		{
			return true;
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0001F3A0 File Offset: 0x0001D5A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool TrySerializeUnknownTypes(object input, out object output)
		{
			return true;
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x0001F3C0 File Offset: 0x0001D5C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PocoJsonSerializerStrategy()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			PocoJsonSerializerStrategy.EmptyTypes = new Type[0];
			PocoJsonSerializerStrategy.ArrayConstructorParameterTypes = new Type[]
			{
				Type.GetTypeFromHandle(nla1WKOGMY5oN5nImw.YLTPhkyqLF6F9(16777219))
			};
			PocoJsonSerializerStrategy.p9qhTIvFxW = new string[]
			{
				"yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z",
				"yyyy-MM-dd\\THH:mm:ss\\Z",
				"yyyy-MM-dd\\THH:mm:ssK"
			};
		}

		// Token: 0x04000F08 RID: 3848
		internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

		// Token: 0x04000F09 RID: 3849
		internal IDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>> GetCache;

		// Token: 0x04000F0A RID: 3850
		internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

		// Token: 0x04000F0B RID: 3851
		internal static readonly Type[] EmptyTypes;

		// Token: 0x04000F0C RID: 3852
		internal static readonly Type[] ArrayConstructorParameterTypes;

		// Token: 0x04000F0D RID: 3853
		private static readonly string[] p9qhTIvFxW;
	}
}
