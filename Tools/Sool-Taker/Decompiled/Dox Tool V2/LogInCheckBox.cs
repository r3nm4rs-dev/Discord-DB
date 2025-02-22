using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000011 RID: 17
	[DefaultEvent("CheckedChanged")]
	public class LogInCheckBox : Control
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000A2E6 File Offset: 0x000084E6
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000A2EE File Offset: 0x000084EE
		[Category("Colours")]
		public Color BaseColour
		{
			get
			{
				return this._BackColour;
			}
			set
			{
				this._BackColour = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000A2F7 File Offset: 0x000084F7
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000A2FF File Offset: 0x000084FF
		[Category("Colours")]
		public Color BorderColour
		{
			get
			{
				return this._BorderColour;
			}
			set
			{
				this._BorderColour = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000A308 File Offset: 0x00008508
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000A310 File Offset: 0x00008510
		[Category("Colours")]
		public Color CheckedColour
		{
			get
			{
				return this._CheckedColour;
			}
			set
			{
				this._CheckedColour = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000A319 File Offset: 0x00008519
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000A321 File Offset: 0x00008521
		[Category("Colours")]
		public Color FontColour
		{
			get
			{
				return this._TextColour;
			}
			set
			{
				this._TextColour = value;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000A32A File Offset: 0x0000852A
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000A339 File Offset: 0x00008539
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000A341 File Offset: 0x00008541
		public bool Checked
		{
			get
			{
				return this._Checked;
			}
			set
			{
				this._Checked = value;
				base.Invalidate();
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000123 RID: 291 RVA: 0x0000A350 File Offset: 0x00008550
		// (remove) Token: 0x06000124 RID: 292 RVA: 0x0000A388 File Offset: 0x00008588
		public event LogInCheckBox.CheckedChangedEventHandler CheckedChanged;

		// Token: 0x06000125 RID: 293 RVA: 0x0000A3C0 File Offset: 0x000085C0
		protected override void OnClick(EventArgs e)
		{
			this._Checked = !this._Checked;
			LogInCheckBox.CheckedChangedEventHandler checkedChangedEvent = this.CheckedChangedEvent;
			if (checkedChangedEvent != null)
			{
				checkedChangedEvent(this);
			}
			base.OnClick(e);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000A3F4 File Offset: 0x000085F4
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 22;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000A405 File Offset: 0x00008605
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = DrawHelpers.MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000A41B File Offset: 0x0000861B
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000A431 File Offset: 0x00008631
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000A447 File Offset: 0x00008647
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000A460 File Offset: 0x00008660
		public LogInCheckBox()
		{
			this.State = DrawHelpers.MouseState.None;
			this._CheckedColour = Color.FromArgb(173, 173, 174);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._BackColour = Color.FromArgb(42, 42, 42);
			this._TextColour = Color.FromArgb(255, 255, 255);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.Cursor = Cursors.Hand;
			base.Size = new Size(100, 22);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000A500 File Offset: 0x00008700
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, 20, 20);
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(Color.FromArgb(54, 54, 54));
			graphics2.FillRectangle(new SolidBrush(this._BackColour), rect);
			graphics2.DrawRectangle(new Pen(this._BorderColour), new Rectangle(1, 1, 18, 18));
			DrawHelpers.MouseState state = this.State;
			if (state == DrawHelpers.MouseState.Over)
			{
				graphics2.FillRectangle(new SolidBrush(Color.FromArgb(50, 49, 51)), rect);
				graphics2.DrawRectangle(new Pen(this._BorderColour), new Rectangle(1, 1, 18, 18));
			}
			if (this.Checked)
			{
				Point[] points = new Point[]
				{
					new Point(4, 11),
					new Point(6, 8),
					new Point(9, 12),
					new Point(15, 3),
					new Point(17, 6),
					new Point(9, 16)
				};
				graphics2.FillPolygon(new SolidBrush(this._CheckedColour), points);
			}
			graphics2.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(24, 1, base.Width, checked(base.Height - 2)), new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Center
			});
			graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
		}

		// Token: 0x04000078 RID: 120
		public bool _Checked;

		// Token: 0x04000079 RID: 121
		private DrawHelpers.MouseState State;

		// Token: 0x0400007A RID: 122
		public Color _CheckedColour;

		// Token: 0x0400007B RID: 123
		public Color _BorderColour;

		// Token: 0x0400007C RID: 124
		public Color _BackColour;

		// Token: 0x0400007D RID: 125
		public Color _TextColour;

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000354 RID: 852
		public delegate void CheckedChangedEventHandler(object sender);
	}
}
