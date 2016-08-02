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

            var vowels  = new List<char>{ 'a','e','i','o','u','A','E','I','O','U' };
            var dict = new Dictionary<int, char>();

            var source = text.ToArray();

            for (var i = 0; i < source.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                   dict.Add(i, text[i]);
                }
            }

            var keys = n > 0 ? dict.Keys.ToArray() : dict.Keys.Reverse().ToArray();
            n = n < 0 ? n*-1 : n; 
            var elementIndex = 0;
            foreach (var key in keys)
            {
                var index = elementIndex;
                for (var j = 0; j < n; j++)
                {
                    if (++index > keys.Length - 1)
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

        public static string VowelShifting2(string text, int n)
        {
            var vowels = "aeiouAEIOU";
            var vowelPositions = text.Select((c, i) => new { c, pos = i }).Where(c => vowels.Contains(c.c)).ToList();
            var shiftedVowels = new Dictionary<int, char>();
            for (int i = 0; i < vowelPositions.Count; i++)
            {
                var shifted_i = i + n;
                shifted_i %= vowelPositions.Count;
                if (shifted_i < 0)
                {
                    shifted_i += vowelPositions.Count;
                }

                shiftedVowels.Add(vowelPositions[shifted_i].pos, vowelPositions[i].c);
            }

            return string.Concat(text.Select((c, i) => vowels.Contains(c) ? shiftedVowels[i] : c));

        }

        public static string VowelShifting3(string text, int n)
        {
            if (string.IsNullOrEmpty(text) || n == 0)
            {
                return text;
            }

            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var dict = new Dictionary<int, char>();

            var source = text.ToArray();

            for (var i = 0; i < source.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    dict.Add(i, text[i]);
                }
            }
            var inexes = dict.Keys.ToList();
            for (var i = 0; i < inexes.Count; i++)
            {
                var shiftedIndex = (i + n) % inexes.Count;
                
                if (shiftedIndex < 0)
                {
                    shiftedIndex += inexes.Count;
                }

                source[inexes[shiftedIndex]] = dict[inexes[i]];
            }

            return new string(source);
        }

    }
}

