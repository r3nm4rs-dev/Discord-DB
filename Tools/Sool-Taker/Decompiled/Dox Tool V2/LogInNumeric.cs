using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Dox_Tool_V2
{
	// Token: 0x0200001A RID: 26
	public class LogInNumeric : Control
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		public long Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if (value <= this._Maximum & value >= this._Minimum)
				{
					this._Value = value;
				}
				base.Invalidate();
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000C50A File Offset: 0x0000A70A
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0000C512 File Offset: 0x0000A712
		public long Maximum
		{
			get
			{
				return this._Maximum;
			}
			set
			{
				if (value > this._Minimum)
				{
					this._Maximum = value;
				}
				if (this._Value > this._Maximum)
				{
					this._Value = this._Maximum;
				}
				base.Invalidate();
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000C544 File Offset: 0x0000A744
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000C54C File Offset: 0x0000A74C
		public long Minimum
		{
			get
			{
				return this._Minimum;
			}
			set
			{
				if (value < this._Maximum)
				{
					this._Minimum = value;
				}
				if (this._Value < this._Minimum)
				{
					this._Value = this.Minimum;
				}
				base.Invalidate();
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000C580 File Offset: 0x0000A780
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.MouseXLoc = e.Location.X;
			this.MouseYLoc = e.Location.Y;
			base.Invalidate();
			if (e.X < checked(base.Width - 47))
			{
				this.Cursor = Cursors.IBeam;
				return;
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000C5EC File Offset: 0x0000A7EC
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			checked
			{
				if (this.MouseXLoc > base.Width - 47 && this.MouseXLoc < base.Width - 3)
				{
					if (this.MouseXLoc < base.Width - 23)
					{
						if (this.Value + 1L <= this._Maximum)
						{
							ref long ptr = ref this._Value;
							this._Value = ptr + 1L;
						}
					}
					else if (this.Value - 1L >= this._Minimum)
					{
						ref long ptr = ref this._Value;
						this._Value = ptr - 1L;
					}
				}
				else
				{
					this.BoolValue = !this.BoolValue;
					base.Focus();
				}
				base.Invalidate();
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000C690 File Offset: 0x0000A890
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			try
			{
				if (this.BoolValue)
				{
					this._Value = Conversions.ToLong(Conversions.ToString(this._Value) + e.KeyChar.ToString());
				}
				if (this._Value > this._Maximum)
				{
					this._Value = this._Maximum;
				}
				base.Invalidate();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000C714 File Offset: 0x0000A914
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyCode == Keys.Back)
			{
				this.Value = 0L;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000C72E File Offset: 0x0000A92E
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 24;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000C73F File Offset: 0x0000A93F
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000C747 File Offset: 0x0000A947
		[Category("Colours")]
		public Color BaseColour
		{
			get
			{
				return this._BaseColour;
			}
			set
			{
				this._BaseColour = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000C750 File Offset: 0x0000A950
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000C758 File Offset: 0x0000A958
		[Category("Colours")]
		public Color ButtonColour
		{
			get
			{
				return this._ButtonColour;
			}
			set
			{
				this._ButtonColour = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000C761 File Offset: 0x0000A961
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000C769 File Offset: 0x0000A969
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000C772 File Offset: 0x0000A972
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000C77A File Offset: 0x0000A97A
		[Category("Colours")]
		public Color SecondBorderColour
		{
			get
			{
				return this._SecondBorderColour;
			}
			set
			{
				this._SecondBorderColour = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000C783 File Offset: 0x0000A983
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000C78B File Offset: 0x0000A98B
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

		// Token: 0x060001CC RID: 460 RVA: 0x0000C794 File Offset: 0x0000A994
		public LogInNumeric()
		{
			this.State = DrawHelpers.MouseState.None;
			this._Minimum = 0L;
			this._Maximum = 9999999L;
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._ButtonColour = Color.FromArgb(47, 47, 47);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._SecondBorderColour = Color.FromArgb(0, 191, 255);
			this._FontColour = Color.FromArgb(255, 255, 255);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 10f);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000C850 File Offset: 0x0000AA50
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			StringFormat stringFormat = new StringFormat();
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.Alignment = StringAlignment.Center;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(this.BackColor);
			graphics.FillRectangle(new SolidBrush(this._BaseColour), rect);
			checked
			{
				graphics.FillRectangle(new SolidBrush(this._ButtonColour), new Rectangle(base.Width - 48, 0, 48, base.Height));
				graphics.DrawRectangle(new Pen(this._BorderColour, 2f), rect);
				graphics.DrawLine(new Pen(this._SecondBorderColour), new Point(base.Width - 48, 1), new Point(base.Width - 48, base.Height - 2));
				graphics.DrawLine(new Pen(this._BorderColour), new Point(base.Width - 24, 1), new Point(base.Width - 24, base.Height - 2));
				graphics.DrawLine(new Pen(this._FontColour), new Point(base.Width - 36, 7), new Point(base.Width - 36, 17));
				graphics.DrawLine(new Pen(this._FontColour), new Point(base.Width - 31, 12), new Point(base.Width - 41, 12));
				graphics.DrawLine(new Pen(this._FontColour), new Point(base.Width - 17, 13), new Point(base.Width - 7, 13));
				graphics.DrawString(Conversions.ToString(this.Value), this.Font, new SolidBrush(this._FontColour), new Rectangle(5, 1, base.Width, base.Height), new StringFormat
				{
					LineAlignment = StringAlignment.Center
				});
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000B4 RID: 180
		private DrawHelpers.MouseState State;

		// Token: 0x040000B5 RID: 181
		public int MouseXLoc;

		// Token: 0x040000B6 RID: 182
		public int MouseYLoc;

		// Token: 0x040000B7 RID: 183
		public long _Value;

		// Token: 0x040000B8 RID: 184
		public long _Minimum;

		// Token: 0x040000B9 RID: 185
		public long _Maximum;

		// Token: 0x040000BA RID: 186
		public bool BoolValue;

		// Token: 0x040000BB RID: 187
		public Color _BaseColour;

		// Token: 0x040000BC RID: 188
		public Color _ButtonColour;

		// Token: 0x040000BD RID: 189
		public Color _BorderColour;

		// Token: 0x040000BE RID: 190
		public Color _SecondBorderColour;

		// Token: 0x040000BF RID: 191
		public Color _FontColour;
	}
}
