using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Dox_Tool_V2
{
	// Token: 0x02000025 RID: 37
	public class LogInTrackBar : Control
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000F4BC File Offset: 0x0000D6BC
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
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

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000F4CD File Offset: 0x0000D6CD
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0000F4D5 File Offset: 0x0000D6D5
		[Category("Colours")]
		public Color BarBaseColour
		{
			get
			{
				return this._BarBaseColour;
			}
			set
			{
				this._BarBaseColour = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000F4DE File Offset: 0x0000D6DE
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000F4E6 File Offset: 0x0000D6E6
		[Category("Colours")]
		public Color StripColour
		{
			get
			{
				return this._StripColour;
			}
			set
			{
				this._StripColour = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000F4EF File Offset: 0x0000D6EF
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000F4F7 File Offset: 0x0000D6F7
		[Category("Colours")]
		public Color TextColour
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000F500 File Offset: 0x0000D700
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000F508 File Offset: 0x0000D708
		[Category("Colours")]
		public Color StripAmountColour
		{
			get
			{
				return this._StripAmountColour;
			}
			set
			{
				this._StripAmountColour = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000F511 File Offset: 0x0000D711
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0000F519 File Offset: 0x0000D719
		public int Maximum
		{
			get
			{
				return this._Maximum;
			}
			set
			{
				if (value > 0)
				{
					this._Maximum = value;
				}
				if (value < this._Value)
				{
					this._Value = value;
				}
				base.Invalidate();
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600029B RID: 667 RVA: 0x0000F53C File Offset: 0x0000D73C
		// (remove) Token: 0x0600029C RID: 668 RVA: 0x0000F574 File Offset: 0x0000D774
		public event LogInTrackBar.ValueChangedEventHandler ValueChanged;

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000F5A9 File Offset: 0x0000D7A9
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if (value != this._Value)
				{
					if (value < 0)
					{
						this._Value = 0;
					}
					else if (value > this._Maximum)
					{
						this._Value = this._Maximum;
					}
					else
					{
						this._Value = value;
					}
					base.Invalidate();
					LogInTrackBar.ValueChangedEventHandler valueChangedEvent = this.ValueChangedEvent;
					if (valueChangedEvent != null)
					{
						valueChangedEvent();
					}
				}
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000F60D File Offset: 0x0000D80D
		protected override void OnHandleCreated(EventArgs e)
		{
			this.BackColor = Color.Transparent;
			base.OnHandleCreated(e);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000F624 File Offset: 0x0000D824
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			Rectangle rect = new Rectangle(new Point(e.Location.X, e.Location.Y), new Size(1, 1));
			checked
			{
				Rectangle rectangle = new Rectangle(10, 10, base.Width - 21, base.Height - 21);
				if (new Rectangle(new Point(rectangle.X + (int)Math.Round(unchecked((double)rectangle.Width * ((double)this.Value / (double)this.Maximum))) - (int)Math.Round(unchecked((double)this.Track.Width / 2.0 - 1.0)), 0), new Size(this.Track.Width, base.Height)).IntersectsWith(rect))
				{
					this.CaptureMovement = true;
				}
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000F704 File Offset: 0x0000D904
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.CaptureMovement = false;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000F714 File Offset: 0x0000D914
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			checked
			{
				if (this.CaptureMovement)
				{
					Point point = new Point(e.X, e.Y);
					Rectangle rectangle = new Rectangle(10, 10, base.Width - 21, base.Height - 21);
					this.Value = (int)Math.Round(unchecked((double)this.Maximum * ((double)(checked(point.X - rectangle.X)) / (double)rectangle.Width)));
				}
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000F78D File Offset: 0x0000D98D
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.CaptureMovement = false;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
		public LogInTrackBar()
		{
			this._Maximum = 10;
			this._Value = 0;
			this.CaptureMovement = false;
			this.Bar = checked(new Rectangle(0, 10, base.Width - 21, base.Height - 21));
			this.Track = new Size(25, 14);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._BarBaseColour = Color.FromArgb(47, 47, 47);
			this._StripColour = Color.FromArgb(42, 42, 42);
			this._StripAmountColour = Color.FromArgb(23, 119, 151);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000F86C File Offset: 0x0000DA6C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			checked
			{
				this.Bar = new Rectangle(13, 11, base.Width - 27, base.Height - 21);
				graphics.Clear(base.Parent.FindForm().BackColor);
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
				graphics.FillRectangle(new SolidBrush(this._StripColour), new Rectangle(3, (int)Math.Round(unchecked((double)base.Height / 2.0 - 4.0)), base.Width - 5, 8));
				graphics.DrawRectangle(new Pen(this._BorderColour, 2f), new Rectangle(4, (int)Math.Round(unchecked((double)base.Height / 2.0 - 4.0)), base.Width - 5, 8));
				graphics.FillRectangle(new SolidBrush(this._StripAmountColour), new Rectangle(4, (int)Math.Round(unchecked((double)base.Height / 2.0 - 4.0)), (int)Math.Round(unchecked((double)this.Bar.Width * ((double)this.Value / (double)this.Maximum))) + (int)Math.Round((double)this.Track.Width / 2.0), 8));
				graphics.FillRectangle(new SolidBrush(this._BarBaseColour), this.Bar.X + (int)Math.Round(unchecked((double)this.Bar.Width * ((double)this.Value / (double)this.Maximum))) - (int)Math.Round((double)this.Track.Width / 2.0), this.Bar.Y + (int)Math.Round((double)this.Bar.Height / 2.0) - (int)Math.Round((double)this.Track.Height / 2.0), this.Track.Width, this.Track.Height);
				graphics.DrawRectangle(new Pen(this._BorderColour, 2f), this.Bar.X + (int)Math.Round(unchecked((double)this.Bar.Width * ((double)this.Value / (double)this.Maximum))) - (int)Math.Round((double)this.Track.Width / 2.0), this.Bar.Y + (int)Math.Round((double)this.Bar.Height / 2.0) - (int)Math.Round((double)this.Track.Height / 2.0), this.Track.Width, this.Track.Height);
				graphics.DrawString(Conversions.ToString(this._Value), new Font("Segoe UI", 6.5f, FontStyle.Regular), new SolidBrush(this._TextColour), new Rectangle(this.Bar.X + (int)Math.Round(unchecked((double)this.Bar.Width * ((double)this.Value / (double)this.Maximum))) - (int)Math.Round((double)this.Track.Width / 2.0), this.Bar.Y + (int)Math.Round((double)this.Bar.Height / 2.0) - (int)Math.Round((double)this.Track.Height / 2.0), this.Track.Width - 1, this.Track.Height), new StringFormat
				{
					Alignment = StringAlignment.Center,
					LineAlignment = StringAlignment.Center
				});
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x04000101 RID: 257
		public int _Maximum;

		// Token: 0x04000102 RID: 258
		public int _Value;

		// Token: 0x04000103 RID: 259
		public bool CaptureMovement;

		// Token: 0x04000104 RID: 260
		public Rectangle Bar;

		// Token: 0x04000105 RID: 261
		public Size Track;

		// Token: 0x04000106 RID: 262
		public Color _TextColour;

		// Token: 0x04000107 RID: 263
		public Color _BorderColour;

		// Token: 0x04000108 RID: 264
		public Color _BarBaseColour;

		// Token: 0x04000109 RID: 265
		public Color _StripColour;

		// Token: 0x0400010A RID: 266
		public Color _StripAmountColour;

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000360 RID: 864
		public delegate void ValueChangedEventHandler();
	}
}
