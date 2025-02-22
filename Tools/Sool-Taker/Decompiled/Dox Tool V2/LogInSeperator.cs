using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000019 RID: 25
	public class LogInSeperator : Control
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000C33B File Offset: 0x0000A53B
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000C343 File Offset: 0x0000A543
		[Category("Control")]
		public float Thickness
		{
			get
			{
				return this._Thickness;
			}
			set
			{
				this._Thickness = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000C34C File Offset: 0x0000A54C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000C354 File Offset: 0x0000A554
		[Category("Control")]
		public LogInSeperator.Style Alignment
		{
			get
			{
				return this._Alignment;
			}
			set
			{
				this._Alignment = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000C35D File Offset: 0x0000A55D
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0000C365 File Offset: 0x0000A565
		[Category("Colours")]
		public Color SeperatorColour
		{
			get
			{
				return this._SeperatorColour;
			}
			set
			{
				this._SeperatorColour = value;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000C370 File Offset: 0x0000A570
		public LogInSeperator()
		{
			this._SeperatorColour = Color.FromArgb(35, 35, 35);
			this._Alignment = LogInSeperator.Style.Horizontal;
			this._Thickness = 1f;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.BackColor = Color.Transparent;
			base.Size = new Size(20, 20);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			checked
			{
				new Rectangle(0, 0, base.Width - 1, base.Height - 1);
				Graphics graphics2 = graphics;
				graphics2.SmoothingMode = SmoothingMode.HighQuality;
				graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
				LogInSeperator.Style alignment = this._Alignment;
				if (alignment != LogInSeperator.Style.Horizontal)
				{
					if (alignment == LogInSeperator.Style.Verticle)
					{
						graphics2.DrawLine(new Pen(this._SeperatorColour, this._Thickness), new Point((int)Math.Round((double)base.Width / 2.0), 0), new Point((int)Math.Round((double)base.Width / 2.0), base.Height));
					}
				}
				else
				{
					graphics2.DrawLine(new Pen(this._SeperatorColour, this._Thickness), new Point(0, (int)Math.Round((double)base.Height / 2.0)), new Point(base.Width, (int)Math.Round((double)base.Height / 2.0)));
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000B1 RID: 177
		public Color _SeperatorColour;

		// Token: 0x040000B2 RID: 178
		public LogInSeperator.Style _Alignment;

		// Token: 0x040000B3 RID: 179
		public float _Thickness;

		// Token: 0x02000037 RID: 55
		public enum Style
		{
			// Token: 0x04000171 RID: 369
			Horizontal,
			// Token: 0x04000172 RID: 370
			Verticle
		}
	}
}
