using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Dox_Tool_V2
{
	// Token: 0x02000013 RID: 19
	public class LogInRadialProgressBar : Control
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000ACA7 File Offset: 0x00008EA7
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000ACAF File Offset: 0x00008EAF
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000ACF3 File Offset: 0x00008EF3
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

		// Token: 0x06000153 RID: 339 RVA: 0x0000AD19 File Offset: 0x00008F19
		public void Increment(int Amount)
		{
			checked
			{
				this.Value += Amount;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000AD29 File Offset: 0x00008F29
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000AD31 File Offset: 0x00008F31
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000AD3A File Offset: 0x00008F3A
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000AD42 File Offset: 0x00008F42
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000AD4B File Offset: 0x00008F4B
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000AD53 File Offset: 0x00008F53
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000AD5C File Offset: 0x00008F5C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000AD64 File Offset: 0x00008F64
		[Category("Control")]
		public int StartingAngle
		{
			get
			{
				return this._StartingAngle;
			}
			set
			{
				this._StartingAngle = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000AD6D File Offset: 0x00008F6D
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000AD75 File Offset: 0x00008F75
		[Category("Control")]
		public int RotationAngle
		{
			get
			{
				return this._RotationAngle;
			}
			set
			{
				this._RotationAngle = value;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000AD80 File Offset: 0x00008F80
		public LogInRadialProgressBar()
		{
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._ProgressColour = Color.FromArgb(0, 160, 199);
			this._Value = 0;
			this._Maximum = 100;
			this._StartingAngle = 110;
			this._RotationAngle = 255;
			this._Font = new Font("Segoe UI", 20f);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(78, 78);
			this.BackColor = Color.Transparent;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000AE30 File Offset: 0x00009030
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this.BackColor);
			int value = this._Value;
			checked
			{
				if (value == 0)
				{
					graphics.DrawArc(new Pen(new SolidBrush(this._BorderColour), 6f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, this._StartingAngle - 3, this._RotationAngle + 5);
					graphics.DrawArc(new Pen(new SolidBrush(this._BaseColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, this._StartingAngle, this._RotationAngle);
					graphics.DrawString(Conversions.ToString(this._Value), this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round(unchecked((double)base.Height / 2.0 - 1.0))), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				else if (value == this._Maximum)
				{
					graphics.DrawArc(new Pen(new SolidBrush(this._BorderColour), 6f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, this._StartingAngle - 3, this._RotationAngle + 5);
					graphics.DrawArc(new Pen(new SolidBrush(this._BaseColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, this._StartingAngle, this._RotationAngle);
					graphics.DrawArc(new Pen(new SolidBrush(this._ProgressColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, this._StartingAngle, this._RotationAngle);
					graphics.DrawString(Conversions.ToString(this._Value), this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round(unchecked((double)base.Height / 2.0 - 1.0))), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawArc(new Pen(new SolidBrush(this._BorderColour), 6f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, this._StartingAngle - 3, this._RotationAngle + 5);
					graphics.DrawArc(new Pen(new SolidBrush(this._BaseColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, this._StartingAngle, this._RotationAngle);
					graphics.DrawArc(new Pen(new SolidBrush(this._ProgressColour), 4f), 3, 3, base.Width - 3 - 4, base.Height - 3 - 3, this._StartingAngle, (int)Math.Round(unchecked((double)this._RotationAngle / (double)this._Maximum * (double)this._Value)));
					graphics.DrawString(Conversions.ToString(this._Value), this._Font, Brushes.White, new Point((int)Math.Round((double)base.Width / 2.0), (int)Math.Round(unchecked((double)base.Height / 2.0 - 1.0))), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x0400008A RID: 138
		public Color _BorderColour;

		// Token: 0x0400008B RID: 139
		public Color _BaseColour;

		// Token: 0x0400008C RID: 140
		public Color _ProgressColour;

		// Token: 0x0400008D RID: 141
		public int _Value;

		// Token: 0x0400008E RID: 142
		public int _Maximum;

		// Token: 0x0400008F RID: 143
		public int _StartingAngle;

		// Token: 0x04000090 RID: 144
		public int _RotationAngle;

		// Token: 0x04000091 RID: 145
		public readonly Font _Font;
	}
}
