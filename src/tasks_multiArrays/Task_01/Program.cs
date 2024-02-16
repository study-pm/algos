/* Дана прямоугольная матрица размерности MxN, все элементы, которой различны.
 * Сформировать одномерный массив, в который занести наибольшие элементы каждого столбца матрицы.
 */

namespace Task_01
{
    public class Utils
    {
        /// <summary>
        /// Get quantity of digits in an integer or double number
        /// </summary>
        /// <param name="n">number</param>
        /// <returns>digit count</returns>
        static int GetDigitCount(dynamic n) => n.ToString().Length;
        static string GetFillingToMaxWidth(dynamic number, int maxWidth)
        {
            string result = number.ToString();
            int numberLength = result.Length;
            for (int i = 0; i < maxWidth - numberLength; i++)
            {
                result = " " + result;
            }
            return result;
        }
        /// <summary>
        /// Generates random two-dimensional numeric array
        /// </summary>
        /// <param name="rows">Row count</param>
        /// <param name="columns">Column count</param>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns></returns>
        public static int[,] GetRandom2DArray(int rows, int columns, int min = -128, int max = 128)
        {
            int[,] result = new int[rows, columns];

            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(min, max);
                }
            }

            return result;
        }
        public static double[,] GetRandom2DArray(int rows, int columns, double min = -128.0, double max = 128.0)
        {
            double[,] result = new double[rows, columns];

            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.NextDouble() * (max - min) + min;
                }
            }

            return result;
        }
        /// <summary>
        /// Prints array in a prettified format
        /// </summary>
        /// <param name="arr">Source numeric array</param>
        /// <param name="divider">Column separators (defaults to none)</param>
        /// <param name="paddingSpaces">Space count each cell is padded (left and right)</param>
        /// <param name="roundDigits">Quantity of decimal digits to round to</param>
        /// <param name="cellWidth">Fixed cell width (defaults to none)</param>
        public static void PrintFormattedArray(dynamic arr, string divider = "", int paddingSpaces = 1, int? roundDigits = null, int? cellWidth = null)
        {
            int GetMaxDigitCount(dynamic arr)
            {
                int maxCount = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int count = Utils.GetDigitCount(roundDigits == null ? arr[i] : Math.Round(arr[i], (int)roundDigits));
                    if (count > maxCount) maxCount = count;
                }
                return maxCount;
            }

            int cellInnerWidth = cellWidth == null ? GetMaxDigitCount(arr) : (int)cellWidth;
            string padding = new string(' ', paddingSpaces);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(padding);
                Console.Write(Utils.GetFillingToMaxWidth(roundDigits == null ? arr[i] : arr[i].ToString("N" + (int)roundDigits), cellInnerWidth));
                Console.Write(padding + (i != arr.Length-1 ? divider : ""));
            }
        }
        /// <summary>
        /// Prints two-dimensional array in a pretty format
        /// </summary>
        /// <param name="arr">Source numeric 2D array</param>
        /// <param name="divider">Column separators (defaults to none)</param>
        /// <param name="paddingSpaces">Space count each cell is padded (left and right)</param>
        /// <param name="roundDigits">Quantity of decimal digits to round to</param>
        public static int Print2DArray(dynamic arr, string divider = "", int paddingSpaces = 1, int? roundDigits = null, bool isLastColDividerDub = false)
        {
            int GetMaxDigitCount(dynamic arr)
            {
                int maxCount = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        int count = Utils.GetDigitCount(roundDigits == null ? arr[i, j] : Math.Round(arr[i, j], (int)roundDigits));
                        if (count > maxCount) maxCount = count;
                    }
                }
                return maxCount;
            }

            int cellInnerWidth = GetMaxDigitCount(arr);
            string padding = new String(' ', paddingSpaces);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(padding);
                    Console.Write(Utils.GetFillingToMaxWidth(roundDigits == null ? arr[i, j] : arr[i,j].ToString("N" + (int)roundDigits), cellInnerWidth));
                    Console.Write(padding + (j != arr.GetLength(1) - 1 ? divider : ""));
                    if (isLastColDividerDub && j == arr.GetLength(1)-2) Console.Write(divider);
                }
                Console.WriteLine();
            }
            return cellInnerWidth;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int M = 3;
            int N = 5;

            // For integers
            int[,] ints = Utils.GetRandom2DArray(M, N, -128);
            int[] maxOfColumns_int = new int[N];

            for (int i = 0; i < ints.GetLength(1); i++) maxOfColumns_int[i] = ints[0, i];

            for (int i = 1; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    if (ints[i, j] > maxOfColumns_int[j]) maxOfColumns_int[j] = ints[i, j];
                }
            }

            Console.WriteLine("Source 2D random integers array");
            int itemWidth = Utils.Print2DArray(ints, "|");
            Console.WriteLine("\nMax values for each column");
            Utils.PrintFormattedArray(maxOfColumns_int, "|", cellWidth: itemWidth);

            Console.WriteLine(Environment.NewLine + "\n");

            // For doubles
            double[,] doubles = Utils.GetRandom2DArray(M, N, -128.0);
            double[] maxOfColumns_double = new double[N];

            for (int i = 0; i < doubles.GetLength(1); i++) maxOfColumns_double[i] = doubles[0, i];

            for (int i = 1; i < doubles.GetLength(0); i++)
            {
                for (int j = 0; j < doubles.GetLength(1); j++)
                {
                    if (doubles[i, j] > maxOfColumns_double[j]) maxOfColumns_double[j] = doubles[i, j];
                }
            }

            Console.WriteLine("Source 2D random doubles array");
            int roundDigits = 2;
            int itemWidthDouble = Utils.Print2DArray(doubles, "|", roundDigits: roundDigits);
            Console.WriteLine("\nMax values for each column");
            Utils.PrintFormattedArray(maxOfColumns_double, "|", roundDigits: roundDigits, cellWidth: itemWidthDouble);
        }
    }
}
