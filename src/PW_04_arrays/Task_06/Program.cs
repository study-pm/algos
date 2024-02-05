/* *Дан целочисленный массив размера N.
 * Удалить из массива все элементы, встречающиеся ровно два раза, и вывести размер полученного массива и его содержимое.
 */

using System;

namespace Task_06
{
    internal class Program
    {
        /// <summary>
        /// Get transformed array with removed duplications with any given occurences number
        /// </summary>
        /// <param name="input">Source array</param>
        /// <param name="occurencesNumber">Number of occurences</param>
        /// <returns>Transformed array</returns>
        static int[] RemoveArrayDupes(int[] input, int occurencesNumber = 2)
        {
            List<int> source = input.ToList();
            for (int i = 0; i < input.Length; i++)
            {

                List<int> indices = new List<int>();
                for (int j = 0; j < source.Count; j++)
                {
                    if (source[j] == input[i]) indices.Add(j);
                }
                if (indices.Count == occurencesNumber)
                {
                    for (int k = indices.Count-1; k > -1; k--) source.RemoveAt(indices[k]);
                }
            }
            return source.ToArray();
        }
        static void Main(string[] args)
        {
            try
            {
                // Sample input 1: 2 2 0 4 -6 3 3 3 4 2 7 56 0
                // Sample input 2: 3 2 2 0 4 -6 3 3 3 4 2 72 72

                // Input
                Console.Write("Enter array of integers, separated by a space: ");
                int[] A = Task_05.Utils.ConvertStringToIntegerArr(Console.ReadLine());

                // Calculation
                int[] B = RemoveArrayDupes(A);
                int n = B.Length;

                // Expected output 1:
                // Transformed array: 2 2 - 6 3 3 3 2 7 56
                // Transformed array length: 9

                // Expected output 2:
                // Transformed array: 3 2 2 0 - 6 3 3 3 2
                // Transformed array length: 9

                // Output
                Console.WriteLine("Transformed array: " + String.Join(" ", B));
                Console.WriteLine("Transformed array length: " + n);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input: entered values must be valid integer numbers separated by an ordinary space");
            }
        }
    }
}
