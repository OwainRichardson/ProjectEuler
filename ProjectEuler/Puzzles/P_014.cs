using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_014
    {
        public static void Execute()
        {
            long longestChain = 0;
            long highestStartingNumber = 0;

            for (long number = 1; number <= 999999; number++)
            {
                Console.Write($"\r{number}");

                long chain = 1;
                long iterationNumber = number;

                while (iterationNumber != 1)
                {
                    if (iterationNumber % 2 == 0)
                    {
                        iterationNumber = iterationNumber / 2;
                    }
                    else
                    {
                        iterationNumber = (iterationNumber * 3) + 1;
                    }

                    chain++;
                }

                if (chain > longestChain)
                {
                    longestChain = chain;
                    highestStartingNumber = number;
                }
            }

            Console.Write($"\r{highestStartingNumber}        ");
            Console.WriteLine();
        }
    }
}
