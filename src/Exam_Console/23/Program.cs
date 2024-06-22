/* Проверить, принадлежит ли число, введенное с клавиатуры, интервалу (к, х),
 * где к, х – вводятся с клавиатуры.
 */

namespace Console_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number k: ");
                double k = double.Parse(Console.ReadLine());

                Console.Write("Enter number x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Enter number n: ");
                double n = double.Parse(Console.ReadLine());

                if (k > x) (k, x) = (x, k);

                Console.WriteLine($"Number {n} {(n > k && n < x ? "belongs" : "doesn't")} to ({k}, {x}).");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
