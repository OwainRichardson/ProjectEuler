using System;

namespace ProjectEuler
{
    public static class ProgramExtensions
    {
        public static string ToThreeFigures(this int number)
        {
            string puzzleNumber = number.ToString();

            while (puzzleNumber.Length < 3)
            {
                puzzleNumber = $"0{puzzleNumber}";
            }

            return puzzleNumber;
        }

        public static bool IsPrime(this long number)
        {
            bool isPrime = true;

            if (number == 1)
            {
                isPrime = false;
            }
            if (number == 2)
            {
                isPrime = true;
            }

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }

        public static bool IsPythagoreanTriple(int a, int b, int c)
        {
            return (Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2);
        }
    }
}
