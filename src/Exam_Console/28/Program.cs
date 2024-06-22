/* Дана заштрихованная область и точка с координатами x, y (рисунок 2).
 * Определить, попадает ли данная точка в  заштрихованную область.
 * Результат вывести в виде текстового сообщения.
 */

namespace Console_28
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

                string position = "on the edge of";

                if (x * x + y * y < 25 && y > 0) position = "inside";
                else if (x * x + y * y > 25 || y < 0) position = "outside";

                Console.WriteLine($"Point with coordinates ({x}, {y}) is {position} the shaded region.");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
            }
        }
    }
}
