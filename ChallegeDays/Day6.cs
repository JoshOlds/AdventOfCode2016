using System;
using System.Collections.Generic;

namespace Advent2016
{
    public class Day6 : IExecutable
    {
        public void Execute()
        {

            Console.WriteLine("Advent of Code 2016 - Day 6");
            string[] inputArr = null;
            try //Try to read the text file
            {
                inputArr = System.IO.File.ReadAllLines(@"./data/Day6.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            inputArr = InputManipulator.RowsToColumns(inputArr);

            Console.WriteLine("The decoded message is: " + stringBuilder(inputArr));
            Console.WriteLine("The modified decoded message is: " + modifiedStringBuilder(inputArr));


        }

        public string stringBuilder(string[] sArr)
        {
            string output = "";
            foreach(string s in sArr)
            {
                output += CommonCharacters.MostCommonCharacters(s, 1);
            }
            return output;
        }
        public string modifiedStringBuilder(string[] sArr)
        {
            string output = "";
            foreach(string s in sArr)
            {
                output += CommonCharacters.LeastCommonCharacters(s, 1);
            }
            return output;
        }
    }
}