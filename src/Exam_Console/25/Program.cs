/* Одноклеточная амёба каждые 3 часа делится на 2 клетки.
 * Определить, сколько амёб будет через 3, 6, 9, 12, …, 24 часа.
 */

namespace Console_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint divisionRate = 2; // cells
            uint divisionStep = 3; // hours

            uint initialCount = 1;
            uint timeFrame = 24;

            uint totalCount = initialCount;

            // Loop
            for (uint i = 3; i <= timeFrame; i += divisionStep)
            {
                totalCount *= 2;
                Console.WriteLine($"Quantity after {i} h: {totalCount}");
            }

            Console.WriteLine(Environment.NewLine);

            // Recursion
            void AmoebaSplit(uint frame, uint step, uint count, uint timeLimit)
            {
                count *= 2;
                frame += step;
                Console.WriteLine($"Number of cells in {frame} h is {count}");
                if (frame < timeLimit) AmoebaSplit(frame, step, count, timeLimit);
            }

            AmoebaSplit(0, 3, 1, 24);
        }
    }
}
