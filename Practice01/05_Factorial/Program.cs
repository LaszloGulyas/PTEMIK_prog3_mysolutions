using System;

namespace _05_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                Console.Write("Enter a number to calculate factorial: ");

            } while (!int.TryParse(Console.ReadLine(), out number));

            Console.WriteLine(CalcFactorial(number));
        }

        private static int CalcFactorial(int n)
        {
            int result = 1;
            while (n > 1)
            {
                result *= n--;
            }
            return result;
        }
    }
}
