using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x0200017E RID: 382
	internal struct JsonPosition
	{
		// Token: 0x06000F20 RID: 3872 RVA: 0x00010164 File Offset: 0x0000E364
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonPosition(JsonContainerType type)
		{
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0001016C File Offset: 0x0000E36C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int CalculateLength()
		{
			return 0;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0001017C File Offset: 0x0000E37C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void WriteTo(StringBuilder sb)
		{
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0001018C File Offset: 0x0000E38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			return true;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00010194 File Offset: 0x0000E394
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			return null;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000101B4 File Offset: 0x0000E3B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message)
		{
			return null;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000101C4 File Offset: 0x0000E3C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JsonPosition()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			JsonPosition.yB7l1UYlbA = new char[]
			{
				'.',
				' ',
				'[',
				']',
				'(',
				')'
			};
		}

		// Token: 0x04000695 RID: 1685
		private static readonly char[] yB7l1UYlbA;

		// Token: 0x04000696 RID: 1686
		internal JsonContainerType Type;

		// Token: 0x04000697 RID: 1687
		internal int Position;

		// Token: 0x04000698 RID: 1688
		internal string PropertyName;

		// Token: 0x04000699 RID: 1689
		internal bool HasIndex;
	}
}
