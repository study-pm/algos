/* Дан массив из n чисел как положительных, так и отрицательных.
 * Нужно сначала записать положительные числа, а затем отрицательные в том же порядке, как они были записаны в исходном массиве.
 */

namespace Task_15
{
    internal class Program
    {
        /// <summary>
        /// Split original array on groups based on item sign preserving original order inside each group
        /// </summary>
        /// <param name="input">Source array</param>
        /// <returns>Array of negative, zero and positive numbers groups</returns>
        static double[][] SplitOnSign(double[] input)
        {
            double[] positives = Array.Empty<double>();
            double[] zeros = Array.Empty<double>();
            double[] negatives = Array.Empty<double>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0)
                {
                    Array.Resize(ref negatives, negatives.Length+1);
                    negatives[negatives.Length-1] = input[i];
                }
                else if (input[i] == 0)
                {
                    Array.Resize(ref zeros, zeros.Length+1);
                    zeros[zeros.Length-1] = input[i];
                }
                else
                {
                    Array.Resize(ref positives, positives.Length+1);
                    positives[positives.Length-1] = input[i];
                }
            }
            return new double[][] { negatives, zeros, positives };
        }
        static void Main(string[] args)
        {
            int n = 10;
            double[] srcArr = Task_11.Utils.GetRandomDoubleArray(n, -128.0, 128.0);

            // Calculation
            double[][] arraySplit = SplitOnSign(srcArr);
            double[] result = arraySplit[0].Concat(arraySplit[1]).Concat(arraySplit[2]).ToArray();

            // Output
            Console.Write("Source array:");
            for (int i = 0; i < srcArr.Length; i++)
            {
                Console.Write(" " + srcArr[i].ToString("N2"));
            }
            Console.WriteLine();
            Console.Write("Result array:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(" " + result[i].ToString("N2"));
            }
        }
    }
}
