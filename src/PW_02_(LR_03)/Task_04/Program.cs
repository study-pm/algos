/* Написать приложение «Конвертер валют».
 * Курс валют (доллары, евро, йены) задать программно, исходную сумму в рублях и требуемую валюту указывает пользователь.
 * На выходе — сумма в валюте, округленная до двух знаков после запятой.
 */

using System.Globalization;

namespace Task_04
{
    internal class Program
    {
        static double ConvertToValue(double amount, string valueCode)
        {
            return amount / GetExchangeRate(valueCode);
        }
        static double GetExchangeRate(string valueCode)
        {
            switch (valueCode)
            {
                case "eur":
                    return 97.16;
                case "jpy":
                    return 0.59;
                case "usd":
                    return 88.70;
                default:
                    return 0;
            }
        }
        static string? ParseValue(string valueCode)
        {
            string v = valueCode.ToLower();
            switch(v)
            {
                case "eur":
                    return "eur";
                case "jpy":
                    return "jpy";
                case "usd":
                    return "usd";
                default:
                    return null;
            }
        }
        static void Main(string[] args)
        {
            // Handle user input
            double a;
            Console.Write("Enter the amount you would like to convert to value (in Russian roubles): ");
            bool isAmountParsed = double.TryParse(Console.ReadLine(), out a);
            if (!isAmountParsed)
            {
                // Handle invalid decimal separator
                string decimalSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                Console.WriteLine("Incorrect amount input: use decimal separator according to your system current culture settings ({0})", decimalSeparator);
                return;
            }

            Console.Write("Enter value code (USD | EUR | JPY): ");

            string? v = ParseValue(Console.ReadLine());

            if (v == null)
            {
                Console.WriteLine("Incorrect value input, acceptable values are: USD | EUR | JPY");
                return;
            }

            // Calculation
            double s = ConvertToValue(a, v);

            // Output
            Console.WriteLine($"You get {s.ToString("N2")} {v.ToUpper()}");

        }
    }
}
