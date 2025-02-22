using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using UY3BiEArlp6B4GPt9k;

namespace Plot.Anima
{
	// Token: 0x02000362 RID: 866
	public class Anima
	{
		// Token: 0x0600208E RID: 8334 RVA: 0x0001E118 File Offset: 0x0001C318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Anima()
		{
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x0001E120 File Offset: 0x0001C320
		static Anima()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x02000363 RID: 867
		public class AnimaListView : Control
		{
			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x06002090 RID: 8336 RVA: 0x0001E1B8 File Offset: 0x0001C3B8
			// (set) Token: 0x06002091 RID: 8337 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
			public string[] Columns
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x06002092 RID: 8338 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
			// (set) Token: 0x06002093 RID: 8339 RVA: 0x0001E1D0 File Offset: 0x0001C3D0
			public ListViewItem[] Items
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x06002094 RID: 8340 RVA: 0x0001E1D8 File Offset: 0x0001C3D8
			// (set) Token: 0x06002095 RID: 8341 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
			public int ColumnWidth
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x06002096 RID: 8342 RVA: 0x0001E1E8 File Offset: 0x0001C3E8
			// (set) Token: 0x06002097 RID: 8343 RVA: 0x0001E1F0 File Offset: 0x0001C3F0
			public int SelectedIndex
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x06002098 RID: 8344 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
			// (set) Token: 0x06002099 RID: 8345 RVA: 0x0001E200 File Offset: 0x0001C400
			public List<int> SelectedIndexes
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x0600209A RID: 8346 RVA: 0x0001E208 File Offset: 0x0001C408
			// (set) Token: 0x0600209B RID: 8347 RVA: 0x0001E210 File Offset: 0x0001C410
			public bool Multiselect
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x0600209C RID: 8348 RVA: 0x0001E218 File Offset: 0x0001C418
			// (set) Token: 0x0600209D RID: 8349 RVA: 0x0001E220 File Offset: 0x0001C420
			public int Highlight
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x0600209E RID: 8350 RVA: 0x0001E228 File Offset: 0x0001C428
			// (set) Token: 0x0600209F RID: 8351 RVA: 0x0001E230 File Offset: 0x0001C430
			public bool HandleItemsForeColor
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0001E238 File Offset: 0x0001C438
			// (set) Token: 0x060020A1 RID: 8353 RVA: 0x0001E240 File Offset: 0x0001C440
			public bool Grid
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x060020A2 RID: 8354 RVA: 0x0001E248 File Offset: 0x0001C448
			// (set) Token: 0x060020A3 RID: 8355 RVA: 0x0001E250 File Offset: 0x0001C450
			public int ItemSize
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x060020A4 RID: 8356 RVA: 0x0001E258 File Offset: 0x0001C458
			public int SelectedCount
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0001E268 File Offset: 0x0001C468
			public ListViewItem FocusedItem
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
			}

			// Token: 0x060020A6 RID: 8358 RVA: 0x0001E278 File Offset: 0x0001C478
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Add(ListViewItem Item)
			{
			}

			// Token: 0x1400002B RID: 43
			// (add) Token: 0x060020A7 RID: 8359 RVA: 0x0001E288 File Offset: 0x0001C488
			// (remove) Token: 0x060020A8 RID: 8360 RVA: 0x0001E298 File Offset: 0x0001C498
			public event Anima.AnimaListView.SelectedIndexChangedEventHandler SelectedIndexChanged
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

			// Token: 0x060020A9 RID: 8361 RVA: 0x0001E2A8 File Offset: 0x0001C4A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaListView()
			{
			}

			// Token: 0x060020AA RID: 8362 RVA: 0x0001E2B8 File Offset: 0x0001C4B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			private SolidBrush OCuZcdJEXq(int \u0020, ListViewItem \u0020)
			{
				return null;
			}

			// Token: 0x060020AB RID: 8363 RVA: 0x0001E2C8 File Offset: 0x0001C4C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			private SolidBrush tecZHAevU6(int \u0020, ListViewItem.ListViewSubItem \u0020)
			{
				return null;
			}

			// Token: 0x060020AC RID: 8364 RVA: 0x0001E2D8 File Offset: 0x0001C4D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x060020AD RID: 8365 RVA: 0x0001E40C File Offset: 0x0001C60C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseUp(MouseEventArgs e)
			{
			}

			// Token: 0x060020AE RID: 8366 RVA: 0x0001E41C File Offset: 0x0001C61C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private int TKUZYC4WAr(Point \u0020)
			{
				return 0;
			}

			// Token: 0x060020AF RID: 8367 RVA: 0x0001E42C File Offset: 0x0001C62C
			static AnimaListView()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EAB RID: 3755
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string[] TI9ZP5NkQc;

			// Token: 0x04000EAC RID: 3756
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private ListViewItem[] SJuZrw98B6;

			// Token: 0x04000EAD RID: 3757
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int Qw2ZpkjWEl;

			// Token: 0x04000EAE RID: 3758
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private int ec7ZM1Tuju;

			// Token: 0x04000EAF RID: 3759
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<int> G2JZOox980;

			// Token: 0x04000EB0 RID: 3760
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool HjPZvukIiG;

			// Token: 0x04000EB1 RID: 3761
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int hrhZF9kayL;

			// Token: 0x04000EB2 RID: 3762
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool RBaZ0vUDNm;

			// Token: 0x04000EB3 RID: 3763
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool GmUZuIYdEp;

			// Token: 0x04000EB4 RID: 3764
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int ssCZ7sEsSY;

			// Token: 0x04000EB5 RID: 3765
			private int wWLZ1UfncB;

			// Token: 0x04000EB6 RID: 3766
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.AnimaListView.SelectedIndexChangedEventHandler D4lZiGSsik;

			// Token: 0x02000364 RID: 868
			public sealed class SelectedIndexChangedEventHandler : MulticastDelegate
			{
				// Token: 0x060020B0 RID: 8368
				public extern SelectedIndexChangedEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x060020B1 RID: 8369
				public extern IAsyncResult BeginInvoke(object Sender, int Index, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x060020B2 RID: 8370
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x060020B3 RID: 8371
				public extern void Invoke(object Sender, int Index);

				// Token: 0x060020B4 RID: 8372 RVA: 0x0001EE08 File Offset: 0x0001D008
				static SelectedIndexChangedEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}
		}

		// Token: 0x02000365 RID: 869
		public class AnimaTextBox : Control
		{
			// Token: 0x060020B5 RID: 8373 RVA: 0x0001E434 File Offset: 0x0001C634
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private virtual TextBox gXBHGcmOVYl()
			{
				return null;
			}

			// Token: 0x060020B6 RID: 8374 RVA: 0x0001E43C File Offset: 0x0001C63C
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			private virtual void wwCHGqwdJgO(TextBox WithEventsValue)
			{
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0001E44C File Offset: 0x0001C64C
			// (set) Token: 0x060020B8 RID: 8376 RVA: 0x0001E454 File Offset: 0x0001C654
			public bool Dark
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0001E45C File Offset: 0x0001C65C
			// (set) Token: 0x060020BA RID: 8378 RVA: 0x0001E464 File Offset: 0x0001C664
			public bool Numeric
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x060020BB RID: 8379 RVA: 0x0001E46C File Offset: 0x0001C66C
			// (set) Token: 0x060020BC RID: 8380 RVA: 0x0001E47C File Offset: 0x0001C67C
			public new string Text
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

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x060020BD RID: 8381 RVA: 0x0001E484 File Offset: 0x0001C684
			// (set) Token: 0x060020BE RID: 8382 RVA: 0x0001E494 File Offset: 0x0001C694
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

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x060020BF RID: 8383 RVA: 0x0001E49C File Offset: 0x0001C69C
			// (set) Token: 0x060020C0 RID: 8384 RVA: 0x0001E4AC File Offset: 0x0001C6AC
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

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0001E4B4 File Offset: 0x0001C6B4
			// (set) Token: 0x060020C2 RID: 8386 RVA: 0x0001E4C4 File Offset: 0x0001C6C4
			public bool MultiLine
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

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0001E4D4 File Offset: 0x0001C6D4
			// (set) Token: 0x060020C4 RID: 8388 RVA: 0x0001E4E4 File Offset: 0x0001C6E4
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

			// Token: 0x060020C5 RID: 8389 RVA: 0x0001E4EC File Offset: 0x0001C6EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaTextBox()
			{
			}

			// Token: 0x060020C6 RID: 8390 RVA: 0x0001E4FC File Offset: 0x0001C6FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CreateHandle()
			{
			}

			// Token: 0x060020C7 RID: 8391 RVA: 0x0001E50C File Offset: 0x0001C70C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnEnter(EventArgs e)
			{
			}

			// Token: 0x060020C8 RID: 8392 RVA: 0x0001E514 File Offset: 0x0001C714
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x060020C9 RID: 8393 RVA: 0x0001E564 File Offset: 0x0001C764
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void BbiZU7EQqM()
			{
			}

			// Token: 0x060020CA RID: 8394 RVA: 0x0001E574 File Offset: 0x0001C774
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void NBGZIGjSpa(object \u0020, KeyPressEventArgs \u0020)
			{
			}

			// Token: 0x060020CB RID: 8395 RVA: 0x0001E584 File Offset: 0x0001C784
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void qi6ZNr7blk()
			{
			}

			// Token: 0x060020CC RID: 8396 RVA: 0x0001E58C File Offset: 0x0001C78C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnResize(EventArgs e)
			{
			}

			// Token: 0x060020CD RID: 8397 RVA: 0x0001E59C File Offset: 0x0001C79C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void RexZmVmbZ4()
			{
			}

			// Token: 0x060020CE RID: 8398 RVA: 0x0001E5A4 File Offset: 0x0001C7A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void JkhZVxLtZZ()
			{
			}

			// Token: 0x060020CF RID: 8399 RVA: 0x0001E5B4 File Offset: 0x0001C7B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void xUXZ99m9Eo()
			{
			}

			// Token: 0x060020D3 RID: 8403 RVA: 0x0001E5DC File Offset: 0x0001C7DC
			static AnimaTextBox()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EB7 RID: 3767
			private Graphics wMpZ2dPXCO;

			// Token: 0x04000EB8 RID: 3768
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[AccessedThroughProperty("T")]
			private TextBox QfVZgOw3ii;

			// Token: 0x04000EB9 RID: 3769
			private Thread JtSZCYAk1T;

			// Token: 0x04000EBA RID: 3770
			private Thread pqeZ63tv97;

			// Token: 0x04000EBB RID: 3771
			private int[] IXJZlXFa1s;

			// Token: 0x04000EBC RID: 3772
			private int S2ZZqMEZjm;

			// Token: 0x04000EBD RID: 3773
			private bool frGZLOCKik;

			// Token: 0x04000EBE RID: 3774
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool IybZ8sVlSH;

			// Token: 0x04000EBF RID: 3775
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool RJcZbG1pWF;
		}

		// Token: 0x02000366 RID: 870
		public class AnimaProgressBar : ProgressBar
		{
			// Token: 0x060020D4 RID: 8404 RVA: 0x0001E5E4 File Offset: 0x0001C7E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaProgressBar()
			{
			}

			// Token: 0x060020D5 RID: 8405 RVA: 0x0001E5EC File Offset: 0x0001C7EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x060020D6 RID: 8406 RVA: 0x0001E618 File Offset: 0x0001C818
			static AnimaProgressBar()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EC0 RID: 3776
			private Graphics uGNZ4GAA3v;
		}

		// Token: 0x02000367 RID: 871
		public class AnimaCheckBox : CheckBox
		{
			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0001E620 File Offset: 0x0001C820
			// (set) Token: 0x060020D8 RID: 8408 RVA: 0x0001E628 File Offset: 0x0001C828
			public bool Radio
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0001E630 File Offset: 0x0001C830
			// (set) Token: 0x060020DA RID: 8410 RVA: 0x0001E638 File Offset: 0x0001C838
			public bool Caution
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return true;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x060020DB RID: 8411 RVA: 0x0001E640 File Offset: 0x0001C840
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaCheckBox()
			{
			}

			// Token: 0x060020DC RID: 8412 RVA: 0x0001E650 File Offset: 0x0001C850
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x060020DD RID: 8413 RVA: 0x0001E694 File Offset: 0x0001C894
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseEnter(EventArgs e)
			{
			}

			// Token: 0x060020DE RID: 8414 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseLeave(EventArgs e)
			{
			}

			// Token: 0x060020DF RID: 8415 RVA: 0x0001E6AC File Offset: 0x0001C8AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseUp(MouseEventArgs e)
			{
			}

			// Token: 0x060020E0 RID: 8416 RVA: 0x0001E6CC File Offset: 0x0001C8CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void jP8ZX6yG6a()
			{
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x0001E6DC File Offset: 0x0001C8DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void Ku2ZGYLmN1()
			{
			}

			// Token: 0x060020E2 RID: 8418 RVA: 0x0001E6EC File Offset: 0x0001C8EC
			static AnimaCheckBox()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EC1 RID: 3777
			private Graphics f10ZdvoYwy;

			// Token: 0x04000EC2 RID: 3778
			private Thread HuOZjLKXG4;

			// Token: 0x04000EC3 RID: 3779
			private Thread hnLZyobkbr;

			// Token: 0x04000EC4 RID: 3780
			private int[] zXuZfxfgbk;

			// Token: 0x04000EC5 RID: 3781
			private bool hnyZac218L;

			// Token: 0x04000EC6 RID: 3782
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool m1UZnAgOlv;

			// Token: 0x04000EC7 RID: 3783
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private bool bNXZ5A68u3;
		}

		// Token: 0x02000368 RID: 872
		public class AnimaHeader : Control
		{
			// Token: 0x060020E3 RID: 8419 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaHeader()
			{
			}

			// Token: 0x060020E4 RID: 8420 RVA: 0x0001E704 File Offset: 0x0001C904
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x060020E5 RID: 8421 RVA: 0x0001E73C File Offset: 0x0001C93C
			static AnimaHeader()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EC8 RID: 3784
			private Graphics UYTZW0cvtO;
		}

		// Token: 0x02000369 RID: 873
		public class AnimaForm : ContainerControl
		{
			// Token: 0x060020E6 RID: 8422 RVA: 0x0001E744 File Offset: 0x0001C944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaForm()
			{
			}

			// Token: 0x060020E7 RID: 8423 RVA: 0x0001E754 File Offset: 0x0001C954
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnCreateControl()
			{
			}

			// Token: 0x060020E8 RID: 8424 RVA: 0x0001E75C File Offset: 0x0001C95C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x060020E9 RID: 8425 RVA: 0x0001E7A0 File Offset: 0x0001C9A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseDown(MouseEventArgs e)
			{
			}

			// Token: 0x060020EA RID: 8426 RVA: 0x0001E7B0 File Offset: 0x0001C9B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseUp(MouseEventArgs e)
			{
			}

			// Token: 0x060020EB RID: 8427 RVA: 0x0001E7C0 File Offset: 0x0001C9C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseMove(MouseEventArgs e)
			{
			}

			// Token: 0x060020EC RID: 8428 RVA: 0x0001E7D0 File Offset: 0x0001C9D0
			static AnimaForm()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EC9 RID: 3785
			private Graphics UcpZsr4NFa;

			// Token: 0x04000ECA RID: 3786
			private bool uoVZkG5bTE;

			// Token: 0x04000ECB RID: 3787
			private Point tRNZeUkIX0;

			// Token: 0x04000ECC RID: 3788
			private Point vWaZoN4fIX;
		}

		// Token: 0x0200036A RID: 874
		public class AnimaButton : Button
		{
			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x060020ED RID: 8429 RVA: 0x0001E7D8 File Offset: 0x0001C9D8
			// (set) Token: 0x060020EE RID: 8430 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
			public Point ImageLocation
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return (Point)null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x060020EF RID: 8431 RVA: 0x0001E7EC File Offset: 0x0001C9EC
			// (set) Token: 0x060020F0 RID: 8432 RVA: 0x0001E7F8 File Offset: 0x0001C9F8
			public Size ImageSize
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return (Size)null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x060020F1 RID: 8433 RVA: 0x0001E800 File Offset: 0x0001CA00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaButton()
			{
			}

			// Token: 0x060020F2 RID: 8434 RVA: 0x0001E810 File Offset: 0x0001CA10
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x060020F3 RID: 8435 RVA: 0x0001E854 File Offset: 0x0001CA54
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseEnter(EventArgs e)
			{
			}

			// Token: 0x060020F4 RID: 8436 RVA: 0x0001E864 File Offset: 0x0001CA64
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseLeave(EventArgs e)
			{
			}

			// Token: 0x060020F5 RID: 8437 RVA: 0x0001E86C File Offset: 0x0001CA6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseDown(MouseEventArgs e)
			{
			}

			// Token: 0x060020F6 RID: 8438 RVA: 0x0001E87C File Offset: 0x0001CA7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void FGSZACv1Vr(Point \u0020)
			{
			}

			// Token: 0x060020F7 RID: 8439 RVA: 0x0001E88C File Offset: 0x0001CA8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void XrqZEq9RXe()
			{
			}

			// Token: 0x060020F8 RID: 8440 RVA: 0x0001E89C File Offset: 0x0001CA9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void KegZK9BX26()
			{
			}

			// Token: 0x060020F9 RID: 8441 RVA: 0x0001E8AC File Offset: 0x0001CAAC
			static AnimaButton()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000ECD RID: 3789
			private Graphics zuRZDVPFfY;

			// Token: 0x04000ECE RID: 3790
			private Thread QtmZZqjHqN;

			// Token: 0x04000ECF RID: 3791
			private Thread fP5Zh2v8rs;

			// Token: 0x04000ED0 RID: 3792
			private Thread eC8ZQe9u4D;

			// Token: 0x04000ED1 RID: 3793
			private int[] gYwZ3OJSnk;

			// Token: 0x04000ED2 RID: 3794
			private Point KOWZSuoxiA;

			// Token: 0x04000ED3 RID: 3795
			private Size BXUZTFnw9I;

			// Token: 0x04000ED4 RID: 3796
			private bool i1RZRXFy8U;

			// Token: 0x04000ED5 RID: 3797
			private bool hkMZwG7EoI;

			// Token: 0x04000ED6 RID: 3798
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Point MxYZBX5qjt;

			// Token: 0x04000ED7 RID: 3799
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Size eY5ZJwc5uo;
		}

		// Token: 0x0200036C RID: 876
		public class Renderer : ToolStripRenderer
		{
			// Token: 0x060020FD RID: 8445 RVA: 0x0001E8B4 File Offset: 0x0001CAB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Renderer()
			{
			}

			// Token: 0x1400002C RID: 44
			// (add) Token: 0x060020FE RID: 8446 RVA: 0x0001E8BC File Offset: 0x0001CABC
			// (remove) Token: 0x060020FF RID: 8447 RVA: 0x0001E8CC File Offset: 0x0001CACC
			public event Anima.Renderer.PaintMenuBackgroundEventHandler PaintMenuBackground
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

			// Token: 0x1400002D RID: 45
			// (add) Token: 0x06002100 RID: 8448 RVA: 0x0001E8DC File Offset: 0x0001CADC
			// (remove) Token: 0x06002101 RID: 8449 RVA: 0x0001E8EC File Offset: 0x0001CAEC
			public event Anima.Renderer.PaintMenuBorderEventHandler PaintMenuBorder
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

			// Token: 0x1400002E RID: 46
			// (add) Token: 0x06002102 RID: 8450 RVA: 0x0001E8FC File Offset: 0x0001CAFC
			// (remove) Token: 0x06002103 RID: 8451 RVA: 0x0001E90C File Offset: 0x0001CB0C
			public event Anima.Renderer.PaintMenuImageMarginEventHandler PaintMenuImageMargin
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

			// Token: 0x1400002F RID: 47
			// (add) Token: 0x06002104 RID: 8452 RVA: 0x0001E91C File Offset: 0x0001CB1C
			// (remove) Token: 0x06002105 RID: 8453 RVA: 0x0001E92C File Offset: 0x0001CB2C
			public event Anima.Renderer.PaintItemCheckEventHandler PaintItemCheck
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

			// Token: 0x14000030 RID: 48
			// (add) Token: 0x06002106 RID: 8454 RVA: 0x0001E93C File Offset: 0x0001CB3C
			// (remove) Token: 0x06002107 RID: 8455 RVA: 0x0001E94C File Offset: 0x0001CB4C
			public event Anima.Renderer.PaintItemImageEventHandler PaintItemImage
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

			// Token: 0x14000031 RID: 49
			// (add) Token: 0x06002108 RID: 8456 RVA: 0x0001E95C File Offset: 0x0001CB5C
			// (remove) Token: 0x06002109 RID: 8457 RVA: 0x0001E96C File Offset: 0x0001CB6C
			public event Anima.Renderer.PaintItemTextEventHandler PaintItemText
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

			// Token: 0x14000032 RID: 50
			// (add) Token: 0x0600210A RID: 8458 RVA: 0x0001E97C File Offset: 0x0001CB7C
			// (remove) Token: 0x0600210B RID: 8459 RVA: 0x0001E98C File Offset: 0x0001CB8C
			public event Anima.Renderer.PaintItemBackgroundEventHandler PaintItemBackground
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

			// Token: 0x14000033 RID: 51
			// (add) Token: 0x0600210C RID: 8460 RVA: 0x0001E99C File Offset: 0x0001CB9C
			// (remove) Token: 0x0600210D RID: 8461 RVA: 0x0001E9AC File Offset: 0x0001CBAC
			public event Anima.Renderer.PaintItemArrowEventHandler PaintItemArrow
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

			// Token: 0x14000034 RID: 52
			// (add) Token: 0x0600210E RID: 8462 RVA: 0x0001E9BC File Offset: 0x0001CBBC
			// (remove) Token: 0x0600210F RID: 8463 RVA: 0x0001E9CC File Offset: 0x0001CBCC
			public event Anima.Renderer.PaintSeparatorEventHandler PaintSeparator
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

			// Token: 0x06002110 RID: 8464 RVA: 0x0001E9DC File Offset: 0x0001CBDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
			{
			}

			// Token: 0x06002111 RID: 8465 RVA: 0x0001E9EC File Offset: 0x0001CBEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
			{
			}

			// Token: 0x06002112 RID: 8466 RVA: 0x0001E9FC File Offset: 0x0001CBFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
			{
			}

			// Token: 0x06002113 RID: 8467 RVA: 0x0001EA0C File Offset: 0x0001CC0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
			{
			}

			// Token: 0x06002114 RID: 8468 RVA: 0x0001EA1C File Offset: 0x0001CC1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
			{
			}

			// Token: 0x06002115 RID: 8469 RVA: 0x0001EA2C File Offset: 0x0001CC2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
			{
			}

			// Token: 0x06002116 RID: 8470 RVA: 0x0001EA3C File Offset: 0x0001CC3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
			{
			}

			// Token: 0x06002117 RID: 8471 RVA: 0x0001EA4C File Offset: 0x0001CC4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
			{
			}

			// Token: 0x06002118 RID: 8472 RVA: 0x0001EA5C File Offset: 0x0001CC5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
			{
			}

			// Token: 0x06002119 RID: 8473 RVA: 0x0001EA6C File Offset: 0x0001CC6C
			static Renderer()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EDA RID: 3802
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.Renderer.PaintMenuBackgroundEventHandler v0rZzwBknl;

			// Token: 0x04000EDB RID: 3803
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.Renderer.PaintMenuBorderEventHandler ARZht1nK0Z;

			// Token: 0x04000EDC RID: 3804
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.Renderer.PaintMenuImageMarginEventHandler ij3hxMrubE;

			// Token: 0x04000EDD RID: 3805
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.Renderer.PaintItemCheckEventHandler Y2DhcUqkXI;

			// Token: 0x04000EDE RID: 3806
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Anima.Renderer.PaintItemImageEventHandler OS2hHiJRdm;

			// Token: 0x04000EDF RID: 3807
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.Renderer.PaintItemTextEventHandler QIohY5VZBg;

			// Token: 0x04000EE0 RID: 3808
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Anima.Renderer.PaintItemBackgroundEventHandler CJihPgMkGF;

			// Token: 0x04000EE1 RID: 3809
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.Renderer.PaintItemArrowEventHandler RFehrbu66p;

			// Token: 0x04000EE2 RID: 3810
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.Renderer.PaintSeparatorEventHandler zjYhpt6C30;

			// Token: 0x0200036D RID: 877
			public sealed class PaintMenuBackgroundEventHandler : MulticastDelegate
			{
				// Token: 0x0600211A RID: 8474
				public extern PaintMenuBackgroundEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x0600211B RID: 8475
				public extern IAsyncResult BeginInvoke(object sender, ToolStripRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x0600211C RID: 8476
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x0600211D RID: 8477
				public extern void Invoke(object sender, ToolStripRenderEventArgs e);

				// Token: 0x0600211E RID: 8478 RVA: 0x0001EE28 File Offset: 0x0001D028
				static PaintMenuBackgroundEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}

			// Token: 0x0200036E RID: 878
			public sealed class PaintMenuBorderEventHandler : MulticastDelegate
			{
				// Token: 0x0600211F RID: 8479
				public extern PaintMenuBorderEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x06002120 RID: 8480
				public extern IAsyncResult BeginInvoke(object sender, ToolStripRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x06002121 RID: 8481
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x06002122 RID: 8482
				public extern void Invoke(object sender, ToolStripRenderEventArgs e);

				// Token: 0x06002123 RID: 8483 RVA: 0x0001EE30 File Offset: 0x0001D030
				static PaintMenuBorderEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}

			// Token: 0x0200036F RID: 879
			public sealed class PaintMenuImageMarginEventHandler : MulticastDelegate
			{
				// Token: 0x06002124 RID: 8484
				public extern PaintMenuImageMarginEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x06002125 RID: 8485
				public extern IAsyncResult BeginInvoke(object sender, ToolStripRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x06002126 RID: 8486
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x06002127 RID: 8487
				public extern void Invoke(object sender, ToolStripRenderEventArgs e);

				// Token: 0x06002128 RID: 8488 RVA: 0x0001EE38 File Offset: 0x0001D038
				static PaintMenuImageMarginEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}

			// Token: 0x02000370 RID: 880
			public sealed class PaintItemCheckEventHandler : MulticastDelegate
			{
				// Token: 0x06002129 RID: 8489
				public extern PaintItemCheckEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x0600212A RID: 8490
				public extern IAsyncResult BeginInvoke(object sender, ToolStripItemImageRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x0600212B RID: 8491
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x0600212C RID: 8492
				public extern void Invoke(object sender, ToolStripItemImageRenderEventArgs e);

				// Token: 0x0600212D RID: 8493 RVA: 0x0001EE40 File Offset: 0x0001D040
				static PaintItemCheckEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}

			// Token: 0x02000371 RID: 881
			public sealed class PaintItemImageEventHandler : MulticastDelegate
			{
				// Token: 0x0600212E RID: 8494
				public extern PaintItemImageEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x0600212F RID: 8495
				public extern IAsyncResult BeginInvoke(object sender, ToolStripItemImageRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x06002130 RID: 8496
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x06002131 RID: 8497
				public extern void Invoke(object sender, ToolStripItemImageRenderEventArgs e);

				// Token: 0x06002132 RID: 8498 RVA: 0x0001EE48 File Offset: 0x0001D048
				static PaintItemImageEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}

			// Token: 0x02000372 RID: 882
			public sealed class PaintItemTextEventHandler : MulticastDelegate
			{
				// Token: 0x06002133 RID: 8499
				public extern PaintItemTextEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x06002134 RID: 8500
				public extern IAsyncResult BeginInvoke(object sender, ToolStripItemTextRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x06002135 RID: 8501
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x06002136 RID: 8502
				public extern void Invoke(object sender, ToolStripItemTextRenderEventArgs e);

				// Token: 0x06002137 RID: 8503 RVA: 0x0001EE50 File Offset: 0x0001D050
				static PaintItemTextEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}

			// Token: 0x02000373 RID: 883
			public sealed class PaintItemBackgroundEventHandler : MulticastDelegate
			{
				// Token: 0x06002138 RID: 8504
				public extern PaintItemBackgroundEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x06002139 RID: 8505
				public extern IAsyncResult BeginInvoke(object sender, ToolStripItemRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x0600213A RID: 8506
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x0600213B RID: 8507
				public extern void Invoke(object sender, ToolStripItemRenderEventArgs e);

				// Token: 0x0600213C RID: 8508 RVA: 0x0001EE58 File Offset: 0x0001D058
				static PaintItemBackgroundEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}

			// Token: 0x02000374 RID: 884
			public sealed class PaintItemArrowEventHandler : MulticastDelegate
			{
				// Token: 0x0600213D RID: 8509
				public extern PaintItemArrowEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x0600213E RID: 8510
				public extern IAsyncResult BeginInvoke(object sender, ToolStripArrowRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x0600213F RID: 8511
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x06002140 RID: 8512
				public extern void Invoke(object sender, ToolStripArrowRenderEventArgs e);

				// Token: 0x06002141 RID: 8513 RVA: 0x0001EE60 File Offset: 0x0001D060
				static PaintItemArrowEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}

			// Token: 0x02000375 RID: 885
			public sealed class PaintSeparatorEventHandler : MulticastDelegate
			{
				// Token: 0x06002142 RID: 8514
				public extern PaintSeparatorEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x06002143 RID: 8515
				public extern IAsyncResult BeginInvoke(object sender, ToolStripSeparatorRenderEventArgs e, AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x06002144 RID: 8516
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x06002145 RID: 8517
				public extern void Invoke(object sender, ToolStripSeparatorRenderEventArgs e);

				// Token: 0x06002146 RID: 8518 RVA: 0x0001EE68 File Offset: 0x0001D068
				static PaintSeparatorEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}
		}

		// Token: 0x02000376 RID: 886
		public class AnimaContextMenuStrip : ContextMenuStrip
		{
			// Token: 0x06002147 RID: 8519 RVA: 0x0001EA74 File Offset: 0x0001CC74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaContextMenuStrip()
			{
			}

			// Token: 0x06002148 RID: 8520 RVA: 0x0001EA84 File Offset: 0x0001CC84
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void c5hhMYBVvN(object \u0020, ToolStripArrowRenderEventArgs \u0020)
			{
			}

			// Token: 0x06002149 RID: 8521 RVA: 0x0001EAB0 File Offset: 0x0001CCB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void SnshObaSPP(object \u0020, ToolStripRenderEventArgs \u0020)
			{
			}

			// Token: 0x0600214A RID: 8522 RVA: 0x0001EAB8 File Offset: 0x0001CCB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void IpDhv47EQe(object \u0020, ToolStripRenderEventArgs \u0020)
			{
			}

			// Token: 0x0600214B RID: 8523 RVA: 0x0001EAD8 File Offset: 0x0001CCD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void FGdhFnV5gJ(object \u0020, ToolStripItemImageRenderEventArgs \u0020)
			{
			}

			// Token: 0x0600214C RID: 8524 RVA: 0x0001EAE0 File Offset: 0x0001CCE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void N3Jh0AgeE0(object \u0020, ToolStripItemTextRenderEventArgs \u0020)
			{
			}

			// Token: 0x0600214D RID: 8525 RVA: 0x0001EB00 File Offset: 0x0001CD00
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void D3HhuTV4sK(object \u0020, ToolStripItemRenderEventArgs \u0020)
			{
			}

			// Token: 0x0600214E RID: 8526 RVA: 0x0001EB20 File Offset: 0x0001CD20
			static AnimaContextMenuStrip()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EE3 RID: 3811
			private Graphics hqWh7o27lE;

			// Token: 0x04000EE4 RID: 3812
			private Rectangle Gwyh1wGSKc;
		}

		// Token: 0x02000377 RID: 887
		public class AnimaStatusBar : Control
		{
			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x0600214F RID: 8527 RVA: 0x0001EB28 File Offset: 0x0001CD28
			// (set) Token: 0x06002150 RID: 8528 RVA: 0x0001EB34 File Offset: 0x0001CD34
			public Anima.AnimaStatusBar.Types Type
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return (Anima.AnimaStatusBar.Types)null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x06002151 RID: 8529 RVA: 0x0001EB3C File Offset: 0x0001CD3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaStatusBar()
			{
			}

			// Token: 0x06002152 RID: 8530 RVA: 0x0001EB4C File Offset: 0x0001CD4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x06002153 RID: 8531 RVA: 0x0001EB90 File Offset: 0x0001CD90
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnTextChanged(EventArgs e)
			{
			}

			// Token: 0x06002154 RID: 8532 RVA: 0x0001EB98 File Offset: 0x0001CD98
			static AnimaStatusBar()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EE5 RID: 3813
			private Graphics W6khiGSDLJ;

			// Token: 0x04000EE6 RID: 3814
			private Color DSchUFcZr1;

			// Token: 0x04000EE7 RID: 3815
			private Color ASchIpXP0Q;

			// Token: 0x04000EE8 RID: 3816
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.AnimaStatusBar.Types OZxhN9BPN5;

			// Token: 0x02000378 RID: 888
			public enum Types : byte
			{
				// Token: 0x04000EEA RID: 3818
				Basic,
				// Token: 0x04000EEB RID: 3819
				Warning,
				// Token: 0x04000EEC RID: 3820
				Wrong,
				// Token: 0x04000EED RID: 3821
				Success
			}
		}

		// Token: 0x02000379 RID: 889
		public class AnimaTabControl : TabControl
		{
			// Token: 0x06002155 RID: 8533 RVA: 0x0001EBA0 File Offset: 0x0001CDA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnControlAdded(ControlEventArgs e)
			{
			}

			// Token: 0x06002156 RID: 8534 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaTabControl()
			{
			}

			// Token: 0x06002157 RID: 8535 RVA: 0x0001EBC0 File Offset: 0x0001CDC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x06002158 RID: 8536 RVA: 0x0001EC04 File Offset: 0x0001CE04
			static AnimaTabControl()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EEE RID: 3822
			private Graphics qQGhmry9CQ;

			// Token: 0x04000EEF RID: 3823
			private Rectangle ioYhVxZ4AB;
		}

		// Token: 0x0200037A RID: 890
		public class AnimaGroupBox : Control
		{
			// Token: 0x06002159 RID: 8537 RVA: 0x0001EC0C File Offset: 0x0001CE0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaGroupBox()
			{
			}

			// Token: 0x0600215A RID: 8538 RVA: 0x0001EC1C File Offset: 0x0001CE1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x0600215B RID: 8539 RVA: 0x0001EC60 File Offset: 0x0001CE60
			static AnimaGroupBox()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}

		// Token: 0x0200037B RID: 891
		public class AnimaControlBox : Control
		{
			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x0600215C RID: 8540 RVA: 0x0001EC68 File Offset: 0x0001CE68
			// (set) Token: 0x0600215D RID: 8541 RVA: 0x0001EC70 File Offset: 0x0001CE70
			public int TextHeight
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x0600215E RID: 8542 RVA: 0x0001EC78 File Offset: 0x0001CE78
			// (set) Token: 0x0600215F RID: 8543 RVA: 0x0001EC80 File Offset: 0x0001CE80
			public int ComboHeight
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06002160 RID: 8544 RVA: 0x0001EC88 File Offset: 0x0001CE88
			// (set) Token: 0x06002161 RID: 8545 RVA: 0x0001EC90 File Offset: 0x0001CE90
			public string[] Items
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06002162 RID: 8546 RVA: 0x0001EC98 File Offset: 0x0001CE98
			// (set) Token: 0x06002163 RID: 8547 RVA: 0x0001ECA0 File Offset: 0x0001CEA0
			public int SelectedIndex
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06002164 RID: 8548 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
			// (set) Token: 0x06002165 RID: 8549 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
			public int ItemSize
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x06002166 RID: 8550 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
			// (set) Token: 0x06002167 RID: 8551 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
			public string SelectedItem
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x06002168 RID: 8552 RVA: 0x0001ECC8 File Offset: 0x0001CEC8
			// (set) Token: 0x06002169 RID: 8553 RVA: 0x0001ECD0 File Offset: 0x0001CED0
			public Anima.AnimaGroupBox AnimaGroupBoxContainer
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x0600216A RID: 8554 RVA: 0x0001ECD8 File Offset: 0x0001CED8
			// (set) Token: 0x0600216B RID: 8555 RVA: 0x0001ECE4 File Offset: 0x0001CEE4
			public Point CurrentLocation
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return (Point)null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
				}
			}

			// Token: 0x14000035 RID: 53
			// (add) Token: 0x0600216C RID: 8556 RVA: 0x0001ECEC File Offset: 0x0001CEEC
			// (remove) Token: 0x0600216D RID: 8557 RVA: 0x0001ECFC File Offset: 0x0001CEFC
			public event Anima.AnimaControlBox.SelectedIndexChangedEventHandler SelectedIndexChanged
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

			// Token: 0x0600216E RID: 8558 RVA: 0x0001ED0C File Offset: 0x0001CF0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AnimaControlBox()
			{
			}

			// Token: 0x0600216F RID: 8559 RVA: 0x0001ED1C File Offset: 0x0001CF1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnPaint(PaintEventArgs e)
			{
			}

			// Token: 0x06002170 RID: 8560 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnLostFocus(EventArgs e)
			{
			}

			// Token: 0x06002171 RID: 8561 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseDown(MouseEventArgs e)
			{
			}

			// Token: 0x06002172 RID: 8562 RVA: 0x0001EDF0 File Offset: 0x0001CFF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnMouseMove(MouseEventArgs e)
			{
			}

			// Token: 0x06002173 RID: 8563 RVA: 0x0001EE00 File Offset: 0x0001D000
			static AnimaControlBox()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}

			// Token: 0x04000EF0 RID: 3824
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private int ss9h9EMlcV;

			// Token: 0x04000EF1 RID: 3825
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private int XA7h2Ud0eL;

			// Token: 0x04000EF2 RID: 3826
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string[] q3PhgSThoh;

			// Token: 0x04000EF3 RID: 3827
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int X6LhCE6tmE;

			// Token: 0x04000EF4 RID: 3828
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private int Rtlh6GMZXb;

			// Token: 0x04000EF5 RID: 3829
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string mokhlZ5UqC;

			// Token: 0x04000EF6 RID: 3830
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Anima.AnimaGroupBox JfFhqHSYum;

			// Token: 0x04000EF7 RID: 3831
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private Point CEghLuYu50;

			// Token: 0x04000EF8 RID: 3832
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private Anima.AnimaControlBox.SelectedIndexChangedEventHandler oMXh88C1De;

			// Token: 0x04000EF9 RID: 3833
			private bool lM7hbtFlLW;

			// Token: 0x04000EFA RID: 3834
			private int U1qh4sfFy4;

			// Token: 0x04000EFB RID: 3835
			private int caDhXvYiKu;

			// Token: 0x0200037C RID: 892
			public sealed class SelectedIndexChangedEventHandler : MulticastDelegate
			{
				// Token: 0x06002174 RID: 8564
				public extern SelectedIndexChangedEventHandler(object TargetObject, IntPtr TargetMethod);

				// Token: 0x06002175 RID: 8565
				public extern IAsyncResult BeginInvoke(AsyncCallback DelegateCallback, object DelegateAsyncState);

				// Token: 0x06002176 RID: 8566
				public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

				// Token: 0x06002177 RID: 8567
				public extern void Invoke();

				// Token: 0x06002178 RID: 8568 RVA: 0x0001EE70 File Offset: 0x0001D070
				static SelectedIndexChangedEventHandler()
				{
					nCP5vtxT3QjsSeuiK3.SLMriFgIx();
				}
			}
		}
	}
}
