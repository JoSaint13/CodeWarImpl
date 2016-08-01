using System;
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
    }
}
