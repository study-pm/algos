using Task_03;

namespace Task_04
{
    internal class ExpressionValue
    {
        /// <summary>
        /// Get product of expression: x(x - n)(x - 2n)(x - 3n)...(x - n^2)
        /// </summary>
        /// <param name="x">real number</param>
        /// <param name="n">natural number</param>
        /// <returns>product of expression</returns>
        static double GetProduct(double x, int n)
        {
            double product = x;
            for (int i = 1, j = n, k = (int)Math.Pow(n, 2); j <= k; i++, j = i * n)
            {
                product *= (x - j);
            }
            return product;
        }
        static void Main(string[] args)
        {
            try
            {
                // Input
                Console.Write("Enter x (must be a real number): ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter n (must be a natural number): ");
                int n = Task_03.ReverseNumber.ParseNatural(Console.ReadLine());

                // Calculation
                double y = GetProduct(x, n);

                // Output
                Console.WriteLine(y);
            }
            catch (Exception e)
            {
                if (e.Message == "not a natural number")
                {
                    Console.WriteLine("Invalid input: n must be a natural number");
                }
                else
                {
                    Console.WriteLine("Invalid input: x must be a real number");
                }
            }
        }
    }
}
