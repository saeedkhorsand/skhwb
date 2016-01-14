using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKHWB.securityTools
{
    public class eofHash
    {
        public static string getHashedPassword(string password, string login)
        {
            string str = login.ToLower() + password;
            // Create Hash Password
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] data = encoding.GetBytes(str);
            System.Security.Cryptography.SHA1 sha = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] bytes = sha.ComputeHash(data);
            char[] c = new char[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                c[i] = (char)(bytes[i] & 0x7f);
            }
            string hs = string.Empty;
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            hs = s.Append(c).ToString();
            return hs;
        }
    }
}
