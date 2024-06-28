/* Если целое число М делится нацело на целое число N,
 * то вывести на экран частное от деления,
 * в противном случае сообщение «М на N не делится».
 */

using System.Globalization;

namespace Console_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.GetCultureInfo("ru-RU");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Console.Write("Enter integer M: ");
                int M = int.Parse(Console.ReadLine());

                Console.Write("Enter integer N: ");
                int N = int.Parse(Console.ReadLine());

                if (M % N == 0) Console.WriteLine("Quotient is: " + M / N);
                else Console.WriteLine("M is not divisble by N.");

                string path = "result.txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    string pad = new string('*', 10);
                    sw.WriteLine(pad + "Result" + pad);
                    sw.WriteLine("M: " + M);
                    sw.WriteLine("N: " + N);
                    sw.WriteLine($"M is{(M % N == 0 ? " " : " not ")}divisible by N.");
                    if (M % N == 0) sw.WriteLine("Quotient: " + M / N);
                }

                string[] res = File.ReadAllLines(path);
                Console.WriteLine("*****Reading from file*****");
                foreach (string line in res)
                {
                    Console.WriteLine($"{line}");
                }
            }
            catch (Exception exc)
            {
                TextWriter oldErr = Console.Error;
                string path = "error.log";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    string pad = new string('=', 10);
                    sw.WriteLine(pad + "Error Log" + pad);
                    Console.SetError(sw);
                    string[] err =
                    {
                        "Exception type: " + exc.GetType().Name,
                        "Message:" + exc.Message,
                        "Stack trace: " + exc.StackTrace,
                    };
                    foreach (string line in err) Console.Error.WriteLine(line);
                }

                Console.SetError(oldErr);
                Console.Error.WriteLine("Invalid input: " + exc.Message);
                Console.Error.Write("Further details are available in \"error.log\" file. Do you want to open it (type y|n)? ");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Y)
                {
                    Console.WriteLine(Environment.NewLine);
                    string[] errRes = File.ReadAllLines(path);
                    foreach (string line in errRes) Console.Error.WriteLine(line);
                }
            }
        }
    }
}
