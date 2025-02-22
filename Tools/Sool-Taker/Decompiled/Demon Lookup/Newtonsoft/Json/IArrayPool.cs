using System;

namespace Newtonsoft.Json
{
	// Token: 0x0200016F RID: 367
	public interface IArrayPool<T>
	{
		// Token: 0x06000E8B RID: 3723
		T[] Rent(int minimumLength);

		// Token: 0x06000E8C RID: 3724
		void Return(T[] array);
	}
}
