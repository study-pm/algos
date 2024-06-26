/* Вывести таблицу степеней числа два от нулевой до n, где n вводится  пользователем */

namespace Console_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // By default, the console uses the 850 code page or the 437 code page, which don't support that character.
            // It's trying to display the "infinity" symbol (∞),
            // but on your system it appears to just display ? to show that it's not a supported character.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // https://stackoverflow.com/questions/73218845/why-do-i-get-question-mark-in-console-instead-of-a-double-value-nan-and-what-d
            try
            {
                Console.Write("Enter a non-negative integer number: ");
                uint n = uint.Parse(Console.ReadLine());

                uint baseNumber = 2;

                uint[] powers = new uint[n + 1];

                string path = "result.txt";

                File.WriteAllText(path, "=====Result=====\n");

                for (uint i = 0; i < powers.Length; i++)
                {
                    powers[i] = (uint)Math.Pow(baseNumber, i);
                    Console.WriteLine($"{baseNumber}^{i} \t {powers[i]:N0}");
                    File.AppendAllText(path, $"{baseNumber}^{i} \t {powers[i]:N0}\n");
                }

                string[] result = File.ReadAllLines(path);
                foreach (string line in result)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);

                string[] error =
                {
                    "Timestamp: " + DateTime.Now,
                    "Error: Invalid input",
                    "Type: " + exc.GetType().Name,
                    "Message: " + exc.Message,
                    "Stack trace: " + exc.StackTrace,
                };
                string path = "error.txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (string line in error)
                    {
                        sw.WriteLine(line);
                    }
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }

        }
    }
}
