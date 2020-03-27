using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_013
    {
        public static void Execute()
        {
            string[] inputs = File.ReadAllLines("../../../Data/P_013.txt");

            BigInteger total = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                total += BigInteger.Parse(inputs[i]);
            }

            Console.WriteLine(total.ToString().Substring(0, 10));
        }
    }
}
