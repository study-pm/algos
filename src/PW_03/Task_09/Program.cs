/* Шахматный ферзь ходит по диагонали, горизонтали или вертикали. 
 * Программа получает на вход четыре числа от 1 до 8 каждое, задающие номер столбца и номер строки сначала для первой клетки, потом для второй клетки. 
 * Определите, может ли ферзь попасть с первой клетки на вторую одним ходом. 
 * В случае, если хотя бы одно из введенных чисел не лежит в диапазоне от 1 до 8, выведите строку "Ошибка!".
 */

namespace Task_09
{
    internal class Program
    {
        /// <summary>
        /// Checks whether queen one step movement from first cell to second one is possible
        /// </summary>
        /// <param name="cells">Jagged array of two cells coordinates</param>
        /// <returns>True if one step movement is possible, False if not</returns>
        static bool CheckIfOneStepIsPossible(int[][] cells)
        {
            return cells[0][0] == cells[1][0]
                || cells[0][1] == cells[1][1]
                || Math.Abs(cells[0][0] - cells[1][0]) == Math.Abs(cells[0][1] - cells[1][1]);
        }
        /// <summary>
        /// Checks if cell coordinate values are valid
        /// </summary>
        /// <param name="cell">Cell coordinates</param>
        static void CheckIfValidCell(int[] cell)
        {
            foreach (int coordinate in cell)
            {
                if (coordinate > 0 && coordinate < 9) continue;
                throw new Exception("Invalid coordinate");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                // Input
                Console.Write("Enter cell 1 coordinates separated by space (x y): ");
                string[] cell1Input = Console.ReadLine().Split(' ');
                Console.Write("Enter cell 2 coordinates separated by space (x y): ");
                string[] cell2Input = Console.ReadLine().Split(' ');

                int[] cell1 = new int[] { int.Parse(cell1Input[0]), int.Parse(cell1Input[1]) };
                int[] cell2 = new int[] { int.Parse(cell2Input[0]), int.Parse(cell2Input[1]) };

                // Validity checks
                int[][] cells = new int[][] { cell1, cell2 };
                foreach (int[] cell in cells) CheckIfValidCell(cell);

                // Calculation
                bool a = CheckIfOneStepIsPossible(cells);

                // Output
                Console.WriteLine($"Queen one step movement from cell 1 to cell 2 is {(a ? "" : "not")} possible");
            }
            catch (Exception e)
            {
                Console.Write("Invalid input: cell coordinates must be ");
                if (e.Message == "Invalid coordinate") Console.Write("between 1 and 8 inclusively.");
                else Console.Write(" integer numbers separated by a space.");
            }
        }
    }
}
