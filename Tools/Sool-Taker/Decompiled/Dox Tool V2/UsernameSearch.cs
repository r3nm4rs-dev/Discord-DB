using System;

namespace Dox_Tool_V2
{
	// Token: 0x0200002B RID: 43
	public class UsernameSearch
	{
		// Token: 0x06000337 RID: 823 RVA: 0x0001224D File Offset: 0x0001044D
		public UsernameSearch(string userSearch)
		{
			this.functions = new Functions();
			this.username = userSearch;
		}

		// Token: 0x04000155 RID: 341
		private object username;

		// Token: 0x04000156 RID: 342
		private Functions functions;
	}
}
