using System;
using System.Collections.Generic;

namespace Advent2016
{
    public class Day7 : IExecutable
    {
        public void Execute()
        {

            Console.WriteLine("Advent of Code 2016 - Day 7");
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



        }

        
    }
}