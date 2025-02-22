using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x02000187 RID: 391
	[Serializable]
	public class JsonReaderException : JsonException
	{
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x0001075C File Offset: 0x0000E95C
		public int LineNumber
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00010764 File Offset: 0x0000E964
		public int LinePosition
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x0001076C File Offset: 0x0000E96C
		public string Path
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00010774 File Offset: 0x0000E974
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonReaderException()
		{
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0001077C File Offset: 0x0000E97C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonReaderException(string message)
		{
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00010784 File Offset: 0x0000E984
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonReaderException(string message, Exception innerException)
		{
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0001078C File Offset: 0x0000E98C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00010794 File Offset: 0x0000E994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception innerException)
		{
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0001079C File Offset: 0x0000E99C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000107A4 File Offset: 0x0000E9A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000107AC File Offset: 0x0000E9AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000107BC File Offset: 0x0000E9BC
		static JsonReaderException()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040006E2 RID: 1762
		[CompilerGenerated]
		private readonly int aIRlWMnUMQ;

		// Token: 0x040006E3 RID: 1763
		[CompilerGenerated]
		private readonly int wSPlsZWq4b;

		// Token: 0x040006E4 RID: 1764
		[CompilerGenerated]
		private readonly string V4flkGF3jv;
	}
}
