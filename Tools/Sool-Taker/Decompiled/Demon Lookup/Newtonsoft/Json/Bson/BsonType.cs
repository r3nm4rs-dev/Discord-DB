using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000338 RID: 824
	internal enum BsonType : sbyte
	{
		// Token: 0x04000E3F RID: 3647
		Number = 1,
		// Token: 0x04000E40 RID: 3648
		String,
		// Token: 0x04000E41 RID: 3649
		Object,
		// Token: 0x04000E42 RID: 3650
		Array,
		// Token: 0x04000E43 RID: 3651
		Binary,
		// Token: 0x04000E44 RID: 3652
		Undefined,
		// Token: 0x04000E45 RID: 3653
		Oid,
		// Token: 0x04000E46 RID: 3654
		Boolean,
		// Token: 0x04000E47 RID: 3655
		Date,
		// Token: 0x04000E48 RID: 3656
		Null,
		// Token: 0x04000E49 RID: 3657
		Regex,
		// Token: 0x04000E4A RID: 3658
		Reference,
		// Token: 0x04000E4B RID: 3659
		Code,
		// Token: 0x04000E4C RID: 3660
		Symbol,
		// Token: 0x04000E4D RID: 3661
		CodeWScope,
		// Token: 0x04000E4E RID: 3662
		Integer,
		// Token: 0x04000E4F RID: 3663
		TimeStamp,
		// Token: 0x04000E50 RID: 3664
		Long,
		// Token: 0x04000E51 RID: 3665
		MinKey = -1,
		// Token: 0x04000E52 RID: 3666
		MaxKey = 127
	}
}
