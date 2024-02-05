/* Осуществить ввод последовательности целых чисел. 
 * Определить, сколько из них и какие принимают наибольшее значение.
 * Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
 */

namespace Task_05
{
    internal class IntegerSequence
    {
        static void Main(string[] args)
        {
            int? m = null;
            int n = 0;
            int input;
            bool isInteger;
            do
            {
                Console.Write("Enter an integer: ");
                isInteger = int.TryParse(Console.ReadLine(), out input);
                if (!isInteger)
                {
                    Console.WriteLine("Invalid input: must be an integer.");
                    continue;
                }
                if (m == input)
                {
                    n++;
                }
                // Since any comparison to null produces False output, comparison inversion is required
                // This is done to omit the following check: if (m == null) m = input;
                else if (!(m > input))
                {
                    m = input;
                    n = 1;
                }
            }
            while (input != 0);

            if (m == null) Console.WriteLine("No valid values are provided.");
            else Console.WriteLine($"Maximum is {m}, repeated {n} times");
        }
    }
}
