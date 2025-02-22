using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x0200001E RID: 30
	public class LogInContextMenu : ContextMenuStrip
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000D6D2 File Offset: 0x0000B8D2
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0000D6DA File Offset: 0x0000B8DA
		public Color FontColour
		{
			get
			{
				return this._FontColour;
			}
			set
			{
				this._FontColour = value;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		public LogInContextMenu()
		{
			this._FontColour = Color.FromArgb(55, 255, 255);
			base.Renderer = new ToolStripProfessionalRenderer(new LogInColourTable());
			base.ShowCheckMargin = false;
			base.ShowImageMargin = false;
			base.ForeColor = Color.FromArgb(255, 255, 255);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000D746 File Offset: 0x0000B946
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			base.OnPaint(e);
		}

		// Token: 0x040000D2 RID: 210
		public Color _FontColour;
	}
}
