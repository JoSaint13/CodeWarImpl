using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public  class StringsMix
    {
        static IDictionary<char, Tuple<int, char, string>> dictionary = new Dictionary<char, Tuple<int, char, string>>();
       

        public static string Mix(string s1, string s2)
        {
            var sb = new StringBuilder();
            var all = string.Concat(s1, s2).Where(x => !char.IsUpper(x) && !char.IsWhiteSpace(x));
            foreach (var s in all)
            {
                var c1 = s1.Count(x => x.Equals(s));
                var c2 = s2.Count(x => x.Equals(s));
                
                var count = c1 >= c2 ? c1 : c2;
                if (count <= 1)
                {
                    continue;
                }

                var str = string.Format("{0}:{1}/", c1 > c2 ? "1" : c1 < c2 ? "2" : "=", new string(s, count));

                if (!dictionary.ContainsKey(s))
                {
                    dictionary.Add(s, new Tuple<int, char, string>(count, s, str));
                }
            }

            var groups = dictionary.Where(z => z.Value.Item1 > 1).GroupBy(x => x.Value.Item1).OrderByDescending(x => x.Key);

            foreach (var group in groups)
            {
                var g = group.OrderBy(x => x.Value.Item3[0]);
                foreach (var item in g)
                {
                    sb.Append(item.Value.Item3);
                }

             

            }

            return sb.ToString().Remove(sb.Length-1,1);
        }

    

      
    }
}
