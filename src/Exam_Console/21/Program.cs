/* Услуги телефонной сети оплачиваются по следующему правилу:
 * за разговоры от А минут в месяц — В рублей,
 * а разговоры сверх установленной нормы оплачиваются из расчета С рублей за минуту.
 * Вычислить плату за пользование телефоном для введенного времени разговоров за месяц.
 */

using System.Globalization;

namespace Console_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console output setup
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("ru-RU");
            // Correct display russian rouble symbol
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            try
            {
                string msg = "Must be a valid non-negative integer";
                Console.Write($"Enter monthly phone time limit A in minutes ({msg}): ");
                uint lmtA = uint.Parse(Console.ReadLine());

                Console.Write($"Enter rate B in roubles ({msg}): ");
                uint rateB = uint.Parse(Console.ReadLine());

                Console.Write($"Enter rate C (for extra time) in roubles ({msg}): ");
                uint rateC = uint.Parse(Console.ReadLine());

                Console.Write($"Enter actual monthly phone time in time format (hh:mm): ");
                TimeSpan time = TimeSpan.Parse(Console.ReadLine());

                uint totalTime = (uint)time.TotalMinutes;
                uint inTime;
                uint extraTime;

                if (totalTime < lmtA)
                {
                    inTime = totalTime;
                    extraTime = 0;
                }
                else
                {
                    inTime = lmtA;
                    extraTime = totalTime - inTime;

                }

                uint totalCharge = inTime * rateB + extraTime * rateC;

                string formatted = string.Format(cultureInfo, "{0:C2}", totalCharge);

                Console.WriteLine("Total monthly charge is: {0}", formatted);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}

/* Sample data
 * A = 60
 * B = 100
 * C = 150
 * actual = 2:22
 * totalCharge = 6 000 + 12 300 = 18 300,00 ₽
 */
