namespace Task_05
{
    internal class Program
    {
        /// <summary>
        /// Defines discount fraction depending on purchase amount
        /// </summary>
        /// <param name="x">Purchase amount</param>
        /// <returns>Discount fraction</returns>
        static double GetDiscount(double x)
        {
            if (x > 3000) return 0.05;
            else if (x > 2000) return 0.03;
            return 0;
        }
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter purchase amount: ");
            double x = double.Parse(Console.ReadLine());

            // Calculation
            double y = x * (1 - GetDiscount(x));

            // Output
            Console.WriteLine("Amount considering discount: " + y.ToString("C2"));
        }
    }
}
