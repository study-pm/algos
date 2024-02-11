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
        }
    }
}
