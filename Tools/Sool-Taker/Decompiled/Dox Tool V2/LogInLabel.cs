using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dox_Tool_V2
{
	// Token: 0x02000015 RID: 21
	public class LogInLabel : Label
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000B614 File Offset: 0x00009814
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000B61C File Offset: 0x0000981C
		[Category("Colours")]
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

		// Token: 0x0600017A RID: 378 RVA: 0x0000B625 File Offset: 0x00009825
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000B634 File Offset: 0x00009834
		public LogInLabel()
		{
			this._FontColour = Color.FromArgb(255, 255, 255);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.Font = new Font("Segoe UI", 9f);
			this.ForeColor = this._FontColour;
			this.BackColor = Color.Transparent;
			this.Text = this.Text;
		}

		// Token: 0x0400009A RID: 154
		public Color _FontColour;
	}
}
