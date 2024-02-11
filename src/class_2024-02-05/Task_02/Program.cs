/* Сформировать массив из 10 целых чисел, выбранных случайным образом из интервала [10, 50].
 * Найти максимальный среди элементов с четными индексами.
 */

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(10, 50);
            }

            int max = array[0];

            for (int i = 2; i < array.Length; i++)
            {
                if (i % 2 == 0 && array[i] > max) max = array[i];
            }

            // Output
            Console.WriteLine("Array items: " + String.Join(' ', array));
            Console.WriteLine("Max: " + max.ToString());
        }
    }
}
