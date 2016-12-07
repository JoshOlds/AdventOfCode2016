using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2016
{

    public class CommonCharacters
    {
        /// <summaryof >
        /// Returns a string containing the most common characters in the input string, in order of frequency, ties sorted alphabetically.     
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="amount">Amount of characters to be in output string, default is 5</param>
        /// <returns></returns>
        public static string MostCommonCharacters(string input, int amount = 5)
        {
            input = String.Concat(input.OrderBy(c => c));
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char c in input)
            {
                if(dict.ContainsKey(c)) dict[c]++;
                else dict.Add(c, 1);
            }
            var top = dict.OrderByDescending(pair => pair.Value).Take(amount);
            string result = "";
            foreach(KeyValuePair<char, int> pair in top)
            {
                result += pair.Key;
            }
            return result;
        }

        public static string LeastCommonCharacters(string input, int amount = 5)
        {
            input = String.Concat(input.OrderBy(c => c));
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char c in input)
            {
                if(dict.ContainsKey(c)) dict[c]++;
                else dict.Add(c, 1);
            }
            var top = dict.OrderByDescending(pair => (0 - pair.Value)).Take(amount);
            string result = "";
            foreach(KeyValuePair<char, int> pair in top)
            {
                result += pair.Key;
            }
            return result;
        }

    }
}