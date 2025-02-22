using System;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000267 RID: 615
	public interface IReferenceResolver
	{
		// Token: 0x060016E3 RID: 5859
		object ResolveReference(object context, string reference);

		// Token: 0x060016E4 RID: 5860
		string GetReference(object context, object value);

		// Token: 0x060016E5 RID: 5861
		bool IsReferenced(object context, object value);

		// Token: 0x060016E6 RID: 5862
		void AddReference(object context, string reference, object value);
	}
}
