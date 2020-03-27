using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_011
    {
        public static void Execute()
        {
            string[] inputs = File.ReadAllLines("../../../Data/P_011.txt");
            int[,] grid = new int[20, 20];
            long greatestProduct = 0;

            int row = 0;
            int column = 0;

            foreach (string input in inputs)
            {
                string[] split = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                column = 0;

                foreach (string s in split)
                {
                    grid[row, column] = int.Parse(s);
                    column++;
                }

                row++;
            }


            for (row = 0; row < 20; row++)
            {
                for (column = 0; column < 20; column++)
                {
                    if (column + 3 < 20)
                    {
                        int total = grid[row, column]
                                        * grid[row, column + 1]
                                        * grid[row, column + 2]
                                        * grid[row, column + 3];

                        if (total > greatestProduct)
                        {
                            greatestProduct = total;
                        }
                    }

                    if (row + 3 < 20)
                    {
                        int total = grid[row, column]
                                        * grid[row + 1, column]
                                        * grid[row + 2, column]
                                        * grid[row + 3, column];

                        if (total > greatestProduct)
                        {
                            greatestProduct = total;
                        }
                    }

                    if (column + 3 < 20 && row + 3 < 20)
                    {
                        int total = grid[row, column]
                                        * grid[row + 1, column + 1]
                                        * grid[row + 2, column + 2]
                                        * grid[row + 3, column + 3];

                        if (total > greatestProduct)
                        {
                            greatestProduct = total;
                        }
                    }

                    if (column - 3 >= 0 && row + 3 < 20)
                    {
                        int total = grid[row, column]
                                        * grid[row + 1, column - 1]
                                        * grid[row + 2, column - 2]
                                        * grid[row + 3, column - 3];

                        if (total > greatestProduct)
                        {
                            greatestProduct = total;
                        }
                    }
                }
            }

            Console.WriteLine(greatestProduct);
        }
    }
}
