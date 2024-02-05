/*Вывести все целые числа из диапазона от А до В, кратные трем (А<=В ).
 */

namespace Task_01
{
    public class AliquotOf3
    {
        /// <summary>
        /// Defines left and right border for range by two integers and puts them the right places
        /// </summary>
        /// <param name="x">first integer</param>
        /// <param name="y">second integer</param>
        /// <param name="a">min limit</param>
        /// <param name="b">max limit</param>
        public static void NormalizeBorders(int x, int y, out int a, out int b)
        {
            if (y < x)
            {
                a = y; b = x;
            }
            else
            {
                a = x; b = y;
            }
        }
        /// <summary>
        /// Returns integers divisible by 3 inside the given range and prints every such number
        /// </summary>
        /// <param name="a">range min value</param>
        /// <param name="b">range max value</param>
        /// <returns>List of all integers aliquot of 3</returns>
        static List<int> GetPrintAliquotOf3(int a, int b)
        {
            List<int> aliquotesOf3 = new List<int>();
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                    aliquotesOf3.Add(i);
                }
            }
            return aliquotesOf3;
        }
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter integer A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter integer B: ");
            int B = int.Parse(Console.ReadLine());

            // Check and fix range borders
            NormalizeBorders(A, B, out int a, out int b);

            // Calculation
            List<int> X = GetPrintAliquotOf3(a, b);
        }
    }
}
