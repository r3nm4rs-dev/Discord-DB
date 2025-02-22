using System;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020002F3 RID: 755
	internal enum QueryOperator
	{
		// Token: 0x04000DA4 RID: 3492
		None,
		// Token: 0x04000DA5 RID: 3493
		Equals,
		// Token: 0x04000DA6 RID: 3494
		NotEquals,
		// Token: 0x04000DA7 RID: 3495
		Exists,
		// Token: 0x04000DA8 RID: 3496
		LessThan,
		// Token: 0x04000DA9 RID: 3497
		LessThanOrEquals,
		// Token: 0x04000DAA RID: 3498
		GreaterThan,
		// Token: 0x04000DAB RID: 3499
		GreaterThanOrEquals,
		// Token: 0x04000DAC RID: 3500
		And,
		// Token: 0x04000DAD RID: 3501
		Or
	}
}
