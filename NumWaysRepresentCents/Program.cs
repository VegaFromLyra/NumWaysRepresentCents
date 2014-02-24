using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumWaysRepresentCents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12;

            Console.WriteLine("Number of ways to make {0} cents is {1}", n, GetWays(n));
        }

        static int GetWays(int n)
        {
            int denom = 25;

            return GetWays(n, denom);
        }

        static int GetWays(int n, int denom)
        {
            int nextDenom = 0;

            switch (denom)
            {
                case 25:
                    nextDenom = 10;
                    break;

                case 10:
                    nextDenom = 5;
                    break;

                case 5:
                    nextDenom = 1;
                    break;

                case 1:
                    return 1;
            }

            int ways = 0;

            for (int i = 0; i * denom <= n; i++)
            {
                ways += GetWays(n - (i * denom), nextDenom);
            }

            return ways;
        }
    }
}
