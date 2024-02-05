/* Даны два массива A и B.
 * Определить которых из них имеет больший диапазон, т.е. разницу между самым большим и самым меньшим значением
 */

namespace Task_01
{
    public class Utils
    {
        /// <summary>
        /// Convert string to array of real numbers
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="separator">Items separator</param>
        /// <returns>Array of real numbers</returns>
        public static double[] ConvertStringToDoubleArr(string input, string separator = " ")
        {
            string[] strArr = input.Split(separator);
            double[] resArr = new double[strArr.Length];
            for (int i = 0; i < strArr.Length; i++) resArr[i] = double.Parse(strArr[i]);
            return resArr;
        }
        /// <summary>
        /// Get array item having maximum value
        /// </summary>
        /// <param name="arr">Array to search in</param>
        /// <returns>Maximum value</returns>
        public static double GetArrayMaxValueItem(double[] arr) => arr.Max();
        /// <summary>
        /// Get array item having maximum value
        /// </summary>
        /// <param name="arr">Array to search in</param>
        /// <param name="isForeach">Flag signifying this overload usage</param>
        /// <returns>Maximum value</returns>
        public static double? GetArrayMaxValueItem(double[] arr, bool isForeach)
        {
            double? max = null;
            foreach (double item in arr) {
                if (!(item < max)) max = item;
            }
            return max;
        }
        /// <summary>
        /// Get array item having minimum value
        /// </summary>
        /// <param name="arr">Array to search in</param>
        /// <returns>Minimum value</returns>
        public static double GetArrayMinValueItem(double[] arr) => arr.Min();
        /// <summary>
        /// Get array item having minimum value
        /// </summary>
        /// <param name="arr">Array to search in</param>
        /// <param name="isForeach">Flag signifying this overload usage</param>
        /// <returns>Minimum value</returns>
        public static double? GetArrayMinValueItem(double[] arr, bool isForeach)
        {
            double? min = null;
            foreach (double item in arr)
            {
                if (!(item > min)) min = item;
            }
            return min;
        }
    }
    internal class MaxRange
    {
        /// <summary>
        /// Get difference between maximum and minimum values of array items
        /// </summary>
        /// <param name="arr">Source array</param>
        /// <returns>Array range</returns>
        static double GetArrayRange(double[] arr) => Utils.GetArrayMaxValueItem(arr) - Utils.GetArrayMinValueItem(arr);
        /// <summary>
        /// Get array indices having maximum range
        /// </summary>
        /// <param name="arrs">Input arrays</param>
        /// <returns>Maximum range array indices</returns>
        static List<int> GetMaxRangeArrayIndices(params double[][] arrs)
        {
            List<int> indices = new List<int>();
            double maxRange = 0;
            for (int i = 0; i < arrs.Length; i++)
            {
                double range = GetArrayRange(arrs[i]);
                Console.WriteLine(range);
                if (range > maxRange)
                {
                    indices.Clear();
                    maxRange = range;
                }
                if (range >= maxRange) indices.Add(i);
            }
            return indices;
        }
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter first array items separated by a space (must be real numbers): ");
            double[] A = Utils.ConvertStringToDoubleArr(Console.ReadLine(), " ");
            Console.Write("Enter second array items separated by a space (must be real numbers): ");
            double[] B = Utils.ConvertStringToDoubleArr(Console.ReadLine(), " ");

            // Calculation
            List<int> I = GetMaxRangeArrayIndices(A, B);

            // Output
            Console.Write($"Array{(I.Count > 1 ? "s" : "")} with index{(I.Count > 1 ? "es" : "")} ");
            foreach (int i in I) Console.Write($"{i}{(i < I.Count-1 ? "," : "")} ");
            Console.Write($"ha{(I.Count > 1 ? "ve": "s")} maximum range");
        }
    }
}
