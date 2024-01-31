namespace Task_03
{
    public class ReverseNumber
    {
        /// <summary>
        /// Parse a string and convert to a natural number
        /// </summary>
        /// <param name="s">string representing a natural number</param>
        /// <returns>Parsed number</returns>
        /// <exception cref="Exception">Not an integer or natural number</exception>
        public static int ParseNatural(string s)
        {
            int n = int.Parse(s);
            if (n < 1) throw new Exception("not a natural number");
            return n;
        }
        /// <summary>
        /// Reverse digit order in a natural number decimal representation
        /// </summary>
        /// <param name="n">Source natural number</param>
        /// <returns>Reverted natural number</returns>
        static int ReverseNatural(int n)
        {
            int dividend = n;
            int quotient = 0;
            while (dividend != 0)
            {
                quotient *= 10;
                quotient += dividend % 10;
                dividend /= 10;
            }
            return quotient;
        }
        static void Main(string[] args)
        {
            try
            {
                // Input
                Console.Write("Enter a natural number: ");
                int N = ParseNatural(Console.ReadLine());

                // Calculation
                int M = ReverseNatural(N);

                // Output
                Console.WriteLine("Inverted input: " + M);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input: must be a natural number");
            }
        }
    }
}
