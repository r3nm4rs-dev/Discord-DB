using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dox_Tool_V2.My;
using Microsoft.VisualBasic;

namespace Dox_Tool_V2
{
	// Token: 0x0200002A RID: 42
	public class Updater
	{
		// Token: 0x06000336 RID: 822 RVA: 0x00012148 File Offset: 0x00010348
		public Updater()
		{
			this.thisVersion = Application.ProductVersion;
			this.functions = new Functions();
			if (MessageBox.Show("Would you like to check for updates?", "Check for updates?", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Interaction.MsgBox("Program is now checking for updates. Please be patient.", MsgBoxStyle.OkOnly, null);
				this.currentVersion = new WebClient().DownloadString("http://Drizzybot.com/releases/version.txt");
				if (this.currentVersion.Equals(RuntimeHelpers.GetObjectValue(this.thisVersion)))
				{
					Interaction.MsgBox("No update is available at this time. Program will continue.", MsgBoxStyle.OkOnly, null);
					return;
				}
				Interaction.MsgBox("An update is available. The new version will now be downloaded...", MsgBoxStyle.OkOnly, null);
				NetworkCredential networkCredentials = new NetworkCredential(string.Empty, string.Empty);
				MyProject.Computer.Network.DownloadFile(new Uri("http://drizzybot.com/releases/Dox%20Tool%20V2.exe"), AppDomain.CurrentDomain.BaseDirectory + "Dox Tool V2 - Updated.exe", networkCredentials, false, 3500, true);
				Interaction.MsgBox("Done! Launching new version...", MsgBoxStyle.OkOnly, null);
				Process.Start(AppDomain.CurrentDomain.BaseDirectory + "Dox Tool V2 - Updated.exe");
				Application.Exit();
			}
		}

		// Token: 0x04000152 RID: 338
		private object thisVersion;

		// Token: 0x04000153 RID: 339
		private object currentVersion;

		// Token: 0x04000154 RID: 340
		private Functions functions;
	}
}
