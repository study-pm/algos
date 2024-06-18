/* Идет k-я секунда суток.
 * Определить, сколько целых часов (Н) и целых минут (М) прошло с начала суток.
 */

namespace Console_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int k = (int)(now - now.Date).TotalSeconds;
            // int k = (int)now.Subtract(now.Date).TotalSeconds;

            Console.WriteLine(k);

            int H = k / 60 / 60;
            int M = k % 3600 / 60;

            Console.WriteLine("{0} hour and {1} minutes elapsed from the beginning of the day", H, M);
        }
    }
}
