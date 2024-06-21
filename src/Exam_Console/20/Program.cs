/* Вывести все чётные и кратные четырём числа из диапазона [a; b]. */

namespace Console_20
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
                    if (val % 2 == 0) Console.WriteLine("Even: " + val);
                    if (val % 4 == 0) Console.WriteLine("Multiple of 4: " + val);
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
