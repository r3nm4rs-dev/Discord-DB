using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000021 RID: 33
	public class LogInStatusBar : Control
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0000DEBC File Offset: 0x0000C0BC
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000DEC5 File Offset: 0x0000C0C5
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0000DECD File Offset: 0x0000C0CD
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

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000DED6 File Offset: 0x0000C0D6
		// (set) Token: 0x06000244 RID: 580 RVA: 0x0000DEDE File Offset: 0x0000C0DE
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

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000DEE7 File Offset: 0x0000C0E7
		// (set) Token: 0x06000246 RID: 582 RVA: 0x0000DEEF File Offset: 0x0000C0EF
		[Category("Control")]
		public LogInStatusBar.Alignments Alignment
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

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000DEF8 File Offset: 0x0000C0F8
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000DF00 File Offset: 0x0000C100
		[Category("Control")]
		public LogInStatusBar.LinesCount LinesToShow
		{
			get
			{
				return this._LinesToShow;
			}
			set
			{
				this._LinesToShow = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000DF09 File Offset: 0x0000C109
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000DF11 File Offset: 0x0000C111
		public bool ShowBorder
		{
			get
			{
				return this._ShowBorder;
			}
			set
			{
				this._ShowBorder = value;
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000DF1A File Offset: 0x0000C11A
		protected override void CreateHandle()
		{
			base.CreateHandle();
			this.Dock = DockStyle.Bottom;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000A32A File Offset: 0x0000852A
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000DF29 File Offset: 0x0000C129
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000DF31 File Offset: 0x0000C131
		[Category("Colours")]
		public Color RectangleColor
		{
			get
			{
				return this._RectColour;
			}
			set
			{
				this._RectColour = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000DF3A File Offset: 0x0000C13A
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000DF42 File Offset: 0x0000C142
		public bool ShowLine
		{
			get
			{
				return this._ShowLine;
			}
			set
			{
				this._ShowLine = value;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000DF4C File Offset: 0x0000C14C
		public LogInStatusBar()
		{
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._TextColour = Color.White;
			this._RectColour = Color.FromArgb(21, 117, 149);
			this._ShowLine = true;
			this._LinesToShow = LogInStatusBar.LinesCount.One;
			this._Alignment = LogInStatusBar.Alignments.Left;
			this._ShowBorder = true;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 9f);
			this.ForeColor = Color.White;
			base.Size = new Size(base.Width, 20);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000E004 File Offset: 0x0000C204
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			Graphics graphics2 = graphics;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.Clear(this.BaseColour);
			graphics2.FillRectangle(new SolidBrush(this.BaseColour), rect);
			checked
			{
				if (this._ShowLine)
				{
					LogInStatusBar.LinesCount linesToShow = this._LinesToShow;
					if (linesToShow != LogInStatusBar.LinesCount.One)
					{
						if (linesToShow == LogInStatusBar.LinesCount.Two)
						{
							if (this._Alignment == LogInStatusBar.Alignments.Left)
							{
								graphics2.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(22, 2, base.Width, base.Height), new StringFormat
								{
									Alignment = StringAlignment.Near,
									LineAlignment = StringAlignment.Near
								});
							}
							else if (this._Alignment == LogInStatusBar.Alignments.Center)
							{
								graphics2.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(0, 0, base.Width, base.Height), new StringFormat
								{
									Alignment = StringAlignment.Center,
									LineAlignment = StringAlignment.Center
								});
							}
							else
							{
								graphics2.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(0, 0, base.Width - 22, base.Height), new StringFormat
								{
									Alignment = StringAlignment.Far,
									LineAlignment = StringAlignment.Center
								});
							}
							graphics2.FillRectangle(new SolidBrush(this._RectColour), new Rectangle(5, 9, 14, 3));
							graphics2.FillRectangle(new SolidBrush(this._RectColour), new Rectangle(base.Width - 20, 9, 14, 3));
						}
					}
					else
					{
						if (this._Alignment == LogInStatusBar.Alignments.Left)
						{
							graphics2.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(22, 2, base.Width, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Near,
								LineAlignment = StringAlignment.Near
							});
						}
						else if (this._Alignment == LogInStatusBar.Alignments.Center)
						{
							graphics2.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(0, 0, base.Width, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Center,
								LineAlignment = StringAlignment.Center
							});
						}
						else
						{
							graphics2.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(0, 0, base.Width - 5, base.Height), new StringFormat
							{
								Alignment = StringAlignment.Far,
								LineAlignment = StringAlignment.Center
							});
						}
						graphics2.FillRectangle(new SolidBrush(this._RectColour), new Rectangle(5, 9, 14, 3));
					}
				}
				else
				{
					graphics2.DrawString(this.Text, this.Font, Brushes.White, new Rectangle(5, 2, base.Width, base.Height), new StringFormat
					{
						Alignment = StringAlignment.Near,
						LineAlignment = StringAlignment.Near
					});
				}
				if (this._ShowBorder)
				{
					graphics2.DrawLine(new Pen(this._BorderColour, 2f), new Point(0, 0), new Point(base.Width, 0));
				}
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000DF RID: 223
		public Color _BaseColour;

		// Token: 0x040000E0 RID: 224
		public Color _BorderColour;

		// Token: 0x040000E1 RID: 225
		public Color _TextColour;

		// Token: 0x040000E2 RID: 226
		public Color _RectColour;

		// Token: 0x040000E3 RID: 227
		public bool _ShowLine;

		// Token: 0x040000E4 RID: 228
		public LogInStatusBar.LinesCount _LinesToShow;

		// Token: 0x040000E5 RID: 229
		public LogInStatusBar.Alignments _Alignment;

		// Token: 0x040000E6 RID: 230
		public bool _ShowBorder;

		// Token: 0x02000038 RID: 56
		public enum LinesCount
		{
			// Token: 0x04000174 RID: 372
			One = 1,
			// Token: 0x04000175 RID: 373
			Two
		}

		// Token: 0x02000039 RID: 57
		public enum Alignments
		{
			// Token: 0x04000177 RID: 375
			Left,
			// Token: 0x04000178 RID: 376
			Center,
			// Token: 0x04000179 RID: 377
			Right
		}
	}
}
