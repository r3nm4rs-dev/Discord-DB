using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using HsZcU78F13T1yLWI1V;
using RestSharp.Serialization.Xml;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp.Deserializers
{
	// Token: 0x020003F0 RID: 1008
	public class XmlDeserializer : IXmlDeserializer, IDeserializer
	{
		// Token: 0x060026A7 RID: 9895 RVA: 0x00021338 File Offset: 0x0001F538
		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlDeserializer()
		{
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x00021340 File Offset: 0x0001F540
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x00021348 File Offset: 0x0001F548
		public CultureInfo Culture
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

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x00021350 File Offset: 0x0001F550
		// (set) Token: 0x060026AB RID: 9899 RVA: 0x00021358 File Offset: 0x0001F558
		public string RootElement
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

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x00021360 File Offset: 0x0001F560
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x00021368 File Offset: 0x0001F568
		public string Namespace
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x00021370 File Offset: 0x0001F570
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x00021378 File Offset: 0x0001F578
		public string DateFormat
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

		// Token: 0x060026B0 RID: 9904 RVA: 0x00021380 File Offset: 0x0001F580
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual T Deserialize<T>(IRestResponse response)
		{
			return null;
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00021390 File Offset: 0x0001F590
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void edDR1WrpKw(XDocument \u0020)
		{
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000213B0 File Offset: 0x0001F5B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual object Map(object x, XElement root)
		{
			return null;
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000213D0 File Offset: 0x0001F5D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool NKORiu5T1S(string \u0020, out object \u0020, Type \u0020)
		{
			return true;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x000213E0 File Offset: 0x0001F5E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SMARUkBtar(Type \u0020, IEnumerable<XElement> \u0020, IList \u0020)
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00021400 File Offset: 0x0001F600
		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ol4RI2LbLF(XElement \u0020, string \u0020, Type \u0020)
		{
			return null;
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00021410 File Offset: 0x0001F610
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual object CreateAndMap(Type t, XElement element)
		{
			return null;
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00021420 File Offset: 0x0001F620
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual object GetValueFromXml(XElement root, XName name, PropertyInfo prop, bool useExactName)
		{
			return null;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x00021430 File Offset: 0x0001F630
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual XElement GetElementByName(XElement root, XName name)
		{
			return null;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00021440 File Offset: 0x0001F640
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual XAttribute GetAttributeByName(XElement root, XName name, bool useExactName)
		{
			return null;
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00021450 File Offset: 0x0001F650
		static XmlDeserializer()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x0400109F RID: 4255
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CultureInfo AM4RNWMLka;

		// Token: 0x040010A0 RID: 4256
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string cOLRm15q6W;

		// Token: 0x040010A1 RID: 4257
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string TOIRVYs7iY;

		// Token: 0x040010A2 RID: 4258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string qQ9R9xBIQ1;

		// Token: 0x020003F1 RID: 1009
		[CompilerGenerated]
		[Serializable]
		private sealed class C0qhDuh2OtjftWA3R16
		{
			// Token: 0x060026BB RID: 9915 RVA: 0x000230EC File Offset: 0x000212EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			static C0qhDuh2OtjftWA3R16()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				XmlDeserializer.C0qhDuh2OtjftWA3R16.BUFxtSamvBI = new XmlDeserializer.C0qhDuh2OtjftWA3R16();
			}

			// Token: 0x060026BC RID: 9916 RVA: 0x00023108 File Offset: 0x00021308
			[MethodImpl(MethodImplOptions.NoInlining)]
			public C0qhDuh2OtjftWA3R16()
			{
			}

			// Token: 0x060026BD RID: 9917 RVA: 0x00023110 File Offset: 0x00021310
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool AShxtKNgpRu(XAttribute a)
			{
				return true;
			}

			// Token: 0x060026BE RID: 9918 RVA: 0x00023118 File Offset: 0x00021318
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal XAttribute JphxtDpp9ZN(XAttribute a)
			{
				return null;
			}

			// Token: 0x060026BF RID: 9919 RVA: 0x00023128 File Offset: 0x00021328
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool U32xtZfmmca(XNode n)
			{
				return true;
			}

			// Token: 0x060026C0 RID: 9920 RVA: 0x00023130 File Offset: 0x00021330
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int pwpxthD16wC(XElement d)
			{
				return 0;
			}

			// Token: 0x060026C1 RID: 9921 RVA: 0x00023138 File Offset: 0x00021338
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int XNhxtQgkNHU(XElement d)
			{
				return 0;
			}

			// Token: 0x060026C2 RID: 9922 RVA: 0x00023140 File Offset: 0x00021340
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int ADixt3qGeuH(XElement d)
			{
				return 0;
			}

			// Token: 0x040010A3 RID: 4259
			public static readonly XmlDeserializer.C0qhDuh2OtjftWA3R16 BUFxtSamvBI;

			// Token: 0x040010A4 RID: 4260
			public static Func<XAttribute, bool> f1ExtTM3N9I;

			// Token: 0x040010A5 RID: 4261
			public static Func<XAttribute, XAttribute> vkWxtRPN7Y9;

			// Token: 0x040010A6 RID: 4262
			public static Func<XNode, bool> VWuxtwYDdBU;

			// Token: 0x040010A7 RID: 4263
			public static Func<XElement, int> JKextBqaJIv;

			// Token: 0x040010A8 RID: 4264
			public static Func<XElement, int> pw1xtJ11AYL;

			// Token: 0x040010A9 RID: 4265
			public static Func<XElement, int> tZExtzPIVV3;
		}

		// Token: 0x020003F2 RID: 1010
		[CompilerGenerated]
		private sealed class bJ3WM8hX98dvxO7graB
		{
			// Token: 0x060026C3 RID: 9923 RVA: 0x00023148 File Offset: 0x00021348
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bJ3WM8hX98dvxO7graB()
			{
			}

			// Token: 0x060026C4 RID: 9924 RVA: 0x00023150 File Offset: 0x00021350
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal object GK9xxt7adJW(XElement element)
			{
				return null;
			}

			// Token: 0x060026C5 RID: 9925 RVA: 0x00023158 File Offset: 0x00021358
			static bJ3WM8hX98dvxO7graB()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x040010AA RID: 4266
			public XmlDeserializer wBvxxxoAdRJ;

			// Token: 0x040010AB RID: 4267
			public Type kKjxxccWEfQ;

			// Token: 0x040010AC RID: 4268
			public Func<XElement, object> es7xxH0lmTk;
		}

		// Token: 0x020003F3 RID: 1011
		[CompilerGenerated]
		private sealed class a9M0JwhjHw39CNLLVKi
		{
			// Token: 0x060026C6 RID: 9926 RVA: 0x00023160 File Offset: 0x00021360
			[MethodImpl(MethodImplOptions.NoInlining)]
			public a9M0JwhjHw39CNLLVKi()
			{
			}

			// Token: 0x060026C7 RID: 9927 RVA: 0x00023168 File Offset: 0x00021368
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool fS9xxYij6Bj(XElement e)
			{
				return true;
			}

			// Token: 0x060026C8 RID: 9928 RVA: 0x00023170 File Offset: 0x00021370
			static a9M0JwhjHw39CNLLVKi()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x040010AD RID: 4269
			public string nejxxP5JRqX;
		}

		// Token: 0x020003F4 RID: 1012
		[CompilerGenerated]
		private sealed class HcYfdlhZScgM1FEesPV
		{
			// Token: 0x060026C9 RID: 9929 RVA: 0x00023178 File Offset: 0x00021378
			[MethodImpl(MethodImplOptions.NoInlining)]
			public HcYfdlhZScgM1FEesPV()
			{
			}

			// Token: 0x060026CA RID: 9930 RVA: 0x00023180 File Offset: 0x00021380
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool oEcxxrIjElC(XElement e)
			{
				return true;
			}

			// Token: 0x060026CB RID: 9931 RVA: 0x00023188 File Offset: 0x00021388
			static HcYfdlhZScgM1FEesPV()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x040010AE RID: 4270
			public XName F9xxxpDBSkD;
		}

		// Token: 0x020003F5 RID: 1013
		[CompilerGenerated]
		private sealed class D5ueXAh4GoxhOBCtLaF
		{
			// Token: 0x060026CC RID: 9932 RVA: 0x00023190 File Offset: 0x00021390
			[MethodImpl(MethodImplOptions.NoInlining)]
			public D5ueXAh4GoxhOBCtLaF()
			{
			}

			// Token: 0x060026CD RID: 9933 RVA: 0x00023198 File Offset: 0x00021398
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool rIMxxMrPNk7(XElement d)
			{
				return true;
			}

			// Token: 0x060026CE RID: 9934 RVA: 0x000231A0 File Offset: 0x000213A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool QaFxxOYnhWQ(XElement d)
			{
				return true;
			}

			// Token: 0x060026CF RID: 9935 RVA: 0x000231A8 File Offset: 0x000213A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool MQAxxvvZZWj(XAttribute x)
			{
				return true;
			}

			// Token: 0x060026D0 RID: 9936 RVA: 0x000231B0 File Offset: 0x000213B0
			static D5ueXAh4GoxhOBCtLaF()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x040010AF RID: 4271
			public XName VBkxxFNep6K;
		}

		// Token: 0x020003F6 RID: 1014
		[CompilerGenerated]
		private sealed class BOn5Yjhb08txZOePfbD
		{
			// Token: 0x060026D1 RID: 9937 RVA: 0x000231B8 File Offset: 0x000213B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public BOn5Yjhb08txZOePfbD()
			{
			}

			// Token: 0x060026D2 RID: 9938 RVA: 0x000231C0 File Offset: 0x000213C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool Popxx0QnEaU(XAttribute d)
			{
				return true;
			}

			// Token: 0x060026D3 RID: 9939 RVA: 0x000231D0 File Offset: 0x000213D0
			static BOn5Yjhb08txZOePfbD()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x040010B0 RID: 4272
			public bool CIjxxuPiGcO;

			// Token: 0x040010B1 RID: 4273
			public XName Ksvxx7DviWu;

			// Token: 0x040010B2 RID: 4274
			public List<XName> PuYxx1w6Ga4;
		}
	}
}
