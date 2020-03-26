using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_006
    {
        public static void Execute()
        {
            long sumOfSquares = 0;
            long squareOfSums = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += (i * i);
                squareOfSums += i;
            }

            squareOfSums = squareOfSums * squareOfSums;

            Console.WriteLine(squareOfSums - sumOfSquares);
        }
    }
}
