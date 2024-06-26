/* Вывести значения функции у = х^3 при х = 8, 7.5, …, 2. */

using System.Globalization;

namespace Console_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.GetCultureInfo("ru-RU");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            TextWriter oldOut = Console.Out;

            using StreamWriter sW = new(@"output.txt");
            {
                Console.SetOut(sW);
                Console.WriteLine("Sample output");
            }

            Console.SetOut(oldOut);

            double[] range = { 8, 2 };
            double step = 0.5;

            string path = @"result.txt";

            Console.WriteLine("{0, 5} |\t {1, 6}", "x", "y");
            Console.WriteLine(new string('—', 15));
            string[] headerLines = { "x \t y", new string('—', 15) };
            File.WriteAllLines(path, headerLines);

            double[] result = Array.Empty<double>();

            double x = 8;
            while (x >= 2)
            {
                double y = Math.Pow(x, 3);
                Array.Resize(ref result, result.Length+1);
                result[result.GetUpperBound(0)] = y;
                Console.WriteLine("{0, 5} |\t {1, 6}", string.Format("{0:N1}", x), string.Format("{0:N2}", y));
                string res = $"{x} \t {y.ToString("N", ci)}";
                File.AppendAllText(path, res + Environment.NewLine);
                x -= step;
            }

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach(double val in result) sw.WriteLine(val);
            }
        }
    }
}
