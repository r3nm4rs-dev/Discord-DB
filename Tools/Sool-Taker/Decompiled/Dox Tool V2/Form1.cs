using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Dox_Tool_V2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dox_Tool_V2
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x0000299C File Offset: 0x00000B9C
		public Form1()
		{
			base.Load += this.Form1_Load;
			this.functions = new Functions();
			this.InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000029C8 File Offset: 0x00000BC8
		private void nameSearch_Click(object sender, EventArgs e)
		{
			this.personProgress.Value = 0;
			this.personSearchResults.Items.Clear();
			new NameSearch(this.firstName.Text, this.lastName.Text, this.location.Text);
			Form1.WorkerArgs workerArgs = new Form1.WorkerArgs();
			workerArgs.first = this.firstName.Text;
			workerArgs.last = this.lastName.Text;
			workerArgs.location = this.location.Text;
			this.personSearch.RunWorkerAsync(workerArgs);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002A60 File Offset: 0x00000C60
		private void emailSearch_Click(object sender, EventArgs e)
		{
			this.emailProgress.Value = 0;
			this.emailSearchResults.Items.Clear();
			Form1.WorkerArgs workerArgs = new Form1.WorkerArgs();
			workerArgs.email = this.email.Text;
			workerArgs.query = this.email.Text;
			workerArgs.box = this.emailSearchResults;
			workerArgs.bar = this.emailProgress;
			this.emailWorker.RunWorkerAsync(workerArgs);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002AD8 File Offset: 0x00000CD8
		private void userSearch_Click(object sender, EventArgs e)
		{
			this.usernameProgress.Value = 0;
			this.usernameSearchResults.Items.Clear();
			Form1.WorkerArgs workerArgs = new Form1.WorkerArgs();
			workerArgs.query = this.usernameSearch.Text;
			workerArgs.box = this.usernameSearchResults;
			workerArgs.bar = this.usernameProgress;
			this.googleWorker.RunWorkerAsync(workerArgs);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002B3C File Offset: 0x00000D3C
		private void ipSearchButton_Click(object sender, EventArgs e)
		{
			string pageSource = this.functions.GetPageSource("http://ip-api.com/json/" + this.ipText.Text);
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(pageSource));
				this.cityState.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"city"
				}, null), "/"), NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"regionName"
				}, null)));
				this.latLong.Text = NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"lat"
				}, null).ToString() + "," + NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"lon"
				}, null).ToString();
				this.zipCode.Text = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[]
				{
					"zip"
				}, null));
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				this.ipText.Text = "Error.";
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002C68 File Offset: 0x00000E68
		private void mapButton_Click(object sender, EventArgs e)
		{
			Process.Start("http://maps.google.com?q=" + this.latLong.Text);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002C88 File Offset: 0x00000E88
		private void exportButton_Click(object sender, EventArgs e)
		{
			using (StreamWriter streamWriter = File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "dox.txt"))
			{
				streamWriter.WriteLine("⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟");
				streamWriter.WriteLine("╔═══╗╔═══╗╔═╗╔═╗╔═══╗╔═══╗");
				streamWriter.WriteLine("╚╗╔╗║║╔═╗║╚╗╚╝╔╝║╔══╝╚╗╔╗║");
				streamWriter.WriteLine("─║║║║║║─║║─╚╗╔╝─║╚══╗─║║║║");
				streamWriter.WriteLine("─║║║║║║─║║─╔╝╚╗─║╔══╝─║║║║");
				streamWriter.WriteLine("╔╝╚╝║║╚═╝║╔╝╔╗╚╗║╚══╗╔╝╚╝║");
				streamWriter.WriteLine("╚═══╝╚═══╝╚═╝╚═╝╚═══╝╚═══╝");
				streamWriter.WriteLine("⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟");
				streamWriter.WriteLine("Name: " + this.nameTemplate.Text);
				streamWriter.WriteLine("Age: " + this.ageTemplate.Text);
				streamWriter.WriteLine("Phone Number: " + this.phoneTemplate.Text);
				streamWriter.WriteLine("Address: " + this.addressTemplate.Text);
				streamWriter.WriteLine("Email: " + this.emailTemplate.Text);
				streamWriter.WriteLine("⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟⍟");
				streamWriter.WriteLine(this.otherInfo.Text);
			}
			Process.Start(AppDomain.CurrentDomain.BaseDirectory + "dox.txt");
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002DE0 File Offset: 0x00000FE0
		private void Form1_Load(object sender, EventArgs e)
		{
			if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll"))
			{
				Interaction.MsgBox("The program will now download a required assembly to run...", MsgBoxStyle.OkOnly, null);
				MyProject.Computer.Network.DownloadFile("http://drizzybot.com/releases/Newtonsoft.Json.dll", AppDomain.CurrentDomain.BaseDirectory + "Newtonsoft.Json.dll");
				Interaction.MsgBox("Done! The program will now start...", MsgBoxStyle.OkOnly, null);
			}
			new Updater();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002E50 File Offset: 0x00001050
		private void personSearchResults_DoubleClick(object sender, EventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.personSearchResults.SelectedItem, null, "Substring", new object[]
			{
				Operators.AddObject(NewLateBinding.LateGet(this.personSearchResults.SelectedItem, null, "IndexOf", new object[]
				{
					": "
				}, null, null, null), 2)
			}, null, null, null));
			if (this.functions.IsUri(Conversions.ToString(objectValue)))
			{
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(null, typeof(Process), "Start", array = new object[]
				{
					objectValue
				}, null, null, array2 = new bool[]
				{
					true
				}, true);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002F09 File Offset: 0x00001109
		private void emailSearchResults_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002F0C File Offset: 0x0000110C
		private void emailSearchResults_DoubleClick(object sender, EventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.emailSearchResults.SelectedItem, null, "Substring", new object[]
			{
				Operators.AddObject(NewLateBinding.LateGet(this.emailSearchResults.SelectedItem, null, "IndexOf", new object[]
				{
					": "
				}, null, null, null), 2)
			}, null, null, null));
			if (this.functions.IsUri(Conversions.ToString(objectValue)))
			{
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(null, typeof(Process), "Start", array = new object[]
				{
					objectValue
				}, null, null, array2 = new bool[]
				{
					true
				}, true);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002FC8 File Offset: 0x000011C8
		private void usernameSearchResults_DoubleClick(object sender, EventArgs e)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(this.usernameSearchResults.SelectedItem, null, "Substring", new object[]
			{
				Operators.AddObject(NewLateBinding.LateGet(this.usernameSearchResults.SelectedItem, null, "IndexOf", new object[]
				{
					": "
				}, null, null, null), 2)
			}, null, null, null));
			if (this.functions.IsUri(Conversions.ToString(objectValue)))
			{
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(null, typeof(Process), "Start", array = new object[]
				{
					objectValue
				}, null, null, array2 = new bool[]
				{
					true
				}, true);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003084 File Offset: 0x00001284
		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Console.WriteLine("Starting 10Digits");
			Form1.WorkerArgs workerArgs = (Form1.WorkerArgs)e.Argument;
			string url = string.Concat(new string[]
			{
				"http://10digits.us/n/",
				workerArgs.first,
				"_",
				workerArgs.last,
				"/location/",
				workerArgs.location
			});
			string pageSource = this.functions.GetPageSource(url);
			Console.WriteLine("Got Source");
			object objectValue = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "itemtype=\"http://schema.org/PostalAddress\"><span>(.*?)</li>"));
			checked
			{
				string[] array = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
				int num = 0;
				try
				{
					foreach (object obj in ((IEnumerable)objectValue))
					{
						string text = WebUtility.HtmlDecode(((Match)obj).Groups[1].Value);
						text = text.Replace("/", "");
						text = text.Replace("<span>", "");
						array[num] = text;
						num++;
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
				Console.WriteLine("Got matches: " + num.ToString());
				int num2 = num;
				for (int i = 0; i <= num2; i++)
				{
					string text2 = array[i];
					this.AddToListBox(this.personSearchResults, "Possible Address: " + text2);
					Console.WriteLine(text2);
				}
				this.UpdateBar(this.personProgress, 33);
				try
				{
					Console.WriteLine("Starting 411");
					url = string.Concat(new string[]
					{
						"http://www.411.com/name/",
						workerArgs.first,
						"-",
						workerArgs.last,
						"/",
						workerArgs.location
					});
					pageSource = this.functions.GetPageSource(url);
					objectValue = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "Lives at:  </span> (.*?)$"));
					string[] array2 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
					num = 0;
					try
					{
						foreach (object obj2 in ((IEnumerable)objectValue))
						{
							string text3 = WebUtility.HtmlDecode(((Match)obj2).Groups[1].Value);
							text3 = text3.Replace("/", "");
							text3 = text3.Replace("<span>", "");
							array2[num] = text3;
							num++;
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					foreach (string text4 in array2)
					{
						this.AddToListBox(this.personSearchResults, "Possible Address: " + text4);
						Console.WriteLine(text4);
					}
					this.UpdateBar(this.personProgress, 66);
					Console.WriteLine("Starting Zaba");
					url = string.Concat(new string[]
					{
						"http://www.zabasearch.com/people/",
						workerArgs.first,
						"+",
						workerArgs.last,
						"/",
						workerArgs.location
					});
					pageSource = this.functions.GetPageSource(url);
					if (!pageSource.Contains("Free <span class=\"listings-available-box\">Listings</span>"))
					{
						objectValue = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "initialize(.*?);</script>"));
						string[] array4 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
						num = 0;
						try
						{
							foreach (object obj3 in ((IEnumerable)objectValue))
							{
								string text5 = WebUtility.HtmlDecode(((Match)obj3).Groups[1].Value);
								text5 = Regex.Match(text5, "'\"(.*?)\"'").Groups[1].Value;
								array4[num] = text5;
								num++;
							}
						}
						finally
						{
							IEnumerator enumerator3;
							if (enumerator3 is IDisposable)
							{
								(enumerator3 as IDisposable).Dispose();
							}
						}
						foreach (string text6 in array4)
						{
							if (!string.IsNullOrEmpty(text6))
							{
								this.AddToListBox(this.personSearchResults, "Possible Address: " + text6);
								Console.WriteLine(text6);
							}
						}
						string value = Regex.Match(pageSource, "itemprop=\"telephone\">(.*?)</font>").Groups[1].Value;
						this.AddToListBox(this.personSearchResults, "Possible Phone: " + value);
						Console.WriteLine(value);
					}
					else
					{
						Console.WriteLine("More than one match");
						objectValue = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "itemprop=\"streetAddress\">(.*?)</"));
						object objectValue2 = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "<span itemprop=\"telephone\">(.*?)</span>"));
						string[] array6 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
						string[] array7 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "Count", new object[0], null, null, null)) + 1];
						num = 0;
						try
						{
							foreach (object obj4 in ((IEnumerable)objectValue))
							{
								string text7 = WebUtility.HtmlDecode(((Match)obj4).Groups[1].Value);
								array6[num] = text7;
								num++;
							}
						}
						finally
						{
							IEnumerator enumerator4;
							if (enumerator4 is IDisposable)
							{
								(enumerator4 as IDisposable).Dispose();
							}
						}
						num = 0;
						try
						{
							foreach (object obj5 in ((IEnumerable)objectValue2))
							{
								string text8 = WebUtility.HtmlDecode(((Match)obj5).Groups[1].Value);
								array7[num] = text8;
								num++;
							}
						}
						finally
						{
							IEnumerator enumerator5;
							if (enumerator5 is IDisposable)
							{
								(enumerator5 as IDisposable).Dispose();
							}
						}
						foreach (string text9 in array6)
						{
							this.AddToListBox(this.personSearchResults, "Possible Address: " + text9);
							Console.WriteLine(text9);
						}
						foreach (string text10 in array7)
						{
							this.AddToListBox(this.personSearchResults, "Possible Phone Number: " + text10);
							Console.WriteLine(text10);
						}
					}
					this.UpdateBar(this.personProgress, 100);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.InnerException);
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000037AC File Offset: 0x000019AC
		private void AddToListBox(ListBox g, object oo)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				if (!string.IsNullOrEmpty(Conversions.ToString(oo)))
				{
					g.Items.Add(RuntimeHelpers.GetObjectValue(oo));
				}
			}));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000037E0 File Offset: 0x000019E0
		private void CleanThread(ListBox g)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				this.clean(g);
			}));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003814 File Offset: 0x00001A14
		public void clean(ListBox g)
		{
			List<string> list = new List<string>();
			int count = g.Items.Count;
			checked
			{
				for (int i = 0; i <= count; i++)
				{
					string text = g.Items[i].ToString().Substring(g.Items[i].ToString().IndexOf(": "));
					if (!string.IsNullOrEmpty(text))
					{
						list.Add(text);
					}
				}
				g.Items.Clear();
				try
				{
					foreach (string item in list)
					{
						g.Items.Add(item);
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000038D8 File Offset: 0x00001AD8
		public void UpdateBar(LogInProgressBar bar, int g)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				if (bar.Value < 100)
				{
					bar.Value = g;
				}
			}));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000390C File Offset: 0x00001B0C
		private void personSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			Console.WriteLine(Conversions.ToDouble("Progress: ") + (double)e.ProgressPercentage);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003928 File Offset: 0x00001B28
		private void emailWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			Console.WriteLine("Started");
			Form1.WorkerArgs workerArgs = (Form1.WorkerArgs)e.Argument;
			Console.WriteLine("Got arguments");
			string url = "https://thatsthem.com/email/" + workerArgs.email;
			string pageSource = this.functions.GetPageSource(url);
			Console.WriteLine("Got source");
			object objectValue = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "<span itemprop=\"streetAddress\">(.*?)</span>"));
			object objectValue2 = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "<span itemprop=\"telephone\">(.*?)</span>"));
			int num = 0;
			checked
			{
				string[] array = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
				string[] array2 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "Count", new object[0], null, null, null)) + 1];
				try
				{
					foreach (object obj in ((IEnumerable)objectValue))
					{
						string value = ((Match)obj).Groups[1].Value;
						array[num] = value;
						num++;
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
				foreach (string text in array)
				{
					this.AddToListBox(this.emailSearchResults, "Possible Address: " + text);
					Console.WriteLine(text);
				}
				num = 0;
				try
				{
					foreach (object obj2 in ((IEnumerable)objectValue2))
					{
						string value2 = ((Match)obj2).Groups[1].Value;
						array2[num] = value2;
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				foreach (string text2 in array2)
				{
					this.AddToListBox(this.emailSearchResults, "Possible Phone: " + text2);
					Console.WriteLine(text2);
				}
				this.UpdateBar(this.emailProgress, 33);
				url = "http://www.whoismind.com/email/" + workerArgs.email + ".html";
				pageSource = this.functions.GetPageSource(url);
				MatchCollection matchCollection = (MatchCollection)this.functions.GetMatches(pageSource, "<a href=\"/whois/(.*?).html");
				string[] array5 = new string[matchCollection.Count + 1];
				num = 0;
				try
				{
					foreach (object obj3 in matchCollection)
					{
						string text3 = ((Match)obj3).Groups[1].Value;
						text3 = text3.Replace("<a href=\"/whois/", "");
						text3 = text3.Replace(".html", "");
						array5[num] = text3;
						this.AddToListBox(this.emailSearchResults, "Domain Name:  http://" + text3);
						Console.WriteLine(text3);
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				foreach (string str in array5)
				{
					string pageSource2 = this.functions.GetPageSource("http://api.bulkwhoisapi.com/whoisAPI.php?domain=" + str + "&token=usemeforfree");
					try
					{
						object objectValue3 = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(pageSource2));
						object right = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantName"
						}, null).ToString();
						object obj4 = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantStreet"
						}, null).ToString();
						obj4 = Operators.AddObject(obj4, " - " + NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantCity"
						}, null).ToString());
						obj4 = Operators.AddObject(obj4, ", " + NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantPostalCode"
						}, null).ToString());
						object right2 = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue3, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantPhone"
						}, null).ToString();
						this.AddToListBox(this.emailSearchResults, Operators.AddObject("Possible Name:  ", right));
						this.AddToListBox(this.emailSearchResults, Operators.AddObject("Possible Address:  ", obj4));
						this.AddToListBox(this.emailSearchResults, Operators.AddObject("Possible Phone:  ", right2));
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}
				this.UpdateBar(this.emailProgress, 66);
				url = "https://hacked-emails.com/api?q=" + workerArgs.email;
				pageSource = this.functions.GetPageSource(url);
				List<JToken> list = ((IEnumerable<JToken>)JObject.Parse(pageSource).Children()).ToList<JToken>();
				try
				{
					foreach (JToken jtoken in list)
					{
						JProperty jproperty = (JProperty)jtoken;
						jproperty.CreateReader();
						Console.WriteLine(jproperty.Name);
						string name = jproperty.Name;
						if (Operators.CompareString(name, "data", false) == 0)
						{
							try
							{
								foreach (JToken jtoken2 in jproperty.Values())
								{
									string text4 = ((JObject)jtoken2)["source_url"].ToString();
									if (!text4.Equals("#"))
									{
										this.AddToListBox(this.emailSearchResults, "Possible Data Leak:  " + text4);
										Console.WriteLine(text4);
									}
								}
							}
							finally
							{
								IEnumerator<JToken> enumerator5;
								if (enumerator5 != null)
								{
									enumerator5.Dispose();
								}
							}
						}
					}
				}
				finally
				{
					List<JToken>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
				this.UpdateBar(this.emailProgress, 70);
				this.googleWorker.RunWorkerAsync(RuntimeHelpers.GetObjectValue(e.Argument));
				Console.WriteLine("Done");
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003FD0 File Offset: 0x000021D0
		private void googleWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			Form1.WorkerArgs workerArgs = (Form1.WorkerArgs)e.Argument;
			string pageSource = this.functions.GetPageSource("http://www.google.com/search?num=100&q=\"" + workerArgs.query + "\"");
			try
			{
				foreach (object obj in new Regex("url\\?q=(.*?)&").Matches(pageSource))
				{
					string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), null, "groups", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					Console.WriteLine(text);
					if (!text.Contains("googleusercontent") && !text.Contains("/settings/ads"))
					{
						this.AddToListBox(workerArgs.box, "Possible Connection: " + WebUtility.HtmlDecode(text));
						this.UpdateBar(workerArgs.bar, checked(workerArgs.bar.Value + 2));
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
			this.UpdateBar(workerArgs.bar, 100);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00007697 File Offset: 0x00005897
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000769F File Offset: 0x0000589F
		internal virtual LogInThemeContainer LogInThemeContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000076A8 File Offset: 0x000058A8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000076B0 File Offset: 0x000058B0
		internal virtual LogInTabControl LogInTabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000076B9 File Offset: 0x000058B9
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000076C1 File Offset: 0x000058C1
		internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000076CA File Offset: 0x000058CA
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000076D2 File Offset: 0x000058D2
		internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000076DB File Offset: 0x000058DB
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000076E4 File Offset: 0x000058E4
		internal virtual LogInButton nameSearch
		{
			[CompilerGenerated]
			get
			{
				return this._nameSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.nameSearch_Click);
				LogInButton nameSearch = this._nameSearch;
				if (nameSearch != null)
				{
					nameSearch.Click -= value2;
				}
				this._nameSearch = value;
				nameSearch = this._nameSearch;
				if (nameSearch != null)
				{
					nameSearch.Click += value2;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00007727 File Offset: 0x00005927
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000772F File Offset: 0x0000592F
		internal virtual LogInNormalTextBox location { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00007738 File Offset: 0x00005938
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00007740 File Offset: 0x00005940
		internal virtual LogInLabel LogInLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00007749 File Offset: 0x00005949
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00007751 File Offset: 0x00005951
		internal virtual LogInNormalTextBox lastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000775A File Offset: 0x0000595A
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00007762 File Offset: 0x00005962
		internal virtual LogInNormalTextBox firstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000776B File Offset: 0x0000596B
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00007773 File Offset: 0x00005973
		internal virtual LogInLabel LogInLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000777C File Offset: 0x0000597C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00007784 File Offset: 0x00005984
		internal virtual LogInLabel LogInLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000778D File Offset: 0x0000598D
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00007795 File Offset: 0x00005995
		internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000779E File Offset: 0x0000599E
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000077A6 File Offset: 0x000059A6
		internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000077AF File Offset: 0x000059AF
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000077B7 File Offset: 0x000059B7
		internal virtual LogInNormalTextBox email { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000077C0 File Offset: 0x000059C0
		// (set) Token: 0x0600004A RID: 74 RVA: 0x000077C8 File Offset: 0x000059C8
		internal virtual LogInLabel LogInLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000077D1 File Offset: 0x000059D1
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000077DC File Offset: 0x000059DC
		internal virtual LogInButton emailSearch
		{
			[CompilerGenerated]
			get
			{
				return this._emailSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.emailSearch_Click);
				LogInButton emailSearch = this._emailSearch;
				if (emailSearch != null)
				{
					emailSearch.Click -= value2;
				}
				this._emailSearch = value;
				emailSearch = this._emailSearch;
				if (emailSearch != null)
				{
					emailSearch.Click += value2;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000781F File Offset: 0x00005A1F
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00007828 File Offset: 0x00005A28
		internal virtual LogInButton userSearch
		{
			[CompilerGenerated]
			get
			{
				return this._userSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.userSearch_Click);
				LogInButton userSearch = this._userSearch;
				if (userSearch != null)
				{
					userSearch.Click -= value2;
				}
				this._userSearch = value;
				userSearch = this._userSearch;
				if (userSearch != null)
				{
					userSearch.Click += value2;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000786B File Offset: 0x00005A6B
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00007873 File Offset: 0x00005A73
		internal virtual LogInNormalTextBox usernameSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000787C File Offset: 0x00005A7C
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00007884 File Offset: 0x00005A84
		internal virtual LogInLabel LogInLabel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000788D File Offset: 0x00005A8D
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00007895 File Offset: 0x00005A95
		internal virtual LogInGroupBox LogInGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000789E File Offset: 0x00005A9E
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000078A6 File Offset: 0x00005AA6
		internal virtual LogInNormalTextBox zipCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000078AF File Offset: 0x00005AAF
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000078B7 File Offset: 0x00005AB7
		internal virtual LogInLabel LogInLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000078C0 File Offset: 0x00005AC0
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000078C8 File Offset: 0x00005AC8
		internal virtual LogInNormalTextBox latLong { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000078D1 File Offset: 0x00005AD1
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000078D9 File Offset: 0x00005AD9
		internal virtual LogInLabel LogInLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000078E2 File Offset: 0x00005AE2
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000078EA File Offset: 0x00005AEA
		internal virtual LogInNormalTextBox cityState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000078F3 File Offset: 0x00005AF3
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000078FB File Offset: 0x00005AFB
		internal virtual LogInLabel LogInLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00007904 File Offset: 0x00005B04
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000790C File Offset: 0x00005B0C
		internal virtual LogInButton ipSearchButton
		{
			[CompilerGenerated]
			get
			{
				return this._ipSearchButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ipSearchButton_Click);
				LogInButton ipSearchButton = this._ipSearchButton;
				if (ipSearchButton != null)
				{
					ipSearchButton.Click -= value2;
				}
				this._ipSearchButton = value;
				ipSearchButton = this._ipSearchButton;
				if (ipSearchButton != null)
				{
					ipSearchButton.Click += value2;
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000794F File Offset: 0x00005B4F
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00007957 File Offset: 0x00005B57
		internal virtual LogInNormalTextBox ipText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00007960 File Offset: 0x00005B60
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00007968 File Offset: 0x00005B68
		internal virtual LogInLabel LogInLabel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00007971 File Offset: 0x00005B71
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000797C File Offset: 0x00005B7C
		internal virtual LogInButton mapButton
		{
			[CompilerGenerated]
			get
			{
				return this._mapButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mapButton_Click);
				LogInButton mapButton = this._mapButton;
				if (mapButton != null)
				{
					mapButton.Click -= value2;
				}
				this._mapButton = value;
				mapButton = this._mapButton;
				if (mapButton != null)
				{
					mapButton.Click += value2;
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000079BF File Offset: 0x00005BBF
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000079C7 File Offset: 0x00005BC7
		internal virtual LogInGroupBox LogInGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000079D0 File Offset: 0x00005BD0
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000079D8 File Offset: 0x00005BD8
		internal virtual LogInButton exportButton
		{
			[CompilerGenerated]
			get
			{
				return this._exportButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.exportButton_Click);
				LogInButton exportButton = this._exportButton;
				if (exportButton != null)
				{
					exportButton.Click -= value2;
				}
				this._exportButton = value;
				exportButton = this._exportButton;
				if (exportButton != null)
				{
					exportButton.Click += value2;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00007A1B File Offset: 0x00005C1B
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00007A23 File Offset: 0x00005C23
		internal virtual LogInRichTextBox otherInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00007A2C File Offset: 0x00005C2C
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00007A34 File Offset: 0x00005C34
		internal virtual LogInLabel LogInLabel15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00007A3D File Offset: 0x00005C3D
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00007A45 File Offset: 0x00005C45
		internal virtual LogInNormalTextBox emailTemplate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00007A4E File Offset: 0x00005C4E
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00007A56 File Offset: 0x00005C56
		internal virtual LogInLabel LogInLabel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00007A5F File Offset: 0x00005C5F
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00007A67 File Offset: 0x00005C67
		internal virtual LogInNormalTextBox addressTemplate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00007A70 File Offset: 0x00005C70
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00007A78 File Offset: 0x00005C78
		internal virtual LogInLabel LogInLabel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00007A81 File Offset: 0x00005C81
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00007A89 File Offset: 0x00005C89
		internal virtual LogInNormalTextBox phoneTemplate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00007A92 File Offset: 0x00005C92
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00007A9A File Offset: 0x00005C9A
		internal virtual LogInLabel LogInLabel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00007AA3 File Offset: 0x00005CA3
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00007AAB File Offset: 0x00005CAB
		internal virtual LogInNormalTextBox ageTemplate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00007AB4 File Offset: 0x00005CB4
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00007ABC File Offset: 0x00005CBC
		internal virtual LogInLabel LogInLabel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00007AC5 File Offset: 0x00005CC5
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00007ACD File Offset: 0x00005CCD
		internal virtual LogInNormalTextBox nameTemplate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00007AD6 File Offset: 0x00005CD6
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00007ADE File Offset: 0x00005CDE
		internal virtual LogInLabel LogInLabel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00007AE7 File Offset: 0x00005CE7
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00007AF0 File Offset: 0x00005CF0
		internal virtual ListBox personSearchResults
		{
			[CompilerGenerated]
			get
			{
				return this._personSearchResults;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.personSearchResults_DoubleClick);
				ListBox personSearchResults = this._personSearchResults;
				if (personSearchResults != null)
				{
					personSearchResults.DoubleClick -= value2;
				}
				this._personSearchResults = value;
				personSearchResults = this._personSearchResults;
				if (personSearchResults != null)
				{
					personSearchResults.DoubleClick += value2;
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00007B33 File Offset: 0x00005D33
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00007B3C File Offset: 0x00005D3C
		internal virtual ListBox emailSearchResults
		{
			[CompilerGenerated]
			get
			{
				return this._emailSearchResults;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.emailSearchResults_SelectedIndexChanged);
				EventHandler value3 = new EventHandler(this.emailSearchResults_DoubleClick);
				ListBox emailSearchResults = this._emailSearchResults;
				if (emailSearchResults != null)
				{
					emailSearchResults.SelectedIndexChanged -= value2;
					emailSearchResults.DoubleClick -= value3;
				}
				this._emailSearchResults = value;
				emailSearchResults = this._emailSearchResults;
				if (emailSearchResults != null)
				{
					emailSearchResults.SelectedIndexChanged += value2;
					emailSearchResults.DoubleClick += value3;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00007B9A File Offset: 0x00005D9A
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00007BA4 File Offset: 0x00005DA4
		internal virtual ListBox usernameSearchResults
		{
			[CompilerGenerated]
			get
			{
				return this._usernameSearchResults;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.usernameSearchResults_DoubleClick);
				ListBox usernameSearchResults = this._usernameSearchResults;
				if (usernameSearchResults != null)
				{
					usernameSearchResults.DoubleClick -= value2;
				}
				this._usernameSearchResults = value;
				usernameSearchResults = this._usernameSearchResults;
				if (usernameSearchResults != null)
				{
					usernameSearchResults.DoubleClick += value2;
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00007BE7 File Offset: 0x00005DE7
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00007BF0 File Offset: 0x00005DF0
		internal virtual BackgroundWorker personSearch
		{
			[CompilerGenerated]
			get
			{
				return this._personSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
				ProgressChangedEventHandler value3 = new ProgressChangedEventHandler(this.personSearch_ProgressChanged);
				BackgroundWorker personSearch = this._personSearch;
				if (personSearch != null)
				{
					personSearch.DoWork -= value2;
					personSearch.ProgressChanged -= value3;
				}
				this._personSearch = value;
				personSearch = this._personSearch;
				if (personSearch != null)
				{
					personSearch.DoWork += value2;
					personSearch.ProgressChanged += value3;
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00007C4E File Offset: 0x00005E4E
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00007C56 File Offset: 0x00005E56
		internal virtual LogInLabel LogInLabel16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00007C5F File Offset: 0x00005E5F
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00007C67 File Offset: 0x00005E67
		internal virtual LogInProgressBar personProgress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00007C70 File Offset: 0x00005E70
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00007C78 File Offset: 0x00005E78
		internal virtual BackgroundWorker emailWorker
		{
			[CompilerGenerated]
			get
			{
				return this._emailWorker;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.emailWorker_DoWork);
				BackgroundWorker emailWorker = this._emailWorker;
				if (emailWorker != null)
				{
					emailWorker.DoWork -= value2;
				}
				this._emailWorker = value;
				emailWorker = this._emailWorker;
				if (emailWorker != null)
				{
					emailWorker.DoWork += value2;
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00007CBB File Offset: 0x00005EBB
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00007CC3 File Offset: 0x00005EC3
		internal virtual LogInLabel LogInLabel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00007CCC File Offset: 0x00005ECC
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00007CD4 File Offset: 0x00005ED4
		internal virtual LogInProgressBar emailProgress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00007CDD File Offset: 0x00005EDD
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00007CE5 File Offset: 0x00005EE5
		internal virtual LogInLabel LogInLabel18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00007CEE File Offset: 0x00005EEE
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00007CF6 File Offset: 0x00005EF6
		internal virtual LogInProgressBar usernameProgress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00007CFF File Offset: 0x00005EFF
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00007D08 File Offset: 0x00005F08
		internal virtual BackgroundWorker googleWorker
		{
			[CompilerGenerated]
			get
			{
				return this._googleWorker;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.googleWorker_DoWork);
				BackgroundWorker googleWorker = this._googleWorker;
				if (googleWorker != null)
				{
					googleWorker.DoWork -= value2;
				}
				this._googleWorker = value;
				googleWorker = this._googleWorker;
				if (googleWorker != null)
				{
					googleWorker.DoWork += value2;
				}
			}
		}

		// Token: 0x0400000D RID: 13
		private Functions functions;

		// Token: 0x0200002F RID: 47
		public class WorkerArgs
		{
			// Token: 0x0400015A RID: 346
			public string first;

			// Token: 0x0400015B RID: 347
			public string last;

			// Token: 0x0400015C RID: 348
			public string location;

			// Token: 0x0400015D RID: 349
			public string email;

			// Token: 0x0400015E RID: 350
			public string username;

			// Token: 0x0400015F RID: 351
			public string query;

			// Token: 0x04000160 RID: 352
			public ListBox box;

			// Token: 0x04000161 RID: 353
			public LogInProgressBar bar;
		}
	}
}
