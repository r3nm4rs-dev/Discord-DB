using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000225 RID: 549
	internal static class JavaScriptUtils
	{
		// Token: 0x06001532 RID: 5426 RVA: 0x0001426C File Offset: 0x0001246C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JavaScriptUtils()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			if (nCP5vtxT3QjsSeuiK3.TU7gF13T1(2616))
			{
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				JavaScriptUtils.SingleQuoteCharEscapeFlags = new bool[128];
				JavaScriptUtils.DoubleQuoteCharEscapeFlags = new bool[128];
				JavaScriptUtils.HtmlCharEscapeFlags = new bool[128];
				IList<char> list = new List<char>
				{
					'\n',
					'\r',
					'\t',
					'\\',
					'\f',
					'\b'
				};
				for (int i = 0; i < 32; i++)
				{
					list.Add((char)i);
				}
				foreach (char c in list.Union(new char[]
				{
					'\''
				}))
				{
					JavaScriptUtils.SingleQuoteCharEscapeFlags[(int)c] = true;
				}
				foreach (char c2 in list.Union(new char[]
				{
					'"'
				}))
				{
					JavaScriptUtils.DoubleQuoteCharEscapeFlags[(int)c2] = true;
				}
				foreach (char c3 in list.Union(new char[]
				{
					'"',
					'\'',
					'<',
					'>',
					'&'
				}))
				{
					JavaScriptUtils.HtmlCharEscapeFlags[(int)c3] = true;
				}
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00014420 File Offset: 0x00012620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			return null;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00014428 File Offset: 0x00012628
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags)
		{
			return true;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00014438 File Offset: 0x00012638
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00014448 File Offset: 0x00012648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00014468 File Offset: 0x00012668
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int odDXaITLJ4(string \u0020, bool[] \u0020, StringEscapeHandling \u0020)
		{
			return 0;
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00014478 File Offset: 0x00012678
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task WriteEscapedJavaScriptStringAsync(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, JsonTextWriter client, char[] writeBuffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00014488 File Offset: 0x00012688
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task zVRXnMbK5u(TextWriter \u0020, string \u0020, char \u0020, bool[] \u0020, StringEscapeHandling \u0020, JsonTextWriter \u0020, char[] \u0020, CancellationToken \u0020)
		{
			return null;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00014498 File Offset: 0x00012698
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task Ej0X5AAhb6(Task \u0020, TextWriter \u0020, string \u0020, char \u0020, bool[] \u0020, StringEscapeHandling \u0020, JsonTextWriter \u0020, char[] \u0020, CancellationToken \u0020)
		{
			return null;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000144A8 File Offset: 0x000126A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task WriteCharAsync(Task task, TextWriter writer, char c, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x000144B8 File Offset: 0x000126B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task XNxXWoq2xk(TextWriter \u0020, string \u0020, bool[] \u0020, StringEscapeHandling \u0020, JsonTextWriter \u0020, char[] \u0020, CancellationToken \u0020)
		{
			return null;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x000144C8 File Offset: 0x000126C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Task d0eXsF0C4M(TextWriter \u0020, string \u0020, int \u0020, bool[] \u0020, StringEscapeHandling \u0020, JsonTextWriter \u0020, char[] \u0020, CancellationToken \u0020)
		{
			return null;
		}

		// Token: 0x04000A74 RID: 2676
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		// Token: 0x04000A75 RID: 2677
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		// Token: 0x04000A76 RID: 2678
		internal static readonly bool[] HtmlCharEscapeFlags;
	}
}
