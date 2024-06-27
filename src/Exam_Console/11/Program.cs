/* Даны целые числа А, В.
 * Если числа не равны, то заменить каждое из них одним и тем же числом, равным большему из исходных,
 * а если равны, то заменить числа нулями.
 */

using System.Globalization;

namespace Console_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Enter integer number";

            CultureInfo ci = CultureInfo.GetCultureInfo("ru-RU");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Console.Write(msg + " A: ");
                int A = int.Parse(Console.ReadLine());

                Console.Write(msg + " B: ");
                int B = int.Parse(Console.ReadLine());

                if (A == B)
                {
                    A = B = 0;
                }
                else
                {
                    int max = Math.Max(A, B);
                    int maximum = A > B ? A : B;
                    A = B = max;
                }

                TextWriter oldOut = Console.Out;
                string path = "result.txt";
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Unicode))
                {
                    sw.WriteLine("*****Result*****");
                    Console.SetOut(sw);
                    Console.WriteLine($"A = {A}");
                    Console.WriteLine($"B = {B}");
                }
                Console.SetOut(oldOut);

                Console.WriteLine($"A = {A}, B = {B}");

                Console.WriteLine("\nReading from file");
                using StreamReader sr = new StreamReader(path);
                {
                    while (sr.Peek() >= 0)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine("Invalid input: " + exc.Message);

                string path = @"error.log";
                TextWriter oldErr = Console.Error;
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine("=====Error log=====");
                    Console.SetError(sw);
                    Console.Error.WriteLine("Timestamp: " + DateTime.Now.ToString(ci));
                    Console.Error.WriteLine("Exception Type: " + exc.GetType().Name);
                    Console.Error.WriteLine("Message: " + exc.Message);
                    Console.Error.WriteLine("Stack trace: " + exc.StackTrace);
                }
                Console.SetError(oldErr);

                Console.Error.Write("Further details are available in \"error.log\" file. Do you want to open it (type y|n)? ");
                System.ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == System.ConsoleKey.Y)
                {
                    Console.Error.WriteLine(Environment.NewLine);
                    using StreamReader sr = new StreamReader(path);
                    {
                        while (sr.Peek() >= 0)
                        {
                            Console.Error.WriteLine(sr.ReadLine());
                        }
                    }
                }
            }
        }
    }
}
