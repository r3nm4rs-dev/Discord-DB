using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UY3BiEArlp6B4GPt9k;

namespace FlatUI
{
	// Token: 0x020000A2 RID: 162
	[DefaultEvent("CheckedChanged")]
	public class FlatToggle : Control
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600064B RID: 1611 RVA: 0x00007D8C File Offset: 0x00005F8C
		// (remove) Token: 0x0600064C RID: 1612 RVA: 0x00007D9C File Offset: 0x00005F9C
		public event FlatToggle.CheckedChangedEventHandler CheckedChanged
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

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00007DAC File Offset: 0x00005FAC
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00007DC0 File Offset: 0x00005FC0
		[Category("Options")]
		public FlatToggle._Options Options
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FlatToggle._Options)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00007DC8 File Offset: 0x00005FC8
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00007DD8 File Offset: 0x00005FD8
		[Category("Options")]
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

		// Token: 0x06000651 RID: 1617 RVA: 0x00007DE0 File Offset: 0x00005FE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnTextChanged(EventArgs e)
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00007DF0 File Offset: 0x00005FF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00007DF8 File Offset: 0x00005FF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00007E00 File Offset: 0x00006000
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00007E08 File Offset: 0x00006008
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00007E10 File Offset: 0x00006010
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00007E20 File Offset: 0x00006020
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlatToggle()
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00007E30 File Offset: 0x00006030
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00007E40 File Offset: 0x00006040
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void bXYFh4x4Et()
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00007E50 File Offset: 0x00006050
		static FlatToggle()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040002AE RID: 686
		private int FeIFQDgPOF;

		// Token: 0x040002AF RID: 687
		private int B4WF3vdsws;

		// Token: 0x040002B0 RID: 688
		private FlatToggle._Options KBIFSQRvrl;

		// Token: 0x040002B1 RID: 689
		private bool XEUFTl5MsB;

		// Token: 0x040002B2 RID: 690
		private MouseState bqrFRMTUh6;

		// Token: 0x040002B3 RID: 691
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private FlatToggle.CheckedChangedEventHandler w3MFwAAlaX;

		// Token: 0x040002B4 RID: 692
		private Color ynbFB6HEvU;

		// Token: 0x040002B5 RID: 693
		private Color BqSFJdm3uG;

		// Token: 0x040002B6 RID: 694
		private Color vhHFzViBQy;

		// Token: 0x040002B7 RID: 695
		private Color pGp0tnSntt;

		// Token: 0x040002B8 RID: 696
		private Color K2a0xEfCH5;

		// Token: 0x020000A3 RID: 163
		public sealed class CheckedChangedEventHandler : MulticastDelegate
		{
			// Token: 0x0600065C RID: 1628
			public extern CheckedChangedEventHandler(object @object, IntPtr method);

			// Token: 0x0600065D RID: 1629
			public extern void Invoke(object sender);

			// Token: 0x0600065E RID: 1630
			public extern IAsyncResult BeginInvoke(object sender, AsyncCallback callback, object @object);

			// Token: 0x0600065F RID: 1631
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000660 RID: 1632 RVA: 0x0000840C File Offset: 0x0000660C
			static CheckedChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}

		// Token: 0x020000A4 RID: 164
		[Flags]
		public enum _Options
		{
			// Token: 0x040002BA RID: 698
			Style1 = 0,
			// Token: 0x040002BB RID: 699
			Style2 = 1,
			// Token: 0x040002BC RID: 700
			Style3 = 2,
			// Token: 0x040002BD RID: 701
			Style4 = 3,
			// Token: 0x040002BE RID: 702
			Style5 = 4
		}
	}
}
