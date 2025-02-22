using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000010 RID: 16
	public class LogInLogButton : Control
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00009DEB File Offset: 0x00007FEB
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = DrawHelpers.MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00009E01 File Offset: 0x00008001
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00009E17 File Offset: 0x00008017
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00009E2D File Offset: 0x0000802D
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00009E43 File Offset: 0x00008043
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00009E4B File Offset: 0x0000804B
		[Category("Colours")]
		public Color ArcColour
		{
			get
			{
				return this._ArcColour;
			}
			set
			{
				this._ArcColour = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00009E54 File Offset: 0x00008054
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00009E5C File Offset: 0x0000805C
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00009E65 File Offset: 0x00008065
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00009E6D File Offset: 0x0000806D
		[Category("Colours")]
		public Color ArrowColour
		{
			get
			{
				return this._ArrowColour;
			}
			set
			{
				this._ArrowColour = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00009E76 File Offset: 0x00008076
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00009E7E File Offset: 0x0000807E
		[Category("Colours")]
		public Color ArrowBorderColour
		{
			get
			{
				return this._ArrowBorderColour;
			}
			set
			{
				this._ArrowBorderColour = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00009E87 File Offset: 0x00008087
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00009E8F File Offset: 0x0000808F
		[Category("Colours")]
		public Color HoverColour
		{
			get
			{
				return this._HoverColour;
			}
			set
			{
				this._HoverColour = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00009E98 File Offset: 0x00008098
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Category("Colours")]
		public Color PressedColour
		{
			get
			{
				return this._PressedColour;
			}
			set
			{
				this._PressedColour = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00009EA9 File Offset: 0x000080A9
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00009EB1 File Offset: 0x000080B1
		[Category("Colours")]
		public Color NormalColour
		{
			get
			{
				return this._NormalColour;
			}
			set
			{
				this._NormalColour = value;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00009EBA File Offset: 0x000080BA
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Size = new Size(50, 50);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00009ED4 File Offset: 0x000080D4
		public LogInLogButton()
		{
			this.State = DrawHelpers.MouseState.None;
			this._ArcColour = Color.FromArgb(43, 43, 43);
			this._ArrowColour = Color.FromArgb(235, 233, 234);
			this._ArrowBorderColour = Color.FromArgb(170, 170, 170);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._HoverColour = Color.FromArgb(0, 130, 169);
			this._PressedColour = Color.FromArgb(0, 145, 184);
			this._NormalColour = Color.FromArgb(0, 160, 199);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(50, 50);
			this.BackColor = Color.Transparent;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00009FB4 File Offset: 0x000081B4
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			GraphicsPath graphicsPath = new GraphicsPath();
			GraphicsPath graphicsPath2 = new GraphicsPath();
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(this.BackColor);
			Point[] points = new Point[]
			{
				new Point(18, 22),
				new Point(28, 22),
				new Point(28, 18),
				new Point(34, 25),
				new Point(28, 32),
				new Point(28, 28),
				new Point(18, 28)
			};
			checked
			{
				switch (this.State)
				{
				case DrawHelpers.MouseState.None:
					graphics2.FillEllipse(new SolidBrush(Color.FromArgb(56, 56, 56)), new Rectangle(3, 3, base.Width - 3 - 3, base.Height - 3 - 3));
					graphics2.DrawArc(new Pen(new SolidBrush(this._ArcColour), 4f), 3, 3, base.Width - 3 - 3, base.Height - 3 - 3, -90, 360);
					graphics2.DrawEllipse(new Pen(this._BorderColour), new Rectangle(1, 1, base.Height - 3, base.Height - 3));
					graphics2.FillEllipse(new SolidBrush(this._NormalColour), new Rectangle(5, 5, base.Height - 11, base.Height - 11));
					graphics2.FillPolygon(new SolidBrush(this._ArrowColour), points);
					graphics2.DrawPolygon(new Pen(this._ArrowBorderColour), points);
					break;
				case DrawHelpers.MouseState.Over:
					graphics2.DrawArc(new Pen(new SolidBrush(this._ArcColour), 4f), 3, 3, base.Width - 3 - 3, base.Height - 3 - 3, -90, 360);
					graphics2.DrawEllipse(new Pen(this._BorderColour), new Rectangle(1, 1, base.Height - 3, base.Height - 3));
					graphics2.FillEllipse(new SolidBrush(this._HoverColour), new Rectangle(6, 6, base.Height - 13, base.Height - 13));
					graphics2.FillPolygon(new SolidBrush(this._ArrowColour), points);
					graphics2.DrawPolygon(new Pen(this._ArrowBorderColour), points);
					break;
				case DrawHelpers.MouseState.Down:
					graphics2.DrawArc(new Pen(new SolidBrush(this._ArcColour), 4f), 3, 3, base.Width - 3 - 3, base.Height - 3 - 3, -90, 360);
					graphics2.DrawEllipse(new Pen(this._BorderColour), new Rectangle(1, 1, base.Height - 3, base.Height - 3));
					graphics2.FillEllipse(new SolidBrush(this._PressedColour), new Rectangle(6, 6, base.Height - 13, base.Height - 13));
					graphics2.FillPolygon(new SolidBrush(this._ArrowColour), points);
					graphics2.DrawPolygon(new Pen(this._ArrowBorderColour), points);
					break;
				}
				graphicsPath.Dispose();
				graphicsPath2.Dispose();
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x04000070 RID: 112
		private DrawHelpers.MouseState State;

		// Token: 0x04000071 RID: 113
		public Color _ArcColour;

		// Token: 0x04000072 RID: 114
		public Color _ArrowColour;

		// Token: 0x04000073 RID: 115
		public Color _ArrowBorderColour;

		// Token: 0x04000074 RID: 116
		public Color _BorderColour;

		// Token: 0x04000075 RID: 117
		public Color _HoverColour;

		// Token: 0x04000076 RID: 118
		public Color _PressedColour;

		// Token: 0x04000077 RID: 119
		public Color _NormalColour;
	}
}
