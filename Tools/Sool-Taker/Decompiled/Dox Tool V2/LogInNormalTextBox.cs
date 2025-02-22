using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000012 RID: 18
	public class LogInNormalTextBox : Control
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000A683 File Offset: 0x00008883
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000A68B File Offset: 0x0000888B
		public virtual TextBox TB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000A694 File Offset: 0x00008894
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000A69C File Offset: 0x0000889C
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000A6B9 File Offset: 0x000088B9
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000A6C1 File Offset: 0x000088C1
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000A6DE File Offset: 0x000088DE
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000A6E6 File Offset: 0x000088E6
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000A703 File Offset: 0x00008903
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000A70B File Offset: 0x0000890B
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000A728 File Offset: 0x00008928
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000A730 File Offset: 0x00008930
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00009284 File Offset: 0x00007484
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000A784 File Offset: 0x00008984
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000092A9 File Offset: 0x000074A9
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000A7A4 File Offset: 0x000089A4
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
						this.TB.Width = base.Width - 6;
						if (!this._Multiline)
						{
							base.Height = this.TB.Height + 11;
						}
					}
				}
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000A80D File Offset: 0x00008A0D
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!base.Controls.Contains(this.TB))
			{
				base.Controls.Add(this.TB);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000A839 File Offset: 0x00008A39
		public void OnBaseTextChanged(object s, EventArgs e)
		{
			this.Text = this.TB.Text;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000A84C File Offset: 0x00008A4C
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

		// Token: 0x06000140 RID: 320 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		protected override void OnResize(EventArgs e)
		{
			this.TB.Location = new Point(5, 5);
			checked
			{
				this.TB.Width = base.Width - 10;
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000A910 File Offset: 0x00008B10
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000A918 File Offset: 0x00008B18
		public LogInNormalTextBox.Styles Style
		{
			get
			{
				return this._Style;
			}
			set
			{
				this._Style = value;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000A921 File Offset: 0x00008B21
		public void SelectAll()
		{
			this.TB.Focus();
			this.TB.SelectAll();
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000A93A File Offset: 0x00008B3A
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000A942 File Offset: 0x00008B42
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000A94B File Offset: 0x00008B4B
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000A953 File Offset: 0x00008B53
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000A95C File Offset: 0x00008B5C
		// (set) Token: 0x06000149 RID: 329 RVA: 0x0000A964 File Offset: 0x00008B64
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

		// Token: 0x0600014A RID: 330 RVA: 0x0000A96D File Offset: 0x00008B6D
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = DrawHelpers.MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000A983 File Offset: 0x00008B83
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = DrawHelpers.MouseState.Over;
			this.TB.Focus();
			base.Invalidate();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000A9A5 File Offset: 0x00008BA5
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000A9BC File Offset: 0x00008BBC
		public LogInNormalTextBox()
		{
			this.State = DrawHelpers.MouseState.None;
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._Style = LogInNormalTextBox.Styles.NotRounded;
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

		// Token: 0x0600014E RID: 334 RVA: 0x0000AB64 File Offset: 0x00008D64
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
			Graphics graphics2 = graphics;
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics2.SmoothingMode = SmoothingMode.HighQuality;
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics2.Clear(this.BackColor);
			this.TB.BackColor = Color.FromArgb(42, 42, 42);
			this.TB.ForeColor = Color.FromArgb(255, 255, 255);
			LogInNormalTextBox.Styles style = this._Style;
			if (style != LogInNormalTextBox.Styles.Rounded)
			{
				if (style == LogInNormalTextBox.Styles.NotRounded)
				{
					graphics2.FillRectangle(new SolidBrush(Color.FromArgb(42, 42, 42)), checked(new Rectangle(0, 0, base.Width - 1, base.Height - 1)));
					graphics2.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(35, 35, 35)), 2f), new Rectangle(0, 0, base.Width, base.Height));
				}
			}
			else
			{
				GraphicsPath graphicsPath = DrawHelpers.RoundRectangle(rectangle, 6);
				graphics2.FillPath(new SolidBrush(Color.FromArgb(42, 42, 42)), graphicsPath);
				graphics2.DrawPath(new Pen(new SolidBrush(Color.FromArgb(35, 35, 35)), 2f), graphicsPath);
				graphicsPath.Dispose();
			}
			graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
		}

		// Token: 0x0400007F RID: 127
		private DrawHelpers.MouseState State;

		// Token: 0x04000081 RID: 129
		public Color _BaseColour;

		// Token: 0x04000082 RID: 130
		public Color _TextColour;

		// Token: 0x04000083 RID: 131
		public Color _BorderColour;

		// Token: 0x04000084 RID: 132
		public LogInNormalTextBox.Styles _Style;

		// Token: 0x04000085 RID: 133
		public HorizontalAlignment _TextAlign;

		// Token: 0x04000086 RID: 134
		public int _MaxLength;

		// Token: 0x04000087 RID: 135
		public bool _ReadOnly;

		// Token: 0x04000088 RID: 136
		public bool _UseSystemPasswordChar;

		// Token: 0x04000089 RID: 137
		public bool _Multiline;

		// Token: 0x02000035 RID: 53
		public enum Styles
		{
			// Token: 0x0400016E RID: 366
			Rounded,
			// Token: 0x0400016F RID: 367
			NotRounded
		}
	}
}
