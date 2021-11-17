﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace MVVM_Shop
{
    public class Helper
    {
        public static string HashPassword(string password)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);
            return Convert.ToBase64String(hashedBytes);
        }
    }
}
