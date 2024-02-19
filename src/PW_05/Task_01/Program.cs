/* Написать программу, выводящую на экран одномерный и двумерный массив чисел соответственно
 * (одномерный — в виде строки, двумерный — в виде таблицы).
 */

using System.ComponentModel.DataAnnotations;

namespace Task_01
{
    public class Utils
    {
        /// <summary>
        /// Produce random value with the specified range
        /// </summary>
        /// <param name="range">Value range (min and max values)</param>
        /// <returns>Random value within the specified range</returns>
        private static int GetRandomValue(int[] range)
        {
            Random random = new();
            return random.Next(range[0], range[1]);
        }
        private static double GetRandomValue(double[] range)
        {
            Random random = new();
            return random.NextDouble() * (range[1] - range[0]) + range[0];
        }
        /// <summary>
        /// Generate array of random values
        /// </summary>
        /// <param name="length">New array length</param>
        /// <param name="range">Values range as [min, max]</param>
        /// <returns>New array filled with generated random values</returns>
        public static int[] GetRandomsArray(int length, int[] range)
        {
            int[] result = new int[length];

            Random random = new Random();
            for (int i = 0; i < length; i++) result[i] = GetRandomValue(range);
            return result;
        }
        public static double[] GetRandomsArray(int length, double[] range)
        {
            double[] result = new double[length];

            Random random = new Random();
            for (int i = 0; i < length; i++) result[i] = GetRandomValue(range);
            return result;
        }
        public static int[,] GetRandomsArray(int rowCount, int colCount, int[] range)
        {
            int[,] result = new int[rowCount, colCount];

            Random random = new Random();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    result[i, j] = GetRandomValue(range);
                }
            }
            return result;
        }
        public static double[,] GetRandomsArray(int rowCount, int colCount, double[] range)
        {
            double[,] result = new double[rowCount, colCount];

            Random random = new Random();
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    result[i, j] = GetRandomValue(range);
                }
            }
            return result;
        }
        public static void PrintArray(int[] arr, string divider = "", int paddingSpaces = 1)
        {
            string padding = new string(' ', paddingSpaces);
            Console.WriteLine(String.Join(padding + divider + padding, arr));
        }
        public static void PrintArray(double[] arr, string divider = "", int paddingSpaces = 1, int roundDigits = 2)
        {
            string padding = new string(' ', paddingSpaces);
            Console.Write(padding + arr[0].ToString("N" + roundDigits));
            for (int i = 1; i < arr.Length; i++) Console.Write(padding + divider + padding + arr[i].ToString("N" + roundDigits));
        }
        /// <summary>
        /// Prints two dimensional array values in pretty format
        /// </summary>
        /// <param name="arr">Source array</param>
        /// <param name="divider">Column separator (defaults to none)</param>
        /// <param name="paddingSpaces">Cell padding (number of spaces)</param>
        /// <param name="roundDigits">Number of decimal digits (defaults to none - no rounding)</param>
        public static void PrintArray(dynamic arr, string divider = "", int paddingSpaces = 1, int? roundDigits = null)
        {
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
            int GetMaxDigitCount(dynamic value)
            {
                int maxCount = 0;
                for (int i = 0; i < value.GetLength(0); i++)
                {
                    for (int j = 0; j < value.GetLength(1); j++)
                    {
                        int count = GetDigitCount(roundDigits == null ? value[i, j] : Math.Round(value[i, j], (int)roundDigits));
                        if (count > maxCount) maxCount = count;
                    }
                }
                return maxCount;
            }

            int cellInnerWidth = GetMaxDigitCount(arr);
            string padding = new string(' ', paddingSpaces);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(padding);
                    Console.Write(GetFillingToMaxWidth(roundDigits == null ? arr[i, j] : arr[i, j].ToString("N" + (int)roundDigits), cellInnerWidth));
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(padding + (j != arr.GetLength(1) - 1 ? divider : ""));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            int[] ints_1 = Utils.GetRandomsArray(16, new int[] { -128, 128 });
            Console.WriteLine("One-dimensional array of int values");
            Utils.PrintArray(ints_1);

            Console.WriteLine();

            double[] doubles_1 = Utils.GetRandomsArray(8, new double[] { -128.0, 128.0 });
            Console.WriteLine("One-dimensional array of double values");
            Utils.PrintArray(doubles_1);

            Console.WriteLine(Environment.NewLine);

            int[,] ints_2 = Utils.GetRandomsArray(8, 8, new int[] { -512, 512 });
            Console.WriteLine("Two-dimensional array of int values");
            Utils.PrintArray(ints_2, "|");

            Console.WriteLine();

            double[,] doubles_2 = Utils.GetRandomsArray(8, 6, new double[] { -512, 512 });
            Console.WriteLine("Two-dimensional array of double values");
            Utils.PrintArray(doubles_2, "|", roundDigits: 2);
        }
    }
}
