/* Составить программу вычисления квадратного уравнения ax^2+bx+c. Коэффициенты a,b,c вводятся с клавиатуры.
 */

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter quadratic coefficient (a): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter linear coefficient (b): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter constant coefficient (free term) (c): ");
            double c = double.Parse(Console.ReadLine());

            // Calculation
            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d))/(2 * a);
                double x2 = (-b - Math.Sqrt(d))/(2 * a);
                Console.WriteLine($"Quadratic equantion has two solutions: {x1.ToString("N2")} and {x2.ToString("N2")}.");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Quadratic equantion has one solution: {x.ToString("N2")}.");
            }
            else
            {
                Console.WriteLine("Quadratic equantion has no solutions.");
            }
        }
    }
}
