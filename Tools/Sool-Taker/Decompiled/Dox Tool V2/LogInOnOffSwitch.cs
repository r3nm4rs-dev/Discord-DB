using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000022 RID: 34
	public class LogInOnOffSwitch : Control
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000E348 File Offset: 0x0000C548
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000E350 File Offset: 0x0000C550
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000E359 File Offset: 0x0000C559
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000E361 File Offset: 0x0000C561
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

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000E36A File Offset: 0x0000C56A
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0000E372 File Offset: 0x0000C572
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000E37B File Offset: 0x0000C57B
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000E383 File Offset: 0x0000C583
		[Category("Colours")]
		public Color NonToggledTextColourderColour
		{
			get
			{
				return this._NonToggledTextColour;
			}
			set
			{
				this._NonToggledTextColour = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000E38C File Offset: 0x0000C58C
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000E394 File Offset: 0x0000C594
		[Category("Colours")]
		public Color ToggledColour
		{
			get
			{
				return this._ToggledColour;
			}
			set
			{
				this._ToggledColour = value;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600025D RID: 605 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		// (remove) Token: 0x0600025E RID: 606 RVA: 0x0000E3D8 File Offset: 0x0000C5D8
		public event LogInOnOffSwitch.ToggledChangedEventHandler ToggledChanged;

		// Token: 0x0600025F RID: 607 RVA: 0x0000E410 File Offset: 0x0000C610
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.MouseXLoc = e.Location.X;
			base.Invalidate();
			if (e.X < checked(base.Width - 40) && e.X > 40)
			{
				this.Cursor = Cursors.IBeam;
				return;
			}
			this.Cursor = Cursors.Arrow;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000E470 File Offset: 0x0000C670
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (this.MouseXLoc > checked(base.Width - 39))
			{
				this._Toggled = LogInOnOffSwitch.Toggles.Toggled;
				this.ToggledValue();
			}
			else if (this.MouseXLoc < 39)
			{
				this._Toggled = LogInOnOffSwitch.Toggles.NotToggled;
				this.ToggledValue();
			}
			base.Invalidate();
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000E4C1 File Offset: 0x0000C6C1
		// (set) Token: 0x06000262 RID: 610 RVA: 0x0000E4C9 File Offset: 0x0000C6C9
		public LogInOnOffSwitch.Toggles Toggled
		{
			get
			{
				return this._Toggled;
			}
			set
			{
				this._Toggled = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		public void ToggledValue()
		{
			checked
			{
				if (this._Toggled > LogInOnOffSwitch.Toggles.Toggled)
				{
					if (this.ToggleLocation < 100)
					{
						ref int ptr = ref this.ToggleLocation;
						this.ToggleLocation = ptr + 10;
					}
				}
				else if (this.ToggleLocation > 0)
				{
					ref int ptr = ref this.ToggleLocation;
					this.ToggleLocation = ptr - 10;
				}
				base.Invalidate();
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000E528 File Offset: 0x0000C728
		public LogInOnOffSwitch()
		{
			this._Toggled = LogInOnOffSwitch.Toggles.NotToggled;
			this.ToggleLocation = 0;
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._NonToggledTextColour = Color.FromArgb(155, 155, 155);
			this._ToggledColour = Color.FromArgb(23, 119, 151);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.Clear(base.Parent.FindForm().BackColor);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.FillRectangle(new SolidBrush(this._BaseColour), new Rectangle(0, 0, 39, base.Height));
			checked
			{
				graphics.FillRectangle(new SolidBrush(this._BaseColour), new Rectangle(base.Width - 40, 0, base.Width, base.Height));
				graphics.FillRectangle(new SolidBrush(this._BaseColour), new Rectangle(38, 9, base.Width - 40, 5));
				Point[] points = new Point[]
				{
					new Point(0, 0),
					new Point(39, 0),
					new Point(39, 9),
					new Point(base.Width - 40, 9),
					new Point(base.Width - 40, 0),
					new Point(base.Width - 2, 0),
					new Point(base.Width - 2, base.Height - 1),
					new Point(base.Width - 40, base.Height - 1),
					new Point(base.Width - 40, 14),
					new Point(39, 14),
					new Point(39, base.Height - 1),
					new Point(0, base.Height - 1),
					default(Point)
				};
				graphics.DrawLines(new Pen(this._BorderColour, 2f), points);
				if (this._Toggled == LogInOnOffSwitch.Toggles.Toggled)
				{
					graphics.FillRectangle(new SolidBrush(this._ToggledColour), new Rectangle((int)Math.Round((double)base.Width / 2.0), 10, (int)Math.Round(unchecked((double)base.Width / 2.0 - 38.0)), 3));
					graphics.FillRectangle(new SolidBrush(this._ToggledColour), new Rectangle(base.Width - 39, 2, 36, base.Height - 5));
				}
				if (this._Toggled == LogInOnOffSwitch.Toggles.Toggled)
				{
					graphics.DrawString("TRUE", new Font("Microsoft Sans Serif", 7f, FontStyle.Bold), new SolidBrush(this._TextColour), new Rectangle(2, -1, (int)Math.Round(unchecked((double)(checked(base.Width - 20)) + 6.666666666666667)), base.Height), new StringFormat
					{
						Alignment = StringAlignment.Far,
						LineAlignment = StringAlignment.Center
					});
					graphics.DrawString("TRUE", new Font("Microsoft Sans Serif", 7f, FontStyle.Bold), new SolidBrush(this._NonToggledTextColour), new Rectangle(7, -1, (int)Math.Round(unchecked((double)(checked(base.Width - 20)) + 6.666666666666667)), base.Height), new StringFormat
					{
						Alignment = StringAlignment.Near,
						LineAlignment = StringAlignment.Center
					});
				}
				else if (this._Toggled == LogInOnOffSwitch.Toggles.NotToggled)
				{
					graphics.DrawString("TRUE", new Font("Microsoft Sans Serif", 7f, FontStyle.Bold), new SolidBrush(this._TextColour), new Rectangle(7, -1, (int)Math.Round(unchecked((double)(checked(base.Width - 20)) + 6.666666666666667)), base.Height), new StringFormat
					{
						Alignment = StringAlignment.Near,
						LineAlignment = StringAlignment.Center
					});
					graphics.DrawString("TRUE", new Font("Microsoft Sans Serif", 7f, FontStyle.Bold), new SolidBrush(this._NonToggledTextColour), new Rectangle(2, -1, (int)Math.Round(unchecked((double)(checked(base.Width - 20)) + 6.666666666666667)), base.Height), new StringFormat
					{
						Alignment = StringAlignment.Far,
						LineAlignment = StringAlignment.Center
					});
				}
				graphics.DrawLine(new Pen(this._BorderColour, 2f), new Point((int)Math.Round((double)base.Width / 2.0), 0), new Point((int)Math.Round((double)base.Width / 2.0), base.Height));
			}
		}

		// Token: 0x040000E7 RID: 231
		public LogInOnOffSwitch.Toggles _Toggled;

		// Token: 0x040000E8 RID: 232
		public int MouseXLoc;

		// Token: 0x040000E9 RID: 233
		public int ToggleLocation;

		// Token: 0x040000EA RID: 234
		public Color _BaseColour;

		// Token: 0x040000EB RID: 235
		public Color _BorderColour;

		// Token: 0x040000EC RID: 236
		public Color _TextColour;

		// Token: 0x040000ED RID: 237
		public Color _NonToggledTextColour;

		// Token: 0x040000EE RID: 238
		public Color _ToggledColour;

		// Token: 0x0200003A RID: 58
		public enum Toggles
		{
			// Token: 0x0400017B RID: 379
			Toggled,
			// Token: 0x0400017C RID: 380
			NotToggled
		}

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600035C RID: 860
		public delegate void ToggledChangedEventHandler();
	}
}
