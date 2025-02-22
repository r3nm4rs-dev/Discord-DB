using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UY3BiEArlp6B4GPt9k;

namespace FlatUI
{
	// Token: 0x0200008E RID: 142
	[DefaultEvent("CheckedChanged")]
	public class FlatCheckBox : Control
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x00007080 File Offset: 0x00005280
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnTextChanged(EventArgs e)
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00007088 File Offset: 0x00005288
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00007098 File Offset: 0x00005298
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

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600053B RID: 1339 RVA: 0x000070A0 File Offset: 0x000052A0
		// (remove) Token: 0x0600053C RID: 1340 RVA: 0x000070B0 File Offset: 0x000052B0
		public event FlatCheckBox.CheckedChangedEventHandler CheckedChanged
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

		// Token: 0x0600053D RID: 1341 RVA: 0x000070C0 File Offset: 0x000052C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnClick(EventArgs e)
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x000070D0 File Offset: 0x000052D0
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x000070E4 File Offset: 0x000052E4
		[Category("Options")]
		public FlatCheckBox._Options Options
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FlatCheckBox._Options)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000070EC File Offset: 0x000052EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000070F4 File Offset: 0x000052F4
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00007108 File Offset: 0x00005308
		[Category("Colors")]
		public Color BaseColor
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00007110 File Offset: 0x00005310
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00007124 File Offset: 0x00005324
		[Category("Colors")]
		public Color BorderColor
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

		// Token: 0x06000545 RID: 1349 RVA: 0x0000712C File Offset: 0x0000532C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseDown(MouseEventArgs e)
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00007134 File Offset: 0x00005334
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0000713C File Offset: 0x0000533C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseEnter(EventArgs e)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00007144 File Offset: 0x00005344
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000714C File Offset: 0x0000534C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FlatCheckBox()
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000715C File Offset: 0x0000535C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000716C File Offset: 0x0000536C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void zopOSYZ4G6()
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000717C File Offset: 0x0000537C
		static FlatCheckBox()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x04000242 RID: 578
		private int QWfOT1x5fP;

		// Token: 0x04000243 RID: 579
		private int x2HOReWFgG;

		// Token: 0x04000244 RID: 580
		private MouseState kqDOwd9LWE;

		// Token: 0x04000245 RID: 581
		private FlatCheckBox._Options s2qOBD3wsx;

		// Token: 0x04000246 RID: 582
		private bool P3bOJiq4iD;

		// Token: 0x04000247 RID: 583
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private FlatCheckBox.CheckedChangedEventHandler hTMOznX9S4;

		// Token: 0x04000248 RID: 584
		private Color riZvtJRiKE;

		// Token: 0x04000249 RID: 585
		private Color QiHvx7HsY6;

		// Token: 0x0400024A RID: 586
		private Color lq2vcW4xne;

		// Token: 0x0200008F RID: 143
		public sealed class CheckedChangedEventHandler : MulticastDelegate
		{
			// Token: 0x0600054D RID: 1357
			public extern CheckedChangedEventHandler(object @object, IntPtr method);

			// Token: 0x0600054E RID: 1358
			public extern void Invoke(object sender);

			// Token: 0x0600054F RID: 1359
			public extern IAsyncResult BeginInvoke(object sender, AsyncCallback callback, object @object);

			// Token: 0x06000550 RID: 1360
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000551 RID: 1361 RVA: 0x000082A8 File Offset: 0x000064A8
			static CheckedChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}

		// Token: 0x02000090 RID: 144
		[Flags]
		public enum _Options
		{
			// Token: 0x0400024C RID: 588
			Style1 = 0,
			// Token: 0x0400024D RID: 589
			Style2 = 1
		}
	}
}
