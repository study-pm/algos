/* Дана прямоугольная матрица размерности MxN, все элементы, которой различны.
 * Сформировать одномерный массив, в который занести наименьшие элементы каждой строки матрицы.
 */

using Task_01;

namespace Task_02
{
    internal class Program
    {
        static dynamic AppendToRow(dynamic srcArr, dynamic appendageArr)
        {
            dynamic[,] resArr = new dynamic[srcArr.GetLength(0), srcArr.GetLength(1) + 1];
            for (int i = 0; i < srcArr.GetLength(0); i++)
            {
                for (int j = 0; j < srcArr.GetLength(1); j++) resArr[i, j] = srcArr[i, j];
                resArr[i, resArr.GetLength(1)-1] = appendageArr[i];
            }

            return resArr;
        }
        static void Main(string[] args)
        {
            int M = 6;
            int N = 5;

            // For integers
            int[,] ints = Task_01.Utils.GetRandom2DArray(M, N, -256, 256);
            int[] minOfRows_int = new int[M];

            for (int i = 0; i < ints.GetLength(0); i++) minOfRows_int[i] = ints[i, 0];

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (ints[i, j] < minOfRows_int[i]) minOfRows_int[i] = ints[i, j];
                }
            }

            Console.WriteLine("Source 2D random integers array");
            Task_01.Utils.Print2DArray(ints, "|");
            Console.WriteLine("\nMin values for each row");
            Console.WriteLine(String.Join(" ", minOfRows_int));
            Console.WriteLine();
            
            dynamic[,] intsExtended = AppendToRow(ints, minOfRows_int);
            Console.WriteLine("Source 2D random integers array extended with each row minimum values");
            Task_01.Utils.Print2DArray(intsExtended, "|", isLastColDividerDub: true);

            Console.WriteLine(Environment.NewLine + "\n");

            // For doubles
            double[,] doubles = Task_01.Utils.GetRandom2DArray(M, N, -256.0, 256.0);
            double[] minOfRows_double = new double[M];

            for (int i = 0; i < doubles.GetLength(0); i++) minOfRows_double[i] = doubles[i, 0];

            for (int i = 0; i < doubles.GetLength(0); i++)
            {
                for (int j = 0; j < doubles.GetLength(1); j++)
                {
                    if (doubles[i, j] < minOfRows_double[i]) minOfRows_double[i] = doubles[i, j];
                }
            }

            int roundDigits = 2;
            dynamic[,] doublesExtended = AppendToRow(doubles, minOfRows_double);
            Console.WriteLine("Source 2D random doubles array extended with each row minimum values");
            Task_01.Utils.Print2DArray(doublesExtended, "|", isLastColDividerDub: true, roundDigits: roundDigits);
        }
    }
}
