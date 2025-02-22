using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000247 RID: 583
	internal static class StringUtils
	{
		// Token: 0x0600160F RID: 5647 RVA: 0x00014B48 File Offset: 0x00012D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			return null;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00014B50 File Offset: 0x00012D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00014B58 File Offset: 0x00012D58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00014B60 File Offset: 0x00012D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00014B68 File Offset: 0x00012D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string JjsGMd8X4n(this string \u0020, IFormatProvider \u0020, params object[] args)
		{
			return null;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00014B70 File Offset: 0x00012D70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsWhiteSpace(string s)
		{
			return true;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00014B80 File Offset: 0x00012D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00014B88 File Offset: 0x00012D88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00014B98 File Offset: 0x00012D98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return null;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00014BA8 File Offset: 0x00012DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ToCamelCase(string s)
		{
			return null;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00014BB8 File Offset: 0x00012DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ToSnakeCase(string s)
		{
			return null;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00014BC8 File Offset: 0x00012DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsHighSurrogate(char c)
		{
			return true;
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00014BD0 File Offset: 0x00012DD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsLowSurrogate(char c)
		{
			return true;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00014BD8 File Offset: 0x00012DD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool StartsWith(this string source, char value)
		{
			return true;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool EndsWith(this string source, char value)
		{
			return true;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00014BE8 File Offset: 0x00012DE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string Trim(this string s, int start, int length)
		{
			return null;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00014BF8 File Offset: 0x00012DF8
		static StringUtils()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000AC4 RID: 2756
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x04000AC5 RID: 2757
		public const string Empty = "";

		// Token: 0x04000AC6 RID: 2758
		public const char CarriageReturn = '\r';

		// Token: 0x04000AC7 RID: 2759
		public const char LineFeed = '\n';

		// Token: 0x04000AC8 RID: 2760
		public const char Tab = '\t';

		// Token: 0x02000248 RID: 584
		internal enum SnakeCaseState
		{
			// Token: 0x04000ACA RID: 2762
			Start,
			// Token: 0x04000ACB RID: 2763
			Lower,
			// Token: 0x04000ACC RID: 2764
			Upper,
			// Token: 0x04000ACD RID: 2765
			NewWord
		}

		// Token: 0x02000249 RID: 585
		[CompilerGenerated]
		private sealed class OQHLmWY2gtYTnK95Rdk<orNCnUYX4fV7j9fn8Vs>
		{
			// Token: 0x06001620 RID: 5664 RVA: 0x0001C3CC File Offset: 0x0001A5CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public OQHLmWY2gtYTnK95Rdk()
			{
			}

			// Token: 0x06001621 RID: 5665 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool u7LATfSL7W(orNCnUYX4fV7j9fn8Vs s)
			{
				return true;
			}

			// Token: 0x06001622 RID: 5666 RVA: 0x0001C3DC File Offset: 0x0001A5DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool ULbAR81xu9(orNCnUYX4fV7j9fn8Vs s)
			{
				return true;
			}

			// Token: 0x06001623 RID: 5667 RVA: 0x0001C3E4 File Offset: 0x0001A5E4
			static OQHLmWY2gtYTnK95Rdk()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000ACE RID: 2766
			public Func<orNCnUYX4fV7j9fn8Vs, string> E2GAwh0Ybe;

			// Token: 0x04000ACF RID: 2767
			public string Vq9AB5Fbjy;
		}
	}
}
