/* Найти все трехзначные числа,
 * которые при делении на 2 дают остаток 1,
 * при делении на 3 - остаток 2,
 * при делении на 4 - остаток 3,
 * а само число делится на 5.
 */

namespace Console_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = { 100, 1000 };

            for (int i = range[0]; i < range[1]; i++)
            {
                if (i % 2 == 1 && i % 3 == 2 && i % 4 == 3 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} % 2 == 1, {i} % 3 == 2, {i} % 4 == 3, {i} % 5 == 0");
                }
            }
        }
    }
}
