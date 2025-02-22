using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Dox_Tool_V2.My;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dox_Tool_V2
{
	// Token: 0x02000008 RID: 8
	public class EmailSearch
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002213 File Offset: 0x00000413
		public EmailSearch(string toSearch)
		{
			this.functions = new Functions();
			this.email = toSearch;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002230 File Offset: 0x00000430
		public void SearchThatsThem()
		{
			string url = "https://thatsthem.com/email/" + this.email;
			string pageSource = this.functions.GetPageSource(url);
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
					if (!string.IsNullOrEmpty(text) && !MyProject.Forms.Form1.emailSearchResults.Items.Contains(text))
					{
						MyProject.Forms.Form1.emailSearchResults.Items.Add("Possible Address: " + text);
						Console.WriteLine(text);
					}
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
					if (!string.IsNullOrEmpty(text2) && !MyProject.Forms.Form1.emailSearchResults.Items.Contains(text2))
					{
						MyProject.Forms.Form1.emailSearchResults.Items.Add("Possible Phone: " + text2);
						Console.WriteLine(text2);
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000248C File Offset: 0x0000068C
		public void SearchWhoIsMind()
		{
			string url = "http://www.whoismind.com/email/" + this.email + ".html";
			string pageSource = this.functions.GetPageSource(url);
			MatchCollection matchCollection = (MatchCollection)this.functions.GetMatches(pageSource, "<a href=\"/whois/(.*?).html");
			checked
			{
				string[] array = new string[matchCollection.Count + 1];
				int num = 0;
				try
				{
					foreach (object obj in matchCollection)
					{
						string text = ((Match)obj).Groups[1].Value;
						text = text.Replace("<a href=\"/whois/", "");
						text = text.Replace(".html", "");
						array[num] = text;
						if (!string.IsNullOrEmpty(text) && !MyProject.Forms.Form1.emailSearchResults.Items.Contains(text))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add("Domain name:  http://" + text);
							Console.WriteLine(text);
						}
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
				foreach (string str in array)
				{
					string pageSource2 = this.functions.GetPageSource("http://api.bulkwhoisapi.com/whoisAPI.php?domain=" + str + "&token=usemeforfree");
					try
					{
						object objectValue = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(pageSource2));
						object obj2 = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantName"
						}, null).ToString();
						object obj3 = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantStreet"
						}, null).ToString();
						obj3 = Operators.AddObject(obj3, " - " + NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantCity"
						}, null).ToString());
						obj3 = Operators.AddObject(obj3, ", " + NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantPostalCode"
						}, null).ToString());
						object obj4 = NewLateBinding.LateIndexGet(NewLateBinding.LateIndexGet(objectValue, new object[]
						{
							"formatted_data"
						}, null), new object[]
						{
							"RegistrantPhone"
						}, null).ToString();
						if (!MyProject.Forms.Form1.emailSearchResults.Items.Contains(RuntimeHelpers.GetObjectValue(obj2)))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add(Operators.AddObject("Possible name:  ", obj2));
						}
						if (!MyProject.Forms.Form1.emailSearchResults.Items.Contains(RuntimeHelpers.GetObjectValue(obj3)))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add(Operators.AddObject("Possible address:  ", obj3));
						}
						if (!MyProject.Forms.Form1.emailSearchResults.Items.Contains(RuntimeHelpers.GetObjectValue(obj4)))
						{
							MyProject.Forms.Form1.emailSearchResults.Items.Add(Operators.AddObject("Possible phone:  ", obj4));
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000283C File Offset: 0x00000A3C
		public void SearchDatabases()
		{
			string url = "https://hacked-emails.com/api?q=" + this.email;
			List<JToken> list = ((IEnumerable<JToken>)JObject.Parse(this.functions.GetPageSource(url)).Children()).ToList<JToken>();
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
								string text = ((JObject)jtoken2)["source_url"].ToString();
								if (!text.Equals("#") && !MyProject.Forms.Form1.emailSearchResults.Items.Contains(text))
								{
									MyProject.Forms.Form1.emailSearchResults.Items.Add("Possible Data Leak:  " + text);
									Console.WriteLine(text);
								}
							}
						}
						finally
						{
							IEnumerator<JToken> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
				}
			}
			finally
			{
				List<JToken>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x0400000B RID: 11
		private string email;

		// Token: 0x0400000C RID: 12
		private Functions functions;
	}
}
