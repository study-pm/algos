namespace Task_02
{
    internal class Program
    {
        /// <summary>
        /// Gets time period of day depending on hour
        /// </summary>
        /// <param name="h">Hour</param>
        /// <returns>Name (string representation) of time period</returns>
        static string GetTimeOfDay(int h)
        {
            switch(h)
            {
                case var _ when h >= 0 && h < 7:
                    return "Night";
                case var _ when h >= 7 && h <= 11:
                    return "Morning";
                case var _ when h >= 12 && h < 17:
                    return "Afternoon";
                case var _ when h >= 17 && h <= 23:
                    return "Evening";
                default:
                    return "Error";
            }
        }
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter current time in hours: ");
            int h = Convert.ToInt32(Console.ReadLine());

            // Calculation
            string t = GetTimeOfDay(h);

            // Output
            Console.WriteLine(t);
        }
    }
}
