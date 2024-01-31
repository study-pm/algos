using Task_01;

namespace Task_02
{
    internal class TrailingX
    {
        /// <summary>
        /// Check if input is a valid digit
        /// </summary>
        /// <param name="x">digit</param>
        /// <returns>True if digit, False if not digit</returns>
        static bool CheckIfDigit(int x)
        {
            int[] digits = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return Array.IndexOf(digits, x) != -1;
        }
        /// <summary>
        /// Check if input is a valid digit (another way)
        /// </summary>
        /// <param name="x">digit</param>
        /// <returns>True if digit, False if not digit</returns>
        static bool CheckIfDigit(int x, bool isList)
        {
            List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return digits.Contains(x);
        }
        /// <summary>
        /// Prints all integers with given trailing digit
        /// </summary>
        /// <param name="a">range min value</param>
        /// <param name="b">range max value</param>
        /// <param name="x">trailing digit</param>
        /// <returns>List of all integers with given trailing digit</returns>
        static int[] GetPrintWithTrailingDigit(int a, int b, int x)
        {
            int[] havingTrailingDigit = new int[0];
            for (int i = a; i <= b; i++)
            {
                if (i % 10 == x || i % 10 == -x)
                {
                    Console.Write(i + " ");
                    Array.Resize(ref havingTrailingDigit, havingTrailingDigit.Length+1);
                    havingTrailingDigit[havingTrailingDigit.Length-1] = i;
                }
            }
            return havingTrailingDigit;
        }
        static void Main(string[] args)
        {
            try
            {
                // Input
                Console.Write("Enter integer A: ");
                int A = int.Parse(Console.ReadLine());
                Console.Write("Enter integer B: ");
                int B = int.Parse(Console.ReadLine());
                Console.Write("Enter digit X: ");
                int X = int.Parse(Console.ReadLine());

                // Check X
                if (!CheckIfDigit(X)) throw new Exception("not a digit");

                // Check and fix range borders
                Task_01.AliquotOf3.NormalizeBorders(A, B, out int a, out int b);

                // Calculation
                int[] M = GetPrintWithTrailingDigit(a, b, X);
            }
            catch (Exception e)
            {
                if (e.Message == "not a digit") Console.WriteLine("X value must be a valid decimal digit in the range between 0 and 9");
                else Console.WriteLine("A and B values must be integers");
            }

        }
    }
}
