using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200029C RID: 668
	[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
	[Serializable]
	public class JsonSchemaException : JsonException
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x0001733C File Offset: 0x0001553C
		public int LineNumber
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x00017344 File Offset: 0x00015544
		public int LinePosition
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x0001734C File Offset: 0x0001554C
		public string Path
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00017354 File Offset: 0x00015554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonSchemaException()
		{
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0001735C File Offset: 0x0001555C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonSchemaException(string message)
		{
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00017364 File Offset: 0x00015564
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonSchemaException(string message, Exception innerException)
		{
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0001736C File Offset: 0x0001556C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonSchemaException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00017374 File Offset: 0x00015574
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition)
		{
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0001737C File Offset: 0x0001557C
		static JsonSchemaException()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000C10 RID: 3088
		[CompilerGenerated]
		private readonly int IiNaqc82ht;

		// Token: 0x04000C11 RID: 3089
		[CompilerGenerated]
		private readonly int e67aL2yqAd;

		// Token: 0x04000C12 RID: 3090
		[CompilerGenerated]
		private readonly string fcva8BfoSF;
	}
}
