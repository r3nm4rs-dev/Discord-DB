using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x0200000E RID: 14
	[DefaultEvent("TextChanged")]
	public class LogInUserTextBox : Control
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00009181 File Offset: 0x00007381
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00009189 File Offset: 0x00007389
		public virtual TextBox TB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00009192 File Offset: 0x00007392
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000919A File Offset: 0x0000739A
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000091B7 File Offset: 0x000073B7
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000091BF File Offset: 0x000073BF
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

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000091DC File Offset: 0x000073DC
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000091E4 File Offset: 0x000073E4
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00009201 File Offset: 0x00007401
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00009209 File Offset: 0x00007409
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00009226 File Offset: 0x00007426
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00009230 File Offset: 0x00007430
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00009284 File Offset: 0x00007484
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000928C File Offset: 0x0000748C
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000092A9 File Offset: 0x000074A9
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000092B4 File Offset: 0x000074B4
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

		// Token: 0x060000D5 RID: 213 RVA: 0x0000931E File Offset: 0x0000751E
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!base.Controls.Contains(this.TB))
			{
				base.Controls.Add(this.TB);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000934A File Offset: 0x0000754A
		public void OnBaseTextChanged(object s, EventArgs e)
		{
			this.Text = this.TB.Text;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00009360 File Offset: 0x00007560
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

		// Token: 0x060000D8 RID: 216 RVA: 0x000093B8 File Offset: 0x000075B8
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00009424 File Offset: 0x00007624
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000942C File Offset: 0x0000762C
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00009435 File Offset: 0x00007635
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000943D File Offset: 0x0000763D
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00009446 File Offset: 0x00007646
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000944E File Offset: 0x0000764E
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

		// Token: 0x060000DF RID: 223 RVA: 0x00009457 File Offset: 0x00007657
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = DrawHelpers.MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000946D File Offset: 0x0000766D
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = DrawHelpers.MouseState.Over;
			this.TB.Focus();
			base.Invalidate();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000948F File Offset: 0x0000768F
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000094A8 File Offset: 0x000076A8
		public LogInUserTextBox()
		{
			this.State = DrawHelpers.MouseState.None;
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._BorderColour = Color.FromArgb(35, 35, 35);
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

		// Token: 0x060000E3 RID: 227 RVA: 0x00009648 File Offset: 0x00007848
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
				graphics.FillPie(new SolidBrush(base.FindForm().BackColor), new Rectangle(base.Width - 25, base.Height - 23, base.Height + 25, base.Height + 25), 180f, 90f);
				graphics.DrawPie(new Pen(Color.FromArgb(35, 35, 35), 2f), new Rectangle(base.Width - 25, base.Height - 23, base.Height + 25, base.Height + 25), 180f, 90f);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x0400005C RID: 92
		private DrawHelpers.MouseState State;

		// Token: 0x0400005E RID: 94
		public Color _BaseColour;

		// Token: 0x0400005F RID: 95
		public Color _TextColour;

		// Token: 0x04000060 RID: 96
		public Color _BorderColour;

		// Token: 0x04000061 RID: 97
		public HorizontalAlignment _TextAlign;

		// Token: 0x04000062 RID: 98
		public int _MaxLength;

		// Token: 0x04000063 RID: 99
		public bool _ReadOnly;

		// Token: 0x04000064 RID: 100
		public bool _UseSystemPasswordChar;

		// Token: 0x04000065 RID: 101
		public bool _Multiline;
	}
}
