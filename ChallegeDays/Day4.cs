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
            List<string> dectryptedStrings = new List<string>();
            List<int> idList = new List<int>();
            int total = 0;

            try //Try to read the text file
            {
                inputArr = System.IO.File.ReadAllLines(@"./data/Day4.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            foreach (string line in inputArr)
            {
                string checksum = GetChecksum(line);
                int sectorId = GetSectorId(line);
                string data = GetData(line);
                string commonChars = CommonCharacters.MostCommonCharacters(data, 5);
                if (commonChars == checksum)
                {
                    total += sectorId;
                    string shiftedString = ShiftCipher.applyCaseInsensitiveCipher(data, sectorId);
                    dectryptedStrings.Add(shiftedString);
                    idList.Add(sectorId);
                }
            }

            foreach (string s in dectryptedStrings)
            {
                if (s.Contains("north")) 
                {
                    Console.WriteLine(s);
                    Console.WriteLine("The North Pole Storage is at sector ID: " + idList[dectryptedStrings.IndexOf(s)]);
                }
            }

            Console.WriteLine("The total of all matching sector IDs is: " + total);

        }

        public string GetChecksum(string input)
        {
            int start = input.LastIndexOf('[') + 1;
            int length = input.LastIndexOf(']') - start;
            return input.Substring(start, length);
        }

        public int GetSectorId(string input)
        {
            int start = input.LastIndexOf('-') + 1;
            int length = input.IndexOf('[') - start;
            string id = input.Substring(start, length);
            return Int32.Parse(id);
        }

        public string GetData(string input)
        {
            int start = 0;
            int length = input.LastIndexOf('-');
            string output = input.Substring(start, length);
            output = output.Replace("-", "");
            return output;
        }
    }
}