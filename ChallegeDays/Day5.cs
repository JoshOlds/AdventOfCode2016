using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Advent2016
{
    public class Day5 : IExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Advent of Code Challenge 2016 - Day 5");
            string input = "reyedfim";
            string code = "";
            Stopwatch sw = new Stopwatch();


            sw.Start();
            List<string> foundHash = MD5_BruteForce.GetMD5HashesThatStartWith(input, "00000", 8, true);
            sw.Stop();
            foreach (string s in foundHash)
            {
                Console.WriteLine(s);
                code += s[5];
            }
            Console.WriteLine("Code is: " + code);
            Console.WriteLine("This process took: " + sw.Elapsed);
            Console.WriteLine("Starting second hashing session...");
            
            sw.Reset();
            sw.Start();
            string[] computedCode = computeCode(input, "00000", 8);
            sw.Stop();
            foreach (string c in computedCode)
            {
                Console.Write(c);
            }
            Console.WriteLine("\nThis process took: " + sw.Elapsed);

        }

        public string[] computeCode(string input, string startsWith, int amount)
        {
            string hash = "";
            int i = 0;
            MD5 md5Hash = MD5.Create();
            string[] computedCode = new string[8];
            int count = 0;
            do
            {
                do
                {
                    hash = MD5_BruteForce.GetMd5Hash(input + i.ToString());
                    int x = 9;
                    if (Int32.TryParse(hash[5].ToString(), out x))

                        if (hash.StartsWith(startsWith) && x < 8)
                        {
                            int index = Int32.Parse(hash[5].ToString());
                            string value = hash[6].ToString();
                            if (computedCode[index] == null)
                            {
                                computedCode[index] = value;
                                count++;
                            }
                        }
                    i++;
                } while (!hash.StartsWith(startsWith));
                Console.WriteLine("Hash found #" + count + " , Starting next hash...");
            } while (count < amount);

            return computedCode;
        }
    }
}