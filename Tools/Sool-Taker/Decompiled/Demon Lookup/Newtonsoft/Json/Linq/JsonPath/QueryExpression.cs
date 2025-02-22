using System;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020002F4 RID: 756
	internal abstract class QueryExpression
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00019718 File Offset: 0x00017918
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x00019724 File Offset: 0x00017924
		public QueryOperator Operator
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (QueryOperator)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001DBA RID: 7610
		public abstract bool IsMatch(JToken root, JToken t);

		// Token: 0x06001DBB RID: 7611 RVA: 0x0001972C File Offset: 0x0001792C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected QueryExpression()
		{
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x00019734 File Offset: 0x00017934
		static QueryExpression()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000DAE RID: 3502
		[CompilerGenerated]
		private QueryOperator lqPWM5gsQ7;
	}
}
