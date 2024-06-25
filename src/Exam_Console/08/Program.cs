/* Определить площадь заштрихованной фигуры (рисунок 1), если известна длина стороны квадрата. */

using System.Globalization;
using System.IO;

namespace Console_08
{
    internal struct NonNegative
    {
        public uint Value {  get; set; }
        public NonNegative(uint value) => Value = value;
        public override string ToString() => Value.ToString();
        public static implicit operator NonNegative(uint value) => new NonNegative(value);
        public static implicit operator uint(NonNegative value) => value.Value;
        public static NonNegative Parse(string s)
        {
            uint parsed = uint.Parse(s);
            if (parsed < 0) throw new FormatException($"The input string {s} was not in the correct format. Must not be less than zero.");
            return new NonNegative(parsed);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.GetCultureInfo("ru-RU");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Console.Write("Enter a: ");
                NonNegative a = NonNegative.Parse(Console.ReadLine());

                double s_outerSquare = a * a;
                double s_innerSquare = Math.Pow(a - a / 5 * 2, 2);
                double s_triangle = s_innerSquare / 2;
                double s_rim = s_outerSquare - s_innerSquare;

                double s = s_rim + s_triangle;

                Console.WriteLine($"Figure square is: {s:#.##}");

                string path = @"result.txt";
                File.WriteAllText(path, s.ToString("N", ci));

                Console.WriteLine("*****Read from file*****");
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (Exception exc)
            {
                Console.Error.WriteLine("Invalid input: " + exc.Message);

                string path = @"error.txt";
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine("Timestamp: " + DateTime.Now.ToString(ci));
                    sw.WriteLine("Type: " + exc.GetType().Name);
                    sw.WriteLine("Message: " + exc.Message);
                    sw.WriteLine("Stack Trace: " + exc.StackTrace);
                }
                Console.Error.WriteLine("=====Read from file=====");
                using (StreamReader sr = new StreamReader(path))
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
