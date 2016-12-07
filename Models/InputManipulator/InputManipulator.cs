using System;

namespace Advent2016
{
    public class InputManipulator
    {

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

    }
}