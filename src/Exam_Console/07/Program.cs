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
            uint k = (uint)(now - now.Date).TotalSeconds;
            // int k = (int)now.Subtract(now.Date).TotalSeconds;

            Console.WriteLine(k);

            uint H = k / 60 / 60;
            uint M = k % 3600 / 60;

            Console.WriteLine("{0} hour and {1} minutes elapsed from the beginning of the day", H, M);

            string path = "result.txt";
            FileInfo f = new FileInfo(path);
            StreamWriter sw = new StreamWriter(f.Create());
            sw.WriteLine($"{H} hour(s) and {M} minute(s) elapsed");
            sw.Close();

            Console.WriteLine("\nReading from file");

            StreamReader sr = new StreamReader(f.Open(FileMode.Open));
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
}
