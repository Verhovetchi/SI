using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RSAEncrypt
{
     public partial class Form1 : Form
     {
          UnicodeEncoding ByteConverter = new UnicodeEncoding();
          RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
          byte[] plaintext;
          byte[] encryptedtext;

          public Form1()
          {
               InitializeComponent();
          }

          private void btnEncrypt_Click(object sender, EventArgs e)
          {
               plaintext = ByteConverter.GetBytes(txtPlain.Text);
               encryptedtext = Algorithm.Encryption(plaintext, RSA.ExportParameters(false), false);
               txtEncrypt.Text = ByteConverter.GetString(encryptedtext);
          }

          private void btnDecrypt_Click(object sender, EventArgs e)
          {
               byte[] decryptedtext = Algorithm.Decryption(encryptedtext,
               RSA.ExportParameters(true), false);
               txtDecrypt.Text = ByteConverter.GetString(decryptedtext);
          }
     }
}
