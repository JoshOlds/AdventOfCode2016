using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2016
{

    public class ShiftCipher
    {

        public static string applyCaseInsensitiveCipher(string input, int shiftAmount)
        {
            shiftAmount = shiftAmount % 26;
            List<int> charCodes = new List<int>();
            List<int> shiftedCodes = new List<int>();
            string output = "";
            foreach(char c in input)
            {
                charCodes.Add(Convert.ToInt32(c));
            }
            foreach(int code in charCodes)
            {
                int newCode = code + shiftAmount;
                if(newCode > 122) newCode -= 26;
                shiftedCodes.Add(newCode);
            }
            foreach(int code in shiftedCodes)
            {
                char c = Convert.ToChar(code);
                output += c;
            }
            return output;
        }
    }
}