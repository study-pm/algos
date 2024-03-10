/* Квадратная матрица порядка 2n состоит из 4 блоков.
 * Напишите программу, которая формирует новую матрицу, переставляя блоки исходной матрицы согласно приведенной схеме.
 */

using System.Drawing;

namespace Task_05_2
{
    internal class Program
    {
        /// <summary>
        /// Generate square matrix filled with indices
        /// </summary>
        /// <param name="n">Matrix size</param>
        /// <returns>Square matrix filled with indices</returns>
        public static string[,] GetFilledWithIndices(int n)
        {
            string[,] matrix = new string[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + "" + j;
                }
            }

            return matrix;
        }
        /// <summary>
        /// Get new square matrix based on the source one with quadrants shifted clockwise
        /// </summary>
        /// <param name="src">Source square matrix</param>
        /// <returns>Matrix with quadrants shifted clockwise</returns>
        public static string[,] GetShiftedMatrix(string[,] src)
        {
            string[,] shifted = new string[src.GetLength(0), src.GetLength(1)];

            int shift = src.GetLength(0) / 2;

            for (int i = 0; i < shift; i++)
            {
                for (int j = 0; j < shift; j++)
                {
                    shifted[i, j+shift] = src[i, j];
                }
                for (int j = shift; j < src.GetLength(1); j++)
                {
                    shifted[i + shift, j] = src[i, j];
                }
            }

            for (int i = shift; i < src.GetLength(0); i++)
            {
                for (int j = shift; j < src.GetLength(1); j++)
                {
                    shifted[i, j-shift] = src[i, j];
                }
                for (int j = 0; j < shift; j++)
                {
                    shifted[i - shift, j] = src[i, j];
                }
            }

            return shifted;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a positive integer number: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 0) throw new Exception("invalid input");

                string[,] src = GetFilledWithIndices(2 * n);
                Console.WriteLine("Source matrix");
                Task_01.Utils.PrintArray(src, "");
                Console.WriteLine();

                string[,] shifted = GetShiftedMatrix(src);
                Console.WriteLine("Shifted matrix");
                Task_01.Utils.PrintArray(shifted, "");
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input: must be a non-negative integer.");
            }
        }
    }
}
