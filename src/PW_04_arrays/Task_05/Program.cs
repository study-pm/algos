namespace Task_05
{
    public class Utils
    {
        /// <summary>
        /// Convert string to array of integer numbers
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="separator">Items separator</param>
        /// <returns>Array of integer numbers</returns>
        public static int[] ConvertStringToIntegerArr(string input, string separator = " ")
        {
            string[] strArr = input.Split(separator);
            int[] resArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++) resArr[i] = int.Parse(strArr[i]);
            return resArr;
        }
    }
    internal class Program
    {
        /// <summary>
        /// Get transformed array consisting with series expanded by any given numbers of elements
        /// </summary>
        /// <param name="input">Source array</param>
        /// <param name="addedItemsNumber">Quantity of elements to expand to</param>
        /// <returns>Expanded series array</returns>
        static int[] ExpandArraySeries(int[] input, int addedItemsNumber = 1)
        {
            List<int> result = new List<int>();
            void AddItems(List<int> list, int item, int itemsNumber)
            {
                for (int i = 0; i < itemsNumber; i++) list.Add(item);
            }
            for (int i = 0; i < input.Length-1; i++)
            {
                result.Add(input[i]);
                if (input[i] != input[i+1]) AddItems(result, input[i], addedItemsNumber);
            }
            result.Add(input[input.Length-1]);
            AddItems(result, input[input.Length-1], addedItemsNumber);
            return result.ToArray();
        }
        static void Main(string[] args)
        {
            try
            {
                // Sample input 1: 2 2 0 4 -6 3 3 3 4 2 7 56 0
                // Sample input 2: 3 2 2 0 4 -6 3 3 3 4 2 72 72

                // Input
                Console.Write("Enter array of integers, separated by a space: ");
                int[] A = Utils.ConvertStringToIntegerArr(Console.ReadLine());

                // Calculation
                int[] C = ExpandArraySeries(A, 2);

                // Expected output 1: 2 2 2 0 0 4 4 -6 -6 3 3 3 3 4 4 2 2 7 7 56 56 0 0
                // Expected output 2: 3 3 2 2 2 0 0 4 4 -6 -6 3 3 3 3 4 4 2 2 72 72 72

                // Output
                Console.WriteLine(String.Join(" ", C));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input: entered values must be valid integer numbers separated by an ordinary space");
            }
        }
    }
}
