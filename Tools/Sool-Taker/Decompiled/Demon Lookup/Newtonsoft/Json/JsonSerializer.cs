using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json
{
	// Token: 0x0200018A RID: 394
	public class JsonSerializer
	{
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000FC3 RID: 4035 RVA: 0x00010814 File Offset: 0x0000EA14
		// (remove) Token: 0x06000FC4 RID: 4036 RVA: 0x00010824 File Offset: 0x0000EA24
		public virtual event EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00010834 File Offset: 0x0000EA34
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0001083C File Offset: 0x0000EA3C
		public virtual IReferenceResolver ReferenceResolver
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

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00010844 File Offset: 0x0000EA44
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x00010854 File Offset: 0x0000EA54
		[Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public virtual SerializationBinder Binder
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

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x0001085C File Offset: 0x0000EA5C
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x00010864 File Offset: 0x0000EA64
		public virtual ISerializationBinder SerializationBinder
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0001086C File Offset: 0x0000EA6C
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x00010874 File Offset: 0x0000EA74
		public virtual ITraceWriter TraceWriter
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

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0001087C File Offset: 0x0000EA7C
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x00010884 File Offset: 0x0000EA84
		public virtual IEqualityComparer EqualityComparer
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x0001088C File Offset: 0x0000EA8C
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x00010898 File Offset: 0x0000EA98
		public virtual TypeNameHandling TypeNameHandling
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

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x000108A0 File Offset: 0x0000EAA0
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x000108AC File Offset: 0x0000EAAC
		[Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public virtual FormatterAssemblyStyle TypeNameAssemblyFormat
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000108B4 File Offset: 0x0000EAB4
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x000108C0 File Offset: 0x0000EAC0
		public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x000108C8 File Offset: 0x0000EAC8
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x000108D4 File Offset: 0x0000EAD4
		public virtual PreserveReferencesHandling PreserveReferencesHandling
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000108DC File Offset: 0x0000EADC
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x000108E8 File Offset: 0x0000EAE8
		public virtual ReferenceLoopHandling ReferenceLoopHandling
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

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000108F0 File Offset: 0x0000EAF0
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x000108FC File Offset: 0x0000EAFC
		public virtual MissingMemberHandling MissingMemberHandling
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

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00010904 File Offset: 0x0000EB04
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00010910 File Offset: 0x0000EB10
		public virtual NullValueHandling NullValueHandling
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

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00010918 File Offset: 0x0000EB18
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00010924 File Offset: 0x0000EB24
		public virtual DefaultValueHandling DefaultValueHandling
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

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0001092C File Offset: 0x0000EB2C
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00010938 File Offset: 0x0000EB38
		public virtual ObjectCreationHandling ObjectCreationHandling
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

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00010940 File Offset: 0x0000EB40
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x0001094C File Offset: 0x0000EB4C
		public virtual ConstructorHandling ConstructorHandling
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

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00010954 File Offset: 0x0000EB54
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00010960 File Offset: 0x0000EB60
		public virtual MetadataPropertyHandling MetadataPropertyHandling
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

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00010968 File Offset: 0x0000EB68
		public virtual JsonConverterCollection Converters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00010970 File Offset: 0x0000EB70
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00010978 File Offset: 0x0000EB78
		public virtual IContractResolver ContractResolver
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00010980 File Offset: 0x0000EB80
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0001098C File Offset: 0x0000EB8C
		public virtual StreamingContext Context
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

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00010994 File Offset: 0x0000EB94
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x000109A8 File Offset: 0x0000EBA8
		public virtual Formatting Formatting
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x000109B0 File Offset: 0x0000EBB0
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x000109C4 File Offset: 0x0000EBC4
		public virtual DateFormatHandling DateFormatHandling
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x000109CC File Offset: 0x0000EBCC
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x000109E0 File Offset: 0x0000EBE0
		public virtual DateTimeZoneHandling DateTimeZoneHandling
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

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000109E8 File Offset: 0x0000EBE8
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x000109FC File Offset: 0x0000EBFC
		public virtual DateParseHandling DateParseHandling
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00010A04 File Offset: 0x0000EC04
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00010A18 File Offset: 0x0000EC18
		public virtual FloatParseHandling FloatParseHandling
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

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00010A20 File Offset: 0x0000EC20
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00010A34 File Offset: 0x0000EC34
		public virtual FloatFormatHandling FloatFormatHandling
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

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00010A3C File Offset: 0x0000EC3C
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x00010A50 File Offset: 0x0000EC50
		public virtual StringEscapeHandling StringEscapeHandling
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

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00010A58 File Offset: 0x0000EC58
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x00010A60 File Offset: 0x0000EC60
		public virtual string DateFormatString
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00010A68 File Offset: 0x0000EC68
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x00010A70 File Offset: 0x0000EC70
		public virtual CultureInfo Culture
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00010A78 File Offset: 0x0000EC78
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x00010A80 File Offset: 0x0000EC80
		public virtual int? MaxDepth
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

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00010A90 File Offset: 0x0000EC90
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		public virtual bool CheckAdditionalContent
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

		// Token: 0x06001000 RID: 4096 RVA: 0x00010AA8 File Offset: 0x0000ECA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool IsCheckAdditionalContentSet()
		{
			return true;
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonSerializer()
		{
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00010AC0 File Offset: 0x0000ECC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JsonSerializer Create()
		{
			return null;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00010AC8 File Offset: 0x0000ECC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00010AD8 File Offset: 0x0000ECD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JsonSerializer CreateDefault()
		{
			return null;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00010AE0 File Offset: 0x0000ECE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static JsonSerializer CreateDefault(JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void cd5leM9Z9G(JsonSerializer \u0020, JsonSerializerSettings \u0020)
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00010B00 File Offset: 0x0000ED00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Populate(TextReader reader, object target)
		{
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00010B08 File Offset: 0x0000ED08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Populate(JsonReader reader, object target)
		{
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00010B10 File Offset: 0x0000ED10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00010B20 File Offset: 0x0000ED20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Deserialize(JsonReader reader)
		{
			return null;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00010B28 File Offset: 0x0000ED28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Deserialize(TextReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00010B30 File Offset: 0x0000ED30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Deserialize<T>(JsonReader reader)
		{
			return null;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00010B38 File Offset: 0x0000ED38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Deserialize(JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00010B40 File Offset: 0x0000ED40
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00010B50 File Offset: 0x0000ED50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void I5Wlo8y7Sd(JsonReader \u0020, out CultureInfo \u0020, out DateTimeZoneHandling? \u0020, out DateParseHandling? \u0020, out FloatParseHandling? \u0020, out int? \u0020, out string \u0020)
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00010B60 File Offset: 0x0000ED60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void fZSlAoP5ey(JsonReader \u0020, CultureInfo \u0020, DateTimeZoneHandling? \u0020, DateParseHandling? \u0020, FloatParseHandling? \u0020, int? \u0020, string \u0020)
		{
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00010B70 File Offset: 0x0000ED70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(TextWriter textWriter, object value)
		{
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00010B78 File Offset: 0x0000ED78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00010B80 File Offset: 0x0000ED80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(TextWriter textWriter, object value, Type objectType)
		{
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00010B88 File Offset: 0x0000ED88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00010B90 File Offset: 0x0000ED90
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00010BA0 File Offset: 0x0000EDA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IReferenceResolver GetReferenceResolver()
		{
			return null;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			return null;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void OnError(Newtonsoft.Json.Serialization.ErrorEventArgs e)
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00010BC8 File Offset: 0x0000EDC8
		static JsonSerializer()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040006E5 RID: 1765
		internal TypeNameHandling _typeNameHandling;

		// Token: 0x040006E6 RID: 1766
		internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;

		// Token: 0x040006E7 RID: 1767
		internal PreserveReferencesHandling _preserveReferencesHandling;

		// Token: 0x040006E8 RID: 1768
		internal ReferenceLoopHandling _referenceLoopHandling;

		// Token: 0x040006E9 RID: 1769
		internal MissingMemberHandling _missingMemberHandling;

		// Token: 0x040006EA RID: 1770
		internal ObjectCreationHandling _objectCreationHandling;

		// Token: 0x040006EB RID: 1771
		internal NullValueHandling _nullValueHandling;

		// Token: 0x040006EC RID: 1772
		internal DefaultValueHandling _defaultValueHandling;

		// Token: 0x040006ED RID: 1773
		internal ConstructorHandling _constructorHandling;

		// Token: 0x040006EE RID: 1774
		internal MetadataPropertyHandling _metadataPropertyHandling;

		// Token: 0x040006EF RID: 1775
		internal JsonConverterCollection _converters;

		// Token: 0x040006F0 RID: 1776
		internal IContractResolver _contractResolver;

		// Token: 0x040006F1 RID: 1777
		internal ITraceWriter _traceWriter;

		// Token: 0x040006F2 RID: 1778
		internal IEqualityComparer _equalityComparer;

		// Token: 0x040006F3 RID: 1779
		internal ISerializationBinder _serializationBinder;

		// Token: 0x040006F4 RID: 1780
		internal StreamingContext _context;

		// Token: 0x040006F5 RID: 1781
		private IReferenceResolver qXIlELB17B;

		// Token: 0x040006F6 RID: 1782
		private Formatting? sGPlKH2rFB;

		// Token: 0x040006F7 RID: 1783
		private DateFormatHandling? WpElDsBonw;

		// Token: 0x040006F8 RID: 1784
		private DateTimeZoneHandling? MO4lZDuZki;

		// Token: 0x040006F9 RID: 1785
		private DateParseHandling? fmhlh8dtR7;

		// Token: 0x040006FA RID: 1786
		private FloatFormatHandling? qQWlQLxDNY;

		// Token: 0x040006FB RID: 1787
		private FloatParseHandling? BTWl3EU90D;

		// Token: 0x040006FC RID: 1788
		private StringEscapeHandling? xAIlScOJrd;

		// Token: 0x040006FD RID: 1789
		private CultureInfo FQFlTS8h6j;

		// Token: 0x040006FE RID: 1790
		private int? E3FlRsi8UI;

		// Token: 0x040006FF RID: 1791
		private bool OSTlwV0gCO;

		// Token: 0x04000700 RID: 1792
		private bool? Pj5lB7eEXJ;

		// Token: 0x04000701 RID: 1793
		private string pYHlJ1FjId;

		// Token: 0x04000702 RID: 1794
		private bool JxWlz9h72L;

		// Token: 0x04000703 RID: 1795
		[CompilerGenerated]
		private EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> DCeqt4wtHB;
	}
}
