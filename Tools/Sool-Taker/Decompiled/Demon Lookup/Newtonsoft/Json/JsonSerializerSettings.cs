using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using HsZcU78F13T1yLWI1V;
using Newtonsoft.Json.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x0200018B RID: 395
	public class JsonSerializerSettings
	{
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		// (set) Token: 0x0600101C RID: 4124 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		public ReferenceLoopHandling ReferenceLoopHandling
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

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x00010BEC File Offset: 0x0000EDEC
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x00010C00 File Offset: 0x0000EE00
		public MissingMemberHandling MissingMemberHandling
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

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00010C08 File Offset: 0x0000EE08
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public ObjectCreationHandling ObjectCreationHandling
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

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00010C24 File Offset: 0x0000EE24
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x00010C38 File Offset: 0x0000EE38
		public NullValueHandling NullValueHandling
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

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00010C40 File Offset: 0x0000EE40
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x00010C54 File Offset: 0x0000EE54
		public DefaultValueHandling DefaultValueHandling
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

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00010C5C File Offset: 0x0000EE5C
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x00010C64 File Offset: 0x0000EE64
		public IList<JsonConverter> Converters
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

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x00010C6C File Offset: 0x0000EE6C
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x00010C80 File Offset: 0x0000EE80
		public PreserveReferencesHandling PreserveReferencesHandling
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

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00010C88 File Offset: 0x0000EE88
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x00010C9C File Offset: 0x0000EE9C
		public TypeNameHandling TypeNameHandling
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

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00010CA4 File Offset: 0x0000EEA4
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x00010CB8 File Offset: 0x0000EEB8
		public MetadataPropertyHandling MetadataPropertyHandling
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

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00010CC0 File Offset: 0x0000EEC0
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x00010CCC File Offset: 0x0000EECC
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public FormatterAssemblyStyle TypeNameAssemblyFormat
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

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00010CD4 File Offset: 0x0000EED4
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x00010CE8 File Offset: 0x0000EEE8
		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
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

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x00010D04 File Offset: 0x0000EF04
		public ConstructorHandling ConstructorHandling
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

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x00010D0C File Offset: 0x0000EF0C
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x00010D14 File Offset: 0x0000EF14
		public IContractResolver ContractResolver
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

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x00010D1C File Offset: 0x0000EF1C
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x00010D24 File Offset: 0x0000EF24
		public IEqualityComparer EqualityComparer
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

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x00010D2C File Offset: 0x0000EF2C
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x00010D34 File Offset: 0x0000EF34
		[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
		public IReferenceResolver ReferenceResolver
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

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00010D44 File Offset: 0x0000EF44
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x00010D4C File Offset: 0x0000EF4C
		public Func<IReferenceResolver> ReferenceResolverProvider
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

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00010D54 File Offset: 0x0000EF54
		// (set) Token: 0x0600103C RID: 4156 RVA: 0x00010D5C File Offset: 0x0000EF5C
		public ITraceWriter TraceWriter
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

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00010D64 File Offset: 0x0000EF64
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x00010D74 File Offset: 0x0000EF74
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public SerializationBinder Binder
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

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00010D7C File Offset: 0x0000EF7C
		// (set) Token: 0x06001040 RID: 4160 RVA: 0x00010D84 File Offset: 0x0000EF84
		public ISerializationBinder SerializationBinder
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

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00010D8C File Offset: 0x0000EF8C
		// (set) Token: 0x06001042 RID: 4162 RVA: 0x00010D94 File Offset: 0x0000EF94
		public EventHandler<ErrorEventArgs> Error
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

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x00010D9C File Offset: 0x0000EF9C
		// (set) Token: 0x06001044 RID: 4164 RVA: 0x00010DB0 File Offset: 0x0000EFB0
		public StreamingContext Context
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

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x00010DC0 File Offset: 0x0000EFC0
		public string DateFormatString
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

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		public int? MaxDepth
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

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x00010DF4 File Offset: 0x0000EFF4
		public Formatting Formatting
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

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x00010DFC File Offset: 0x0000EFFC
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x00010E10 File Offset: 0x0000F010
		public DateFormatHandling DateFormatHandling
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

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x00010E18 File Offset: 0x0000F018
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x00010E2C File Offset: 0x0000F02C
		public DateTimeZoneHandling DateTimeZoneHandling
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

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x00010E34 File Offset: 0x0000F034
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x00010E48 File Offset: 0x0000F048
		public DateParseHandling DateParseHandling
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00010E50 File Offset: 0x0000F050
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x00010E64 File Offset: 0x0000F064
		public FloatFormatHandling FloatFormatHandling
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

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x00010E6C File Offset: 0x0000F06C
		// (set) Token: 0x06001054 RID: 4180 RVA: 0x00010E80 File Offset: 0x0000F080
		public FloatParseHandling FloatParseHandling
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00010E88 File Offset: 0x0000F088
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x00010E9C File Offset: 0x0000F09C
		public StringEscapeHandling StringEscapeHandling
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001057 RID: 4183 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		// (set) Token: 0x06001058 RID: 4184 RVA: 0x00010EAC File Offset: 0x0000F0AC
		public CultureInfo Culture
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001059 RID: 4185 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		// (set) Token: 0x0600105A RID: 4186 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		public bool CheckAdditionalContent
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

		// Token: 0x0600105B RID: 4187 RVA: 0x00010ECC File Offset: 0x0000F0CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JsonSerializerSettings()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			JsonSerializerSettings.DefaultContext = default(StreamingContext);
			JsonSerializerSettings.DefaultCulture = CultureInfo.InvariantCulture;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonSerializerSettings()
		{
		}

		// Token: 0x04000704 RID: 1796
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		// Token: 0x04000705 RID: 1797
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		// Token: 0x04000706 RID: 1798
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		// Token: 0x04000707 RID: 1799
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		// Token: 0x04000708 RID: 1800
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		// Token: 0x04000709 RID: 1801
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		// Token: 0x0400070A RID: 1802
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		// Token: 0x0400070B RID: 1803
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		// Token: 0x0400070C RID: 1804
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

		// Token: 0x0400070D RID: 1805
		internal static readonly StreamingContext DefaultContext;

		// Token: 0x0400070E RID: 1806
		internal const Formatting DefaultFormatting = Formatting.None;

		// Token: 0x0400070F RID: 1807
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

		// Token: 0x04000710 RID: 1808
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

		// Token: 0x04000711 RID: 1809
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

		// Token: 0x04000712 RID: 1810
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

		// Token: 0x04000713 RID: 1811
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

		// Token: 0x04000714 RID: 1812
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

		// Token: 0x04000715 RID: 1813
		internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple;

		// Token: 0x04000716 RID: 1814
		internal static readonly CultureInfo DefaultCulture;

		// Token: 0x04000717 RID: 1815
		internal const bool DefaultCheckAdditionalContent = false;

		// Token: 0x04000718 RID: 1816
		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x04000719 RID: 1817
		internal Formatting? _formatting;

		// Token: 0x0400071A RID: 1818
		internal DateFormatHandling? _dateFormatHandling;

		// Token: 0x0400071B RID: 1819
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x0400071C RID: 1820
		internal DateParseHandling? _dateParseHandling;

		// Token: 0x0400071D RID: 1821
		internal FloatFormatHandling? _floatFormatHandling;

		// Token: 0x0400071E RID: 1822
		internal FloatParseHandling? _floatParseHandling;

		// Token: 0x0400071F RID: 1823
		internal StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x04000720 RID: 1824
		internal CultureInfo _culture;

		// Token: 0x04000721 RID: 1825
		internal bool? _checkAdditionalContent;

		// Token: 0x04000722 RID: 1826
		internal int? _maxDepth;

		// Token: 0x04000723 RID: 1827
		internal bool _maxDepthSet;

		// Token: 0x04000724 RID: 1828
		internal string _dateFormatString;

		// Token: 0x04000725 RID: 1829
		internal bool _dateFormatStringSet;

		// Token: 0x04000726 RID: 1830
		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		// Token: 0x04000727 RID: 1831
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x04000728 RID: 1832
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		// Token: 0x04000729 RID: 1833
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x0400072A RID: 1834
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x0400072B RID: 1835
		internal MissingMemberHandling? _missingMemberHandling;

		// Token: 0x0400072C RID: 1836
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x0400072D RID: 1837
		internal StreamingContext? _context;

		// Token: 0x0400072E RID: 1838
		internal ConstructorHandling? _constructorHandling;

		// Token: 0x0400072F RID: 1839
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x04000730 RID: 1840
		internal MetadataPropertyHandling? _metadataPropertyHandling;

		// Token: 0x04000731 RID: 1841
		[CompilerGenerated]
		private IList<JsonConverter> cndqxuxb6y;

		// Token: 0x04000732 RID: 1842
		[CompilerGenerated]
		private IContractResolver DMwqcD8nEP;

		// Token: 0x04000733 RID: 1843
		[CompilerGenerated]
		private IEqualityComparer zZiqH71DVS;

		// Token: 0x04000734 RID: 1844
		[CompilerGenerated]
		private Func<IReferenceResolver> ybSqY4nt9s;

		// Token: 0x04000735 RID: 1845
		[CompilerGenerated]
		private ITraceWriter BReqPIyQ6g;

		// Token: 0x04000736 RID: 1846
		[CompilerGenerated]
		private ISerializationBinder yWuqrBQK8Q;

		// Token: 0x04000737 RID: 1847
		[CompilerGenerated]
		private EventHandler<ErrorEventArgs> TDnqp1ugoh;

		// Token: 0x0200018C RID: 396
		[CompilerGenerated]
		private sealed class EwqnOxanjMiNCSX6lR
		{
			// Token: 0x0600105D RID: 4189 RVA: 0x0001ADD8 File Offset: 0x00018FD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public EwqnOxanjMiNCSX6lR()
			{
			}

			// Token: 0x0600105E RID: 4190 RVA: 0x0001ADE0 File Offset: 0x00018FE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IReferenceResolver wWkkE0tnB5()
			{
				return null;
			}

			// Token: 0x0600105F RID: 4191 RVA: 0x0001ADE8 File Offset: 0x00018FE8
			static EwqnOxanjMiNCSX6lR()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000738 RID: 1848
			public IReferenceResolver PXLkK7xTG4;
		}
	}
}
