using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_010
    {
        public static void Execute()
        {
            long total = 2;

            for (long i = 3; i < 2000000; i = i + 2)
            {
                if (i % 1000 == 0)
                {
                    Console.Write($"\r{i}");
                }

                if (i.IsPrime())
                {
                    total += i;
                }
            }

            Console.WriteLine(total);
        }
    }
}
