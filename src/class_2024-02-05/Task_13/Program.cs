/* Заданы два массива А и В. Написать программу нахождения элементов, общих для А и В.
 */

namespace Task_13
{
    internal class Program
    {
        /// <summary>
        /// Get common items of two arrays without doubles
        /// </summary>
        /// <param name="input1">Array 1</param>
        /// <param name="input2">Array 2</param>
        /// <returns>Arrays 1 and 2 intersection</returns>
        static string[] GetArrayIntersection(string[] input1, string[] input2)
        {
            // Initialize empty array
            string[] result = Array.Empty<string>();

            foreach (string outerItem in input1)
            {
                foreach (var innerItem in input2)
                {
                    if (outerItem == innerItem && Array.IndexOf(result, outerItem) == -1)
                    {
                        Array.Resize(ref result, result.Length+1);
                        result[result.Length-1] = outerItem;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] A = new string[] { "12.2", "rep", "87", "abc", "2,18", "val_2", "15", "val_2", "7" };
            string[] B = new string[] { "99", "3a3b", "val_2", "p1", "val2", "16", "s", "2.18", "7", "rep" };

            // Calculation
            string[] I = GetArrayIntersection(A, B);

            // Output
            Console.WriteLine("Array A: " + String.Join(' ', A));
            Console.WriteLine("Array B: " + String.Join(' ', B));
            Console.WriteLine("Intersection of A and B (w/o doubles): " + String.Join(' ', I));
        }
    }
}
