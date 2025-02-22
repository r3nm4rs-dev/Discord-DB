using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000029 RID: 41
	public class LogInListBoxWBuiltInScrollBar : Control
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00011861 File Offset: 0x0000FA61
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00011869 File Offset: 0x0000FA69
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00011872 File Offset: 0x0000FA72
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0001187A File Offset: 0x0000FA7A
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0001189B File Offset: 0x0000FA9B
		// (set) Token: 0x0600031A RID: 794 RVA: 0x000118A3 File Offset: 0x0000FAA3
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600031B RID: 795 RVA: 0x000118AC File Offset: 0x0000FAAC
		// (set) Token: 0x0600031C RID: 796 RVA: 0x000118B4 File Offset: 0x0000FAB4
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000118BD File Offset: 0x0000FABD
		// (set) Token: 0x0600031E RID: 798 RVA: 0x000118C5 File Offset: 0x0000FAC5
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600031F RID: 799 RVA: 0x000118CE File Offset: 0x0000FACE
		// (set) Token: 0x06000320 RID: 800 RVA: 0x000118D6 File Offset: 0x0000FAD6
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

		// Token: 0x06000321 RID: 801 RVA: 0x00010F37 File Offset: 0x0000F137
		public void HandleScroll(object sender)
		{
			base.Invalidate();
		}

		// Token: 0x06000322 RID: 802 RVA: 0x000118E0 File Offset: 0x0000FAE0
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

		// Token: 0x06000323 RID: 803 RVA: 0x000119D4 File Offset: 0x0000FBD4
		public void InvalidateLayout()
		{
			checked
			{
				this.VerticalScrollbar.Location = new Point(base.Width - this.VerticalScrollbar.Width - 2, 2);
				this.VerticalScrollbar.Size = new Size(18, base.Height - 4);
				base.Invalidate();
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00011A26 File Offset: 0x0000FC26
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00011A33 File Offset: 0x0000FC33
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public LogInListBoxWBuiltInScrollBar.LogInListBoxItem[] Items
		{
			get
			{
				return this._Items.ToArray();
			}
			set
			{
				this._Items = new List<LogInListBoxWBuiltInScrollBar.LogInListBoxItem>(value);
				base.Invalidate();
				this.InvalidateScroll();
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00011A4D File Offset: 0x0000FC4D
		public LogInListBoxWBuiltInScrollBar.LogInListBoxItem[] SelectedItems
		{
			get
			{
				return this._SelectedItems.ToArray();
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00011A5A File Offset: 0x0000FC5A
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00011A62 File Offset: 0x0000FC62
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000092A9 File Offset: 0x000074A9
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00011A98 File Offset: 0x0000FC98
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

		// Token: 0x0600032B RID: 811 RVA: 0x00011B04 File Offset: 0x0000FD04
		public void AddItem(string Items)
		{
			LogInListBoxWBuiltInScrollBar.LogInListBoxItem logInListBoxItem = new LogInListBoxWBuiltInScrollBar.LogInListBoxItem();
			logInListBoxItem.Text = Items;
			this._Items.Add(logInListBoxItem);
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00011B38 File Offset: 0x0000FD38
		public void AddItems(string[] Items)
		{
			foreach (string text in Items)
			{
				LogInListBoxWBuiltInScrollBar.LogInListBoxItem logInListBoxItem = new LogInListBoxWBuiltInScrollBar.LogInListBoxItem();
				logInListBoxItem.Text = text;
				this._Items.Add(logInListBoxItem);
			}
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00011B7E File Offset: 0x0000FD7E
		public void RemoveItemAt(int index)
		{
			this._Items.RemoveAt(index);
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00011B98 File Offset: 0x0000FD98
		public void RemoveItem(LogInListBoxWBuiltInScrollBar.LogInListBoxItem item)
		{
			this._Items.Remove(item);
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		public void RemoveItems(LogInListBoxWBuiltInScrollBar.LogInListBoxItem[] items)
		{
			foreach (LogInListBoxWBuiltInScrollBar.LogInListBoxItem item in items)
			{
				this._Items.Remove(item);
			}
			base.Invalidate();
			this.InvalidateScroll();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00011BEE File Offset: 0x0000FDEE
		protected override void OnSizeChanged(EventArgs e)
		{
			this._SelectedHeight = base.Height;
			this.InvalidateScroll();
			this.InvalidateLayout();
			base.OnSizeChanged(e);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001126F File Offset: 0x0000F46F
		public void Vertical_MouseDown(object sender, MouseEventArgs e)
		{
			base.Focus();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00011C10 File Offset: 0x0000FE10
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

		// Token: 0x06000333 RID: 819 RVA: 0x00011D14 File Offset: 0x0000FF14
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

		// Token: 0x06000334 RID: 820 RVA: 0x00011D78 File Offset: 0x0000FF78
		public LogInListBoxWBuiltInScrollBar()
		{
			this._Items = new List<LogInListBoxWBuiltInScrollBar.LogInListBoxItem>();
			this._SelectedItems = new List<LogInListBoxWBuiltInScrollBar.LogInListBoxItem>();
			this._MultiSelect = true;
			this.ItemHeight = 24;
			this._BaseColour = Color.FromArgb(55, 55, 55);
			this._SelectedItemColour = Color.FromArgb(50, 50, 50);
			this._NonSelectedItemColour = Color.FromArgb(47, 47, 47);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._TextColour = Color.FromArgb(255, 255, 255);
			this._SelectedHeight = 1;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			this.VerticalScrollbar = new LogInVerticalScrollBar();
			this.VerticalScrollbar._SmallChange = 1;
			this.VerticalScrollbar._LargeChange = 1;
			this.VerticalScrollbar.Scroll += this.HandleScroll;
			this.VerticalScrollbar.MouseDown += this.Vertical_MouseDown;
			base.Controls.Add(this.VerticalScrollbar);
			this.InvalidateLayout();
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00011E90 File Offset: 0x00010090
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
				graphics.DrawLine(new Pen(this._BorderColour, 2f), this.VerticalScrollbar.Location.X - 1, 0, this.VerticalScrollbar.Location.X - 1, base.Height);
				int num3 = num2;
				int num4 = this._Items.Count - 1;
				for (int i = num3; i <= num4; i++)
				{
					LogInListBoxWBuiltInScrollBar.LogInListBoxItem logInListBoxItem = this.Items[i];
					int num5 = i * this.ItemHeight + 1 - num + (int)Math.Round(unchecked((double)this.ItemHeight / 2.0 - 8.0));
					if (this._SelectedItems.Contains(logInListBoxItem))
					{
						graphics.FillRectangle(new SolidBrush(this._SelectedItemColour), new Rectangle(0, i * this.ItemHeight + 1 - num, base.Width - 19, this.ItemHeight - 1));
					}
					else
					{
						graphics.FillRectangle(new SolidBrush(this._NonSelectedItemColour), new Rectangle(0, i * this.ItemHeight + 1 - num, base.Width - 19, this.ItemHeight - 1));
					}
					graphics.DrawLine(new Pen(this._BorderColour), 0, i * this.ItemHeight + 1 - num + this.ItemHeight - 1, base.Width - 18, i * this.ItemHeight + 1 - num + this.ItemHeight - 1);
					graphics.DrawString(logInListBoxItem.Text, new Font("Segoe UI", 8f), new SolidBrush(this._TextColour), 9f, (float)num5);
					graphics.ResetClip();
				}
				graphics.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35), 2f), 1, 1, base.Width - 2, base.Height - 2);
				graphics.DrawLine(new Pen(this._BorderColour, 2f), this.VerticalScrollbar.Location.X - 1, 0, this.VerticalScrollbar.Location.X - 1, base.Height);
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			}
		}

		// Token: 0x04000147 RID: 327
		public List<LogInListBoxWBuiltInScrollBar.LogInListBoxItem> _Items;

		// Token: 0x04000148 RID: 328
		public readonly List<LogInListBoxWBuiltInScrollBar.LogInListBoxItem> _SelectedItems;

		// Token: 0x04000149 RID: 329
		public bool _MultiSelect;

		// Token: 0x0400014A RID: 330
		public int ItemHeight;

		// Token: 0x0400014B RID: 331
		public readonly LogInVerticalScrollBar VerticalScrollbar;

		// Token: 0x0400014C RID: 332
		public Color _BaseColour;

		// Token: 0x0400014D RID: 333
		public Color _SelectedItemColour;

		// Token: 0x0400014E RID: 334
		public Color _NonSelectedItemColour;

		// Token: 0x0400014F RID: 335
		public Color _BorderColour;

		// Token: 0x04000150 RID: 336
		public Color _TextColour;

		// Token: 0x04000151 RID: 337
		public int _SelectedHeight;

		// Token: 0x02000040 RID: 64
		public class LogInListBoxItem
		{
			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600036E RID: 878 RVA: 0x000124BC File Offset: 0x000106BC
			// (set) Token: 0x0600036F RID: 879 RVA: 0x000124C4 File Offset: 0x000106C4
			public string Text { get; set; }

			// Token: 0x06000370 RID: 880 RVA: 0x000124CD File Offset: 0x000106CD
			public override string ToString()
			{
				return this.Text;
			}
		}
	}
}
