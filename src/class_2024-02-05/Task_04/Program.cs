/* Задан одномерный массив А[1..20].
 * Найти минимальный элемент среди элементов массива с n-го по k-й (n и k вводятся с клавиатуры)
 */

namespace Task_04
{
    internal class Program
    {
        /// <summary>
        /// Parse a string and convert to a natural number
        /// </summary>
        /// <param name="s">string representing a natural number</param>
        /// <returns>Parsed number</returns>
        /// <exception cref="Exception">Not an integer or natural number</exception>
        public static int ParseAsNatural(string s)
        {
            int n = int.Parse(s);
            if (n < 1) throw new Exception("not a natural number");
            return n;
        }
        /// <summary>
        /// Check and fix item range
        /// </summary>
        /// <param name="k">First element number</param>
        /// <param name="n">Last element number</param>
        /// <returns>Fixed element numbers</returns>
        /// <exception cref="Exception"></exception>
        public static (int, int) CheckItemRange(int n, int k)
        {
            if (k > 20 || n > 20) throw new Exception("outside the item range");
            int first = n;
            int last = k;
            if (last < first) (first, last) = (last, first);
            return (first, last);
        }
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
                Console.Write("Enter first element number (must be an integer from 1 to 20): ");
                int n = ParseAsNatural(Console.ReadLine());
                Console.Write("Enter last element number (must be an integer from 1 to 20): ");
                int k = ParseAsNatural(Console.ReadLine());

                (n, k) = CheckItemRange(n, k);

                int min = A[n-1];

                for (int i = n; i < k; i++)
                {
                    if (A[i] < min) min = A[i];
                }

                // Output
                Console.WriteLine("Source array items: " + String.Join(' ', A));
                Console.WriteLine($"Min value from range between element numbers from {n} to {k}: {min}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}
