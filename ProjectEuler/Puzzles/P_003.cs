using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_003
    {
        public static void Execute()
        {
            long number = 600851475143;
            List<long> primeFactors = new List<long>();

            for (long i = 2; i <= number; i++)
            {
                if (number == 1)
                {
                    break;
                }

                if (i.IsPrime() && number % i == 0)
                {
                    primeFactors.Add(i);
                    number = number / i;
                    i = 2;
                }
            }

            Console.WriteLine(primeFactors.Max());
        }
    }
}
