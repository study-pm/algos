/* Задан массив положительных вещественных чисел.
 * Вычислить значения функции у=0,5х при значениях аргумента, заданных в исходном массиве, и поместить их в другой массив.
 * Вывести на экран дисплея оба массива в виде двух столбцов.
 */

namespace Task_11
{
    public class Utils
    {
        public static double[] GetRandomDoubleArray(int length, double min = -128.0, double max = 128.0)
        {
            Random random = new Random();

            double[] array = new double[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * (max - min) + min;
            }
            return array;
        }
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
        /// Prints array in a prettified format
        /// </summary>
        /// <param name="arr">Source numeric array</param>
        /// <param name="divider">Column separators (defaults to none)</param>
        /// <param name="paddingSpaces">Space count each cell is padded (left and right)</param>
        /// <param name="roundDigits">Quantity of decimal digits to round to</param>
        /// <param name="cellWidth">Fixed cell width (defaults to none)</param>
        public static void PrintFormattedArrays(dynamic arr1, dynamic arr2, string divider = "", int paddingSpaces = 1, int? roundDigits = null, int? cellWidth = null)
        {
            int GetMaxDigitCount(dynamic arr1, dynamic arr2)
            {
                int maxCount = 0;
                foreach (var arr in new dynamic[] { arr1, arr2 })
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int count = Utils.GetDigitCount(roundDigits == null ? arr[i] : Math.Round(arr[i], (int)roundDigits));
                        if (count > maxCount) maxCount = count;
                    }
                }
                return maxCount;
            }

            int cellInnerWidth = cellWidth == null ? GetMaxDigitCount(arr1, arr2) : (int)cellWidth;
            string padding = new string(' ', paddingSpaces);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(padding);
                Console.Write(Utils.GetFillingToMaxWidth(roundDigits == null ? arr1[i] : arr1[i].ToString("N" + (int)roundDigits), cellInnerWidth));
                Console.Write(padding + divider);
                Console.Write(padding);
                Console.Write(Utils.GetFillingToMaxWidth(roundDigits == null ? arr2[i] : arr2[i].ToString("N" + (int)roundDigits), cellInnerWidth));
                Console.Write(padding);
                Console.WriteLine();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double[] srcArr = Utils.GetRandomDoubleArray(n, 1.0, 128.0);

            double[] dstArr = new double[n];

            for (int i = 0; i < srcArr.Length; i++)
            {
                dstArr[i] = srcArr[i] * 0.5;
            }

            // Output
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(srcArr[i].ToString("N2") + " " + dstArr[i].ToString("N2"));
            }

            Console.WriteLine();

            // Pretty output
            Utils.PrintFormattedArrays(srcArr, dstArr, "|", roundDigits: 2);
        }
    }
}
