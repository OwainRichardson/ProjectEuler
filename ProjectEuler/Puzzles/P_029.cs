using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_029
    {
        public static void Execute()
        {
            int start = 2;
            int end = 100;
            List<BigInteger> terms = new List<BigInteger>();

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    BigInteger value = (BigInteger)Math.Pow(a, b);

                    if (!terms.Contains(value))
                    {
                        terms.Add(value);
                    }
                }
            }

            Console.WriteLine(terms.Distinct().Count());
            Console.WriteLine();
        }
    }
}
