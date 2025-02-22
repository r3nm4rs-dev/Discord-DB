using System;
using System.Collections;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Dox_Tool_V2.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Dox_Tool_V2
{
	// Token: 0x0200000B RID: 11
	public class NameSearch
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00007F84 File Offset: 0x00006184
		public NameSearch(string firstName, string lastName, string locat)
		{
			this.functions = new Functions();
			this.first = firstName;
			this.last = lastName;
			this.location = locat;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007FAC File Offset: 0x000061AC
		public void Search411()
		{
			string url = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("http://www.411.com/name/", this.first), "-"), this.last), "/"), this.location));
			string pageSource = this.functions.GetPageSource(url);
			object objectValue = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "Lives at:  </span> (.*?)$"));
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
				foreach (string text2 in array)
				{
					if (!string.IsNullOrEmpty(text2))
					{
						Functions functions = this.functions;
						Form1 form;
						ListBox personSearchResults = (form = MyProject.Forms.Form1).personSearchResults;
						object operand = functions.Contains(ref personSearchResults, text2);
						form.personSearchResults = personSearchResults;
						if (Conversions.ToBoolean(Operators.NotObject(operand)) && !text2.ToLower().Contains("unknown"))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("411 Possible Address: " + text2);
							Console.WriteLine(text2);
						}
					}
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000817C File Offset: 0x0000637C
		public void SearchTenDigits()
		{
			string url = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("http://10digits.us/n/", this.first), "_"), this.last), "/location/"), this.location));
			string pageSource = this.functions.GetPageSource(url);
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
				foreach (string text2 in array)
				{
					if (!string.IsNullOrEmpty(text2))
					{
						Functions functions = this.functions;
						Form1 form;
						ListBox personSearchResults = (form = MyProject.Forms.Form1).personSearchResults;
						object operand = functions.Contains(ref personSearchResults, text2);
						form.personSearchResults = personSearchResults;
						if (Conversions.ToBoolean(Operators.NotObject(operand)))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Address: " + text2);
							Console.WriteLine(text2);
						}
					}
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00008338 File Offset: 0x00006538
		public void SearchZaba()
		{
			string url = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject("http://www.zabasearch.com/people/", this.first), "+"), this.last), "/"), this.location));
			string pageSource = this.functions.GetPageSource(url);
			checked
			{
				if (!pageSource.Contains("Free <span class=\"listings-available-box\">Listings</span>"))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "initialize(.*?);</script>"));
					string[] array = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null)) + 1];
					int num = 0;
					try
					{
						foreach (object obj in ((IEnumerable)objectValue))
						{
							string text = WebUtility.HtmlDecode(((Match)obj).Groups[1].Value);
							text = Regex.Match(text, "'\"(.*?)\"'").Groups[1].Value;
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
					foreach (string text2 in array)
					{
						if (!string.IsNullOrEmpty(text2))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Address: " + text2);
							Console.WriteLine(text2);
						}
					}
					string value = Regex.Match(pageSource, "itemprop=\"telephone\">(.*?)</font>").Groups[1].Value;
					MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Phone: " + value);
					Console.WriteLine(value);
					return;
				}
				Console.WriteLine("More than one match");
				object objectValue2 = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "itemprop=\"streetAddress\">(.*?)</"));
				object objectValue3 = RuntimeHelpers.GetObjectValue(this.functions.GetMatches(pageSource, "<span itemprop=\"telephone\">(.*?)</span>"));
				string[] array3 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, null, "Count", new object[0], null, null, null)) + 1];
				string[] array4 = new string[Conversions.ToInteger(NewLateBinding.LateGet(objectValue3, null, "Count", new object[0], null, null, null)) + 1];
				int num2 = 0;
				try
				{
					foreach (object obj2 in ((IEnumerable)objectValue2))
					{
						string text3 = WebUtility.HtmlDecode(((Match)obj2).Groups[1].Value);
						array3[num2] = text3;
						num2++;
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
				num2 = 0;
				try
				{
					foreach (object obj3 in ((IEnumerable)objectValue3))
					{
						string text4 = WebUtility.HtmlDecode(((Match)obj3).Groups[1].Value);
						array4[num2] = text4;
						num2++;
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
				foreach (string text5 in array3)
				{
					if (!string.IsNullOrEmpty(text5))
					{
						Functions functions = this.functions;
						Form1 form;
						ListBox personSearchResults = (form = MyProject.Forms.Form1).personSearchResults;
						object operand = functions.Contains(ref personSearchResults, text5);
						form.personSearchResults = personSearchResults;
						if (Conversions.ToBoolean(Operators.NotObject(operand)))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Address: " + text5);
						}
					}
				}
				foreach (string text6 in array4)
				{
					if (!string.IsNullOrEmpty(text6))
					{
						Functions functions2 = this.functions;
						Form1 form;
						ListBox personSearchResults = (form = MyProject.Forms.Form1).personSearchResults;
						object operand2 = functions2.Contains(ref personSearchResults, text6);
						form.personSearchResults = personSearchResults;
						if (Conversions.ToBoolean(Operators.NotObject(operand2)))
						{
							MyProject.Forms.Form1.personSearchResults.Items.Add("Possible Phone Number: " + text6);
						}
					}
				}
			}
		}

		// Token: 0x04000047 RID: 71
		private object first;

		// Token: 0x04000048 RID: 72
		private object last;

		// Token: 0x04000049 RID: 73
		private object location;

		// Token: 0x0400004A RID: 74
		private Functions functions;
	}
}
