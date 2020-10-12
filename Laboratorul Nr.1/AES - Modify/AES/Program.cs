using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class ManagedAesSample
{
     public static void Main()
     {
          Console.Write("Input:");
          string data = Console.ReadLine();
          EncryptAesManaged(data);
          Console.ReadLine();
     }
     static void EncryptAesManaged(string raw)
     {
          try
          {
               using (AesManaged aes = new AesManaged())
               {
                    string key = "skmdajwkemdnswer";

                    byte[] privateKey = Encoding.ASCII.GetBytes(key);

                    byte[] encrypted = Encrypt(raw, privateKey, aes.IV);

                    for (int i = 0; i < encrypted.Length; i++)
                    {
                         Console.Write(encrypted[i] + " ");
                    }
                   
                    string decrypted = Decrypt(encrypted, privateKey, aes.IV);
                    Console.WriteLine();
                    Console.WriteLine($"Decrypted data: {decrypted}");
               }
          }
          catch (Exception exp)
          {
               Console.WriteLine(exp.Message);
          }
          Console.ReadKey();
     }
     static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
     {
          byte[] encrypted;
          using (AesManaged aes = new AesManaged())
          {
               ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
              
               using (MemoryStream ms = new MemoryStream())
               {   
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                         using (StreamWriter sw = new StreamWriter(cs))
                              sw.Write(plainText);
                         encrypted = ms.ToArray();
                    }
               }
          }
          return encrypted;
     }
     static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
     {
          string plaintext = null;
         
          using (AesManaged aes = new AesManaged())
          {
               ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
               using (MemoryStream ms = new MemoryStream(cipherText))
               {  
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {    
                         using (StreamReader reader = new StreamReader(cs))
                              plaintext = reader.ReadToEnd();
                    }
               }
          }
          return plaintext;
     }
}