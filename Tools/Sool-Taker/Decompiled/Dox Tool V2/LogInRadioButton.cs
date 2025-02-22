using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000014 RID: 20
	[DefaultEvent("CheckedChanged")]
	public class LogInRadioButton : Control
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000B1EF File Offset: 0x000093EF
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000B1F7 File Offset: 0x000093F7
		[Category("Colours")]
		public Color HighlightColour
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000B200 File Offset: 0x00009400
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000B208 File Offset: 0x00009408
		[Category("Colours")]
		public Color BaseColour
		{
			get
			{
				return this._BackColour;
			}
			set
			{
				this._BackColour = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000B211 File Offset: 0x00009411
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000B219 File Offset: 0x00009419
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000B222 File Offset: 0x00009422
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000B22A File Offset: 0x0000942A
		[Category("Colours")]
		public Color CheckedColour
		{
			get
			{
				return this._CheckedColour;
			}
			set
			{
				this._CheckedColour = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000B233 File Offset: 0x00009433
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000B23B File Offset: 0x0000943B
		[Category("Colours")]
		public Color FontColour
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

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600016A RID: 362 RVA: 0x0000B244 File Offset: 0x00009444
		// (remove) Token: 0x0600016B RID: 363 RVA: 0x0000B27C File Offset: 0x0000947C
		public event LogInRadioButton.CheckedChangedEventHandler CheckedChanged;

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0000B2B1 File Offset: 0x000094B1
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000B2BC File Offset: 0x000094BC
		public bool Checked
		{
			get
			{
				return this._Checked;
			}
			set
			{
				this._Checked = value;
				this.InvalidateControls();
				LogInRadioButton.CheckedChangedEventHandler checkedChangedEvent = this.CheckedChangedEvent;
				if (checkedChangedEvent != null)
				{
					checkedChangedEvent(this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000B2ED File Offset: 0x000094ED
		protected override void OnClick(EventArgs e)
		{
			if (!this._Checked)
			{
				this.Checked = true;
			}
			base.OnClick(e);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000B308 File Offset: 0x00009508
		public void InvalidateControls()
		{
			if (base.IsHandleCreated && this._Checked)
			{
				try
				{
					foreach (object obj in base.Parent.Controls)
					{
						Control control = (Control)obj;
						if (control != this && control is LogInRadioButton)
						{
							((LogInRadioButton)control).Checked = false;
							base.Invalidate();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000B394 File Offset: 0x00009594
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			this.InvalidateControls();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000A3F4 File Offset: 0x000085F4
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Height = 22;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000B3A2 File Offset: 0x000095A2
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = DrawHelpers.MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000B3B8 File Offset: 0x000095B8
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000B3CE File Offset: 0x000095CE
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = DrawHelpers.MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000B3E4 File Offset: 0x000095E4
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = DrawHelpers.MouseState.None;
			base.Invalidate();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000B3FC File Offset: 0x000095FC
		public LogInRadioButton()
		{
			this.State = DrawHelpers.MouseState.None;
			this._HoverColour = Color.FromArgb(50, 49, 51);
			this._CheckedColour = Color.FromArgb(173, 173, 174);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._BackColour = Color.FromArgb(54, 54, 54);
			this._TextColour = Color.FromArgb(255, 255, 255);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.Cursor = Cursors.Hand;
			base.Size = new Size(100, 22);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000B4AC File Offset: 0x000096AC
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			checked
			{
				Rectangle rect = new Rectangle(1, 1, base.Height - 2, base.Height - 2);
				Rectangle rect2 = new Rectangle(6, 6, base.Height - 12, base.Height - 12);
				Graphics graphics2 = graphics;
				graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
				graphics2.SmoothingMode = SmoothingMode.HighQuality;
				graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics2.Clear(this._BackColour);
				graphics2.FillEllipse(new SolidBrush(this._BackColour), rect);
				graphics2.DrawEllipse(new Pen(this._BorderColour, 2f), rect);
				if (this.Checked)
				{
					DrawHelpers.MouseState state = this.State;
					if (state == DrawHelpers.MouseState.Over)
					{
						graphics2.FillEllipse(new SolidBrush(this._HoverColour), new Rectangle(2, 2, base.Height - 4, base.Height - 4));
					}
					graphics2.FillEllipse(new SolidBrush(this._CheckedColour), rect2);
				}
				else
				{
					DrawHelpers.MouseState state2 = this.State;
					if (state2 == DrawHelpers.MouseState.Over)
					{
						graphics2.FillEllipse(new SolidBrush(this._HoverColour), new Rectangle(2, 2, base.Height - 4, base.Height - 4));
					}
				}
				graphics2.DrawString(this.Text, this.Font, new SolidBrush(this._TextColour), new Rectangle(24, 3, base.Width, base.Height), new StringFormat
				{
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Near
				});
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x04000092 RID: 146
		public bool _Checked;

		// Token: 0x04000093 RID: 147
		private DrawHelpers.MouseState State;

		// Token: 0x04000094 RID: 148
		public Color _HoverColour;

		// Token: 0x04000095 RID: 149
		public Color _CheckedColour;

		// Token: 0x04000096 RID: 150
		public Color _BorderColour;

		// Token: 0x04000097 RID: 151
		public Color _BackColour;

		// Token: 0x04000098 RID: 152
		public Color _TextColour;

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000358 RID: 856
		public delegate void CheckedChangedEventHandler(object sender);
	}
}
