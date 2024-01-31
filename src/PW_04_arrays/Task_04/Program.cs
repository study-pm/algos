namespace Task_04
{
    internal class Program
    {
        /// <summary>
        /// Removes duplicated values in array
        /// </summary>
        /// <param name="input">Source array</param>
        /// <returns>Array without duplicated values</returns>
        static string[] RemoveArrayDoubles(string[] input)
        {
            List<string> result = new List<string>();
            foreach (string item in input)
            {
                if (!result.Contains(item)) result.Add(item);

            }
            return result.ToArray();
        }
        /// <summary>
        /// Get two arrays difference
        /// </summary>
        /// <param name="minuend">First array</param>
        /// <param name="subtrahend">Second array</param>
        /// <param name="isAlt">Flag signifying alternative way</param>
        /// <returns>Arrays difference</returns>
        static string[] SubtractArrays(string[] minuend, string[] subtrahend)
        {
            List<string> diff = new List<string>();
            foreach (string item in minuend)
            {
                bool isFound = false;
                for (int i = 0; i < subtrahend.Length; i++)
                {
                    if (item == subtrahend[i])
                    {
                        isFound = true;
                        break;
                    }
                }
                if (isFound) continue;
                diff.Add(item);
            }
            return diff.ToArray();
        }
        static string[] SubtractArrays(string[] minuend, string[] subtrahend, bool isAlt = true)
        {
            List<string> diff = new List<string>();
            foreach (string item in minuend)
            {
                if (Array.IndexOf(subtrahend, item) == -1) diff.Add(item);
            }
            return diff.ToArray();
        }
        static void Main(string[] args)
        {
            // Sample input (line 1): 12.2 rep 87 abc 2,18 val2 15 val2 7
            // Sample input (line 2): 99 3a3b p1 16 s 2.18 7 , rep

            // Input
            Console.Write("Enter array A values separated by a space: ");
            string[] A = Console.ReadLine().Split(" ");
            Console.Write("Enter array B values separated by a space: ");
            string[] B = Console.ReadLine().Split(" ");

            // Calculation
            string[] C = RemoveArrayDoubles(SubtractArrays(A, B, true));
            string[] D = RemoveArrayDoubles(SubtractArrays(B, A));

            // Expected output (line 1) : 12.2 87 abc 2,18 val2 15
            // Expected output (line 2) : 99 3a3b p1 16 s 2.18 ,

            // Output
            Console.WriteLine(String.Join(' ', C));
            Console.WriteLine(String.Join(' ', D));
        }
    }
}
