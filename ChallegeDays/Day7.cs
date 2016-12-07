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
            int goodCount = 0;

            try //Try to read the text file
            {
                inputArr = System.IO.File.ReadAllLines(@"./data/Day7.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            foreach(string s in inputArr)
            {
                List<string> inside = InputManipulator.InsideSquareBrackets(s);
                List<string> outside = InputManipulator.OutsideSquareBrackets(s);
                bool insideABBA = false;
                bool outsideABBA = false;
                foreach(string x in inside) //Check for ABBA inside brackets
                {
                    if(ABBA.ABBACheck(x)) insideABBA = true;
                }
                foreach(string x in outside) //Check for ABBA outside brackets
                {
                    if(ABBA.ABBACheck(x)) outsideABBA = true;
                }
                if(!insideABBA && outsideABBA) goodCount++;
            }

            Console.WriteLine("The good IP count (ABBA) is: " + goodCount);


            //Part 2
            int abaCount = 0;
            foreach(string s in inputArr)
            {
                List<string> inside = InputManipulator.InsideSquareBrackets(s);
                List<string> outside = InputManipulator.OutsideSquareBrackets(s);
                bool found = false;

                foreach(string x in outside) //Check for ABBA outside brackets
                {
                    if(ABBA.ABACheck(x))
                    {
                        List<string> abaList = ABBA.GetABAs(x);
                        
                        foreach(string aba in abaList)
                        {
                            foreach(string insideString in inside)
                            {
                                string bab = ABBA.GenerateBAB(aba);
                                if (insideString.Contains(bab)) found = true;
                            }
                        }
                    } 
                }
                if(found) abaCount++;
            }

            Console.WriteLine("The good IP count (ABA) is: " + abaCount);

            



        }

        
    }
}