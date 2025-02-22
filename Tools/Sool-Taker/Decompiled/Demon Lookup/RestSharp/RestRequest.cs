using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using HsZcU78F13T1yLWI1V;
using RestSharp.Serialization.Xml;
using RestSharp.Serializers;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp
{
	// Token: 0x020003D7 RID: 983
	public class RestRequest : IRestRequest
	{
		// Token: 0x0600259E RID: 9630 RVA: 0x00020A38 File Offset: 0x0001EC38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest()
		{
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00020A48 File Offset: 0x0001EC48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest(Method method)
		{
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00020A50 File Offset: 0x0001EC50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest(string resource, Method method)
		{
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00020A58 File Offset: 0x0001EC58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest(string resource, DataFormat dataFormat)
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00020A60 File Offset: 0x0001EC60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest(string resource)
		{
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00020A68 File Offset: 0x0001EC68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest(string resource, Method method, DataFormat dataFormat)
		{
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00020A88 File Offset: 0x0001EC88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest(Uri resource, Method method, DataFormat dataFormat)
		{
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00020A98 File Offset: 0x0001EC98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest(Uri resource, Method method)
		{
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00020AA0 File Offset: 0x0001ECA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RestRequest(Uri resource)
		{
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		public object UserState
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

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		public IList<DecompressionMethods> AllowedDecompressionMethods
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x00020AC8 File Offset: 0x0001ECC8
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x00020AD0 File Offset: 0x0001ECD0
		public bool AlwaysMultipartFormData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		public ISerializer JsonSerializer
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

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x00020AE8 File Offset: 0x0001ECE8
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		public IXmlSerializer XmlSerializer
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

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x00020B00 File Offset: 0x0001ED00
		public Action<Stream> ResponseWriter
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

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00020B10 File Offset: 0x0001ED10
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x00020B18 File Offset: 0x0001ED18
		public Action<Stream, IHttpResponse> AdvancedResponseWriter
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

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x00020B28 File Offset: 0x0001ED28
		// (set) Token: 0x060025B5 RID: 9653 RVA: 0x00020B30 File Offset: 0x0001ED30
		public bool UseDefaultCredentials
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00020B38 File Offset: 0x0001ED38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddFile(string name, string path, string contentType = null)
		{
			return null;
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00020B48 File Offset: 0x0001ED48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddFile(string name, byte[] bytes, string fileName, string contentType = null)
		{
			return null;
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00020B50 File Offset: 0x0001ED50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddFile(string name, Action<Stream> writer, string fileName, long contentLength, string contentType = null)
		{
			return null;
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00020B60 File Offset: 0x0001ED60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddFileBytes(string name, byte[] bytes, string filename, string contentType = "application/x-gzip")
		{
			return null;
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00020B70 File Offset: 0x0001ED70
		[Obsolete("Use AddXmlBody")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddBody(object obj, string xmlNamespace)
		{
			return null;
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00020B80 File Offset: 0x0001ED80
		[Obsolete("Use AddXmlBody")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddBody(object obj)
		{
			return null;
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00020B90 File Offset: 0x0001ED90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddJsonBody(object obj)
		{
			return null;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00020BA0 File Offset: 0x0001EDA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddXmlBody(object obj)
		{
			return null;
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00020BA8 File Offset: 0x0001EDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddXmlBody(object obj, string xmlNamespace)
		{
			return null;
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00020BB8 File Offset: 0x0001EDB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddObject(object obj, params string[] includedProperties)
		{
			return null;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddObject(object obj)
		{
			return null;
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00020BD8 File Offset: 0x0001EDD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddParameter(Parameter p)
		{
			return null;
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00020BE8 File Offset: 0x0001EDE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddParameter(string name, object value)
		{
			return null;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00020BF0 File Offset: 0x0001EDF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddParameter(string name, object value, ParameterType type)
		{
			return null;
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddParameter(string name, object value, string contentType, ParameterType type)
		{
			return null;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00020C00 File Offset: 0x0001EE00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddOrUpdateParameter(Parameter p)
		{
			return null;
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00020C10 File Offset: 0x0001EE10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddOrUpdateParameter(string name, object value)
		{
			return null;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00020C18 File Offset: 0x0001EE18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddOrUpdateParameter(string name, object value, ParameterType type)
		{
			return null;
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00020C20 File Offset: 0x0001EE20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddOrUpdateParameter(string name, object value, string contentType, ParameterType type)
		{
			return null;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00020C28 File Offset: 0x0001EE28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddHeader(string name, string value)
		{
			return null;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00020C38 File Offset: 0x0001EE38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddCookie(string name, string value)
		{
			return null;
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00020C40 File Offset: 0x0001EE40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddUrlSegment(string name, string value)
		{
			return null;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00020C48 File Offset: 0x0001EE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddQueryParameter(string name, string value)
		{
			return null;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00020C50 File Offset: 0x0001EE50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddQueryParameter(string name, string value, bool encode)
		{
			return null;
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00020C58 File Offset: 0x0001EE58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddDecompressionMethod(DecompressionMethods decompressionMethod)
		{
			return null;
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060025CF RID: 9679 RVA: 0x00020C68 File Offset: 0x0001EE68
		public List<Parameter> Parameters
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x00020C70 File Offset: 0x0001EE70
		public List<FileParameter> Files
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060025D1 RID: 9681 RVA: 0x00020C78 File Offset: 0x0001EE78
		// (set) Token: 0x060025D2 RID: 9682 RVA: 0x00020C84 File Offset: 0x0001EE84
		public Method Method
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Method)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x00020C8C File Offset: 0x0001EE8C
		// (set) Token: 0x060025D4 RID: 9684 RVA: 0x00020C94 File Offset: 0x0001EE94
		public string Resource
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

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x00020C9C File Offset: 0x0001EE9C
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x00020CA8 File Offset: 0x0001EEA8
		public DataFormat RequestFormat
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DataFormat)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x00020CB0 File Offset: 0x0001EEB0
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		[Obsolete("Add custom content handler instead. This property will be removed.")]
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

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		// (set) Token: 0x060025DA RID: 9690 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		public Action<IRestResponse> OnBeforeDeserialization
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

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x00020CD0 File Offset: 0x0001EED0
		// (set) Token: 0x060025DC RID: 9692 RVA: 0x00020CD8 File Offset: 0x0001EED8
		[Obsolete("Add custom content handler instead. This property will be removed.")]
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

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x00020CE0 File Offset: 0x0001EEE0
		// (set) Token: 0x060025DE RID: 9694 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		[Obsolete("Add custom content handler instead. This property will be removed.")]
		public string XmlNamespace
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

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x00020CF0 File Offset: 0x0001EEF0
		// (set) Token: 0x060025E0 RID: 9696 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		public ICredentials Credentials
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

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x00020D00 File Offset: 0x0001EF00
		// (set) Token: 0x060025E2 RID: 9698 RVA: 0x00020D08 File Offset: 0x0001EF08
		public int Timeout
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x00020D10 File Offset: 0x0001EF10
		// (set) Token: 0x060025E4 RID: 9700 RVA: 0x00020D18 File Offset: 0x0001EF18
		public int ReadWriteTimeout
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00020D20 File Offset: 0x0001EF20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IncreaseNumAttempts()
		{
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x00020D30 File Offset: 0x0001EF30
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x00020D38 File Offset: 0x0001EF38
		public int Attempts
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
			}
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00020D40 File Offset: 0x0001EF40
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IRestRequest RIxSwVeO5B(FileParameter \u0020)
		{
			return null;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00020D50 File Offset: 0x0001EF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IRestRequest AddUrlSegment(string name, object value)
		{
			return null;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x00020D58 File Offset: 0x0001EF58
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RestRequest()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			RestRequest.hkETroCM5f = new Regex(":\\d+");
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00020D78 File Offset: 0x0001EF78
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IEnumerable<NameValuePair> <.ctor>g__ParseQuery|8_0(string query)
		{
			return null;
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00020D88 File Offset: 0x0001EF88
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool <AddHeader>g__InvalidHost|60_0(string host)
		{
			return true;
		}

		// Token: 0x0400103D RID: 4157
		private readonly IList<DecompressionMethods> pE8SJ6R4V0;

		// Token: 0x0400103E RID: 4158
		private Action<Stream> Aj1SzsfnOy;

		// Token: 0x0400103F RID: 4159
		private Action<Stream, IHttpResponse> zawTtL6lxl;

		// Token: 0x04001040 RID: 4160
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object rNCTxNwt5f;

		// Token: 0x04001041 RID: 4161
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool VFtTcV6Lx4;

		// Token: 0x04001042 RID: 4162
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ISerializer qZ7THEqxIE;

		// Token: 0x04001043 RID: 4163
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private IXmlSerializer xb7TYQylrA;

		// Token: 0x04001044 RID: 4164
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool F9MTPuEU2L;

		// Token: 0x04001045 RID: 4165
		private static readonly Regex hkETroCM5f;

		// Token: 0x04001046 RID: 4166
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly List<Parameter> WE4Tp7ZGGw;

		// Token: 0x04001047 RID: 4167
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly List<FileParameter> VqPTM6HwAO;

		// Token: 0x04001048 RID: 4168
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Method enDTO1d0wG;

		// Token: 0x04001049 RID: 4169
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string P5OTv8m4t2;

		// Token: 0x0400104A RID: 4170
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DataFormat aNPTFcEQZ1;

		// Token: 0x0400104B RID: 4171
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string W9IT0BMrs9;

		// Token: 0x0400104C RID: 4172
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IRestResponse> ST1TuQSHOC;

		// Token: 0x0400104D RID: 4173
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string b7rT7Djt1r;

		// Token: 0x0400104E RID: 4174
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string ntvT1C85b2;

		// Token: 0x0400104F RID: 4175
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ICredentials tWkTiQ4eCw;

		// Token: 0x04001050 RID: 4176
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int cB6TUd9IGQ;

		// Token: 0x04001051 RID: 4177
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int IODTIgmFvm;

		// Token: 0x04001052 RID: 4178
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int BGQTN55usU;

		// Token: 0x020003D8 RID: 984
		[CompilerGenerated]
		[Serializable]
		private sealed class nYfpeyhCIVLP2F1MOyA
		{
			// Token: 0x060025ED RID: 9709 RVA: 0x00022F80 File Offset: 0x00021180
			[MethodImpl(MethodImplOptions.NoInlining)]
			static nYfpeyhCIVLP2F1MOyA()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				RestRequest.nYfpeyhCIVLP2F1MOyA.SvDxt9hkmtG = new RestRequest.nYfpeyhCIVLP2F1MOyA();
			}

			// Token: 0x060025EE RID: 9710 RVA: 0x00022F9C File Offset: 0x0002119C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public nYfpeyhCIVLP2F1MOyA()
			{
			}

			// Token: 0x060025EF RID: 9711 RVA: 0x00022FA4 File Offset: 0x000211A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void oX2xtI9klXf(IRestResponse r)
			{
			}

			// Token: 0x060025F0 RID: 9712 RVA: 0x00022FAC File Offset: 0x000211AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal NameValuePair TJqxtNVFgkt(string x)
			{
				return null;
			}

			// Token: 0x060025F1 RID: 9713 RVA: 0x00022FBC File Offset: 0x000211BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool gwTxtmeT5o4(NameValuePair x)
			{
				return true;
			}

			// Token: 0x060025F2 RID: 9714 RVA: 0x00022FC4 File Offset: 0x000211C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string o2HxtVrcQ3o(object item)
			{
				return null;
			}

			// Token: 0x04001053 RID: 4179
			public static readonly RestRequest.nYfpeyhCIVLP2F1MOyA SvDxt9hkmtG;

			// Token: 0x04001054 RID: 4180
			public static Action<IRestResponse> pEYxt20bWU6;

			// Token: 0x04001055 RID: 4181
			public static Func<string, NameValuePair> cqSxtgnhNKt;

			// Token: 0x04001056 RID: 4182
			public static Func<NameValuePair, bool> UeIxtCxKxjj;

			// Token: 0x04001057 RID: 4183
			public static Func<object, string> DFuxt6GWFRx;
		}

		// Token: 0x020003D9 RID: 985
		[CompilerGenerated]
		private sealed class dM8ooZhlbh8fKq68j0G
		{
			// Token: 0x060025F3 RID: 9715 RVA: 0x00022FCC File Offset: 0x000211CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public dM8ooZhlbh8fKq68j0G()
			{
			}

			// Token: 0x060025F4 RID: 9716 RVA: 0x00022FD4 File Offset: 0x000211D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void Wt7xtlpfmgC(Stream s)
			{
			}

			// Token: 0x060025F5 RID: 9717 RVA: 0x00022FF4 File Offset: 0x000211F4
			static dM8ooZhlbh8fKq68j0G()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04001058 RID: 4184
			public string EwextqBCyP5;
		}

		// Token: 0x020003DA RID: 986
		[CompilerGenerated]
		private sealed class a6U0JohVtoGaQFRuT7K
		{
			// Token: 0x060025F6 RID: 9718 RVA: 0x00022FFC File Offset: 0x000211FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public a6U0JohVtoGaQFRuT7K()
			{
			}

			// Token: 0x060025F7 RID: 9719 RVA: 0x00023004 File Offset: 0x00021204
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void aBwxtLPhjpO(Stream s)
			{
			}

			// Token: 0x060025F8 RID: 9720 RVA: 0x00023024 File Offset: 0x00021224
			static a6U0JohVtoGaQFRuT7K()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04001059 RID: 4185
			public byte[] bTlxt8yBq1c;
		}

		// Token: 0x020003DB RID: 987
		[CompilerGenerated]
		private sealed class FJF6UBhI0B3i4eSoE05
		{
			// Token: 0x060025F9 RID: 9721 RVA: 0x0002302C File Offset: 0x0002122C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FJF6UBhI0B3i4eSoE05()
			{
			}

			// Token: 0x060025FA RID: 9722 RVA: 0x00023034 File Offset: 0x00021234
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool mtPxtbeKc1I(Parameter param)
			{
				return true;
			}

			// Token: 0x060025FB RID: 9723 RVA: 0x0002303C File Offset: 0x0002123C
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool FI2xt462SYJ(Parameter param)
			{
				return true;
			}

			// Token: 0x060025FC RID: 9724 RVA: 0x00023044 File Offset: 0x00021244
			static FJF6UBhI0B3i4eSoE05()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x0400105A RID: 4186
			public Parameter KumxtX47Suf;
		}
	}
}
