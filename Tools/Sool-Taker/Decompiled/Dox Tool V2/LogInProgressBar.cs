using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x0200001F RID: 31
	public class LogInProgressBar : Control
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000D75B File Offset: 0x0000B95B
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000D763 File Offset: 0x0000B963
		public Color SecondColour
		{
			get
			{
				return this._SecondColour;
			}
			set
			{
				this._SecondColour = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000D76C File Offset: 0x0000B96C
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000D774 File Offset: 0x0000B974
		[Category("Control")]
		public bool TwoColour
		{
			get
			{
				return this._TwoColour;
			}
			set
			{
				this._TwoColour = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000D77D File Offset: 0x0000B97D
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0000D785 File Offset: 0x0000B985
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000D7C7 File Offset: 0x0000B9C7
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000D7ED File Offset: 0x0000B9ED
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0000D7F5 File Offset: 0x0000B9F5
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000D7FE File Offset: 0x0000B9FE
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0000D806 File Offset: 0x0000BA06
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000D80F File Offset: 0x0000BA0F
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0000D817 File Offset: 0x0000BA17
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000D820 File Offset: 0x0000BA20
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0000D828 File Offset: 0x0000BA28
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

		// Token: 0x06000227 RID: 551 RVA: 0x0000D831 File Offset: 0x0000BA31
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 25;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000D842 File Offset: 0x0000BA42
		protected override void CreateHandle()
		{
			base.CreateHandle();
			base.Height = 25;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000D852 File Offset: 0x0000BA52
		public void Increment(int Amount)
		{
			checked
			{
				this.Value += Amount;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000D864 File Offset: 0x0000BA64
		public LogInProgressBar()
		{
			this._ProgressColour = Color.FromArgb(0, 160, 199);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._FontColour = Color.FromArgb(50, 50, 50);
			this._SecondColour = Color.FromArgb(0, 145, 184);
			this._Value = 0;
			this._Maximum = 100;
			this._TwoColour = true;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000D900 File Offset: 0x0000BB00
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(this.BackColor);
			checked
			{
				int num = (int)Math.Round(unchecked((double)this._Value / (double)this._Maximum * (double)base.Width));
				int value = this.Value;
				if (value == 0)
				{
					graphics2.FillRectangle(new SolidBrush(this._BaseColour), rect);
					graphics2.FillRectangle(new SolidBrush(this._ProgressColour), new Rectangle(0, 0, num - 1, base.Height));
					graphics2.DrawRectangle(new Pen(this._BorderColour, 3f), rect);
				}
				else if (value == this._Maximum)
				{
					graphics2.FillRectangle(new SolidBrush(this._BaseColour), rect);
					graphics2.FillRectangle(new SolidBrush(this._ProgressColour), new Rectangle(0, 0, num - 1, base.Height));
					if (this._TwoColour)
					{
						graphics.SetClip(new Rectangle(0, -10, (int)Math.Round(unchecked((double)(checked(base.Width * this._Value)) / (double)this._Maximum - 1.0)), base.Height - 5));
						double num2 = (double)((base.Width - 1) * this._Maximum) / (double)this._Value;
						for (double num3 = 0.0; num3 <= num2; num3 = unchecked(num3 + 25.0))
						{
							graphics.DrawLine(new Pen(new SolidBrush(this._SecondColour), 7f), new Point((int)Math.Round(num3), 0), new Point((int)Math.Round(unchecked(num3 - 15.0)), base.Height));
						}
						graphics.ResetClip();
					}
					graphics2.DrawRectangle(new Pen(this._BorderColour, 3f), rect);
				}
				else
				{
					graphics2.FillRectangle(new SolidBrush(this._BaseColour), rect);
					graphics2.FillRectangle(new SolidBrush(this._ProgressColour), new Rectangle(0, 0, num - 1, base.Height));
					if (this._TwoColour)
					{
						graphics2.SetClip(new Rectangle(0, 0, (int)Math.Round(unchecked((double)(checked(base.Width * this._Value)) / (double)this._Maximum - 1.0)), base.Height - 1));
						double num4 = (double)((base.Width - 1) * this._Maximum) / (double)this._Value;
						for (double num5 = 0.0; num5 <= num4; num5 = unchecked(num5 + 25.0))
						{
							graphics2.DrawLine(new Pen(new SolidBrush(this._SecondColour), 7f), new Point((int)Math.Round(num5), 0), new Point((int)Math.Round(unchecked(num5 - 10.0)), base.Height));
						}
						graphics2.ResetClip();
					}
					graphics2.DrawRectangle(new Pen(this._BorderColour, 3f), rect);
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000D3 RID: 211
		public Color _ProgressColour;

		// Token: 0x040000D4 RID: 212
		public Color _BorderColour;

		// Token: 0x040000D5 RID: 213
		public Color _BaseColour;

		// Token: 0x040000D6 RID: 214
		public Color _FontColour;

		// Token: 0x040000D7 RID: 215
		public Color _SecondColour;

		// Token: 0x040000D8 RID: 216
		public int _Value;

		// Token: 0x040000D9 RID: 217
		public int _Maximum;

		// Token: 0x040000DA RID: 218
		public bool _TwoColour;
	}
}
