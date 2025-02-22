using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020002C3 RID: 707
	public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> where T : JToken
	{
		// Token: 0x06001B20 RID: 6944 RVA: 0x0001809C File Offset: 0x0001629C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JEnumerable(IEnumerable<T> enumerable)
		{
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x000180A4 File Offset: 0x000162A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x000180AC File Offset: 0x000162AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700058D RID: 1421
		public IJEnumerable<JToken> this[object key]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000180BC File Offset: 0x000162BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JEnumerable<T> other)
		{
			return true;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000180C4 File Offset: 0x000162C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			return true;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x000180CC File Offset: 0x000162CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x000180D4 File Offset: 0x000162D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JEnumerable()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			JEnumerable<T>.Empty = new JEnumerable<T>(Enumerable.Empty<T>());
		}

		// Token: 0x04000CB9 RID: 3257
		public static readonly JEnumerable<T> Empty;

		// Token: 0x04000CBA RID: 3258
		private readonly IEnumerable<T> FacnfoQPrk;
	}
}
