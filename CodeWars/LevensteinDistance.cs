using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class LevensteinDistance
    {
        private IEnumerable<string> _words;

        public LevensteinDistance(IEnumerable<string> words)
        {
            _words = words;
        }

        public string FindMostSimilar(string term)
        {
            var val = 10000;
            var result = "";
            foreach (var word in _words)
            {
                var n = term.Length;
                var m = word.Length;
                var d = new int[n + 1, m + 1];

                // Step 2
                for (int i = 0; i <= n; d[i, 0] = i++)
                {
                }

                for (int j = 0; j <= m; d[0, j] = j++)
                {
                }

                // Step 3
                for (int i = 1; i <= n; i++)
                {
                    //Step 4
                    for (int j = 1; j <= m; j++)
                    {
                        // Step 5
                        int cost = (word[j - 1] == term[i - 1]) ? 0 : 1;

                        // Step 6
                        d[i, j] = Math.Min(
                            Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                            d[i - 1, j - 1] + cost);
                    }
                }
                
                var length = d[n, m];
                if (length < val)
                {
                    result = word;
                    val = length;
                }
               
            }

            return result;

        }
    }
}