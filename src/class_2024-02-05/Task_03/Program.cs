/* Сформировать массив из 15 целых чисел, выбранных случайным образом из интервала [10, 90].
 * Поменять местами первый и минимальный элементы.
 */

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[15];
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(10, 90);
            }

            int min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            // Output
            Console.WriteLine("Source array items: " + String.Join(' ', array));
            Console.WriteLine($"Min value is {min} with index {minIndex}");
            
            (array[0], array[minIndex]) = (array[minIndex], array[0]);
            Console.WriteLine("Result array items: " + String.Join(' ', array));
        }
    }
}
