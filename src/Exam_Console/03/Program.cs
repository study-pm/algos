﻿/* Вывести таблицу степеней числа два от нулевой до n, где n вводится  пользователем */

namespace Console_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // By default, the console uses the 850 code page or the 437 code page, which don't support that character.
            // It's trying to display the "infinity" symbol (∞),
            // but on your system it appears to just display ? to show that it's not a supported character.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // https://stackoverflow.com/questions/73218845/why-do-i-get-question-mark-in-console-instead-of-a-double-value-nan-and-what-d
            try
            {
                Console.Write("Enter an integer number: ");
                int n = int.Parse(Console.ReadLine());

                int baseNumber = 2;

                double[] degrees = new double[n + 1];

                for (int i = 0; i < degrees.Length; i++)
                {
                    degrees[i] = Math.Pow(baseNumber, i);
                    Console.WriteLine($"{baseNumber}^{i} \t {degrees[i]:N0}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }

        }
    }
}
