using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_030
    {
        public static void Execute()
        {
            int start = 2;
            int end = 999999;
            List<int> successfullCases = new List<int>();

            for (int val = start; val <= end; val++)
            {
                long total = 0;
                string textNumber = val.ToString();

                for (int index = 0; index < textNumber.Length; index++)
                {
                    total += (long)Math.Pow(int.Parse(textNumber[index].ToString()), 5);

                    if (total > val)
                    {
                        break;
                    }
                }

                if (total == val)
                {
                    successfullCases.Add(val);
                }
            }

            Console.Write(successfullCases.Sum());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
