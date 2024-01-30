namespace Task_08
{
    internal class Program
    {
        /// <summary>
        /// Gets change in roubles and copecks
        /// </summary>
        /// <param name="a">Produce price roubles part</param>
        /// <param name="b">Produce price copecks part</param>
        /// <param name="c">Payed amount roubles part</param>
        /// <param name="d">Payed amount copecks part</param>
        /// <param name="e">Change amount roubles part</param>
        /// <param name="f">Change amount copecks part</param>
        /// <returns>True if change is requried, False if insufficient funding, Null if no change is required</returns>
        static bool? GetChange(int a, int b, int c, int d, out int e, out int f)
        {
            double productPrice = a + (double)b / 100;
            double payedAmount = c + d / 100.0;

            decimal change = (decimal)payedAmount - (decimal)productPrice;

            e = (int)change;
            f = (int)(change * 100);

            switch (change)
            {
                case > 0: return true;
                case < 0: return false;
                default: return null;
            }
        }
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter a (product price, roubles part): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b (product price,  copecks part): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter c (payed amount, roubles part): ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter d (payed amount, copecks part): ");
            int d = int.Parse(Console.ReadLine());

            // Calculation
            bool? isChange = GetChange(a, b, c, d, out int e, out int f);

            // Output
            if (isChange == true) Console.WriteLine($"Change is {e} roubles {f} copecks");
            else if (isChange == false) Console.WriteLine($"Insufficient payed amount, add {-e} roubles {-f} copecks");
            else Console.WriteLine("No change required");
        }
    }
}
