using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_002
    {
        public static void Execute()
        {
            List<int> fibonacci = new List<int> { 1, 1 };

            int index = 2;
            int nextFib = 0;
            int total = 0;

            while (nextFib <= 4000000)
            {
                nextFib = fibonacci[index - 2] + fibonacci[index - 1];

                if (nextFib % 2 == 0)
                {
                    total += nextFib;
                }

                fibonacci.Add(nextFib);

                index++;
            }

            Console.WriteLine(total);
        }
    }
}
