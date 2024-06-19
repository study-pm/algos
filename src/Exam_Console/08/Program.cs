/* Определить площадь заштрихованной фигуры (рисунок 1), если известна длина стороны квадрата. */

namespace Console_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a: ");
                double a = double.Parse(Console.ReadLine());

                if (a < 0) throw new Exception("Must be a non-negative number");

                double s_outerSquare = a * a;
                double s_innerSquare = Math.Pow(a - a / 5 * 2, 2);
                double s_triangle = s_innerSquare / 2;
                double s_rim = s_outerSquare - s_innerSquare;

                double s = s_rim + s_triangle;

                Console.WriteLine($"Figure square is: {s:#.##}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}
