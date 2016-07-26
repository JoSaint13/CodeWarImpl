using System.Linq;

namespace CodeWars
{
    public static class CountTheMonkeys
    {
        public static int[] MonkeyCount(int n)
        {
            var res = new int[n];

            for (var i = 1; i < n+1; i++)
            {
                res[i - 1] = i;
            }

            return res;
        }

        public static int[] MonkeyCount2(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }

    }
}
