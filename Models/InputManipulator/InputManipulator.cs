using System;
using System.Collections.Generic;

namespace Advent2016
{
    public class InputManipulator
    {
        /// <summary>
        /// Takes an array of strings (rows), and returns and array of strings (columns)
        /// </summary>
        /// <param name="input">string array input</param>
        /// <returns></returns>
        public static string[] RowsToColumns(string[] input)
        {
            int size = input.Length; //Length of input array
            int width = input[0].Length; //Length of first string in input
            string[] output = new string[width];
            for(int i = 0; i < width; i++)
            { // Fill output with empty strings
                output[i] = "";
            }
            for(int i = 0; i < width; i++)
            {
                for(int x = 0; x < size; x++)
                {
                    output[i] += input[x][i]; 
                }
            }
            return output;
        }

        /// <summary>
        /// Returns a list of strings that were contained inside square brackets, in the original input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<string> InsideSquareBrackets(string input)
        {
            List<string> output = new List<string>();
            string tempString = "";
            bool bracketFlag = false;
            for(int i = 0; i < input.Length; i++)
            {
                if(bracketFlag == false && input[i] == '[')
                {//Hit start of bracket
                    tempString = "";
                    bracketFlag = true;
                }
                else if(bracketFlag == true && input[i] == ']')
                {//Hit end of bracket
                    output.Add(tempString);
                    tempString = "";
                    bracketFlag = false;
                }
                else //standard character
                {
                    tempString += input[i];
                }
            }
            return output;
        }

        public static List<string> OutsideSquareBrackets(string input)
        {
            List<string> output = new List<string>();
            string tempString = "";
            bool bracketFlag = false;
            for(int i = 0; i < input.Length; i++)
            {
                if(bracketFlag == false && input[i] == '[')
                {//Hit start of bracket
                    output.Add(tempString);
                    tempString = "";
                    bracketFlag = true;
                }
                else if(bracketFlag == true && input[i] == ']')
                {//Hit end of bracket
                    tempString = "";
                    bracketFlag = false;
                }
                else //standard character
                {
                    tempString += input[i];
                }
            }
            output.Add(tempString);
            return output;
        }

    }
}