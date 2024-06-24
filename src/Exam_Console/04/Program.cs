/* Вычислить стоимость поездки на автомобиле на дачу (туда и обратно).
 * Исходными данными являются: расстояние до дачи (км);
 * количество бензина, которое потребляет автомобиль на 100 км пробега;
 * цена 1 литра бензина.
 */

using System.Globalization;
using System.Runtime.CompilerServices;

namespace Console_04
{
    internal struct NonNegative
    {
        public double Value { get; set; }
        public NonNegative(double val)
        {
            Value = val;
        }
        public override string ToString() => Value.ToString();
        public static implicit operator double(NonNegative val) => val.Value;
        public static implicit operator NonNegative(double val) => new NonNegative(val);
        public static NonNegative Parse(string s)
        {
            double res = double.Parse(s);
            if (res < 0) throw new FormatException($"The input string {s} was not in a correct format. Must be a non-negative value.");
            return new NonNegative(res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup console output
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            CultureInfo ci = CultureInfo.GetCultureInfo("ru-RU");

            try
            {
                Console.Write("Enter distance in km: ");
                NonNegative distance = NonNegative.Parse(Console.ReadLine());
                Console.Write("Enter gas consumption in l/100km: ");
                NonNegative consumption = NonNegative.Parse(Console.ReadLine());
                Console.Write("Enter gas price for 1 liter in roubles: ");
                NonNegative price = NonNegative.Parse(Console.ReadLine());

                double cost = distance * consumption / 100 * price * 2;

                Console.WriteLine("Trip cost (hin und zurück): {0:.##}", cost);

                string path = "result.txt";
                File.WriteAllText(path, cost.ToString());
                string resOut = File.ReadAllText(path);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);

                string path = "error.txt";
                string[] errTxt =
                {
                    "Time: " + DateTime.Now.ToString(ci),
                    "Error: Invalid input",
                    "Type: " + exc.GetType().Name,
                    "Message: " + exc.Message,
                    "Stack trace: " + exc.StackTrace,
                };

                File.WriteAllLines(path, errTxt);

                string[] errOut = File.ReadAllLines(path);
            }
        }
    }
}
