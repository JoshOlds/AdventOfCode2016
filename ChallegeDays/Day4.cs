using System;
using System.Collections.Generic;

namespace Advent2016
{
    public class Day4 : IExecutable
    {
        public void Execute()
        {

            Console.WriteLine("Advent of Code 2016 - Day 4");
            string[] inputArr = null;

            try //Try to read the text file
            {
                inputArr = System.IO.File.ReadAllLines(@"./data/Day4.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            foreach(string line in inputArr)
            {
                string checksum = GetChecksum(line);
                
            }

        }

        public string GetChecksum(string input)
        {
            int start = input.LastIndexOf('-');
            int length = input.IndexOf('[') - start;
            return input.Substring(start, length);
        }
    }
}