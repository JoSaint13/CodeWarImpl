using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class BracesClass
    {
        public static bool Braces(string braces)
        {
            if (braces.Length % 2 != 0)
            {
                return false;
            }
            var opposites = new Dictionary<char,char>
            {
                {'(',')' },
                {'{','}' },
                {'[',']' }
            };

            var source = braces.ToList();
            var offset = 1;

            for (var i = 0; i < braces.Count()/2 ; i+=offset)
            {
                if (!opposites.ContainsKey(source[i]))
                {
                    return false;
                }

                var r1 = opposites[source[i]] == source[i + 1];
                if (r1)
                {
                    offset = 2;
                }
                var r2 = opposites[source[i]] == source[(source.Count-1) - i];
                if (!r1 && !r2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
