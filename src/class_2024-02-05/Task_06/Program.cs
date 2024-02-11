/* Заменить отрицательные элементы в числовом массиве из n чисел (n>10) их квадратами, оставив остальные без изменения.
 */

namespace Task_06
{
    internal class Program
    {
        static bool CheckIfIntGreaterThan(string input, int count, out int n)
        {
            bool isInt = int.TryParse(input, out int number);
            isInt = isInt && number > count;
            n = number;
            return isInt;
        }
        static void Main(string[] args)
        {
            try
            {
                // Input
                Console.Write("Enter an integer greater than 10: ");
                string input = Console.ReadLine();
                int n;
                if (!CheckIfIntGreaterThan(input, 10, out n)) throw new Exception("Invalid input");

                Random random = new Random();

                int[] array = new int[n];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-100, 100);
                }

                // Output
                Console.WriteLine("Source array items: " + String.Join(' ', array));

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0) continue;
                    array[i] = (int)Math.Pow((double)array[i], 2);
                }

                // Output
                Console.WriteLine("Result array items: " + String.Join(' ', array));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
