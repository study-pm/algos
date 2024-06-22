/* Подсчитать, сколько очков набрала команда в отборочном турнире,
 * если известно, что m встреч она выиграла,
 * n встреч она проиграла,
 * к  встреч закончились ничьими,
 * полагая, что за выигрыш команда получает 2 очка, за ничью – 1 очко, за проигрыш – 0 очков.
 */

namespace Console_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter win matches count: ");
                byte m = byte.Parse(Console.ReadLine());

                Console.Write("Enter lose matches count: ");
                byte n = byte.Parse(Console.ReadLine());

                Console.Write("Enter tie matches count: ");
                byte k = byte.Parse(Console.ReadLine());

                byte loseScoreRate = 0;
                byte tieScoreRate = 1;
                byte winScoreRate = 2;

                int totalScore = m * winScoreRate + n * loseScoreRate + k * tieScoreRate;

                Console.WriteLine(Environment.NewLine + "Total team score is: " + totalScore);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
