using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Advent2016
{
    public class MD5_BruteForce
    {
        static MD5 md5Hash = MD5.Create();

        public static string GetMd5Hash(string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static List<string> GetMD5HashesThatStartWith(string input, string startsWith, int amount = 1, bool verbose = false)
        {
            string hash = "";
            int i = 0;
            List<string> matchList = new List<string>();
            do
            {
                do
                {
                    hash = GetMd5Hash(input + i.ToString());
                    if (hash.StartsWith(startsWith)) matchList.Add(hash);
                    i++;
                } while (!hash.StartsWith(startsWith));
                if (verbose) Console.WriteLine("Hash found #" + matchList.Count + " , Starting next hash...");
            } while (matchList.Count < amount);

            return matchList;
        }
    }
}