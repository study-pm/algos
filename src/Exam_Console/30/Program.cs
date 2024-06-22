/* Вычислить m = min(x^2+y^2, y^2+z^2) - 4 */

namespace Console_30
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

                double m = Math.Min(x * x + y * y, y * y + z * z) - 4;

                Console.WriteLine($"m = {m:G2}");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
            }
        }
    }
}
