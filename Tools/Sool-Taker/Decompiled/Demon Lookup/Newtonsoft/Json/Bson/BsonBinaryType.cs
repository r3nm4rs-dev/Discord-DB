using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000328 RID: 808
	internal enum BsonBinaryType : byte
	{
		// Token: 0x04000E05 RID: 3589
		Binary,
		// Token: 0x04000E06 RID: 3590
		Function,
		// Token: 0x04000E07 RID: 3591
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		BinaryOld,
		// Token: 0x04000E08 RID: 3592
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		UuidOld,
		// Token: 0x04000E09 RID: 3593
		Uuid,
		// Token: 0x04000E0A RID: 3594
		Md5,
		// Token: 0x04000E0B RID: 3595
		UserDefined = 128
	}
}
