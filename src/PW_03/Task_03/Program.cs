namespace Task_03
{
    internal class Program
    {
        /// <summary>
        /// Checks if number is even
        /// </summary>
        /// <param name="x">Number</param>
        /// <returns>True if number is even, False if number is odd</returns>
        static bool CheckIfEven(int x)
        {
            return x % 2 == 0;
        }
        /// <summary>
        /// Checks if number is positive
        /// </summary>
        /// <param name="x">Number</param>
        /// <returns>True if number is positive, False if number is negative, Null if number is zero</returns>
        static bool? CheckIfPositive(int x)
        {
            if (x > 0) return true;
            else if (x < 0) return false;
            return null;
        }
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter integer number: ");
            int x = int.Parse(Console.ReadLine());

            // Calculation
            bool? isPositive = CheckIfPositive(x);
            string s = isPositive == null
                ? "Zero number."
                : $"{((bool)isPositive ? "Positive" : "Negative")} {(CheckIfEven(x) ? "even" : "odd")} number."
            ;

            // Output
            Console.WriteLine(s);
        }
    }
}
