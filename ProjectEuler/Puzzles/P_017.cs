using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_017
    {
        public static void Execute()
        {
            int number = 2;
            int power = 1000;

            BigInteger bigNumber = (BigInteger)Math.Pow(number, power);

            Console.WriteLine(bigNumber.ToString().Sum(x => int.Parse(x.ToString())));
        }
    }
}
