using System;
using System.Collections.Generic;

namespace Advent2016
{
    public class ABBA
    {

        public static bool ABBACheck(string input)
        {
            bool abba = false;
            for(int i = 0; i < input.Length - 3; i++)
            {
                char first = input[i];
                char second = input[i+1];
                char third = input[i+2];
                char fourth = input[i+3];
                if(first == fourth && second == third && first != second) abba = true;
            }
            return abba;
        }

        public static bool ABACheck(string input)
        {
            bool aba = false;
            for(int i = 0; i < input.Length - 2; i++)
            {
                char first = input[i];
                char second = input[i+1];
                char third = input[i+2];
                if(first == third && second != first) aba = true;
            }
            return aba;
        }

        public static List<string> GetABAs(string input)
        {
            List<string> abaList = new List<string>();
            string aba = "";
            for(int i = 0; i < input.Length - 2; i++)
            {
                char first = input[i];
                char second = input[i+1];
                char third = input[i+2];
                if(first == third && second != first)
                {
                    aba = (first.ToString() + second.ToString() + third.ToString());
                    abaList.Add(aba);
                } 
            }
            return abaList;
        }

        public static string GenerateBAB(string input)
        {
            if(input.Length != 3)
            {
                throw new Exception("Input string must be 3 characters");
            }
            string output = "";
            output += input[1].ToString();
            output += input[0].ToString();
            output += input[1].ToString();
            return output;
        }
    }
}