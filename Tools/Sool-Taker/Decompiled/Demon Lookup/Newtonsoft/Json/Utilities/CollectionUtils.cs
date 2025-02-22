using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020001E9 RID: 489
	internal static class CollectionUtils
	{
		// Token: 0x0600139A RID: 5018 RVA: 0x00012A44 File Offset: 0x00010C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return true;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00012A4C File Offset: 0x00010C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00012A6C File Offset: 0x00010C6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsDictionaryType(Type type)
		{
			return true;
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00012A7C File Offset: 0x00010C7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			return null;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00012A8C File Offset: 0x00010C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			return null;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00012A9C File Offset: 0x00010C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AddDistinct<T>(this IList<T> list, T value)
		{
			return true;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00012AA4 File Offset: 0x00010CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			return true;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00012AAC File Offset: 0x00010CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return true;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00012ACC File Offset: 0x00010CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			return true;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00012AEC File Offset: 0x00010CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			return 0;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00012B0C File Offset: 0x00010D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			return true;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00012B1C File Offset: 0x00010D1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int IndexOfReference<T>(this List<T> list, T item)
		{
			return 0;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00012B2C File Offset: 0x00010D2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IList<int> acfbWStfJg(IList \u0020, int \u0020)
		{
			return null;
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00012B3C File Offset: 0x00010D3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void DOkbsoBsS0(IList \u0020, Array \u0020, int[] \u0020)
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00012B4C File Offset: 0x00010D4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object tFQbk8Cw0h(IList \u0020, int[] \u0020)
		{
			return null;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00012B5C File Offset: 0x00010D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00012B6C File Offset: 0x00010D6C
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
		public static T[] ArrayEmpty<T>()
		{
			return null;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00012B7C File Offset: 0x00010D7C
		static CollectionUtils()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
