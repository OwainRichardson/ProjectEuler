using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_007
    {
        public static void Execute()
        {
            List<long> primes = new List<long>();
            int index = 10001;

            long i = 2;
            while (primes.Count < index)
            {
                if (i.IsPrime())
                {
                    primes.Add(i);
                }

                i++;
            }

            Console.WriteLine(primes[index - 1]);
        }
    }
}
