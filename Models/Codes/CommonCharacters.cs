using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent2016
{

    public class CommonCharacters
    {

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

    }
}