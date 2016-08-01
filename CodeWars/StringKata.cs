using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class StringKata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            var res = s.GroupBy(x => x.ToString(), x=>x, StringComparer.OrdinalIgnoreCase).FirstOrDefault(g => g.Count() == 1);
            return res == null ? "" : res.Key;
        }

        public static string VowelShifting(string text, int n)
        {
            if (string.IsNullOrEmpty(text) || n == 0)
            {
                return text;
            }

            var vowels  = new List<char>{ 'a','e','i','o','u' };
            var dict = new Dictionary<int, char>();

            var source = text.ToArray();

            for (var i = 0; i < source.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                   dict.Add(i, text[i]);
                }
            }

            var keys = dict.Keys.ToArray();
            var elementIndex = 0;
            foreach (var key in dict.Keys)
            {
                var index = elementIndex;

                for (var j = 0; j < n; j++)
                {
                    if (++index > keys.Length-1)
                    {
                        index = 0;
                    }
                }

                var targetIndex = keys[index];
                source[targetIndex] = dict[key];
                elementIndex ++;
            }

            return new string(source);
        }
    }
}
