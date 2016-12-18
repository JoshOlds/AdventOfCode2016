using System;

namespace Advent2016
{
    public class Day9 : IExecutable
    {
        public void Execute()
        {

            Console.WriteLine("Advent of Code 2016 - Day 9");
            
            string[] inputArr = null;
            try //Try to read the text file
            {
                inputArr = System.IO.File.ReadAllLines(@"./data/Day9.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            string[] outputArr = new string[inputArr.Length];
            for(int i = 0; i < inputArr.Length; i++)
            {
                string output = Decompressor_Day9.Decompress(InputManipulator.RemoveAllWhiteSpace(inputArr[i]));
                outputArr[i] = output;
            }

            int count = 0;
            foreach(string s in outputArr)
            {
                count += s.Length;
            }

            Console.WriteLine("Length of Decompressed message: " + count);
            
        }

        
    }
}