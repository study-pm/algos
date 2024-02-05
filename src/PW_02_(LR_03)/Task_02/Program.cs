/* Написать программу, определяющую по введенному пользователем году и номеру месяца:
 * – является ли введенный пользователем год високосным;
 * – сколько дней в месяце.
 *
 * При выполнении учитывать, что год является високосным, если он кратен 4 и не кратен 100 или если он кратен 400.
 */

namespace Task_02
{
    internal class Program
    {
        static bool CheckIfLeap(int y)
        {
            if (y % 400 == 0) return true;
            else if (y % 4 == 0 && y % 100 != 0) return true;
            return false;
        }
        static int GetDaysQuantity(int m, int y)
        {
            // February case
            if (m == 2) return CheckIfLeap(y) ? 29 : 28;

            // Rest months
            return 30 + (m + m / 8) % 2;
        }
        static void Main(string[] args)
        {
            int m, y;

            // User input
            Console.Write("Enter year: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month number (starting from 1, no leading zeroes): ");
            bool isValidMonth = int.TryParse(Console.ReadLine(), out m);

            // Calculation
            bool l = CheckIfLeap(y);

            // Output
            Console.WriteLine($"Year {y} is {(l ? "" : "not")} leap.");

            if (isValidMonth && m > 0 && m < 13)
            {
                // Calculation
                int n = GetDaysQuantity(m, y);

                System.Globalization.DateTimeFormatInfo mfi = new System.Globalization.DateTimeFormatInfo();
                Console.WriteLine($"There are {n} day{(n.ToString().Last() == '1' ? "" : "s")} in {mfi.GetMonthName(m)} of {y}.");
            }
            else
            {
                Console.WriteLine("Invalid month number, must be an integer in range between 1 and 12 inclusively");
            }
        }
    }
}
