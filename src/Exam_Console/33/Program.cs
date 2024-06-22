/* Вычислить m = max(x+y^2, y+z^2) + 1. */

namespace Console_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number x: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Enter number y: ");
                double y = double.Parse(Console.ReadLine());

                Console.Write("Enter number z: ");
                double z = double.Parse(Console.ReadLine());

                double m = Math.Max(x + y * y, y + z * z) + 1;

                Console.WriteLine("m = {0:.##}", m);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
            }
        }
    }
}
