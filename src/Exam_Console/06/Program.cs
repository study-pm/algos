/* Вывести таблицу стоимости (цена 1кг задается во время работы),
 * например, яблок в диапазоне от А грамм до В грамм с шагом С грамм.
 */

using System.Globalization;

namespace Console_06
{
    internal struct NonNegative
    {
        public double Value;
        public NonNegative(double val)
        {
            Value = val;
        }
        public override readonly string ToString() => Value.ToString();
        public static implicit operator NonNegative(double val) {  return new NonNegative(val); }
        public static implicit operator double(NonNegative val) {  return val.Value; }
        public static NonNegative Parse(string s)
        {
            double d = double.Parse(s);
            if (d < 0) throw new FormatException($"The input value {s} was not in a correct format. Must be a non-negative real number.");
            return new NonNegative(d);
        }
        public static NonNegative[] ParseRange(string s)
        {
            string separator = " ";
            if (s.Contains(",")) separator = ",";
            else if (s.Contains(";")) separator = ";";

            string[] input = s.Split(separator, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            NonNegative[] range = new NonNegative[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                range[i] = Parse(input[i]);
            }
            return range;
        }
        public static void NormalizeRange(NonNegative[] input)
        {
            if (input[0] > input[1]) (input[0], input[1]) = (input[1], input[0]);
        }
    }
    internal class Program
    {
        static public double[] ParseRange(string val)
        {
            string[] input = val.Split(' ');
            double[] range = new double[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                range[i] = double.Parse(input[i]);
            }
            return range;
        }
        static public double[] CheckAndFixRange(double[] range)
        {
            if (range[0] > range[1])
            {
                (range[0], range[1]) = (range[1], range[0]);
            }
            return range;
        }
        static void Main(string[] args)
        {
            // Console output setup
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("ru-RU");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Console.Write("Enter apple price for 1kg: ");
                NonNegative price = NonNegative.Parse(Console.ReadLine());

                Console.Write("Enter weight range in grams separated by a space: ");
                string input = Console.ReadLine();
                double[] range = CheckAndFixRange(ParseRange(input));
                NonNegative[] rg = NonNegative.ParseRange(input);
                NonNegative.NormalizeRange(rg);

                Console.Write("Enter weight step in grams: ");
                NonNegative step = NonNegative.Parse(Console.ReadLine());

                Console.WriteLine(Environment.NewLine + "Weight (g) \t Price (r)");

                double acc = range[0];
                while (acc <= range[1])
                {
                    var formatted = String.Format(cultureInfo, "{0:C}", acc * price / 1000);
                    Console.WriteLine("{0:n} \t {1}", acc, formatted);
                    acc += step;
                }

                Console.WriteLine(Environment.NewLine);

                string path = "result.txt";
                File.WriteAllText(path, "Weight (g) \t Cost\n\n");

                acc = rg[0];
                string[] result = Array.Empty<string>();
                do
                {
                    Array.Resize(ref result, result.Length+1);
                    result[result.Length - 1] = acc.ToString("N2") + "\t" + (acc * price / 1000).ToString("C", cultureInfo);
                    acc += step;
                }
                while (acc <= rg[1]);
                File.AppendAllLines(path, result);

                string[] output = File.ReadAllLines(path);
                foreach (string line in output) Console.WriteLine(line);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);

                string path = "error.txt";
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Unicode))
                {
                    sw.WriteLine("Timestamp: " + DateTime.Now.ToString(cultureInfo));
                    sw.WriteLine("Error: Invalid input");
                    sw.WriteLine("Type: " + exc.GetType());
                    sw.WriteLine("Message: " + exc.Message);
                    sw.WriteLine("Stack trace: " + exc.StackTrace);
                }
                Console.WriteLine("Error file contents");
                using (StreamReader sr = new StreamReader(path))
                {
                    while(sr.Peek() >= 0)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
        }
    }
}
