using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_012
    {
        public static void Execute()
        {
            int triangleNumber = 0;
            int difference = 1;
            int numberOfFactors = 0;

            while (numberOfFactors < 500)
            {
                triangleNumber += difference;
                difference++;

                numberOfFactors = CountFactors(triangleNumber);                
            }

            Console.WriteLine(triangleNumber);
        }

        private static int CountFactors(int triangleNumber)
        {
            int numberOfFactors = 0;

            for (int i = 1; i <= triangleNumber / 2; i++)
            {
                if (triangleNumber % i == 0)
                {
                    numberOfFactors++;
                }
            }

            return numberOfFactors;
        }
    }
}
