/* Вывести все нечётные и кратные трём числа из диапазона [a; b] */

namespace Console_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Must be a valid integer number";

            try
            {
                Console.Write($"Enter a ({msg}): ");
                int a = int.Parse(Console.ReadLine());

                Console.Write($"Enter b ({msg}): ");
                int b = int.Parse(Console.ReadLine());

                if (a > b) (a, b) = (b, a);

                int val = a;

                while (val <= b)
                {
                    if (val % 2 != 0) Console.WriteLine("Odd: " + val);
                    if (val % 3 == 0) Console.WriteLine("Multiple of 3: " + val);
                    val++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
