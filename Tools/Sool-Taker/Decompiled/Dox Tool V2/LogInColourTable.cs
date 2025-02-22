using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x0200001B RID: 27
	public class LogInColourTable : ProfessionalColorTable
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0000CA49 File Offset: 0x0000AC49
		public LogInColourTable()
		{
			this._BackColour = Color.FromArgb(42, 42, 42);
			this._BorderColour = Color.FromArgb(35, 35, 35);
			this._SelectedColour = Color.FromArgb(47, 47, 47);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000CA84 File Offset: 0x0000AC84
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000CA8C File Offset: 0x0000AC8C
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000CA95 File Offset: 0x0000AC95
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0000CA9D File Offset: 0x0000AC9D
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000CAAE File Offset: 0x0000ACAE
		[Category("Colours")]
		public Color BackColour
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color ButtonSelectedBorder
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color CheckBackground
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color CheckPressedBackground
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color CheckSelectedBackground
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color ImageMarginGradientBegin
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color ImageMarginGradientEnd
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color ImageMarginGradientMiddle
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000CA95 File Offset: 0x0000AC95
		public override Color MenuBorder
		{
			get
			{
				return this._BorderColour;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color MenuItemBorder
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000CA84 File Offset: 0x0000AC84
		public override Color MenuItemSelected
		{
			get
			{
				return this._SelectedColour;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000CA95 File Offset: 0x0000AC95
		public override Color SeparatorDark
		{
			get
			{
				return this._BorderColour;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000CAA6 File Offset: 0x0000ACA6
		public override Color ToolStripDropDownBackground
		{
			get
			{
				return this._BackColour;
			}
		}

		// Token: 0x040000C0 RID: 192
		public Color _BackColour;

		// Token: 0x040000C1 RID: 193
		public Color _BorderColour;

		// Token: 0x040000C2 RID: 194
		public Color _SelectedColour;
	}
}
