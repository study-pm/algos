/* В заданном массиве найти среднее арифметическое положительных чисел, среднее арифметическое отрицательных чисел и число нулей.
 */

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            array[array.Length-1] = 0;

            double meanPositive = 0;
            double meanNegative = 0;
            int zeroesCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) meanPositive += array[i];
                else if (array[i] < 0) meanNegative += array[i];
                else zeroesCount++;
            }

            // Output
            Console.WriteLine("Source array items: " + String.Join(' ', array));
            Console.WriteLine($"Array mean of positive numbers: {meanPositive}");
            Console.WriteLine($"Array mean of negative numbers: {meanNegative}");
            Console.WriteLine($"Array zeroes count: {zeroesCount}");
        }
    }
}
