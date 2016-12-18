using System;

namespace Advent2016
{
    public static class Decompressor_Day9
    {

        public static string Decompress(string input)
        {
            string output = "";
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                char c = input[i];
                if (c == '(') //Started identifier
                {
                    string remaining = input.Substring(i);
                    int xIdentifier = remaining.IndexOf("x");
                    int endIdentifier = remaining.IndexOf(")");
                    string rangeString = remaining.Substring(1, xIdentifier - 1);
                    int range = Int32.Parse(rangeString);
                    string multiplierString = remaining.Substring(xIdentifier + 1, (endIdentifier -1) - xIdentifier);
                    int multiplier = Int32.Parse(multiplierString);
                    string decompressedString = remaining.Substring(endIdentifier + 1, range);
                    for(int x = 0; x < multiplier; x++)
                    {
                        output += decompressedString;
                    }
                    i += endIdentifier + range;
                }
                else
                {
                    output += c; //Add on to output
                }
            }

            return output;
        }

    }
}