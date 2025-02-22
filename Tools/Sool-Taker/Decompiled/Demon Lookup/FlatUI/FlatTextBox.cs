using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UY3BiEArlp6B4GPt9k;

namespace FlatUI
{
	// Token: 0x020000A1 RID: 161
	[DefaultEvent("TextChanged")]
	public class FlatTextBox : Control
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00007BC0 File Offset: 0x00005DC0
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00007BD4 File Offset: 0x00005DD4
		[Category("Options")]
		public HorizontalAlignment TextAlign
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (HorizontalAlignment)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00007BE4 File Offset: 0x00005DE4
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00007BF4 File Offset: 0x00005DF4
		[Category("Options")]
		public int MaxLength
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

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00007C04 File Offset: 0x00005E04
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00007C14 File Offset: 0x00005E14
		[Category("Options")]
		public bool ReadOnly
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00007C24 File Offset: 0x00005E24
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00007C34 File Offset: 0x00005E34
		[Category("Options")]
		public bool UseSystemPasswordChar
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00007C44 File Offset: 0x00005E44
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00007C54 File Offset: 0x00005E54
		[Category("Options")]
		public bool Multiline
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

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00007C64 File Offset: 0x00005E64
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00007C74 File Offset: 0x00005E74
		[Category("Options")]
		public bool FocusOnHover
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00007C7C File Offset: 0x00005E7C
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00007C8C File Offset: 0x00005E8C
		[Category("Options")]
		public override string Text
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00007C9C File Offset: 0x00005E9C
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00007CAC File Offset: 0x00005EAC
		[Category("Options")]
		public override Font Font
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00007CBC File Offset: 0x00005EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnCreateControl()
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00007CCC File Offset: 0x00005ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void zy9Fj5diyL(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00007CD4 File Offset: 0x00005ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void naFFy6RjNH(object \u0020, KeyEventArgs \u0020)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00007CE4 File Offset: 0x00005EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00007CF4 File Offset: 0x00005EF4
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00007D08 File Offset: 0x00005F08
		[Category("Colors")]
		public Color TextColor
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

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00007D10 File Offset: 0x00005F10
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00007D24 File Offset: 0x00005F24
		public override Color ForeColor
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

		// Token: 0x06000643 RID: 1603 RVA: 0x00007D2C File Offset: 0x00005F2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00007D34 File Offset: 0x00005F34
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00007D3C File Offset: 0x00005F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00007D4C File Offset: 0x00005F4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00007D54 File Offset: 0x00005F54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlatTextBox()
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00007D64 File Offset: 0x00005F64
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00007D74 File Offset: 0x00005F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MjbFfU1lWn()
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00007D84 File Offset: 0x00005F84
		static FlatTextBox()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x040002A1 RID: 673
		private int GG1FaJKEtg;

		// Token: 0x040002A2 RID: 674
		private int YsHFnMM6FK;

		// Token: 0x040002A3 RID: 675
		private MouseState lH5F5dKv7D;

		// Token: 0x040002A4 RID: 676
		private TextBox jFJFWHc5Qq;

		// Token: 0x040002A5 RID: 677
		private HorizontalAlignment YnyFs8C3M0;

		// Token: 0x040002A6 RID: 678
		private int rXpFkN76nq;

		// Token: 0x040002A7 RID: 679
		private bool IwsFeEKjqt;

		// Token: 0x040002A8 RID: 680
		private bool lVNFo47Twg;

		// Token: 0x040002A9 RID: 681
		private bool NYIFAn7Plv;

		// Token: 0x040002AA RID: 682
		private bool lBRFEorPeh;

		// Token: 0x040002AB RID: 683
		private Color PcEFKa38hF;

		// Token: 0x040002AC RID: 684
		private Color GHDFDQshgq;

		// Token: 0x040002AD RID: 685
		private Color djTFZWOFs8;
	}
}
