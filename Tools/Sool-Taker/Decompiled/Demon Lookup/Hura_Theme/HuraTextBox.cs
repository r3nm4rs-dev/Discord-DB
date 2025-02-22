using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Hura_Theme
{
	// Token: 0x020000CC RID: 204
	public class HuraTextBox : TextBox
	{
		// Token: 0x06000756 RID: 1878 RVA: 0x00009104 File Offset: 0x00007304
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HuraTextBox()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			HuraTextBox.CsDuQiorhK = new List<WeakReference>();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00009120 File Offset: 0x00007320
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void VAGuhaCJRP(object \u0020)
		{
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000758 RID: 1880 RVA: 0x00009140 File Offset: 0x00007340
		// (remove) Token: 0x06000759 RID: 1881 RVA: 0x00009148 File Offset: 0x00007348
		public event HuraTextBox.ColorSchemeChangedEventHandler ColorSchemeChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00009150 File Offset: 0x00007350
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00009164 File Offset: 0x00007364
		public HuraTextBox.ColorSchemes ColorScheme
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (HuraTextBox.ColorSchemes)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00009174 File Offset: 0x00007374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HuraTextBox()
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00009184 File Offset: 0x00007384
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnColorSchemeChanged()
		{
		}

		// Token: 0x04000342 RID: 834
		private static List<WeakReference> CsDuQiorhK;

		// Token: 0x04000343 RID: 835
		private HuraTextBox.ColorSchemeChangedEventHandler Co1u332rBO;

		// Token: 0x04000344 RID: 836
		private HuraTextBox.ColorSchemes HrkuSB8rvW;

		// Token: 0x020000CD RID: 205
		public enum ColorSchemes
		{
			// Token: 0x04000346 RID: 838
			Light,
			// Token: 0x04000347 RID: 839
			Dark
		}

		// Token: 0x020000CE RID: 206
		public sealed class ColorSchemeChangedEventHandler : MulticastDelegate
		{
			// Token: 0x0600075E RID: 1886
			public extern ColorSchemeChangedEventHandler(object TargetObject, IntPtr TargetMethod);

			// Token: 0x0600075F RID: 1887
			public extern IAsyncResult BeginInvoke(AsyncCallback DelegateCallback, object DelegateAsyncState);

			// Token: 0x06000760 RID: 1888
			public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

			// Token: 0x06000761 RID: 1889
			public extern void Invoke();

			// Token: 0x06000762 RID: 1890 RVA: 0x00009428 File Offset: 0x00007628
			static ColorSchemeChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}
	}
}
