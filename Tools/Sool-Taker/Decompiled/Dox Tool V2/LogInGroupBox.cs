using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000018 RID: 24
	public class LogInGroupBox : ContainerControl
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000C058 File Offset: 0x0000A258
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000C060 File Offset: 0x0000A260
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000C069 File Offset: 0x0000A269
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000C071 File Offset: 0x0000A271
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000C07A File Offset: 0x0000A27A
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000C082 File Offset: 0x0000A282
		[Category("Colours")]
		public Color HeaderColour
		{
			get
			{
				return this._HeaderColour;
			}
			set
			{
				this._HeaderColour = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000C08B File Offset: 0x0000A28B
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000C093 File Offset: 0x0000A293
		[Category("Colours")]
		public Color MainColour
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

		// Token: 0x060001AD RID: 429 RVA: 0x0000C09C File Offset: 0x0000A29C
		public LogInGroupBox()
		{
			this._MainColour = Color.FromArgb(47, 47, 47);
			this._HeaderColour = Color.FromArgb(42, 42, 42);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.Size = new Size(160, 110);
			this.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000C138 File Offset: 0x0000A338
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(Color.FromArgb(54, 54, 54));
			graphics.FillRectangle(new SolidBrush(this._MainColour), new Rectangle(0, 28, base.Width, base.Height));
			checked
			{
				graphics.FillRectangle(new SolidBrush(this._HeaderColour), new Rectangle(0, 0, (int)Math.Round((double)(unchecked(graphics.MeasureString(this.Text, this.Font).Width + 7f))), 28));
				graphics.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Point(5, 5));
				Point[] points = new Point[]
				{
					new Point(0, 0),
					new Point((int)Math.Round((double)(unchecked(graphics.MeasureString(this.Text, this.Font).Width + 7f))), 0),
					new Point((int)Math.Round((double)(unchecked(graphics.MeasureString(this.Text, this.Font).Width + 7f))), 28),
					new Point(base.Width - 1, 28),
					new Point(base.Width - 1, base.Height - 1),
					new Point(1, base.Height - 1),
					new Point(1, 1)
				};
				graphics.DrawLines(new Pen(this._BorderColour), points);
				graphics.DrawLine(new Pen(this._BorderColour, 2f), new Point(0, 28), new Point((int)Math.Round((double)(unchecked(graphics.MeasureString(this.Text, this.Font).Width + 7f))), 28));
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000AD RID: 173
		public Color _MainColour;

		// Token: 0x040000AE RID: 174
		public Color _HeaderColour;

		// Token: 0x040000AF RID: 175
		public Color _TextColour;

		// Token: 0x040000B0 RID: 176
		public Color _BorderColour;
	}
}
