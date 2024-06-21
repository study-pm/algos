/* Вывести среднее арифметическое вводимой с клавиатуры последовательности чисел.
 * Признаком конца ввода является число 9999.
 */

namespace Console_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            double mean = 0;

            try
            {
                Console.WriteLine("Enter integer numbers one by one, to finish the series enter 9999");
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n == 9999) break;
                    sum += n;
                    count++;
                    mean = (double)sum / count;
                }

                if (count == 0) Console.WriteLine("The series contains 0 elements, no mean is available.");
                else Console.WriteLine("Mean of the series is: {0:N2}", mean);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
