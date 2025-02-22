using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UY3BiEArlp6B4GPt9k;

namespace FlatUI
{
	// Token: 0x020000AC RID: 172
	[DefaultEvent("CheckedChanged")]
	public class FlatRadioButton : Control
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x000081B4 File Offset: 0x000063B4
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x000081C4 File Offset: 0x000063C4
		public bool Checked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600069D RID: 1693 RVA: 0x000081D4 File Offset: 0x000063D4
		// (remove) Token: 0x0600069E RID: 1694 RVA: 0x000081E4 File Offset: 0x000063E4
		public event FlatRadioButton.CheckedChangedEventHandler CheckedChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000081F4 File Offset: 0x000063F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00008204 File Offset: 0x00006404
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OCP0j50fsA()
		{
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00008224 File Offset: 0x00006424
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnCreateControl()
		{
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0000822C File Offset: 0x0000642C
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x00008240 File Offset: 0x00006440
		[Category("Options")]
		public FlatRadioButton._Options Options
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FlatRadioButton._Options)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00008248 File Offset: 0x00006448
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00008250 File Offset: 0x00006450
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00008258 File Offset: 0x00006458
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00008260 File Offset: 0x00006460
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00008268 File Offset: 0x00006468
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00008270 File Offset: 0x00006470
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlatRadioButton()
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00008280 File Offset: 0x00006480
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00008290 File Offset: 0x00006490
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AwF0yrKKTp()
		{
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000082A0 File Offset: 0x000064A0
		static FlatRadioButton()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040002EB RID: 747
		private MouseState hKt0f8x8nG;

		// Token: 0x040002EC RID: 748
		private int G3G0arJSoh;

		// Token: 0x040002ED RID: 749
		private int mQq0nq0wY7;

		// Token: 0x040002EE RID: 750
		private FlatRadioButton._Options gxN05ZCULa;

		// Token: 0x040002EF RID: 751
		private bool zCB0WDlh4e;

		// Token: 0x040002F0 RID: 752
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FlatRadioButton.CheckedChangedEventHandler qGF0sR0AfE;

		// Token: 0x040002F1 RID: 753
		private Color JNe0kLH8qe;

		// Token: 0x040002F2 RID: 754
		private Color Rb00eEuSnj;

		// Token: 0x040002F3 RID: 755
		private Color ohr0oPsoNy;

		// Token: 0x020000AD RID: 173
		public sealed class CheckedChangedEventHandler : MulticastDelegate
		{
			// Token: 0x060006AD RID: 1709
			public extern CheckedChangedEventHandler(object @object, IntPtr method);

			// Token: 0x060006AE RID: 1710
			public extern void Invoke(object sender);

			// Token: 0x060006AF RID: 1711
			public extern IAsyncResult BeginInvoke(object sender, AsyncCallback callback, object @object);

			// Token: 0x060006B0 RID: 1712
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x060006B1 RID: 1713 RVA: 0x0000841C File Offset: 0x0000661C
			static CheckedChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}

		// Token: 0x020000AE RID: 174
		[Flags]
		public enum _Options
		{
			// Token: 0x040002F5 RID: 757
			Style1 = 0,
			// Token: 0x040002F6 RID: 758
			Style2 = 1
		}
	}
}
