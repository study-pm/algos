/* Вычислить стоимости покупки с учетом скидки.
 * Скидка в 3% предоставляется, если сумма покупки больше 1000 руб.,
 * в 5% - если сумма больше 5000 руб.,
 * в 10% - если сумма больше 10000 руб.
 */

// Task 10

using System.Globalization;

namespace Console_26
{
    internal class Program
    {
        public static double GetDiscount(double amt)
        {
            return amt switch
            {
                > 10_000    => 0.1,
                > 5_000     => 0.05,
                > 1_000     => 0.03,
                _           => 0
            };
        }
        public static string GetErrMsg(string input)
        {
            return $"The input string '{input}' was not in a correct format. Must be a non-negative integer number";
        }
        static void Main(string[] args)
        {
            // Console output setup
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("ru-RU");
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                Console.Write("Enter purchase amount without discount: ");
                double amt = double.Parse(Console.ReadLine());
                if (amt < 0) throw new FormatException(GetErrMsg(amt.ToString()));

                double discount = GetDiscount(amt);

                string formatted = string.Format(cultureInfo, "{0:C2}", amt * (1 - discount));

                Console.WriteLine("Purchase amount with discount {0:P0} is: {1}", discount, formatted);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
