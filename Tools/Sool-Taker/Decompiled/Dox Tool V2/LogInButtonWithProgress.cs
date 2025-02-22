using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000017 RID: 23
	public class LogInButtonWithProgress : Control
	{
		// Token: 0x0600018E RID: 398 RVA: 0x0000BAB7 File Offset: 0x00009CB7
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = DrawHelpers.MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000BACD File Offset: 0x00009CCD
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000BAE3 File Offset: 0x00009CE3
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000BAF9 File Offset: 0x00009CF9
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000BB0F File Offset: 0x00009D0F
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000BB17 File Offset: 0x00009D17
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000BB20 File Offset: 0x00009D20
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0000BB28 File Offset: 0x00009D28
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000BB31 File Offset: 0x00009D31
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0000BB39 File Offset: 0x00009D39
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000BB42 File Offset: 0x00009D42
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0000BB4A File Offset: 0x00009D4A
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000BB53 File Offset: 0x00009D53
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000BB5B File Offset: 0x00009D5B
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000BB64 File Offset: 0x00009D64
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000BB6C File Offset: 0x00009D6C
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000BB75 File Offset: 0x00009D75
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0000BB7D File Offset: 0x00009D7D
		[Category("Control")]
		public int Maximum
		{
			get
			{
				return this._Maximum;
			}
			set
			{
				if (value < this._Value)
				{
					this._Value = value;
				}
				this._Maximum = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000BB9C File Offset: 0x00009D9C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000BBBF File Offset: 0x00009DBF
		[Category("Control")]
		public int Value
		{
			get
			{
				int result;
				if (this._Value == 0)
				{
					result = 0;
				}
				else
				{
					result = this._Value;
				}
				return result;
			}
			set
			{
				if (value > this._Maximum)
				{
					value = this._Maximum;
					base.Invalidate();
				}
				this._Value = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000BBE5 File Offset: 0x00009DE5
		public void Increment(int Amount)
		{
			checked
			{
				this.Value += Amount;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		public LogInButtonWithProgress()
		{
			this._Value = 0;
			this._Maximum = 100;
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

		// Token: 0x060001A4 RID: 420 RVA: 0x0000BCDC File Offset: 0x00009EDC
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this.BackColor);
			checked
			{
				switch (this.State)
				{
				case DrawHelpers.MouseState.None:
					graphics.FillRectangle(new SolidBrush(this._MainColour), new Rectangle(0, 0, base.Width, base.Height - 4));
					graphics.DrawRectangle(new Pen(this._BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height - 4));
					graphics.DrawString(this.Text, this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				case DrawHelpers.MouseState.Over:
					graphics.FillRectangle(new SolidBrush(this._HoverColour), new Rectangle(0, 0, base.Width, base.Height - 4));
					graphics.DrawRectangle(new Pen(this._BorderColour, 1f), new Rectangle(1, 1, base.Width - 2, base.Height - 5));
					graphics.DrawString(this.Text, this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				case DrawHelpers.MouseState.Down:
					graphics.FillRectangle(new SolidBrush(this._PressedColour), new Rectangle(0, 0, base.Width, base.Height - 4));
					graphics.DrawRectangle(new Pen(this._BorderColour, 1f), new Rectangle(1, 1, base.Width - 2, base.Height - 5));
					graphics.DrawString(this.Text, this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
					break;
				}
				int value = this._Value;
				if (value != 0)
				{
					if (value == this._Maximum)
					{
						graphics.FillRectangle(new SolidBrush(this._ProgressColour), new Rectangle(0, base.Height - 4, base.Width, base.Height - 4));
						graphics.DrawRectangle(new Pen(this._BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height));
					}
					else
					{
						graphics.FillRectangle(new SolidBrush(this._ProgressColour), new Rectangle(0, base.Height - 4, (int)Math.Round(unchecked((double)base.Width / (double)this._Maximum * (double)this._Value)), base.Height - 4));
						graphics.DrawRectangle(new Pen(this._BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height));
					}
				}
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000A3 RID: 163
		public int _Value;

		// Token: 0x040000A4 RID: 164
		public int _Maximum;

		// Token: 0x040000A5 RID: 165
		public Font _Font;

		// Token: 0x040000A6 RID: 166
		public Color _ProgressColour;

		// Token: 0x040000A7 RID: 167
		public Color _BorderColour;

		// Token: 0x040000A8 RID: 168
		public Color _FontColour;

		// Token: 0x040000A9 RID: 169
		public Color _MainColour;

		// Token: 0x040000AA RID: 170
		public Color _HoverColour;

		// Token: 0x040000AB RID: 171
		public Color _PressedColour;

		// Token: 0x040000AC RID: 172
		private DrawHelpers.MouseState State;
	}
}
