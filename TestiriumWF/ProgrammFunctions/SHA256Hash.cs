using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;

namespace TestiriumWF.ProgrammFunctions
{
    internal class SHA256Hash
    {
        public string HashPassword(string login, string password)
        {
            var bytePassword = Encoding.Default.GetBytes(password + login + ConfigurationManager.AppSettings.Get("Salt"));
            var hashedPassword = new SHA256Managed().ComputeHash(bytePassword);
            return Convert.ToBase64String(hashedPassword);
        }
    }
}
