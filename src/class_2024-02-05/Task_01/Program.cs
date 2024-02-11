/* Сформировать массив из 15 целых чисел, выбранных случайным образом из интервала [-10, 30].
 * Найти среднее арифметическое положительных элементов.
 */

 namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[15];
            for (int i = 0; i< 15; i++)
            {
                array[i] = random.Next(-10, 30);
            }
            int sumOfPositives = 0;
            int itemCount = 0;
            for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= 0) continue;
                    sumOfPositives += array[i];
                    itemCount++;
                }
            double mean = (double)sumOfPositives / itemCount;

            // Output
            Console.WriteLine("Array items: " + String.Join(' ', array));
            Console.WriteLine("Mean: " + mean.ToString("N2"));
        }
    }
}
