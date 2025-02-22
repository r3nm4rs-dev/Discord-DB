using System;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020002AB RID: 683
	[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x06001A1F RID: 6687 RVA: 0x00017894 File Offset: 0x00015A94
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ValidationEventArgs(JsonSchemaException ex)
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0001789C File Offset: 0x00015A9C
		public JsonSchemaException Exception
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x000178A4 File Offset: 0x00015AA4
		public string Path
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x000178AC File Offset: 0x00015AAC
		public string Message
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000178B4 File Offset: 0x00015AB4
		static ValidationEventArgs()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000C53 RID: 3155
		private readonly JsonSchemaException kspn8PQard;
	}
}
