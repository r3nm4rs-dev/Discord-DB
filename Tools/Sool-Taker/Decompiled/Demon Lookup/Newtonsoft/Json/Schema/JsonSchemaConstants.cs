using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200029B RID: 667
	[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
	internal static class JsonSchemaConstants
	{
		// Token: 0x06001992 RID: 6546 RVA: 0x000172B0 File Offset: 0x000154B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JsonSchemaConstants()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			JsonSchemaConstants.JsonSchemaTypeMapping = new Dictionary<string, JsonSchemaType>
			{
				{
					"string",
					JsonSchemaType.String
				},
				{
					"object",
					JsonSchemaType.Object
				},
				{
					"integer",
					JsonSchemaType.Integer
				},
				{
					"number",
					JsonSchemaType.Float
				},
				{
					"null",
					JsonSchemaType.Null
				},
				{
					"boolean",
					JsonSchemaType.Boolean
				},
				{
					"array",
					JsonSchemaType.Array
				},
				{
					"any",
					JsonSchemaType.Any
				}
			};
		}

		// Token: 0x04000BEF RID: 3055
		public const string TypePropertyName = "type";

		// Token: 0x04000BF0 RID: 3056
		public const string PropertiesPropertyName = "properties";

		// Token: 0x04000BF1 RID: 3057
		public const string ItemsPropertyName = "items";

		// Token: 0x04000BF2 RID: 3058
		public const string AdditionalItemsPropertyName = "additionalItems";

		// Token: 0x04000BF3 RID: 3059
		public const string RequiredPropertyName = "required";

		// Token: 0x04000BF4 RID: 3060
		public const string PatternPropertiesPropertyName = "patternProperties";

		// Token: 0x04000BF5 RID: 3061
		public const string AdditionalPropertiesPropertyName = "additionalProperties";

		// Token: 0x04000BF6 RID: 3062
		public const string RequiresPropertyName = "requires";

		// Token: 0x04000BF7 RID: 3063
		public const string MinimumPropertyName = "minimum";

		// Token: 0x04000BF8 RID: 3064
		public const string MaximumPropertyName = "maximum";

		// Token: 0x04000BF9 RID: 3065
		public const string ExclusiveMinimumPropertyName = "exclusiveMinimum";

		// Token: 0x04000BFA RID: 3066
		public const string ExclusiveMaximumPropertyName = "exclusiveMaximum";

		// Token: 0x04000BFB RID: 3067
		public const string MinimumItemsPropertyName = "minItems";

		// Token: 0x04000BFC RID: 3068
		public const string MaximumItemsPropertyName = "maxItems";

		// Token: 0x04000BFD RID: 3069
		public const string PatternPropertyName = "pattern";

		// Token: 0x04000BFE RID: 3070
		public const string MaximumLengthPropertyName = "maxLength";

		// Token: 0x04000BFF RID: 3071
		public const string MinimumLengthPropertyName = "minLength";

		// Token: 0x04000C00 RID: 3072
		public const string EnumPropertyName = "enum";

		// Token: 0x04000C01 RID: 3073
		public const string ReadOnlyPropertyName = "readonly";

		// Token: 0x04000C02 RID: 3074
		public const string TitlePropertyName = "title";

		// Token: 0x04000C03 RID: 3075
		public const string DescriptionPropertyName = "description";

		// Token: 0x04000C04 RID: 3076
		public const string FormatPropertyName = "format";

		// Token: 0x04000C05 RID: 3077
		public const string DefaultPropertyName = "default";

		// Token: 0x04000C06 RID: 3078
		public const string TransientPropertyName = "transient";

		// Token: 0x04000C07 RID: 3079
		public const string DivisibleByPropertyName = "divisibleBy";

		// Token: 0x04000C08 RID: 3080
		public const string HiddenPropertyName = "hidden";

		// Token: 0x04000C09 RID: 3081
		public const string DisallowPropertyName = "disallow";

		// Token: 0x04000C0A RID: 3082
		public const string ExtendsPropertyName = "extends";

		// Token: 0x04000C0B RID: 3083
		public const string IdPropertyName = "id";

		// Token: 0x04000C0C RID: 3084
		public const string UniqueItemsPropertyName = "uniqueItems";

		// Token: 0x04000C0D RID: 3085
		public const string OptionValuePropertyName = "value";

		// Token: 0x04000C0E RID: 3086
		public const string OptionLabelPropertyName = "label";

		// Token: 0x04000C0F RID: 3087
		public static readonly IDictionary<string, JsonSchemaType> JsonSchemaTypeMapping;
	}
}
