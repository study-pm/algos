/* Дан массив A размера N.
 * Сформировать новый массив B того же размера по следующему правилу: элемент BK равен сумме элементов массива A с номерами от 1 до K
 */

using Task_01;

namespace Task_02
{
    internal class CumulativeArray
    {
        /// <summary>
        /// Get array of items produced by cumulative summing of the source array members
        /// </summary>
        /// <param name="srcArr">Source array</param>
        /// <returns>Cumulative array</returns>
        static double[] GetCumulativeArray(double[] srcArr)
        {
            double[] resArr = new double[srcArr.Length];
            resArr[0] = srcArr[0];
            for (int i = 1; i < srcArr.Length; i++)
            {
                resArr[i] = srcArr[i] + resArr[i-1];
            }
            return resArr;
        }
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter array items separated by a space (must be real numbers): ");
            double[] A = Task_01.Utils.ConvertStringToDoubleArr(Console.ReadLine(), " ");

            // Calculation
            double[] B = GetCumulativeArray(A);

            // Output
            Console.WriteLine(String.Join(" ", B));
        }
    }
}
