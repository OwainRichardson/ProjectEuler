using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_031
    {
        public static Dictionary<int, int> coins = new Dictionary<int, int>
        {
            { 0, 1 },
            { 1, 2 },
            { 2, 5 },
            { 3, 10 },
            { 4, 20 },
            { 5, 50 },
            { 6, 100 },
            { 7, 200 }
        };


        public static void Execute()
        {

            int target = 200;
            int[] coinSizes = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] ways = new int[target + 1];
            ways[0] = 1;

            for (int i = 0; i < coinSizes.Length; i++)
            {
                for (int j = coinSizes[i]; j <= target; j++)
                {
                    ways[j] += ways[j - coinSizes[i]];
                }
            }

            Console.WriteLine(ways.Last());
            Console.WriteLine();
        }
    }
}
