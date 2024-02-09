/* В массиве из 2n чисел найти сумму квадратов элементов с четными индексами и сумму кубов элементов с нечетными индексами.
 */

namespace Task_08
{
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
                if (!Task_05.Utils.CheckIfNotNegativeInt(input, out n)) throw new Exception("Invalid input");

                int[] array = Task_05.Utils.GetRandomIntArray(2 * n);

                int evensSumOfSquares = 0;
                int oddsSumOfCubes = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0) evensSumOfSquares += (int)Math.Pow((double)array[i], 2);
                    else oddsSumOfCubes += (int)Math.Pow((double)array[i], 3);
                }

                // Output
                Console.WriteLine("Source array items: " + String.Join(' ', array));
                Console.WriteLine("Array even items sum of squares: " + evensSumOfSquares.ToString("N0"));
                Console.WriteLine("Array odd items sum of cubes: " + oddsSumOfCubes.ToString("N0"));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
