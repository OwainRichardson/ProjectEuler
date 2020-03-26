using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_001
    {
        public static void Execute()
        {
            int total = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine(total);
        }
    }
}
