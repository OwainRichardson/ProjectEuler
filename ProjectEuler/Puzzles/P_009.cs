using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_009
    {
        public static void Execute()
        {
            for (int a = 1; a <= 1000; a++)
            {
                for (int b = a + 1; b <= 1000; b++)
                {
                    for (int c = b + 1; c <= 1000; c++)
                    {
                        if (a + b + c == 1000)
                        {
                            if (ProgramExtensions.IsPythagoreanTriple(a, b, c))
                            {
                                Console.WriteLine(a * b * c);
                            }
                        }
                    }
                }
            }
        }
    }
}
