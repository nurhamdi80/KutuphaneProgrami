using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProgrami.Data.HelperClass
{
    public static class Sifreleme
    {
        public static string MD5(this string parola) 
        {
            MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider();

            byte[] dizi = md5.ComputeHash(Encoding.UTF8.GetBytes(parola));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dizi.Length; i++) 
            {
                sb.Append(dizi[i].ToString("x2"));
            }

            return sb.ToString();
        }
        public static string SHA_1(this string parola) 
        {
            SHA1 sha1Hasher = SHA1.Create();
            byte[] dizi = sha1Hasher.ComputeHash(Encoding.Default.GetBytes(parola));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dizi.Length; i++)
            {
                sb.Append(dizi[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string Sifrele(this string parola) 
        {
            parola = parola.SHA_1();
            parola = parola.MD5();
            parola = parola.SHA_1();
            parola = parola.MD5();
            return parola;
        }
        public static string YeniSifreOlustur(int karakterSayisi) 
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random=new Random();    
            var result=new String(
                Enumerable.Repeat(chars,karakterSayisi)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray() );
            return result;
        }
    }
}
