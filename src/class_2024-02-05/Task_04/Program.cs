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
                int[] A = new int[20];
                for (int i = 0; i < 20; i++)
                {
                    A[i] = random.Next(-100, 100);
                }

                Console.Write("Enter first array index: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Enter last array index: ");
                int k = int.Parse(Console.ReadLine());

                if (k < n) (n, k) = (k, n);

                int min = A[n];

                for (int i = n-1; i < k; i++)
                {
                    if (A[i] < min) min = A[i];
                }

                // Output
                Console.WriteLine("Source array items: " + String.Join(' ', A));
                Console.WriteLine($"Min value from range between indices {n} and {k}: {min}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
