using ProjectEuler.Puzzles;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> puzzles = new List<int> { 14 };

            foreach (int p in puzzles)
            {
                Console.WriteLine($"Puzzle {p}");

                Type t = Type.GetType($"ProjectEuler.Puzzles.P_{p.ToThreeFigures()}");
                MethodInfo method = t.GetMethod("Execute", BindingFlags.Static | BindingFlags.Public);

                method.Invoke(null, null);
            }

            Console.WriteLine();
        }
    }
}
