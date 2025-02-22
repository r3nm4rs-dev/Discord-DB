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
	// Token: 0x0200001C RID: 28
	public class LogInListBox : Control
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000CAB7 File Offset: 0x0000ACB7
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000CAC0 File Offset: 0x0000ACC0
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000CB03 File Offset: 0x0000AD03
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000CB0B File Offset: 0x0000AD0B
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000CB3B File Offset: 0x0000AD3B
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0000CB43 File Offset: 0x0000AD43
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000CB54 File Offset: 0x0000AD54
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000CB5D File Offset: 0x0000AD5D
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000CB65 File Offset: 0x0000AD65
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000CB6E File Offset: 0x0000AD6E
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000CB76 File Offset: 0x0000AD76
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000CB7F File Offset: 0x0000AD7F
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0000CB87 File Offset: 0x0000AD87
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000CB90 File Offset: 0x0000AD90
		public string SelectedItem
		{
			get
			{
				return Conversions.ToString(this.ListB.SelectedItem);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000CBA2 File Offset: 0x0000ADA2
		public int SelectedIndex
		{
			get
			{
				return this.ListB.SelectedIndex;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000CBAF File Offset: 0x0000ADAF
		public void Clear()
		{
			this.ListB.Items.Clear();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
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

		// Token: 0x060001F3 RID: 499 RVA: 0x0000CC14 File Offset: 0x0000AE14
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			if (!base.Controls.Contains(this.ListB))
			{
				base.Controls.Add(this.ListB);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000CC40 File Offset: 0x0000AE40
		public void AddRange(object[] items)
		{
			this.ListB.Items.Remove("");
			this.ListB.Items.AddRange(items);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000CC68 File Offset: 0x0000AE68
		public void AddItem(object item)
		{
			this.ListB.Items.Remove("");
			this.ListB.Items.Add(RuntimeHelpers.GetObjectValue(item));
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000CC98 File Offset: 0x0000AE98
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

		// Token: 0x060001F7 RID: 503 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public LogInListBox()
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
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.ListB.DrawMode = DrawMode.OwnerDrawFixed;
			this.ListB.ScrollAlwaysVisible = false;
			this.ListB.HorizontalScrollbar = false;
			this.ListB.BorderStyle = BorderStyle.None;
			this.ListB.BackColor = this._BaseColour;
			this.ListB.Location = new Point(3, 3);
			this.ListB.Font = new Font("Segoe UI", 8f);
			this.ListB.ItemHeight = 20;
			this.ListB.Items.Clear();
			this.ListB.IntegralHeight = false;
			base.Size = new Size(130, 100);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
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
				this.ListB.Size = new Size(base.Width - 6, base.Height - 5);
				graphics.FillRectangle(new SolidBrush(this._BaseColour), rect);
				graphics.DrawRectangle(new Pen(this._BorderColour, 3f), new Rectangle(0, 0, base.Width, base.Height - 1));
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x040000C4 RID: 196
		public string[] _Items;

		// Token: 0x040000C5 RID: 197
		public Color _BaseColour;

		// Token: 0x040000C6 RID: 198
		public Color _SelectedColour;

		// Token: 0x040000C7 RID: 199
		public Color _ListBaseColour;

		// Token: 0x040000C8 RID: 200
		public Color _TextColour;

		// Token: 0x040000C9 RID: 201
		public Color _BorderColour;
	}
}
