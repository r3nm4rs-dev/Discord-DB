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
	// Token: 0x02000466 RID: 1126
	public class ThirteenButton : Button
	{
		// Token: 0x060029CC RID: 10700 RVA: 0x000247F4 File Offset: 0x000229F4
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ThirteenButton()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			ThirteenButton.OBTxYrnGWsB = new List<WeakReference>();
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00024810 File Offset: 0x00022A10
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void FL5xYPUscTI(object \u0020)
		{
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x00024830 File Offset: 0x00022A30
		// (set) Token: 0x060029CF RID: 10703 RVA: 0x00024844 File Offset: 0x00022A44
		public ThirteenButton.ColorSchemes ColorScheme
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ThirteenButton.ColorSchemes)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x0002484C File Offset: 0x00022A4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00024854 File Offset: 0x00022A54
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x0002485C File Offset: 0x00022A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00024864 File Offset: 0x00022A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x0002486C File Offset: 0x00022A6C
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x00024880 File Offset: 0x00022A80
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

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060029D6 RID: 10710 RVA: 0x00024888 File Offset: 0x00022A88
		// (remove) Token: 0x060029D7 RID: 10711 RVA: 0x00024890 File Offset: 0x00022A90
		public event ThirteenButton.AccentColorChangedEventHandler AccentColorChanged
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

		// Token: 0x060029D8 RID: 10712 RVA: 0x00024898 File Offset: 0x00022A98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ThirteenButton()
		{
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000248A8 File Offset: 0x00022AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000248B8 File Offset: 0x00022AB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnAccentColorChanged()
		{
		}

		// Token: 0x040011C9 RID: 4553
		private static List<WeakReference> OBTxYrnGWsB;

		// Token: 0x040011CA RID: 4554
		private ThirteenButton.ColorSchemes tXDxYpGhTI1;

		// Token: 0x040011CB RID: 4555
		private ThirteenButton.MouseState gOHxYMtGFst;

		// Token: 0x040011CC RID: 4556
		private Color hA7xYOuV3gM;

		// Token: 0x040011CD RID: 4557
		private ThirteenButton.AccentColorChangedEventHandler wS5xYvpNpO1;

		// Token: 0x02000467 RID: 1127
		public enum MouseState
		{
			// Token: 0x040011CF RID: 4559
			None,
			// Token: 0x040011D0 RID: 4560
			Over,
			// Token: 0x040011D1 RID: 4561
			Down
		}

		// Token: 0x02000468 RID: 1128
		public enum ColorSchemes
		{
			// Token: 0x040011D3 RID: 4563
			Light,
			// Token: 0x040011D4 RID: 4564
			Dark
		}

		// Token: 0x02000469 RID: 1129
		public sealed class AccentColorChangedEventHandler : MulticastDelegate
		{
			// Token: 0x060029DB RID: 10715
			public extern AccentColorChangedEventHandler(object TargetObject, IntPtr TargetMethod);

			// Token: 0x060029DC RID: 10716
			public extern IAsyncResult BeginInvoke(AsyncCallback DelegateCallback, object DelegateAsyncState);

			// Token: 0x060029DD RID: 10717
			public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

			// Token: 0x060029DE RID: 10718
			public extern void Invoke();

			// Token: 0x060029DF RID: 10719 RVA: 0x00024D44 File Offset: 0x00022F44
			static AccentColorChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}
	}
}
