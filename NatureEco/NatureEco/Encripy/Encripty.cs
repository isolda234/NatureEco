using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace NatureEco.Encripy
{
     class Encripty
    {
        public string Encrypt(string value)
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(value));
            StringBuilder returnval = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                returnval.Append(hashdata[i].ToString());
            }
            return returnval.ToString();

        }
    }
}
