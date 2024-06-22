/* Вывести 	минимальное число из вводимой с клавиатуры последовательности чисел.
 * Признаком конца ввода является число 9999.
 */


namespace Console_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int min = int.MaxValue;
                int count = 0;

                Console.WriteLine("Enter integer numbers one by one, to end series enter 9999");
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n == 9999) break;
                    count++;
                    if (n < min) min = n;
                }

                if (count == 0) Console.WriteLine("The series has 0 items, hense no minimum value");
                else Console.WriteLine("The mininum of the series is {0}", min);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
            }
        }
    }
}
