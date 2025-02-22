using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000020 RID: 32
	public class LogInRichTextBox : Control
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000DC0F File Offset: 0x0000BE0F
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0000DC17 File Offset: 0x0000BE17
		public virtual RichTextBox TB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000DC20 File Offset: 0x0000BE20
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0000DC28 File Offset: 0x0000BE28
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000DC31 File Offset: 0x0000BE31
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0000DC39 File Offset: 0x0000BE39
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000DC42 File Offset: 0x0000BE42
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0000DC4A File Offset: 0x0000BE4A
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

		// Token: 0x06000234 RID: 564 RVA: 0x0000DC53 File Offset: 0x0000BE53
		public void AppendText(string AppendingText)
		{
			this.TB.Focus();
			this.TB.AppendText(AppendingText);
			base.Invalidate();
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000DC73 File Offset: 0x0000BE73
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000DC80 File Offset: 0x0000BE80
		public override string Text
		{
			get
			{
				return this.TB.Text;
			}
			set
			{
				this.TB.Text = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000DC94 File Offset: 0x0000BE94
		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			this.TB.BackColor = this.BackColor;
			base.Invalidate();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000DCB4 File Offset: 0x0000BEB4
		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.TB.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000DCD4 File Offset: 0x0000BED4
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.TB.Size = checked(new Size(base.Width - 10, base.Height - 11));
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000DCFF File Offset: 0x0000BEFF
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.TB.Font = this.Font;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000DD19 File Offset: 0x0000BF19
		public void TextChanges()
		{
			this.TB.Text = this.Text;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		public LogInRichTextBox()
		{
			base.TextChanged += delegate(object a0, EventArgs a1)
			{
				this.TextChanges();
			};
			this.TB = new RichTextBox();
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			RichTextBox tb = this.TB;
			tb.Multiline = true;
			tb.BackColor = this._BaseColour;
			tb.ForeColor = this._TextColour;
			tb.Text = string.Empty;
			tb.BorderStyle = BorderStyle.None;
			tb.Location = new Point(5, 5);
			tb.Font = new Font("Segeo UI", 9f);
			tb.Size = checked(new Size(base.Width - 10, base.Height - 10));
			base.Controls.Add(this.TB);
			base.Size = new Size(135, 35);
			this.DoubleBuffered = true;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000DE3C File Offset: 0x0000C03C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			checked
			{
				new Rectangle(0, 0, base.Width - 1, base.Height - 1);
				graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics.Clear(this._BaseColour);
				graphics.DrawRectangle(new Pen(this._BorderColour, 2f), base.ClientRectangle);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000DC RID: 220
		public Color _BaseColour;

		// Token: 0x040000DD RID: 221
		public Color _TextColour;

		// Token: 0x040000DE RID: 222
		public Color _BorderColour;
	}
}
