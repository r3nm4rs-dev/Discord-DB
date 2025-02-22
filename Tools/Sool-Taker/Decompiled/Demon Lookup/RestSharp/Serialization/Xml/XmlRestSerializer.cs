using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp.Serialization.Xml
{
	// Token: 0x020003FE RID: 1022
	public class XmlRestSerializer : IRestSerializer, ISerializer, IDeserializer, IXmlSerializer, IWithRootElement, IXmlDeserializer
	{
		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x00021540 File Offset: 0x0001F740
		public string[] SupportedContentTypes
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x00021548 File Offset: 0x0001F748
		public DataFormat DataFormat
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DataFormat)null;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x00021554 File Offset: 0x0001F754
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x0002155C File Offset: 0x0001F75C
		public string ContentType
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

		// Token: 0x060026ED RID: 9965 RVA: 0x00021564 File Offset: 0x0001F764
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Serialize(object obj)
		{
			return null;
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x0002156C File Offset: 0x0001F76C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Deserialize<T>(IRestResponse response)
		{
			return null;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00021574 File Offset: 0x0001F774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlRestSerializer WithOptions(XmlSerilizationOptions options)
		{
			return null;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00021584 File Offset: 0x0001F784
		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlRestSerializer WithXmlSerializer<T>(XmlSerilizationOptions options = null) where T : IXmlSerializer, new()
		{
			return null;
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x00021594 File Offset: 0x0001F794
		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlRestSerializer WithXmlSerializer(IXmlSerializer xmlSerializer)
		{
			return null;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000215A4 File Offset: 0x0001F7A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlRestSerializer WithXmlDeserialzier<T>(XmlSerilizationOptions options = null) where T : IXmlDeserializer, new()
		{
			return null;
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000215B4 File Offset: 0x0001F7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlRestSerializer WithXmlDeserializer(IXmlDeserializer xmlDeserializer)
		{
			return null;
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000215C4 File Offset: 0x0001F7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string Serialize(Parameter parameter)
		{
			return null;
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x000215D4 File Offset: 0x0001F7D4
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x000215DC File Offset: 0x0001F7DC
		public string RootElement
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x000215E4 File Offset: 0x0001F7E4
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x000215EC File Offset: 0x0001F7EC
		public string Namespace
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000215F4 File Offset: 0x0001F7F4
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x000215FC File Offset: 0x0001F7FC
		public string DateFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00021604 File Offset: 0x0001F804
		[MethodImpl(MethodImplOptions.NoInlining)]
		public XmlRestSerializer()
		{
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00021614 File Offset: 0x0001F814
		static XmlRestSerializer()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040010B8 RID: 4280
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly string[] rQcR2oPVJW;

		// Token: 0x040010B9 RID: 4281
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly DataFormat OdjRg9TAmq;

		// Token: 0x040010BA RID: 4282
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string yGLRCKpOXf;

		// Token: 0x040010BB RID: 4283
		private XmlSerilizationOptions T91R6T7Mj7;

		// Token: 0x040010BC RID: 4284
		private IXmlSerializer g0qRlpUM3u;

		// Token: 0x040010BD RID: 4285
		private IXmlDeserializer K0yRqi2gos;
	}
}
