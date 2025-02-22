using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000023 RID: 35
	public class LogInComboBox : ComboBox
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000EA2D File Offset: 0x0000CC2D
		// (set) Token: 0x06000267 RID: 615 RVA: 0x0000EA35 File Offset: 0x0000CC35
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000EA3E File Offset: 0x0000CC3E
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000EA46 File Offset: 0x0000CC46
		[Category("Colours")]
		public Color SqaureColour
		{
			get
			{
				return this._SqaureColour;
			}
			set
			{
				this._SqaureColour = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000EA4F File Offset: 0x0000CC4F
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000EA57 File Offset: 0x0000CC57
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000EA60 File Offset: 0x0000CC60
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0000EA68 File Offset: 0x0000CC68
		[Category("Colours")]
		public Color SqaureHoverColour
		{
			get
			{
				return this._SqaureHoverColour;
			}
			set
			{
				this._SqaureHoverColour = value;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000EA71 File Offset: 0x0000CC71
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000EA87 File Offset: 0x0000CC87
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000EA9D File Offset: 0x0000CC9D
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000EAA5 File Offset: 0x0000CCA5
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000EAAE File Offset: 0x0000CCAE
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0000EAB6 File Offset: 0x0000CCB6
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000EABF File Offset: 0x0000CCBF
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0000EAC7 File Offset: 0x0000CCC7
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		public int StartIndex
		{
			get
			{
				return this._StartIndex;
			}
			set
			{
				this._StartIndex = value;
				try
				{
					base.SelectedIndex = value;
				}
				catch (Exception ex)
				{
				}
				base.Invalidate();
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000EB18 File Offset: 0x0000CD18
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000EB27 File Offset: 0x0000CD27
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.Invalidate();
			this.OnMouseClick(e);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000EB36 File Offset: 0x0000CD36
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.Invalidate();
			base.OnMouseUp(e);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000EB48 File Offset: 0x0000CD48
		public void ReplaceItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			checked
			{
				Rectangle rect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width + 1, e.Bounds.Height + 1);
				try
				{
					Graphics graphics = e.Graphics;
					if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
					{
						graphics.FillRectangle(new SolidBrush(this._SqaureColour), rect);
						graphics.DrawString(base.GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index])), this.Font, new SolidBrush(this._FontColour), 1f, (float)(e.Bounds.Top + 2));
					}
					else
					{
						graphics.FillRectangle(new SolidBrush(this._BaseColour), rect);
						graphics.DrawString(base.GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index])), this.Font, new SolidBrush(this._FontColour), 1f, (float)(e.Bounds.Top + 2));
					}
				}
				catch (Exception ex)
				{
				}
				e.DrawFocusRectangle();
				base.Invalidate();
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		public LogInComboBox()
		{
			base.DrawItem += this.ReplaceItem;
			this._StartIndex = 0;
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._FontColour = Color.FromArgb(255, 255, 255);
			this._LineColour = Color.FromArgb(23, 119, 151);
			this._SqaureColour = Color.FromArgb(47, 47, 47);
			this._ArrowColour = Color.FromArgb(30, 30, 30);
			this._SqaureHoverColour = Color.FromArgb(52, 52, 52);
			this.State = DrawHelpers.MouseState.None;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.BackColor = Color.Transparent;
			base.DrawMode = DrawMode.OwnerDrawFixed;
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			base.Width = 163;
			this.Font = new Font("Segoe UI", 10f);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this.BackColor);
			checked
			{
				try
				{
					Rectangle rect = new Rectangle(base.Width - 25, 0, base.Width, base.Height);
					graphics.FillRectangle(new SolidBrush(this._BaseColour), new Rectangle(0, 0, base.Width - 25, base.Height));
					DrawHelpers.MouseState state = this.State;
					if (state != DrawHelpers.MouseState.None)
					{
						if (state == DrawHelpers.MouseState.Over)
						{
							graphics.FillRectangle(new SolidBrush(this._SqaureHoverColour), rect);
						}
					}
					else
					{
						graphics.FillRectangle(new SolidBrush(this._SqaureColour), rect);
					}
					graphics.DrawLine(new Pen(this._LineColour, 2f), new Point(base.Width - 26, 1), new Point(base.Width - 26, base.Height - 1));
					try
					{
						graphics.DrawString(this.Text, this.Font, new SolidBrush(this._FontColour), new Rectangle(3, 0, base.Width - 20, base.Height), new StringFormat
						{
							LineAlignment = StringAlignment.Center,
							Alignment = StringAlignment.Near
						});
					}
					catch (Exception ex)
					{
					}
					graphics.DrawRectangle(new Pen(this._BorderColour, 2f), new Rectangle(0, 0, base.Width, base.Height));
					Point[] points = new Point[]
					{
						new Point(base.Width - 17, 11),
						new Point(base.Width - 13, 5),
						new Point(base.Width - 9, 11)
					};
					graphics.FillPolygon(new SolidBrush(this._BorderColour), points);
					graphics.DrawPolygon(new Pen(this._ArrowColour), points);
					Point[] points2 = new Point[]
					{
						new Point(base.Width - 17, 15),
						new Point(base.Width - 13, 21),
						new Point(base.Width - 9, 15)
					};
					graphics.FillPolygon(new SolidBrush(this._BorderColour), points2);
					graphics.DrawPolygon(new Pen(this._ArrowColour), points2);
				}
				catch (Exception ex2)
				{
				}
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics = null;
			}
		}

		// Token: 0x040000F0 RID: 240
		public int _StartIndex;

		// Token: 0x040000F1 RID: 241
		public Color _BorderColour;

		// Token: 0x040000F2 RID: 242
		public Color _BaseColour;

		// Token: 0x040000F3 RID: 243
		public Color _FontColour;

		// Token: 0x040000F4 RID: 244
		public Color _LineColour;

		// Token: 0x040000F5 RID: 245
		public Color _SqaureColour;

		// Token: 0x040000F6 RID: 246
		public Color _ArrowColour;

		// Token: 0x040000F7 RID: 247
		public Color _SqaureHoverColour;

		// Token: 0x040000F8 RID: 248
		private DrawHelpers.MouseState State;
	}
}
