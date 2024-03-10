/* Написать программу, находящую минимальный и максимальный элемент массива, вычисляющую среднее арифметическое элементов массива и сумму элементов.
 * Массив одномерный, размерности N, заполнить его случайными целыми числами от a до b.
 * N, a и b вводятся пользователем.
 * Вывести массив и результаты/
 */

namespace Task_02
{
    internal class Program
    {
        /// <summary>
        /// Parse string expressing the range
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Value range [min, max]</returns>
        /// <exception cref="Exception"></exception>
        static int[] ParseRangeStr(string input)
        {
            try
            {
                string[] rangeStr = input.Split(" ");
                int[] range = new int[2];
                for (int i = 0; i < 2; i++) range[i] = int.Parse(rangeStr[i]);
                if (range[0] > range[1]) (range[0], range[1]) = (range[1], range[0]);
                return range;
            }
            catch (Exception) {
                throw new Exception("range");
            }
        }
        static void Main()
        {
            try
            {
                // Input
                Console.Write("Enter array length (N): ");
                bool isN = int.TryParse(Console.ReadLine(), out int N);
                if (!isN) throw new Exception("length");

                Console.Write("Enter array min and max values, separated by a space: ");
                int[] range = ParseRangeStr(Console.ReadLine());
                int a = range[0], b = range[1];

                int[] arr = Task_01.Utils.GetRandomsArray(N, new int[] { a, b });

                int max = arr[0];
                int min = arr[0];
                int sum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                    sum += arr[i];
                }

                double mean = (double)sum / arr.Length;

                Console.WriteLine();
                Console.WriteLine($"Auto generated array of {N} items within the range between {a} and {b}: ");
                Task_01.Utils.PrintArray(arr);

                Console.WriteLine();
                Console.WriteLine($"Array max value is {max}, min is {min}, mean is {mean.ToString("N2")}");
            }
            catch (Exception e)
            {
                switch(e.Message)
                {
                    case "length":
                        Console.WriteLine("Invalid length input (must be an integer)");
                        break;
                    case "range":
                        Console.WriteLine("Invalid range input (must be two integer numbers separated by a unary space)");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
