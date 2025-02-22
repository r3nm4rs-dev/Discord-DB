using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Dox_Tool_V2
{
	// Token: 0x0200001D RID: 29
	public class LogInTitledListBox : Control
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000D076 File Offset: 0x0000B276
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0000D080 File Offset: 0x0000B280
		public virtual ListBox ListB
		{
			[CompilerGenerated]
			get
			{
				return this._ListB;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DrawItemEventHandler value2 = new DrawItemEventHandler(this.Drawitem);
				ListBox listB = this._ListB;
				if (listB != null)
				{
					listB.DrawItem -= value2;
				}
				this._ListB = value;
				listB = this._ListB;
				if (listB != null)
				{
					listB.DrawItem += value2;
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000D0C3 File Offset: 0x0000B2C3
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000D0CB File Offset: 0x0000B2CB
		[Category("Control")]
		public Font TitleFont
		{
			get
			{
				return this._TitleFont;
			}
			set
			{
				this._TitleFont = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0000D0DC File Offset: 0x0000B2DC
		[Category("Control")]
		public string[] Items
		{
			get
			{
				return this._Items;
			}
			set
			{
				this._Items = value;
				this.ListB.Items.Clear();
				this.ListB.Items.AddRange(value);
				base.Invalidate();
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000D10C File Offset: 0x0000B30C
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000D114 File Offset: 0x0000B314
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000D11D File Offset: 0x0000B31D
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000D125 File Offset: 0x0000B325
		[Category("Colours")]
		public Color SelectedColour
		{
			get
			{
				return this._SelectedColour;
			}
			set
			{
				this._SelectedColour = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000D12E File Offset: 0x0000B32E
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000D136 File Offset: 0x0000B336
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000D13F File Offset: 0x0000B33F
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000D147 File Offset: 0x0000B347
		[Category("Colours")]
		public Color ListBaseColour
		{
			get
			{
				return this._ListBaseColour;
			}
			set
			{
				this._ListBaseColour = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000D150 File Offset: 0x0000B350
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000D158 File Offset: 0x0000B358
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000D161 File Offset: 0x0000B361
		public string SelectedItem
		{
			get
			{
				return Conversions.ToString(this.ListB.SelectedItem);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000D173 File Offset: 0x0000B373
		public int SelectedIndex
		{
			get
			{
				return this.ListB.SelectedIndex;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000D180 File Offset: 0x0000B380
		public void Clear()
		{
			this.ListB.Items.Clear();
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000D194 File Offset: 0x0000B394
		public void ClearSelected()
		{
			checked
			{
				for (int i = this.ListB.SelectedItems.Count - 1; i >= 0; i += -1)
				{
					this.ListB.Items.Remove(RuntimeHelpers.GetObjectValue(this.ListB.SelectedItems[i]));
				}
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!base.Controls.Contains(this.ListB))
			{
				base.Controls.Add(this.ListB);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000D210 File Offset: 0x0000B410
		public void AddRange(object[] items)
		{
			this.ListB.Items.Remove("");
			this.ListB.Items.AddRange(items);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000D238 File Offset: 0x0000B438
		public void AddItem(object item)
		{
			this.ListB.Items.Remove("");
			this.ListB.Items.Add(RuntimeHelpers.GetObjectValue(item));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000D268 File Offset: 0x0000B468
		public void Drawitem(object sender, DrawItemEventArgs e)
		{
			checked
			{
				if (e.Index >= 0)
				{
					e.DrawBackground();
					e.DrawFocusRectangle();
					Graphics graphics = e.Graphics;
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
					if (Strings.InStr(e.State.ToString(), "Selected,", CompareMethod.Binary) > 0)
					{
						graphics.FillRectangle(new SolidBrush(this._SelectedColour), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1));
						graphics.DrawString(" " + this.ListB.Items[e.Index].ToString(), new Font("Segoe UI", 9f, FontStyle.Bold), new SolidBrush(this._TextColour), (float)e.Bounds.X, (float)(e.Bounds.Y + 2));
					}
					else
					{
						graphics.FillRectangle(new SolidBrush(this._ListBaseColour), new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
						graphics.DrawString(" " + this.ListB.Items[e.Index].ToString(), new Font("Segoe UI", 8f), new SolidBrush(this._TextColour), (float)e.Bounds.X, (float)(e.Bounds.Y + 2));
					}
					graphics.Dispose();
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000D44C File Offset: 0x0000B64C
		public LogInTitledListBox()
		{
			this.ListB = new ListBox();
			this._Items = new string[]
			{
				""
			};
			this._BaseColour = Color.FromArgb(42, 42, 42);
			this._SelectedColour = Color.FromArgb(55, 55, 55);
			this._ListBaseColour = Color.FromArgb(47, 47, 47);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._TitleFont = new Font("Segeo UI", 10f, FontStyle.Bold);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.ListB.DrawMode = DrawMode.OwnerDrawFixed;
			this.ListB.ScrollAlwaysVisible = false;
			this.ListB.HorizontalScrollbar = false;
			this.ListB.BorderStyle = BorderStyle.None;
			this.ListB.BackColor = this.BaseColour;
			this.ListB.Location = new Point(3, 28);
			this.ListB.Font = new Font("Segoe UI", 8f);
			this.ListB.ItemHeight = 20;
			this.ListB.Items.Clear();
			this.ListB.IntegralHeight = false;
			base.Size = new Size(130, 100);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(this.BackColor);
			checked
			{
				this.ListB.Size = new Size(base.Width - 6, base.Height - 30);
				graphics.FillRectangle(new SolidBrush(this.BaseColour), rect);
				graphics.DrawRectangle(new Pen(this._BorderColour, 3f), new Rectangle(0, 0, base.Width, base.Height - 1));
				graphics.DrawLine(new Pen(this._BorderColour, 2f), new Point(0, 27), new Point(base.Width - 1, 27));
				graphics.DrawString(this.Text, this._TitleFont, new SolidBrush(this._TextColour), new Rectangle(2, 5, base.Width - 5, 20), new StringFormat
				{
					Alignment = StringAlignment.Center,
					LineAlignment = StringAlignment.Center
				});
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000CB RID: 203
		public string[] _Items;

		// Token: 0x040000CC RID: 204
		public Color _BaseColour;

		// Token: 0x040000CD RID: 205
		public Color _SelectedColour;

		// Token: 0x040000CE RID: 206
		public Color _ListBaseColour;

		// Token: 0x040000CF RID: 207
		public Color _TextColour;

		// Token: 0x040000D0 RID: 208
		public Color _BorderColour;

		// Token: 0x040000D1 RID: 209
		public Font _TitleFont;
	}
}
