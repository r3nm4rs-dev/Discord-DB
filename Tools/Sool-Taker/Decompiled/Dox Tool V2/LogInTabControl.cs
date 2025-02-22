using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000024 RID: 36
	public class LogInTabControl : TabControl
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000F03C File Offset: 0x0000D23C
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000F044 File Offset: 0x0000D244
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000F04D File Offset: 0x0000D24D
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0000F055 File Offset: 0x0000D255
		[Category("Colours")]
		public Color UpLineColour
		{
			get
			{
				return this._UpLineColour;
			}
			set
			{
				this._UpLineColour = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000F05E File Offset: 0x0000D25E
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000F066 File Offset: 0x0000D266
		[Category("Colours")]
		public Color HorizontalLineColour
		{
			get
			{
				return this._HorizLineColour;
			}
			set
			{
				this._HorizLineColour = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000F06F File Offset: 0x0000D26F
		// (set) Token: 0x06000285 RID: 645 RVA: 0x0000F077 File Offset: 0x0000D277
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000F080 File Offset: 0x0000D280
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000F088 File Offset: 0x0000D288
		[Category("Colours")]
		public Color BackTabColour
		{
			get
			{
				return this._BackTabColour;
			}
			set
			{
				this._BackTabColour = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000F091 File Offset: 0x0000D291
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000F099 File Offset: 0x0000D299
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000F0A2 File Offset: 0x0000D2A2
		// (set) Token: 0x0600028B RID: 651 RVA: 0x0000F0AA File Offset: 0x0000D2AA
		[Category("Colours")]
		public Color ActiveColour
		{
			get
			{
				return this._ActiveColour;
			}
			set
			{
				this._ActiveColour = value;
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000F0B3 File Offset: 0x0000D2B3
		protected override void CreateHandle()
		{
			base.CreateHandle();
			base.Alignment = TabAlignment.Top;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		public LogInTabControl()
		{
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._BackTabColour = Color.FromArgb(54, 54, 54);
			this._BaseColour = Color.FromArgb(35, 35, 35);
			this._ActiveColour = Color.FromArgb(47, 47, 47);
			this._BorderColour = Color.FromArgb(30, 30, 30);
			this._UpLineColour = Color.FromArgb(0, 160, 199);
			this._HorizLineColour = Color.FromArgb(23, 119, 151);
			this.CenterSF = new StringFormat
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 10f);
			base.SizeMode = TabSizeMode.Normal;
			base.ItemSize = new Size(240, 32);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(this._BaseColour);
			try
			{
				base.SelectedTab.BackColor = this._BackTabColour;
			}
			catch (Exception ex)
			{
			}
			try
			{
				base.SelectedTab.BorderStyle = BorderStyle.FixedSingle;
			}
			catch (Exception ex2)
			{
			}
			graphics.DrawRectangle(new Pen(this._BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height));
			checked
			{
				int num = base.TabCount - 1;
				for (int i = 0; i <= num; i++)
				{
					Rectangle rectangle = new Rectangle(new Point(base.GetTabRect(i).Location.X, base.GetTabRect(i).Location.Y), new Size(base.GetTabRect(i).Width, base.GetTabRect(i).Height));
					Rectangle rectangle2 = new Rectangle(rectangle.Location, new Size(rectangle.Width, rectangle.Height));
					if (i == base.SelectedIndex)
					{
						graphics.FillRectangle(new SolidBrush(this._BaseColour), rectangle2);
						graphics.FillRectangle(new SolidBrush(this._ActiveColour), new Rectangle(rectangle.X + 1, rectangle.Y - 3, rectangle.Width, rectangle.Height + 5));
						graphics.DrawString(base.TabPages[i].Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(rectangle.X + 7, rectangle.Y, rectangle.Width - 3, rectangle.Height), this.CenterSF);
						graphics.DrawLine(new Pen(this._HorizLineColour, 2f), new Point(rectangle.X + 3, (int)Math.Round(unchecked((double)rectangle.Height / 2.0 + 2.0))), new Point(rectangle.X + 9, (int)Math.Round(unchecked((double)rectangle.Height / 2.0 + 2.0))));
						graphics.DrawLine(new Pen(this._UpLineColour, 2f), new Point(rectangle.X + 3, rectangle.Y - 3), new Point(rectangle.X + 3, rectangle.Height + 5));
					}
					else
					{
						graphics.DrawString(base.TabPages[i].Text, this.Font, new SolidBrush(this._TextColour), rectangle2, this.CenterSF);
					}
				}
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics = null;
			}
		}

		// Token: 0x040000F9 RID: 249
		public Color _TextColour;

		// Token: 0x040000FA RID: 250
		public Color _BackTabColour;

		// Token: 0x040000FB RID: 251
		public Color _BaseColour;

		// Token: 0x040000FC RID: 252
		public Color _ActiveColour;

		// Token: 0x040000FD RID: 253
		public Color _BorderColour;

		// Token: 0x040000FE RID: 254
		public Color _UpLineColour;

		// Token: 0x040000FF RID: 255
		public Color _HorizLineColour;

		// Token: 0x04000100 RID: 256
		public StringFormat CenterSF;
	}
}
