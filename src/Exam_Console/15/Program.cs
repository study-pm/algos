/* Перераспределите значения переменных х и у так,
 * чтобы в х оказалось большее из этих значений, а в у меньшее.
 */

namespace Console_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Must be a valid number";
            try
            {
                Console.Write($"Enter x ({msg}): ");
                double x = double.Parse(Console.ReadLine());

                Console.Write($"Enter y ({msg}): ");
                double y = double.Parse(Console.ReadLine());
                if (x < y)
                {
                    (x, y) = (y, x);
                }
                Console.WriteLine("Result: x = {0}, y = {1}", x, y);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }
    }
}
