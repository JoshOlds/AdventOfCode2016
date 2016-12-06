using System;
using System.Collections.Generic;

namespace Advent2016
{

    public class Day3 : IExecutable
    {

        public void Execute()
        {
            Console.WriteLine("Advent of Code 2016 - Day 3");
            string[] inputArr = null;
            List<int> columnList = new List<int>();
            int possible = 0;
            int possibleColumns = 0;

            try //Try to read the text file
            {
                inputArr = System.IO.File.ReadAllLines(@"./data/Day3.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            foreach (string line in inputArr) //Loop for first half of challenge (by rows)
            {
                string a = line.Substring(0, 5);
                string b = line.Substring(5, 5);
                string c = line.Substring(10, 5);
                int aNum = Int32.Parse(a);
                int bNum = Int32.Parse(b);
                int cNum = Int32.Parse(c);
                if (Triangle.isRealTriangle(aNum, bNum, cNum)) possible++;
            }

            Console.WriteLine("There are " + possible + " possible triangles (By Rows).");


            for (int x = 0; x < 3; x++) //loop to grab data as numbers (for columns)
            {
                foreach (string line in inputArr)
                {
                    string a = line.Substring(0, 5);
                    string b = line.Substring(5, 5);
                    string c = line.Substring(10, 5);
                    int aNum = Int32.Parse(a);
                    int bNum = Int32.Parse(b);
                    int cNum = Int32.Parse(c);
                    if (x == 0) columnList.Add(aNum);
                    if (x == 1) columnList.Add(bNum);
                    if (x == 2) columnList.Add(cNum);
                }
            }

            for(int i = 0; i < columnList.Count; i += 3)
            {
                if(Triangle.isRealTriangle(columnList[i], columnList[i+1], columnList[i+2] )) possibleColumns++;  
            }

            Console.WriteLine("There are " + possibleColumns + " possible triangles (By columns).");


        }

    }

}

