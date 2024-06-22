/* Вывести сумму первых n членов ряда: 1 + 1/2 + 1/3 + 1/4 + ...
 * Количество суммируемых членов ряда задается пользователем.
 */

namespace Console_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a natural number: ");
                uint n = uint.Parse(Console.ReadLine());

                double sum = 0;

                for (uint i = 1; i <= n; i++)
                {
                    sum += 1.0/i;
                }

                Console.WriteLine("Series sum is: {0:N2}", sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
