/* Вывести значения функции у = х^3 при х = 8, 7.5, …, 2. */

namespace Console_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] range = { 8, 2 };
            double step = 0.5;

            Console.WriteLine("{0, 5} |\t {1, 6}", "x", "y");
            Console.WriteLine(new string('—', 15));

            double x = 8;
            while (x >= 2)
            {
                double y = Math.Pow(x, 3);
                Console.WriteLine("{0, 5} |\t {1, 6}", string.Format("{0:N1}", x), string.Format("{0:N2}", y));
                x -= step;
            }
        }
    }
}
