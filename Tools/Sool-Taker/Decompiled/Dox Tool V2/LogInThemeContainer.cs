using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x0200000D RID: 13
	public class LogInThemeContainer : ContainerControl
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00008958 File Offset: 0x00006B58
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00008960 File Offset: 0x00006B60
		[Category("Control")]
		public int FontSize
		{
			get
			{
				return this._FontSize;
			}
			set
			{
				this._FontSize = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00008969 File Offset: 0x00006B69
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00008971 File Offset: 0x00006B71
		[Category("Control")]
		public bool AllowMinimize
		{
			get
			{
				return this._AllowMinimize;
			}
			set
			{
				this._AllowMinimize = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000897A File Offset: 0x00006B7A
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00008982 File Offset: 0x00006B82
		[Category("Control")]
		public bool AllowMaximize
		{
			get
			{
				return this._AllowMaximize;
			}
			set
			{
				this._AllowMaximize = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000898B File Offset: 0x00006B8B
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00008993 File Offset: 0x00006B93
		[Category("Control")]
		public bool ShowIcon
		{
			get
			{
				return this._ShowIcon;
			}
			set
			{
				this._ShowIcon = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000899C File Offset: 0x00006B9C
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000089A4 File Offset: 0x00006BA4
		[Category("Control")]
		public bool AllowClose
		{
			get
			{
				return this._AllowClose;
			}
			set
			{
				this._AllowClose = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000089AD File Offset: 0x00006BAD
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000089B5 File Offset: 0x00006BB5
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000089BE File Offset: 0x00006BBE
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000089C6 File Offset: 0x00006BC6
		[Category("Colours")]
		public Color HoverColour
		{
			get
			{
				return this._HoverColour;
			}
			set
			{
				this._HoverColour = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000089CF File Offset: 0x00006BCF
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000089D7 File Offset: 0x00006BD7
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000089E0 File Offset: 0x00006BE0
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Category("Colours")]
		public Color ContainerColour
		{
			get
			{
				return this._ContainerColour;
			}
			set
			{
				this._ContainerColour = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000089F1 File Offset: 0x00006BF1
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000089F9 File Offset: 0x00006BF9
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

		// Token: 0x060000BD RID: 189 RVA: 0x00008A02 File Offset: 0x00006C02
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.CaptureMovement = false;
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00008A1F File Offset: 0x00006C1F
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00008A35 File Offset: 0x00006C35
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00008A4C File Offset: 0x00006C4C
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.MouseXLoc = e.Location.X;
			this.MouseYLoc = e.Location.Y;
			base.Invalidate();
			if (this.CaptureMovement)
			{
				base.Parent.Location = Control.MousePosition - (Size)this.MouseP;
			}
			if (e.X < checked(base.Width - 90) && e.Y > 35)
			{
				this.Cursor = Cursors.Arrow;
				return;
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00008AE8 File Offset: 0x00006CE8
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			checked
			{
				if (this.MouseXLoc > base.Width - 39 && this.MouseXLoc < base.Width - 16 && this.MouseYLoc < 22)
				{
					if (this._AllowClose)
					{
						Environment.Exit(0);
					}
				}
				else if (this.MouseXLoc > base.Width - 89 && this.MouseXLoc < base.Width - 66 && this.MouseYLoc < 22)
				{
					if (this._AllowMinimize)
					{
						FormWindowState windowState = base.FindForm().WindowState;
						if (windowState != FormWindowState.Normal)
						{
							if (windowState == FormWindowState.Maximized)
							{
								base.FindForm().WindowState = FormWindowState.Minimized;
							}
						}
						else
						{
							base.FindForm().WindowState = FormWindowState.Minimized;
						}
					}
				}
				else if (e.Button == MouseButtons.Left & new Rectangle(0, 0, base.Width - 90, 35).Contains(e.Location))
				{
					this.CaptureMovement = true;
					this.MouseP = e.Location;
				}
				else if (e.Button == MouseButtons.Left & new Rectangle(base.Width - 90, 22, 75, 13).Contains(e.Location))
				{
					this.CaptureMovement = true;
					this.MouseP = e.Location;
				}
				else if (e.Button == MouseButtons.Left & new Rectangle(base.Width - 15, 0, 15, 35).Contains(e.Location))
				{
					this.CaptureMovement = true;
					this.MouseP = e.Location;
				}
				else
				{
					base.Focus();
				}
				this.State = DrawHelpers.MouseState.Down;
				base.Invalidate();
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008C98 File Offset: 0x00006E98
		public LogInThemeContainer()
		{
			this._AllowClose = true;
			this._AllowMinimize = true;
			this._AllowMaximize = false;
			this._FontSize = 12;
			this._Font = new Font("Segoe UI", (float)this._FontSize);
			this._ShowIcon = true;
			this.State = DrawHelpers.MouseState.None;
			this.CaptureMovement = false;
			this.MouseP = new Point(0, 0);
			this._FontColour = Color.FromArgb(255, 255, 255);
			this._BaseColour = Color.FromArgb(35, 35, 35);
			this._ContainerColour = Color.FromArgb(54, 54, 54);
			this._BorderColour = Color.FromArgb(60, 60, 60);
			this._HoverColour = Color.FromArgb(42, 42, 42);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.BackColor = this._BaseColour;
			this.Dock = DockStyle.Fill;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00008D88 File Offset: 0x00006F88
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			base.ParentForm.FormBorderStyle = FormBorderStyle.None;
			base.ParentForm.AllowTransparency = false;
			base.ParentForm.TransparencyKey = Color.Fuchsia;
			base.ParentForm.FindForm().StartPosition = FormStartPosition.CenterScreen;
			this.Dock = DockStyle.Fill;
			base.Invalidate();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00008DE4 File Offset: 0x00006FE4
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.FillRectangle(new SolidBrush(this._BaseColour), new Rectangle(0, 0, base.Width, base.Height));
			checked
			{
				graphics.FillRectangle(new SolidBrush(this._ContainerColour), new Rectangle(2, 35, base.Width - 4, base.Height - 37));
				graphics.DrawRectangle(new Pen(this._BorderColour), new Rectangle(0, 0, base.Width, base.Height));
				Point[] points = new Point[]
				{
					new Point(base.Width - 90, 0),
					new Point(base.Width - 90, 22),
					new Point(base.Width - 15, 22),
					new Point(base.Width - 15, 0)
				};
				graphics.DrawLines(new Pen(this._BorderColour), points);
				graphics.DrawLine(new Pen(this._BorderColour), base.Width - 65, 0, base.Width - 65, 22);
				DrawHelpers.MouseState state = this.State;
				if (state == DrawHelpers.MouseState.Over)
				{
					if (this.MouseXLoc > base.Width - 39 && this.MouseXLoc < base.Width - 16 && this.MouseYLoc < 22)
					{
						graphics.FillRectangle(new SolidBrush(this._HoverColour), new Rectangle(base.Width - 39, 0, 23, 22));
					}
					else if (this.MouseXLoc > base.Width - 64 && this.MouseXLoc < base.Width - 41 && this.MouseYLoc < 22)
					{
						graphics.FillRectangle(new SolidBrush(this._HoverColour), new Rectangle(base.Width - 64, 0, 23, 22));
					}
					else if (this.MouseXLoc > base.Width - 89 && this.MouseXLoc < base.Width - 66 && this.MouseYLoc < 22)
					{
						graphics.FillRectangle(new SolidBrush(this._HoverColour), new Rectangle(base.Width - 89, 0, 23, 22));
					}
				}
				graphics.DrawLine(new Pen(this._BorderColour), base.Width - 40, 0, base.Width - 40, 22);
				graphics.DrawLine(new Pen(this._FontColour), base.Width - 33, 6, base.Width - 22, 16);
				graphics.DrawLine(new Pen(this._FontColour), base.Width - 33, 16, base.Width - 22, 6);
				graphics.DrawLine(new Pen(this._FontColour), base.Width - 83, 16, base.Width - 72, 16);
				if (this._ShowIcon)
				{
					graphics.DrawIcon(base.FindForm().Icon, new Rectangle(6, 6, 22, 22));
					graphics.DrawString(this.Text, this._Font, new SolidBrush(this._FontColour), new RectangleF(31f, 0f, (float)(base.Width - 110), 35f), new StringFormat
					{
						LineAlignment = StringAlignment.Center,
						Alignment = StringAlignment.Near
					});
				}
				else
				{
					graphics.DrawString(this.Text, this._Font, new SolidBrush(this._FontColour), new RectangleF(3f, 0f, (float)(base.Width - 110), 35f), new StringFormat
					{
						LineAlignment = StringAlignment.Center,
						Alignment = StringAlignment.Near
					});
				}
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x0400004B RID: 75
		public bool _AllowClose;

		// Token: 0x0400004C RID: 76
		public bool _AllowMinimize;

		// Token: 0x0400004D RID: 77
		public bool _AllowMaximize;

		// Token: 0x0400004E RID: 78
		public int _FontSize;

		// Token: 0x0400004F RID: 79
		public readonly Font _Font;

		// Token: 0x04000050 RID: 80
		public bool _ShowIcon;

		// Token: 0x04000051 RID: 81
		private DrawHelpers.MouseState State;

		// Token: 0x04000052 RID: 82
		public int MouseXLoc;

		// Token: 0x04000053 RID: 83
		public int MouseYLoc;

		// Token: 0x04000054 RID: 84
		public bool CaptureMovement;

		// Token: 0x04000055 RID: 85
		public const int MoveHeight = 35;

		// Token: 0x04000056 RID: 86
		public Point MouseP;

		// Token: 0x04000057 RID: 87
		public Color _FontColour;

		// Token: 0x04000058 RID: 88
		public Color _BaseColour;

		// Token: 0x04000059 RID: 89
		public Color _ContainerColour;

		// Token: 0x0400005A RID: 90
		public Color _BorderColour;

		// Token: 0x0400005B RID: 91
		public Color _HoverColour;
	}
}
