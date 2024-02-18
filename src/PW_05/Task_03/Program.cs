/* Написать программу для перемножения квадратных матриц А и В размерности NxN, которая должна вывести на экран результат — третью матрицу размерности NxN.
 */

namespace Task_03
{
    internal class Program
    {
        /// <summary>
        /// Get product of two matrices multiplication
        /// </summary>
        /// <param name="A">First matrix (multiplicand)</param>
        /// <param name="B">Second matrix (multiplier/factor)</param>
        /// <returns>Result matrix (product)</returns>
        /// <exception cref="Exception">Denotes inconsistency of multiplicand and multiplier</exception>
        public static int[,] MultiplyMatrices(int[,] A, int[,] B)
        {
            // Sample A: int[,] A = { { 1, 2, 2 }, { 3, 1, 1 } };
            // Sample B: int[,] B = { { 4, 2 }, { 3, 1 }, { 1, 5 } };

            if (A.GetLength(1) != B.GetLength(0)) throw new Exception("inconsistent");

            int[,] AB = new int[A.GetLength(0), B.GetLength(1)];

            for (int k = 0; k < A.GetLength(1); k++)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        AB[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            // Sample Product 1: AB = { { 12, 14 }, { 16, 12 } }
            // Sample Product 2: BA = { { 10, 10, 10 }, { 6, 7, 7 }, { 16, 7, 7 } }
            return AB;
        }
        static void Main()
        {
            int M = 2;
            int N = 2;

            int[,] A = Task_01.Utils.GetRandomsArray(M, N, new int[] { -4, 4 });
            int[,] B = Task_01.Utils.GetRandomsArray(N, M, new int[] { -8, 8 });

            int[,] AB = MultiplyMatrices(A, B);

            Console.WriteLine("Matrix A: ");
            Task_01.Utils.PrintArray(A, "|");

            Console.WriteLine();

            Console.WriteLine("Matrix B: ");
            Task_01.Utils.PrintArray(B, "|");


            Console.WriteLine();

            Console.WriteLine("Matrix AB: ");
            Task_01.Utils.PrintArray(AB, "|");
        }
    }
}
