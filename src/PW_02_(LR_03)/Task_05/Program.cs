/* Написать программу, запрашивающую сумму покупки и внесенную покупателем сумму.
 * Если сдача не требуется, выводить на экран «Спасибо!»;
 * если денег внесено больше, чем необходимо — «Возьмите сдачу» и указывать сумму сдачи;
 * если денег недостаточно — сообщение об этом и указать размер недостающей суммы.
 *
 * В магазине действует система скидок:
 * 3% предоставляется, если сумма покупки больше 500 рублей, 5% – если сумма больше 1000 рублей.
 */

using System.Globalization;

namespace Task_05
{
    internal class Program
    {
        static double GetAmtWithDiscount(double amount)
        {
            if (amount > 1000)
            {
                return amount * 0.95;
            }
            else if (amount > 500)
            {
                return amount * 0.97;
            }
            return amount;
        }
        static void Main(string[] args)
        {
            try
            {
                // User input
                Console.Write("Enter purchase amount, in Russian roubles: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter amount deposited by customer, in Russian roubles: ");
                double d = Convert.ToDouble(Console.ReadLine());

                // Calculation
                double amt = GetAmtWithDiscount(a);
                double c = d - amt;

                // Output
                if (c == 0)
                {
                    Console.WriteLine("Thank you!");
                }
                else if (c > 0)
                {
                    Console.WriteLine($"Take your change: {c.ToString("N")} RUR.");
                }
                else
                {
                    Console.WriteLine($"Insufficient deposit, please add {(c * -1).ToString("N")} RUR.");
                }
            }
            catch (Exception)
            {

                // Handle invalid decimal separator
                string decimalSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                Console.WriteLine("Incorrect input: use decimal separator according to your system current culture settings ({0})", decimalSeparator);
            }
        }
    }
}
