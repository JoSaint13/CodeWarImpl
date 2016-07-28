using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class TwiceLinear
    {
        public static int DblLinear(int n)
        {
            var p1 = 0;
            var p2 = 0;
            Func<int,int> genX = x => 2 * x + 1; 
            Func<int,int> genY = x => 3 * x + 1; 

            var seq = new List<int>() {1};

            for (var i = 0; i < n; i++)
            {
                var v1 = genX(seq[p1]);
                var v2 = genY(seq[p2]);

                if (v1 < v2)
                {
                    seq.Add(v1);
                    p1++;
                }
                else if (v2 < v1)
                {
                    seq.Add(v2);
                    p2++;
                }
                else
                {
                    p1++;
                    i--;
                }

            }


            return seq[n];

        }
    }
}
