/* Написать программу, находящую площадь треугольника, если его можно построить по введенным пользователем трем числам (длинам сторон). 
 * Определить вид треугольника.
 *
 * Для вычисления площади S использовать формулу Герона:
 * S=√(p*(p-a)*(p-b)*(p-c)),
 * где р — полупериметр.
 *
 * Результат округлять до двух знаков после запятой.
 * Если треугольник построить нельзя, сообщить об этом пользователю.
 */

namespace Task_03
{
    internal class Program
    {
        static bool CheckIfTriangle(double[] sides)
        {
            if (sides[0] + sides[1] > sides[2] && sides[1] + sides[2] > sides[0] && sides[2] + sides[0] > sides[1]) return true;
            return false;
        }
        static double GetTriangleSquare(double[] sides)
        {
            double p = sides.Sum() / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }
        static string GetTriangleType(double[] sides)
        {
            if (
                Math.Pow(sides[0], 2) > Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2) ||
                Math.Pow(sides[1], 2) > Math.Pow(sides[0], 2) + Math.Pow(sides[2], 2) ||
                Math.Pow(sides[2], 2) > Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)
                )

            {
                return "obtuse";
            }
            else if (
                Math.Pow(sides[0], 2) < Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2) ||
                Math.Pow(sides[1], 2) < Math.Pow(sides[0], 2) + Math.Pow(sides[2], 2) ||
                Math.Pow(sides[2], 2) < Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)
                )
            {
                return "acute";
            }
            return "right";
        }
        static void Main(string[] args)
        {
            // User input
            Console.Write("Enter triangle sides, separated by an ordinary space: ");
            string[] inputArr = Console.ReadLine().Split(' ');
            double[] sides = new double[inputArr.Length];
            for (int i = 0; i < inputArr.Length; i++) sides[i] = double.Parse(inputArr[i]);

            // Check if triangle exists
            if (!CheckIfTriangle(sides))
            {
                Console.WriteLine("Input sides does not make a triangle");
                return;
            }

            // Calculation
            double S = GetTriangleSquare(sides);
            string t = GetTriangleType(sides);

            // Output
            Console.WriteLine($"Triangle square is {S.ToString("N2")}. Triangle is {t}");

        }
    }
}
