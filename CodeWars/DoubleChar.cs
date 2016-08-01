using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class DoubleChar
    {
        public static string MakeDouble(string s)
        {
            var result = new List<char>(s.Length*2);
            s.ToList().ForEach(x => result.AddRange(new[] {x, x}));
            return new string(result.ToArray());
        }
    }
}