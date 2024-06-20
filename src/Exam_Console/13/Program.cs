/* Даны три действительных числа.
 * Возвести в квадрат те из них, значения которых неотрицательны,
 * и в четвёртую степень – отрицательные
 */

namespace Console_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] range = { -100, 100 };

            int count = 4;

            double[] numbers = new double[count];
            double[] processed = new double[count];

            Console.WriteLine("{0, 6} \t {1, 15}", "x", "y");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.NextDouble() * (range[1] - range[0]) + range[0];
                processed[i] = Math.Pow(numbers[i], numbers[i] < 0 ? 4 : 2);
                Console.WriteLine("{0, 6} \t {1, 15}", string.Format("{0:N2}", numbers[i]), string.Format("{0:N2}", processed[i]));
            }
        }
    }
}
