/* Составьте программу, которая определяет, принадлежит ли точка А(x0, y0) графику функции y=2x-3.
 */

namespace Task_01
{
    internal class Program
    {
        /// <summary>
        /// Defines whether the given point belongs to the function y = 2x-3 graph
        /// </summary>
        /// <param name="a">Point coordinates</param>
        /// <returns>True if belongs, False if doesn't belong</returns>
        static bool DoesBelongToGraph(double[] a)
        {
            double y = 2 * a[0] - 3;
            return a[1] == y;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter A coordinates x0, y0, separated by a single space: ");
            string[] input = Console.ReadLine().Split();
            double[] a = new double[] { double.Parse(input[0]), double.Parse(input[1]) };

            bool b = DoesBelongToGraph(a);

            Console.WriteLine($"A does{(b ? "" : "n't")} belong to the function y = 2x-3 graph.");
        }
    }
}
