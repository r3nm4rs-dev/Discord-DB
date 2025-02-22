using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x0200000F RID: 15
	[DefaultEvent("TextChanged")]
	public class LogInPassTextBox : Control
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000097AB File Offset: 0x000079AB
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000097B3 File Offset: 0x000079B3
		public virtual TextBox TB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000097BC File Offset: 0x000079BC
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x000097C4 File Offset: 0x000079C4
		[Category("Options")]
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this._TextAlign;
			}
			set
			{
				this._TextAlign = value;
				if (this.TB != null)
				{
					this.TB.TextAlign = value;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000097E1 File Offset: 0x000079E1
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000097E9 File Offset: 0x000079E9
		[Category("Options")]
		public int MaxLength
		{
			get
			{
				return this._MaxLength;
			}
			set
			{
				this._MaxLength = value;
				if (this.TB != null)
				{
					this.TB.MaxLength = value;
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00009806 File Offset: 0x00007A06
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000980E File Offset: 0x00007A0E
		[Category("Options")]
		public bool ReadOnly
		{
			get
			{
				return this._ReadOnly;
			}
			set
			{
				this._ReadOnly = value;
				if (this.TB != null)
				{
					this.TB.ReadOnly = value;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000982B File Offset: 0x00007A2B
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00009833 File Offset: 0x00007A33
		[Category("Options")]
		public bool UseSystemPasswordChar
		{
			get
			{
				return this._UseSystemPasswordChar;
			}
			set
			{
				this._UseSystemPasswordChar = value;
				if (this.TB != null)
				{
					this.TB.UseSystemPasswordChar = value;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00009850 File Offset: 0x00007A50
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00009858 File Offset: 0x00007A58
		[Category("Options")]
		public bool Multiline
		{
			get
			{
				return this._Multiline;
			}
			set
			{
				this._Multiline = value;
				checked
				{
					if (this.TB != null)
					{
						this.TB.Multiline = value;
						if (value)
						{
							this.TB.Height = base.Height - 11;
							return;
						}
						base.Height = this.TB.Height + 11;
					}
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00009284 File Offset: 0x00007484
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000098AC File Offset: 0x00007AAC
		[Category("Options")]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				if (this.TB != null)
				{
					this.TB.Text = value;
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000092A9 File Offset: 0x000074A9
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000098CC File Offset: 0x00007ACC
		[Category("Options")]
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				base.Font = value;
				checked
				{
					if (this.TB != null)
					{
						this.TB.Font = value;
						this.TB.Location = new Point(3, 5);
						this.TB.Width = base.Width - 35;
						if (!this._Multiline)
						{
							base.Height = this.TB.Height + 11;
						}
					}
				}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00009936 File Offset: 0x00007B36
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!base.Controls.Contains(this.TB))
			{
				base.Controls.Add(this.TB);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00009962 File Offset: 0x00007B62
		public void OnBaseTextChanged(object s, EventArgs e)
		{
			this.Text = this.TB.Text;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00009978 File Offset: 0x00007B78
		public void OnBaseKeyDown(object s, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				this.TB.SelectAll();
				e.SuppressKeyPress = true;
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				this.TB.Copy();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000099D0 File Offset: 0x00007BD0
		protected override void OnResize(EventArgs e)
		{
			this.TB.Location = new Point(5, 5);
			checked
			{
				this.TB.Width = base.Width - 35;
				if (this._Multiline)
				{
					this.TB.Height = base.Height - 11;
				}
				else
				{
					base.Height = this.TB.Height + 11;
				}
				base.OnResize(e);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00009A3C File Offset: 0x00007C3C
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00009A44 File Offset: 0x00007C44
		[Category("Colours")]
		public Color BackgroundColour
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00009A4D File Offset: 0x00007C4D
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00009A55 File Offset: 0x00007C55
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00009A5E File Offset: 0x00007C5E
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00009A66 File Offset: 0x00007C66
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

		// Token: 0x060000FE RID: 254 RVA: 0x00009A6F File Offset: 0x00007C6F
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = DrawHelpers.MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00009A85 File Offset: 0x00007C85
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = DrawHelpers.MouseState.Over;
			this.TB.Focus();
			base.Invalidate();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00009AA7 File Offset: 0x00007CA7
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00009AC0 File Offset: 0x00007CC0
		public LogInPassTextBox()
		{
			this.State = DrawHelpers.MouseState.None;
			this._BaseColour = Color.FromArgb(255, 255, 255);
			this._TextColour = Color.FromArgb(50, 50, 50);
			this._BorderColour = Color.FromArgb(180, 187, 205);
			this._TextAlign = HorizontalAlignment.Left;
			this._MaxLength = 32767;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.BackColor = Color.Transparent;
			this.TB = new TextBox();
			this.TB.Height = 190;
			this.TB.Font = new Font("Segoe UI", 10f);
			this.TB.Text = this.Text;
			this.TB.BackColor = Color.FromArgb(42, 42, 42);
			this.TB.ForeColor = Color.FromArgb(255, 255, 255);
			this.TB.MaxLength = this._MaxLength;
			this.TB.Multiline = false;
			this.TB.ReadOnly = this._ReadOnly;
			this.TB.UseSystemPasswordChar = this._UseSystemPasswordChar;
			this.TB.BorderStyle = BorderStyle.None;
			this.TB.Location = new Point(5, 5);
			this.TB.Width = checked(base.Width - 35);
			this.TB.TextChanged += this.OnBaseTextChanged;
			this.TB.KeyDown += this.OnBaseKeyDown;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00009C6C File Offset: 0x00007E6C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this.BackColor);
			this.TB.BackColor = Color.FromArgb(42, 42, 42);
			this.TB.ForeColor = Color.FromArgb(255, 255, 255);
			GraphicsPath graphicsPath = DrawHelpers.RoundRectangle(rectangle, 6);
			graphics.FillPath(new SolidBrush(Color.FromArgb(42, 42, 42)), graphicsPath);
			graphics.DrawPath(new Pen(new SolidBrush(Color.FromArgb(35, 35, 35)), 2f), graphicsPath);
			graphicsPath.Dispose();
			checked
			{
				graphics.FillPie(new SolidBrush(base.FindForm().BackColor), new Rectangle(base.Width - 25, base.Height - 60, base.Height + 25, base.Height + 25), 90f, 90f);
				graphics.DrawPie(new Pen(Color.FromArgb(35, 35, 35), 2f), new Rectangle(base.Width - 25, base.Height - 60, base.Height + 25, base.Height + 25), 90f, 90f);
				graphics.FillEllipse(new SolidBrush(this._TextColour), new Rectangle(10, 5, 10, 7));
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x04000066 RID: 102
		private DrawHelpers.MouseState State;

		// Token: 0x04000068 RID: 104
		public Color _BaseColour;

		// Token: 0x04000069 RID: 105
		public Color _TextColour;

		// Token: 0x0400006A RID: 106
		public Color _BorderColour;

		// Token: 0x0400006B RID: 107
		public HorizontalAlignment _TextAlign;

		// Token: 0x0400006C RID: 108
		public int _MaxLength;

		// Token: 0x0400006D RID: 109
		public bool _ReadOnly;

		// Token: 0x0400006E RID: 110
		public bool _UseSystemPasswordChar;

		// Token: 0x0400006F RID: 111
		public bool _Multiline;
	}
}
