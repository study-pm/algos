/* Перевести время из минут и секунд в секунды.
 * Должна осуществляться проверка правильности введенных пользователем данных,
 * и в случае, если данные неверные, выводить соответствующее сообщение
 */

using System.ComponentModel;

namespace Console_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter minutes and seconds separated by a colon symbol (\":\")");
                string input = Console.ReadLine();

                TimeSpan parsed = TimeSpan.Parse("00:" + input);

                // Doesn't handle the case of mins or seconds exceeding 60
                // TimeOnly time = new TimeOnly(0, 6, 2);
                TimeSpan span = new TimeSpan(0, 66, 2);

                Console.WriteLine(Environment.NewLine + "Total seconds: " + parsed.TotalSeconds);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}
