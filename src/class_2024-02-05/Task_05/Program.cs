/* Массив содержит 2n чисел.
 * Из суммы первых n его элементов вычесть сумму последних n элементов.
 */

namespace Task_05
{
    public class Utils
    {
        public static int[] GetRandomIntArray(int length, int rangeFrom = -100, int rangeTo = 100)
        {
            Random random = new Random();

            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(rangeFrom, rangeTo);
            }
            return array;
        }
        public static bool CheckIfNotNegativeInt(string input, out int n)
        {
            bool isInt = int.TryParse(input, out int number);
            isInt = isInt && number >= 0;
            n = number;
            return isInt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Input
                Console.Write("Enter an integer non-negative number: ");
                string input = Console.ReadLine();
                int n;
                if (!Utils.CheckIfNotNegativeInt(input, out n)) throw new Exception("Invalid input");

                int[] array = Utils.GetRandomIntArray(2 * n);

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
