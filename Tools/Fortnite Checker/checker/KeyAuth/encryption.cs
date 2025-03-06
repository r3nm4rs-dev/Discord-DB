// Decompiled with JetBrains decompiler
// Type: KeyAuth.encryption
// Assembly: NexusFN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 95EF2A8C-0A82-4169-A602-5A6F579F3441
// Assembly location: C:\Users\Renaud\Downloads\Nexus Fortnite Checker\checker.exe

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

#nullable disable
namespace KeyAuth
{
  public static class encryption
  {
    public static string byte_arr_to_str(byte[] ba)
    {
      StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
      foreach (byte num in ba)
        stringBuilder.AppendFormat("{0:x2}", (object) num);
      return stringBuilder.ToString();
    }

    public static byte[] str_to_byte_arr(string hex)
    {
      try
      {
        int length = hex.Length;
        byte[] byteArr = new byte[length / 2];
        for (int startIndex = 0; startIndex < length; startIndex += 2)
          byteArr[startIndex / 2] = Convert.ToByte(hex.Substring(startIndex, 2), 16);
        return byteArr;
      }
      catch
      {
        Console.WriteLine("\n\n  The session has ended, open program again.");
        Thread.Sleep(3500);
        Environment.Exit(0);
        return (byte[]) null;
      }
    }

    public static string encrypt_string(string plain_text, byte[] key, byte[] iv)
    {
      Aes aes = Aes.Create();
      aes.Mode = CipherMode.CBC;
      aes.Key = key;
      aes.IV = iv;
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (ICryptoTransform encryptor = aes.CreateEncryptor())
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
          {
            byte[] bytes = Encoding.Default.GetBytes(plain_text);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            return encryption.byte_arr_to_str(memoryStream.ToArray());
          }
        }
      }
    }

    public static string decrypt_string(string cipher_text, byte[] key, byte[] iv)
    {
      Aes aes = Aes.Create();
      aes.Mode = CipherMode.CBC;
      aes.Key = key;
      aes.IV = iv;
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (ICryptoTransform decryptor = aes.CreateDecryptor())
        {
          using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Write))
          {
            byte[] byteArr = encryption.str_to_byte_arr(cipher_text);
            cryptoStream.Write(byteArr, 0, byteArr.Length);
            cryptoStream.FlushFinalBlock();
            byte[] array = memoryStream.ToArray();
            return Encoding.Default.GetString(array, 0, array.Length);
          }
        }
      }
    }

    public static string iv_key()
    {
      Guid guid = Guid.NewGuid();
      string str = guid.ToString();
      guid = Guid.NewGuid();
      int length = guid.ToString().IndexOf("-", StringComparison.Ordinal);
      return str.Substring(0, length);
    }

    public static string sha256(string r)
    {
      return encryption.byte_arr_to_str(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(r)));
    }

    public static string encrypt(string message, string enc_key, string iv)
    {
      byte[] bytes1 = Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(0, 32));
      byte[] bytes2 = Encoding.Default.GetBytes(encryption.sha256(iv).Substring(0, 16));
      return encryption.encrypt_string(message, bytes1, bytes2);
    }

    public static string decrypt(string message, string enc_key, string iv)
    {
      byte[] bytes1 = Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(0, 32));
      byte[] bytes2 = Encoding.Default.GetBytes(encryption.sha256(iv).Substring(0, 16));
      return encryption.decrypt_string(message, bytes1, bytes2);
    }
  }
}
