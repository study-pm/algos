/* Если целое число М делится нацело на целое число N,
 * то вывести на экран частное от деления,
 * в противном случае сообщение «М на N не делится».
 */

namespace Console_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter integer M: ");
                int M = int.Parse(Console.ReadLine());

                Console.Write("Enter integer N: ");
                int N = int.Parse(Console.ReadLine());

                if (M % N == 0) Console.WriteLine("Quotient is: " + M / N);
                else Console.WriteLine("M is not divisble by N.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}
