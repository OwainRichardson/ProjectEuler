using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Puzzles
{
    public static class P_004
    {
        public static void Execute()
        {
            List<int> palindromicNumbers = new List<int>();

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    int product = i * j;

                    if (product.IsPalindrome())
                    {
                        palindromicNumbers.Add(product);
                    }
                }
            }

            Console.WriteLine(palindromicNumbers.Max());
        }

        private static bool IsPalindrome(this int number)
        {
            bool isPalindrome = true;
            string value = number.ToString();

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] != value[value.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
