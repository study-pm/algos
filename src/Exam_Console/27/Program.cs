/* Вычислить m = min(x+y^2, y+z^2) + 1 */

namespace Console_27
{
    internal class Program
    {
        static double Min(double a, double b)
        {
            return a < b ? a : b;
        }
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

                double m = Math.Min(x + y * y, y + z * z) + 1;

                double m1 = Min(x + Math.Pow(y, 2), y + Math.Pow(z, 2)) + 1;

                Console.WriteLine($"m = {m:N2}, m1 = {m1:.##}");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
            }
        }
    }
}
