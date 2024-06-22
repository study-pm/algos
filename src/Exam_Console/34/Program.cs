/* Вычислить m = max(x^2+y^2, y^2+z^2) - 4. */

namespace Console_34
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

                double m = Math.Max(x*x + y*y, y*y + z*z) - 4;

                Console.WriteLine("m = {0:.##}", m);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
            }
        }
    }
}
