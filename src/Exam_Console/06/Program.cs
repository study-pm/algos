/* Вывести таблицу стоимости (цена 1кг задается во время работы),
 * например, яблок в диапазоне от А грамм до В грамм с шагом С грамм.
 */

using System.Globalization;

namespace Console_06
{
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
                double price = double.Parse(Console.ReadLine());

                Console.Write("Enter weight range in grams separated by a space: ");
                double[] range = CheckAndFixRange(ParseRange(Console.ReadLine()));

                Console.Write("Enter weight step in grams: ");
                double step = double.Parse(Console.ReadLine());

                if (price < 0 || range[0] < 0 || range[1] < 0 || step < 0) throw new Exception("Must be a non-negative number");

                Console.WriteLine(Environment.NewLine + "Weight (g) \t Price (r)");

                double acc = range[0];
                while (acc <= range[1])
                {

                    var formatted = String.Format(cultureInfo, "{0:C}", acc * price / 1000);
                    Console.WriteLine("{0:n} \t {1}", acc, formatted);
                    acc += step;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}
