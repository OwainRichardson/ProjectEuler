using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_005
    {
        public static void Execute()
        {
            int number = 10;
            bool allDivide = false;

            while (!allDivide)
            {
                allDivide = true;

                for (int i = 1; i <= 20; i++)
                {
                    if (number % i != 0)
                    {
                        allDivide = false;
                        number++;
                        break;
                    }
                }
            }

            Console.WriteLine(number);
        }
    }
}
