using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000028 RID: 40
	public class LogInTitledListBoxWBuiltInScrollBar : Control
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		[Category("Colours")]
		public Color TitleAreaColour
		{
			get
			{
				return this._TitleAreaColour;
			}
			set
			{
				this._TitleAreaColour = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00010EB9 File Offset: 0x0000F0B9
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00010EC1 File Offset: 0x0000F0C1
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00010ECA File Offset: 0x0000F0CA
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00010ED2 File Offset: 0x0000F0D2
		[Category("Control")]
		public int SelectedHeight
		{
			get
			{
				return this._SelectedHeight;
			}
			set
			{
				if (value < 1)
				{
					this._SelectedHeight = base.Height;
				}
				else
				{
					this._SelectedHeight = value;
				}
				this.InvalidateScroll();
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00010EF3 File Offset: 0x0000F0F3
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00010EFB File Offset: 0x0000F0FB
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00010F04 File Offset: 0x0000F104
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00010F0C File Offset: 0x0000F10C
		[Category("Colours")]
		public Color SelectedItemColour
		{
			get
			{
				return this._SelectedItemColour;
			}
			set
			{
				this._SelectedItemColour = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00010F15 File Offset: 0x0000F115
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00010F1D File Offset: 0x0000F11D
		[Category("Colours")]
		public Color NonSelectedItemColour
		{
			get
			{
				return this._NonSelectedItemColour;
			}
			set
			{
				this._NonSelectedItemColour = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00010F26 File Offset: 0x0000F126
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00010F2E File Offset: 0x0000F12E
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

		// Token: 0x06000300 RID: 768 RVA: 0x00010F37 File Offset: 0x0000F137
		public void HandleScroll(object sender)
		{
			base.Invalidate();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00010F40 File Offset: 0x0000F140
		public void InvalidateScroll()
		{
			checked
			{
				if ((double)((int)Math.Round(Math.Round((double)(this._Items.Count * this.ItemHeight) / (double)this._SelectedHeight))) < (double)(this._Items.Count * this.ItemHeight) / (double)this._SelectedHeight)
				{
					this.VerticalScrollbar._Maximum = (int)Math.Round(Math.Ceiling((double)(this._Items.Count * this.ItemHeight) / (double)this._SelectedHeight));
				}
				else if ((int)Math.Round(Math.Round((double)(this._Items.Count * this.ItemHeight) / (double)this._SelectedHeight)) == 0)
				{
					this.VerticalScrollbar._Maximum = 1;
				}
				else
				{
					this.VerticalScrollbar._Maximum = (int)Math.Round(Math.Round((double)(this._Items.Count * this.ItemHeight) / (double)this._SelectedHeight));
				}
				base.Invalidate();
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00011034 File Offset: 0x0000F234
		public void InvalidateLayout()
		{
			checked
			{
				this.VerticalScrollbar.Location = new Point(base.Width - this.VerticalScrollbar.Width - 2, 2);
				this.VerticalScrollbar.Size = new Size(18, base.Height - 4);
				base.Invalidate();
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00011086 File Offset: 0x0000F286
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00011093 File Offset: 0x0000F293
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem[] Items
		{
			get
			{
				return this._Items.ToArray();
			}
			set
			{
				this._Items = new List<LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem>(value);
				base.Invalidate();
				this.InvalidateScroll();
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000305 RID: 773 RVA: 0x000110AD File Offset: 0x0000F2AD
		public LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem[] SelectedItems
		{
			get
			{
				return this._SelectedItems.ToArray();
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000110BA File Offset: 0x0000F2BA
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000110C2 File Offset: 0x0000F2C2
		public bool MultiSelect
		{
			get
			{
				return this._MultiSelect;
			}
			set
			{
				this._MultiSelect = value;
				if (this._SelectedItems.Count > 1)
				{
					this._SelectedItems.RemoveRange(1, checked(this._SelectedItems.Count - 1));
				}
				base.Invalidate();
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000092A9 File Offset: 0x000074A9
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000110F8 File Offset: 0x0000F2F8
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				this.ItemHeight = checked((int)Math.Round((double)Graphics.FromHwnd(base.Handle).MeasureString("@", this.Font).Height));
				if (this.VerticalScrollbar != null)
				{
					this.VerticalScrollbar._SmallChange = 1;
					this.VerticalScrollbar._LargeChange = 1;
				}
				base.Font = value;
				this.InvalidateLayout();
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00011164 File Offset: 0x0000F364
		public void AddItem(string Items)
		{
			LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem logInListBoxItem = new LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem();
			logInListBoxItem.Text = Items;
			this._Items.Add(logInListBoxItem);
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00011198 File Offset: 0x0000F398
		public void AddItems(string[] Items)
		{
			foreach (string text in Items)
			{
				LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem logInListBoxItem = new LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem();
				logInListBoxItem.Text = text;
				this._Items.Add(logInListBoxItem);
			}
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000111DE File Offset: 0x0000F3DE
		public void RemoveItemAt(int index)
		{
			this._Items.RemoveAt(index);
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000111F8 File Offset: 0x0000F3F8
		public void RemoveItem(LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem item)
		{
			this._Items.Remove(item);
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00011214 File Offset: 0x0000F414
		public void RemoveItems(LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem[] items)
		{
			foreach (LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem item in items)
			{
				this._Items.Remove(item);
			}
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0001124E File Offset: 0x0000F44E
		protected override void OnSizeChanged(EventArgs e)
		{
			this._SelectedHeight = base.Height;
			this.InvalidateScroll();
			this.InvalidateLayout();
			base.OnSizeChanged(e);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0001126F File Offset: 0x0000F46F
		public void Vertical_MouseDown(object sender, MouseEventArgs e)
		{
			base.Focus();
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00011278 File Offset: 0x0000F478
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.Focus();
			checked
			{
				if (e.Button == MouseButtons.Left)
				{
					int num = this.VerticalScrollbar.Value * (this.VerticalScrollbar.Maximum + (base.Height - this.ItemHeight));
					int num2 = (e.Y + num) / this.ItemHeight;
					if (num2 > this._Items.Count - 1)
					{
						num2 = -1;
					}
					if (num2 != -1)
					{
						if (Control.ModifierKeys == Keys.Control && this._MultiSelect)
						{
							if (this._SelectedItems.Contains(this._Items[num2]))
							{
								this._SelectedItems.Remove(this._Items[num2]);
							}
							else
							{
								this._SelectedItems.Add(this._Items[num2]);
							}
						}
						else
						{
							this._SelectedItems.Clear();
							this._SelectedItems.Add(this._Items[num2]);
						}
					}
					base.Invalidate();
				}
				base.OnMouseDown(e);
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0001137C File Offset: 0x0000F57C
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			checked
			{
				int num = 0 - e.Delta * SystemInformation.MouseWheelScrollLines / 120 * 1;
				int value = Math.Max(Math.Min(this.VerticalScrollbar.Value + num, this.VerticalScrollbar.Maximum), this.VerticalScrollbar.Minimum);
				this.VerticalScrollbar.Value = value;
				base.OnMouseWheel(e);
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000113E0 File Offset: 0x0000F5E0
		public LogInTitledListBoxWBuiltInScrollBar()
		{
			this._Items = new List<LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem>();
			this._SelectedItems = new List<LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem>();
			this._MultiSelect = true;
			this.ItemHeight = 24;
			this._BaseColour = Color.FromArgb(55, 55, 55);
			this._SelectedItemColour = Color.FromArgb(50, 50, 50);
			this._NonSelectedItemColour = Color.FromArgb(47, 47, 47);
			this._TitleAreaColour = Color.FromArgb(42, 42, 42);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._SelectedHeight = 1;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.VerticalScrollbar = new LogInVerticalScrollBar();
			this.VerticalScrollbar.SmallChange = 1;
			this.VerticalScrollbar.LargeChange = 1;
			this.VerticalScrollbar.Scroll += this.HandleScroll;
			this.VerticalScrollbar.MouseDown += this.Vertical_MouseDown;
			base.Controls.Add(this.VerticalScrollbar);
			this.InvalidateLayout();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0001150C File Offset: 0x0000F70C
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.Clear(this._BaseColour);
			checked
			{
				int num = this.VerticalScrollbar.Value * (this.VerticalScrollbar.Maximum + (base.Height - this.ItemHeight));
				int num2;
				if (num == 0)
				{
					num2 = 0;
				}
				else
				{
					num2 = num / this.ItemHeight / this.VerticalScrollbar.Maximum;
				}
				Math.Min(num2 + base.Height / this.ItemHeight, this._Items.Count - 1);
				int num3 = num2;
				int num4 = this._Items.Count - 1;
				for (int i = num3; i <= num4; i++)
				{
					LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem logInListBoxItem = this.Items[i];
					int num5 = this.ItemHeight + i * this.ItemHeight + 1 - num + (int)Math.Round(unchecked((double)this.ItemHeight / 2.0 - 8.0));
					if (this._SelectedItems.Contains(logInListBoxItem))
					{
						graphics.FillRectangle(new SolidBrush(this._SelectedItemColour), new Rectangle(0, this.ItemHeight + i * this.ItemHeight + 1 - num, base.Width - 19, this.ItemHeight - 1));
					}
					else
					{
						graphics.FillRectangle(new SolidBrush(this._NonSelectedItemColour), new Rectangle(0, this.ItemHeight + i * this.ItemHeight + 1 - num, base.Width - 19, this.ItemHeight - 1));
					}
					graphics.DrawLine(new Pen(this._BorderColour), 0, this.ItemHeight + i * this.ItemHeight + 1 - num + this.ItemHeight - 1, base.Width - 18, this.ItemHeight + i * this.ItemHeight + 1 - num + this.ItemHeight - 1);
					graphics.DrawString(logInListBoxItem.Text, new Font("Segoe UI", 8f), new SolidBrush(this._TextColour), 9f, (float)num5);
					graphics.ResetClip();
				}
				graphics.FillRectangle(new SolidBrush(this._TitleAreaColour), new Rectangle(0, 0, base.Width, this.ItemHeight));
				graphics.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35)), 1, 1, base.Width - 3, this.ItemHeight - 2);
				graphics.DrawString(this.Text, new Font("Segoe UI", 10f, FontStyle.Bold), new SolidBrush(this._TextColour), new Rectangle(0, 0, base.Width, this.ItemHeight + 2), new StringFormat
				{
					Alignment = StringAlignment.Center,
					LineAlignment = StringAlignment.Center
				});
				graphics.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35), 2f), 1, 0, base.Width - 2, base.Height - 1);
				graphics.DrawLine(new Pen(this._BorderColour), 0, this.ItemHeight, base.Width, this.ItemHeight);
				graphics.DrawLine(new Pen(this._BorderColour, 2f), this.VerticalScrollbar.Location.X - 1, 0, this.VerticalScrollbar.Location.X - 1, base.Height);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x0400013B RID: 315
		public List<LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem> _Items;

		// Token: 0x0400013C RID: 316
		public readonly List<LogInTitledListBoxWBuiltInScrollBar.LogInListBoxItem> _SelectedItems;

		// Token: 0x0400013D RID: 317
		public bool _MultiSelect;

		// Token: 0x0400013E RID: 318
		public int ItemHeight;

		// Token: 0x0400013F RID: 319
		public readonly LogInVerticalScrollBar VerticalScrollbar;

		// Token: 0x04000140 RID: 320
		public Color _BaseColour;

		// Token: 0x04000141 RID: 321
		public Color _SelectedItemColour;

		// Token: 0x04000142 RID: 322
		public Color _NonSelectedItemColour;

		// Token: 0x04000143 RID: 323
		public Color _TitleAreaColour;

		// Token: 0x04000144 RID: 324
		public Color _BorderColour;

		// Token: 0x04000145 RID: 325
		public Color _TextColour;

		// Token: 0x04000146 RID: 326
		public int _SelectedHeight;

		// Token: 0x0200003F RID: 63
		public class LogInListBoxItem
		{
			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600036A RID: 874 RVA: 0x000124A3 File Offset: 0x000106A3
			// (set) Token: 0x0600036B RID: 875 RVA: 0x000124AB File Offset: 0x000106AB
			public string Text { get; set; }

			// Token: 0x0600036C RID: 876 RVA: 0x000124B4 File Offset: 0x000106B4
			public override string ToString()
			{
				return this.Text;
			}
		}
	}
}
