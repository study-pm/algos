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
        public static string GetErrMsg(int input)
        {
            return $"The input string '{input}' was not in a correct format. Must be a non-negative integer number";
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter win matches count: ");
                int m = int.Parse(Console.ReadLine());
                if (m < 0) throw new FormatException(GetErrMsg(m));

                Console.Write("Enter lose matches count: ");
                int n = int.Parse(Console.ReadLine());
                if (n < 0) throw new FormatException(GetErrMsg(n));

                Console.Write("Enter tie matches count: ");
                int k = int.Parse(Console.ReadLine());
                if (k < 0) throw new FormatException(GetErrMsg(k));

                int loseScoreRate = 0;
                int tieScoreRate = 1;
                int winScoreRate = 2;

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
