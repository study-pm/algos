/* Дана заштрихованная область и точка с координатами х, у (рисунок 3).
 * Определить, попадает ли данная точка  в  заштрихованную область.
 * Результат вывести в виде текстового сообщения.
 */

namespace Console_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter point x coordinate: ");
                float x = float.Parse(Console.ReadLine());

                Console.Write("Enter point y coordinate: ");
                float y = float.Parse(Console.ReadLine());

                // Circle equation: x^2 + y^2 = r^2

                float c = (float)Math.Pow(x, 2) + (float)Math.Pow(y, 2);

                string position = "on the edge of";

                if (c > 25 && x < 10 && x > 0 && y > 0) position = "inside";
                else if (c < 25 || x > 10 || x < 0 || y < 0) position = "outside";

                Console.WriteLine($"Point with coordinates ({x}, {y}) is {position} the shaded region.");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
            }
        }
    }
}
