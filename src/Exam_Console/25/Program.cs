/* Одноклеточная амёба каждые 3 часа делится на 2 клетки.
 * Определить, сколько амёб будет через 3, 6, 9, 12, …, 24 часа.
 */

namespace Console_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divisionRate = 2; // cells
            int divisionStep = 3; // hours

            int initialCount = 1;
            int timeFrame = 24;

            int totalCount = initialCount;

            // Loop
            for (int i = 3; i <= timeFrame; i += divisionStep)
            {
                totalCount *= 2;
                Console.WriteLine($"Quantity after {i} h: {totalCount}");
            }

            Console.WriteLine(Environment.NewLine);

            // Recursion
            void AmoebaSplit(int frame, int step, int count, int timeLimit)
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
