using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace RestSharp.Serialization
{
	// Token: 0x020003F7 RID: 1015
	public static class ContentType
	{
		// Token: 0x060026D4 RID: 9940 RVA: 0x00021458 File Offset: 0x0001F658
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContentType()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			if (nCP5vtxT3QjsSeuiK3.TU7gF13T1(4016))
			{
				nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
				WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
				ContentType.FromDataFormat = new Dictionary<DataFormat, string>
				{
					{
						DataFormat.Xml,
						"application/xml"
					},
					{
						DataFormat.Json,
						"application/json"
					}
				};
				ContentType.JsonAccept = new string[]
				{
					"application/json",
					"text/json",
					"text/x-json",
					"text/javascript",
					"*+json"
				};
				ContentType.XmlAccept = new string[]
				{
					"application/xml",
					"text/xml",
					"*+xml",
					"*"
				};
			}
		}

		// Token: 0x040010B3 RID: 4275
		public const string Json = "application/json";

		// Token: 0x040010B4 RID: 4276
		public const string Xml = "application/xml";

		// Token: 0x040010B5 RID: 4277
		public static readonly Dictionary<DataFormat, string> FromDataFormat;

		// Token: 0x040010B6 RID: 4278
		public static readonly string[] JsonAccept;

		// Token: 0x040010B7 RID: 4279
		public static readonly string[] XmlAccept;
	}
}
