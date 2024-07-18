using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Artan.BLL
{
    public class CryptoServices
    {
        public static string HashPass_SHA256(string password)
        {
            using (SHA256CryptoServiceProvider sHA256Crypto = new SHA256CryptoServiceProvider())
            {
                password = BitConverter.ToString(sHA256Crypto.ComputeHash(Encoding.UTF8.GetBytes(password.ToLower().Trim())));
            }
            return password;
        }
    }
}
