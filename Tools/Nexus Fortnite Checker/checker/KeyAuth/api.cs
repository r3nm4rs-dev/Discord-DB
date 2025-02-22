// Decompiled with JetBrains decompiler
// Type: KeyAuth.api
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

#nullable disable
namespace KeyAuth
{
  public class api
  {
    public string name;
    public string ownerid;
    public string secret;
    public string version;
    private string sessionid;
    private string enckey;
    private bool initzalized;
    public static string Usernameee;
    public api.app_data_class app_data = new api.app_data_class();
    public api.user_data_class user_data = new api.user_data_class();
    public api.Data ongod = new api.Data();
    public api.response_class response = new api.response_class();
    private json_wrapper response_decoder = new json_wrapper((object) new api.response_structure());

    public api(string name, string ownerid, string secret, string version)
    {
      if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
      {
        api.error("Application not setup correctly. Please watch video link found in Program.cs");
        Environment.Exit(0);
      }
      this.name = name;
      this.ownerid = ownerid;
      this.secret = secret;
      this.version = version;
    }

    public void init()
    {
      this.enckey = encryption.sha256(encryption.iv_key());
      string iv = encryption.sha256(encryption.iv_key());
      string message = api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (init))),
        ["ver"] = encryption.encrypt(this.version, this.secret, iv),
        ["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName),
        ["enckey"] = encryption.encrypt(this.enckey, this.secret, iv),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      });
      if (message == "KeyAuth_Invalid")
      {
        api.error("Application not found");
        Environment.Exit(0);
      }
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(message, this.secret, iv));
      this.load_response_struct(generic);
      if (generic.success)
      {
        this.load_app_data(generic.appinfo);
        this.sessionid = generic.sessionid;
        this.initzalized = true;
      }
      else
      {
        if (!(generic.message == "invalidver"))
          return;
        this.app_data.downloadLink = generic.download;
      }
    }

    public void register(string username, string pass, string key)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string message = WindowsIdentity.GetCurrent().User.Value;
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (register))),
        [nameof (username)] = encryption.encrypt(username, this.enckey, iv),
        [nameof (pass)] = encryption.encrypt(pass, this.enckey, iv),
        [nameof (key)] = encryption.encrypt(key, this.enckey, iv),
        ["hwid"] = encryption.encrypt(message, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      if (!generic.success)
        return;
      this.load_user_data(generic.info);
    }

    public void login(string username, string pass)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string message = WindowsIdentity.GetCurrent().User.Value;
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (login))),
        [nameof (username)] = encryption.encrypt(username, this.enckey, iv),
        [nameof (pass)] = encryption.encrypt(pass, this.enckey, iv),
        ["hwid"] = encryption.encrypt(message, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      if (!generic.success)
        return;
      this.load_user_data(generic.info);
    }

    public void web_login()
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string str1 = WindowsIdentity.GetCurrent().User.Value;
      HttpListener httpListener = new HttpListener();
      string uriPrefix = "http://localhost:1337/" + "handshake" + "/";
      httpListener.Prefixes.Add(uriPrefix);
      httpListener.Start();
      HttpListenerContext context = httpListener.GetContext();
      HttpListenerRequest request = context.Request;
      HttpListenerResponse response = context.Response;
      response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
      response.AddHeader("Access-Control-Allow-Origin", "*");
      response.AddHeader("Via", "hugzho's big brain");
      response.AddHeader("Location", "your kernel ;)");
      response.AddHeader("Retry-After", "never lmao");
      response.Headers.Add("Server", "\r\n\r\n");
      httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
      httpListener.UnsafeConnectionNtlmAuthentication = true;
      httpListener.IgnoreWriteExceptions = true;
      string str2 = request.RawUrl.Replace("/handshake?user=", "").Replace("&token=", " ");
      string str3 = str2.Split()[0];
      string str4 = str2.Split(' ')[1];
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(api.req_unenc(new NameValueCollection()
      {
        ["type"] = "login",
        ["username"] = str3,
        ["token"] = str4,
        ["hwid"] = str1,
        ["sessionid"] = this.sessionid,
        ["name"] = this.name,
        ["ownerid"] = this.ownerid
      }));
      this.load_response_struct(generic);
      bool flag = true;
      if (generic.success)
      {
        this.load_user_data(generic.info);
        System.IO.File.WriteAllText("C:\\Login.txt", generic.ToString());
        response.StatusCode = 420;
        response.StatusDescription = "SHEESH";
      }
      else
      {
        Console.WriteLine(generic.message);
        System.IO.File.WriteAllText("C:\\Login.txt", generic.ToString());
        response.StatusCode = 200;
        response.StatusDescription = generic.message;
        flag = false;
      }
      byte[] bytes = Encoding.UTF8.GetBytes("Whats up?");
      response.ContentLength64 = (long) bytes.Length;
      response.OutputStream.Write(bytes, 0, bytes.Length);
      Thread.Sleep(1250);
      httpListener.Stop();
      if (!flag)
        System.IO.File.WriteAllText("C:\\Login.txt", generic.ToString());
      Environment.Exit(0);
    }

    public void button(string button)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      HttpListener httpListener = new HttpListener();
      string uriPrefix = "http://localhost:1337/" + button + "/";
      httpListener.Prefixes.Add(uriPrefix);
      httpListener.Start();
      HttpListenerContext context = httpListener.GetContext();
      HttpListenerRequest request = context.Request;
      HttpListenerResponse response = context.Response;
      response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
      response.AddHeader("Access-Control-Allow-Origin", "*");
      response.AddHeader("Via", "hugzho's big brain");
      response.AddHeader("Location", "your kernel ;)");
      response.AddHeader("Retry-After", "never lmao");
      response.Headers.Add("Server", "\r\n\r\n");
      response.StatusCode = 420;
      response.StatusDescription = "SHEESH";
      httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
      httpListener.UnsafeConnectionNtlmAuthentication = true;
      httpListener.IgnoreWriteExceptions = true;
      httpListener.Stop();
    }

    public void upgrade(string username, string key)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string str = WindowsIdentity.GetCurrent().User.Value;
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (upgrade))),
        [nameof (username)] = encryption.encrypt(username, this.enckey, iv),
        [nameof (key)] = encryption.encrypt(key, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      generic.success = false;
      this.load_response_struct(generic);
    }

    public void license(string key)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string message = WindowsIdentity.GetCurrent().User.Value;
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (license))),
        [nameof (key)] = encryption.encrypt(key, this.enckey, iv),
        ["hwid"] = encryption.encrypt(message, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      if (!generic.success)
        return;
      this.load_user_data(generic.info);
    }

    public void check()
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      this.load_response_struct(this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (check))),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv)));
    }

    public void setvar(string var, string data)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      this.load_response_struct(this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (setvar))),
        [nameof (var)] = encryption.encrypt(var, this.enckey, iv),
        [nameof (data)] = encryption.encrypt(data, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv)));
    }

    public string getvar(string var)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (getvar))),
        [nameof (var)] = encryption.encrypt(var, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      return generic.success ? generic.response : (string) null;
    }

    public void ban(string reason = null)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      this.load_response_struct(this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (ban))),
        [nameof (reason)] = reason,
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv)));
    }

    public string var(string varid)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string str = WindowsIdentity.GetCurrent().User.Value;
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (var))),
        [nameof (varid)] = encryption.encrypt(varid, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      return generic.success ? generic.message : (string) null;
    }

    public List<api.users> fetchOnline()
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (fetchOnline))),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      return generic.success ? generic.users : (List<api.users>) null;
    }

    public List<api.msg> chatget(string channelname)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (chatget))),
        ["channel"] = encryption.encrypt(channelname, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      return generic.success && !(generic.messages[0].message == "not_found") ? generic.messages : (List<api.msg>) null;
    }

    public bool chatsend(string msg, string channelname)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (chatsend))),
        ["message"] = encryption.encrypt(msg, this.enckey, iv),
        ["channel"] = encryption.encrypt(channelname, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      return generic.success;
    }

    public bool checkblack()
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string message = WindowsIdentity.GetCurrent().User.Value;
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist")),
        ["hwid"] = encryption.encrypt(message, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      return generic.success;
    }

    public string webhook(string webid, string param, string body = "", string conttype = "")
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
        return (string) null;
      }
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (webhook))),
        [nameof (webid)] = encryption.encrypt(webid, this.enckey, iv),
        ["params"] = encryption.encrypt(param, this.enckey, iv),
        [nameof (body)] = encryption.encrypt(body, this.enckey, iv),
        [nameof (conttype)] = encryption.encrypt(conttype, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      return generic.success ? generic.response : (string) null;
    }

    public byte[] download(string fileid)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first. File is empty since no request could be made.");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      api.response_structure generic = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt(api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file")),
        [nameof (fileid)] = encryption.encrypt(fileid, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      }), this.enckey, iv));
      this.load_response_struct(generic);
      return generic.success ? encryption.str_to_byte_arr(generic.contents) : (byte[]) null;
    }

    public void log(string message)
    {
      if (!this.initzalized)
      {
        api.error("Please initzalize first");
        Environment.Exit(0);
      }
      string iv = encryption.sha256(encryption.iv_key());
      api.req(new NameValueCollection()
      {
        ["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(nameof (log))),
        ["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, iv),
        [nameof (message)] = encryption.encrypt(message, this.enckey, iv),
        ["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid)),
        ["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name)),
        ["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid)),
        ["init_iv"] = iv
      });
    }

    public static string checksum(string filename)
    {
      string lowerInvariant;
      using (MD5 md5 = MD5.Create())
      {
        using (FileStream inputStream = System.IO.File.OpenRead(filename))
          lowerInvariant = BitConverter.ToString(md5.ComputeHash((Stream) inputStream)).Replace("-", "").ToLowerInvariant();
      }
      return lowerInvariant;
    }

    public static void error(string message)
    {
      Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
      {
        CreateNoWindow = true,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false
      });
      Environment.Exit(0);
    }

    private static string req(NameValueCollection post_data)
    {
      try
      {
        using (WebClient webClient = new WebClient())
        {
          byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
          Encoding.Default.GetString(bytes);
          return Encoding.Default.GetString(bytes);
        }
      }
      catch (WebException ex)
      {
        if (((HttpWebResponse) ex.Response).StatusCode == (HttpStatusCode) 429)
        {
          api.error("You're connecting too fast to loader, slow down.");
          Environment.Exit(0);
          return "";
        }
        api.error("Connection failure. Please try again, or contact us for help.");
        Environment.Exit(0);
        return "";
      }
    }

    private static string req_unenc(NameValueCollection post_data)
    {
      try
      {
        using (WebClient webClient = new WebClient())
          return Encoding.Default.GetString(webClient.UploadValues("https://keyauth.win/api/1.1/", post_data));
      }
      catch (WebException ex)
      {
        if (((HttpWebResponse) ex.Response).StatusCode == (HttpStatusCode) 429)
        {
          Thread.Sleep(1000);
          return api.req(post_data);
        }
        api.error("Connection failure. Please try again, or contact us for help.");
        Environment.Exit(0);
        return "";
      }
    }

    private void load_app_data(api.app_data_structure data)
    {
      this.app_data.numUsers = data.numUsers;
      this.app_data.numOnlineUsers = data.numOnlineUsers;
      this.app_data.numKeys = data.numKeys;
      this.app_data.version = data.version;
      this.app_data.customerPanelLink = data.customerPanelLink;
    }

    public string expirydaysleft()
    {
      TimeSpan timeSpan = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds((double) long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime() - DateTime.Now;
      int num = timeSpan.Days;
      string str1 = num.ToString();
      num = timeSpan.Hours;
      string str2 = num.ToString();
      return Convert.ToString(str1 + " Days " + str2 + " Hours Left");
    }

    private void load_user_data(api.user_data_structure data)
    {
      this.user_data.username = data.username;
      this.user_data.ip = data.ip;
      this.user_data.hwid = data.hwid;
      this.user_data.createdate = data.createdate;
      this.user_data.lastlogin = data.lastlogin;
      this.user_data.subscriptions = data.subscriptions;
    }

    private void load_response_struct(api.response_structure data)
    {
      this.response.success = data.success;
      this.response.message = data.message;
    }

    [DataContract]
    private class response_structure
    {
      [DataMember]
      public bool success { get; set; }

      [DataMember]
      public string sessionid { get; set; }

      [DataMember]
      public string contents { get; set; }

      [DataMember]
      public string response { get; set; }

      [DataMember]
      public string message { get; set; }

      [DataMember]
      public string download { get; set; }

      [DataMember(IsRequired = false, EmitDefaultValue = false)]
      public api.user_data_structure info { get; set; }

      [DataMember(IsRequired = false, EmitDefaultValue = false)]
      public api.app_data_structure appinfo { get; set; }

      [DataMember]
      public List<api.msg> messages { get; set; }

      [DataMember]
      public List<api.users> users { get; set; }
    }

    public class msg
    {
      public string message { get; set; }

      public string author { get; set; }

      public string timestamp { get; set; }
    }

    public class users
    {
      public string credential { get; set; }
    }

    [DataContract]
    private class user_data_structure
    {
      [DataMember]
      public string username { get; set; }

      [DataMember]
      public string ip { get; set; }

      [DataMember]
      public string hwid { get; set; }

      [DataMember]
      public string createdate { get; set; }

      [DataMember]
      public string lastlogin { get; set; }

      [DataMember]
      public List<api.Data> subscriptions { get; set; }
    }

    [DataContract]
    private class app_data_structure
    {
      [DataMember]
      public string numUsers { get; set; }

      [DataMember]
      public string numOnlineUsers { get; set; }

      [DataMember]
      public string numKeys { get; set; }

      [DataMember]
      public string version { get; set; }

      [DataMember]
      public string customerPanelLink { get; set; }

      [DataMember]
      public string downloadLink { get; set; }
    }

    public class app_data_class
    {
      public string numUsers { get; set; }

      public string numOnlineUsers { get; set; }

      public string numKeys { get; set; }

      public string version { get; set; }

      public string customerPanelLink { get; set; }

      public string downloadLink { get; set; }
    }

    public class user_data_class
    {
      public string username { get; set; }

      public string ip { get; set; }

      public string hwid { get; set; }

      public string createdate { get; set; }

      public string lastlogin { get; set; }

      public List<api.Data> subscriptions { get; set; }
    }

    public class Data
    {
      public string subscription { get; set; }

      public string expiry { get; set; }

      public string timeleft { get; set; }
    }

    public class response_class
    {
      public bool success { get; set; }

      public string message { get; set; }
    }
  }
}
