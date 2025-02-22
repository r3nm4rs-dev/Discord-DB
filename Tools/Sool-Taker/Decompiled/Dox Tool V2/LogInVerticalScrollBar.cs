using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000026 RID: 38
	[DefaultEvent("Scroll")]
	public class LogInVerticalScrollBar : Control
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000FC44 File Offset: 0x0000DE44
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0000FC4C File Offset: 0x0000DE4C
		[Category("Colours")]
		public Color ThumbBorder
		{
			get
			{
				return this._ThumbBorder;
			}
			set
			{
				this._ThumbBorder = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000FC55 File Offset: 0x0000DE55
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x0000FC5D File Offset: 0x0000DE5D
		[Category("Colours")]
		public Color LineColour
		{
			get
			{
				return this._LineColour;
			}
			set
			{
				this._LineColour = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000FC66 File Offset: 0x0000DE66
		// (set) Token: 0x060002AB RID: 683 RVA: 0x0000FC6E File Offset: 0x0000DE6E
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000FC77 File Offset: 0x0000DE77
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000FC7F File Offset: 0x0000DE7F
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000FC88 File Offset: 0x0000DE88
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000FC90 File Offset: 0x0000DE90
		[Category("Colours")]
		public Color ThumbColour
		{
			get
			{
				return this._ThumbColour;
			}
			set
			{
				this._ThumbColour = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000FC99 File Offset: 0x0000DE99
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000FCA1 File Offset: 0x0000DEA1
		[Category("Colours")]
		public Color ThumbSecondBorder
		{
			get
			{
				return this._ThumbSecondBorder;
			}
			set
			{
				this._ThumbSecondBorder = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000FCAA File Offset: 0x0000DEAA
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000FCB2 File Offset: 0x0000DEB2
		[Category("Colours")]
		public Color FirstBorder
		{
			get
			{
				return this._FirstBorder;
			}
			set
			{
				this._FirstBorder = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000FCBB File Offset: 0x0000DEBB
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x0000FCC3 File Offset: 0x0000DEC3
		[Category("Colours")]
		public Color SecondBorder
		{
			get
			{
				return this._SecondBorder;
			}
			set
			{
				this._SecondBorder = value;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060002B6 RID: 694 RVA: 0x0000FCCC File Offset: 0x0000DECC
		// (remove) Token: 0x060002B7 RID: 695 RVA: 0x0000FD04 File Offset: 0x0000DF04
		public event LogInVerticalScrollBar.ScrollEventHandler Scroll;

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000FD39 File Offset: 0x0000DF39
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public int Minimum
		{
			get
			{
				return this._Minimum;
			}
			set
			{
				this._Minimum = value;
				if (value > this._Value)
				{
					this._Value = value;
				}
				if (value > this._Maximum)
				{
					this._Maximum = value;
				}
				this.InvalidateLayout();
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000FD70 File Offset: 0x0000DF70
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000FD78 File Offset: 0x0000DF78
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
				if (value < this._Minimum)
				{
					this._Minimum = value;
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000FD9A File Offset: 0x0000DF9A
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000FDA4 File Offset: 0x0000DFA4
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
					if (value < this._Minimum)
					{
						this._Value = this._Minimum;
					}
					else if (value > this._Maximum)
					{
						this._Value = this._Maximum;
					}
					else
					{
						this._Value = value;
					}
					this.InvalidatePosition();
					LogInVerticalScrollBar.ScrollEventHandler scrollEvent = this.ScrollEvent;
					if (scrollEvent != null)
					{
						scrollEvent(this);
					}
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000FE08 File Offset: 0x0000E008
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000FE10 File Offset: 0x0000E010
		public int SmallChange
		{
			get
			{
				return this._SmallChange;
			}
			set
			{
				if (value >= 1)
				{
					bool flag = -((this._SmallChange == value) > false);
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000FE33 File Offset: 0x0000E033
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000FE3B File Offset: 0x0000E03B
		public int LargeChange
		{
			get
			{
				return this._LargeChange;
			}
			set
			{
				if (value >= 1)
				{
					this._LargeChange = value;
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000FE48 File Offset: 0x0000E048
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000FE50 File Offset: 0x0000E050
		public int ButtonSize
		{
			get
			{
				return this._ButtonSize;
			}
			set
			{
				if (value < 16)
				{
					this._ButtonSize = 16;
					return;
				}
				this._ButtonSize = value;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000FE67 File Offset: 0x0000E067
		protected override void OnSizeChanged(EventArgs e)
		{
			this.InvalidateLayout();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000FE70 File Offset: 0x0000E070
		public void InvalidateLayout()
		{
			this.TSA = new Rectangle(0, 1, base.Width, 0);
			checked
			{
				this.Shaft = new Rectangle(0, this.TSA.Bottom - 1, base.Width, base.Height - 3);
				this.ShowThumb = (this._Maximum - this._Minimum != 0);
				if (this.ShowThumb)
				{
					this.Thumb = new Rectangle(1, 0, base.Width - 3, this._ThumbSize);
				}
				LogInVerticalScrollBar.ScrollEventHandler scrollEvent = this.ScrollEvent;
				if (scrollEvent != null)
				{
					scrollEvent(this);
				}
				this.InvalidatePosition();
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000FF08 File Offset: 0x0000E108
		public void InvalidatePosition()
		{
			this.Thumb.Y = checked((int)Math.Round(unchecked(checked((double)(this._Value - this._Minimum) / (double)(this._Maximum - this._Minimum)) * (double)(checked(this.Shaft.Height - this._ThumbSize)) + 1.0)));
			base.Invalidate();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000FF68 File Offset: 0x0000E168
		protected override void OnMouseDown(MouseEventArgs e)
		{
			checked
			{
				if (e.Button == MouseButtons.Left && this.ShowThumb)
				{
					if (this.TSA.Contains(e.Location))
					{
						this.ThumbMovement = this._Value - this._SmallChange;
					}
					else if (this.BSA.Contains(e.Location))
					{
						this.ThumbMovement = this._Value + this._SmallChange;
					}
					else
					{
						if (this.Thumb.Contains(e.Location))
						{
							this.ThumbPressed = true;
							return;
						}
						if (e.Y < this.Thumb.Y)
						{
							this.ThumbMovement = this._Value - this._LargeChange;
						}
						else
						{
							this.ThumbMovement = this._Value + this._LargeChange;
						}
					}
					this.Value = Math.Min(Math.Max(this.ThumbMovement, this._Minimum), this._Maximum);
					this.InvalidatePosition();
				}
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00010060 File Offset: 0x0000E260
		protected override void OnMouseMove(MouseEventArgs e)
		{
			checked
			{
				if (this.ThumbPressed && this.ShowThumb)
				{
					int num = e.Y - this.TSA.Height - this._ThumbSize / 2;
					int num2 = this.Shaft.Height - this._ThumbSize;
					this.ThumbMovement = (int)Math.Round(unchecked((double)num / (double)num2 * (double)(checked(this._Maximum - this._Minimum)))) + this._Minimum;
					this.Value = Math.Min(Math.Max(this.ThumbMovement, this._Minimum), this._Maximum);
					this.InvalidatePosition();
				}
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000100FE File Offset: 0x0000E2FE
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.ThumbPressed = false;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00010108 File Offset: 0x0000E308
		public LogInVerticalScrollBar()
		{
			this._ThumbSize = 24;
			this._Minimum = 0;
			this._Maximum = 100;
			this._Value = 0;
			this._SmallChange = 1;
			this._ButtonSize = 16;
			this._LargeChange = 10;
			this._ThumbBorder = Color.FromArgb(35, 35, 35);
			this._LineColour = Color.FromArgb(23, 119, 151);
			this._ArrowColour = Color.FromArgb(37, 37, 37);
			this._BaseColour = Color.FromArgb(47, 47, 47);
			this._ThumbColour = Color.FromArgb(55, 55, 55);
			this._ThumbSecondBorder = Color.FromArgb(65, 65, 65);
			this._FirstBorder = Color.FromArgb(55, 55, 55);
			this._SecondBorder = Color.FromArgb(35, 35, 35);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(24, 50);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00010200 File Offset: 0x0000E400
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this._BaseColour);
			checked
			{
				Point[] points = new Point[]
				{
					new Point((int)Math.Round((double)base.Width / 2.0), 5),
					new Point((int)Math.Round((double)base.Width / 4.0), 13),
					new Point((int)Math.Round(unchecked((double)base.Width / 2.0 - 2.0)), 13),
					new Point((int)Math.Round(unchecked((double)base.Width / 2.0 - 2.0)), base.Height - 13),
					new Point((int)Math.Round((double)base.Width / 4.0), base.Height - 13),
					new Point((int)Math.Round((double)base.Width / 2.0), base.Height - 5),
					new Point((int)Math.Round(unchecked((double)base.Width - (double)base.Width / 4.0 - 1.0)), base.Height - 13),
					new Point((int)Math.Round(unchecked((double)base.Width / 2.0 + 2.0)), base.Height - 13),
					new Point((int)Math.Round(unchecked((double)base.Width / 2.0 + 2.0)), 13),
					new Point((int)Math.Round(unchecked((double)base.Width - (double)base.Width / 4.0 - 1.0)), 13)
				};
				graphics.FillPolygon(new SolidBrush(this._ArrowColour), points);
				graphics.FillRectangle(new SolidBrush(this._ThumbColour), this.Thumb);
				graphics.DrawRectangle(new Pen(this._ThumbBorder), this.Thumb);
				graphics.DrawRectangle(new Pen(this._ThumbSecondBorder), this.Thumb.X + 1, this.Thumb.Y + 1, this.Thumb.Width - 2, this.Thumb.Height - 2);
				graphics.DrawLine(new Pen(this._LineColour, 2f), new Point((int)Math.Round(unchecked((double)this.Thumb.Width / 2.0 + 1.0)), this.Thumb.Y + 4), new Point((int)Math.Round(unchecked((double)this.Thumb.Width / 2.0 + 1.0)), this.Thumb.Bottom - 4));
				graphics.DrawRectangle(new Pen(this._FirstBorder), 0, 0, base.Width - 1, base.Height - 1);
				graphics.DrawRectangle(new Pen(this._SecondBorder), 1, 1, base.Width - 3, base.Height - 3);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x0400010C RID: 268
		public int ThumbMovement;

		// Token: 0x0400010D RID: 269
		public Rectangle TSA;

		// Token: 0x0400010E RID: 270
		public Rectangle BSA;

		// Token: 0x0400010F RID: 271
		public Rectangle Shaft;

		// Token: 0x04000110 RID: 272
		public Rectangle Thumb;

		// Token: 0x04000111 RID: 273
		public bool ShowThumb;

		// Token: 0x04000112 RID: 274
		public bool ThumbPressed;

		// Token: 0x04000113 RID: 275
		public int _ThumbSize;

		// Token: 0x04000114 RID: 276
		public int _Minimum;

		// Token: 0x04000115 RID: 277
		public int _Maximum;

		// Token: 0x04000116 RID: 278
		public int _Value;

		// Token: 0x04000117 RID: 279
		public int _SmallChange;

		// Token: 0x04000118 RID: 280
		public int _ButtonSize;

		// Token: 0x04000119 RID: 281
		public int _LargeChange;

		// Token: 0x0400011A RID: 282
		public Color _ThumbBorder;

		// Token: 0x0400011B RID: 283
		public Color _LineColour;

		// Token: 0x0400011C RID: 284
		public Color _ArrowColour;

		// Token: 0x0400011D RID: 285
		public Color _BaseColour;

		// Token: 0x0400011E RID: 286
		public Color _ThumbColour;

		// Token: 0x0400011F RID: 287
		public Color _ThumbSecondBorder;

		// Token: 0x04000120 RID: 288
		public Color _FirstBorder;

		// Token: 0x04000121 RID: 289
		public Color _SecondBorder;

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000364 RID: 868
		public delegate void ScrollEventHandler(object sender);
	}
}
