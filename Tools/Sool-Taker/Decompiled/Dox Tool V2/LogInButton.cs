using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000016 RID: 22
	public class LogInButton : Control
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0000B6A5 File Offset: 0x000098A5
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = DrawHelpers.MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000B6BB File Offset: 0x000098BB
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000B6D1 File Offset: 0x000098D1
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000B6E7 File Offset: 0x000098E7
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000B6FD File Offset: 0x000098FD
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000B705 File Offset: 0x00009905
		[Category("Colours")]
		public Color ProgressColour
		{
			get
			{
				return this._ProgressColour;
			}
			set
			{
				this._ProgressColour = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000B70E File Offset: 0x0000990E
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0000B716 File Offset: 0x00009916
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000B71F File Offset: 0x0000991F
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000B727 File Offset: 0x00009927
		[Category("Colours")]
		public Color FontColour
		{
			get
			{
				return this._FontColour;
			}
			set
			{
				this._FontColour = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000B730 File Offset: 0x00009930
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0000B738 File Offset: 0x00009938
		[Category("Colours")]
		public Color BaseColour
		{
			get
			{
				return this._MainColour;
			}
			set
			{
				this._MainColour = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000B741 File Offset: 0x00009941
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0000B749 File Offset: 0x00009949
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000B752 File Offset: 0x00009952
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000B75A File Offset: 0x0000995A
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

		// Token: 0x0600018C RID: 396 RVA: 0x0000B764 File Offset: 0x00009964
		public LogInButton()
		{
			this._Font = new Font("Segoe UI", 9f);
			this._ProgressColour = Color.FromArgb(0, 191, 255);
			this._BorderColour = Color.FromArgb(25, 25, 25);
			this._FontColour = Color.FromArgb(255, 255, 255);
			this._MainColour = Color.FromArgb(42, 42, 42);
			this._HoverColour = Color.FromArgb(52, 52, 52);
			this._PressedColour = Color.FromArgb(47, 47, 47);
			this.State = DrawHelpers.MouseState.None;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(75, 30);
			this.BackColor = Color.Transparent;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000B83C File Offset: 0x00009A3C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.Clear(this.BackColor);
			checked
			{
				switch (this.State)
				{
				case DrawHelpers.MouseState.None:
					graphics.FillRectangle(new SolidBrush(this._MainColour), new Rectangle(0, 0, base.Width, base.Height));
					graphics.DrawRectangle(new Pen(this._BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height));
					graphics.DrawString(this.Text, this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				case DrawHelpers.MouseState.Over:
					graphics.FillRectangle(new SolidBrush(this._HoverColour), new Rectangle(0, 0, base.Width, base.Height));
					graphics.DrawRectangle(new Pen(this._BorderColour, 1f), new Rectangle(1, 1, base.Width - 2, base.Height - 2));
					graphics.DrawString(this.Text, this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				case DrawHelpers.MouseState.Down:
					graphics.FillRectangle(new SolidBrush(this._PressedColour), new Rectangle(0, 0, base.Width, base.Height));
					graphics.DrawRectangle(new Pen(this._BorderColour, 1f), new Rectangle(1, 1, base.Width - 2, base.Height - 2));
					graphics.DrawString(this.Text, this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round((double)base.Height / 2.0)), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				}
			}
		}

		// Token: 0x0400009B RID: 155
		public readonly Font _Font;

		// Token: 0x0400009C RID: 156
		public Color _ProgressColour;

		// Token: 0x0400009D RID: 157
		public Color _BorderColour;

		// Token: 0x0400009E RID: 158
		public Color _FontColour;

		// Token: 0x0400009F RID: 159
		public Color _MainColour;

		// Token: 0x040000A0 RID: 160
		public Color _HoverColour;

		// Token: 0x040000A1 RID: 161
		public Color _PressedColour;

		// Token: 0x040000A2 RID: 162
		private DrawHelpers.MouseState State;
	}
}
