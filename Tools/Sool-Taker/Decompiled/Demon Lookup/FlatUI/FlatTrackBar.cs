using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UY3BiEArlp6B4GPt9k;

namespace FlatUI
{
	// Token: 0x020000A5 RID: 165
	[DefaultEvent("Scroll")]
	public class FlatTrackBar : Control
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x00007E58 File Offset: 0x00006058
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00007E68 File Offset: 0x00006068
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00007E78 File Offset: 0x00006078
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00007E80 File Offset: 0x00006080
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00007E94 File Offset: 0x00006094
		public FlatTrackBar._Style Style
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FlatTrackBar._Style)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00007E9C File Offset: 0x0000609C
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00007EB0 File Offset: 0x000060B0
		[Category("Colors")]
		public Color TrackColor
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00007EB8 File Offset: 0x000060B8
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00007ECC File Offset: 0x000060CC
		[Category("Colors")]
		public Color HatchColor
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

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600066A RID: 1642 RVA: 0x00007ED4 File Offset: 0x000060D4
		// (remove) Token: 0x0600066B RID: 1643 RVA: 0x00007EE4 File Offset: 0x000060E4
		public event FlatTrackBar.ScrollEventHandler Scroll
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00007EF4 File Offset: 0x000060F4
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00007F04 File Offset: 0x00006104
		public int Minimum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00007F14 File Offset: 0x00006114
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00007F24 File Offset: 0x00006124
		public int Maximum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00007F34 File Offset: 0x00006134
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00007F44 File Offset: 0x00006144
		public int Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00007F54 File Offset: 0x00006154
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00007F64 File Offset: 0x00006164
		public bool ShowValue
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

		// Token: 0x06000674 RID: 1652 RVA: 0x00007F6C File Offset: 0x0000616C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnKeyDown(KeyEventArgs e)
		{
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00007F7C File Offset: 0x0000617C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnTextChanged(EventArgs e)
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00007F84 File Offset: 0x00006184
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00007F8C File Offset: 0x0000618C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlatTrackBar()
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00007F9C File Offset: 0x0000619C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00007FAC File Offset: 0x000061AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void L120ciBs4m()
		{
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00007FBC File Offset: 0x000061BC
		static FlatTrackBar()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040002BF RID: 703
		private int udb0HLTj7a;

		// Token: 0x040002C0 RID: 704
		private int GuD0YA6sNg;

		// Token: 0x040002C1 RID: 705
		private int eUn0P02W8b;

		// Token: 0x040002C2 RID: 706
		private bool QmV0rQil4R;

		// Token: 0x040002C3 RID: 707
		private Rectangle UaS0pRp3DF;

		// Token: 0x040002C4 RID: 708
		private Rectangle kPx0MaysKY;

		// Token: 0x040002C5 RID: 709
		private FlatTrackBar._Style fPe0O05cWA;

		// Token: 0x040002C6 RID: 710
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private FlatTrackBar.ScrollEventHandler ps40v2swXo;

		// Token: 0x040002C7 RID: 711
		private int z3w0FGQXFS;

		// Token: 0x040002C8 RID: 712
		private int dFs00KG6QA;

		// Token: 0x040002C9 RID: 713
		private int rXN0uoNGNb;

		// Token: 0x040002CA RID: 714
		private bool lVn07FiAlh;

		// Token: 0x040002CB RID: 715
		private Color YYd01KCsGf;

		// Token: 0x040002CC RID: 716
		private Color lgc0ix6oMu;

		// Token: 0x040002CD RID: 717
		private Color cCY0UMpWap;

		// Token: 0x040002CE RID: 718
		private Color rR80IlLP8r;

		// Token: 0x020000A6 RID: 166
		[Flags]
		public enum _Style
		{
			// Token: 0x040002D0 RID: 720
			Slider = 0,
			// Token: 0x040002D1 RID: 721
			Knob = 1
		}

		// Token: 0x020000A7 RID: 167
		public sealed class ScrollEventHandler : MulticastDelegate
		{
			// Token: 0x0600067B RID: 1659
			public extern ScrollEventHandler(object @object, IntPtr method);

			// Token: 0x0600067C RID: 1660
			public extern void Invoke(object sender);

			// Token: 0x0600067D RID: 1661
			public extern IAsyncResult BeginInvoke(object sender, AsyncCallback callback, object @object);

			// Token: 0x0600067E RID: 1662
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x0600067F RID: 1663 RVA: 0x00008414 File Offset: 0x00006614
			static ScrollEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}
	}
}
