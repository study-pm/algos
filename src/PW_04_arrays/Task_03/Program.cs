/* Даны два массива A и B, элементы которых упорядочены по возрастанию.
 * Объединить эти массивы так, чтобы результирующий массив C остался упорядоченным по возрастанию
 */

using Task_01;

namespace Task_03
{
    internal class JoinSortedArrays
    {
        enum SortOrder
        {
            asc = 1,
            desc = -1
        }
        /// <summary>
        /// Merge two sorted arrays, preserving the sorting order
        /// </summary>
        /// <param name="a">First array, sorted ascending</param>
        /// <param name="b">First array, sorted ascending</param>
        /// <param name="order">Sorting order</param>
        /// <returns></returns>
        static double[] MergeSorting(double[] a, double[] b, SortOrder order = SortOrder.asc)
        {
            double[] c = new double[a.Length + b.Length];
            for (int i = 0, j = 0, k = 0; k < c.Length; k++)
            {
                // Streamlined conditionals (one level)
                if (
                    i < a.Length && j < b.Length && (order == SortOrder.asc ? a[i] <= b[j] : a[i] > b[j])
                    || i < a.Length && j >= b.Length
                    )
                {
                    c[k] = a[i];
                    i++;
                }
                else if (
                    i < a.Length && j < b.Length && (order == SortOrder.asc ? a[i] > b[j] : a[i] <= b[j])
                    || i >= a.Length && j < b.Length
                    )
                {
                    c[k] = b[j];
                    j++;
                }
                /* Multilevel conditionals (ascending order only)
                if (i < a.Length && j < b.Length)
                {
                    if (a[i] < b[j])
                    {
                        c[k] = a[i];
                        i++;
                    }
                    else
                    {
                        c[k] = b[j];
                        j++;
                    }
                }
                else if (i < a.Length)
                {
                    c[k] = a[i];
                    i++;
                }
                else if (j < b.Length)
                {
                    c[k] = b[j];
                    j++;
                }
                */
            }
            return c;
        }
        static void Main(string[] args)
        {

            // Sample input (line 1): -415 -5 0 66 6879 1 225,25 -1024,128
            // Sample input (line 2): -2048,26697 0 1 2 3 4 5 6 7 8 9 -1 -55

            // Input
            Console.Write("Enter first array items separated by a space (must be real numbers): ");
            double[] A = Utils.ConvertStringToDoubleArr(Console.ReadLine(), " ");
            Console.Write("Enter second array items separated by a space (must be real numbers): ");
            double[] B = Utils.ConvertStringToDoubleArr(Console.ReadLine(), " ");
            Console.Write("Set sorting order (1/empty - ascending, -1 - descending): ");
            SortOrder order = Console.ReadLine() == "-1" ? SortOrder.desc : SortOrder.asc;

            // Data preparation (ensure proper sorting)
            Array.Sort(A);
            Array.Sort(B);
            if (order == SortOrder.desc)
            {
                Array.Reverse(A);
                Array.Reverse(B);
            }

            // Calculation
            double[] C = MergeSorting(A, B, order);

            // Expected output (sorting order 1) : -2048,26697 -1024,128 -415 -55 -5 -1 0 0 1 1 2 3 4 5 6 7 8 9 66 225,25 6879
            // Expected output (sorting order -1): 6879 225,25 66 9 8 7 6 5 4 3 2 1 1 0 0 -1 -5 -55 -415 -1024,128 -2048,26697

            // Output
            Console.WriteLine(String.Join(" ", C));
        }
    }
}
