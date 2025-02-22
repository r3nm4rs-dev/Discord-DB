using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using UY3BiEArlp6B4GPt9k;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020001FA RID: 506
	internal class DynamicProxy<T>
	{
		// Token: 0x06001447 RID: 5191 RVA: 0x000139F0 File Offset: 0x00011BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IEnumerable<string> GetDynamicMemberNames(T instance)
		{
			return null;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x000139F8 File Offset: 0x00011BF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, out object result)
		{
			return true;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00013A00 File Offset: 0x00011C00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryConvert(T instance, ConvertBinder binder, out object result)
		{
			return true;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00013A08 File Offset: 0x00011C08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, out object result)
		{
			return true;
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00013A10 File Offset: 0x00011C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes)
		{
			return true;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00013A18 File Offset: 0x00011C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder)
		{
			return true;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00013A20 File Offset: 0x00011C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, out object result)
		{
			return true;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00013A28 File Offset: 0x00011C28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryGetMember(T instance, GetMemberBinder binder, out object result)
		{
			return true;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00013A30 File Offset: 0x00011C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, out object result)
		{
			return true;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00013A38 File Offset: 0x00011C38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, out object result)
		{
			return true;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00013A40 File Offset: 0x00011C40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value)
		{
			return true;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00013A48 File Offset: 0x00011C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value)
		{
			return true;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00013A50 File Offset: 0x00011C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, out object result)
		{
			return true;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00013A58 File Offset: 0x00011C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DynamicProxy()
		{
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00013A60 File Offset: 0x00011C60
		static DynamicProxy()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}
	}
}
