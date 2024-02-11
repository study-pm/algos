/* Определить, какие элементы массива А и сколько раз встречаются в массиве В.
 */

namespace Task_14
{
    internal class Program
    {
        /// <summary>
        /// Get two arrays common values and occurences count
        /// </summary>
        /// <param name="arr1">Array 1</param>
        /// <param name="arr2">Array 2</param>
        /// <returns>Array of (value, count) tuples</returns>
        static (string, int)[] GetArrayCommonValuesOccurences(string[] arr1, string[] arr2)
        {
            string[] values = Array.Empty<string>();
            int[] count = Array.Empty<int>();

            foreach (string item in arr1)
            {
                // Check arr1 doubles and ignore them
                if (Array.IndexOf(values, item) != -1) continue;

                int index = Array.IndexOf(arr2, item);
                if (index == -1) continue;

                Array.Resize(ref values, values.Length+1);
                Array.Resize(ref count, count.Length+1);
                count[count.Length-1] = 0;
                while (index != -1)
                {
                    values[values.Length-1] = item;
                    count[count.Length-1]++;
                    index = Array.IndexOf(arr2, item, index+1);
                }
            }

            // Form resulting tuples array
            (string, int)[] result = new (string, int)[values.Length];
            for (int i = 0; i < result.Length; i++) result[i] = (values[i], count[i]);

            return result;
        }
        static void Main(string[] args)
        {
            string[] A = new string[] { "12.2", "rep", "87", "abc", "2,18", "val_2", "15", "val_2", "7" };
            string[] B = new string[] { "99", "3a3b", "val_2", "p1", "val2", "rep", "16", "s", "2.18", "7", "rep" };

            // Calculation
            (string, int)[] arrayIntersection = GetArrayCommonValuesOccurences(A, B);

            // Output
            Console.WriteLine("Array A: " + String.Join(' ', A));
            Console.WriteLine("Array B: " + String.Join(' ', B));
            Console.WriteLine("Common items of A and B and occurences count tuples: " + String.Join(' ', arrayIntersection));
        }
    }
}
