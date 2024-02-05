/* Массив содержит 2n чисел.
 * Из суммы первых n его элементов вычесть сумму последних n элементов.
 */

namespace Task_05
{
    internal class Program
    {
        static bool CheckIfNotNegativeInt(string input, out int n)
        {
            bool isInt = int.TryParse(input, out int number);
            isInt = isInt && number >= 0;
            n = number;
            return isInt;
        }
        static void Main(string[] args)
        {
            try
            {
                // Input
                Console.Write("Enter an integer not negative number: ");
                string input = Console.ReadLine();
                int n;
                if (!CheckIfNotNegativeInt(input, out n)) throw new Exception("Invalid input");

                Random random = new Random();

                int[] array = new int[2 * n];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-100, 100);
                }

                int sumFirstN = 0;

                for (int i = 0; i < n; i++)
                {
                    sumFirstN += array[i];
                }

                int sumLastN = 0;

                for (int i = n; i < array.Length; i++)
                {
                    sumLastN += array[i];
                }

                // Output
                Console.WriteLine("Source array items: " + String.Join(' ', array));
                Console.WriteLine($"Frist {n} sum: {sumFirstN}");
                Console.WriteLine($"Last {n} sum: {sumLastN}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
