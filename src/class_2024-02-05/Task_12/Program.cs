/*  В одномерном массиве целых чисел a1, а2, ..., an найти номер первого четного числа.
 *  Если четных чисел нет, то ответом может быть число 0
 */

namespace Task_12
{
    internal class Program
    {
        /// <summary>
        /// Get array's first even number index and value
        /// </summary>
        /// <param name="srcArr">Source array</param>
        /// <returns>Index and value of the first even number (both may be null if there are no such numbers)</returns>
        static int?[] GetFirstEvenIndexAndValue(int[] srcArr)
        {
            int?[] result = new int?[] { null, null };
            for (int i = 0; i < srcArr.Length; i++)
            {
                if (srcArr[i] % 2 == 0)
                {
                    result[0] = i;
                    result[1] = srcArr[i];
                    break;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = 2;
            int[] array = Task_05.Utils.GetRandomIntArray(n);

            // Calculation
            int?[] result = GetFirstEvenIndexAndValue(array);

            // Output
            Console.WriteLine("Source array items: " + String.Join(' ', array));
            if (result[0] == null)
            {
                Console.WriteLine($"No even numbers in the array, answer is 0");
            }
            else {
                Console.WriteLine($"First even number is a{result[0] + 1} with index {result[0]} and value {result[1]}");
            }
        }
    }
}
