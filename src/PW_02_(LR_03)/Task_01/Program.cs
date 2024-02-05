/* Написать программу, вычисляющую значение функции у:
 * – если х < -5, то у(х) = а*х2;
 * – если -5 ≤ х < 1, то у(х) = а*|х|;
 * – если х ≥ 1, то у(х) = 1/(а-х).
 *
 * Числа а и х вводятся пользователем.
 * Результат округлять до трех знаков после запятой.
 */

namespace Task_01
{
    internal class Program
    {
        static double? f (double a, double x)
        {
            if (x < -5)
            {
                return a * Math.Pow(x, 2);
            }
            else if (x < 1 && x >= -5)
            {
                return a * Math.Abs(x);
            }
            else if (a != x)
            {
                return 1 / (a - x);
            }
            return null;
        }
        static void Main(string[] args)
        {
            try
            {
                // User input
                Console.Write("Enter param a (must be a valid real number): ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter variable x (must be a valid real number): ");
                double x = Convert.ToDouble(Console.ReadLine());

                // Calculation
                double? y = f(a, x);

                // Output
                if (y != null)
                {
                    Console.WriteLine("y = " + y?.ToString("N3"));
                }
                else
                {
                    Console.WriteLine("No solution: division by zero, quotient is undefined");
                }
            }
            catch (Exception)
            {
                // Handle invalid decimal separator
                string decimalSeparator = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                Console.WriteLine("Incorrect input: use decimal separator according to your system current culture settings ({0})", decimalSeparator);
            }
        }
    }
}
