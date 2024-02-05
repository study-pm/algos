/* Требуется определить, бьет ли ладья, стоящая на клетке с указанными координатами (номер строки и номер столбца), фигуру, стоящую на другой указанной клетке. 
 * Вводятся четыре числа: координаты ладьи (два числа) и координаты другой фигуры (два числа), каждое число вводится в отдельной строке.
 */

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter rook x coordinate (must be integer): ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter rook y coordinate (must be integer): ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another figure x coordinate (must be integer): ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Enter another figure y coordinate (must be integer): ");
            int y2 = int.Parse(Console.ReadLine());

            // Calculation
            bool a = x1 == x2 || y1 == y2;

            // Output
            Console.Write($"Rook does{(a ? "" : "n't")} beat another figure.");
        }
    }
}
