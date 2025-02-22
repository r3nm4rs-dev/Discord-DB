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
	// Token: 0x020000C1 RID: 193
	public class HuraControlBox : Control
	{
		// Token: 0x0600071C RID: 1820 RVA: 0x00008E54 File Offset: 0x00007054
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HuraControlBox()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			HuraControlBox.z1fu6aF1rS = new List<WeakReference>();
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00008E70 File Offset: 0x00007070
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void WDnuCEPqCj(object \u0020)
		{
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600071E RID: 1822 RVA: 0x00008E90 File Offset: 0x00007090
		// (remove) Token: 0x0600071F RID: 1823 RVA: 0x00008E98 File Offset: 0x00007098
		public event HuraControlBox.ColorSchemeChangedEventHandler ColorSchemeChanged
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

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00008EA0 File Offset: 0x000070A0
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00008EB4 File Offset: 0x000070B4
		public HuraControlBox.ColorSchemes ColorScheme
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (HuraControlBox.ColorSchemes)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00008EC4 File Offset: 0x000070C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnColorSchemeChanged()
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00008ED4 File Offset: 0x000070D4
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00008EE8 File Offset: 0x000070E8
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

		// Token: 0x06000725 RID: 1829 RVA: 0x00008EF0 File Offset: 0x000070F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HuraControlBox()
		{
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00008F00 File Offset: 0x00007100
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00008F10 File Offset: 0x00007110
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00008F20 File Offset: 0x00007120
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00008F30 File Offset: 0x00007130
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00008F40 File Offset: 0x00007140
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x0400031E RID: 798
		private static List<WeakReference> z1fu6aF1rS;

		// Token: 0x0400031F RID: 799
		private HuraControlBox.ColorSchemeChangedEventHandler bQMulvjPBv;

		// Token: 0x04000320 RID: 800
		private HuraControlBox.ColorSchemes Hm3uqncALN;

		// Token: 0x04000321 RID: 801
		private Color OipuLUPmMv;

		// Token: 0x04000322 RID: 802
		private HuraControlBox.ButtonHover hKKu851rWo;

		// Token: 0x020000C2 RID: 194
		public enum ColorSchemes
		{
			// Token: 0x04000324 RID: 804
			Dark
		}

		// Token: 0x020000C3 RID: 195
		public sealed class ColorSchemeChangedEventHandler : MulticastDelegate
		{
			// Token: 0x0600072B RID: 1835
			public extern ColorSchemeChangedEventHandler(object TargetObject, IntPtr TargetMethod);

			// Token: 0x0600072C RID: 1836
			public extern IAsyncResult BeginInvoke(AsyncCallback DelegateCallback, object DelegateAsyncState);

			// Token: 0x0600072D RID: 1837
			public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

			// Token: 0x0600072E RID: 1838
			public extern void Invoke();

			// Token: 0x0600072F RID: 1839 RVA: 0x00009410 File Offset: 0x00007610
			static ColorSchemeChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}

		// Token: 0x020000C4 RID: 196
		public enum ButtonHover
		{
			// Token: 0x04000326 RID: 806
			Minimize,
			// Token: 0x04000327 RID: 807
			Maximize,
			// Token: 0x04000328 RID: 808
			Close,
			// Token: 0x04000329 RID: 809
			None
		}
	}
}
