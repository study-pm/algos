/* Вывести максимальное число из вводимой с клавиатуры последовательности чисел.
 * Признаком конца ввода является число 9999.
 */


namespace Console_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int count = 0;

            Console.WriteLine("Enter integer numbers one by one, to end series enter 9999");

            try
            {
                for (; ; )
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n == 9999) break;
                    if (max < n) max = n;
                    count++;
                }

                if (count == 0) Console.WriteLine("Series has no items, hense no maximum value.");
                else Console.WriteLine("Series maximum value is {0}", max);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Invalid input: " + exc.Message);
            }
        }
    }
}
