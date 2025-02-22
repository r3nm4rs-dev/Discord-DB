using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Teen
{
	// Token: 0x0200046D RID: 1133
	public class ThirteenTabControl : TabControl
	{
		// Token: 0x060029ED RID: 10733 RVA: 0x00024950 File Offset: 0x00022B50
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ThirteenTabControl()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			ThirteenTabControl.zkgxYigTGvY = new List<WeakReference>();
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x0002496C File Offset: 0x00022B6C
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void wiExY1gIEri(object \u0020)
		{
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x0002498C File Offset: 0x00022B8C
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x000249A0 File Offset: 0x00022BA0
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

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x060029F1 RID: 10737 RVA: 0x000249A8 File Offset: 0x00022BA8
		// (remove) Token: 0x060029F2 RID: 10738 RVA: 0x000249B0 File Offset: 0x00022BB0
		public event ThirteenTabControl.ColorSchemeChangedEventHandler ColorSchemeChanged
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

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000249B8 File Offset: 0x00022BB8
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x000249CC File Offset: 0x00022BCC
		public ThirteenTabControl.ColorSchemes ColorScheme
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ThirteenTabControl.ColorSchemes)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000249DC File Offset: 0x00022BDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnColorSchemeChanged()
		{
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000249EC File Offset: 0x00022BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ThirteenTabControl()
		{
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000249FC File Offset: 0x00022BFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x040011DB RID: 4571
		private static List<WeakReference> zkgxYigTGvY;

		// Token: 0x040011DC RID: 4572
		private Color wKyxYUarWAC;

		// Token: 0x040011DD RID: 4573
		private Color OmHxYIfmOTB;

		// Token: 0x040011DE RID: 4574
		private Color KgFxYNPdfUg;

		// Token: 0x040011DF RID: 4575
		private ThirteenTabControl.ColorSchemeChangedEventHandler dsrxYmeMPlC;

		// Token: 0x040011E0 RID: 4576
		private ThirteenTabControl.ColorSchemes HE9xYVriFkT;

		// Token: 0x0200046E RID: 1134
		public enum ColorSchemes
		{
			// Token: 0x040011E2 RID: 4578
			Light,
			// Token: 0x040011E3 RID: 4579
			Dark
		}

		// Token: 0x0200046F RID: 1135
		public sealed class ColorSchemeChangedEventHandler : MulticastDelegate
		{
			// Token: 0x060029F8 RID: 10744
			public extern ColorSchemeChangedEventHandler(object TargetObject, IntPtr TargetMethod);

			// Token: 0x060029F9 RID: 10745
			public extern IAsyncResult BeginInvoke(AsyncCallback DelegateCallback, object DelegateAsyncState);

			// Token: 0x060029FA RID: 10746
			public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

			// Token: 0x060029FB RID: 10747
			public extern void Invoke();

			// Token: 0x060029FC RID: 10748 RVA: 0x00024D54 File Offset: 0x00022F54
			static ColorSchemeChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}
	}
}
