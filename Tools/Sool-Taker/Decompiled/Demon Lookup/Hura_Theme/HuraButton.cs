using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Hura_Theme
{
	// Token: 0x020000C5 RID: 197
	public class HuraButton : Button
	{
		// Token: 0x06000730 RID: 1840 RVA: 0x00008F48 File Offset: 0x00007148
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HuraButton()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			HuraButton.sNou4G4aUq = new List<WeakReference>();
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00008F64 File Offset: 0x00007164
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void a8tuby7Fwr(object \u0020)
		{
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00008F84 File Offset: 0x00007184
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00008F98 File Offset: 0x00007198
		public HuraButton.ColorSchemes ColorScheme
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (HuraButton.ColorSchemes)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00008FA0 File Offset: 0x000071A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00008FA8 File Offset: 0x000071A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00008FB0 File Offset: 0x000071B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00008FB8 File Offset: 0x000071B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00008FC0 File Offset: 0x000071C0
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00008FD4 File Offset: 0x000071D4
		public Color AccentColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600073A RID: 1850 RVA: 0x00008FDC File Offset: 0x000071DC
		// (remove) Token: 0x0600073B RID: 1851 RVA: 0x00008FE4 File Offset: 0x000071E4
		public event HuraButton.AccentColorChangedEventHandler AccentColorChanged
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

		// Token: 0x0600073C RID: 1852 RVA: 0x00008FEC File Offset: 0x000071EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HuraButton()
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00008FFC File Offset: 0x000071FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0000900C File Offset: 0x0000720C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnAccentColorChanged()
		{
		}

		// Token: 0x0400032A RID: 810
		private static List<WeakReference> sNou4G4aUq;

		// Token: 0x0400032B RID: 811
		private HuraButton.ColorSchemes Iv3uXZ1esi;

		// Token: 0x0400032C RID: 812
		private HuraButton.MouseState cCHuGGp5G6;

		// Token: 0x0400032D RID: 813
		private Color g6Dudg865u;

		// Token: 0x0400032E RID: 814
		private HuraButton.AccentColorChangedEventHandler ddSujcWsXe;

		// Token: 0x020000C6 RID: 198
		public enum MouseState
		{
			// Token: 0x04000330 RID: 816
			None,
			// Token: 0x04000331 RID: 817
			Over,
			// Token: 0x04000332 RID: 818
			Down
		}

		// Token: 0x020000C7 RID: 199
		public enum ColorSchemes
		{
			// Token: 0x04000334 RID: 820
			Dark
		}

		// Token: 0x020000C8 RID: 200
		public sealed class AccentColorChangedEventHandler : MulticastDelegate
		{
			// Token: 0x0600073F RID: 1855
			public extern AccentColorChangedEventHandler(object TargetObject, IntPtr TargetMethod);

			// Token: 0x06000740 RID: 1856
			public extern IAsyncResult BeginInvoke(AsyncCallback DelegateCallback, object DelegateAsyncState);

			// Token: 0x06000741 RID: 1857
			public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

			// Token: 0x06000742 RID: 1858
			public extern void Invoke();

			// Token: 0x06000743 RID: 1859 RVA: 0x00009418 File Offset: 0x00007618
			static AccentColorChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}
	}
}
