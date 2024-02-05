/* Составить программу вычисления квадратного уравнения ax^2+bx+c.
 * Коэффициенты a,b,c вводятся с клавиатуры.
 */

namespace Task_04
{
    internal class Program
    {
        /// <summary>
        /// Get solutions for quadratic equation
        /// </summary>
        /// <param name="a">quadratic coefficient</param>
        /// <param name="b">linear coefficient</param>
        /// <param name="c">constant coefficient (free term)</param>
        /// <returns>array of solutions for quadratic equations</returns>
        static double[]? SolveQuadraticEquation(double a, double b, double c)
        {
            double GetDiscriminant(double a, double b, double c)
            {
                return Math.Pow(b, 2) - 4 * a * c;
            }

            double d = GetDiscriminant(a, b, c);

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                return null;
            }
        }
        static void Main(string[] args)
        {
            // Input
            // Sample Input 1: a = 2; b = -1; c = -15
            // Sample Input 2: a = 1; b = -6; c = 9
            // Sample Input 3: a = 3; b = 1; c = 2
            Console.Write("Enter quadratic coefficient (a): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter linear coefficient (b): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter constant coefficient (free term) (c): ");
            double c = double.Parse(Console.ReadLine());

            // Calculation
            double[]? x = SolveQuadraticEquation(a, b, c);

            // Output
            // Sample Output 1: 3,00; -2.50
            // Sample Output 2: 3,00
            // Sample Output 3: -
            if (x == null)
            {
                Console.WriteLine("Quadratic equantion has no solutions.");
            }
            else if (x.Length == 2) {
                Console.WriteLine($"Quadratic equantion has two solutions: {x[0].ToString("N2")} and {x[1].ToString("N2")}.");
            }
            else {
                Console.WriteLine($"Quadratic equantion has one solution: {x[0].ToString("N2")}.");
            }
        }
    }
}
