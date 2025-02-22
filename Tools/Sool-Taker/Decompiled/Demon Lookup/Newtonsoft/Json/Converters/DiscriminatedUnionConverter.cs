using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Utilities;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000306 RID: 774
	public class DiscriminatedUnionConverter : JsonConverter
	{
		// Token: 0x06001E31 RID: 7729 RVA: 0x00019AAC File Offset: 0x00017CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Type XHdWCHY9gg(Type \u0020)
		{
			return null;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00019ABC File Offset: 0x00017CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static DiscriminatedUnionConverter.Union qjNW6oP4F1(Type \u0020)
		{
			return null;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00019ACC File Offset: 0x00017CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00019ADC File Offset: 0x00017CDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00019AEC File Offset: 0x00017CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanConvert(Type objectType)
		{
			return true;
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x00019AFC File Offset: 0x00017CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiscriminatedUnionConverter()
		{
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00019B04 File Offset: 0x00017D04
		[MethodImpl(MethodImplOptions.NoInlining)]
		static DiscriminatedUnionConverter()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			DiscriminatedUnionConverter.G1FWl23nQG = new ThreadSafeStore<Type, DiscriminatedUnionConverter.Union>(new Func<Type, DiscriminatedUnionConverter.Union>(DiscriminatedUnionConverter.qjNW6oP4F1));
			DiscriminatedUnionConverter.CUDWqFPyLv = new ThreadSafeStore<Type, Type>(new Func<Type, Type>(DiscriminatedUnionConverter.XHdWCHY9gg));
		}

		// Token: 0x04000DE1 RID: 3553
		private static readonly ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> G1FWl23nQG;

		// Token: 0x04000DE2 RID: 3554
		private static readonly ThreadSafeStore<Type, Type> CUDWqFPyLv;

		// Token: 0x02000307 RID: 775
		internal class Union
		{
			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x06001E38 RID: 7736 RVA: 0x0001D66C File Offset: 0x0001B86C
			// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0001D674 File Offset: 0x0001B874
			public FSharpFunction TagReader
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x06001E3A RID: 7738 RVA: 0x0001D67C File Offset: 0x0001B87C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Union()
			{
			}

			// Token: 0x06001E3B RID: 7739 RVA: 0x0001D684 File Offset: 0x0001B884
			static Union()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000DE3 RID: 3555
			public List<DiscriminatedUnionConverter.UnionCase> Cases;

			// Token: 0x04000DE4 RID: 3556
			[CompilerGenerated]
			private FSharpFunction TvfKWtSEYk;
		}

		// Token: 0x02000308 RID: 776
		internal class UnionCase
		{
			// Token: 0x06001E3C RID: 7740 RVA: 0x0001D68C File Offset: 0x0001B88C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public UnionCase()
			{
			}

			// Token: 0x06001E3D RID: 7741 RVA: 0x0001D694 File Offset: 0x0001B894
			static UnionCase()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000DE5 RID: 3557
			public int Tag;

			// Token: 0x04000DE6 RID: 3558
			public string Name;

			// Token: 0x04000DE7 RID: 3559
			public PropertyInfo[] Fields;

			// Token: 0x04000DE8 RID: 3560
			public FSharpFunction FieldReader;

			// Token: 0x04000DE9 RID: 3561
			public FSharpFunction Constructor;
		}

		// Token: 0x02000309 RID: 777
		[CompilerGenerated]
		private sealed class cZd8lsNUTGqse85i6wl
		{
			// Token: 0x06001E3E RID: 7742 RVA: 0x0001D69C File Offset: 0x0001B89C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public cZd8lsNUTGqse85i6wl()
			{
			}

			// Token: 0x06001E3F RID: 7743 RVA: 0x0001D6A4 File Offset: 0x0001B8A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool yTbKsqo4Tp(DiscriminatedUnionConverter.UnionCase c)
			{
				return true;
			}

			// Token: 0x06001E40 RID: 7744 RVA: 0x0001D6AC File Offset: 0x0001B8AC
			static cZd8lsNUTGqse85i6wl()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000DEA RID: 3562
			public int UKYKkl6Cyk;
		}

		// Token: 0x0200030A RID: 778
		[CompilerGenerated]
		private sealed class xtOIBLNWiDudqQA2rEW
		{
			// Token: 0x06001E41 RID: 7745 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public xtOIBLNWiDudqQA2rEW()
			{
			}

			// Token: 0x06001E42 RID: 7746 RVA: 0x0001D6BC File Offset: 0x0001B8BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool edvKeOxXdM(DiscriminatedUnionConverter.UnionCase c)
			{
				return true;
			}

			// Token: 0x06001E43 RID: 7747 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
			static xtOIBLNWiDudqQA2rEW()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000DEB RID: 3563
			public string XZkKoH0p6E;

			// Token: 0x04000DEC RID: 3564
			public Func<DiscriminatedUnionConverter.UnionCase, bool> RWDKAC4qRP;
		}
	}
}
