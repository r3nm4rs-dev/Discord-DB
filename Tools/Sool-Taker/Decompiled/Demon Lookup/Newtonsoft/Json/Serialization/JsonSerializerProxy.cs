using System;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000286 RID: 646
	internal class JsonSerializerProxy : JsonSerializer
	{
		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06001843 RID: 6211 RVA: 0x00016578 File Offset: 0x00014778
		// (remove) Token: 0x06001844 RID: 6212 RVA: 0x00016580 File Offset: 0x00014780
		public override event EventHandler<ErrorEventArgs> Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00016588 File Offset: 0x00014788
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x00016590 File Offset: 0x00014790
		public override IReferenceResolver ReferenceResolver
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00016598 File Offset: 0x00014798
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x000165A0 File Offset: 0x000147A0
		public override ITraceWriter TraceWriter
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x000165A8 File Offset: 0x000147A8
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x000165B0 File Offset: 0x000147B0
		public override IEqualityComparer EqualityComparer
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x000165B8 File Offset: 0x000147B8
		public override JsonConverterCollection Converters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x000165C0 File Offset: 0x000147C0
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x000165CC File Offset: 0x000147CC
		public override DefaultValueHandling DefaultValueHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DefaultValueHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x000165D4 File Offset: 0x000147D4
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x000165DC File Offset: 0x000147DC
		public override IContractResolver ContractResolver
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x000165E4 File Offset: 0x000147E4
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x000165F0 File Offset: 0x000147F0
		public override MissingMemberHandling MissingMemberHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MissingMemberHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x000165F8 File Offset: 0x000147F8
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x00016604 File Offset: 0x00014804
		public override NullValueHandling NullValueHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (NullValueHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0001660C File Offset: 0x0001480C
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x00016618 File Offset: 0x00014818
		public override ObjectCreationHandling ObjectCreationHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ObjectCreationHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00016620 File Offset: 0x00014820
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0001662C File Offset: 0x0001482C
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ReferenceLoopHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00016634 File Offset: 0x00014834
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x00016640 File Offset: 0x00014840
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (PreserveReferencesHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00016648 File Offset: 0x00014848
		// (set) Token: 0x0600185B RID: 6235 RVA: 0x00016654 File Offset: 0x00014854
		public override TypeNameHandling TypeNameHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TypeNameHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x0001665C File Offset: 0x0001485C
		// (set) Token: 0x0600185D RID: 6237 RVA: 0x00016668 File Offset: 0x00014868
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (MetadataPropertyHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00016670 File Offset: 0x00014870
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x0001667C File Offset: 0x0001487C
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public override FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FormatterAssemblyStyle)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00016684 File Offset: 0x00014884
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x00016690 File Offset: 0x00014890
		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TypeNameAssemblyFormatHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00016698 File Offset: 0x00014898
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x000166A4 File Offset: 0x000148A4
		public override ConstructorHandling ConstructorHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ConstructorHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x000166AC File Offset: 0x000148AC
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x000166B4 File Offset: 0x000148B4
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public override SerializationBinder Binder
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x000166BC File Offset: 0x000148BC
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x000166C4 File Offset: 0x000148C4
		public override ISerializationBinder SerializationBinder
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x000166CC File Offset: 0x000148CC
		// (set) Token: 0x06001869 RID: 6249 RVA: 0x000166D8 File Offset: 0x000148D8
		public override StreamingContext Context
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (StreamingContext)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x000166E0 File Offset: 0x000148E0
		// (set) Token: 0x0600186B RID: 6251 RVA: 0x000166EC File Offset: 0x000148EC
		public override Formatting Formatting
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Formatting)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x000166F4 File Offset: 0x000148F4
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x00016700 File Offset: 0x00014900
		public override DateFormatHandling DateFormatHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DateFormatHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00016708 File Offset: 0x00014908
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x00016714 File Offset: 0x00014914
		public override DateTimeZoneHandling DateTimeZoneHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DateTimeZoneHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0001671C File Offset: 0x0001491C
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x00016728 File Offset: 0x00014928
		public override DateParseHandling DateParseHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (DateParseHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00016730 File Offset: 0x00014930
		// (set) Token: 0x06001873 RID: 6259 RVA: 0x0001673C File Offset: 0x0001493C
		public override FloatFormatHandling FloatFormatHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FloatFormatHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00016744 File Offset: 0x00014944
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x00016750 File Offset: 0x00014950
		public override FloatParseHandling FloatParseHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FloatParseHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00016758 File Offset: 0x00014958
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x00016764 File Offset: 0x00014964
		public override StringEscapeHandling StringEscapeHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (StringEscapeHandling)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0001676C File Offset: 0x0001496C
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x00016774 File Offset: 0x00014974
		public override string DateFormatString
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

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x0001677C File Offset: 0x0001497C
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x00016784 File Offset: 0x00014984
		public override CultureInfo Culture
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x0001678C File Offset: 0x0001498C
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x00016794 File Offset: 0x00014994
		public override int? MaxDepth
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0001679C File Offset: 0x0001499C
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x000167A4 File Offset: 0x000149A4
		public override bool CheckAdditionalContent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000167AC File Offset: 0x000149AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000167B4 File Offset: 0x000149B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000167BC File Offset: 0x000149BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000167C4 File Offset: 0x000149C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x000167CC File Offset: 0x000149CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000167D4 File Offset: 0x000149D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType)
		{
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000167DC File Offset: 0x000149DC
		static JsonSerializerProxy()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000BA0 RID: 2976
		private readonly JsonSerializerInternalReader Nu3frxfAZy;

		// Token: 0x04000BA1 RID: 2977
		private readonly JsonSerializerInternalWriter qD8fp5bXlW;

		// Token: 0x04000BA2 RID: 2978
		private readonly JsonSerializer bf1fMXtPir;
	}
}
