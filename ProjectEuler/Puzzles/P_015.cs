using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_015
    {
        public static void Execute()
        {
            int columns = 20;
            int rows = 20;

            Dictionary<string, long> values = new Dictionary<string, long>();

            for (int column = 0; column <= columns; column++)
            {
                for (int row = 0; row <= rows; row++)
                {
                    if (row == 0 && column == 0)
                    {
                        values.Add($"{row}-{column}", 0);
                    }
                    else if (row == 0 || column == 0)
                    {
                        values.Add($"{row}-{column}", 1);
                    }
                    else
                    {
                        values.Add($"{row}-{column}", values[$"{row - 1}-{column}"] + values[$"{row}-{column - 1}"]);
                    }
                }
            }

            Console.WriteLine(values.Last().Value);
        }
    }
}
