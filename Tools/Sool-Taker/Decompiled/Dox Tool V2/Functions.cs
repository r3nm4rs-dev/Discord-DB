using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Dox_Tool_V2
{
	// Token: 0x0200000A RID: 10
	public class Functions
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00007D54 File Offset: 0x00005F54
		public string GetPageSource(string url)
		{
			string result = string.Empty;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				httpWebRequest.Timeout = 5000;
				httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)";
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				result = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			}
			catch (Exception ex)
			{
				Console.WriteLine(url + ": " + ex.Message);
			}
			return result;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007DDC File Offset: 0x00005FDC
		public object GetMatches(string toSearch, string regexPattern)
		{
			return Regex.Matches(toSearch, regexPattern, RegexOptions.Multiline);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public bool IsUri(string source)
		{
			Uri uri;
			return !string.IsNullOrEmpty(source) && Uri.IsWellFormedUriString(source, UriKind.RelativeOrAbsolute) && Uri.TryCreate(source, UriKind.RelativeOrAbsolute, out uri);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007E18 File Offset: 0x00006018
		public void SearchGoogle(string query, ref ListBox g)
		{
			string pageSource = this.GetPageSource("http://www.google.com/search?num=100&q=\"" + query + "\"");
			try
			{
				foreach (object obj in new Regex("url\\?q=(.*?)&").Matches(pageSource))
				{
					string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(obj), null, "groups", new object[]
					{
						1
					}, null, null, null), null, "Value", new object[0], null, null, null));
					if (!g.Items.Contains(text) && !text.Contains("googleusercontent") && !text.Contains("/settings/ads"))
					{
						g.Items.Add("Possible Connection: " + HttpUtility.UrlDecode(text));
						Console.WriteLine(text);
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
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007F18 File Offset: 0x00006118
		public object Contains(ref ListBox g, string f)
		{
			bool flag = false;
			try
			{
				foreach (object value in g.Items)
				{
					string value2 = Conversions.ToString(value);
					if (f.Equals(value2))
					{
						flag = true;
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
			return flag;
		}
	}
}
