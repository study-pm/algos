/* Проверить, входит ли цифра М в десятичную запись четырёхзначного числа А.
 * Цифра M и число A вводятся пользователем.
 */

namespace Console_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Однозначным называется такое натуральное число, которое записывается с помощью одной цифры.
            // Многозначным называется такое натуральное число, которое записывается с помощью двух и более цифр.
            // https://tenchat.ru/media/2378667-itak-suschestvuyut-limnogoznachnyye-chisla
            string msg = "Must be a 4-digits natural number";
            try
            {
                Console.Write($"Enter number A ({msg}): ");
                string A = Console.ReadLine();
                int a = int.Parse(A);

                // To handle cases with leading zeroes giving correct string length but invalid digits quantity (like "0123")
                // https://stackoverflow.com/questions/4483886/how-can-i-get-a-count-of-the-total-number-of-digits-in-a-number
                double check = Math.Floor(Math.Log10(a) + 1);

                Console.WriteLine("Number of digits is: " + check);
                if (A.Length != 4 || a < 1 || check != 4) throw new FormatException(msg);

                Console.Write("Enter digit M: ");
                string B = Console.ReadLine();
                int b = int.Parse(B);
                if (B.Length != 1) throw new FormatException("Must be a digit");

                bool contains = false;
                // Way 1
                if (A.Contains(B)) contains = true;

                // Way 2
                int n = a;
                while (n != 0)
                {
                    if (n % 10 == b)
                    {
                        contains = true;
                        break;
                    }
                    n /= 10;
                }

                Console.WriteLine($"Number {A} {(contains ? "contains" : "does not contain")} digit {B}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
