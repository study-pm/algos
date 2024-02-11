/* Задан одномерный массив А[1..20].
 * Найти минимальный элемент среди элементов массива с n-го по k-й (n и k вводятся с клавиатуры)
 */

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                int[] array = new int[20];
                for (int i = 0; i < 20; i++)
                {
                    array[i] = random.Next(-100, 100);
                }

                Console.Write("Enter first array index: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter last array index: ");
                int k = int.Parse(Console.ReadLine());

                if (k < n) (n, k) = (k, n);

                int min = array[n];

                for (int i = n; i < k + 1; i++)
                {
                    if (array[i] < min) min = array[i];
                }

                // Output
                Console.WriteLine("Source array items: " + String.Join(' ', array));
                Console.WriteLine($"Min value from range between indices {n} and {k}: {min}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
