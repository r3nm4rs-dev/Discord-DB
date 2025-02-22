using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000027 RID: 39
	[DefaultEvent("Scroll")]
	public class LogInHorizontalScrollBar : Control
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00010577 File Offset: 0x0000E777
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0001057F File Offset: 0x0000E77F
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00010588 File Offset: 0x0000E788
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00010590 File Offset: 0x0000E790
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00010599 File Offset: 0x0000E799
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000105A1 File Offset: 0x0000E7A1
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000105AA File Offset: 0x0000E7AA
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000105B2 File Offset: 0x0000E7B2
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000105BB File Offset: 0x0000E7BB
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000105C3 File Offset: 0x0000E7C3
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x000105CC File Offset: 0x0000E7CC
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x000105D4 File Offset: 0x0000E7D4
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000105DD File Offset: 0x0000E7DD
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000105E5 File Offset: 0x0000E7E5
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000105EE File Offset: 0x0000E7EE
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000105F6 File Offset: 0x0000E7F6
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

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060002DC RID: 732 RVA: 0x00010600 File Offset: 0x0000E800
		// (remove) Token: 0x060002DD RID: 733 RVA: 0x00010638 File Offset: 0x0000E838
		public event LogInHorizontalScrollBar.ScrollEventHandler Scroll;

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0001066D File Offset: 0x0000E86D
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00010675 File Offset: 0x0000E875
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x000106A4 File Offset: 0x0000E8A4
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x000106AC File Offset: 0x0000E8AC
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x000106CE File Offset: 0x0000E8CE
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x000106D8 File Offset: 0x0000E8D8
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
					LogInHorizontalScrollBar.ScrollEventHandler scrollEvent = this.ScrollEvent;
					if (scrollEvent != null)
					{
						scrollEvent(this);
					}
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0001073C File Offset: 0x0000E93C
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00010744 File Offset: 0x0000E944
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00010767 File Offset: 0x0000E967
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0001076F File Offset: 0x0000E96F
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0001077C File Offset: 0x0000E97C
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00010784 File Offset: 0x0000E984
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

		// Token: 0x060002EA RID: 746 RVA: 0x0001079B File Offset: 0x0000E99B
		protected override void OnSizeChanged(EventArgs e)
		{
			this.InvalidateLayout();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000107A4 File Offset: 0x0000E9A4
		public void InvalidateLayout()
		{
			this.LSA = new Rectangle(0, 1, 0, base.Height);
			checked
			{
				this.Shaft = new Rectangle(this.LSA.Right + 1, 0, base.Width - 3, base.Height);
				this.ShowThumb = (this._Maximum - this._Minimum != 0);
				this.Thumb = new Rectangle(0, 1, this._ThumbSize, base.Height - 3);
				LogInHorizontalScrollBar.ScrollEventHandler scrollEvent = this.ScrollEvent;
				if (scrollEvent != null)
				{
					scrollEvent(this);
				}
				this.InvalidatePosition();
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00010834 File Offset: 0x0000EA34
		public void InvalidatePosition()
		{
			this.Thumb.X = checked((int)Math.Round(unchecked(checked((double)(this._Value - this._Minimum) / (double)(this._Maximum - this._Minimum)) * (double)(checked(this.Shaft.Width - this._ThumbSize)) + 1.0)));
			base.Invalidate();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00010894 File Offset: 0x0000EA94
		protected override void OnMouseDown(MouseEventArgs e)
		{
			checked
			{
				if (e.Button == MouseButtons.Left && this.ShowThumb)
				{
					if (this.LSA.Contains(e.Location))
					{
						this.ThumbMovement = this._Value - this._SmallChange;
					}
					else if (this.RSA.Contains(e.Location))
					{
						this.ThumbMovement = this._Value + this._SmallChange;
					}
					else
					{
						if (this.Thumb.Contains(e.Location))
						{
							this.ThumbDown = true;
							return;
						}
						if (e.X < this.Thumb.X)
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

		// Token: 0x060002EE RID: 750 RVA: 0x0001098C File Offset: 0x0000EB8C
		protected override void OnMouseMove(MouseEventArgs e)
		{
			checked
			{
				if (this.ThumbDown && this.ShowThumb)
				{
					int num = e.X - this.LSA.Width - this._ThumbSize / 2;
					int num2 = this.Shaft.Width - this._ThumbSize;
					this.ThumbMovement = (int)Math.Round(unchecked((double)num / (double)num2 * (double)(checked(this._Maximum - this._Minimum)))) + this._Minimum;
					this.Value = Math.Min(Math.Max(this.ThumbMovement, this._Minimum), this._Maximum);
					this.InvalidatePosition();
				}
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00010A2A File Offset: 0x0000EC2A
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.ThumbDown = false;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00010A34 File Offset: 0x0000EC34
		public LogInHorizontalScrollBar()
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
			this.ThumbDown = false;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Height = 18;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00010B2C File Offset: 0x0000ED2C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(Color.FromArgb(47, 47, 47));
			checked
			{
				Point[] points = new Point[]
				{
					new Point(5, (int)Math.Round((double)base.Height / 2.0)),
					new Point(13, (int)Math.Round((double)base.Height / 4.0)),
					new Point(13, (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))),
					new Point(base.Width - 13, (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))),
					new Point(base.Width - 13, (int)Math.Round((double)base.Height / 4.0)),
					new Point(base.Width - 5, (int)Math.Round((double)base.Height / 2.0)),
					new Point(base.Width - 13, (int)Math.Round(unchecked((double)base.Height - (double)base.Height / 4.0 - 1.0))),
					new Point(base.Width - 13, (int)Math.Round(unchecked((double)base.Height / 2.0 + 2.0))),
					new Point(13, (int)Math.Round(unchecked((double)base.Height / 2.0 + 2.0))),
					new Point(13, (int)Math.Round(unchecked((double)base.Height - (double)base.Height / 4.0 - 1.0)))
				};
				graphics.FillPolygon(new SolidBrush(this._ArrowColour), points);
				graphics.FillRectangle(new SolidBrush(this._ThumbColour), this.Thumb);
				graphics.DrawRectangle(new Pen(this._ThumbBorder), this.Thumb);
				graphics.DrawRectangle(new Pen(this._ThumbSecondBorder), this.Thumb.X + 1, this.Thumb.Y + 1, this.Thumb.Width - 2, this.Thumb.Height - 2);
				graphics.DrawLine(new Pen(this._LineColour, 2f), new Point(this.Thumb.X + 4, (int)Math.Round(unchecked((double)this.Thumb.Height / 2.0 + 1.0))), new Point(this.Thumb.Right - 4, (int)Math.Round(unchecked((double)this.Thumb.Height / 2.0 + 1.0))));
				graphics.DrawRectangle(new Pen(this._FirstBorder), 0, 0, base.Width - 1, base.Height - 1);
				graphics.DrawRectangle(new Pen(this._SecondBorder), 1, 1, base.Width - 3, base.Height - 3);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x04000123 RID: 291
		public int ThumbMovement;

		// Token: 0x04000124 RID: 292
		public Rectangle LSA;

		// Token: 0x04000125 RID: 293
		public Rectangle RSA;

		// Token: 0x04000126 RID: 294
		public Rectangle Shaft;

		// Token: 0x04000127 RID: 295
		public Rectangle Thumb;

		// Token: 0x04000128 RID: 296
		public bool ShowThumb;

		// Token: 0x04000129 RID: 297
		public bool ThumbPressed;

		// Token: 0x0400012A RID: 298
		public int _ThumbSize;

		// Token: 0x0400012B RID: 299
		public int _Minimum;

		// Token: 0x0400012C RID: 300
		public int _Maximum;

		// Token: 0x0400012D RID: 301
		public int _Value;

		// Token: 0x0400012E RID: 302
		public int _SmallChange;

		// Token: 0x0400012F RID: 303
		public int _ButtonSize;

		// Token: 0x04000130 RID: 304
		public int _LargeChange;

		// Token: 0x04000131 RID: 305
		public Color _ThumbBorder;

		// Token: 0x04000132 RID: 306
		public Color _LineColour;

		// Token: 0x04000133 RID: 307
		public Color _ArrowColour;

		// Token: 0x04000134 RID: 308
		public Color _BaseColour;

		// Token: 0x04000135 RID: 309
		public Color _ThumbColour;

		// Token: 0x04000136 RID: 310
		public Color _ThumbSecondBorder;

		// Token: 0x04000137 RID: 311
		public Color _FirstBorder;

		// Token: 0x04000138 RID: 312
		public Color _SecondBorder;

		// Token: 0x04000139 RID: 313
		public bool ThumbDown;

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000368 RID: 872
		public delegate void ScrollEventHandler(object sender);
	}
}
